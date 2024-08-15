Imports System.Data.SqlClient
Imports System.IO

Public Class CreateAccount
    Dim hasviewTerm As Boolean = False
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToRegis.Click
        If txtUser.Text = "" Then
            MsgBox("Enter your UserName")
            txtUser.Select()
        ElseIf txtName.Text = "" Then
            MsgBox("Enter your FullName")
            txtName.Select()
        ElseIf numFamily.Value <= 0 Then
            MsgBox("Add your numfamily")
        ElseIf txtPass.Text = "" Then
            MsgBox("Enter your password")
            txtPass.Select()
        ElseIf txtConfirmPass.Text = "" Then
            MsgBox("Enter your ConfirmPassword")
            txtConfirmPass.Select()
        ElseIf cbAgree.Checked = False Then
            MsgBox("Please Agree the term")
        Else

            Dim username As String = txtUser.Text
            Dim password As String = txtPass.Text
            Dim confirmPassword As String = txtConfirmPass.Text
            Dim fullname As String = txtName.Text
            Dim gob As String = dtpDob.Value
            Dim gender As Boolean = 0
            Dim familyCount As Integer = numFamily.Value
            Dim validate As Boolean = True

            If rdoMale.Checked Then
                gender = 0
            ElseIf rdoFe.Checked Then
                gender = 1
            End If

            If username = "" Or password = "" Or confirmPassword = "" Then
                validate = False
            End If

            If password <> confirmPassword Then
                validate = False
            End If




            Dim sql As String = "INSERT INTO [dbo].[Users]
            ([GUID],[UserTypeID],[Username],[Password],[FullName],[Gender],[BirthDate],[FamilyCount])
            VALUES
            (NEWID(),2,@username, @password, @fullname, @gender, @dob, @familyCount)"

            Using connection As SqlConnection = GetConnection()

                Dim command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@fullname", fullname)
                command.Parameters.AddWithValue("@gender", gender)
                command.Parameters.AddWithValue("@dob", dtpDob.Value.ToString("yyyy-MM-dd"))
                command.Parameters.AddWithValue("@familyCount", familyCount)

                Try
                    command.ExecuteNonQuery()
                    MsgBox("Data Inserted Successfully!")
                    Management.Show()
                    Me.Hide()
                Catch ex As SqlException
                    MsgBox("Error Inserting Data: " & ex.Message)

                End Try


            End Using
        End If
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDob.ValueChanged

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged

    End Sub

    Private Sub rdoMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMale.CheckedChanged

    End Sub

    Private Sub rdoFe_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFe.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgree.CheckedChanged
        If hasviewTerm = False Then
            cbAgree.Checked = False
            MsgBox("Please review the tems and condition fist.")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkViewTerm.LinkClicked
        hasviewTerm = True

        Dim filePath As String = Path.GetTempFileName()
        File.WriteAllText(filePath, My.Resources.Terms)
        If File.Exists(filePath) Then
            Process.Start("notepad.exe", filePath)
        Else
            MsgBox("open file error")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnToLogin.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub numFamily_ValueChanged(sender As Object, e As EventArgs) Handles numFamily.ValueChanged

    End Sub

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class