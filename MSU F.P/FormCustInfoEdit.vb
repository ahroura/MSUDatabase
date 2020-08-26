Imports MySql.Data.MySqlClient

Public Class FormCustInfoEdit
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "UPDATE ikea.customer SET cust_id = '" & BunifuMetroTextboxID.Text & "', cust_firstname = '" & BunifuMetroTextboxFN.Text & "', cust_lastname = '" & BunifuMetroTextboxLN.Text & "', cust_address = '" & BunifuMetroTextboxAddress.Text & "', cust_age = '" & BunifuMetroTextboxAge.Text & "', cust_contact = '" & BunifuMetroTextboxContact.Text & "', cust_email = '" & BunifuMetroTextboxEmail.Text & "',cust_IC = '" & BunifuMetroTextboxIC.Text & "', cust_gender = '" & BunifuMetroTextboxGender.Text & "', cust_DoB = '" & DateTimePicker1.Text & "' WHERE cust_id = '" & BunifuMetroTextboxID.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			MessageBox.Show("Data Updated")
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub FormCustInfoEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM ikea.customer WHERE cust_username = '" & FormCustomerLogin.tb.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxIC.Text = READER.GetString("cust_IC")
				BunifuMetroTextboxFN.Text = READER.GetString("cust_firstname")
				BunifuMetroTextboxLN.Text = READER.GetString("cust_lastname")
				BunifuMetroTextboxAddress.Text = READER.GetString("cust_address")
				BunifuMetroTextboxAge.Text = READER.GetInt32("cust_age")
				BunifuMetroTextboxContact.Text = READER.GetString("cust_contact")
				BunifuMetroTextboxEmail.Text = READER.GetString("cust_email")
				BunifuMetroTextboxGender.Text = READER.GetString("cust_gender")
				BunifuMetroTextboxID.Text = READER.GetString("cust_id")
				DateTimePicker1.Text = READER.GetString("cust_DoB")

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
End Class