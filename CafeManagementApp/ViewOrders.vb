Imports System.Data.SqlClient

Public Class ViewOrders

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

    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBills()
    End Sub

    Private Sub DisplayBills()
        Connection.Open()
        Dim command = New SqlCommand("SELECT * FROM Orders", Connection)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataSet = New DataSet()
        adapter.Fill(dataSet)
        dgvOrders.DataSource = dataSet.Tables(0)
        Connection.Close()
        dgvOrders.ClearSelection()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim orders = New Orders
        orders.Show()
        Me.Hide()
    End Sub
End Class