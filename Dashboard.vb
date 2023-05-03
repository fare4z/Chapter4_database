Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        dataSet.Clear()

        cmd = con.CreateCommand
        cmd.CommandText = "select * from tbl_login"

        dataAdapter.SelectCommand = cmd

        dataAdapter.Fill(dataSet, "tbl_login")
        txtID.DataBindings.Add("Text", dataSet.Tables("tbl_login"), "log_id")
        txtUsername.DataBindings.Add("Text", dataSet.Tables("tbl_login"), "log_username")
        txtPassword.DataBindings.Add("Text", dataSet.Tables("tbl_login"), "log_password")
        txtFullname.DataBindings.Add("Text", dataSet.Tables("tbl_login"), "log_fullname")

        DataGridView1.DataSource = dataSet.Tables(0)

        RefreshSub()
    End Sub

    Public Sub RefreshSub()
        On Error Resume Next
        dataSet.Clear()

        cmd = con.CreateCommand
        cmd.CommandText = "select * from tbl_login"
        dataAdapter.SelectCommand = cmd

        dataAdapter.Fill(dataSet, "tbl_login")
        DataGridView1.DataSource = dataSet.Tables(0)

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        RefreshSub()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con.Open()
            cmd.CommandText = "DELETE from tbl_login " _
                      & "WHERE log_id = " & txtID.Text

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            RefreshSub()
            MessageBox.Show("Data Delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            con.Open()
            cmd.CommandText = "UPDATE tbl_login SET log_username = '" & txtUsername.Text & "'," _
                & "log_password = '" & txtPassword.Text & "'," _
                & "log_fullname = '" & txtPassword.Text & "'" _
                & "WHERE log_id = " & txtID.Text

            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            RefreshSub()
            MessageBox.Show("Data Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class