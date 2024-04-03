Imports System.Data.SqlClient

Public Class RegistrationForm

    ' Your connection string to the database
    Dim connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;"

    Dim FuncCls As New CommonFunctionsCls()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get user inputs
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim confirmPassword As String = TextBox3.Text

        ' Validate inputs
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(confirmPassword) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If Not password.Equals(confirmPassword) Then
            MessageBox.Show("Passwords do not match. Please enter them again.")
            TextBox2.Clear()
            TextBox3.Clear()
            Return
        End If

        ' Hash the password before storing it
        Dim hashedPassword As String = FuncCls.EncryptPassword(password)

        ' Save the user to the database (you need to implement this part)
        If SaveUserToDatabase(username, hashedPassword) Then
            MessageBox.Show("Registration successful!")
            ' Redirect to the login form
            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Hide() ' Hide the registration form
        Else
            MessageBox.Show("Registration failed. Please try again.")
        End If
    End Sub


    Private Function SaveUserToDatabase(username As String, hashedPassword As String) As Boolean
        ' Implement logic to save the user to the database
        ' For simplicity, this is just a placeholder
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO Users (Username, PasswordHash) VALUES (@Username, @PasswordHash)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword)
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("user already exits")
            Return False
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
