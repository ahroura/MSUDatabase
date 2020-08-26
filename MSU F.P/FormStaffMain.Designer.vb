<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaffMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStaffMain))
        Me.panelMenu = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.IconButton10 = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.IconButton9 = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCrtForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.IconCrtForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackgroundImage = CType(resources.GetObject("panelMenu.BackgroundImage"), System.Drawing.Image)
        Me.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMenu.Controls.Add(Me.IconButton6)
        Me.panelMenu.Controls.Add(Me.IconButton5)
        Me.panelMenu.Controls.Add(Me.IconButton3)
        Me.panelMenu.Controls.Add(Me.IconButton4)
        Me.panelMenu.Controls.Add(Me.IconButton2)
        Me.panelMenu.Controls.Add(Me.IconButton1)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.GradientBottomLeft = System.Drawing.Color.Gold
        Me.panelMenu.GradientBottomRight = System.Drawing.Color.White
        Me.panelMenu.GradientTopLeft = System.Drawing.Color.Orange
        Me.panelMenu.GradientTopRight = System.Drawing.Color.Yellow
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Quality = 10
        Me.panelMenu.Size = New System.Drawing.Size(293, 731)
        Me.panelMenu.TabIndex = 1
        '
        'IconButton6
        '
        Me.IconButton6.BackColor = System.Drawing.Color.Transparent
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton6.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.IconButton6.IconColor = System.Drawing.Color.DimGray
        Me.IconButton6.IconSize = 42
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(-4, 505)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton6.Rotation = 0R
        Me.IconButton6.Size = New System.Drawing.Size(293, 74)
        Me.IconButton6.TabIndex = 7
        Me.IconButton6.Text = "Orders"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = False
        '
        'IconButton5
        '
        Me.IconButton5.BackColor = System.Drawing.Color.Transparent
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Boxes
        Me.IconButton5.IconColor = System.Drawing.Color.DimGray
        Me.IconButton5.IconSize = 42
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(-4, 434)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(293, 74)
        Me.IconButton5.TabIndex = 6
        Me.IconButton5.Text = "Products"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = False
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox
        Me.IconButton3.IconColor = System.Drawing.Color.DimGray
        Me.IconButton3.IconSize = 42
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(-4, 294)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(293, 74)
        Me.IconButton3.TabIndex = 5
        Me.IconButton3.Text = "Suppliers"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.BackColor = System.Drawing.Color.Transparent
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave
        Me.IconButton4.IconColor = System.Drawing.Color.DimGray
        Me.IconButton4.IconSize = 42
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(-4, 364)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(293, 74)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.Text = "Payslip"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton2.IconColor = System.Drawing.Color.DimGray
        Me.IconButton2.IconSize = 42
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(-4, 224)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(293, 74)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "Staff"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.IconButton1.IconColor = System.Drawing.Color.DimGray
        Me.IconButton1.IconSize = 42
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(-4, 155)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(293, 74)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "Customers"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.Transparent
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(293, 172)
        Me.panelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton10)
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton7)
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton8)
        Me.BunifuGradientPanel1.Controls.Add(Me.IconButton9)
        Me.BunifuGradientPanel1.Controls.Add(Me.lblFormTitle)
        Me.BunifuGradientPanel1.Controls.Add(Me.IconCrtForm)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gold
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Orange
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(293, 0)
        Me.BunifuGradientPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1150, 98)
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'IconButton10
        '
        Me.IconButton10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton10.BackColor = System.Drawing.Color.Transparent
        Me.IconButton10.FlatAppearance.BorderSize = 0
        Me.IconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton10.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton10.ForeColor = System.Drawing.Color.DimGray
        Me.IconButton10.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButton10.IconColor = System.Drawing.Color.DimGray
        Me.IconButton10.IconSize = 42
        Me.IconButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton10.Location = New System.Drawing.Point(997, 31)
        Me.IconButton10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton10.Name = "IconButton10"
        Me.IconButton10.Padding = New System.Windows.Forms.Padding(13, 0, 27, 0)
        Me.IconButton10.Rotation = 0R
        Me.IconButton10.Size = New System.Drawing.Size(180, 48)
        Me.IconButton10.TabIndex = 8
        Me.IconButton10.Text = "Sign Out"
        Me.IconButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton10.UseVisualStyleBackColor = False
        '
        'IconButton7
        '
        Me.IconButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton7.BackColor = System.Drawing.Color.Transparent
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconButton7.IconColor = System.Drawing.Color.Black
        Me.IconButton7.IconSize = 15
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton7.Location = New System.Drawing.Point(1030, 4)
        Me.IconButton7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Rotation = 0R
        Me.IconButton7.Size = New System.Drawing.Size(33, 20)
        Me.IconButton7.TabIndex = 4
        Me.IconButton7.UseVisualStyleBackColor = False
        '
        'IconButton8
        '
        Me.IconButton8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton8.BackColor = System.Drawing.Color.Transparent
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.IconButton8.IconColor = System.Drawing.Color.Black
        Me.IconButton8.IconSize = 15
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton8.Location = New System.Drawing.Point(1072, 4)
        Me.IconButton8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Rotation = 0R
        Me.IconButton8.Size = New System.Drawing.Size(33, 20)
        Me.IconButton8.TabIndex = 3
        Me.IconButton8.UseVisualStyleBackColor = False
        '
        'IconButton9
        '
        Me.IconButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton9.BackColor = System.Drawing.Color.Transparent
        Me.IconButton9.FlatAppearance.BorderSize = 0
        Me.IconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton9.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton9.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton9.IconColor = System.Drawing.Color.Black
        Me.IconButton9.IconSize = 15
        Me.IconButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton9.Location = New System.Drawing.Point(1113, 4)
        Me.IconButton9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconButton9.Name = "IconButton9"
        Me.IconButton9.Rotation = 0R
        Me.IconButton9.Size = New System.Drawing.Size(33, 20)
        Me.IconButton9.TabIndex = 2
        Me.IconButton9.UseVisualStyleBackColor = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblFormTitle.Location = New System.Drawing.Point(99, 43)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(54, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCrtForm
        '
        Me.IconCrtForm.BackColor = System.Drawing.Color.Transparent
        Me.IconCrtForm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.IconCrtForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCrtForm.IconColor = System.Drawing.Color.RoyalBlue
        Me.IconCrtForm.IconSize = 48
        Me.IconCrtForm.Location = New System.Drawing.Point(29, 28)
        Me.IconCrtForm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IconCrtForm.Name = "IconCrtForm"
        Me.IconCrtForm.Size = New System.Drawing.Size(61, 48)
        Me.IconCrtForm.TabIndex = 0
        Me.IconCrtForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Wheat
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(293, 98)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1150, 633)
        Me.PanelDesktop.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(288, 126)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(577, 347)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'FormStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1443, 731)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.panelMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormStaffMain"
        Me.Text = "FormStaffMain"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.IconCrtForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents panelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton9 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCrtForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconButton10 As FontAwesome.Sharp.IconButton
End Class
