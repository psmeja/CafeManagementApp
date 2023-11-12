<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Items
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.lblItemList = New System.Windows.Forms.Label()
        Me.btnAddNewCategory = New System.Windows.Forms.Button()
        Me.txtNewCategory = New System.Windows.Forms.TextBox()
        Me.lblNewCategory = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblManageItems = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.pnlItems.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.White
        Me.pnlItems.Controls.Add(Me.dgvItems)
        Me.pnlItems.Controls.Add(Me.lblItemList)
        Me.pnlItems.Controls.Add(Me.btnAddNewCategory)
        Me.pnlItems.Controls.Add(Me.txtNewCategory)
        Me.pnlItems.Controls.Add(Me.lblNewCategory)
        Me.pnlItems.Controls.Add(Me.Panel1)
        Me.pnlItems.Controls.Add(Me.lblManageItems)
        Me.pnlItems.Location = New System.Drawing.Point(172, 51)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(1096, 592)
        Me.pnlItems.TabIndex = 0
        '
        'dgvItems
        '
        Me.dgvItems.AllowUserToAddRows = False
        Me.dgvItems.AllowUserToDeleteRows = False
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItems.EnableHeadersVisualStyles = False
        Me.dgvItems.Location = New System.Drawing.Point(41, 325)
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.RowHeadersVisible = False
        Me.dgvItems.RowHeadersWidth = 51
        Me.dgvItems.RowTemplate.Height = 24
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(1000, 221)
        Me.dgvItems.TabIndex = 18
        '
        'lblItemList
        '
        Me.lblItemList.AutoSize = True
        Me.lblItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblItemList.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblItemList.Location = New System.Drawing.Point(492, 287)
        Me.lblItemList.Name = "lblItemList"
        Me.lblItemList.Size = New System.Drawing.Size(114, 29)
        Me.lblItemList.TabIndex = 17
        Me.lblItemList.Text = "Items List"
        '
        'btnAddNewCategory
        '
        Me.btnAddNewCategory.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddNewCategory.FlatAppearance.BorderSize = 0
        Me.btnAddNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddNewCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddNewCategory.Location = New System.Drawing.Point(329, 66)
        Me.btnAddNewCategory.Name = "btnAddNewCategory"
        Me.btnAddNewCategory.Size = New System.Drawing.Size(151, 30)
        Me.btnAddNewCategory.TabIndex = 16
        Me.btnAddNewCategory.Text = "Add Category"
        Me.btnAddNewCategory.UseVisualStyleBackColor = False
        '
        'txtNewCategory
        '
        Me.txtNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtNewCategory.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtNewCategory.Location = New System.Drawing.Point(106, 66)
        Me.txtNewCategory.Name = "txtNewCategory"
        Me.txtNewCategory.Size = New System.Drawing.Size(208, 30)
        Me.txtNewCategory.TabIndex = 15
        '
        'lblNewCategory
        '
        Me.lblNewCategory.AutoSize = True
        Me.lblNewCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNewCategory.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNewCategory.Location = New System.Drawing.Point(36, 71)
        Me.lblNewCategory.Name = "lblNewCategory"
        Me.lblNewCategory.Size = New System.Drawing.Size(64, 25)
        Me.lblNewCategory.TabIndex = 14
        Me.lblNewCategory.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnDeleteItem)
        Me.Panel1.Controls.Add(Me.btnEditItem)
        Me.Panel1.Controls.Add(Me.btnAddItem)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.lblCategory)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.cbxCategory)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.txtQuantity)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.lblQuantity)
        Me.Panel1.Location = New System.Drawing.Point(41, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 162)
        Me.Panel1.TabIndex = 13
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(3, 116)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 30)
        Me.btnReset.TabIndex = 19
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnDeleteItem.FlatAppearance.BorderSize = 0
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.White
        Me.btnDeleteItem.Location = New System.Drawing.Point(844, 116)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(151, 30)
        Me.btnDeleteItem.TabIndex = 18
        Me.btnDeleteItem.Text = "Delete"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'btnEditItem
        '
        Me.btnEditItem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditItem.FlatAppearance.BorderSize = 0
        Me.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEditItem.ForeColor = System.Drawing.Color.White
        Me.btnEditItem.Location = New System.Drawing.Point(687, 116)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(151, 30)
        Me.btnEditItem.TabIndex = 18
        Me.btnEditItem.Text = "Edit"
        Me.btnEditItem.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddItem.ForeColor = System.Drawing.Color.White
        Me.btnAddItem.Location = New System.Drawing.Point(530, 116)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(151, 30)
        Me.btnAddItem.TabIndex = 17
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtName.Location = New System.Drawing.Point(52, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 30)
        Me.txtName.TabIndex = 6
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCategory.Location = New System.Drawing.Point(279, 38)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(92, 25)
        Me.lblCategory.TabIndex = 12
        Me.lblCategory.Text = "Category"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblName.Location = New System.Drawing.Point(47, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'cbxCategory
        '
        Me.cbxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbxCategory.ForeColor = System.Drawing.Color.SteelBlue
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(284, 66)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(181, 33)
        Me.cbxCategory.TabIndex = 11
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPrice.Location = New System.Drawing.Point(492, 41)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(56, 25)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtQuantity.Location = New System.Drawing.Point(730, 69)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(208, 30)
        Me.txtQuantity.TabIndex = 10
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtPrice.Location = New System.Drawing.Point(497, 69)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(208, 30)
        Me.txtPrice.TabIndex = 8
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblQuantity.Location = New System.Drawing.Point(725, 41)
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
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClose.Location = New System.Drawing.Point(1240, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "✖"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(12, 614)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(87, 29)
        Me.lblLogout.TabIndex = 19
        Me.lblLogout.Text = "Logout"
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1280, 655)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.pnlItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlItems As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblManageItems As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCategory As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtNewCategory As TextBox
    Friend WithEvents lblNewCategory As Label
    Friend WithEvents btnAddNewCategory As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents lblItemList As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnReset As Button
End Class
