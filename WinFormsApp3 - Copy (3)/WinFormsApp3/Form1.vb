Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form1
    Public nm_admin As String
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Button1.FlatStyle = FlatStyle.Flat
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Button1.BackColor
        Button1.FlatAppearance.MouseOverBackColor = Button1.BackColor

        Dim path As New GraphicsPath()
        Dim radius As Integer = 20 ' Ubah radius sesuai keinginan Anda
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Button1.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Button1.Width - radius, Button1.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Button1.Height - radius, radius, radius, 90, 90)
        Button1.Region = New Region(path)

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs)
        ' Menghapus placeholder text saat TextBox mendapatkan fokus
        If input_username.Text = "Username" Then
            input_username.Text = ""
            input_username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs)
        ' Mengatur placeholder text saat TextBox kehilangan fokus
        If input_username.Text = "" Then
            input_username.Text = "Username"
            input_username.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        input_username.Text = "adm_1"
        input_password.Text = "yossi"
        Try
            Koneksi()
            cmd = New MySqlCommand("select* from admin where id_admin = '" & input_username.Text & "' and password = '" & input_password.Text & "' ", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Me.Hide()
                Form2.Show()
                nm_admin = dr("nama").ToString
                MsgBox(nm_admin)
            Else
                MsgBox("password atau username salah")
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class
