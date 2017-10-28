Public Class Form5

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Database2.accdb;Persist Security Info=True;Jet OLEDB:Database Password=tamilan"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO Student([Username], [Password], [Age], [Mobileno], [Email Id], [Mark], [Qualification], [Address1], [Address2], [CourseSelected])VALUES(@Username, @Password, @Age, @Mobileno, @EmailId, @Mark, @Qualification, @Address1, @Address2, @CourseSelected)"
            sqlquery.Parameters.AddWithValue("@Username", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@Password", TextBox6.Text)
            sqlquery.Parameters.AddWithValue("@Mobileno", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@Email Id", TextBox3.Text)
            sqlquery.Parameters.AddWithValue("@Mark", TextBox4.Text)
            sqlquery.Parameters.AddWithValue("@Address1", RichTextBox1.Text)
            sqlquery.Parameters.AddWithValue("@Address2", RichTextBox2.Text)
            sqlquery.Parameters.AddWithValue("@Qualification", ComboBox1.Text)
            sqlquery.Parameters.AddWithValue("@CourseSelected", ComboBox2.Text)
            sqlquery.Parameters.AddWithValue("@Age", TextBox5.Text)

            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("your student details are registered successfully.")
            Form7.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class