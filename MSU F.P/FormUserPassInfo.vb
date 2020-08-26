Imports MySql.Data.MySqlClient

Public Class FormUserPassInfo
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FormInfoRegister.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=ikea"
        Dim READER As MySqlDataReader

        If BunifuTextBox2.Text = TextBox1.Text Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "INSERT INTO ikea.customer (cust_firstname, cust_lastname, cust_IC, cust_address, cust_contact, cust_gender, cust_age, cust_email, cust_DoB, cust_username, cust_password) VALUE ('" & FormInfoRegister.FirstName.Text & "', '" & FormInfoRegister.LastName.Text & "', '" & FormInfoRegister.ICNo.Text & "', '" & FormInfoRegister.Address.Text & "', '" & FormInfoRegister.ContactNo.Text & "', '" & FormInfoRegister.gender & "', '" & FormInfoRegister.Age.Text & "', '" & FormEmailRegister.tbE.Text & "', '" & FormInfoRegister.DateofBirth.Text & "', '" & BunifuTextBox1.Text & "', '" & TextBox1.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Registration complete")
                FormCustomerLogin.Show()
                Me.Hide()
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            MessageBox.Show("Password doesn't match")
        End If

    End Sub
End Class