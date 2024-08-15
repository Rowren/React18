Imports System.ComponentModel
Imports System.Data.SqlClient


Public Class Edit

    Private itemID As Long
    Private currentTabIndex As Integer = 0
    Private allowTabChange As Boolean = False
    Public Sub New(itemID As Long)

        ' This call is required by the designer.
        InitializeComponent()
        Me.itemID = itemID
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadItemType()

        Dim sql = "SELECT * FROM ItemTypes ORDER BY ID ASC"

        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(sql, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        cbType.Items.Add(reader.GetString("Name"))

                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub LoadData()
        If Me.itemID <> 0 Then
            Dim sql As String = $"SELECT * FROM Items WHERE ID = {Me.itemID}"
            Using connection As SqlConnection = GetConnection()
                Using Command As New SqlCommand(sql, connection)
                    Using reader As SqlDataReader = Command.ExecuteReader()
                        While reader.Read()
                            'ดึงค่าใส่ control ทีละอัน
                            Dim itemTypeID As Long = reader.GetInt64("ItemTypeID")
                            Dim title = reader.GetString("Title")
                            Dim capacity = reader.GetInt32("Capacity")
                            Dim best = reader.GetInt32("NumberOfBeds")
                            Dim bedroom = reader.GetInt32("NumberOfBedrooms")
                            Dim bathroom = reader.GetInt32("NumberOfBathrooms")
                            Dim app = reader.GetString("ApproximateAddress")
                            Dim Address = reader.GetString("ExactAddress")
                            Dim Dec = reader.GetString("Description")
                            Dim rules = reader.GetString("HostRules")
                            Dim min = reader.GetInt32("MinimumNights")
                            Dim max = reader.GetInt32("MaximumNights")

                            cbType.SelectedIndex = itemTypeID - 1
                            txtTitle.Text = title
                            numCapacity.Value = capacity
                            numBeds.Value = best
                            numBedrooms.Value = bedroom
                            numBathrooms.Value = bathroom
                            txtAppAdd.Text = app
                            txtAddress.Text = Address
                            txtDescrip.Text = Dec
                            txtHost.Text = rules
                            numMin.Value = min
                            numMax.Value = max
                        End While
                    End Using
                End Using
            End Using

        End If
    End Sub

    Private Sub LoadAmenities()
        Dim sql = $"SELECT ID, Name FROM Amenities"
        Using connection As SqlConnection = GetConnection()
            Using Command As New SqlCommand(sql, connection)
                Using adapter As New SqlDataAdapter(Command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Dim rowCount As Integer = dataTable.Rows.Count
                    gvAenities.DataSource = dataTable
                    gvAenities.Columns(0).Visible = False

                    Dim cbAmenities As New DataGridViewCheckBoxColumn With {
                        .HeaderText = "",
                        .Name = "hasProvide"
                    }
                    gvAenities.Columns.Add(cbAmenities)
                    gvAenities.Sort(gvAenities.Columns(1), ListSortDirection.Ascending)
                End Using
            End Using
        End Using
    End Sub

    Private Sub LaodAtt()
        Dim sql = $"SELECT dbo.Attractions.ID, dbo.Attractions.Name, dbo.Areas.ID AS AreaID, dbo.Areas.Name AS AreaName
                  FROM     dbo.Attractions INNER JOIN
                  dbo.Areas ON dbo.Attractions.AreaID = dbo.Areas.ID"
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(sql, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Dim rowCount As Integer = dataTable.Rows.Count
                    gvDistance.DataSource = dataTable
                    gvDistance.Columns(0).Visible = False
                    gvDistance.Columns(2).Visible = False

                    Dim txtdistance As New DataGridViewTextBoxColumn With {
                        .HeaderText = " Distane (km)",
                        .Name = "distance"
                    }
                    Dim txtOnfoot As New DataGridViewTextBoxColumn With {
                        .HeaderText = " On Foot (Minutes)",
                        .Name = "onfoot"
                    }

                    Dim txtByCar As New DataGridViewTextBoxColumn With {
                        .HeaderText = "By Car (Minutes)",
                        .Name = "bycar"
                    }

                    gvDistance.Columns.Add(txtdistance)
                    gvDistance.Columns.Add(txtOnfoot)
                    gvDistance.Columns.Add(txtByCar)
                    gvDistance.Sort(gvDistance.Columns(1), ListSortDirection.Ascending)
                End Using
            End Using
        End Using
    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItemType()
        LoadData()
        LoadAmenities()
        LaodAtt()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        allowTabChange = True ' Allow tab change
        currentTabIndex += 1

        ' Cycle through tabs
        If currentTabIndex < tc.TabPages.Count Then
            tc.SelectedIndex = currentTabIndex
        End If

        ' Update button label based on tab
        If tc.SelectedIndex = tc.TabPages.Count - 1 Then
            btnNext.Text = "Cancel"
        Else
            btnNext.Text = "Next"
        End If

        allowTabChange = False ' Disallow tab change after button click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles numBeds.ValueChanged

    End Sub

    Private Sub cbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbType.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub


    Private Sub gvAenities_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvAenities.CellContentClick

    End Sub

    Private Sub gvDistance_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvDistance.CellContentClick

    End Sub

    Private Sub tc_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tc.Selecting
        If Not allowTabChange Then
            e.Cancel = True
        End If
    End Sub
End Class