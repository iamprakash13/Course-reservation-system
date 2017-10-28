Option Explicit On
Imports System.Data.OleDb

Public Class Form2
    Dim objCon As New OleDbConnection
    Dim strSQL As String
    Dim strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\Database2.accdb"
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim attempt As Integer = 0
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim warning As String = "Warning!" & vbNewLine & vbNewLine + _
         "If your attempt reaches 3" + vbNewLine + _
         "your chances exceed."

        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            attempt = attempt + 1
            MsgBox("please enter username and password" & vbNewLine & vbNewLine + _
                  warning, MsgBoxStyle.Exclamation, "Warning " & _
                   "now Attempt =" & attempt)

        ElseIf (UsernameTextBox.Text = "") Then
            MsgBox("please enter username" & vbNewLine & vbNewLine + _
                  warning, MsgBoxStyle.Exclamation, "Warning " & _
                  "now Attempt =" & attempt)

        ElseIf (PasswordTextBox.Text = "") Then
            MsgBox("please enter Password" & vbNewLine & vbNewLine + _
                 warning, MsgBoxStyle.Exclamation, "Warning " & _
                   "now Attempt =" & attempt)
        Else
            Dim strName = UsernameTextBox.Text
            Dim strPass = PasswordTextBox.Text
            With objCon
                .Close()
                If .State = ConnectionState.Closed Then
                    .ConnectionString = strConnection
                    .Open()
                    MsgBox("Connection state.open", MsgBoxStyle.Information, "Connected")
                End If
            End With

            ds.Clear()
            strSQL = "Select * From Student Where username='" & UsernameTextBox.Text & "'And password='" & PasswordTextBox.Text & "'"
            da = New OleDbDataAdapter(strSQL, objCon)
            da.Fill(ds, "Student")
            If ds.Tables("Student").Rows.Count <> 0 Then
                MaximizeBox = True
                MinimizeBox = True
                MsgBox("HELLO !" + strName + vbNewLine + _
                       "Log In Successful", MsgBoxStyle.OkOnly, _
                       "Welcome" + strName)
                Form6.Show()
            Else
                MaximizeBox = False
                MinimizeBox = False
                attempt = attempt +
                MsgBox("sorry,username or password not found")

            End If
        End If
        If attempt = 3 Then
            MsgBox(MsgBoxStyle.Exclamation, "your chances exceed")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Form1.Show()
        Me.Close()

    End Sub



    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
    End Sub

End Class
