Imports System.Net
Imports Microsoft.VisualBasic.Logging

Public Class Start
    'Вставьте прямую ссылку ниже
    Dim Link As String = "https://github.com/Deadmanovi4/WCoM/raw/refs/heads/main/WCoM.ini"

    Public CINI As New IniFile("Config.ini")
    Public INI As New IniFile("WCoM.ini")
    Dim tmppth As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Void"
    Public dwnpth As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Void\SkyrimRP\"
    Public Debugmode As Boolean = CINI.ReadBool("Void", "Debug", False)
    Dim WithEvents DC As New WebClient
    Dim SelectedStudent As Integer
    Dim SelectedTeacher As Integer
    Dim StudentsList, TeachersList As New List(Of String)
    Dim STCompiler, TECompiler As New List(Of String)
    Public LecTypes As String() =
        {"Общее", "Разрушение", "Изменение", "Иллюзия", "Колдовство",
        "Восстановление", "Ритуалистика", "Зачарование", "Исследование", "Алхимия"}
    Public Ranks As String() = {"Новичек", "Ученик", "Адепт", "Эксперт", "Мастер"}

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Debugmode <> True Then
            Lab_Debug.Hide()
        End If
        LoadData()
    End Sub


#Region "Updater"
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Label1.Click
        DownFile(Link, "WCoM.ini")
        LoadData()
    End Sub
    Public Sub DownFile(link As String, name As String)
        Try
            DC.DownloadFile(New Uri(link), dwnpth & name)
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Compiler"
    Private Sub LoadData()
        StudentList.Items.Clear()
        TeacherList.Items.Clear()
        StudentsList.Clear()
        TeachersList.Clear()
        StudentsOutput.Text = ""
        TeacherOutput.Text = ""
        Dim stcount As Integer = 1
        Dim tecount As Integer = 1
        For Each ID As String In INI.ReadSections()
            If INI.ReadString(ID, "type", "") = "ST" Then
                StudentList.Items.Add(stcount & ". " & INI.ReadString(ID, "name", "Неизвестно"))
                StudentsList.Add(ID)
                stcount += 1
            ElseIf INI.ReadString(ID, "type", "") = "TE" Then
                TeacherList.Items.Add(tecount & ". " & INI.ReadString(ID, "name", "Неизвестно"))
                TeachersList.Add(ID)
                tecount += 1
            End If
        Next
    End Sub


    Private Sub SelectSTData(ID As String)
        STCompiler.Clear()
        Dim Points() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim Splitter As String()
        STCompiler.Add(INI.ReadString(ID, "Name", "Неизвестно") & " (" & CStr(ID) & ")" & vbNewLine & vbNewLine & "Ранг: " & GetRank(INI.ReadString(ID, "Rank", "Неизвестно")) & vbNewLine)
        STCompiler.Add("") '1
        STCompiler.Add("") '2
        For Each item In INI.ReadSection(ID)
            Splitter = INI.ReadString(ID, CStr(item)).Split(";")
            If Splitter.Count = 4 Then
                STCompiler(1) += ("(" & LecTypes(Splitter(1)) & ") ")
                STCompiler(1) += ("'" & Splitter(2) & "'." & " Работу принял: " & INI.ReadString(Splitter(3), "Name", "Неизвестно") & ".")
                If Splitter(0) <> 0 Then
                    Points(Splitter(1)) += Splitter(0)
                    STCompiler(1) += " Начислено: " & Splitter(0) & " балл(ов)"
                End If
                STCompiler(1) += vbNewLine
            End If
            If Splitter.Count = 8 Then
                Points(Splitter(1)) += Splitter(0)
                STCompiler(2) += ("(" & LecTypes(Splitter(1)) & ") ")
                STCompiler(2) += ("'" & Splitter(2) & "', " & DateChange(Splitter(3), Splitter(4)) & " (" & Splitter(5) & ") в " & Splitter(6) & ":00. Преподаватель: " & INI.ReadString(Splitter(7), "Name", "Неизвестно") & vbNewLine)
            End If
        Next
        StudentsOutput.Text = STCompiler(0) & vbNewLine

        Dim var2 As Integer = 0
        Dim odd As Boolean = False
        For Each item In Points
            If item <> 0 Then
                StudentsOutput.Text += LecTypes(var2) & ": " & item & " балл(ов)"
                If odd Then
                    StudentsOutput.Text += vbNewLine
                    odd = False
                Else
                    StudentsOutput.Text += "        "
                    odd = True
                End If
            End If
            var2 += 1
        Next
        StudentsOutput.Text += vbNewLine & vbNewLine & "Проводил исследования:" & vbNewLine & STCompiler(1)
        StudentsOutput.Text += vbNewLine & vbNewLine & "Участвовал в лекциях:" & vbNewLine & STCompiler(2)
    End Sub
    Private Sub SelectTEData(ID As String)
        TECompiler.Clear()
        Dim Splitter As String()
        TECompiler.Add(INI.ReadString(ID, "Name", "Неизвестно") & " (" & CStr(ID) & ")" & vbNewLine & vbNewLine & "Ранг: " & GetRank(INI.ReadString(ID, "Rank", "Неизвестно")) & vbNewLine)
        TECompiler.Add("") '1
        TECompiler.Add("") '2
        For Each item In INI.ReadSection(ID)
            Splitter = INI.ReadString(ID, CStr(item)).Split(";")
            If Splitter.Count = 3 Then
                TECompiler(1) += ("(" & LecTypes(Splitter(0)) & ") ")
                TECompiler(1) += ("'" & Splitter(1) & "'." & "За авторством: " & INI.ReadString(Splitter(2), "Name", "Неизвестно") & vbNewLine)
            End If
            If Splitter.Count = 7 Then
                TECompiler(2) += ("(" & LecTypes(Splitter(0)) & ") ")
                TECompiler(2) += ("'" & Splitter(1) & "', " & DateChange(Splitter(2), Splitter(3)) & " (" & Splitter(4) & ") в " & Splitter(5) & ":00. Кол-во слушателей: " & Splitter(6) & vbNewLine)
            End If
        Next
        TeacherOutput.Text = TECompiler(0) & vbNewLine
        TeacherOutput.Text += vbNewLine & vbNewLine & "Принял исследования:" & vbNewLine & TECompiler(1)
        TeacherOutput.Text += vbNewLine & vbNewLine & "Проводил лекции:" & vbNewLine & TECompiler(2)
    End Sub
    Private Function DateChange(day As Integer, month As Integer) As String
        Dim output As String = CStr(day) & " числа "
        Select Case month
            Case 1
                output += "Утренней звезды"
            Case 2
                output += "Восхода солнца"
            Case 3
                output += "Первого зерна"
            Case 4
                output += "Руки дождя"
            Case 5
                output += "Второго зерна"
            Case 6
                output += "Середины года"
            Case 7
                output += "Высокого солнца"
            Case 8
                output += "Последнего зерна"
            Case 9
                output += "Огня очага"
            Case 10
                output += "Начала морозов"
            Case 11
                output += "Заката солнца"
            Case 12
                output += "Вечерней звезды"
            Case Else
                output += "Предела пустоты"
        End Select
        Return output
    End Function
    Private Function GetRank(val As String)
        If val = "Неизвестно" Then
            Return val
        Else
            Return Ranks(CInt(val))
        End If
    End Function

#End Region
#Region "Buttons"
    Private Sub Lab_Debug_Click(sender As Object, e As EventArgs) Handles Lab_Debug.Click
        Debug.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox("О программе:" & vbNewLine & vbNewLine & "Автор: Revenore, Рев Ловец-Сокрытого" & vbNewLine & "Discord\Telegram: revenore")
    End Sub



    Private Sub StudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentList.SelectedIndexChanged
        If IsNumeric(StudentList.SelectedIndex) Then
            SelectSTData(StudentsList.Item(StudentList.SelectedIndex))
        End If
    End Sub
    Private Sub TeacherList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TeacherList.SelectedIndexChanged
        If IsNumeric(TeacherList.SelectedIndex) Then
            SelectTEData(TeachersList.Item(TeacherList.SelectedIndex))
        End If
    End Sub

#End Region
End Class
