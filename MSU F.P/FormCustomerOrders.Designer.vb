<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomerOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCustomerOrders))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TrackButton = New FontAwesome.Sharp.IconButton()
        Me.BunifuMetroTextboxID = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(36, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 25)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "YOUR ORDERS"
        '
        'TrackButton
        '
        Me.TrackButton.BackColor = System.Drawing.Color.Transparent
        Me.TrackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrackButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.TrackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackButton.ForeColor = System.Drawing.Color.Black
        Me.TrackButton.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.TrackButton.IconColor = System.Drawing.Color.Black
        Me.TrackButton.IconSize = 16
        Me.TrackButton.Location = New System.Drawing.Point(153, 142)
        Me.TrackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.TrackButton.Name = "TrackButton"
        Me.TrackButton.Rotation = 0R
        Me.TrackButton.Size = New System.Drawing.Size(131, 50)
        Me.TrackButton.TabIndex = 106
        Me.TrackButton.Text = "Track"
        Me.TrackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TrackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TrackButton.UseVisualStyleBackColor = False
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
        Me.BunifuMetroTextboxID.Location = New System.Drawing.Point(153, 81)
        Me.BunifuMetroTextboxID.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxID.Name = "BunifuMetroTextboxID"
        Me.BunifuMetroTextboxID.Size = New System.Drawing.Size(293, 41)
        Me.BunifuMetroTextboxID.TabIndex = 105
        Me.BunifuMetroTextboxID.Text = "ID"
        Me.BunifuMetroTextboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Order ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(105, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(859, 198)
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
        Me.IconButton1.Location = New System.Drawing.Point(431, 446)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(197, 59)
        Me.IconButton1.TabIndex = 100
        Me.IconButton1.Text = "Load Table"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
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
        Me.IconButton2.Location = New System.Drawing.Point(292, 142)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(154, 50)
        Me.IconButton2.TabIndex = 109
        Me.IconButton2.Text = "Cancel Order"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'FormCustomerOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TrackButton)
        Me.Controls.Add(Me.BunifuMetroTextboxID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IconButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormCustomerOrders"
        Me.Text = "Your Orders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents TrackButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuMetroTextboxID As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
