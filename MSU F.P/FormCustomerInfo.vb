Imports MySql.Data.MySqlClient

Public Class FormCustomerInfo
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM ikea.customer WHERE cust_firstname = '" & ComboBox1.Text & "'"
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

	Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "INSERT INTO ikea.customer (cust_firstname, cust_lastname, cust_IC, cust_address, cust_contact, cust_gender, cust_age, cust_email, cust_DoB) VALUE ('" & BunifuMetroTextboxFN.Text & "', '" & BunifuMetroTextboxLN.Text & "', '" & BunifuMetroTextboxIC.Text & "', '" & BunifuMetroTextboxAddress.Text & "', '" & BunifuMetroTextboxContact.Text & "', '" & BunifuMetroTextboxGender.Text & "', '" & BunifuMetroTextboxAge.Text & "', '" & BunifuMetroTextboxEmail.Text & "', '" & DateTimePicker1.Text & "')"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			MessageBox.Show("New tuple saved.")
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub FormCustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.customer WHERE cust_id>0"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim sName = READER.GetString("cust_firstname")
				ComboBox1.Items.Add(sName)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		Dim dialog As DialogResult
		dialog = MessageBox.Show("Do you want to delete the data?", "Delete", MessageBoxButtons.YesNo)
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		If dialog = DialogResult.Yes Then
			Try
				MysqlConn.Open()
				Dim Query As String
				Query = "DELETE FROM ikea.customer WHERE cust_id = '" & BunifuMetroTextboxID.Text & "'"
				COMMAND = New MySqlCommand(Query, MysqlConn)
				READER = COMMAND.ExecuteReader

				MessageBox.Show("Data deleted")
				MysqlConn.Close()

			Catch ex As MySqlException
				MessageBox.Show(ex.Message)
			Finally
				MysqlConn.Dispose()
			End Try
		End If
	End Sub
End Class