Imports MySql.Data.MySqlClient

Public Class FormEmailRegister
    Public Shared tbE As TextBox
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FormCustomerLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=ikea"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection successful.")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=ikea"

        Try
            MysqlConn.Open()
            If BunifuTextBox1.Text = BunifuTextBox2.Text Then
                MessageBox.Show("Email verification successful")
                FormInfoRegister.Show()
                Me.Hide()

            Else
                MessageBox.Show("Email doesn't match")
            End If



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub FormEmailRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbE = BunifuTextBox2
    End Sub
End Class