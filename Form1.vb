Imports System.Data.SqlClient

Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            If ConnectionState.Open Then
                con.Close()
            End If
            users.Clear()
            con.Open()
            Cmd = New SqlCommand("Insert Into logint Values ( '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')", con)
            Cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("تم تسجيل بياناتك بنجاج حانوديك الملف الشخصي", MsgBoxStyle.Information)
            users.Clear()
        Catch ex As Exception
            MessageBox.Show("فشل في التسجيل")
            MsgBox(ex.Message & " - " & ex.Source)
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub
End Class
