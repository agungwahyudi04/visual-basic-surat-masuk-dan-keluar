Imports MySql.Data.MySqlClient
Namespace accessdata
    Public Class koneksidata
        Dim conect As New MySqlConnection("server=localhost;uid=root;pwd='';database='pengarsipan'")
        Public Function open() As MySqlConnection
            Try
                conect.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return conect
        End Function
        Public Function close() As MySqlConnection
            Try
                conect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Return conect
        End Function
    End Class
End Namespace
