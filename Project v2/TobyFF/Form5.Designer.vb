<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ytdl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ytdl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.link = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.save = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link:"
        '
        'link
        '
        Me.link.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.link.ForeColor = System.Drawing.Color.White
        Me.link.Location = New System.Drawing.Point(67, 12)
        Me.link.Name = "link"
        Me.link.Size = New System.Drawing.Size(530, 20)
        Me.link.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Save to:"
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(95, 38)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(426, 20)
        Me.save.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(585, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Download"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "video"
        Me.SaveFileDialog1.Title = "Save video"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(524, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 21)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "browse..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ytdl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(605, 90)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.link)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ytdl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YT Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents link As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents save As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button3 As Button
End Class
