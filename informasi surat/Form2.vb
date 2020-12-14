Public Class Form2

    Private Sub DaftarSuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSuratMasukToolStripMenuItem.Click
        daftar_surat_masuk.Show()
    End Sub

    Private Sub DaftarSuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarSuratKeluarToolStripMenuItem.Click
        daftar_surat_keluar.Show()
    End Sub

    Private Sub TambahSuratMasukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahSuratMasukToolStripMenuItem.Click
        surat_diterima.Visible = True
    End Sub

    Private Sub TambahSuratKeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahSuratKeluarToolStripMenuItem.Click
        surat_keluar.Visible = True
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.Show()
        Me.Close()
        login.user.Text = ""
        login.pswd.Text = ""
    End Sub

    Private Sub CetakLaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cetak_surat_keluar.Visible = True
    End Sub
End Class