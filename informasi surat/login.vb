Imports MySql.Data.MySqlClient
Public Class login
#Region "Deklarasi"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New accessdata.koneksidata
    Dim objreader As MySqlDataReader
#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "select * from user where username = '" & user.Text & "' and password = '" & pswd.Text & "'"
        objreader = mycmd.ExecuteReader
        If objreader.HasRows = True And user.Text = "admin" Then
            MsgBox("Selamat anda berhasil login sebagai admin", MsgBoxStyle.Information, "Notice !")
            Form2.Visible = True
            Me.Visible = False
        ElseIf objreader.HasRows = True Then
            MsgBox("Selamat anda berhasil login", MsgBoxStyle.Information, "Notice !")
            Form1.Visible = True
            Me.Visible = False
        Else
            MsgBox("Password atau username salah !", MsgBoxStyle.Information, "Notice !")
            user.Text = ""
            pswd.Text = ""
        End If
        myconnection.close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        user.Text = ""
        pswd.Text = ""
    End Sub
End Class