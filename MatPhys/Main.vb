Public Class Main
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about = New AboutBox
        about.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text = "Bangun Ruang" Then
            rumusSdBangunRuang.Visible = True
        End If
    End Sub

    Private Sub BtnHitLPKubus_Click(sender As Object, e As EventArgs) Handles BtnHitLPKubus.Click
        Dim cek As String
        If TextBoxInputLPKubus.Text Is cek Then
            MessageBox.Show("Inputan berupa angka !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            TextBoxHasilLPKubus.Text = (TextBoxInputLPKubus.Text * 6 ^ 2)
        End If
    End Sub
End Class
