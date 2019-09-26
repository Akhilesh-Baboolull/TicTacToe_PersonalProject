Public Class Form3

    Public prevform As Object = Me


    Private Sub btnabt_Click(sender As Object, e As EventArgs) Handles btnabt.Click

        Me.Visible = False
        Form2.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.PrevForm = Me
        Form4.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As String
        temp = LCase(prevform.name)

        If temp = "form5" Then

            Call Form1.ClearBtns()
            Call Form1.enaballBtns()
            Me.Visible = False
            Form1.Visible = True
            prevform = Me

        Else

            Form1.gmnum.Text = "1"
            Form1.turn.Text = "X"

            Call Form1.ClearScore()
            Call Form1.ClearBtns()
            Call Form1.enaballBtns()

            Me.Visible = False
            Form1.Visible = True
            prevform = Me
        End If

    End Sub
End Class