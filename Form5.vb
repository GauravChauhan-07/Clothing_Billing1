Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Add"
        Button2.Text = "Modify"
        Button3.Text = "Delete"
        Button4.Text = "Cancel"
        Button5.Text = "<-"
        Label13.Text = "Employee Panel"
        Label13.Font = New Font("Arial", 22, FontStyle.Bold)
        Label1.Text = "Emp Id"
        Label2.Text = "Name"
        Label3.Text = "Aadhar NO"
        Label4.Text = "Gender"
        Label5.Text = "Phone NO"
        Label6.Text = "Address"
        Label7.Text = "Email"
        Label8.Text = "State"
        Label9.Text = "City"
        Label10.Text = "Pin Code"
        Label11.Text = "Password"
        Label12.Text = "Date Of Join"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class