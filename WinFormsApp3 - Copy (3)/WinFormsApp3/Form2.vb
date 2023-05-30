Imports System.Collections.Specialized.BitVector32
Imports System.Drawing.Drawing2D

Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button7.FlatStyle = FlatStyle.Flat
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Button7.BackColor
        Button7.FlatAppearance.MouseOverBackColor = Button7.BackColor

        Dim path As New GraphicsPath()
        Dim radius As Integer = 20 ' Ubah radius sesuai keinginan Anda
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(Button7.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(Button7.Width - radius, Button7.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, Button7.Height - radius, radius, radius, 90, 90)
        Button7.Region = New Region(path)

        Button11.FlatStyle = FlatStyle.Flat
        Button11.FlatAppearance.BorderSize = 0
        Button11.FlatAppearance.MouseDownBackColor = Button11.BackColor
        Button11.FlatAppearance.MouseOverBackColor = Button11.BackColor

        Dim path1 As New GraphicsPath()
        Dim radius1 As Integer = 20 ' Ubah radius sesuai keinginan Anda
        path.AddArc(0, 0, radius1, radius1, 180, 90)
        path.AddArc(Button11.Width - radius1, 0, radius1, radius1, 270, 90)
        path.AddArc(Button11.Width - radius1, Button11.Height - radius1, radius1, radius1, 0, 90)
        path.AddArc(0, Button11.Height - radius1, radius1, radius1, 90, 90)
        Button11.Region = New Region(path1)

        Panel3.BackColor = Color.FromArgb(128, 0, 0, 0) ' Opasitas 50%

        Panel_home.Show()
        Call Koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_booking, pelanggan.Nama AS Nama_Pelanggan, booking.Tanggal, booking.Durasi, booking.jam_mulai, booking.jam_selesai, booking.Lapangan, booking.Uang_Muka, booking.total_bayar, booking.status, admin.nama AS Nama_Admin, booking.tanggal_booking FROM booking JOIN admin ON booking.Nama_Admin = admin.id_admin JOIN Lapangan ON booking.Lapangan = Lapangan.id_lapangan JOIN pelanggan ON booking.Nama_Pelanggan = pelanggan.id_pelanggan ORDER BY booking.Tanggal;", conn)
        ds = New DataSet
        da.Fill(ds)
        tbl_booking.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Panel_home.Visible = True
        Panel_user.Visible = False
        Panel_income.Visible = False
        Panel_Lapangan.Visible = False
        Panel_about.Visible = False


    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Panel_home.Visible = False
        Panel_user.Visible = True
        Panel_income.Visible = False
        Panel_Lapangan.Visible = False
        Panel_about.Visible = False
    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click
        Panel_home.Visible = False
        Panel_user.Visible = False
        Panel_income.Visible = True
        Panel_Lapangan.Visible = False
        Panel_about.Visible = False
    End Sub

    Private Sub btnLapangan_Click(sender As Object, e As EventArgs) Handles btnLapangan.Click
        Panel_home.Visible = False
        Panel_user.Visible = False
        Panel_income.Visible = False
        Panel_Lapangan.Visible = True
        Panel_about.Visible = False
    End Sub

    Private Sub btnInfokami_Click(sender As Object, e As EventArgs) Handles btnInfokami.Click
        Panel_home.Visible = False
        Panel_user.Visible = False
        Panel_income.Visible = False
        Panel_Lapangan.Visible = False
        Panel_about.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub Spesifikasi_lap1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.ContextMenuStripChanged
        If ComboBox2.Text = "Lapangan 1" Then
            Lapangan_1.Visible = True
            Lapangan_2.Visible = False
            Lapangan_3.Visible = False
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = True
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 2" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = True
            Lapangan_3.Visible = False
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = True
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 3" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = False
            Lapangan_3.Visible = True
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = True
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 4" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = False
            Lapangan_3.Visible = False
            Lapangan_4.Visible = True

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = True
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Lapangan 1" Then
            Lapangan_1.Visible = True
            Lapangan_2.Visible = False
            Lapangan_3.Visible = False
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = True
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 2" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = True
            Lapangan_3.Visible = False
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = True
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 3" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = False
            Lapangan_3.Visible = True
            Lapangan_4.Visible = False

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = True
            GroupBox_lap4.Visible = False
        End If
        If ComboBox2.Text = "Lapangan 4" Then
            Lapangan_1.Visible = False
            Lapangan_2.Visible = False
            Lapangan_3.Visible = False
            Lapangan_4.Visible = True

            GroupBox_lap1.Visible = False
            GroupBox_lap2.Visible = False
            GroupBox_lap3.Visible = False
            GroupBox_lap4.Visible = True
        End If
    End Sub
End Class