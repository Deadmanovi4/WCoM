Public Class Debug

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNothing(InputStID.Text) = True Or IsNothing(InputStName.Text) = True Or IsNothing(RankList.Text) = True Then
            MsgBox("Все поля должны быть заполнены")
            Exit Sub
        End If
        If RadioSt.Checked <> False And RadioTe.Checked <> False Then
            MsgBox("Выберите тип ученик\преподаватель")
            Exit Sub
        End If
        Start.INI.Write(InputStID.Text, "Name", InputStName.Text)
        If RadioSt.Checked Then
            Start.INI.Write(InputStID.Text, "Type", "ST")
        Else
            Start.INI.Write(InputStID.Text, "Type", "TE")
        End If
        Start.INI.Write(InputStID.Text, "Rank", RankList.SelectedIndex)
        MsgBox("Добавлено успешно")
        Start.LoadData()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNothing(LecTeID.Text) Then
            MsgBox("ID преподавателя не указан")
            Exit Sub
        End If
        If Start.INI.ReadString(LecTeID.Text, "Type", "") <> "TE" Then
            MsgBox("Игрок '" & LecTeID.Text & "' не является преподавателем или не зарегистрирован как преподаватель")
            Exit Sub
        End If
        If IsNothing(LecType.Text) Then
            MsgBox("Тема не выбрана")
            Exit Sub
        End If
        If IsNothing(LecDate.Text) Then
            MsgBox("Дата не указана")
            Exit Sub
        End If
        If IsNothing(LecTime.Text) Then
            MsgBox("Час провдения лекции не указан")
            Exit Sub
        ElseIf IsNumeric(LecTime.Text) <> True Then
            MsgBox("Время проведения не является числом")
            Exit Sub
        Else
            If LecTime.Text < 0 Or LecTime.Text > 23 Then
                MsgBox("Время проведения выходит за рамки времени и пространства")
                Exit Sub
            End If
        End If
        If IsNothing(LecStIDs.Text) Then
            MsgBox("Слушателей нет?")
            Exit Sub
        End If
        If IsNothing(LecName.Text) Then
            MsgBox("Название лекции не указано")
            Exit Sub
        End If
        Dim stcount As Integer = 0
        Dim LectDate() As String = LecDate.Text.Split("\")
        Dim output As String = ""
        For Each value As String In LectDate
            If IsNumeric(value) <> True Then
                MsgBox("Дата не является числом")
                Exit Sub
            End If
        Next
        For Each item As String In LecStIDs.Text.Split(",")
            output = LecPoints.Text & ";" & LecType.SelectedIndex & ";" & LecName.Text & ";" & LectDate(0) & ";" & LectDate(1) & ";" & LectDate(2) & ";" & LecTime.Text & ";" & LecTeID.Text
            If Start.INI.ReadString(item, "Type", "") = "ST" Then
                Start.INI.Write(item, CStr(getNumber(item)), output)
            End If
            stcount += 1
        Next
        output = LecType.SelectedIndex & ";" & LecName.Text & ";" & LectDate(0) & ";" & LectDate(1) & ";" & LectDate(2) & ";" & LecTime.Text & ";" & stcount
        Start.INI.Write(LecTeID.Text, CStr(getNumber(LecTeID.Text)), output)
        MsgBox("Зарегистрировано")
    End Sub
    Private Function getNumber(ID As String) As Integer
        Dim ininum As Integer = 1
        Do While True
            If Start.INI.ReadString(ID, ininum, "") = "" Then
                Return ininum
            End If
            ininum += 1
        Loop
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNothing(StID3.Text) = True Or IsNothing(TeID3.Text) = True Or IsNothing(Name3.Text) = True Or IsNothing(Type3.Text) = True Or IsNothing(Points3.Text) = True Then
            MsgBox("Все поля должны быть заполнены")
            Exit Sub
        End If
        If Start.INI.ReadString(TeID3.Text, "Type", "") <> "TE" Then
            MsgBox("Игрок '" & TeID3.Text & "' не является преподавателем или не зарегистрирован как преподаватель")
            Exit Sub
        End If
        If Start.INI.ReadString(StID3.Text, "Type", "") <> "ST" Then
            MsgBox("Игрок '" & StID3.Text & "' не обучается в Колегии или не зарегистрирован как ученик")
            Exit Sub
        End If
        Dim output As String
        output = Points3.Text & ";" & Type3.SelectedIndex & ";" & Name3.Text & ";" & TeID3.Text
        Start.INI.Write(StID3.Text, CStr(getNumber(StID3.Text)), output)
        output = Type3.SelectedIndex & ";" & Name3.Text & ";" & StID3.Text
        Start.INI.Write(TeID3.Text, CStr(getNumber(TeID3.Text)), output)
        MsgBox("Зарегистрировано")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(Start.dwnpth)
    End Sub

    Private Sub InputStID_TextChanged(sender As Object, e As EventArgs) Handles InputStID.TextChanged
        If CheckDB.Checked Then
            If Start.INI.ReadString(InputStID.Text, "Name", "") <> "" Then
                InputStName.Text = Start.INI.ReadString(InputStID.Text, "Name")
                RankList.SelectedIndex = Start.INI.ReadInt32(InputStID.Text, "Rank")
                Select Case Start.INI.ReadString(InputStID.Text, "Type")
                    Case "ST"
                        RadioSt.Checked = True
                    Case "TE"
                        RadioTe.Checked = True
                End Select
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim temp As String = Start.INI.ReadString(InputStID.Text, "Name", "")
        If temp <> "" Then
            Dim dr As DialogResult = MsgBox("Это действие удалит все записи игрока '" & temp & "'. Продолжить?",
                                        MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                                        "Удаление записей")

            Select Case dr
                Case DialogResult.Yes
                    Start.INI.EraseSection(InputStID.Text)
                    Start.LoadData()
                Case DialogResult.No
                    'nothing
            End Select
        Else
            MsgBox("Записи по данному ID не найдены")
        End If
    End Sub
End Class