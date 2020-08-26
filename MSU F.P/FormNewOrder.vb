Imports MySql.Data.MySqlClient

Public Class FormNewOrder
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand
	Dim payment As String
	Private Sub FormNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		BunifuMetroTextbox4.Text = DateTime.Now.ToString("yyyy-MM-dd")
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
				ProductType_Combo.Items.Add(pType)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
	Private Sub FormNewOrder_Load_2(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.customer WHERE cust_username = '" & FormCustomerLogin.tb.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				BunifuMetroTextbox2.Text = READER.GetInt32("cust_id")
			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub ProductType_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductType_Combo.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.class WHERE class_name = '" & ProductType_Combo.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				BunifuMetroTextbox1.Text = READER.GetInt32("class_id")

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.product WHERE class_id = '" & BunifuMetroTextbox1.Text & "' AND product_id > 0"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			Product_Combo.Items.Clear()
			While READER.Read
				Dim product = READER.GetString("product_name")
				Product_Combo.Items.Add(product)

			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub Product_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Product_Combo.SelectedIndexChanged
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM ikea.product WHERE product_name = '" & Product_Combo.Text & "'"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			While READER.Read
				Product_Description.Text = READER.GetString("product_definition")
				BunifuMetroTextbox3.Text = READER.GetInt32("product_id")
				BunifuMetroTextbox5.Text = READER.GetInt32("product_sellprice")
			End While

			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
		If Product_Combo.Text = "Sandbacken" Then
			PictureBox1.Image = My.Resources.sandbacken
		ElseIf Product_Combo.Text = "Vimle" Then
			PictureBox1.Image = My.Resources.Vimle
		ElseIf Product_Combo.Text = "Hammarn" Then
			PictureBox1.Image = My.Resources.Hammarn
		ElseIf Product_Combo.Text = "Kallax" Then
			PictureBox1.Image = My.Resources.Kallax
		ElseIf Product_Combo.Text = "Hejne" Then
			PictureBox1.Image = My.Resources.Hejne
		ElseIf Product_Combo.Text = "Vilto" Then
			PictureBox1.Image = My.Resources.Vilto
		ElseIf Product_Combo.Text = "Ekedalen" Then
			PictureBox1.Image = My.Resources.Ekedalen
		ElseIf Product_Combo.Text = "Linnmon" Then
			PictureBox1.Image = My.Resources.Linnmon
		ElseIf Product_Combo.Text = "Bekant" Then
			PictureBox1.Image = My.Resources.Bekant
		ElseIf Product_Combo.Text = "Renberget" Then
			PictureBox1.Image = My.Resources.Renberget
		ElseIf Product_Combo.Text = "Markus" Then
			PictureBox1.Image = My.Resources.Markus
		ElseIf Product_Combo.Text = "Millberget" Then
			PictureBox1.Image = My.Resources.Millberget
		ElseIf Product_Combo.Text = "Malm" Then
			PictureBox1.Image = My.Resources.Malm
		ElseIf Product_Combo.Text = "Tarva" Then
			PictureBox1.Image = My.Resources.Tarva
		ElseIf Product_Combo.Text = "Songesand Bed" Then
			PictureBox1.Image = My.Resources.Songesand
		ElseIf Product_Combo.Text = "Pax" Then
			PictureBox1.Image = My.Resources.Pax
		ElseIf Product_Combo.Text = "Brimnes" Then
			PictureBox1.Image = My.Resources.Brimnes
		ElseIf Product_Combo.Text = "Songesand Wardrobe" Then
			PictureBox1.Image = My.Resources.Songesand_wardrobe
		ElseIf Product_Combo.Text = "Krustad" Then
			PictureBox1.Image = My.Resources.Krustad
		ElseIf Product_Combo.Text = "Dinera" Then
			PictureBox1.Image = My.Resources.Dinera
		ElseIf Product_Combo.Text = "Samtidig" Then
			PictureBox1.Image = My.Resources.Samtidig
		End If
	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
		payment = "1"
	End Sub
	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		payment = "2"
	End Sub
	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
		payment = "3"
	End Sub
	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
		payment = "4"
	End Sub

	Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
		Dim dialog = DialogResult
		dialog = MessageBox.Show("Place order?", "Order Confirmation", MessageBoxButtons.YesNo)
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=ikea"
		Dim READER As MySqlDataReader

		If dialog = DialogResult.Yes Then
			Try
				MysqlConn.Open()
				Dim Query As String
				Query = "INSERT INTO ikea.orders (order_date, product_id, order_qty,cust_id,payment_id) VALUE ('" & BunifuMetroTextbox4.Text & "','" & BunifuMetroTextbox3.Text & "','" & BunifuMetroTextboxPS.Text & "','" & BunifuMetroTextbox2.Text & "','" & payment & "')"
				COMMAND = New MySqlCommand(Query, MysqlConn)
				READER = COMMAND.ExecuteReader

				MessageBox.Show("Order placed.")
				MysqlConn.Close()

			Catch ex As MySqlException
				MessageBox.Show(ex.Message)
			Finally
				MysqlConn.Dispose()
			End Try
		End If

	End Sub
End Class
