Imports MySql.Data.MySqlClient

Public Class FormStaffList
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
			Query = " SELECT * FROM ikea.staff WHERE staff_firstname = '" & ComboBox1.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				BunifuMetroTextboxIC.Text = READER.GetString("staff_IC")
				BunifuMetroTextboxFN.Text = READER.GetString("staff_firstname")
				BunifuMetroTextboxLN.Text = READER.GetString("staff_lastname")
				BunifuMetroTextboxAddress.Text = READER.GetString("staff_address")
				BunifuMetroTextboxAge.Text = READER.GetInt32("staff_age")
				BunifuMetroTextboxContact.Text = READER.GetString("staff_contact")
				BunifuMetroTextboxEmail.Text = READER.GetString("staff_email")
				BunifuMetroTextboxGender.Text = READER.GetString("staff_gender")
				BunifuMetroTextboxID.Text = READER.GetString("staff_id")
				DateTimePicker1.Text = READER.GetString("staff_startdate")
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
			Query = "UPDATE ikea.staff SET staff_id = '" & BunifuMetroTextboxID.Text & "', staff_firstname = '" & BunifuMetroTextboxFN.Text & "', staff_lastname = '" & BunifuMetroTextboxLN.Text & "', staff_address = '" & BunifuMetroTextboxAddress.Text & "', staff_age = '" & BunifuMetroTextboxAge.Text & "', staff_contact = '" & BunifuMetroTextboxContact.Text & "', staff_email = '" & BunifuMetroTextboxEmail.Text & "',staff_IC = '" & BunifuMetroTextboxIC.Text & "',staff_gender = '" & BunifuMetroTextboxGender.Text & "', staff_startdate = '" & DateTimePicker1.Text & "' WHERE staff_id = '" & BunifuMetroTextboxID.Text & "'"
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
			Query = "INSERT INTO ikea.staff (staff_firstname, staff_lastname, staff_IC, staff_address, staff_contact, staff_gender, staff_age, staff_email, staff_startdate) VALUE ('" & BunifuMetroTextboxFN.Text & "', '" & BunifuMetroTextboxLN.Text & "', '" & BunifuMetroTextboxIC.Text & "', '" & BunifuMetroTextboxAddress.Text & "', '" & BunifuMetroTextboxContact.Text & "', '" & BunifuMetroTextboxGender.Text & "', '" & BunifuMetroTextboxAge.Text & "', '" & BunifuMetroTextboxEmail.Text & "', '" & DateTimePicker1.Text & "')"
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

	Private Sub FormStaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.staff"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim sName = READER.GetString("staff_firstname")
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
				Query = "DELETE FROM ikea.staff WHERE staff_id = '" & BunifuMetroTextboxID.Text & "'"
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