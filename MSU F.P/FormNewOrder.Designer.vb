<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewOrder
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductType_Combo = New System.Windows.Forms.ComboBox()
        Me.Product_Combo = New System.Windows.Forms.ComboBox()
        Me.Product_Description = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuMetroTextboxPS = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrderButton = New FontAwesome.Sharp.IconButton()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox5 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(235, 25)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "CREATE NEW ORDER"
        '
        'ProductType_Combo
        '
        Me.ProductType_Combo.FormattingEnabled = True
        Me.ProductType_Combo.Location = New System.Drawing.Point(179, 97)
        Me.ProductType_Combo.Name = "ProductType_Combo"
        Me.ProductType_Combo.Size = New System.Drawing.Size(230, 24)
        Me.ProductType_Combo.TabIndex = 19
        '
        'Product_Combo
        '
        Me.Product_Combo.FormattingEnabled = True
        Me.Product_Combo.Location = New System.Drawing.Point(179, 127)
        Me.Product_Combo.Name = "Product_Combo"
        Me.Product_Combo.Size = New System.Drawing.Size(230, 24)
        Me.Product_Combo.TabIndex = 20
        '
        'Product_Description
        '
        Me.Product_Description.BorderColorFocused = System.Drawing.Color.Blue
        Me.Product_Description.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Product_Description.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.Product_Description.BorderThickness = 3
        Me.Product_Description.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Product_Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Product_Description.isPassword = False
        Me.Product_Description.Location = New System.Drawing.Point(179, 159)
        Me.Product_Description.Margin = New System.Windows.Forms.Padding(5)
        Me.Product_Description.Name = "Product_Description"
        Me.Product_Description.Size = New System.Drawing.Size(296, 125)
        Me.Product_Description.TabIndex = 114
        Me.Product_Description.Text = "Description"
        Me.Product_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 100)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 115
        Me.Label12.Text = "Product type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Product name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 159)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 307)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Quantity:"
        '
        'BunifuMetroTextboxPS
        '
        Me.BunifuMetroTextboxPS.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxPS.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxPS.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextboxPS.BorderThickness = 3
        Me.BunifuMetroTextboxPS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextboxPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextboxPS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextboxPS.isPassword = False
        Me.BunifuMetroTextboxPS.Location = New System.Drawing.Point(179, 294)
        Me.BunifuMetroTextboxPS.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextboxPS.Name = "BunifuMetroTextboxPS"
        Me.BunifuMetroTextboxPS.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextboxPS.TabIndex = 119
        Me.BunifuMetroTextboxPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 345)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Payment method:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(180, 344)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(61, 21)
        Me.RadioButton1.TabIndex = 121
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cash"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(179, 371)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 21)
        Me.RadioButton2.TabIndex = 122
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Credit"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(179, 398)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 21)
        Me.RadioButton3.TabIndex = 123
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Debit"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(179, 425)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton4.TabIndex = 124
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "e-Wallet"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(614, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 125
        Me.PictureBox1.TabStop = False
        '
        'OrderButton
        '
        Me.OrderButton.BackColor = System.Drawing.Color.Transparent
        Me.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OrderButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.OrderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderButton.ForeColor = System.Drawing.Color.Black
        Me.OrderButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.OrderButton.IconColor = System.Drawing.Color.Black
        Me.OrderButton.IconSize = 16
        Me.OrderButton.Location = New System.Drawing.Point(179, 469)
        Me.OrderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Rotation = 0R
        Me.OrderButton.Size = New System.Drawing.Size(131, 50)
        Me.OrderButton.TabIndex = 126
        Me.OrderButton.Text = "Place Order"
        Me.OrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OrderButton.UseVisualStyleBackColor = False
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(417, 80)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextbox1.TabIndex = 127
        Me.BunifuMetroTextbox1.Text = "Qty"
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuMetroTextbox1.Visible = False
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderThickness = 3
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(0, -1)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextbox2.TabIndex = 128
        Me.BunifuMetroTextbox2.Text = "Qty"
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuMetroTextbox2.Visible = False
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox3.BorderThickness = 3
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(110, -1)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextbox3.TabIndex = 130
        Me.BunifuMetroTextbox3.Text = "Qty"
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuMetroTextbox3.Visible = False
        '
        'BunifuMetroTextbox4
        '
        Me.BunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox4.BorderThickness = 3
        Me.BunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox4.isPassword = False
        Me.BunifuMetroTextbox4.Location = New System.Drawing.Point(220, -1)
        Me.BunifuMetroTextbox4.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextbox4.Name = "BunifuMetroTextbox4"
        Me.BunifuMetroTextbox4.Size = New System.Drawing.Size(100, 41)
        Me.BunifuMetroTextbox4.TabIndex = 131
        Me.BunifuMetroTextbox4.Text = "Qty"
        Me.BunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BunifuMetroTextbox4.Visible = False
        '
        'BunifuMetroTextbox5
        '
        Me.BunifuMetroTextbox5.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox5.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox5.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox5.BorderThickness = 3
        Me.BunifuMetroTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox5.isPassword = False
        Me.BunifuMetroTextbox5.Location = New System.Drawing.Point(382, 294)
        Me.BunifuMetroTextbox5.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuMetroTextbox5.Name = "BunifuMetroTextbox5"
        Me.BunifuMetroTextbox5.Size = New System.Drawing.Size(93, 41)
        Me.BunifuMetroTextbox5.TabIndex = 133
        Me.BunifuMetroTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 307)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 132
        Me.Label5.Text = "Price:"
        '
        'FormNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1128, 585)
        Me.Controls.Add(Me.BunifuMetroTextbox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BunifuMetroTextbox4)
        Me.Controls.Add(Me.BunifuMetroTextbox3)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuMetroTextboxPS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Product_Description)
        Me.Controls.Add(Me.Product_Combo)
        Me.Controls.Add(Me.ProductType_Combo)
        Me.Controls.Add(Me.Label10)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormNewOrder"
        Me.Text = "New Order"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents ProductType_Combo As ComboBox
    Friend WithEvents Product_Combo As ComboBox
    Friend WithEvents Product_Description As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuMetroTextboxPS As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OrderButton As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox5 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
End Class
