<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents tUsername As System.Windows.Forms.TextBox
    Friend WithEvents tPassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.tUsername = New System.Windows.Forms.TextBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.helpPLogin = New System.Windows.Forms.HelpProvider()
        Me.logoTerminal = New System.Windows.Forms.PictureBox()
        Me.groupBoxChangePassword = New System.Windows.Forms.GroupBox()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChgPass = New System.Windows.Forms.Button()
        CType(Me.logoTerminal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxChangePassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameLabel.Location = New System.Drawing.Point(159, 10)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(44, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User id:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(159, 50)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(57, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tUsername
        '
        Me.helpPLogin.SetHelpString(Me.tUsername, "Key in your user name to enter system")
        Me.tUsername.Location = New System.Drawing.Point(159, 26)
        Me.tUsername.Name = "tUsername"
        Me.helpPLogin.SetShowHelp(Me.tUsername, True)
        Me.tUsername.Size = New System.Drawing.Size(169, 21)
        Me.tUsername.TabIndex = 1
        '
        'tPassword
        '
        Me.helpPLogin.SetHelpString(Me.tPassword, "Your password to protect your account")
        Me.tPassword.Location = New System.Drawing.Point(159, 68)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.helpPLogin.SetShowHelp(Me.tPassword, True)
        Me.tPassword.Size = New System.Drawing.Size(169, 21)
        Me.tPassword.TabIndex = 2
        Me.tPassword.UseSystemPasswordChar = True
        '
        'OK
        '
        Me.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpPLogin.SetHelpString(Me.OK, "Click here to login system")
        Me.OK.Location = New System.Drawing.Point(282, 250)
        Me.OK.Name = "OK"
        Me.helpPLogin.SetShowHelp(Me.OK, True)
        Me.OK.Size = New System.Drawing.Size(48, 24)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpPLogin.SetHelpString(Me.Cancel, "Click here to cancel login and exit application")
        Me.Cancel.Location = New System.Drawing.Point(228, 250)
        Me.Cancel.Name = "Cancel"
        Me.helpPLogin.SetShowHelp(Me.Cancel, True)
        Me.Cancel.Size = New System.Drawing.Size(48, 24)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'logoTerminal
        '
        Me.logoTerminal.Image = CType(resources.GetObject("logoTerminal.Image"), System.Drawing.Image)
        Me.logoTerminal.Location = New System.Drawing.Point(12, 12)
        Me.logoTerminal.Name = "logoTerminal"
        Me.logoTerminal.Size = New System.Drawing.Size(141, 80)
        Me.logoTerminal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoTerminal.TabIndex = 9
        Me.logoTerminal.TabStop = False
        '
        'groupBoxChangePassword
        '
        Me.groupBoxChangePassword.Controls.Add(Me.txtConfirmPassword)
        Me.groupBoxChangePassword.Controls.Add(Me.Label3)
        Me.groupBoxChangePassword.Controls.Add(Me.txtNewPassword)
        Me.groupBoxChangePassword.Controls.Add(Me.Label2)
        Me.groupBoxChangePassword.Location = New System.Drawing.Point(12, 95)
        Me.groupBoxChangePassword.Name = "groupBoxChangePassword"
        Me.groupBoxChangePassword.Size = New System.Drawing.Size(316, 129)
        Me.groupBoxChangePassword.TabIndex = 10
        Me.groupBoxChangePassword.TabStop = False
        Me.groupBoxChangePassword.Text = "Change Password"
        Me.groupBoxChangePassword.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(120, 73)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(169, 21)
        Me.txtConfirmPassword.TabIndex = 5
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Confirm Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(120, 37)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(169, 21)
        Me.txtNewPassword.TabIndex = 4
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&New Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnChgPass
        '
        Me.btnChgPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnChgPass.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChgPass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnChgPass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPass.Location = New System.Drawing.Point(14, 250)
        Me.btnChgPass.Name = "btnChgPass"
        Me.btnChgPass.Size = New System.Drawing.Size(108, 24)
        Me.btnChgPass.TabIndex = 5
        Me.btnChgPass.Text = "C&hange Password..."
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(344, 282)
        Me.Controls.Add(Me.groupBoxChangePassword)
        Me.Controls.Add(Me.logoTerminal)
        Me.Controls.Add(Me.btnChgPass)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.tPassword)
        Me.Controls.Add(Me.tUsername)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        CType(Me.logoTerminal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxChangePassword.ResumeLayout(False)
        Me.groupBoxChangePassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents helpPLogin As System.Windows.Forms.HelpProvider
    Friend WithEvents logoTerminal As System.Windows.Forms.PictureBox
    Friend WithEvents groupBoxChangePassword As System.Windows.Forms.GroupBox
    Friend WithEvents btnChgPass As System.Windows.Forms.Button
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
