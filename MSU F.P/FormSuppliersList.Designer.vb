<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSuppliersList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxAddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxNumber = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UpdateButton = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuMetroTextboxPerson = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxNote = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(474, 114)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(624, 199)
        Me.DataGridView1.TabIndex = 82
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Black
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(682, 324)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(197, 59)
        Me.IconButton1.TabIndex = 81
        Me.IconButton1.Text = "Load Table"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(105, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 178)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Supplier Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 336)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Contact No:"
        '
        'BunifuMetroTextboxName
        '
        Me.BunifuMetroTextboxName.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxName.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxName.BorderThickness = 3
        Me.BunifuMetroTextboxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxName.isPassword = False
        Me.BunifuMetroTextboxName.Location = New System.Drawing.Point(164, 165)
        Me.BunifuMetroTextboxName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxName.Name = "BunifuMetroTextboxName"
        Me.BunifuMetroTextboxName.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxName.TabIndex = 86
        Me.BunifuMetroTextboxName.Text = "Supplier"
        Me.BunifuMetroTextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 389)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Contact Person:"
        '
        'BunifuMetroTextboxAddress
        '
        Me.BunifuMetroTextboxAddress.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAddress.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxAddress.BorderThickness = 3
        Me.BunifuMetroTextboxAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxAddress.isPassword = False
        Me.BunifuMetroTextboxAddress.Location = New System.Drawing.Point(164, 215)
        Me.BunifuMetroTextboxAddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxAddress.Name = "BunifuMetroTextboxAddress"
        Me.BunifuMetroTextboxAddress.Size = New System.Drawing.Size(277, 98)
        Me.BunifuMetroTextboxAddress.TabIndex = 87
        Me.BunifuMetroTextboxAddress.Text = "Address"
        Me.BunifuMetroTextboxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxNumber
        '
        Me.BunifuMetroTextboxNumber.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxNumber.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxNumber.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxNumber.BorderThickness = 3
        Me.BunifuMetroTextboxNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxNumber.isPassword = False
        Me.BunifuMetroTextboxNumber.Location = New System.Drawing.Point(164, 324)
        Me.BunifuMetroTextboxNumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxNumber.Name = "BunifuMetroTextboxNumber"
        Me.BunifuMetroTextboxNumber.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxNumber.TabIndex = 88
        Me.BunifuMetroTextboxNumber.Text = "Number"
        Me.BunifuMetroTextboxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.Black
        Me.SaveButton.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.SaveButton.IconColor = System.Drawing.Color.Black
        Me.SaveButton.IconSize = 16
        Me.SaveButton.Location = New System.Drawing.Point(164, 502)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Rotation = 0R
        Me.SaveButton.Size = New System.Drawing.Size(131, 50)
        Me.SaveButton.TabIndex = 95
        Me.SaveButton.Text = "Insert New"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 25)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "SUPPLIER INFO"
        '
        'BunifuMetroTextboxID
        '
        Me.BunifuMetroTextboxID.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderThickness = 3
        Me.BunifuMetroTextboxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.isPassword = False
        Me.BunifuMetroTextboxID.Location = New System.Drawing.Point(164, 114)
        Me.BunifuMetroTextboxID.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxID.Name = "BunifuMetroTextboxID"
        Me.BunifuMetroTextboxID.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxID.TabIndex = 94
        Me.BunifuMetroTextboxID.Text = "ID"
        Me.BunifuMetroTextboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.Black
        Me.UpdateButton.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.UpdateButton.IconColor = System.Drawing.Color.Black
        Me.UpdateButton.IconSize = 16
        Me.UpdateButton.Location = New System.Drawing.Point(311, 502)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rotation = 0R
        Me.UpdateButton.Size = New System.Drawing.Size(131, 50)
        Me.UpdateButton.TabIndex = 90
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 128)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 17)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Supplier ID:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(164, 32)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 92
        '
        'BunifuMetroTextboxPerson
        '
        Me.BunifuMetroTextboxPerson.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxPerson.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxPerson.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxPerson.BorderThickness = 3
        Me.BunifuMetroTextboxPerson.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxPerson.isPassword = False
        Me.BunifuMetroTextboxPerson.Location = New System.Drawing.Point(164, 375)
        Me.BunifuMetroTextboxPerson.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxPerson.Name = "BunifuMetroTextboxPerson"
        Me.BunifuMetroTextboxPerson.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxPerson.TabIndex = 97
        Me.BunifuMetroTextboxPerson.Text = "Name"
        Me.BunifuMetroTextboxPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxNote
        '
        Me.BunifuMetroTextboxNote.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxNote.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxNote.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxNote.BorderThickness = 3
        Me.BunifuMetroTextboxNote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxNote.isPassword = False
        Me.BunifuMetroTextboxNote.Location = New System.Drawing.Point(164, 425)
        Me.BunifuMetroTextboxNote.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuMetroTextboxNote.Name = "BunifuMetroTextboxNote"
        Me.BunifuMetroTextboxNote.Size = New System.Drawing.Size(277, 41)
        Me.BunifuMetroTextboxNote.TabIndex = 99
        Me.BunifuMetroTextboxNote.Text = "Note"
        Me.BunifuMetroTextboxNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 437)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Note:"
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Firebrick
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconSize = 16
        Me.IconButton2.Location = New System.Drawing.Point(967, 502)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(131, 50)
        Me.IconButton2.TabIndex = 100
        Me.IconButton2.Text = "Delete"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'FormSuppliersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1128, 585)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.BunifuMetroTextboxNote)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuMetroTextboxPerson)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuMetroTextboxName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuMetroTextboxAddress)
        Me.Controls.Add(Me.BunifuMetroTextboxNumber)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BunifuMetroTextboxID)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormSuppliersList"
        Me.Text = "Suppliers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuMetroTextboxName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuMetroTextboxAddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxNumber As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuMetroTextboxID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents UpdateButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuMetroTextboxPerson As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxNote As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
