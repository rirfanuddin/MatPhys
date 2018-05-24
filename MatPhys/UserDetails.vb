Imports MySql.Data.MySqlClient

Public Class UserDetails
    Dim MySqlConn As MySqlConnection
    Dim Perintah, PerintahDetails As MySqlCommand

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim uname = LoginForm.UsernameTextBox.Text
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user=root;password=root;database=matphys"
        Dim ReaderUpdate As MySqlDataReader
        MySqlConn.Open()
        Dim Query As String
        Query = "UPDATE userdetails, users SET address = '" & alamat_txtbox.Text & "', school = '" & sekolah_txtbox.Text & "' WHERE userdetails.id_user = users.id_user AND users.username='" & uname & "'"
        Perintah = New MySqlCommand(Query, MySqlConn)
        Perintah.ExecuteNonQuery()
        MySqlConn.Close()

        MessageBox.Show("BERHASIL MENGUPDATE")
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim uname = LoginForm.UsernameTextBox.Text
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user=root;password=root;database=matphys"
        Dim Reader, ReaderDetails As MySqlDataReader
        MySqlConn.Open()
        Dim Query, QueryDetails As String
        Query = "SELECT username FROM users WHERE username='" & uname & "'"
        Perintah = New MySqlCommand(Query, MySqlConn)
        Reader = Perintah.ExecuteReader
        While Reader.Read()
            username_txtbox.Text = Reader("username").ToString
        End While
        Reader.Close()

        QueryDetails = "SELECT address, school FROM userdetails, users WHERE userdetails.id_user = users.id_user AND users.username='" & uname & "'"
        PerintahDetails = New MySqlCommand(QueryDetails, MySqlConn)
        ReaderDetails = PerintahDetails.ExecuteReader
        While ReaderDetails.Read()
            alamat_txtbox.Text = ReaderDetails("address").ToString
            sekolah_txtbox.Text = ReaderDetails("school").ToString
        End While
        ReaderDetails.Close()
        MySqlConn.Close()
    End Sub
End Class