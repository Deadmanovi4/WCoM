<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.Lab_Debug = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SearchTe = New System.Windows.Forms.TextBox()
        Me.TeacherOutput = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TeacherList = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SearchST = New System.Windows.Forms.TextBox()
        Me.StudentsOutput = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StudentList = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SearchDE = New System.Windows.Forms.TextBox()
        Me.DEOutput = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DEList = New System.Windows.Forms.ListBox()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lab_Debug
        '
        Me.Lab_Debug.AutoSize = True
        Me.Lab_Debug.Location = New System.Drawing.Point(312, 9)
        Me.Lab_Debug.Name = "Lab_Debug"
        Me.Lab_Debug.Size = New System.Drawing.Size(69, 13)
        Me.Lab_Debug.TabIndex = 0
        Me.Lab_Debug.Text = "Меню ввода"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Обновить"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(755, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Void 2025"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SearchTe)
        Me.TabPage2.Controls.Add(Me.TeacherOutput)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TeacherList)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Преподаватели"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SearchTe
        '
        Me.SearchTe.Location = New System.Drawing.Point(65, 6)
        Me.SearchTe.Name = "SearchTe"
        Me.SearchTe.Size = New System.Drawing.Size(100, 20)
        Me.SearchTe.TabIndex = 5
        '
        'TeacherOutput
        '
        Me.TeacherOutput.Location = New System.Drawing.Point(263, 6)
        Me.TeacherOutput.Name = "TeacherOutput"
        Me.TeacherOutput.ReadOnly = True
        Me.TeacherOutput.Size = New System.Drawing.Size(531, 509)
        Me.TeacherOutput.TabIndex = 2
        Me.TeacherOutput.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Поиск ID"
        '
        'TeacherList
        '
        Me.TeacherList.FormattingEnabled = True
        Me.TeacherList.Location = New System.Drawing.Point(5, 30)
        Me.TeacherList.Name = "TeacherList"
        Me.TeacherList.Size = New System.Drawing.Size(252, 485)
        Me.TeacherList.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SearchST)
        Me.TabPage1.Controls.Add(Me.StudentsOutput)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.StudentList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ученики"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SearchST
        '
        Me.SearchST.Location = New System.Drawing.Point(65, 6)
        Me.SearchST.Name = "SearchST"
        Me.SearchST.Size = New System.Drawing.Size(100, 20)
        Me.SearchST.TabIndex = 3
        '
        'StudentsOutput
        '
        Me.StudentsOutput.Location = New System.Drawing.Point(263, 6)
        Me.StudentsOutput.Name = "StudentsOutput"
        Me.StudentsOutput.ReadOnly = True
        Me.StudentsOutput.Size = New System.Drawing.Size(531, 509)
        Me.StudentsOutput.TabIndex = 1
        Me.StudentsOutput.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Поиск ID"
        '
        'StudentList
        '
        Me.StudentList.FormattingEnabled = True
        Me.StudentList.Location = New System.Drawing.Point(6, 32)
        Me.StudentList.Name = "StudentList"
        Me.StudentList.Size = New System.Drawing.Size(251, 485)
        Me.StudentList.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 547)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SearchDE)
        Me.TabPage3.Controls.Add(Me.DEOutput)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.DEList)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(800, 521)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Отчисленные"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SearchDE
        '
        Me.SearchDE.Location = New System.Drawing.Point(65, 5)
        Me.SearchDE.Name = "SearchDE"
        Me.SearchDE.Size = New System.Drawing.Size(100, 20)
        Me.SearchDE.TabIndex = 7
        '
        'DEOutput
        '
        Me.DEOutput.Location = New System.Drawing.Point(263, 5)
        Me.DEOutput.Name = "DEOutput"
        Me.DEOutput.ReadOnly = True
        Me.DEOutput.Size = New System.Drawing.Size(531, 509)
        Me.DEOutput.TabIndex = 5
        Me.DEOutput.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Поиск ID"
        '
        'DEList
        '
        Me.DEList.FormattingEnabled = True
        Me.DEList.Location = New System.Drawing.Point(6, 31)
        Me.DEList.Name = "DEList"
        Me.DEList.Size = New System.Drawing.Size(251, 485)
        Me.DEList.TabIndex = 4
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 576)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Lab_Debug)
        Me.Name = "Start"
        Me.Text = "Записи Коллегии (WCoM)"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab_Debug As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SearchTe As TextBox
    Friend WithEvents TeacherOutput As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TeacherList As ListBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SearchST As TextBox
    Friend WithEvents StudentsOutput As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents StudentList As ListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents SearchDE As TextBox
    Friend WithEvents DEOutput As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DEList As ListBox
End Class
