Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim MySqlConn As MySqlConnection
    Dim Perintah, isAdmin As MySqlCommand
    Dim username, password As String

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        Dim signup = New SignUp
        signup.Show()
        Me.Hide()
    End Sub

    Public Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user=root;password=root;database=matphys"
        Dim Reader, isAdminReader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query, isAdminQuery As String
            username = UsernameTextBox.Text
            password = PasswordTextBox.Text

            Query = "SELECT * FROM matphys.users WHERE username ='" & username & "' AND password =  '" & password & "';"
            Perintah = New MySqlCommand(Query, MySqlConn)
            Reader = Perintah.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            Reader.Close()

            isAdminQuery = "SELECT * FROM matphys.users WHERE username ='" & username & "' AND role =  1;"
            isAdmin = New MySqlCommand(isAdminQuery, MySqlConn)
            isAdminReader = isAdmin.ExecuteReader
            Dim isAdminCount As Integer
            isAdminCount = 0
            While isAdminReader.Read
                isAdminCount = isAdminCount + 1
            End While

            If count = 1 Then
                If isAdminCount = 1 Then
                    MessageBox.Show("Selamat Datang ADMIN" & username)
                    AdminDash.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Selamat Datang " & username)
                    Main.Show()
                    Me.Hide()
                End If
            ElseIf count > 1 Then
                MessageBox.Show("Data Duplicate")
            Else
                MessageBox.Show("Kombinasi username dan password salah!")
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub
End Class
