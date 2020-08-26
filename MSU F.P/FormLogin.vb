Imports MySql.Data.MySqlClient

Public Class FormLogin
	Dim MysqlConn As MySqlConnection
	Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
		Application.Exit()
	End Sub
	Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
		FormCustomerLogin.Show()
		Me.Hide()
	End Sub
	Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
		FormStaffLogin.Show()
		Me.Hide()
	End Sub

	Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"

		Try
			MysqlConn.Open()
			MessageBox.Show("Connection Successful.")
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		Process.Start("www.ikea.com")
	End Sub
End Class
