<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaffOrderView
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
        Me.UpdateButton = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxStats = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextboxID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.UpdateButton.Location = New System.Drawing.Point(137, 179)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Rotation = 0R
        Me.UpdateButton.Size = New System.Drawing.Size(98, 41)
        Me.UpdateButton.TabIndex = 95
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Order Status:"
        '
        'BunifuMetroTextboxStats
        '
        Me.BunifuMetroTextboxStats.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxStats.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxStats.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxStats.BorderThickness = 3
        Me.BunifuMetroTextboxStats.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxStats.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxStats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxStats.isPassword = False
        Me.BunifuMetroTextboxStats.Location = New System.Drawing.Point(137, 139)
        Me.BunifuMetroTextboxStats.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextboxStats.Name = "BunifuMetroTextboxStats"
        Me.BunifuMetroTextboxStats.Size = New System.Drawing.Size(38, 33)
        Me.BunifuMetroTextboxStats.TabIndex = 92
        Me.BunifuMetroTextboxStats.Text = "Stat"
        Me.BunifuMetroTextboxStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuMetroTextboxStats.Visible = False
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
        Me.BunifuMetroTextboxID.Location = New System.Drawing.Point(137, 99)
        Me.BunifuMetroTextboxID.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextboxID.Name = "BunifuMetroTextboxID"
        Me.BunifuMetroTextboxID.Size = New System.Drawing.Size(208, 33)
        Me.BunifuMetroTextboxID.TabIndex = 94
        Me.BunifuMetroTextboxID.Text = "ID"
        Me.BunifuMetroTextboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "Order ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(122, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 161)
        Me.DataGridView1.TabIndex = 90
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
        Me.IconButton1.Location = New System.Drawing.Point(352, 418)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(148, 48)
        Me.IconButton1.TabIndex = 89
        Me.IconButton1.Text = "Load Table"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 144)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 98
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 20)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "ORDERS RECORD"
        '
        'FormStaffOrderView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(846, 475)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuMetroTextboxStats)
        Me.Controls.Add(Me.BunifuMetroTextboxID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "FormStaffOrderView"
        Me.Text = "Orders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpdateButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMetroTextboxStats As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextboxID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label10 As Label
End Class
