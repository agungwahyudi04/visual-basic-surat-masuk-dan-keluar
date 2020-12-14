Imports MySql.Data.MySqlClient
Public Class daftar_surat_keluar
#Region "Deklarasi"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New accessdata.koneksidata
    Dim objreader As MySqlDataReader
#End Region
#Region "Prosedur"
    Sub bacalistview()
        Dim isi As ListViewItem
        listfrom.Items.Clear()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "select * from surat_keluar order by tanggal desc"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = listfrom.Items.Add(objreader.Item("no_sk").ToString)
            isi.SubItems.Add(objreader.Item("tanggal").ToString)
            isi.SubItems.Add(objreader.Item("penerima").ToString)
            isi.SubItems.Add(objreader.Item("sifat").ToString)
            isi.SubItems.Add(objreader.Item("jenis").ToString)
            isi.SubItems.Add(objreader.Item("prihal").ToString)
            isi.SubItems.Add(objreader.Item("status").ToString)
        End While
        mycmd.Connection = myconnection.close
    End Sub

    Sub bacalistview2()
        Dim isi As ListViewItem
        listfrom.Items.Clear()
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "select * from surat_keluar where tanggal = '" & Format(tgl.Value, "yyyy-MM-dd") & "'"
        objreader = mycmd.ExecuteReader
        While objreader.Read
            isi = listfrom.Items.Add(objreader.Item("no_sk").ToString)
            isi.SubItems.Add(objreader.Item("tanggal").ToString)
            isi.SubItems.Add(objreader.Item("penerima").ToString)
            isi.SubItems.Add(objreader.Item("sifat").ToString)
            isi.SubItems.Add(objreader.Item("jenis").ToString)
            isi.SubItems.Add(objreader.Item("prihal").ToString)
            isi.SubItems.Add(objreader.Item("status").ToString)
        End While
        mycmd.Connection = myconnection.close
    End Sub
#End Region

    Sub kliklistview()
        Dim index As Integer
        If listfrom.SelectedItems.Count = 0 Then Exit Sub

        With listfrom
            index = .SelectedIndices(0)
            surat_keluar.tsurat.Text = .Items(index).Text
            surat_keluar.tgl.Value = .Items(index).SubItems(1).Text
            surat_keluar.tpenerima.Text = .Items(index).SubItems(2).Text
            surat_keluar.CBsifat.Text = .Items(index).SubItems(3).Text
            surat_keluar.CBjenis.Text = .Items(index).SubItems(4).Text
            surat_keluar.tprihal.Text = .Items(index).SubItems(5).Text
            surat_keluar.CBsts.Text = .Items(index).SubItems(6).Text
            surat_keluar.Show()
            surat_keluar.update2.Visible = True
            surat_keluar.delete.Visible = True
            surat_keluar.add.Visible = False
            Me.Close()
        End With
    End Sub

    Private Sub daftar_surat_keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bacalistview()
        tgl.Text = ""
    End Sub

    Private Sub tgl_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tgl.ValueChanged
        bacalistview2()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bacalistview()
    End Sub

    Private Sub listfrom_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listfrom.SelectedIndexChanged
        kliklistview()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cetak_surat_keluar.Visible = True
    End Sub
End Class