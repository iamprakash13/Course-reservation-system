Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Database2.accdb;Persist Security Info=True;Jet OLEDB:Database Password=tamilan"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Student1([Username], [Password], [Email Id])VALUES(@Username, @Password ,@EmailId)"
            sqlquery.Parameters.AddWithValue("@Username", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@Password", TextBox3.Text)
            sqlquery.Parameters.AddWithValue("@EmailId", TextBox2.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()

    End Sub
    
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class