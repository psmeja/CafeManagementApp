<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PnlSeller = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSeller = New System.Windows.Forms.Button()
        Me.lblCafeManagementApp = New System.Windows.Forms.Label()
        Me.lblAdminPanel = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PnlSeller.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlSeller
        '
        Me.PnlSeller.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlSeller.Controls.Add(Me.btnClose)
        Me.PnlSeller.Controls.Add(Me.btnSeller)
        Me.PnlSeller.Controls.Add(Me.lblCafeManagementApp)
        Me.PnlSeller.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlSeller.Location = New System.Drawing.Point(450, 0)
        Me.PnlSeller.Name = "PnlSeller"
        Me.PnlSeller.Size = New System.Drawing.Size(540, 445)
        Me.PnlSeller.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClose.Location = New System.Drawing.Point(500, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "✖"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSeller
        '
        Me.btnSeller.BackColor = System.Drawing.Color.White
        Me.btnSeller.FlatAppearance.BorderSize = 0
        Me.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeller.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSeller.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSeller.Location = New System.Drawing.Point(151, 141)
        Me.btnSeller.Name = "btnSeller"
        Me.btnSeller.Size = New System.Drawing.Size(253, 104)
        Me.btnSeller.TabIndex = 7
        Me.btnSeller.Text = "Seller"
        Me.btnSeller.UseVisualStyleBackColor = False
        '
        'lblCafeManagementApp
        '
        Me.lblCafeManagementApp.AutoSize = True
        Me.lblCafeManagementApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCafeManagementApp.ForeColor = System.Drawing.Color.White
        Me.lblCafeManagementApp.Location = New System.Drawing.Point(146, 26)
        Me.lblCafeManagementApp.Name = "lblCafeManagementApp"
        Me.lblCafeManagementApp.Size = New System.Drawing.Size(258, 29)
        Me.lblCafeManagementApp.TabIndex = 0
        Me.lblCafeManagementApp.Text = "Cafe Management App"
        '
        'lblAdminPanel
        '
        Me.lblAdminPanel.AutoSize = True
        Me.lblAdminPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAdminPanel.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblAdminPanel.Location = New System.Drawing.Point(179, 26)
        Me.lblAdminPanel.Name = "lblAdminPanel"
        Me.lblAdminPanel.Size = New System.Drawing.Size(149, 29)
        Me.lblAdminPanel.TabIndex = 1
        Me.lblAdminPanel.Text = "Admin Panel"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblUserName.Location = New System.Drawing.Point(12, 166)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(130, 29)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "User name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPassword.Location = New System.Drawing.Point(22, 216)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(120, 29)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtUserName.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtUserName.Location = New System.Drawing.Point(148, 163)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(208, 34)
        Me.txtUserName.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.SteelBlue
        Me.txtPassword.Location = New System.Drawing.Point(148, 211)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(208, 34)
        Me.txtPassword.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(184, 274)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(144, 45)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 445)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblAdminPanel)
        Me.Controls.Add(Me.PnlSeller)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cafe Management App"
        Me.PnlSeller.ResumeLayout(False)
        Me.PnlSeller.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlSeller As Panel
    Friend WithEvents lblCafeManagementApp As Label
    Friend WithEvents lblAdminPanel As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents btnSeller As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
End Class
