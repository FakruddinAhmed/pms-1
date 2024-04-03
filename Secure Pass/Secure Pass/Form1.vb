Imports System.Data.SqlClient
Public Class Form1

    ' Your connection string to the database
    Dim connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;"
    Dim FuncCls As New CommonFunctionsCls()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get entered username and password
        Dim enteredUsername As String = TextBox1.Text
        Dim enteredPassword As String = TextBox2.Text

        ' Validate credentials
        If ValidateCredentials(enteredUsername, enteredPassword) Then
            ' Successful login, open the main form with the user ID
            Dim authenticatedUserID As Integer = GetUserIDByUsername(enteredUsername)
            Dim mainForm As New MainForm(authenticatedUserID)
            mainForm.Show()
            Me.Hide()
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Enter username.")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Enter password.")
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        ' Query the database to check if the entered credentials are valid
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT PasswordHash FROM Users WHERE Username = @Username"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                Dim storedEncryptedPassword As Object = command.ExecuteScalar()

                If storedEncryptedPassword IsNot Nothing AndAlso Not DBNull.Value.Equals(storedEncryptedPassword) Then
                    ' Decrypt the stored password
                    Dim decryptedPassword As String = FuncCls.DecryptPassword(storedEncryptedPassword.ToString())
                    ' Compare the decrypted password with the user's input
                    Return password = decryptedPassword
                Else
                    Return False ' User not found or password is null/empty
                End If
            End Using
        End Using
    End Function


    Private Function GetUserIDByUsername(username As String) As Integer
        ' Retrieve the user ID based on the username
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT UserID FROM Users WHERE Username = @Username"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                Dim userID As Object = command.ExecuteScalar()

                If userID IsNot Nothing AndAlso Not DBNull.Value.Equals(userID) Then
                    Return Convert.ToInt32(userID)
                Else
                    Return -1 ' User not found or user ID is null/empty
                End If
            End Using
        End Using
    End Function

    ' Checkbox1 is for show/hide password
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim signUpForm As New RegistrationForm()
        signUpForm.Show()
        Me.Hide()
    End Sub
End Class
