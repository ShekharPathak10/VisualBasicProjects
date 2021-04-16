Public Class MainForm
    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles Saying1Button.Click
        'Display a saying when clicked
        MessageLabel.Text = "Let's Go Pens!"
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles Saying2Button.Click
        'Display a saying when clicked
        MessageLabel.Text = "No Pain, No Gain!"
    End Sub

    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        'Display a saying when clicked
        MessageLabel.Text = "Love All, Hate None!"
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        'Display a saying when clicked
        MessageLabel.Text = "Hold the MemeStonks!"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the program when clicked
        Me.Close()
    End Sub
End Class

