Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports CafeManagementApp.My.Resources

Public Class Login

    Private _connection As SqlConnection
    Private Property Connection As SqlConnection
        Get
            If _connection Is Nothing Then
                _connection = SqlHelper.GetSqlConnection()
            End If
            Return _connection
        End Get
        Set(value As SqlConnection)
            _connection = value
        End Set
    End Property

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUserName.Text) Or String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Enter user name and password!")
        Else

            If CheckLoginAndPassword(txtUserName.Text, txtPassword.Text) Then
                Dim items = New Items
                items.Show()
                Me.Hide()
            Else
                MsgBox("Wrong user name or password!")
                txtPassword.Text = String.Empty
                txtUserName.Text = String.Empty
            End If
        End If
    End Sub

    Private Function CheckLoginAndPassword(login As String, password As String) As Boolean
        Dim hash = DataResources.Hash
        Dim data = UTF8Encoding.UTF8.GetBytes(password)
        Using md5 As New MD5CryptoServiceProvider()
            Dim keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash))
            Using tripD As New TripleDESCryptoServiceProvider()
                tripD.Key = keys
                tripD.Mode = CipherMode.ECB
                tripD.Padding = PaddingMode.PKCS7
                Dim transform = tripD.CreateEncryptor()
                Dim results = transform.TransformFinalBlock(data, 0, data.Length)
                Dim encryptedPass = Convert.ToBase64String(results, 0, results.Length)
                Connection.Open()
                Dim command = New SqlCommand($"SELECT COUNT(*) FROM Users WHERE Name='{login}' AND Password='{encryptedPass}'", Connection)
                Dim userFound = Integer.Parse(command.ExecuteScalar())
                Connection.Close()
                If userFound = 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Private Sub btnSeller_Click(sender As Object, e As EventArgs) Handles btnSeller.Click
        Dim orders = New Orders
        orders.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
