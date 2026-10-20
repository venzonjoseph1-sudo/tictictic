Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secondForm As New secondForm()

        secondForm.StartPosition = FormStartPosition.Manual
        secondForm.Location = Me.Location
        secondForm.Size = Me.Size
        secondForm.WindowState = Me.WindowState

        secondForm.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
