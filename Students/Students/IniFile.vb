Imports System.Text
Imports System.Runtime.InteropServices

Public Class IniFile

    Const KEY_BUFFER_SIZE As Integer = 2047        'размер буфера для значения ключа
    Const SECTION_BUFFER_SIZE As Integer = 16384   'размер буфера для считывания секций

    Dim _fileName As String

#Region "Свойства"
    Public ReadOnly Property FileName() As String
        Get
            Return _fileName
        End Get
    End Property
#End Region


#Region "Публичные методы"
    Public Sub New(ByVal FileName As String)
        CreateFolders()
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Void\SkyrimRP\"
        FileName = Replace(FileName, path, "")
        _fileName = path + FileName
    End Sub

    'создать папки
    Private Sub CreateFolders()
        Dim fullpath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Void\SkyrimRP"
        If IO.Directory.Exists(fullpath) = False Then
            IO.Directory.CreateDirectory(fullpath)
        End If
    End Sub


    'считываем названия всех секций
    Public Function ReadSections() As String()
        'получаем строку секций с разделителем vbNullChar секций
        Dim strSections As String = InternalReadString(Nothing, Nothing, "", EIniAtoms.Section)
        If strSections = "" Then Return New String(-1) {}
        'получаем массив секций (с разделителями через Chr(0))
        Return strSections.ToString.Split(vbNullChar)
    End Function

    'считывание названий ключей заданной секции
    Public Function ReadSection(ByVal Section As String) As String()
        'получаем строку ключей с разделителем vbNullChar ключей
        Dim strKeys As String = InternalReadString(Section, Nothing, "", EIniAtoms.Section)
        If strKeys = "" Then Return New String(-1) {}
        'получаем массив ключей (с разделителями через Chr(0))
        Return strKeys.ToString.Split(vbNullChar)

    End Function

    'получение значений всех ключей для заданной секции в формате Ключ=значение
    Public Function ReadSectionValues(ByVal Section As String) As Hashtable
        Dim KeyValueHash As New Hashtable
        'получаем все ключи секции
        Dim keys() As String = ReadSection(Section)
        'создаем хэш-таблицу пар Ключ=значение
        For Each key As String In keys
            'для каждого ключа
            KeyValueHash(key) = InternalReadString(Section, key, "", EIniAtoms.Key)
        Next
        Return KeyValueHash
    End Function

    Public Function ReadString(ByVal Section As String, ByVal Key As String) As String
        Return ReadString(Section, Key, "")
    End Function
    Public Function ReadString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String) As String
        Return InternalReadString(Section, Key, [Default], EIniAtoms.Key)
    End Function

    Public Function ReadInt32(ByVal Section As String, ByVal Key As String) As Integer
        Return Convert.ToInt32(ReadString(Section, Key))
    End Function
    Public Function ReadInt32(ByVal Section As String, ByVal Key As String, ByVal [Default] As Integer) As Integer
        Return Convert.ToInt32(ReadString(Section, Key, Convert.ToString([Default])))
    End Function

    Public Function ReadInt64(ByVal Section As String, ByVal Key As String) As Int64
        Return Convert.ToInt64(ReadString(Section, Key))
    End Function

    Public Function ReadDouble(ByVal Section As String, ByVal Key As String) As Double
        Return Convert.ToDouble(ReadString(Section, Key))
    End Function

    Public Function ReadByte(ByVal Section As String, ByVal Key As String) As Byte
        Return Convert.ToByte(ReadString(Section, Key))
    End Function

    Public Function ReadDate(ByVal Section As String, ByVal Key As String) As Date
        Return Convert.ToDateTime(ReadString(Section, Key))
    End Function

    Public Function ReadBool(ByVal Section As String, ByVal Key As String) As Boolean
        Return Convert.ToBoolean(ReadString(Section, Key))
    End Function
    Public Function ReadBool(ByVal Section As String, ByVal Key As String, ByVal [Default] As Boolean) As Boolean
        Return Convert.ToBoolean(ReadString(Section, Key, Convert.ToString([Default])))
    End Function

    'записывает значения секции по ключу в ReturnedValue
    'возвращает true, если было что-то прочитано
    Public Function ReadString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String, ByRef ReturnedValue$) As Boolean
        Return InternalReadString(Section, Key, [Default], ReturnedValue, EIniAtoms.Key)
    End Function

    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As String)
        If NativeMethods.WritePrivateProfileString(Section, Key, Value, _fileName) = 0 Then
            GenerateError()
        End If
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Int32)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Int64)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Double)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Byte)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Char)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Boolean)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Date)
        Write(Section, Key, Convert.ToString(Value))
    End Sub
    Public Sub Write(ByVal Section As String, ByVal Key As String, ByVal Value As Object)
        Write(Section, Key, Convert.ToString(Value))
    End Sub

    'запись значений , которые хранятся в формате Ключ=значение в хэш-таблице
    Public Sub Write(ByVal Section As String, ByVal Values As Hashtable)
        For Each de As DictionaryEntry In Values
            Write(Section, de.Key, de.Value)
        Next
    End Sub

    'удаление секции
    Public Sub EraseSection(ByVal Section As String)
        If NativeMethods.WritePrivateProfileString(Section, Nothing, Nothing, Me._fileName) = 0 Then
            GenerateError()
        End If
    End Sub

    'удаление ключа
    Public Sub DeleteKey(ByVal Section As String, ByVal Key As String)
        If NativeMethods.WritePrivateProfileString(Section, Key, Nothing, Me._fileName) = 0 Then
            GenerateError()
        End If
    End Sub
#End Region

#Region "Приватные методы"
    Private Enum EIniAtoms
        Key
        Section
    End Enum

    Private Function InternalReadString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String, ByRef ReturnedValue As String, ByVal IniAtom As EIniAtoms) As Boolean
        ReturnedValue = New String(vbNullChar, SECTION_BUFFER_SIZE)
        Dim readed As Int32 = NativeMethods.GetPrivateProfileString(Section, Key, [Default], ReturnedValue, GetBufferSize(IniAtom), Me._fileName)
        If readed > 0 Then
            If ReturnedValue.Chars(readed - 1) = Nothing Then
                ReturnedValue = ReturnedValue.Substring(0, readed - 1)
            Else
                ReturnedValue = ReturnedValue.Substring(0, readed)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Private Function InternalReadString(ByVal Section As String, ByVal Key As String, ByVal [Default] As String, ByVal IniAtom As EIniAtoms) As String
        Dim ret As String = String.Empty
        If InternalReadString(Section, Key, [Default], ret, IniAtom) Then
            Return ret
        Else
            Return ""
        End If
    End Function

    Private Function GetBufferSize(ByVal IniAtom As EIniAtoms) As Integer
        Select Case IniAtom
            Case EIniAtoms.Key
                Return KEY_BUFFER_SIZE
            Case EIniAtoms.Section
                Return SECTION_BUFFER_SIZE
            Case Else
                Return -1
        End Select
    End Function

    Private Sub GenerateError()
        Throw New Exception(String.Format("Невозможно выполнить оперцию! Внутренний код ошибки [{0}]", NativeMethods.GetLastError))
    End Sub
#End Region

End Class







Friend NotInheritable Class NativeMethods

    Private Sub New()
    End Sub

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileSection(
        ByVal lpAppName As String,
        ByVal lpReturnedString As String,
        ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileSectionNames(
        ByVal lpszReturnBuffer As String,
        ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileString(
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As String,
        ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileString(
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As IntPtr,
        ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileString(
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As StringBuilder,
        ByVal nSize As Int32,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetPrivateProfileStruct(
        ByVal lpszSection As String,
        ByVal lpszKey As String,
        ByVal lpStruct As IntPtr,
        ByVal uSizeStruct As Int32,
        ByVal szFile As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function WritePrivateProfileSection(
        ByVal lpAppName As String,
        ByVal lpString As String,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function WritePrivateProfileString(
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpString As String,
        ByVal lpFileName As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function WritePrivateProfileStruct(
        ByVal lpszSection As String,
        ByVal lpszKey As String,
        ByVal lpStruct As IntPtr,
        ByVal uSizeStruct As Int32,
        ByVal szFile As String) As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Function GetLastError() As Int32
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, BestFitMapping:=False, ThrowOnUnmappableChar:=True)>
    Friend Shared Sub SetLastError(ByVal err As Int32)
    End Sub
End Class