Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub Koneksi()
        Try
            Dim str As String = "server=localhost;uid=root;database=database_futsal;"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                MsgBox("koneksi berhasil")
            End If
        Catch ex As Exception
            MsgBox("koneksi gagal")
            MsgBox(ex.Message)
        End Try
    End Sub
End Module