<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.UserUsernameTextBox = New System.Windows.Forms.TextBox()
        Me.ClearUsernameAndPasswordButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserPasswordTextBox
        '
        Me.UserPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPasswordTextBox.Location = New System.Drawing.Point(75, 114)
        Me.UserPasswordTextBox.Name = "UserPasswordTextBox"
        Me.UserPasswordTextBox.Size = New System.Drawing.Size(160, 26)
        Me.UserPasswordTextBox.TabIndex = 1
        Me.UserPasswordTextBox.Text = "Password"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(160, 158)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 23)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'UserUsernameTextBox
        '
        Me.UserUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserUsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserUsernameTextBox.Location = New System.Drawing.Point(75, 82)
        Me.UserUsernameTextBox.Name = "UserUsernameTextBox"
        Me.UserUsernameTextBox.Size = New System.Drawing.Size(160, 26)
        Me.UserUsernameTextBox.TabIndex = 3
        Me.UserUsernameTextBox.Text = "eID"
        '
        'ClearUsernameAndPasswordButton
        '
        Me.ClearUsernameAndPasswordButton.Location = New System.Drawing.Point(75, 158)
        Me.ClearUsernameAndPasswordButton.Name = "ClearUsernameAndPasswordButton"
        Me.ClearUsernameAndPasswordButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearUsernameAndPasswordButton.TabIndex = 4
        Me.ClearUsernameAndPasswordButton.Text = "Clear Text"
        Me.ClearUsernameAndPasswordButton.UseVisualStyleBackColor = True
        '
        'UserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.ClearUsernameAndPasswordButton)
        Me.Controls.Add(Me.UserUsernameTextBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.UserPasswordTextBox)
        Me.Name = "UserLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents UserUsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearUsernameAndPasswordButton As System.Windows.Forms.Button
End Class
