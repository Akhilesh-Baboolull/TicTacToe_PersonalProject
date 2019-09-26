Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form1.gmnum.Text = "1"
        Form1.turn.Text = "X"

        Call Form1.ClearScore()
        Call Form1.ClearBtns()
        Call Form1.enaballBtns()

        Me.Visible = False
    End Sub
End Class