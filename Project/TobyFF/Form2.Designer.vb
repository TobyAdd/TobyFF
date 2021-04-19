<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aditional
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aditional))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fpsa = New System.Windows.Forms.CheckBox()
        Me.fps = New System.Windows.Forms.ComboBox()
        Me.speda = New System.Windows.Forms.CheckBox()
        Me.speed = New System.Windows.Forms.ComboBox()
        Me.delauda = New System.Windows.Forms.CheckBox()
        Me.vola = New System.Windows.Forms.CheckBox()
        Me.compressa = New System.Windows.Forms.CheckBox()
        Me.vol = New System.Windows.Forms.TextBox()
        Me.compress = New System.Windows.Forms.ComboBox()
        Me.from = New System.Windows.Forms.ComboBox()
        Me.toto = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.vspeed = New System.Windows.Forms.TextBox()
        Me.aspeed = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(173, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "to"
        '
        'fpsa
        '
        Me.fpsa.AutoSize = True
        Me.fpsa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.fpsa.ForeColor = System.Drawing.Color.White
        Me.fpsa.Location = New System.Drawing.Point(12, 39)
        Me.fpsa.Name = "fpsa"
        Me.fpsa.Size = New System.Drawing.Size(60, 22)
        Me.fpsa.TabIndex = 35
        Me.fpsa.Text = "FPS:"
        Me.fpsa.UseVisualStyleBackColor = True
        '
        'fps
        '
        Me.fps.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fps.Enabled = False
        Me.fps.ForeColor = System.Drawing.Color.White
        Me.fps.FormattingEnabled = True
        Me.fps.Items.AddRange(New Object() {"1", "2", "5", "8", "10", "12", "15", "16", "20", "25", "30", "50", "60", "100", "120", "240"})
        Me.fps.Location = New System.Drawing.Point(68, 40)
        Me.fps.Name = "fps"
        Me.fps.Size = New System.Drawing.Size(350, 21)
        Me.fps.TabIndex = 36
        '
        'speda
        '
        Me.speda.AutoSize = True
        Me.speda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.speda.ForeColor = System.Drawing.Color.White
        Me.speda.Location = New System.Drawing.Point(12, 65)
        Me.speda.Name = "speda"
        Me.speda.Size = New System.Drawing.Size(73, 22)
        Me.speda.TabIndex = 37
        Me.speda.Text = "Speed:"
        Me.speda.UseVisualStyleBackColor = True
        '
        'speed
        '
        Me.speed.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.speed.Enabled = False
        Me.speed.ForeColor = System.Drawing.Color.White
        Me.speed.FormattingEnabled = True
        Me.speed.Items.AddRange(New Object() {"0.5x", "1.0x", "2.0x", "4.0x"})
        Me.speed.Location = New System.Drawing.Point(78, 65)
        Me.speed.Name = "speed"
        Me.speed.Size = New System.Drawing.Size(340, 21)
        Me.speed.TabIndex = 38
        '
        'delauda
        '
        Me.delauda.AutoSize = True
        Me.delauda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.delauda.ForeColor = System.Drawing.Color.White
        Me.delauda.Location = New System.Drawing.Point(12, 89)
        Me.delauda.Name = "delauda"
        Me.delauda.Size = New System.Drawing.Size(183, 22)
        Me.delauda.TabIndex = 39
        Me.delauda.Text = "Delete audio from video"
        Me.delauda.UseVisualStyleBackColor = True
        '
        'vola
        '
        Me.vola.AutoSize = True
        Me.vola.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.vola.ForeColor = System.Drawing.Color.White
        Me.vola.Location = New System.Drawing.Point(12, 110)
        Me.vola.Name = "vola"
        Me.vola.Size = New System.Drawing.Size(136, 22)
        Me.vola.TabIndex = 40
        Me.vola.Text = "Change Volume:"
        Me.vola.UseVisualStyleBackColor = True
        '
        'compressa
        '
        Me.compressa.AutoSize = True
        Me.compressa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.compressa.ForeColor = System.Drawing.Color.White
        Me.compressa.Location = New System.Drawing.Point(10, 131)
        Me.compressa.Name = "compressa"
        Me.compressa.Size = New System.Drawing.Size(142, 22)
        Me.compressa.TabIndex = 41
        Me.compressa.Text = "Video Compress:"
        Me.compressa.UseVisualStyleBackColor = True
        '
        'vol
        '
        Me.vol.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.vol.Enabled = False
        Me.vol.ForeColor = System.Drawing.Color.White
        Me.vol.Location = New System.Drawing.Point(142, 110)
        Me.vol.Name = "vol"
        Me.vol.Size = New System.Drawing.Size(276, 20)
        Me.vol.TabIndex = 42
        '
        'compress
        '
        Me.compress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.compress.Enabled = False
        Me.compress.ForeColor = System.Drawing.Color.White
        Me.compress.FormattingEnabled = True
        Me.compress.Items.AddRange(New Object() {"ultrafast", "superfast", "veryfast", "faster", "fast", "medium", "slow", "slower", "veryslow", "placebo"})
        Me.compress.Location = New System.Drawing.Point(151, 131)
        Me.compress.Name = "compress"
        Me.compress.Size = New System.Drawing.Size(267, 21)
        Me.compress.TabIndex = 43
        '
        'from
        '
        Me.from.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.from.ForeColor = System.Drawing.Color.White
        Me.from.FormattingEnabled = True
        Me.from.Items.AddRange(New Object() {"00:00:00", "home"})
        Me.from.Location = New System.Drawing.Point(76, 13)
        Me.from.Name = "from"
        Me.from.Size = New System.Drawing.Size(91, 21)
        Me.from.TabIndex = 47
        '
        'toto
        '
        Me.toto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.toto.ForeColor = System.Drawing.Color.White
        Me.toto.FormattingEnabled = True
        Me.toto.Items.AddRange(New Object() {"00:00:00", "end"})
        Me.toto.Location = New System.Drawing.Point(202, 12)
        Me.toto.Name = "toto"
        Me.toto.Size = New System.Drawing.Size(91, 21)
        Me.toto.TabIndex = 48
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Cut from"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(52, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 33)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "video"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(218, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 33)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "audio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'vspeed
        '
        Me.vspeed.Location = New System.Drawing.Point(36, 262)
        Me.vspeed.Name = "vspeed"
        Me.vspeed.Size = New System.Drawing.Size(116, 20)
        Me.vspeed.TabIndex = 52
        '
        'aspeed
        '
        Me.aspeed.Location = New System.Drawing.Point(202, 262)
        Me.aspeed.Name = "aspeed"
        Me.aspeed.Size = New System.Drawing.Size(112, 20)
        Me.aspeed.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(11, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(406, 24)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'aditional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 185)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.aspeed)
        Me.Controls.Add(Me.vspeed)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toto)
        Me.Controls.Add(Me.from)
        Me.Controls.Add(Me.compress)
        Me.Controls.Add(Me.vol)
        Me.Controls.Add(Me.compressa)
        Me.Controls.Add(Me.vola)
        Me.Controls.Add(Me.delauda)
        Me.Controls.Add(Me.speed)
        Me.Controls.Add(Me.speda)
        Me.Controls.Add(Me.fps)
        Me.Controls.Add(Me.fpsa)
        Me.Controls.Add(Me.Label8)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "aditional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aditional tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents fpsa As CheckBox
    Friend WithEvents fps As ComboBox
    Friend WithEvents speda As CheckBox
    Friend WithEvents speed As ComboBox
    Friend WithEvents delauda As CheckBox
    Friend WithEvents vola As CheckBox
    Friend WithEvents compressa As CheckBox
    Friend WithEvents vol As TextBox
    Friend WithEvents compress As ComboBox
    Friend WithEvents from As ComboBox
    Friend WithEvents toto As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents vspeed As TextBox
    Friend WithEvents aspeed As TextBox
    Friend WithEvents Button1 As Button
End Class
