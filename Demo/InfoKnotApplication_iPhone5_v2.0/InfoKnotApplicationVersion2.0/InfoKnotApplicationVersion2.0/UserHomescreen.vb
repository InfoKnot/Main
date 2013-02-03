Public Class UserHomescreen

    Private Sub ApplicationLaunchButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplicationLaunchButton.Click
        Me.Hide()
        UserLogin.Show()
    End Sub
End Class