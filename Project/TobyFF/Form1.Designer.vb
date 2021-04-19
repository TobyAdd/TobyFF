<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TobyFF
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TobyFF))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.output = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.winsize = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vcod = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.audcod = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.vb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ab = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DowloadVideoFromYTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kavichka = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.coder = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input file:"
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.input.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.input.ForeColor = System.Drawing.Color.White
        Me.input.Location = New System.Drawing.Point(92, 34)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(298, 21)
        Me.input.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(396, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Output file:"
        '
        'output
        '
        Me.output.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.output.ForeColor = System.Drawing.Color.White
        Me.output.Location = New System.Drawing.Point(102, 61)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(288, 20)
        Me.output.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(396, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 21)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Video Size:"
        '
        'winsize
        '
        Me.winsize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.winsize.ForeColor = System.Drawing.Color.White
        Me.winsize.FormattingEnabled = True
        Me.winsize.Items.AddRange(New Object() {"256:144", "426:240", "640:360", "854:480", "1280:720", "1920:1080", "2560:1440", "3840:2160"})
        Me.winsize.Location = New System.Drawing.Point(107, 84)
        Me.winsize.Name = "winsize"
        Me.winsize.Size = New System.Drawing.Size(314, 21)
        Me.winsize.TabIndex = 9
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.SupportMultiDottedExtensions = True
        Me.OpenFileDialog1.Title = "Select Input file"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Video (MP4)|*.mp4|Audio (*.MP3)|*.mp3|All Files (*.*)|*.*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Video Codec:"
        '
        'vcod
        '
        Me.vcod.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vcod.ForeColor = System.Drawing.Color.White
        Me.vcod.FormattingEnabled = True
        Me.vcod.Items.AddRange(New Object() {"H264", "H265", "VP9", "AV1"})
        Me.vcod.Location = New System.Drawing.Point(122, 108)
        Me.vcod.Name = "vcod"
        Me.vcod.Size = New System.Drawing.Size(299, 21)
        Me.vcod.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Audio Codec:"
        '
        'audcod
        '
        Me.audcod.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.audcod.ForeColor = System.Drawing.Color.White
        Me.audcod.FormattingEnabled = True
        Me.audcod.Items.AddRange(New Object() {"Opus", "Vorbis", "AAC", "WavPack"})
        Me.audcod.Location = New System.Drawing.Point(123, 131)
        Me.audcod.Name = "audcod"
        Me.audcod.Size = New System.Drawing.Size(298, 21)
        Me.audcod.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(12, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Video Bitrate:"
        '
        'vb
        '
        Me.vb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vb.ForeColor = System.Drawing.Color.White
        Me.vb.Location = New System.Drawing.Point(123, 157)
        Me.vb.Name = "vb"
        Me.vb.Size = New System.Drawing.Size(298, 20)
        Me.vb.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(11, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Audio Bitrate:"
        '
        'ab
        '
        Me.ab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ab.ForeColor = System.Drawing.Color.White
        Me.ab.Location = New System.Drawing.Point(123, 182)
        Me.ab.Name = "ab"
        Me.ab.Size = New System.Drawing.Size(298, 20)
        Me.ab.TabIndex = 30
        '
        'add
        '
        Me.add.AutoSize = True
        Me.add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.add.ForeColor = System.Drawing.Color.White
        Me.add.Location = New System.Drawing.Point(15, 204)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(127, 24)
        Me.add.TabIndex = 31
        Me.add.Text = "Aditional tools"
        Me.add.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RenderToolStripMenuItem, Me.PlayToolStripMenuItem, Me.SettingToolStripMenuItem, Me.DowloadVideoFromYTToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(430, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RenderToolStripMenuItem
        '
        Me.RenderToolStripMenuItem.Name = "RenderToolStripMenuItem"
        Me.RenderToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RenderToolStripMenuItem.Text = "Render"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SettingToolStripMenuItem.Text = "Chcp"
        '
        'DowloadVideoFromYTToolStripMenuItem
        '
        Me.DowloadVideoFromYTToolStripMenuItem.Name = "DowloadVideoFromYTToolStripMenuItem"
        Me.DowloadVideoFromYTToolStripMenuItem.Size = New System.Drawing.Size(146, 20)
        Me.DowloadVideoFromYTToolStripMenuItem.Text = "Dowload Video From YT"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'kavichka
        '
        Me.kavichka.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kavichka.ForeColor = System.Drawing.SystemColors.Window
        Me.kavichka.Location = New System.Drawing.Point(18, 294)
        Me.kavichka.Name = "kavichka"
        Me.kavichka.Size = New System.Drawing.Size(224, 20)
        Me.kavichka.TabIndex = 34
        Me.kavichka.Text = """"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(15, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "If you edit project, DONT DELETE THIS!!!"
        '
        'coder
        '
        Me.coder.Location = New System.Drawing.Point(18, 320)
        Me.coder.Name = "coder"
        Me.coder.Size = New System.Drawing.Size(224, 20)
        Me.coder.TabIndex = 36
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Enabled = False
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(139, 205)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 22)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "(Show)"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TobyFF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 233)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.coder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kavichka)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.ab)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.vb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.audcod)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.vcod)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.winsize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "TobyFF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TobyFF (TobyAdd Video Editor)"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents output As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents winsize As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label5 As Label
    Friend WithEvents vcod As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents audcod As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents vb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ab As TextBox
    Friend WithEvents add As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents kavichka As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DowloadVideoFromYTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents coder As TextBox
    Friend WithEvents Button3 As Button
End Class
