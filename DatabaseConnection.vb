

Imports System.Data.SqlClient

Module DatabaseConnection
    Public Function GetConnection() As SqlConnection
        Dim connectionString As String = "Server=DESKTOP-AR4NLJ5\SQLEXPRESS; Database=Session1; Trusted_Connection=true"
        Dim newConnetion As New SqlConnection(connectionString)
        newConnetion.Open()
        Return newConnetion
    End Function
End Module
