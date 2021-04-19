Public Class ytdl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            save.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kavichkaq As String = TobyFF.kavichka.Text
        Dim linkq As String = Me.link.Text
        Dim saveq As String = Me.save.Text

        Dim sb As New System.Text.StringBuilder

        sb.AppendLine("@echo off")
        sb.AppendLine("cls")
        sb.AppendLine(setup.code.Text)
        sb.AppendLine("title TobyFF [Downloading video]")
        sb.AppendLine("youtube-dl -f bestvideo+bestaudio " & linkq & " --output " & kavichkaq & saveq & kavichkaq)
        sb.AppendLine("title TobyFF [Done]")
        sb.AppendLine("Pause")

        IO.File.WriteAllText("download.bat", sb.ToString())

        Process.Start("download.bat")

    End Sub
End Class