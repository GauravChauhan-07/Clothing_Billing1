Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Administrator Login"
        Button1.Text = "Login"
        Button2.Text = "Cancel"
        Label2.Text = "User Name"
        Label3.Text = "Password"
        Label1.Font = New Font("Arial", 18, FontStyle.Bold)
        DateTimePicker1.Enabled = False
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text
        If username.Equals("admin1001") And password.Equals("admin") Then
            MessageBox.Show("Login Succesful")
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.Hide()
            Form4.Show()
        Else
            MessageBox.Show("Wrong username or password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class