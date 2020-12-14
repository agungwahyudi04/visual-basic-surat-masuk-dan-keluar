
Public Class Cetak_surat_keluar


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRV.SelectionFormula = "DateTimeValue({surat_keluar1.tanggal}) >= DateTimeValue('" & Format(tgl1.Value, "yyyy-MM-dd") & "') and DateTimeValue({surat_keluar1.tanggal}) <= DateTimeValue('" & Format(tgl2.Value, "yyyy-MM-dd") & "')"
        CRV.RefreshReport()
        CRV.ReportSource = "report.rpt"
    End Sub
End Class