Imports System.Data.SqlClient

Public Class MainForm
    Dim FuncCls As New CommonFunctionsCls()
    Dim dataAccess As DataAccessLayer
    Private ReadOnly userID As Integer
    Private accountID As Integer

    ' Define the connection string directly
    Private ReadOnly connectionString As String = "Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;"

    ' Constructor to receive the user ID from the login form
    Public Sub New(authenticatedUserID As Integer)
        InitializeComponent()
        userID = authenticatedUserID
        ' Initialize the data access layer with the connection string
        dataAccess = New DataAccessLayer(connectionString)
    End Sub

    ' Find operation when Button1 is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchAccount()
    End Sub

    ' Add operation when Button2 is clicked
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenAddForm()
    End Sub

    ' Edit operation when Button3 is clicked
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenEditForm(accountID)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Retrieve the entered account name from the TextBox
        Dim enteredAccountName As String = TextBox1.Text.Trim()

        ' Validate if the account name is not empty
        If String.IsNullOrWhiteSpace(enteredAccountName) Then
            MessageBox.Show("Please enter an account name.")
            Return
        End If

        ' Prompt the user to confirm account deletion
        Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the account '{enteredAccountName}'?", "Confirm Deletion", MessageBoxButtons.YesNo)

        ' Check if the user confirmed the deletion
        If confirmationResult = DialogResult.Yes Then
            ' Call the DeleteAccount method passing the account name and user ID
            DeleteAccount(enteredAccountName, userID)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox4.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
    Public Sub DeleteAccount(accountName As String, userID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM Accounts WHERE AccountName = @AccountName AND UserID = @UserID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@AccountName", accountName)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exception
        End Try
    End Sub


    Private Sub SearchAccount()
        ' Retrieve the entered account name from the TextBox
        Dim enteredAccountName As String = TextBox1.Text.Trim()

        ' Validate if the account name is not empty
        If String.IsNullOrWhiteSpace(enteredAccountName) Then
            MessageBox.Show("Please enter an account name.")
            Return
        End If

        ' Retrieve account details using the data access layer
        Dim account As AccountDetails = dataAccess.GetAccountDetails(userID, enteredAccountName)

        If account IsNot Nothing Then
            ' Account found, display details
            TextBox2.Text = account.Website
            TextBox3.Text = account.Username
            ' Decrypt the password before displaying it
            TextBox4.Text = FuncCls.DecryptPassword(account.PasswordHash)
            TextBox5.Text = account.Note
        Else
            ' Account not found
            MessageBox.Show("Account not found.")
        End If
    End Sub

    ' Method to open the AddForm
    Private Sub OpenAddForm()
        Try
            ' Create an instance of the AddForm
            Dim addForm As New Addform(userID)

            ' Show the AddForm as a dialog (modal)
            addForm.ShowDialog()

            ' Optionally, reload the user accounts after adding a new account
            ' You may need to implement this depending on your requirements
        Catch ex As Exception
            ' Handle any exceptions that may occur while opening the AddForm
            MessageBox.Show($"Error opening AddForm: {ex.Message}")
        End Try
    End Sub

    ' Method to open the EditForm
    Private Sub OpenEditForm(accountName As String)
        Try
            ' Create an instance of the EditForm
            Dim editForm As New Editform(userID, accountName)

            ' Show the EditForm as a dialog (modal)
            editForm.ShowDialog()

            ' Optionally, reload the user accounts after editing an account
            ' You may need to implement this depending on your requirements
        Catch ex As Exception
            ' Handle any exceptions that may occur while opening the EditForm
            MessageBox.Show($"Error opening EditForm: {ex.Message}")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
