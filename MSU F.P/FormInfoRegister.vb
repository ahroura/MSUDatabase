Imports MySql.Data.MySqlClient

Public Class FormInfoRegister
    Public Shared gender As String
    Public Shared FirstName As TextBox
    Public Shared LastName As TextBox
    Public Shared Address As TextBox
    Public Shared ContactNo As TextBox
    Public Shared ICNo As TextBox
    Public Shared DateofBirth As DateTimePicker
    Public Shared Age As TextBox
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Application.Exit()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FormEmailRegister.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=ikea"

        Try
            MysqlConn.Open()

            MessageBox.Show("Info saved")
            FormUserPassInfo.Show()
            Me.Hide()
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub FormInfoRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FirstName = BunifuTextBox1
        LastName = TextBox1
        Address = TextBox2
        ContactNo = TextBox3
        ICNo = TextBox4
        DateofBirth = DateTimePicker1
        Age = TextBox5

    End Sub
End Class