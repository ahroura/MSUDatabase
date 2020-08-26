Imports MySql.Data.MySqlClient

Public Class FormSuppliersList
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand
	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * from ikea.suppliers WHERE sup_id>0"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			SDA.SelectCommand = COMMAND
			SDA.Fill(dbDataSet)
			bSource.DataSource = dbDataSet
			DataGridView1.DataSource = bSource
			SDA.Update(dbDataSet)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub FormSuppliersList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.suppliers WHERE sup_id>0"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim pName = READER.GetString("sup_name")
				ComboBox1.Items.Add(pName)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM ikea.suppliers WHERE sup_name = '" & ComboBox1.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxID.Text = READER.GetString("sup_id")
				BunifuMetroTextboxName.Text = READER.GetString("sup_name")
				BunifuMetroTextboxAddress.Text = READER.GetString("sup_address")
				BunifuMetroTextboxNumber.Text = READER.GetString("sup_contact")
				BunifuMetroTextboxPerson.Text = READER.GetString("contact_person")
				BunifuMetroTextboxNote.Text = READER.GetString("note")

			End While

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
			Query = "INSERT INTO ikea.suppliers (sup_id, sup_name, sup_address, sup_contact, contact_person, note)  VALUE ('" & BunifuMetroTextboxID.Text & "', '" & BunifuMetroTextboxName.Text & "', '" & BunifuMetroTextboxAddress.Text & "', '" & BunifuMetroTextboxNumber.Text & "', '" & BunifuMetroTextboxPerson.Text & "', '" & BunifuMetroTextboxNote.Text & "')"
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

	Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "UPDATE ikea.suppliers SET sup_id = '" & BunifuMetroTextboxID.Text & "', sup_name = '" & BunifuMetroTextboxName.Text & "', sup_address = '" & BunifuMetroTextboxAddress.Text & "', sup_contact = '" & BunifuMetroTextboxNumber.Text & "', contact_person = '" & BunifuMetroTextboxPerson.Text & "', note = '" & BunifuMetroTextboxNote.Text & "' WHERE sup_id = '" & BunifuMetroTextboxID.Text & "'"
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

	Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
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
				Query = "DELETE FROM ikea.suppliers WHERE sup_id = '" & BunifuMetroTextboxID.Text & "'"
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