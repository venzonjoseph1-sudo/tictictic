Public Class Guidelines

    Private Sub PLAY_Click(sender As Object, e As EventArgs) Handles PLAY.Click
        Dim GAME As New GAME()

        GAME.StartPosition = FormStartPosition.Manual
        GAME.Location = Me.Location
        GAME.Size = Me.Size
        GAME.WindowState = Me.WindowState

        GAME.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim secondForm As New secondForm

        secondForm.Show()
        Me.Close()

    End Sub
End Class