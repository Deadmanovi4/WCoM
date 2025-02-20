<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debug
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RankList = New System.Windows.Forms.ComboBox()
        Me.RadioTe = New System.Windows.Forms.RadioButton()
        Me.RadioSt = New System.Windows.Forms.RadioButton()
        Me.InputStID = New System.Windows.Forms.TextBox()
        Me.InputStName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LecPoints = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LecName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LecTime = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LecDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LecType = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LecStIDs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LecTeID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Points3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Type3 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TeID3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StID3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(642, 172)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.RankList)
        Me.TabPage1.Controls.Add(Me.RadioTe)
        Me.TabPage1.Controls.Add(Me.RadioSt)
        Me.TabPage1.Controls.Add(Me.InputStID)
        Me.TabPage1.Controls.Add(Me.InputStName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(634, 146)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Добавить\изменить участника"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Ранг"
        '
        'RankList
        '
        Me.RankList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RankList.FormattingEnabled = True
        Me.RankList.Items.AddRange(New Object() {"Новичек", "Ученик", "Адепт", "Эксперт", "Мастер"})
        Me.RankList.Location = New System.Drawing.Point(50, 50)
        Me.RankList.Name = "RankList"
        Me.RankList.Size = New System.Drawing.Size(121, 21)
        Me.RankList.TabIndex = 7
        '
        'RadioTe
        '
        Me.RadioTe.AutoSize = True
        Me.RadioTe.Location = New System.Drawing.Point(18, 114)
        Me.RadioTe.Name = "RadioTe"
        Me.RadioTe.Size = New System.Drawing.Size(104, 17)
        Me.RadioTe.TabIndex = 6
        Me.RadioTe.TabStop = True
        Me.RadioTe.Text = "Преподаватель"
        Me.RadioTe.UseVisualStyleBackColor = True
        '
        'RadioSt
        '
        Me.RadioSt.AutoSize = True
        Me.RadioSt.Location = New System.Drawing.Point(18, 91)
        Me.RadioSt.Name = "RadioSt"
        Me.RadioSt.Size = New System.Drawing.Size(62, 17)
        Me.RadioSt.TabIndex = 5
        Me.RadioSt.TabStop = True
        Me.RadioSt.Text = "Ученик"
        Me.RadioSt.UseVisualStyleBackColor = True
        '
        'InputStID
        '
        Me.InputStID.Location = New System.Drawing.Point(216, 51)
        Me.InputStID.Name = "InputStID"
        Me.InputStID.Size = New System.Drawing.Size(89, 20)
        Me.InputStID.TabIndex = 4
        '
        'InputStName
        '
        Me.InputStName.Location = New System.Drawing.Point(50, 14)
        Me.InputStName.Name = "InputStName"
        Me.InputStName.Size = New System.Drawing.Size(311, 20)
        Me.InputStName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Имя"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Добавить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LecPoints)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.LecName)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.LecTime)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.LecDate)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.LecType)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.LecStIDs)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.LecTeID)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(634, 146)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Регистрация лекции"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LecPoints
        '
        Me.LecPoints.Location = New System.Drawing.Point(588, 39)
        Me.LecPoints.Name = "LecPoints"
        Me.LecPoints.Size = New System.Drawing.Size(32, 20)
        Me.LecPoints.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(542, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Баллы"
        '
        'LecName
        '
        Me.LecName.Location = New System.Drawing.Point(15, 65)
        Me.LecName.Name = "LecName"
        Me.LecName.Size = New System.Drawing.Size(613, 20)
        Me.LecName.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Название лекции"
        '
        'LecTime
        '
        Me.LecTime.Location = New System.Drawing.Point(588, 11)
        Me.LecTime.Name = "LecTime"
        Me.LecTime.Size = New System.Drawing.Size(32, 20)
        Me.LecTime.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(542, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Время"
        '
        'LecDate
        '
        Me.LecDate.Location = New System.Drawing.Point(436, 10)
        Me.LecDate.Name = "LecDate"
        Me.LecDate.Size = New System.Drawing.Size(100, 20)
        Me.LecDate.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(397, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 39)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Дата" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           Формат дд\мм\гг"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Тема:"
        '
        'LecType
        '
        Me.LecType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LecType.FormattingEnabled = True
        Me.LecType.Items.AddRange(New Object() {"0 - Общая", "1 - Разрушение", "2 - Изменение", "3 - Иллюзия", "4 - Колдовство", "5 - Восстановление", "6 - Ритуалистика", "7 - Зачарование", "8 - Исследование", "9 - Алхимия"})
        Me.LecType.Location = New System.Drawing.Point(269, 10)
        Me.LecType.Name = "LecType"
        Me.LecType.Size = New System.Drawing.Size(121, 21)
        Me.LecType.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(509, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Регистрация"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LecStIDs
        '
        Me.LecStIDs.Location = New System.Drawing.Point(103, 91)
        Me.LecStIDs.Name = "LecStIDs"
        Me.LecStIDs.Size = New System.Drawing.Size(525, 20)
        Me.LecStIDs.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 39)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID слушателей" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(через запятую, без решеток '#')"
        '
        'LecTeID
        '
        Me.LecTeID.Location = New System.Drawing.Point(120, 11)
        Me.LecTeID.Name = "LecTeID"
        Me.LecTeID.Size = New System.Drawing.Size(100, 20)
        Me.LecTeID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID преподавателя"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Points3)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Type3)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Name3)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TeID3)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.StID3)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(634, 146)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Регистрация исследования"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Points3
        '
        Me.Points3.Location = New System.Drawing.Point(288, 105)
        Me.Points3.Name = "Points3"
        Me.Points3.Size = New System.Drawing.Size(100, 20)
        Me.Points3.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(242, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Баллы"
        '
        'Type3
        '
        Me.Type3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type3.FormattingEnabled = True
        Me.Type3.Items.AddRange(New Object() {"0 - Общая", "1 - Разрушение", "2 - Изменение", "3 - Иллюзия", "4 - Колдовство", "5 - Восстановление", "6 - Ритуалистика", "7 - Зачарование", "8 - Исследование", "9 - Алхимия"})
        Me.Type3.Location = New System.Drawing.Point(95, 104)
        Me.Type3.Name = "Type3"
        Me.Type3.Size = New System.Drawing.Size(121, 21)
        Me.Type3.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Направление"
        '
        'Name3
        '
        Me.Name3.Location = New System.Drawing.Point(17, 71)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(601, 20)
        Me.Name3.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(256, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Тема исследования"
        '
        'TeID3
        '
        Me.TeID3.Location = New System.Drawing.Point(286, 12)
        Me.TeID3.Name = "TeID3"
        Me.TeID3.Size = New System.Drawing.Size(100, 20)
        Me.TeID3.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(198, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Принял работу"
        '
        'StID3
        '
        Me.StID3.Location = New System.Drawing.Point(81, 12)
        Me.StID3.Name = "StID3"
        Me.StID3.Size = New System.Drawing.Size(100, 20)
        Me.StID3.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ID ученика"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(545, 107)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 36)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Регистрация"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Открыть папку с файлом"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 213)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Debug"
        Me.Text = "Окно записи"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RadioTe As RadioButton
    Friend WithEvents RadioSt As RadioButton
    Friend WithEvents InputStID As TextBox
    Friend WithEvents InputStName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents LecStIDs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LecTeID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LecDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LecType As ComboBox
    Friend WithEvents LecName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LecTime As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LecPoints As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RankList As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents StID3 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Points3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Type3 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Name3 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TeID3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button4 As Button
End Class
