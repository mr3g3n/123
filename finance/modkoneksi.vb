Imports MySql.Data.MySqlClient
Module modkoneksi
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public simpan, ubah, hapus, SQLConn As String

    Public Function Rep(ByVal Kata As String) As String 'anti sql injection
        Rep = Replace(Trim(Kata), "'", "''")
    End Function

    Public Sub bukaDB()


        Dim SQLConn As String
        If flogin.RadioButton1.Checked = True Then
            SQLConn = "server=sql128.main-hosting.eu;Uid=u747740931_finan;Pwd=123456;Database=u747740931_finan;SslMode=none"
            Conn = New MySqlConnection(SQLConn)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        ElseIf flogin.RadioButton2.Checked = True Then
            SQLConn = "server=localhost;Uid=root;Pwd=;Database=dbfinance;SslMode=none"
            Conn = New MySqlConnection(SQLConn)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        End If



    End Sub
End Module
