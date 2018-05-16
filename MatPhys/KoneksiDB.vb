Imports MySql.Data.MySqlClient
Module KoneksiDB
    Public conn As New MySqlConnection
    Public Sub connect(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        If conn.State = ConnectionState.Closed Then
            Dim myString As String = "server=" & server & ";user=" & user & ";password=" & pass & ";database=" & db
            Try
                conn.ConnectionString = myString
                conn.Open()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                End
            End Try
        End If
    End Sub
    Public Sub disconnect()
        Try
            conn.Close()
        Catch ex As MySqlException
        End Try
    End Sub
End Module