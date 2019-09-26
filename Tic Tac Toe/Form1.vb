Public Class Form1
    Dim Winner As String = ""
    Dim count As Integer = 1
    '===============================================================================
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If count = 1 Then
            Call dishnts()
            hnt1.Visible = True
        End If
        If count = 2 Then
            Call dishnts()
            hnt2.Visible = True
        End If
        If count = 3 Then
            Call dishnts()
            hnt3.Visible = True
        End If

        If count = 4 Then
            Call dishnts()
            hnt4.Visible = True
        End If

        If pb1.Value >= pb1.Maximum Then
            count = count + 1
            pb1.Value = 0
        Else
            pb1.Value = pb1.Value + 1
        End If

        If count > 4 Then
            count = 1
        End If

    End Sub
    '================================================================================

    Sub TurnSwap(ByVal btnname As Object)

        If turn.Text = "X" Then
            btnname.Text = "X"
            turn.Text = "O"
        Else
            btnname.Text = "O"
            turn.Text = "X"
        End If

        btnname.Enabled = False
    End Sub
    '===============================================================================
    Sub CheckHorizontal()

        If (b1.Text = b2.Text And b1.Text = b3.Text And b2.Text = b3.Text) And (b1.Enabled = False And b2.Enabled = False And b3.Enabled = False) Then

            MsgBox("PLAYER " & b1.Text & " WINS!!")
            Winner = b1.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

        If (b4.Text = b5.Text And b4.Text = b6.Text And b5.Text = b6.Text) And (b4.Enabled = False And b5.Enabled = False And b6.Enabled = False) Then

            MsgBox("PLAYER " & b4.Text & " WINS!!")
            Winner = b4.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

        If (b7.Text = b8.Text And b7.Text = b9.Text And b8.Text = b9.Text) And (b7.Enabled = False And b8.Enabled = False And b9.Enabled = False) Then

            MsgBox("PLAYER " & b7.Text & " WINS!!")
            Winner = b7.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

    End Sub
    '====================================================================================
    Sub CheckVertical()

        If (b1.Text = b4.Text And b1.Text = b7.Text And b4.Text = b7.Text) And (b1.Enabled = False And b4.Enabled = False And b7.Enabled = False) Then

            MsgBox("PLAYER " & b1.Text & " WINS!!")
            Winner = b1.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

        If (b2.Text = b5.Text And b2.Text = b8.Text And b5.Text = b8.Text) And (b2.Enabled = False And b5.Enabled = False And b8.Enabled = False) Then

            MsgBox("PLAYER " & b2.Text & " WINS!!")
            Winner = b2.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

        If (b3.Text = b6.Text And b3.Text = b9.Text And b6.Text = b9.Text) And (b3.Enabled = False And b6.Enabled = False And b9.Enabled = False) Then

            MsgBox("PLAYER " & b3.Text & " WINS!!")
            Winner = b3.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

    End Sub
    '=============================================================================
    Sub CheckDiagonal()

        If (b1.Text = b5.Text And b1.Text = b9.Text And b5.Text = b9.Text) And (b1.Enabled = False And b5.Enabled = False And b9.Enabled = False) Then

            MsgBox("PLAYER " & b1.Text & " WINS!!")
            Winner = b1.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

        If (b3.Text = b5.Text And b3.Text = b7.Text And b5.Text = b7.Text) And (b3.Enabled = False And b5.Enabled = False And b7.Enabled = False) Then

            MsgBox("PLAYER " & b3.Text & " WINS!!")
            Winner = b3.Text
            Call DisallBtns()
            btnnext.Enabled = True
        End If

    End Sub
    '======================================================================================
    Sub CheckDraw()

        If (b1.Enabled = False And b2.Enabled = False And b3.Enabled = False And b4.Enabled = False And b5.Enabled = False And b6.Enabled = False And b7.Enabled = False And b8.Enabled = False And b9.Enabled = False) And Winner = "" Then

            Winner = "D"
            MsgBox("IT'S A DRAW!!")
            btnnext.Enabled = True
        End If

    End Sub
    '=============================================================================
    Sub DisallBtns()

        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        b9.Enabled = False

    End Sub
    '=========================================================================

    Sub enaballBtns()

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b9.Enabled = True

    End Sub
    '============================================================================

    Sub SetScore()

        If Winner = "X" Then
            xs.Text = Val(xs.Text) + 1
        Else
            If Winner = "O" Then
                os.Text = Val(os.Text) + 1
            Else
                If Winner = "D" Then
                    ds.Text = Val(ds.Text) + 1
                End If
            End If
        End If

        Winner = ""

    End Sub
    '===========================================================================================

    Sub ClearBtns()

        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b9.Text = ""

    End Sub


    '===========================================================================================
    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click

        Call TurnSwap(b1)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click

        Call TurnSwap(b2)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click

        Call TurnSwap(b3)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click

        Call TurnSwap(b4)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click

        Call TurnSwap(b5)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click

        Call TurnSwap(b6)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click

        Call TurnSwap(b7)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click

        Call TurnSwap(b8)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub

    Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click

        Call TurnSwap(b9)

        Call CheckHorizontal()
        Call CheckVertical()
        Call CheckDiagonal()
        Call CheckDraw()
        Call SetScore()
    End Sub
    '=======================================================================================================
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click


        Call ClearBtns()
        Call enaballBtns()

        If turn.Text = "X" Then
            turn.Text = "O"
        Else
            turn.Text = "X"
        End If
        gmnum.Text = Val(gmnum.Text) + 1
        btnnext.Enabled = False
    End Sub
    '=======================================================================================================
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        Form6.Visible = True

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Form4.PrevForm = Me
        Form4.Visible = True
    End Sub
    '====================================================================================
    Sub dishnts()

        hnt1.Visible = False
        hnt2.Visible = False
        hnt3.Visible = False
        hnt4.Visible = False

    End Sub
    '====================================================================================

    Sub ClearScore()

        xs.Text = "0"
        os.Text = "0"
        ds.Text = "0"

    End Sub

    '====================================================================================

    Private Sub btnmn_Click(sender As Object, e As EventArgs) Handles btnmn.Click

        Form5.Visible = True

    End Sub
    '=======================================================================================
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form3.Visible = True

    End Sub
End Class
