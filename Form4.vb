Imports System.DirectoryServices
Imports System.Drawing.Text

Public Class GAME
    Dim plusone As Integer
    Dim checker As Boolean

    Private Sub Enable_False()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub score()
        If (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "6") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            MessageBox.Show("Player X Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label3.Text) + 1
            Label3.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

        If (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            MessageBox.Show("Player O Wins!", "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Label4.Text) + 1
            Label4.Text = plusone.ToString()
            ScoreChecker()
            Enable_False()
        End If

    End Sub

    Private playerTurn As Boolean = True ' True for X, False for O
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click,
            Button2.Click,
            Button3.Click,
            Button4.Click,
            Button5.Click,
            Button6.Click,
            Button7.Click,
            Button8.Click,
            Button9.Click
        Dim clickedButton As Button = CType(sender, Button)
        If clickedButton.Text <> "" Then Return

        If playerTurn Then
            clickedButton.Text = "X"

        Else
            clickedButton.Text = "O"
        End If

        playerTurn = Not playerTurn

        score()


    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True


        playerTurn = True

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ResetEntireGame()
        Label3.Text = "0"
        Label4.Text = "0"

        Label3.Enabled = True
        Label4.Enabled = True


    End Sub

    Private Sub ScoreChecker()
        If Convert.ToInt32(Label3.Text) = 5 Then
            MessageBox.Show("Game Over! Player X Wins", "Result Overall")
            ResetEntireGame()
        End If
        If Convert.ToInt32(Label4.Text) = 5 Then
            MessageBox.Show("Game Over! Player O Wins", "Result Overall")
            ResetEntireGame()
        End If

    End Sub


End Class