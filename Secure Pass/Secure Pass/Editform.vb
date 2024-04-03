Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class EditForm
    Dim FuncCls As New CommonFunctionsCls()
    Private ReadOnly userID As Integer
    Private accountID As Integer
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;"

    Public Sub New(authenticatedUserID As Integer, accountID As Integer)
        InitializeComponent()
        userID = authenticatedUserID
        Me.accountID = accountID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchAccount()
    End Sub

    Private Sub SearchAccount()
        ' Retrieve the entered account name from the TextBox
        Dim enteredAccountName As String = TextBox1.Text.Trim()

        If String.IsNullOrWhiteSpace(enteredAccountName) Then
            MessageBox.Show("Please enter an account name.")
            Return
        End If

        ' Query the database to retrieve the account details, including the account ID
        Dim query As String = "SELECT AccountID, UserID, Website, Username, PasswordHash, Note FROM Accounts WHERE AccountName = @AccountName AND UserID = @UserID"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AccountName", enteredAccountName)
                    command.Parameters.AddWithValue("@UserID", userID)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Account found, retrieve details and populate form fields
                            accountID = Convert.ToInt32(reader("AccountID"))
                            TextBox2.Text = reader("Website").ToString()
                            TextBox3.Text = reader("Username").ToString()
                            TextBox4.Text = FuncCls.DecryptPassword(reader("PasswordHash").ToString())
                            TextBox5.Text = reader("Note").ToString()
                        Else
                            MessageBox.Show("Account not found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error searching account: {ex.Message}")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveChanges()
    End Sub

    Private Sub SaveChanges()
        ' Retrieve edited values from form fields
        Dim editedWebsite As String = TextBox2.Text.Trim()
        Dim editedUsername As String = TextBox3.Text.Trim()
        Dim editedPasswordHash As String = FuncCls.EncryptPassword(TextBox4.Text.Trim())
        Dim editedNote As String = TextBox5.Text.Trim()

        ' Update the account in the database
        Dim updateQuery As String = "UPDATE Accounts SET Website = @Website, Username = @Username, PasswordHash = @PasswordHash, Note = @Note WHERE AccountID = @AccountID"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(updateQuery, connection)
                    command.Parameters.AddWithValue("@Website", editedWebsite)
                    command.Parameters.AddWithValue("@Username", editedUsername)
                    command.Parameters.AddWithValue("@PasswordHash", editedPasswordHash)
                    command.Parameters.AddWithValue("@Note", editedNote)
                    command.Parameters.AddWithValue("@AccountID", accountID)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Account details updated successfully.")
                        ' Clear the text boxes after successful update
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox5.Clear()
                    Else
                        MessageBox.Show("Failed to update account details.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating account: {ex.Message}")
        End Try
    End Sub
End Class
