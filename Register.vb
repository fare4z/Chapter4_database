Public Class Register
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim Username As String = txtUsername.Text.ToString.Trim
        Dim Password As String = txtPassword.Text.ToString.Trim
        Dim Fullname As String = txtName.Text.ToString.ToUpper

        Try
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "INSERT INTO tbl_login (log_username, log_password,log_fullname) Values ('" & Username & "','" & Password & "','" & Fullname & "')"
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class