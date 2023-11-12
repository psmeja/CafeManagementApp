<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnViewOrders = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPlaceOrder = New System.Windows.Forms.Label()
        Me.btnAddToBill = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.dgvBill = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblYourOrder = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblManageItems = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pdPrintBill = New System.Drawing.Printing.PrintDocument()
        Me.ppdPrintBIll = New System.Windows.Forms.PrintPreviewDialog()
        Me.pnlItems.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.White
        Me.pnlItems.Controls.Add(Me.dgvItems)
        Me.pnlItems.Controls.Add(Me.btnPrint)
        Me.pnlItems.Controls.Add(Me.btnViewOrders)
        Me.pnlItems.Controls.Add(Me.lblTotal)
        Me.pnlItems.Controls.Add(Me.lblPlaceOrder)
        Me.pnlItems.Controls.Add(Me.btnAddToBill)
        Me.pnlItems.Controls.Add(Me.btnClear)
        Me.pnlItems.Controls.Add(Me.cbxCategory)
        Me.pnlItems.Controls.Add(Me.dgvBill)
        Me.pnlItems.Controls.Add(Me.lblYourOrder)
        Me.pnlItems.Controls.Add(Me.txtQuantity)
        Me.pnlItems.Controls.Add(Me.lblQuantity)
        Me.pnlItems.Controls.Add(Me.lblManageItems)
        Me.pnlItems.Location = New System.Drawing.Point(172, 51)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(1096, 592)
        Me.pnlItems.TabIndex = 1
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.Location = New System.Drawing.Point(529, 96)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(512, 99)
        Me.dgvItems.TabIndex = 26
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.SteelBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(335, 514)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(151, 30)
        Me.btnPrint.TabIndex = 25
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnViewOrders
        '
        Me.btnViewOrders.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewOrders.FlatAppearance.BorderSize = 0
        Me.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnViewOrders.ForeColor = System.Drawing.Color.White
        Me.btnViewOrders.Location = New System.Drawing.Point(633, 514)
        Me.btnViewOrders.Name = "btnViewOrders"
        Me.btnViewOrders.Size = New System.Drawing.Size(151, 30)
        Me.btnViewOrders.TabIndex = 24
        Me.btnViewOrders.Text = "View Orders"
        Me.btnViewOrders.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotal.Location = New System.Drawing.Point(531, 516)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 25)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Total"
        '
        'lblPlaceOrder
        '
        Me.lblPlaceOrder.AutoSize = True
        Me.lblPlaceOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPlaceOrder.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPlaceOrder.Location = New System.Drawing.Point(707, 64)
        Me.lblPlaceOrder.Name = "lblPlaceOrder"
        Me.lblPlaceOrder.Size = New System.Drawing.Size(143, 29)
        Me.lblPlaceOrder.TabIndex = 22
        Me.lblPlaceOrder.Text = "Place Order"
        '
        'btnAddToBill
        '
        Me.btnAddToBill.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddToBill.FlatAppearance.BorderSize = 0
        Me.btnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddToBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddToBill.ForeColor = System.Drawing.Color.White
        Me.btnAddToBill.Location = New System.Drawing.Point(836, 201)
        Me.btnAddToBill.Name = "btnAddToBill"
        Me.btnAddToBill.Size = New System.Drawing.Size(151, 30)
        Me.btnAddToBill.TabIndex = 17
        Me.btnAddToBill.Text = "Add To Bill"
        Me.btnAddToBill.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(234, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 33)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'cbxCategory
        '
        Me.cbxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbxCategory.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(47, 64)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(181, 33)
        Me.cbxCategory.TabIndex = 19
        '
        'dgvBill
        '
        Me.dgvBill.AllowUserToAddRows = False
        Me.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBill.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBill.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBill.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Product, Me.Price, Me.Quantity, Me.Total})
        Me.dgvBill.EnableHeadersVisualStyles = False
        Me.dgvBill.Location = New System.Drawing.Point(41, 313)
        Me.dgvBill.Name = "dgvBill"
        Me.dgvBill.RowHeadersVisible = False
        Me.dgvBill.RowHeadersWidth = 51
        Me.dgvBill.RowTemplate.Height = 24
        Me.dgvBill.Size = New System.Drawing.Size(1000, 195)
        Me.dgvBill.TabIndex = 18
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.MinimumWidth = 6
        Me.Product.Name = "Product"
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        '
        'lblYourOrder
        '
        Me.lblYourOrder.AutoSize = True
        Me.lblYourOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblYourOrder.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblYourOrder.Location = New System.Drawing.Point(486, 281)
        Me.lblYourOrder.Name = "lblYourOrder"
        Me.lblYourOrder.Size = New System.Drawing.Size(133, 29)
        Me.lblYourOrder.TabIndex = 17
        Me.lblYourOrder.Text = "Your Order"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtQuantity.Location = New System.Drawing.Point(622, 201)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(208, 30)
        Me.txtQuantity.TabIndex = 10
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblQuantity.Location = New System.Drawing.Point(531, 201)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(85, 25)
        Me.lblQuantity.TabIndex = 9
        Me.lblQuantity.Text = "Quantity"
        '
        'lblManageItems
        '
        Me.lblManageItems.AutoSize = True
        Me.lblManageItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblManageItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblManageItems.Location = New System.Drawing.Point(458, 19)
        Me.lblManageItems.Name = "lblManageItems"
        Me.lblManageItems.Size = New System.Drawing.Size(164, 29)
        Me.lblManageItems.TabIndex = 2
        Me.lblManageItems.Text = "Manage Items"
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(12, 617)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(87, 29)
        Me.lblLogout.TabIndex = 20
        Me.lblLogout.Text = "Logout"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClose.Location = New System.Drawing.Point(1240, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "✖"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pdPrintBill
        '
        '
        'ppdPrintBIll
        '
        Me.ppdPrintBIll.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdPrintBIll.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdPrintBIll.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdPrintBIll.Document = Me.pdPrintBill
        Me.ppdPrintBIll.Enabled = True
        Me.ppdPrintBIll.Icon = CType(resources.GetObject("ppdPrintBIll.Icon"), System.Drawing.Icon)
        Me.ppdPrintBIll.Name = "ppdPrintBIll"
        Me.ppdPrintBIll.Visible = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1280, 655)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.pnlItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlItems As Panel
    Friend WithEvents dgvBill As DataGridView
    Friend WithEvents lblYourOrder As Label
    Friend WithEvents btnAddToBill As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblManageItems As Label
    Friend WithEvents lblPlaceOrder As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnViewOrders As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents pdPrintBill As Printing.PrintDocument
    Friend WithEvents ppdPrintBIll As PrintPreviewDialog
End Class
