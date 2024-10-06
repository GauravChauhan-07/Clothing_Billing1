Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name"
        Label2.Text = "Gaurav Chauhan"
        Button1.Text = "Employee Details"
        Button2.Text = "Product Details"
        Button3.Text = "Sales Detail"
        Button4.Text = "Customer Detail"
        Button1.BackColor = Color.DarkCyan
        Button2.BackColor = Color.DarkCyan
        Button3.BackColor = Color.DarkCyan
        Button4.BackColor = Color.DarkCyan
        Button5.Text = "<-"
        Label3.Text = "ADMIN PANEL"
        Label3.Font = New Font("Arial", 26, FontStyle.Bold)
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class