Imports System.Net

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
    Dim StudentsList, TeachersList, DeletedList As New List(Of String)
    Dim STCompiler, TECompiler, DECompiler As New List(Of String)
    Public LecTypes As String() =
        {"Общее", "Разрушение", "Изменение", "Иллюзия", "Колдовство",
        "Восстановление", "Ритуалистика", "Зачарование", "Исследование", "Алхимия"}
    Public Ranks As String() = {"Новичок 1 ст", "Новичок 2 ст", "Новичок 3 ст", "Ученик 1 ст", "Ученик 2 ст", "Адепт", "Эксперт", "Мастер"}
    Public LimitP As Integer() = {25, 55, 85, 115, 145, 185, 225, -1}
    Public LimitRT As Integer() = {-1, -1, 5, 10, 15, 25, 40, 60}

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Debugmode <> True Then
            Lab_Debug.Hide()
        End If
        'Updater()
        LoadData()
    End Sub

    Private Sub Updater()
        DownFile(Link, "WCoM.ini")
        LoadData()
    End Sub
#Region "Updater"
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Updater()
    End Sub
    Public Sub DownFile(link As String, name As String)
        Try
            DC.DownloadFile(New Uri(link), dwnpth & name)
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "Compiler"
    Public Sub LoadData()
        StudentList.Items.Clear()
        TeacherList.Items.Clear()
        DEList.Items.Clear()
        StudentsList.Clear()
        TeachersList.Clear()
        DeletedList.Clear()
        StudentsOutput.Text = ""
        TeacherOutput.Text = ""
        DEOutput.Text = ""
        Dim stcount As Integer = 1
        Dim tecount As Integer = 1
        Dim decount As Integer = 1
        For Each ID As String In INI.ReadSections()
            Select Case INI.ReadString(ID, "type", "")
                Case "ST"
                    StudentList.Items.Add(stcount & ". " & INI.ReadString(ID, "name", "Неизвестно"))
                    StudentsList.Add(ID)
                    stcount += 1
                Case "TE"
                    TeacherList.Items.Add(tecount & ". " & INI.ReadString(ID, "name", "Неизвестно"))
                    TeachersList.Add(ID)
                    tecount += 1
                Case "DE"
                    DEList.Items.Add(decount & ". " & INI.ReadString(ID, "name", "Неизвестно"))
                    DeletedList.Add(ID)
                    decount += 1
                Case Else
                    'nothing
            End Select
        Next
    End Sub

    Public Function GetPoints(ID As String, Optional type As Integer = -1) As Integer
        Dim Points() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim Psumm As Integer = 0
        Dim Splitter As String()
        For Each item In INI.ReadSection(ID)
            Splitter = INI.ReadString(ID, CStr(item)).Split(";")
            If Splitter.Count = 8 Then
                Points(Splitter(1)) += Splitter(0)
                Psumm += Splitter(0)
            End If
            If Splitter.Count = 4 Then
                Points(Splitter(1)) += Splitter(0)
                Psumm += Splitter(0)
            End If
        Next
        If type <> -1 Then
            Return Points(type)
        End If
        Return Psumm
    End Function
    Private Sub SelectSTData(ID As String)
        STCompiler.Clear()
        Dim Points() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim PR_time As Integer = 0
        Dim errors As Integer
        Dim Splitter As String()
        STCompiler.Add(INI.ReadString(ID, "Name", "Неизвестно") & " (" & CStr(ID) & ")" & vbNewLine & vbNewLine & "Ранг: " & GetRank(INI.ReadString(ID, "Rank", "Неизвестно")) & vbNewLine)
        STCompiler.Add("") '1
        STCompiler.Add("") '2
        STCompiler.Add("") '3
        For Each item In INI.ReadSection(ID)
            errors = 0
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
            If Splitter.Count = 5 Then
                If IsNumeric(Splitter(0)) <> True Then
                    errors = 1 'Проверка на числовое значение
                End If
                If errors = 0 Then
                    If Splitter(0) <= 0 Then
                        errors = 1 'Проверка на положительное число после проверки на числовое значение
                    End If
                End If
                If errors = 0 Then
                    PR_time += Splitter(0)
                    STCompiler(3) += (DateChange(Splitter(1), Splitter(2)) & " (" & Splitter(3) & "). Длилась часов: " & Splitter(0) & ". Проверил: " & INI.ReadString(Splitter(4), "Name", "Неизвестно") & vbNewLine)
                End If
            End If
        Next
        If Debug.getNumber(ID, "warn") > 1 Then
            STCompiler(0) += vbNewLine & "У игрока есть предупреждения: " & Debug.getNumber(ID, "warn") - 1 & vbNewLine
        End If
        Dim rank As Integer = INI.ReadInt32(ID, "Rank", 0)
        If rank <> 7 Then
            STCompiler(0) += vbNewLine & "Для следующего ранга требуется:"
            If GetPoints(ID) >= LimitP(rank) Then
                STCompiler(0) += vbNewLine & "Достигнут лимит баллов для данного ранга. Требуется аттестация."
            Else
                STCompiler(0) += vbNewLine & "Баллы: " & GetPoints(ID) & " из " & LimitP(rank) & " доступных на этом ранге"
            End If
            If LimitRT(rank) = -1 Then
                STCompiler(0) += vbNewLine & "Практика не требуется для повышения ранга."
            Else
                STCompiler(0) += vbNewLine & "Проведено " & PR_time & " часов практики из " & LimitRT(rank) & " необходимых."
            End If
            If PR_time > LimitRT(rank) And rank > 1 Then
                STCompiler(0) += vbNewLine & "Свободные баллы из-за переработок: " & (PR_time - LimitRT(rank)) \ 2
            End If
        Else
            STCompiler(0) += vbNewLine & "Достигнут максимальный ранг."
        End If

        StudentsOutput.Text = STCompiler(0) & vbNewLine & vbNewLine

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
        StudentsOutput.Text += vbNewLine & vbNewLine & "Практические занятия:" & vbNewLine & STCompiler(3)
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
        If Debug.getNumber(ID, "warn") > 1 Then
            TECompiler(0) += vbNewLine & "У игрока есть предупреждения: " & Debug.getNumber(ID, "warn") - 1 & vbNewLine
        End If
        TeacherOutput.Text = TECompiler(0) & vbNewLine
        TeacherOutput.Text += vbNewLine & vbNewLine & "Принял исследования:" & vbNewLine & TECompiler(1)
        TeacherOutput.Text += vbNewLine & vbNewLine & "Проводил лекции:" & vbNewLine & TECompiler(2)
    End Sub
    Private Sub SelectDEData(ID As String)
        DECompiler.Clear()
        Dim Splitter As String()
        Dim a = 0
        Dim b = Debug.getNumber(ID, "warn") - 1
        DECompiler.Add(INI.ReadString(ID, "Name", "Неизвестно") & " (" & CStr(ID) & ")" & vbNewLine & vbNewLine & "Ранг: " & GetRank(INI.ReadString(ID, "Rank", "Неизвестно")) & vbNewLine)

        DECompiler(0) += vbNewLine & "Причина исключения: " & INI.ReadString(ID, "Banned", "не указано") & vbNewLine & "Выданные варны:"
        Do While a <= b
            Splitter = INI.ReadString(ID, "Warn" & CStr(a), "").Split("&")
            If Splitter.Count = 5 Then
                DECompiler(0) += vbNewLine & "Варн " & a & ": " & Splitter(0) & ", выдан '" & INI.ReadString(Splitter(1), "Name", "Неизвестно") & "' " & DateChange(Splitter(2), Splitter(3)) & " " & Splitter(4)
            End If
            a += 1
        Loop
        DEOutput.Text = DECompiler(0) & vbNewLine
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

    Private Sub SearchST_TextChanged(sender As Object, e As EventArgs) Handles SearchST.TextChanged
        If INI.ReadString(SearchST.Text, "Type", "") = "ST" Then
            SelectSTData(SearchST.Text)
        End If
    End Sub

    Private Sub SearchTe_TextChanged(sender As Object, e As EventArgs) Handles SearchTe.TextChanged
        If INI.ReadString(SearchTe.Text, "Type", "") = "TE" Then
            SelectTEData(SearchTe.Text)
        End If
    End Sub

    Private Sub SearchDE_TextChanged(sender As Object, e As EventArgs) Handles SearchDE.TextChanged
        If INI.ReadString(SearchDE.Text, "Type", "") = "DE" Then
            SelectDEData(SearchDE.Text)
        End If
    End Sub

    Private Sub DEBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DEList.SelectedIndexChanged
        If DEList.SelectedIndex <> -1 Then
            SelectDEData(DeletedList.Item(DEList.SelectedIndex))
        End If
    End Sub

    Private Sub StudentList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentList.SelectedIndexChanged
        If StudentList.SelectedIndex <> -1 Then
            SelectSTData(StudentsList.Item(StudentList.SelectedIndex))
        End If
    End Sub
    Private Sub TeacherList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TeacherList.SelectedIndexChanged
        If TeacherList.SelectedIndex <> -1 Then
            SelectTEData(TeachersList.Item(TeacherList.SelectedIndex))
        End If
    End Sub

#End Region
End Class
