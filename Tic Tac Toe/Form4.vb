Public Class Form4
    Public PrevForm As Object


    Private Sub btnyes_Click(sender As Object, e As EventArgs) Handles btnyes.Click
        End
    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click

        Me.Visible = False
        PrevForm.visible = True

    End Sub
End Class