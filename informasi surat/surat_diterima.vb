Imports MySql.Data.MySqlClient
Public Class surat_diterima

#Region "Deklarasi"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New accessdata.koneksidata
    Dim objreader As MySqlDataReader
#End Region

    Private Sub update1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update1.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "update suratmasuk set tanggal = '" & (Format(tgl.Value, "yyyy-MM-dd")) & "', pengirim = '" & tpengirim.Text & "', sifat = '" & CBsifat.Text & "', jenis = '" & (CBjenis.Text) & "', prihal = '" & (tprihal.Text) & "' where no_sm ='" & tsurat.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Surat berhasil diupdate !", MsgBoxStyle.Information, "Notice !")
        daftar_surat_masuk.Show()
        Me.Close()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "delete from suratmasuk where no_sm ='" & tsurat.Text & "'"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Surat berhasil dihapus !", MsgBoxStyle.Information, "Notice !")
        tsurat.Text = ""
        tgl.Text = ""
        tpengirim.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
        daftar_surat_masuk.Show()
        Me.Close()
    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "insert into suratmasuk(no_sm,tanggal,pengirim,sifat,jenis,prihal)values('" & (tsurat.Text) & "','" & (Format(tgl.Value, "yyyy-MM-dd")) & "','" & (tpengirim.Text) & "','" & (CBsifat.Text) & "','" & (CBjenis.Text) & "','" & (tprihal.Text) & "')"
        mycmd.ExecuteNonQuery()
        myconnection.close()
        MsgBox("Berhasil disimpan !", MsgBoxStyle.Information, "Notice !")
        tsurat.Text = ""
        tgl.Text = ""
        tpengirim.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tsurat.Text = ""
        tgl.Text = ""
        tpengirim.Text = ""
        CBsifat.Text = ""
        CBjenis.Text = ""
        tprihal.Text = ""
    End Sub

    Private Sub surat_diterima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tgl.Text = ""
    End Sub
End Class