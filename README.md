# Course-reservation-system
it is a mini-project i have done in collage using visual basic 2010 .it connects forms with database.i have used visual basic 2010 as front end and MS Access as back end in this project.

# Description:
we can store data,insert,update,delete data in Database .using vb coding.we can use ODBC Driver for connection string to connect vb link to database.we can use database as MS Access/SQL/Oracle.we can use FrontEnd (User Interface) As VB 2010 or Html(as Web Page) . while you are going to use Html to build it as WebPage(3 Tier application),Use Servlet/Php as middleware (for connection),Use html as Frontend,use any database as Backend.

# Database insertion code:
Use "Insert into tablename([Username])values(@username)" to insert values into table.
Use "UPDATE table name   SET field name  = some value" to update values in table.
Use "DELETE FROM table list" (or) "DELETE FROM table WHERE fieldname = value" to delete record in table.
Use "Select * from tablename" to select records in table.
Use "sqlquery.Parameters.AddWithValue("@username", TextBox1.Text)" to add value entered in textbox to database field.

# VB coding:
declare connection string "Dim connString As String"
Create connection string- connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Visual Studio 2010\database.accdb"
to specify loaction of your database (ms access) file.
u can use message box in vb - MessageBox.show("your message here")
open connection "sqlconn.open()" . close connection "sqlconn.close".
you can build forms based on your project requirement.to insert code double cick on buttons in form code of form will open.there you can insert your code.you can also add pictures in forms n database.

# Download Links:
Vb 2010 express: https://visual-basic-express.soft32.com/free-download/?dm=1

# Credits: Prakash,Sunderasan,Santhosh Kumar,Santhana Kumar.
# Contact us at ptan022@gmail.com , sundarmahi7@gmail.com , Santhoshkumar1998.k@gmail.com
