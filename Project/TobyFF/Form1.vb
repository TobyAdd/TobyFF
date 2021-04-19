Public Class TobyFF

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup.Show()
        setup.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Input.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            output.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles add.CheckedChanged
        If (add.Checked = True) Then
            aditional.Show()
            Button3.Enabled = True
        Else
            aditional.Close()
            Button3.Enabled = False
        End If
    End Sub


    Private Sub RenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenderToolStripMenuItem.Click


        resulte.TextBox1.Text = "ffmpeg "
        Dim inputq As String = Me.input.Text
        Dim abq As String = Me.ab.Text
        Dim vbq As String = Me.vb.Text
        Dim outputq As String = Me.output.Text
        Dim winsizeq As String = Me.winsize.Text
        Dim compressq As String = aditional.compress.Text
        Dim volq As String = aditional.vol.Text
        Dim fpsq As String = aditional.fps.Text
        Dim fromq As String = aditional.from.Text
        Dim totoq As String = aditional.toto.Text
        Dim vspeedq As String = aditional.vspeed.Text
        Dim aspeedq As String = aditional.aspeed.Text
        Dim kavichkaq As String = Me.kavichka.Text


        If (input.Text) <> "" Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-i " & kavichkaq & inputq & kavichkaq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (vcod.Text = "H264") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:v libx264"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (vcod.Text = "H265") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:v libx265"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (vcod.Text = "VP9") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:v libvpx-vp9"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (vcod.Text = "AV1") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:v libaom-av1"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (audcod.Text = "Opus") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:a libopus"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (audcod.Text = "Vorbis") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:a libvorbis"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (audcod.Text = "AAC") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:a aac"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If


        If (audcod.Text = "WavPack") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-c:a wavpack"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If


        If (aditional.vspeed.Text <> "") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-filter_complex " & kavichkaq & "setpts=" & vspeedq & "*PTS" & kavichkaq & " -filter:a " & kavichkaq & "atempo=" & aspeedq & kavichkaq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (winsize.Text <> "") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-vf scale=" & winsizeq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If


        If (aditional.from.Text <> "") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-ss " & fromq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (aditional.toto.Text <> "") Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-to " & totoq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (vb.Text) <> "" Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-vb " & vbq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (ab.Text) <> "" Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-ab " & abq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (aditional.delauda.Checked = True) Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-an"
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (aditional.fpsa.Checked = True) Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-r " & fpsq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (aditional.compressa.Checked = True) Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-preset " & compressq
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
        End If

        If (aditional.vola.Checked = True) Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & "-vol " & volq
        End If

        If (output.Text) <> "" Then
            resulte.TextBox1.Text = resulte.TextBox1.Text & " "
            resulte.TextBox1.Text = resulte.TextBox1.Text & kavichkaq & outputq & kavichkaq
        End If



        resulte.Show()

        If (input.Text <> "") Then
        Else
            resulte.Show()
            MessageBox.Show("No input file found!")
            resulte.Close()
        End If

        If (output.Text <> "") Then

        Else
            resulte.Show()
            MessageBox.Show("No output file found!")
            resulte.Close()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DowloadVideoFromYTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DowloadVideoFromYTToolStripMenuItem.Click
        ytdl.Show()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        setup.Show()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        Dim sb As New System.Text.StringBuilder
        Dim inputq As String = Me.input.Text
        Dim kavichkaq As String = Me.kavichka.Text
        If (input.Text <> "") Then
            sb.AppendLine("@echo off")
            sb.AppendLine(setup.code.Text)
            sb.AppendLine("cls")
            sb.AppendLine("title TobyFF [Playing Video]")
            sb.AppendLine("ffplay " & kavichkaq & inputq & kavichkaq)
            sb.AppendLine("title TobyFF [Done]")
            sb.AppendLine("Pause")

            IO.File.WriteAllText("video.bat", sb.ToString())

            Process.Start("video.bat")
        Else
            MessageBox.Show("No input file found")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        aditional.Show()
    End Sub
End Class