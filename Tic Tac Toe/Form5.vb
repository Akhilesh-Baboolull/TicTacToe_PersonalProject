Public Class Form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.prevform = Me
        Me.Visible = False
        Form1.Visible = False
        Form3.prevform = Me
        Form3.Visible = True

    End Sub
End Class