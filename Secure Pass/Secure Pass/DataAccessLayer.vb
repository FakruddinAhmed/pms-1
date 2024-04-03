Imports System.Data.SqlClient

Public Class DataAccessLayer
    Private ReadOnly connectionString As String
    Dim FuncCls As New CommonFunctionsCls()

    Public Sub New(connectionStr As String)
        connectionString = connectionStr
    End Sub

    Public Function GetAccountDetails(userID As Integer, accountName As String) As AccountDetails
        Dim query As String = "SELECT UserID, AccountID, AccountName, Website, Username, PasswordHash, Note FROM Accounts WHERE AccountName = @AccountName AND UserID = @UserID"
        Dim account As AccountDetails = Nothing

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@AccountName", accountName)
                command.Parameters.AddWithValue("@UserID", userID)

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        account = New AccountDetails() With {
                        .UserID = Convert.ToInt32(reader("UserID")),
                        .AccountID = Convert.ToInt32(reader("AccountID")),
                        .AccountName = reader("AccountName").ToString(),
                        .Website = reader("Website").ToString(),
                        .Username = reader("Username").ToString(),
                        .PasswordHash = reader("PasswordHash").ToString(),
                        .Note = reader("Note").ToString()
                    }
                    End If
                End Using
            End Using
        End Using
        Return account
    End Function



    Public Sub AddAccount(account As AccountDetails)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Accounts (UserID, AccountName, Website, Username, PasswordHash, Note) " &
                                      "VALUES (@UserID, @AccountName, @Website, @Username, @PasswordHash, @Note)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", account.UserID)
                    command.Parameters.AddWithValue("@AccountName", account.AccountName)
                    command.Parameters.AddWithValue("@Website", account.Website)
                    command.Parameters.AddWithValue("@Username", account.Username)
                    command.Parameters.AddWithValue("@PasswordHash", account.PasswordHash)
                    command.Parameters.AddWithValue("@Note", account.Note)

                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Handle exception
        End Try
    End Sub



    ' Other methods for data access as needed
End Class
