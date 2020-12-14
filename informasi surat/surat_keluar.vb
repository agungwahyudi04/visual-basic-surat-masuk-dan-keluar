Imports MySql.Data.MySqlClient
Public Class surat_keluar
#Region "Deklarasi"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New accessdata.koneksidata
    Dim objreader As MySqlDataReader
#End Region

    Private Sub update2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update2.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "update surat_keluar set tanggal = '" & Format(tgl.Value, "yyyy-MM-dd") & "', penerima = '" & tpenerima.Text & "', sifat = '" & CBsifat.Text & "', jenis = '" & (CBjenis.Text) & "', prihal = '" & (tprihal.Text) & "', status = '" & (CBsts.Text) & "' where no_sk ='" & tsurat.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Surat berhasil diupdate !", MsgBoxStyle.Information, "Notice !")
        daftar_surat_keluar.Show()
        Me.Close()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "delete from surat_keluar where no_sm ='" & tsurat.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Surat berhasil dihapus !", MsgBoxStyle.Information, "Notice !")
        tsurat.Text = ""
        tgl.Text = ""
        tpenerima.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
        CBsts.Text = ""
        daftar_surat_masuk.Show()
        Me.Close()
    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "insert into surat_keluar(no_sk,tanggal,penerima,sifat,jenis,prihal,status)values('" & (tsurat.Text) & "','" & (Format(tgl.Value, "yyyy-MM-dd")) & "','" & (tpenerima.Text) & "','" & (CBsifat.Text) & "','" & (CBjenis.Text) & "','" & (tprihal.Text) & "','" & (CBsts.Text) & "')"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Berhasil disimpan !", MsgBoxStyle.Information, "Notice !")
        tsurat.Text = ""
        tgl.Text = ""
        tpenerima.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
        CBsts.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tsurat.Text = ""
        tgl.Text = ""
        tpenerima.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
        CBsts.Text = ""
    End Sub

    Private Sub surat_keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl.Text = ""
    End Sub
End Class