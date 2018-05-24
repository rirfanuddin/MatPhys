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
        TextBoxHasilVKubus.Text = (TextBoxInputSisiKubus.Text ^ 3)
    End Sub

    Private Sub TextBoxInputLBalok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputLBalok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBoxInputPBalok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputPBalok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBoxInputTBalok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputTBalok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ButtonHitBalok_Click(sender As Object, e As EventArgs) Handles ButtonHitBalok.Click
        TextBoxHasilLPBalok.Text = 2 * ((TextBoxInputPBalok.Text * TextBoxInputLBalok.Text) *
                                        (TextBoxInputPBalok.Text * TextBoxInputTBalok.Text) *
                                        (TextBoxInputLBalok.Text * TextBoxInputTBalok.Text))
        TextBoxHasilVBalok.Text = TextBoxInputPBalok.Text * TextBoxInputLBalok.Text * TextBoxInputTBalok.Text
    End Sub

    Private Sub TextBoxInputAPSegitiga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputAPSegitiga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBoxInputTPSegitiga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputTPSegitiga.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBoxInputTPrisma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxInputTPrisma.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ButtonHitPrisma_Click(sender As Object, e As EventArgs) Handles ButtonHitPrisma.Click
        TextBoxHasilVPrisma.Text = (1 / 2 * TextBoxInputAPSegitiga.Text * TextBoxInputTPSegitiga.Text) *
                                    TextBoxInputTPrisma.Text
    End Sub
End Class
