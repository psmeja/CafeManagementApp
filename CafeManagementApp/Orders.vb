Imports System.Data.SqlClient

Public Class Orders

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

    Dim _productName As String
    Dim _productPrice As Decimal
    Dim _stock As Integer = 0
    Dim _selectedItemKey As Integer = 0
    Dim _itemNumberOnTheBill = 0
    Dim _billTotal = 0

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Dim login = New Login
        login.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

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

    Private Sub DisplayItemsFilterByCategory(category As String)
        Connection.Open()
        Dim command = New SqlCommand($"SELECT * FROM Items WHERE Category='{category}'", Connection)
        Dim adapter = New SqlDataAdapter(command)
        Dim dataSet = New DataSet()
        adapter.Fill(dataSet)
        dgvItems.DataSource = dataSet.Tables(0)
        Connection.Close()
        dgvItems.ClearSelection()
    End Sub


    Private Sub FillCategories()
        Connection.Open()
        Dim ccommand = New SqlCommand("SELECT * FROM Categories", Connection)
        Dim adapter = New SqlDataAdapter(ccommand)
        Dim table = New DataTable()
        adapter.Fill(table)
        cbxCategory.DataSource = table
        cbxCategory.DisplayMember = "Name"
        cbxCategory.ValueMember = "Name"
        Connection.Close()
    End Sub

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItems()
        FillCategories()
    End Sub

    Private Sub cbxCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxCategory.SelectionChangeCommitted
        DisplayItemsFilterByCategory(cbxCategory.SelectedValue.ToString())
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DisplayItems()
    End Sub

    Private Sub dgvItems_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvItems.CellMouseClick
        Try
            Dim row As DataGridViewRow = dgvItems.Rows(e.RowIndex)
            _productName = row.Cells(1).Value.ToString()
            If String.IsNullOrWhiteSpace(_productName) Then
                _selectedItemKey = 0
                _stock = 0
            Else
                _selectedItemKey = Integer.Parse(row.Cells(0).Value.ToString())
                _productPrice = Decimal.Parse(row.Cells(3).Value.ToString())
                _stock = Integer.Parse(row.Cells(4).Value.ToString())
            End If
        Catch ex As Exception
            _selectedItemKey = 0
        End Try
    End Sub

    Private Sub btnAddToBill_Click(sender As Object, e As EventArgs) Handles btnAddToBill.Click
        Dim productQuantity = Integer.Parse(txtQuantity.Text)
        If _selectedItemKey = 0 Then
            MsgBox("Select item!")
        ElseIf productQuantity > _stock Then
            MsgBox("Not enaugh stock!")
        Else
            Dim rowNumber As Integer = dgvBill.Rows.Add()
            Dim productTotal = Decimal.Parse(txtQuantity.Text) * _productPrice
            _itemNumberOnTheBill += 1
            dgvBill.Rows.Item(rowNumber).Cells("Id").Value = _itemNumberOnTheBill
            dgvBill.Rows.Item(rowNumber).Cells("Product").Value = _productName
            dgvBill.Rows.Item(rowNumber).Cells("Price").Value = _productPrice
            dgvBill.Rows.Item(rowNumber).Cells("Quantity").Value = txtQuantity.Text
            dgvBill.Rows.Item(rowNumber).Cells("Total").Value = productTotal.ToString()
            _billTotal += productTotal
            lblTotal.Text = _billTotal.ToString()
            UpdateQuantityOfProduct()
            txtQuantity.Text = String.Empty
            _selectedItemKey = 0
        End If
    End Sub

    Private Sub UpdateQuantityOfProduct()
        Try
            Connection.Open()
            Dim newQuantity = _stock - Integer.Parse(txtQuantity.Text)
            Dim cmd = New SqlCommand($"UPDATE Items SET Quantity={newQuantity} WHERE Id = {_selectedItemKey}", Connection)
            cmd.ExecuteNonQuery()
            Connection.Close()
            DisplayItems()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AddBill()
        ppdPrintBIll.Show()
    End Sub

    Private Sub pdPrintBill_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrintBill.PrintPage
        e.Graphics.DrawString("Cafe Shop", New Font("Arial", 22), Brushes.SteelBlue, 335, 35)
        e.Graphics.DrawString("***Your Bill***", New Font("Arial", 14), Brushes.SteelBlue, 350, 60)

        Dim bitmap As New Bitmap(Me.dgvBill.Width, Me.dgvBill.Height)
        dgvBill.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.dgvBill.Width, Me.dgvBill.Height))
        e.Graphics.DrawImage(bitmap, 20, 90)
        e.Graphics.DrawString("Total Amount " + _billTotal.ToString(), New Font("Arial", 14), Brushes.SteelBlue, 340, 380)
        e.Graphics.DrawString("******Thank you for buying in our Cafe******", New Font("Arial", 14), Brushes.SteelBlue, 230, 400)
    End Sub

    Private Sub AddBill()
        Connection.Open()
        Dim values = $"{String.Join(",", $"'{DateTime.Now}'", _billTotal.ToString().Replace(",", "."))}"
        Dim command = New SqlCommand($"INSERT INTO Orders VALUES ({values})", Connection)
        command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Private Sub btnViewOrders_Click(sender As Object, e As EventArgs) Handles btnViewOrders.Click
        Dim viewOrders = New ViewOrders
        viewOrders.Show()
        Me.Hide()
    End Sub
End Class