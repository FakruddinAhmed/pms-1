Imports System.Data.SqlClient

Public Class AddForm
    Private ReadOnly userID As Integer
    Private ReadOnly dataAccess As DataAccessLayer
    Private FuncCls As New CommonFunctionsCls()

    Public Sub New(authenticatedUserID As Integer)
        InitializeComponent()
        userID = authenticatedUserID
        dataAccess = New DataAccessLayer("Data Source=DESKTOP-HILRCRM\SQLEXPRESS;Initial Catalog=loginsystem;Integrated Security=True;Encrypt=False;")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Get the user inputs from the form
            Dim accountName As String = TextBox1.Text.Trim()
            Dim website As String = TextBox2.Text.Trim()
            Dim username As String = TextBox3.Text.Trim()
            Dim password As String = FuncCls.EncryptPassword(TextBox4.Text.Trim()) ' Encrypt the password
            Dim note As String = TextBox5.Text.Trim()

            ' Validate user inputs (you can add more validation as needed)
            If String.IsNullOrWhiteSpace(accountName) OrElse String.IsNullOrWhiteSpace(username) Then
                MessageBox.Show("Please fill in all required fields.")
                Return
            End If

            ' Create an AccountDetails object with the user inputs
            Dim account As New AccountDetails() With {
                .UserID = userID,
                .AccountName = accountName,
                .Website = website,
                .Username = username,
                .PasswordHash = password,
                .Note = note
            }

            ' Add the account to the database using the data access layer
            dataAccess.AddAccount(account)

            ' Display a success message to the user
            MessageBox.Show("Account added successfully.")

            ' Optionally, clear the form fields after adding the account
            ClearFormFields()
        Catch ex As Exception
            ' Handle any exceptions that occur during account addition
            MessageBox.Show($"Error adding account: {ex.Message}")
        End Try
    End Sub

    Private Sub ClearFormFields()
        ' Clear all text fields in the form
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Close the AddForm
        Me.Close()
    End Sub
End Class
