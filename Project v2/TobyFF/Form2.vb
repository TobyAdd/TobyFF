Public Class aditional
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub compressa_CheckedChanged(sender As Object, e As EventArgs) Handles compressa.CheckedChanged
        If (Me.compressa.Checked = True) Then
            Me.compress.Enabled = True
            Me.compress.Text = "medium"
        Else
            Me.compress.Text = ""
            Me.compress.Enabled = False
        End If
    End Sub

    Private Sub aditional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub aditional_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        TobyFF.add.Checked = False
        TobyFF.Button3.Enabled = False
    End Sub

    Private Sub vola_CheckedChanged(sender As Object, e As EventArgs) Handles vola.CheckedChanged
        If (vola.Checked = True) Then
            vol.Enabled = True
            vol.Text = "100"
        Else
            vol.Enabled = False
            vol.Text = ""
        End If
    End Sub

    Private Sub speda_CheckedChanged(sender As Object, e As EventArgs) Handles speda.CheckedChanged
        If (Me.speda.Checked = True) Then
            Me.speed.Enabled = True
            Me.speed.Text = "1x"
            Me.vspeed.Text = ""
            Me.aspeed.Text = ""
        Else
            Me.speed.Enabled = False
            Me.speed.Text = ""
            Me.vspeed.Text = ""
            Me.aspeed.Text = ""
        End If
    End Sub

    Private Sub fpsa_CheckedChanged(sender As Object, e As EventArgs) Handles fpsa.CheckedChanged
        If (Me.fpsa.Checked = True) Then
            Me.fps.Enabled = True
            Me.fps.Text = "30"
        Else
            Me.fps.Enabled = False
            Me.fps.Text = ""
        End If
    End Sub


    Private Sub from_SelectedIndexChanged(sender As Object, e As EventArgs) Handles from.SelectedIndexChanged
        If (from.Text = "home") Then
            from.Text = ""
        End If
    End Sub

    Private Sub toto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toto.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (from.Text = "home") Then
            from.Text = ""
        End If

        If (toto.Text = "end") Then
            toto.Text = ""
        End If
    End Sub

    Private Sub speed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles speed.SelectedIndexChanged
        If (speed.Text = "0.5x") Then
            vspeed.Text = "2"
            aspeed.Text = "0.5"
        End If

        If (speed.Text = "1.0x") Then
            vspeed.Text = ""
            aspeed.Text = ""
        End If

        If (speed.Text = "2.0x") Then
            vspeed.Text = "0.5"
            aspeed.Text = "2"
        End If

        If (speed.Text = "4.0x") Then
            vspeed.Text = "0.25"
            aspeed.Text = "4"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub fps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fps.SelectedIndexChanged

    End Sub

    Private Sub compress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles compress.SelectedIndexChanged

    End Sub
End Class