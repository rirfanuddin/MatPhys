Imports MySql.Data.MySqlClient
Public Class SignUp
    Dim MySqlConn As MySqlConnection
    Dim Perintah As MySqlCommand

    Dim nama, email, username, password, jenjang As String

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user=root;password=root;database=matphys"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            nama = nama_txtbox.Text
            email = email_txtbox.Text
            username = username_txtbox.Text
            password = password_txtbox.Text

            If sd_radio.Checked = True Then
                jenjang = sd_radio.Text
            ElseIf smp_radio.Checked = True Then
                jenjang = smp_radio.Text
            ElseIf sma_radio.Checked = True Then
                jenjang = sma_radio.Text
            End If
            Query = "insert into users (name, email, username, password, jenjang) values ('" & nama_txtbox.Text & "', '" & email & "', '" & username & "', '" & password & "', '" & jenjang & "');"

            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            MessageBox.Show("Data Saved")

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub SignUp_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoginForm.Show()
    End Sub
End Class