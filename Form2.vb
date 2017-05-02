Imports System.Data.SqlClient

Public Class Form2

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("من فضلك قم بأدخال اسم المستخدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("من فضلك قم بأدحال كلمه المرور ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        dt.Clear()
        Dad = New SqlDataAdapter("select * from [logint] where [username]='" & TextBox1.Text & "'and [password]='" & TextBox2.Text & "'", con)
        Dad.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("اسم المستخدم او كلمه المرور خطأ تأكد من بياناتك ", "حطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Exit Sub
        If dt.Rows(3)(4) = 1 Then
            Form3.Show()
            Me.Hide()
        ElseIf dt.Rows(3)(4) = 2 Then
            Me.Hide()
            Form3.Show()
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class