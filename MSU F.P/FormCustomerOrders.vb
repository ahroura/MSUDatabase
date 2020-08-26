Imports MySql.Data.MySqlClient

Public Class FormCustomerOrders
    Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand

	Private Sub FormCustomerOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		load_table()
	End Sub

	Private Sub TrackButton_Click(sender As Object, e As EventArgs) Handles TrackButton.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT o.order_id AS OrderID, o.order_date AS Date, p.product_name AS Product, o.order_qty As Quantity, c.cust_firstname As Customer, s.status_name as Status FROM ikea.orders o, ikea.product p, ikea.customer c, ikea.status s WHERE o.cust_id = (SELECT cust_id FROM ikea.customer WHERE cust_username = '" & FormCustomerLogin.tb.Text & "') AND o.product_id = p.product_id AND o.cust_id = c.cust_id AND o.status_id = s.status_id AND o.order_id = '" & BunifuMetroTextboxID.Text & "'"
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
			Query = "SELECT o.order_id AS OrderID, o.order_date AS Date, p.product_name AS Product, o.order_qty As Quantity, c.cust_firstname As Customer, s.status_name as Status FROM ikea.orders o, ikea.product p, ikea.customer c, ikea.status s WHERE o.cust_id = (SELECT cust_id FROM ikea.customer WHERE cust_username = '" & FormCustomerLogin.tb.Text & "') AND o.product_id = p.product_id AND o.cust_id = c.cust_id AND o.status_id = s.status_id"
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

	Private Sub load_table()
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT o.order_id AS OrderID, o.order_date AS Date, p.product_name AS Product, o.order_qty As Quantity, c.cust_firstname As Customer, s.status_name as Status FROM ikea.orders o, ikea.product p, ikea.customer c, ikea.status s WHERE o.cust_id = (SELECT cust_id FROM ikea.customer WHERE cust_username = '" & FormCustomerLogin.tb.Text & "') AND o.product_id = p.product_id AND o.cust_id = c.cust_id AND o.status_id = s.status_id"
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

	Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
		Dim dialog = DialogResult
		dialog = MessageBox.Show("Are you sure you want to cancel your order?", "Cancel", MessageBoxButtons.YesNo)
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		If dialog = DialogResult.Yes Then
			Try
				MysqlConn.Open()
				Dim Query As String
				Query = "UPDATE ikea.orders SET status_id = '7' WHERE order_id = '" & BunifuMetroTextboxID.Text & "'"
				COMMAND = New MySqlCommand(Query, MysqlConn)
				READER = COMMAND.ExecuteReader

				MessageBox.Show("Data Updated")
				MysqlConn.Close()

			Catch ex As MySqlException
				MessageBox.Show(ex.Message)
			Finally
				MysqlConn.Dispose()
			End Try
		End If

	End Sub
End Class