﻿Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Register.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Username As String = txtUsername.Text.ToString
        Dim Password As String = txtPassword.Text.ToString
        Try
            con.Open()
            cmd.CommandText = "SELECT * FROM tbl_login where log_username ='" & Username & "' and " & "log_password = '" & Password & "'"
            cmd.Connection = con

            dataReader = cmd.ExecuteReader()

            If (dataReader.Read() = True) Then
                MsgBox("susscessful login")
                Me.Hide()
                Dashboard.Show()
            Else
                MsgBox("Wrong Username/Password")
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
