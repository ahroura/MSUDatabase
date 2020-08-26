Imports MySql.Data.MySqlClient

Public Class FormPayslip
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
			Query = "SELECT p.staff_id as StaffID, p.pay_basic as Basic, p.pay_commission AS Commission, staff_firstname AS StaffName FROM ikea.payslip p, ikea.staff s WHERE p.staff_id = s.staff_id"
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
	Private Sub FormPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
				Dim pName = READER.GetString("staff_firstname")
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
			Query = " SELECT p.*, staff_firstname FROM ikea.payslip p, ikea.staff s WHERE p.staff_id = s.staff_id AND staff_firstname = '" & ComboBox1.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxID.Text = READER.GetString("staff_id")
				BunifuMetroTextboxBasic.Text = READER.GetInt32("pay_basic")
				BunifuMetroTextboxCommission.Text = READER.GetInt32("pay_commission")

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
			Query = "INSERT INTO ikea.payslip (staff_id, pay_basic, pay_commission)  VALUE ('" & BunifuMetroTextboxID.Text & "', '" & BunifuMetroTextboxBasic.Text & "', '" & BunifuMetroTextboxCommission.Text & "')"
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
			Query = "UPDATE ikea.payslip SET staff_id = '" & BunifuMetroTextboxID.Text & "', pay_basic = '" & BunifuMetroTextboxBasic.Text & "', pay_commission = '" & BunifuMetroTextboxCommission.Text & "' WHERE staff_id = '" & BunifuMetroTextboxID.Text & "'"
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
End Class