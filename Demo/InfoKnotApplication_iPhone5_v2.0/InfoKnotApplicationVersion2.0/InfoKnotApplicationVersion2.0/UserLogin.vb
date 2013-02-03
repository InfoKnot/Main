Public Class UserLogin

    Private Sub UserUsernameInput_Click(sender As System.Object, e As System.EventArgs) Handles UserUsernameTextBox.Click
        'Erases the text "username" so that user can enter their Username.
        UserUsernameTextBox.Text = ""
    End Sub

    Private Sub UserPasswordInputBox_Click(sender As System.Object, e As System.EventArgs) Handles UserPasswordTextBox.Click
        'Erases the text "Password" so that the user can enter their Password
        UserPasswordTextBox.Text = ""
    End Sub

    Private Sub ClearUsernameAndPasswordButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearUsernameAndPasswordButton.Click
        'Resets the text in Username and Password text input boxes
        UserUsernameTextBox.Text = "eID"
        UserPasswordTextBox.Text = "Password"
    End Sub

    Private Sub LoginButton_Click(sender As System.Object, e As System.EventArgs) Handles LoginButton.Click
        'Checks the username and Password, if valid, sends them on to MainPage
        If UserUsernameTextBox.Text = "Guest" And UserPasswordTextBox.Text = "Test" Then
            MainPage.Show()
            Me.Hide()
        Else
            MsgBox("Username or Password was not recognized")
        End If

    End Sub


End Class