<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Me.ErrorLog = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ErrorLog
        '
        Me.ErrorLog.Location = New System.Drawing.Point(12, 12)
        Me.ErrorLog.Name = "ErrorLog"
        Me.ErrorLog.ReadOnly = True
        Me.ErrorLog.Size = New System.Drawing.Size(506, 246)
        Me.ErrorLog.TabIndex = 0
        Me.ErrorLog.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(444, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Очистить лог"
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 279)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ErrorLog)
        Me.Name = "Log"
        Me.Text = "Логи ошибок и несоответствий"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorLog As RichTextBox
    Friend WithEvents Label1 As Label
End Class
