Imports System.ComponentModel

Public Class setup
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("codes.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code As String = Me.code.Text
        Dim sb As New System.Text.StringBuilder

        sb.AppendLine(code)
        IO.File.WriteAllText("codedata.txt", sb.ToString())
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        code.Text = System.IO.File.ReadAllText("codedata.txt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub setup_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MessageBox.Show("chcp disabled")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.code.Text = "chcp 65001"
    End Sub
End Class