Public Class Form1

    Private Sub DaftarSuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSuratMasukToolStripMenuItem.Click
        daftar_surat_masuk2.Show()
    End Sub

    Private Sub DaftarSuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSuratKeluarToolStripMenuItem.Click
        daftar_surat_keluar2.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.Show()
        Me.Close()
        login.user.Text = ""
        login.pswd.Text = ""
    End Sub
End Class