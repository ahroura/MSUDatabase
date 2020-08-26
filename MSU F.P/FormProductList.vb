Imports MySql.Data.MySqlClient

Public Class FormProductList
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
			Query = " SELECT p.*, s.sup_name, c.class_name FROM ikea.product p, ikea.suppliers s, ikea.class c WHERE product_name = '" & ComboBox1.Text & "' AND p.class_id = c.class_id AND p.sup_id = s.sup_id"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxID.Text = READER.GetString("product_id")
				BunifuMetroTextboxPN.Text = READER.GetString("product_name")
				BunifuMetroTextboxDefinition.Text = READER.GetString("product_definition")
				BunifuMetroTextboxPrice.Text = READER.GetString("product_sellprice")
				BunifuMetroTextboxCost.Text = READER.GetInt32("product_buycost")
				BunifuMetroTextboxPS.Text = READER.GetString("product_stock")
				ComboBox2.Text = READER.GetString("class_name")
				BunifuMetroTextboxCID.Text = READER.GetInt32("class_id")
				BunifuMetroTextboxSID.Text = READER.GetInt32("sup_id")
				ComboBox3.Text = READER.GetString("sup_name")

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
			Query = "UPDATE ikea.product SET product_id = '" & BunifuMetroTextboxID.Text & "', product_name = '" & BunifuMetroTextboxPN.Text & "', sup_id = '" & BunifuMetroTextboxSID.Text & "', class_id = '" & BunifuMetroTextboxCID.Text & "', product_stock = '" & BunifuMetroTextboxPS.Text & "', product_sellprice = '" & BunifuMetroTextboxPrice.Text & "', product_buycost = '" & BunifuMetroTextboxCost.Text & "', product_definition = '" & BunifuMetroTextboxDefinition.Text & "' WHERE product_id = '" & BunifuMetroTextboxID.Text & "'"
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
			Query = "INSERT INTO ikea.product (product_name, sup_id, class_id, product_stock, product_sellprice, product_buycost, product_definition)  VALUE ('" & BunifuMetroTextboxPN.Text & "', '" & BunifuMetroTextboxSID.Text & "', '" & BunifuMetroTextboxCID.Text & "', '" & BunifuMetroTextboxPS.Text & "', '" & BunifuMetroTextboxPrice.Text & "', '" & BunifuMetroTextboxCost.Text & "', '" & BunifuMetroTextboxDefinition.Text & "')"
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
	Private Sub FormProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.product WHERE product_id>0"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim pName = READER.GetString("product_name")
				ComboBox1.Items.Add(pName)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
	Private Sub FormProductList_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.class"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim pType = READER.GetString("class_name")
				ComboBox2.Items.Add(pType)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
	Private Sub FormProductList_Load_3(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT *FROM ikea.suppliers"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Dim sName = READER.GetString("sup_name")
				ComboBox3.Items.Add(sName)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM suppliers WHERE sup_name = '" & ComboBox3.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader

			While READER.Read
				BunifuMetroTextboxSID.Text = READER.GetInt32("sup_id")
			End While
			MysqlConn.Close()
		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = " SELECT * FROM class WHERE class_name = '" & ComboBox2.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				BunifuMetroTextboxCID.Text = READER.GetInt32("class_id")
			End While
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
				Query = "DELETE FROM ikea.product WHERE product_id = '" & BunifuMetroTextboxID.Text & "'"
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