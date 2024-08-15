<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        tc = New TabControl()
        TabPage1 = New TabPage()
        numMax = New NumericUpDown()
        numMin = New NumericUpDown()
        Label13 = New Label()
        Label12 = New Label()
        txtHost = New TextBox()
        txtDescrip = New TextBox()
        txtAddress = New TextBox()
        txtAppAdd = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        numBathrooms = New NumericUpDown()
        Label6 = New Label()
        numBedrooms = New NumericUpDown()
        Label5 = New Label()
        numBeds = New NumericUpDown()
        Label4 = New Label()
        numCapacity = New NumericUpDown()
        Label3 = New Label()
        cbType = New ComboBox()
        Label2 = New Label()
        txtTitle = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        gvAenities = New DataGridView()
        Label14 = New Label()
        TabPage3 = New TabPage()
        gvDistance = New DataGridView()
        Label15 = New Label()
        btnNext = New Button()
        btnClose = New Button()
        tc.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(numMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(numMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBathrooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBedrooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(numBeds, ComponentModel.ISupportInitialize).BeginInit()
        CType(numCapacity, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(gvAenities, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(gvDistance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tc
        ' 
        tc.Controls.Add(TabPage1)
        tc.Controls.Add(TabPage2)
        tc.Controls.Add(TabPage3)
        tc.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tc.Location = New Point(56, 44)
        tc.Margin = New Padding(4)
        tc.Name = "tc"
        tc.SelectedIndex = 0
        tc.Size = New Size(1032, 481)
        tc.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(numMax)
        TabPage1.Controls.Add(numMin)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(txtHost)
        TabPage1.Controls.Add(txtDescrip)
        TabPage1.Controls.Add(txtAddress)
        TabPage1.Controls.Add(txtAppAdd)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(numBathrooms)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(numBedrooms)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(numBeds)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(numCapacity)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(cbType)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txtTitle)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 32)
        TabPage1.Margin = New Padding(4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(4)
        TabPage1.Size = New Size(1024, 445)
        TabPage1.TabIndex = 0
        TabPage1.Text = "ta"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' numMax
        ' 
        numMax.Location = New Point(771, 380)
        numMax.Margin = New Padding(2)
        numMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        numMax.Name = "numMax"
        numMax.Size = New Size(49, 30)
        numMax.TabIndex = 25
        ' 
        ' numMin
        ' 
        numMin.Location = New Point(503, 380)
        numMin.Margin = New Padding(2)
        numMin.Name = "numMin"
        numMin.Size = New Size(50, 30)
        numMin.TabIndex = 24
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(668, 382)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(97, 23)
        Label13.TabIndex = 23
        Label13.Text = "Maximum :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(404, 382)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(93, 23)
        Label12.TabIndex = 22
        Label12.Text = "Minimum :"
        ' 
        ' txtHost
        ' 
        txtHost.Location = New Point(301, 314)
        txtHost.Margin = New Padding(4)
        txtHost.Name = "txtHost"
        txtHost.Size = New Size(669, 30)
        txtHost.TabIndex = 21
        ' 
        ' txtDescrip
        ' 
        txtDescrip.Location = New Point(301, 262)
        txtDescrip.Margin = New Padding(4)
        txtDescrip.Name = "txtDescrip"
        txtDescrip.Size = New Size(669, 30)
        txtDescrip.TabIndex = 20
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(301, 202)
        txtAddress.Margin = New Padding(4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(669, 30)
        txtAddress.TabIndex = 19
        ' 
        ' txtAppAdd
        ' 
        txtAppAdd.Location = New Point(301, 146)
        txtAppAdd.Margin = New Padding(4)
        txtAppAdd.Name = "txtAppAdd"
        txtAppAdd.Size = New Size(669, 30)
        txtAppAdd.TabIndex = 18
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(8, 382)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(219, 23)
        Label11.TabIndex = 17
        Label11.Text = "Reservation Time (Nights) :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 318)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 23)
        Label10.TabIndex = 16
        Label10.Text = "Host Rules :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 266)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 23)
        Label9.TabIndex = 15
        Label9.Text = "Description :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 206)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(125, 23)
        Label8.TabIndex = 14
        Label8.Text = "Exact Address :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 144)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(183, 23)
        Label7.TabIndex = 13
        Label7.Text = "Approximate Address :"
        ' 
        ' numBathrooms
        ' 
        numBathrooms.Location = New Point(866, 86)
        numBathrooms.Margin = New Padding(2)
        numBathrooms.Name = "numBathrooms"
        numBathrooms.Size = New Size(43, 30)
        numBathrooms.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(669, 88)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(191, 23)
        Label6.TabIndex = 11
        Label6.Text = "Number of Bathrooms :"
        ' 
        ' numBedrooms
        ' 
        numBedrooms.Location = New Point(590, 84)
        numBedrooms.Margin = New Padding(2)
        numBedrooms.Name = "numBedrooms"
        numBedrooms.Size = New Size(44, 30)
        numBedrooms.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(399, 88)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 23)
        Label5.TabIndex = 9
        Label5.Text = "Number of Bedrooms :"
        ' 
        ' numBeds
        ' 
        numBeds.Location = New Point(317, 88)
        numBeds.Margin = New Padding(2)
        numBeds.Name = "numBeds"
        numBeds.Size = New Size(44, 30)
        numBeds.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(156, 88)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 23)
        Label4.TabIndex = 7
        Label4.Text = "Number of Beds :"
        ' 
        ' numCapacity
        ' 
        numCapacity.Location = New Point(103, 86)
        numCapacity.Margin = New Padding(2)
        numCapacity.Name = "numCapacity"
        numCapacity.Size = New Size(47, 30)
        numCapacity.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 86)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 23)
        Label3.TabIndex = 5
        Label3.Text = "Capacity :"
        ' 
        ' cbType
        ' 
        cbType.FormattingEnabled = True
        cbType.Location = New Point(95, 14)
        cbType.Margin = New Padding(4)
        cbType.Name = "cbType"
        cbType.Size = New Size(359, 31)
        cbType.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(500, 24)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 23)
        Label2.TabIndex = 3
        Label2.Text = "Title :"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(580, 16)
        txtTitle.Margin = New Padding(4)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(366, 30)
        txtTitle.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 14)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 23)
        Label1.TabIndex = 0
        Label1.Text = "Type :"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(gvAenities)
        TabPage2.Controls.Add(Label14)
        TabPage2.Location = New Point(4, 32)
        TabPage2.Margin = New Padding(4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(4)
        TabPage2.Size = New Size(1024, 445)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Amenities"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' gvAenities
        ' 
        gvAenities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvAenities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gvAenities.Location = New Point(20, 51)
        gvAenities.Name = "gvAenities"
        gvAenities.RowHeadersVisible = False
        gvAenities.RowHeadersWidth = 51
        gvAenities.SelectionMode = DataGridViewSelectionMode.CellSelect
        gvAenities.Size = New Size(986, 376)
        gvAenities.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(20, 14)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(230, 23)
        Label14.TabIndex = 0
        Label14.Text = "Choose Available Amenities :"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(gvDistance)
        TabPage3.Controls.Add(Label15)
        TabPage3.Location = New Point(4, 32)
        TabPage3.Margin = New Padding(4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(4)
        TabPage3.Size = New Size(1024, 445)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Distance to Attration"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' gvDistance
        ' 
        gvDistance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gvDistance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gvDistance.Location = New Point(32, 58)
        gvDistance.Name = "gvDistance"
        gvDistance.RowHeadersVisible = False
        gvDistance.RowHeadersWidth = 51
        gvDistance.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gvDistance.Size = New Size(960, 366)
        gvDistance.TabIndex = 1
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(32, 19)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(681, 23)
        Label15.TabIndex = 0
        Label15.Text = "Specify the distance from each close by attraction and the time it takes to get to them :"
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(729, 542)
        btnNext.Margin = New Padding(4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(124, 38)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(875, 544)
        btnClose.Margin = New Padding(4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(191, 36)
        btnClose.TabIndex = 2
        btnClose.Text = "Close / Finish"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Edit
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 629)
        Controls.Add(btnClose)
        Controls.Add(btnNext)
        Controls.Add(tc)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Edit"
        Text = "Seoul Stay - Add/Edit Listing"
        tc.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(numMax, ComponentModel.ISupportInitialize).EndInit()
        CType(numMin, ComponentModel.ISupportInitialize).EndInit()
        CType(numBathrooms, ComponentModel.ISupportInitialize).EndInit()
        CType(numBedrooms, ComponentModel.ISupportInitialize).EndInit()
        CType(numBeds, ComponentModel.ISupportInitialize).EndInit()
        CType(numCapacity, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(gvAenities, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(gvDistance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tc As TabControl
    Friend WithEvents TabPage1 As TabPage
    Protected WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents numCapacity As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents numBathrooms As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents numBedrooms As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents numBeds As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAppAdd As TextBox
    Friend WithEvents numMax As NumericUpDown
    Friend WithEvents numMin As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Public WithEvents cbType As ComboBox
    Friend WithEvents gvAenities As DataGridView
    Friend WithEvents gvDistance As DataGridView
End Class
