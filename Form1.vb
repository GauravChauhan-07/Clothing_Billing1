Imports MySql.Data.MySqlClient
Public Class Form1

    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=test"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
     Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     ListView1.Columns.Add("Pro_Id", 90, HorizontalAlignment.Center)
     ListView1.Columns.Add("Pro_Name", 180, HorizontalAlignment.Center)
     ListView1.Columns.Add("Pro_Mrp", 90, HorizontalAlignment.Center)
     ListView1.Columns.Add("Qty", 80, HorizontalAlignment.Center)
     ListView1.Columns.Add("Gst", 90, HorizontalAlignment.Center)
     ListView1.Columns.Add("Dis_Id", 90, HorizontalAlignment.Center)
     ListView1.Columns.Add("Pro_Price", 180, HorizontalAlignment.Center)
     ListView1.Columns.Add("Sub_CateId", 110, HorizontalAlignment.Center)
     Button1.Text = "CLEAR"
     Button2.Text = "ADD"
     Button3.Text = "DELETE"
     Button4.Text = "UPDATE"
     Button5.Text = "CLOSE"
     Me.BackColor = Color.DarkGray
     Button6.Text = "CONNECT"
 End Sub


 Private Sub Sub_CateId_KeyUp(sender As Object, e As KeyEventArgs) Handles Sub_CateId.KeyUp
     Dim Cl As ListViewItem
     If e.KeyValue = Keys.Enter Then
         Cl = ListView1.Items.Add(Pro_Id.Text)
         Cl.SubItems.Add(Pro_Name.Text)
         Cl.SubItems.Add(Pro_Mrp.Text)
         Cl.SubItems.Add(Qty.Text)
         Cl.SubItems.Add(Gst_Rate.Text)
         Cl.SubItems.Add(Dis_Id.Text)
         Cl.SubItems.Add(Pro_Price.Text)
         Cl.SubItems.Add(Sub_CateId.Text)
         Pro_Id.Text = ""
         Pro_Name.Text = ""
         Pro_Mrp.Text = ""
         Qty.Text = ""
         Gst_Rate.Text = ""
         Dis_Id.Text = ""
         Pro_Price.Text = ""
         Sub_CateId.Text = ""
         Pro_Id.Focus()
     End If
 End Sub
End Class
