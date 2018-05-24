Imports MySql.Data.MySqlClient
Public Class AdminDash
    Dim MySqlConn As MySqlConnection
    Dim Perintah As MySqlCommand
    Dim da As MySqlDataAdapter
    Dim dst As New DataSet

    Dim umum As Integer = 1
    Dim sd As Integer = 0
    Dim smp As Integer = 0
    Dim sma As Integer = 0

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
            umum = 1
            dtg_umum.Enabled = True
            If sd <> 0 Then
                dtg_sd.DataSource.clear()
            ElseIf smp <> 0 Then
                dtg_smp.DataSource.clear()
            ElseIf sma <> 0 Then
                dtg_sma.DataSource.clear()
            End If

            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0", MySqlConn)
            da.Fill(dst, "users")
            dtg_umum.DataSource = dst.Tables(0)

        ElseIf e.TabPageIndex = 1 Then
            sd = 1
            dtg_sd.Enabled = True

            If umum <> 0 Then
                dtg_umum.DataSource.clear()
            ElseIf smp <> 0 Then
                dtg_smp.DataSource.clear()
            ElseIf sma <> 0 Then
                dtg_sma.DataSource.clear()
            End If
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
            smp = 1
            dtg_smp.Enabled = True
            If sd <> 0 Then
                dtg_sd.DataSource.clear()
            ElseIf umum <> 0 Then
                dtg_umum.DataSource.clear()
            ElseIf sma <> 0 Then
                dtg_sma.DataSource.clear()
            End If

            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0 AND jenjang='SMP'", MySqlConn)
            da.Fill(dst, "users")
            dtg_smp.DataSource = dst.Tables(0)

            Dim Reader As MySqlDataReader
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(id_user) FROM users WHERE role = 0 AND jenjang='SMP'"

            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            While Reader.Read()
                txt_smp.Text = Reader("COUNT(id_user)").ToString
            End While
            MySqlConn.Close()

        ElseIf e.TabPageIndex = 3 Then
            sma = 1
            dtg_sma.Enabled = True
            If sd <> 0 Then
                dtg_sd.DataSource.clear()
            ElseIf smp <> 0 Then
                dtg_smp.DataSource.clear()
            ElseIf umum <> 0 Then
                dtg_umum.DataSource.clear()
            End If
            If umum <> 0 Then
                dtg_umum.DataSource.clear()
            ElseIf sd <> 0 Then
                dtg_sd.DataSource.clear()
            End If

            da = New MySqlDataAdapter("SELECT id_user, name, email, username, password, jenjang FROM users WHERE role=0 AND jenjang='SMA'", MySqlConn)
            da.Fill(dst, "users")
            dtg_sma.DataSource = dst.Tables(0)

            Dim Reader As MySqlDataReader
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT COUNT(id_user) FROM users WHERE role = 0 AND jenjang='SMA'"

            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            While Reader.Read()
                txt_sma.Text = Reader("COUNT(id_user)").ToString
            End While
            MySqlConn.Close()

        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class