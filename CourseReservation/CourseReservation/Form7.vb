Option Explicit On
Imports System.Data.OleDb

Public Class Form7

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim objCon As New OleDbConnection
            Dim strSQL As String
            Dim da As New OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Bank.accdb"
            With objCon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnection
                    .Open()
                End If
            End With
            ds.Clear()
            strSQL = "Select * From Customer Where CCN='" & TextBox1.Text & "'And SecurityCode='" & TextBox2.Text & "'"
            da = New OleDbDataAdapter(strSQL, objCon)
            da.Fill(ds, "Customer")
            If ds.Tables("Customer").Rows.Count <> 0 Then
                MaximizeBox = True
                MinimizeBox = True
                Form8.Show()
            Else
                MaximizeBox = False
                MinimizeBox = False
                MsgBox("sorry,CNN or Code is incorrect")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class