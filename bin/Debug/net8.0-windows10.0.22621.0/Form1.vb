Imports System.Data.SqlClient
Public Class Form1



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmp.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String
        Dim sql As String
        Dim rowCount As String

        If (txtEmp.Text <> "" And txtUser.Text <> "") Or (txtEmp.Text = "" And txtUser.Text = "") Then
            MsgBox("Please Enter Either Employee Or User!")
        Else
            If txtEmp.Text <> "" Then
                username = txtEmp.Text
            Else
                username = txtUser.Text
            End If
        End If

        password = txtPass.Text
        sql = $"SELECT * FROM [Users] WHERE Username ='{username}' AND password ='{password}'"
        Using connection As SqlConnection = GetConnection()
            Using Command As New SqlCommand(sql, connection)
                Using reader As SqlDataReader = Command.ExecuteReader()
                    While reader.Read()
                        rowCount += 1
                        If rowCount = 1 Then
                            Dim userId = reader.GetInt64("ID")
                            currentUserID = userId
                            MsgBox(currentUserID)
                        End If
                    End While
                    If rowCount = 1 Then
                        Management.Show()
                        Me.Hide()
                    Else
                        MsgBox("Login Failedd")
                    End If
                End Using
            End Using
        End Using
    End Sub

 

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub cbShow_CheckedChanged(sender As Object, e As EventArgs) Handles cbShow.CheckedChanged
        If cbShow.Checked Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub
End Class
