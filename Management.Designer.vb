<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        txtSearch = New TextBox()
        gvProperty = New DataGridView()
        TabPage2 = New TabPage()
        Add = New Button()
        gvMeProperty = New DataGridView()
        StatusStrip1 = New StatusStrip()
        tslbCout = New ToolStripStatusLabel()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnExit = New Button()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(gvProperty, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(gvMeProperty, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(15, 165)
        TabControl1.Margin = New Padding(4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(948, 386)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(txtSearch)
        TabPage1.Controls.Add(gvProperty)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(940, 348)
        TabPage1.TabIndex = 0
        TabPage1.Text = "I'm Taverler"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(31, 24)
        txtSearch.Margin = New Padding(4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search destination or Listing Title or Attaction"
        txtSearch.Size = New Size(610, 31)
        txtSearch.TabIndex = 1
        ' 
        ' gvProperty
        ' 
        gvProperty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvProperty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gvProperty.Location = New Point(31, 72)
        gvProperty.Margin = New Padding(4)
        gvProperty.Name = "gvProperty"
        gvProperty.RowHeadersVisible = False
        gvProperty.RowHeadersWidth = 51
        DataGridViewCellStyle1.ForeColor = Color.Black
        gvProperty.RowsDefaultCellStyle = DataGridViewCellStyle1
        gvProperty.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gvProperty.Size = New Size(881, 252)
        gvProperty.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Add)
        TabPage2.Controls.Add(gvMeProperty)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(940, 348)
        TabPage2.TabIndex = 1
        TabPage2.Text = "I'm Owerner / Manager"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Add
        ' 
        Add.BackColor = Color.White
        Add.Cursor = Cursors.Hand
        Add.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Add.Image = CType(resources.GetObject("Add.Image"), Image)
        Add.ImageAlign = ContentAlignment.MiddleLeft
        Add.Location = New Point(21, 8)
        Add.Margin = New Padding(4)
        Add.Name = "Add"
        Add.Padding = New Padding(31, 0, 31, 0)
        Add.Size = New Size(280, 45)
        Add.TabIndex = 2
        Add.Text = "Add Listing"
        Add.TextAlign = ContentAlignment.MiddleRight
        Add.TextImageRelation = TextImageRelation.ImageBeforeText
        Add.UseVisualStyleBackColor = False
        ' 
        ' gvMeProperty
        ' 
        gvMeProperty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvMeProperty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gvMeProperty.Location = New Point(21, 60)
        gvMeProperty.Margin = New Padding(4)
        gvMeProperty.Name = "gvMeProperty"
        gvMeProperty.RowHeadersVisible = False
        gvMeProperty.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle2.ForeColor = Color.Black
        gvMeProperty.RowsDefaultCellStyle = DataGridViewCellStyle2
        gvMeProperty.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gvMeProperty.Size = New Size(891, 258)
        gvMeProperty.TabIndex = 0
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslbCout})
        StatusStrip1.Location = New Point(0, 570)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 18, 0)
        StatusStrip1.Size = New Size(1000, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslbCout
        ' 
        tslbCout.Name = "tslbCout"
        tslbCout.Size = New Size(0, 16)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(78, 15)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(810, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(689, 144)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(118, 36)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(815, 144)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(118, 36)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Management
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 592)
        Controls.Add(btnExit)
        Controls.Add(btnLogout)
        Controls.Add(PictureBox1)
        Controls.Add(StatusStrip1)
        Controls.Add(TabControl1)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Management"
        Text = "Seoul Stay - Management"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(gvProperty, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        CType(gvMeProperty, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents gvProperty As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents gvMeProperty As DataGridView
    Friend WithEvents Add As Button
    Friend WithEvents tslbCout As ToolStripStatusLabel
End Class
