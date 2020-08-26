Imports MySql.Data.MySqlClient

Public Class FormCustomerLogin
	Public Shared tb As TextBox
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand

	Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
		Application.Exit()
	End Sub
	Private Sub BunifuTextBox1_Enter_1(sender As Object, e As EventArgs) Handles BunifuTextBox1.Enter
		Dim username As String = BunifuTextBox1.Text
		If username.Trim().ToLower() = "username" Or username.Trim().ToLower() = "" Then
			BunifuTextBox1.Text = ""
		End If
	End Sub

	Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextBox1.Leave
		Dim username As String = BunifuTextBox1.Text
		If username.Trim().ToLower() = "username" Or username.Trim().ToLower() = "" Then
			BunifuTextBox1.Text = "Username"
		End If
	End Sub

	Private Sub BunifuTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuTextBox2.Enter
		Dim password As String = BunifuTextBox2.Text
		If password.Trim().ToLower() = "password" Or password.Trim().ToLower() = "" Then
			BunifuTextBox2.Text = ""
		End If
	End Sub

	Private Sub BunifuTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuTextBox2.Leave
		Dim password As String = BunifuTextBox2.Text
		If password.Trim().ToLower() = "password" Or password.Trim().ToLower() = "" Then
			BunifuTextBox2.Text = "Password"
		End If
	End Sub

	Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"

		Try
			MysqlConn.Open()
			MessageBox.Show("Connection successful.")
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.customer WHERE cust_username = '" & BunifuTextBox1.Text & "' and cust_password = BINARY '" & BunifuTextBox2.Text & "' "
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While

			If count = 1 Then
				MessageBox.Show("Login successful")
				FormCustomerMain.Show()
				Me.Hide()

			Else
				MessageBox.Show("Incorrect credentials")
			End If
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
		FormLogin.Show()
		Me.Hide()
	End Sub

	Private Sub FormCustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		tb = BunifuTextBox1
	End Sub

	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		FormEmailRegister.Show()
		Me.Hide()
	End Sub
End Class

