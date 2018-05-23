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

    Private Sub TextBoxInputSisiKubus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputSisiKubus.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ButtonHitKubus_Click(sender As Object, e As EventArgs) Handles ButtonHitKubus.Click
        TextBoxHasilLPKubus.Text = (TextBoxInputSisiKubus.Text * 6 ^ 2)
    End Sub

End Class
