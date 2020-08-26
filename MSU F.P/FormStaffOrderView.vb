Imports MySql.Data.MySqlClient

Public Class FormStaffOrderView
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand
	Private Sub FormStaffOrderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Dim READER As MySqlDataReader
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT o.order_id As OrderID, o.order_date AS Date, p.product_name As Product, o.order_qty AS Quantity, s.status_name AS Status, py.payment_type AS Paid
						FROM orders o, product p, status s, payment py
						WHERE o.order_id > 0
						AND o.product_id = p.product_id
						AND o.status_id = s.status_id
						AND o.payment_id = py.payment_id"
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

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.status"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim sName = READER.GetString("status_name")
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
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Dim READER As MySqlDataReader
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT o.order_id As OrderID, o.order_date AS Date, p.product_name As Product, o.order_qty AS Quantity, s.status_name AS Status, py.payment_type AS Paid
						FROM orders o, product p, status s, payment py
						WHERE o.order_id > 0
						AND o.product_id = p.product_id
						AND o.status_id = s.status_id
						AND o.payment_id = py.payment_id"
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

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.status"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim sName = READER.GetString("status_name")
				ComboBox1.Items.Add(sName)

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
			Query = "UPDATE ikea.orders SET order_id = '" & BunifuMetroTextboxID.Text & "', status_id = '" & BunifuMetroTextboxStats.Text & "' WHERE order_id = '" & BunifuMetroTextboxID.Text & "'"
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

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM ikea.status WHERE status_name = '" & ComboBox1.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxStats.Text = READER.GetInt32("status_id")

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

End Class