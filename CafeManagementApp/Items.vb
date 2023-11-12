Imports System.Data.SqlClient

Public Class Items

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

    Dim _selectedItemKey As Integer = 0

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim login = New Login
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnAddNewCategory_Click(sender As Object, e As EventArgs) Handles btnAddNewCategory.Click
        If String.IsNullOrWhiteSpace(txtNewCategory.Text) Then
            MsgBox("Category name cannot be empty!")
        Else
            Connection.Open()
            Dim command = New SqlCommand($"INSERT INTO Categories VALUES ('{txtNewCategory.Text}')", Connection)
            command.ExecuteNonQuery()
            MsgBox("Category added!")
            Connection.Close()
            txtNewCategory.Text = String.Empty
            FillCategories()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub Reset()
        txtName.Text = String.Empty
        cbxCategory.SelectedIndex = 0
        txtPrice.Text = String.Empty
        txtQuantity.Text = String.Empty
        _selectedItemKey = 0
        dgvItems.ClearSelection()
    End Sub

    Private Sub FillCategories()
        Connection.Open()
        Dim command = New SqlCommand("SELECT * FROM Categories", Connection)
        Dim adapter = New SqlDataAdapter(command)
        Dim table = New DataTable()
        adapter.Fill(table)
        cbxCategory.DataSource = table
        cbxCategory.DisplayMember = "Name"
        cbxCategory.ValueMember = "Name"
        Connection.Close()
    End Sub
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategories()
        DisplayItems()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If ValidateItemTextboxes() Then
            Connection.Open()
            Dim values = $"{String.Join("','", txtName.Text, cbxCategory.SelectedValue.ToString(), txtPrice.Text, txtQuantity.Text)}"
            Dim command = New SqlCommand($"INSERT INTO Items VALUES ('{values}')", Connection)
            command.ExecuteNonQuery()
            MsgBox("Item added!")
            Connection.Close()
            Reset()
            DisplayItems()
        End If
    End Sub

    Private Function ValidateItemTextboxes() As Boolean
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("Name cannot be empty!")
            Return False
        ElseIf String.IsNullOrWhiteSpace(cbxCategory.Text) Then
            MsgBox("Category cannot be empty!")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtPrice.Text) Then
            MsgBox("Price cannot be empty!")
            Return False
        ElseIf Not Decimal.TryParse(txtPrice.Text, 0) Then
            MsgBox("Incorrect price!")
            Return False
        ElseIf String.IsNullOrWhiteSpace(txtQuantity.Text) Then
            MsgBox("Quantity cannot be empty!")
            Return False
        ElseIf Not Integer.TryParse(txtQuantity.Text, 0) Then
            MsgBox("Incorrect quantity!")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub DisplayItems()
        Connection.Open()
        Dim command = New SqlCommand("SELECT * FROM Items", Connection)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataSet = New DataSet()
        adapter.Fill(dataSet)
        dgvItems.DataSource = dataSet.Tables(0)
        Connection.Close()
        dgvItems.ClearSelection()
    End Sub

    Private Sub dgvItems_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvItems.CellMouseClick
        Try
            Dim row As DataGridViewRow = dgvItems.Rows(e.RowIndex)
            txtName.Text = row.Cells(1).Value.ToString()
            cbxCategory.SelectedValue = row.Cells(2).Value.ToString()
            txtPrice.Text = row.Cells(3).Value.ToString()
            txtQuantity.Text = row.Cells(4).Value.ToString()
            If String.IsNullOrWhiteSpace(txtName.Text) Then
                _selectedItemKey = 0
            Else
                _selectedItemKey = Integer.Parse(row.Cells(0).Value.ToString())
            End If
        Catch ex As Exception
            _selectedItemKey = 0
        End Try
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If _selectedItemKey = 0 Then
            MsgBox("Select item to delete!")
        Else
            Connection.Open()
            Dim ccommand = New SqlCommand($"DELETE FROM Items WHERE Id = {_selectedItemKey}", Connection)
            ccommand.ExecuteNonQuery()
            MsgBox("Item deleted!")
            Connection.Close()
            Reset()
            DisplayItems()
        End If
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If ValidateItemTextboxes() Then
            If _selectedItemKey = 0 Then
                MsgBox("Select item to edit!")
            Else
                Connection.Open()
                Dim cmd = New SqlCommand($"UPDATE Items SET Name='{txtName.Text}', Category='{cbxCategory.SelectedValue.ToString()}', Price={txtPrice.Text.Replace(",", ".")}, Quantity={txtQuantity.Text} WHERE Id = {_selectedItemKey}", Connection)
                cmd.ExecuteNonQuery()
                MsgBox("Item edited!")
                Connection.Close()
                Reset()
                DisplayItems()
            End If
        End If
    End Sub
End Class