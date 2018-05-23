Imports MySql.Data.MySqlClient
Public Class AdminDash
    Dim MySqlConn As MySqlConnection
    Dim Perintah As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dst As New DataSet

    Private Sub AdminDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user=root;password=root;database=matphys"
        Dim Reader As MySqlDataReader

        Try
            dtg_umum.Enabled = True
            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0", MySqlConn)
            da.Fill(dst, "users")
            dtg_umum.DataSource = dst.Tables(0)

            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(id_user) FROM users WHERE role = 0"

            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            While Reader.Read()
                txt_umum.Text = Reader("COUNT(id_user)").ToString
            End While

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected

        If e.TabPageIndex = 0 Then
            dtg_umum.Enabled = True
            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0", MySqlConn)
            da.Fill(dst, "users")
            dtg_umum.DataSource = dst.Tables(0)

        ElseIf e.TabPageIndex = 1 Then

            dtg_sd.Enabled = True
            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0 AND jenjang='SD'", MySqlConn)
            da.Fill(dst, "users")
            dtg_sd.DataSource = dst.Tables(0)

            Dim Reader As MySqlDataReader
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(id_user) FROM users WHERE role = 0 AND jenjang='SD'"

            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            While Reader.Read()
                txt_sd.Text = Reader("COUNT(id_user)").ToString
            End While
            MySqlConn.Close()

        ElseIf e.TabPageIndex = 2 Then
            dtg_smp.Enabled = True
            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0 AND jenjang='SMP'", MySqlConn)
            da.Fill(dst, "users")
            dtg_smp.DataSource = dst.Tables(0)

        ElseIf e.TabPageIndex = 3 Then
            dtg_sma.Enabled = True
                da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0 AND jenjang='SMA'", MySqlConn)
                da.Fill(dst, "users")
                dtg_sma.DataSource = dst.Tables(0)

        End If

    End Sub

End Class