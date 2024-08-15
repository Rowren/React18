Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class Management
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvProperty.CellContentClick

    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim editForm As New Edit(0)
        editForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        currentUserID = 0
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql = $"SELECT DISTINCT i.ID, i.Title, i.Capacity, a.Name As [Area], t.Name as [Type]
            FROM Items i
                JOIN Areas a ON i.AreaID = a.ID
                JOIN ItemTypes t ON i.ItemTypeID = t.ID
           WHERE
                i.userID = {currentUserID}"

        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(sql, connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Dim rowCount As Integer = dataTable.Rows.Count
                    tslbCout.Text = $"{rowCount} items found"
                    gvMeProperty.DataSource = dataTable
                    gvMeProperty.Columns(0).Visible = False
                    Dim editColumn As New DataGridViewLinkColumn With {
                        .HeaderText = "",
                        .Name = "editDetails",
                        .UseColumnTextForLinkValue = True,
                        .Text = "Edit Datails"
                    }
                    gvMeProperty.Columns.Add(editColumn)
                    gvMeProperty.Sort(gvMeProperty.Columns(0), ListSortDirection.Ascending)
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim textSearch = txtSearch.Text
        If textSearch <> "" Then
            Dim sql = $"SELECT DISTINCT i.Title, i.Capacity, a.Name As [Area], t.Name as [Type]
 FROM Items i
     JOIN Areas a ON i.AreaID = a.ID
     JOIN ItemTypes t ON i.ItemTypeID = t.ID
  WHERE
     i.Title LIKE '%{textSearch}%'
     OR a.Name LIKE '%{textSearch}%' "
            Using connection As SqlConnection = GetConnection()
                Using command As New SqlCommand(sql, connection)
                    Using adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        Dim rowCount As Integer = dataTable.Rows.Count
                        tslbCout.Text = $"{rowCount} items found"
                        gvProperty.DataSource = dataTable
                        gvProperty.Sort(gvProperty.Columns(0), ListSortDirection.Ascending)
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub gvMeProperty_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvMeProperty.CellContentClick
        If e.ColumnIndex = gvMeProperty.Columns("editDetails").Index AndAlso e.RowIndex >= 0 Then
            Dim itemID As Long = CLng(gvMeProperty.Rows(e.RowIndex).Cells("ID").Value)

            Dim editForm As New Edit(itemID)
            editForm.Show()
        End If
    End Sub
End Class