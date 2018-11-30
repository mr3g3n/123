Imports MySql.Data.MySqlClient

Public Class finputbank
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call store()

    End Sub



    Private Sub finputbank_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub store()
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Call bukaDB()
        simpan = "INSERT INTO bank (nm_bank) VALUES (?)"
        CMD = Conn.CreateCommand
        With CMD
            .CommandText = simpan
            .Connection = Conn
            .Parameters.Add("p1", MySqlDbType.String, 50).Value = TextBox1.Text
            .ExecuteNonQuery()
        End With
        ProgressBar1.Value = 100
        TextBox1.Text = ""
        ProgressBar1.Style = ProgressBarStyle.Blocks

    End Sub
End Class