Imports MySql.Data.MySqlClient
Public Class fbank
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        finputbank.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        feditbank.Show()

    End Sub

    Private Sub fbank_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tampildata()
        aturDGV()
    End Sub

    Sub tampildata()
        Call bukaDB()
        DA = New MySqlDataAdapter("select * from bank", Conn)
        DS = New DataSet
        DA.Fill(DS, "data")
        DataGridView1.DataSource = DS.Tables("data")

    End Sub
    Sub aturDGV()
        Try
            DataGridView1.Columns(0).Width = 30
            DataGridView1.Columns(1).Width = 535
            DataGridView1.Columns(0).HeaderText = "No"
            DataGridView1.Columns(1).HeaderText = "Nama Bank"
        Catch ex As Exception
        End Try
    End Sub
End Class