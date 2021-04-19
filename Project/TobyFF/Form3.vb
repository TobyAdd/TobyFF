Public Class resulte
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox1.Text)
        MessageBox.Show("Copied to clipboard")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text)
            MessageBox.Show("Saved")
        Else
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub resulte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmdq As String = TextBox1.Text
        Dim sb As New System.Text.StringBuilder
        sb.AppendLine("@echo off")
        sb.AppendLine(setup.code.Text)
        sb.AppendLine("cls")
        sb.AppendLine("title TobyFF [Rendering]")
        sb.AppendLine(cmdq)
        sb.AppendLine("title TobyFF [Done]")
        sb.AppendLine("Pause")

        IO.File.WriteAllText("render.bat", sb.ToString())

        Process.Start("render.bat")
    End Sub
End Class