<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
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
        GroupBox1 = New GroupBox()
        cbAgree = New CheckBox()
        lnkViewTerm = New LinkLabel()
        numFamily = New NumericUpDown()
        Label6 = New Label()
        rdoFe = New RadioButton()
        rdoMale = New RadioButton()
        txtConfirmPass = New TextBox()
        Label5 = New Label()
        dtpDob = New DateTimePicker()
        txtPass = New TextBox()
        txtName = New TextBox()
        txtUser = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnToRegis = New Button()
        btnToLogin = New Button()
        StatusStrip1 = New StatusStrip()
        GroupBox1.SuspendLayout()
        CType(numFamily, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbAgree)
        GroupBox1.Controls.Add(lnkViewTerm)
        GroupBox1.Controls.Add(numFamily)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(rdoFe)
        GroupBox1.Controls.Add(rdoMale)
        GroupBox1.Controls.Add(txtConfirmPass)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(dtpDob)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(79, 55)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(1001, 409)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Your Information"
        ' 
        ' cbAgree
        ' 
        cbAgree.AutoSize = True
        cbAgree.Location = New Point(49, 369)
        cbAgree.Margin = New Padding(4)
        cbAgree.Name = "cbAgree"
        cbAgree.Size = New Size(327, 29)
        cbAgree.TabIndex = 15
        cbAgree.Text = "I agree to the Temes and Condition"
        cbAgree.UseVisualStyleBackColor = True
        ' 
        ' lnkViewTerm
        ' 
        lnkViewTerm.AutoSize = True
        lnkViewTerm.Location = New Point(662, 370)
        lnkViewTerm.Margin = New Padding(4, 0, 4, 0)
        lnkViewTerm.Name = "lnkViewTerm"
        lnkViewTerm.Size = New Size(239, 25)
        lnkViewTerm.TabIndex = 14
        lnkViewTerm.TabStop = True
        lnkViewTerm.Text = "View Terms and Conditions"
        ' 
        ' numFamily
        ' 
        numFamily.Location = New Point(770, 149)
        numFamily.Margin = New Padding(4)
        numFamily.Name = "numFamily"
        numFamily.Size = New Size(55, 31)
        numFamily.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(512, 151)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(253, 25)
        Label6.TabIndex = 12
        Label6.Text = "Number of Family Members :"
        ' 
        ' rdoFe
        ' 
        rdoFe.AutoSize = True
        rdoFe.Location = New Point(766, 74)
        rdoFe.Margin = New Padding(4)
        rdoFe.Name = "rdoFe"
        rdoFe.Size = New Size(92, 29)
        rdoFe.TabIndex = 11
        rdoFe.TabStop = True
        rdoFe.Text = "Female"
        rdoFe.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(612, 72)
        rdoMale.Margin = New Padding(4)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(74, 29)
        rdoMale.TabIndex = 10
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPass
        ' 
        txtConfirmPass.Location = New Point(681, 289)
        txtConfirmPass.Margin = New Padding(4)
        txtConfirmPass.Name = "txtConfirmPass"
        txtConfirmPass.PasswordChar = "*"c
        txtConfirmPass.Size = New Size(312, 31)
        txtConfirmPass.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(512, 292)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 25)
        Label5.TabIndex = 8
        Label5.Text = "Retype Password:"
        ' 
        ' dtpDob
        ' 
        dtpDob.Location = New Point(192, 221)
        dtpDob.Margin = New Padding(4)
        dtpDob.Name = "dtpDob"
        dtpDob.Size = New Size(312, 31)
        dtpDob.TabIndex = 7
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(192, 289)
        txtPass.Margin = New Padding(4)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(312, 31)
        txtPass.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(192, 142)
        txtName.Margin = New Padding(4)
        txtName.Name = "txtName"
        txtName.Size = New Size(312, 31)
        txtName.TabIndex = 5
        txtName.Text = "  "
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(192, 69)
        txtUser.Margin = New Padding(4)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(312, 31)
        txtUser.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 292)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 3
        Label4.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 221)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 2
        Label3.Text = "Birtday :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 148)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 1
        Label2.Text = "Full Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 72)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 25)
        Label1.TabIndex = 0
        Label1.Text = "UserName :"
        ' 
        ' btnToRegis
        ' 
        btnToRegis.BackColor = SystemColors.ControlLightLight
        btnToRegis.Location = New Point(608, 485)
        btnToRegis.Margin = New Padding(4)
        btnToRegis.Name = "btnToRegis"
        btnToRegis.Size = New Size(220, 39)
        btnToRegis.TabIndex = 1
        btnToRegis.Text = "Register login"
        btnToRegis.UseVisualStyleBackColor = False
        ' 
        ' btnToLogin
        ' 
        btnToLogin.BackColor = SystemColors.ControlLightLight
        btnToLogin.Location = New Point(852, 488)
        btnToLogin.Margin = New Padding(4)
        btnToLogin.Name = "btnToLogin"
        btnToLogin.Size = New Size(228, 36)
        btnToLogin.TabIndex = 2
        btnToLogin.Text = "Return login form"
        btnToLogin.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Location = New Point(0, 540)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 18, 0)
        StatusStrip1.Size = New Size(1135, 22)
        StatusStrip1.TabIndex = 3
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' CreateAccount
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1135, 562)
        Controls.Add(StatusStrip1)
        Controls.Add(btnToLogin)
        Controls.Add(btnToRegis)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "CreateAccount"
        Text = "Seoul Stay - Create Account"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(numFamily, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rdoFe As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents cbAgree As CheckBox
    Friend WithEvents lnkViewTerm As LinkLabel
    Friend WithEvents numFamily As NumericUpDown
    Friend WithEvents btnToRegis As Button
    Friend WithEvents btnToLogin As Button
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
