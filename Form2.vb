Public Class secondForm
    Dim Guidelines As New Guidelines()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a username before proceeding!")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter a username before proceeding!")
            Exit Sub
        End If


        Guidelines.StartPosition = FormStartPosition.Manual
        Guidelines.Location = Me.Location
        Guidelines.Size = Me.Size
        Guidelines.WindowState = Me.WindowState

        Guidelines.Show()
        Me.Hide()
    End Sub

    Private Sub secondForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class