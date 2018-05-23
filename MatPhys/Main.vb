Public Class Main
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about = New AboutBox
        about.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "Bangun Ruang" Then
            rumusSdKubus.Visible = True

        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub UserDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserDetailsToolStripMenuItem.Click
        UserDetails.Show()
    End Sub
End Class
