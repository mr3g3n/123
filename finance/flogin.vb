Imports MySql.Data.MySqlClient

Public Class flogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login_user()
        'fmenu.Show()
        'Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Sub login_user()
        ProgressBar1.Style = ProgressBarStyle.Marquee
        Try
            Call bukaDB()
            Dim SQLConn As String
            SQLConn = "select * from users where nm_user = '" & Rep(TextBox1.Text) & "' and password = '" & Rep(TextBox2.Text) & "'"
            CMD = New MySqlCommand(SQLConn, Conn)
            RD = CMD.ExecuteReader
            If RD.HasRows Then
                ProgressBar1.Style = ProgressBarStyle.Blocks
                fmenu.Show()
                Me.Hide()
            Else
                RD.Close()
                MessageBox.Show("Login gagal, username atau Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal")
        End Try


    End Sub
End Class
