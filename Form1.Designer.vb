<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        cbShow = New CheckBox()
        cbKeep = New CheckBox()
        txtPass = New TextBox()
        txtUser = New TextBox()
        txtEmp = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnLogin = New Button()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        btnExit = New Button()
        StatusStrip1 = New StatusStrip()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(142, 32)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(806, 153)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbShow)
        GroupBox1.Controls.Add(cbKeep)
        GroupBox1.Controls.Add(txtPass)
        GroupBox1.Controls.Add(txtUser)
        GroupBox1.Controls.Add(txtEmp)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(87, 191)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(938, 293)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login"
        ' 
        ' cbShow
        ' 
        cbShow.AutoSize = True
        cbShow.Location = New Point(609, 170)
        cbShow.Name = "cbShow"
        cbShow.Size = New Size(162, 29)
        cbShow.TabIndex = 7
        cbShow.Text = "Show Password"
        cbShow.UseVisualStyleBackColor = True
        ' 
        ' cbKeep
        ' 
        cbKeep.AutoSize = True
        cbKeep.Location = New Point(609, 96)
        cbKeep.Name = "cbKeep"
        cbKeep.Size = New Size(189, 29)
        cbKeep.TabIndex = 6
        cbKeep.Text = "Keep me signed in"
        cbKeep.UseVisualStyleBackColor = True
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(194, 209)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(359, 31)
        txtPass.TabIndex = 5
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(194, 130)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(359, 31)
        txtUser.TabIndex = 4
        ' 
        ' txtEmp
        ' 
        txtEmp.Location = New Point(194, 66)
        txtEmp.Name = "txtEmp"
        txtEmp.Size = New Size(359, 31)
        txtEmp.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(55, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 2
        Label4.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(55, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
        Label3.TabIndex = 1
        Label3.Text = "User :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(55, 70)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 0
        Label2.Text = "Employee :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ControlLightLight
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.ImageAlign = ContentAlignment.TopLeft
        btnLogin.Location = New Point(450, 508)
        btnLogin.Name = "btnLogin"
        btnLogin.Padding = New Padding(28, 0, 28, 0)
        btnLogin.Size = New Size(173, 38)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.TextAlign = ContentAlignment.TopRight
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(450, 579)
        Label5.Name = "Label5"
        Label5.Size = New Size(211, 25)
        Label5.TabIndex = 4
        Label5.Text = "Don't have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(666, 579)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(101, 25)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create one"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = SystemColors.ControlLightLight
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.TopLeft
        btnExit.Location = New Point(666, 508)
        btnExit.Name = "btnExit"
        btnExit.Padding = New Padding(28, 0, 28, 0)
        btnExit.Size = New Size(173, 38)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.TextAlign = ContentAlignment.TopRight
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Location = New Point(0, 627)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 15, 0)
        StatusStrip1.Size = New Size(1114, 22)
        StatusStrip1.TabIndex = 7
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1114, 649)
        Controls.Add(btnLogin)
        Controls.Add(StatusStrip1)
        Controls.Add(btnExit)
        Controls.Add(LinkLabel1)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Seoul Stay - Welcome"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmp As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cbShow As CheckBox
    Friend WithEvents cbKeep As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip

End Class
