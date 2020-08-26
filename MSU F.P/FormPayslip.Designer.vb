<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayslip
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxBasic = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxCommission = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SaveButton = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UpdateButton = New FontAwesome.Sharp.IconButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(91, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Basic salary:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Commission:"
        '
        'BunifuMetroTextboxBasic
        '
        Me.BunifuMetroTextboxBasic.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxBasic.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxBasic.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxBasic.BorderThickness = 3
        Me.BunifuMetroTextboxBasic.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxBasic.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxBasic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxBasic.isPassword = False
        Me.BunifuMetroTextboxBasic.Location = New System.Drawing.Point(135, 134)
        Me.BunifuMetroTextboxBasic.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextboxBasic.Name = "BunifuMetroTextboxBasic"
        Me.BunifuMetroTextboxBasic.Size = New System.Drawing.Size(208, 33)
        Me.BunifuMetroTextboxBasic.TabIndex = 105
        Me.BunifuMetroTextboxBasic.Text = "Basic"
        Me.BunifuMetroTextboxBasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextboxCommission
        '
        Me.BunifuMetroTextboxCommission.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxCommission.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxCommission.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxCommission.BorderThickness = 3
        Me.BunifuMetroTextboxCommission.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxCommission.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxCommission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxCommission.isPassword = False
        Me.BunifuMetroTextboxCommission.Location = New System.Drawing.Point(133, 176)
        Me.BunifuMetroTextboxCommission.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextboxCommission.Name = "BunifuMetroTextboxCommission"
        Me.BunifuMetroTextboxCommission.Size = New System.Drawing.Size(210, 33)
        Me.BunifuMetroTextboxCommission.TabIndex = 107
        Me.BunifuMetroTextboxCommission.Text = "Commission"
        Me.BunifuMetroTextboxCommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.SaveButton.Location = New System.Drawing.Point(135, 315)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Rotation = 0R
        Me.SaveButton.Size = New System.Drawing.Size(98, 41)
        Me.SaveButton.TabIndex = 114
        Me.SaveButton.Text = "Insert New"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "SALARY INFO"
        '
        'BunifuMetroTextboxID
        '
        Me.BunifuMetroTextboxID.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxID.BorderThickness = 3
        Me.BunifuMetroTextboxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxID.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxID.isPassword = False
        Me.BunifuMetroTextboxID.Location = New System.Drawing.Point(135, 93)
        Me.BunifuMetroTextboxID.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextboxID.Name = "BunifuMetroTextboxID"
        Me.BunifuMetroTextboxID.Size = New System.Drawing.Size(208, 33)
        Me.BunifuMetroTextboxID.TabIndex = 113
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
        Me.UpdateButton.Location = New System.Drawing.Point(245, 315)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rotation = 0R
        Me.UpdateButton.Size = New System.Drawing.Size(98, 41)
        Me.UpdateButton.TabIndex = 109
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(80, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Staff ID:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 111
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(375, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 263)
        Me.DataGridView1.TabIndex = 101
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
        Me.IconButton1.Location = New System.Drawing.Point(516, 362)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(148, 48)
        Me.IconButton1.TabIndex = 100
        Me.IconButton1.Text = "Load Table"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'FormPayslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(846, 475)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuMetroTextboxBasic)
        Me.Controls.Add(Me.BunifuMetroTextboxCommission)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BunifuMetroTextboxID)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "FormPayslip"
        Me.Text = "Payslip"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuMetroTextboxBasic As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxCommission As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents SaveButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuMetroTextboxID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents UpdateButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
