<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USRCRTLDASHBOARD
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USRCRTLDASHBOARD))
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Me.LBLLMEM = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLLOAN = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLRICE = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLMEMNUM = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLLNUMBER = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLRICEKG = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLWB = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuTransition = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.LBLDASHBOARD = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2VSeparator2 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2VSeparator3 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.PCWB = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PCRICE = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PCLOAN = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PCMEM = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.PCWB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCRICE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCLOAN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCMEM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLLMEM
        '
        Me.LBLLMEM.AllowParentOverrides = False
        Me.LBLLMEM.AutoEllipsis = False
        Me.LBLLMEM.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLLMEM.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLLMEM, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLLMEM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLMEM.Location = New System.Drawing.Point(140, 93)
        Me.LBLLMEM.Name = "LBLLMEM"
        Me.LBLLMEM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLLMEM.Size = New System.Drawing.Size(51, 17)
        Me.LBLLMEM.TabIndex = 5
        Me.LBLLMEM.Text = "Member"
        Me.LBLLMEM.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLLMEM.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLLOAN
        '
        Me.LBLLOAN.AllowParentOverrides = False
        Me.LBLLOAN.AutoEllipsis = False
        Me.LBLLOAN.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLLOAN.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLLOAN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLLOAN.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LBLLOAN.Location = New System.Drawing.Point(368, 93)
        Me.LBLLOAN.Name = "LBLLOAN"
        Me.LBLLOAN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLLOAN.Size = New System.Drawing.Size(29, 17)
        Me.LBLLOAN.TabIndex = 6
        Me.LBLLOAN.Text = "Loan"
        Me.LBLLOAN.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLLOAN.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLRICE
        '
        Me.LBLRICE.AllowParentOverrides = False
        Me.LBLRICE.AutoEllipsis = False
        Me.LBLRICE.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLRICE.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLRICE, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLRICE.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRICE.Location = New System.Drawing.Point(578, 93)
        Me.LBLRICE.Name = "LBLRICE"
        Me.LBLRICE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLRICE.Size = New System.Drawing.Size(24, 17)
        Me.LBLRICE.TabIndex = 7
        Me.LBLRICE.Text = "Rice"
        Me.LBLRICE.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLRICE.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.BunifuLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel4.Location = New System.Drawing.Point(774, 93)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(58, 17)
        Me.BunifuLabel4.TabIndex = 8
        Me.BunifuLabel4.Text = "Water Bill"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLMEMNUM
        '
        Me.LBLMEMNUM.AllowParentOverrides = False
        Me.LBLMEMNUM.AutoEllipsis = False
        Me.LBLMEMNUM.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLMEMNUM.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLMEMNUM, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLMEMNUM.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMEMNUM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLMEMNUM.Location = New System.Drawing.Point(140, 116)
        Me.LBLMEMNUM.Name = "LBLMEMNUM"
        Me.LBLMEMNUM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLMEMNUM.Size = New System.Drawing.Size(22, 25)
        Me.LBLMEMNUM.TabIndex = 9
        Me.LBLMEMNUM.Text = "05"
        Me.LBLMEMNUM.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLMEMNUM.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLLNUMBER
        '
        Me.LBLLNUMBER.AllowParentOverrides = False
        Me.LBLLNUMBER.AutoEllipsis = False
        Me.LBLLNUMBER.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLLNUMBER.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLLNUMBER, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLLNUMBER.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLNUMBER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLLNUMBER.Location = New System.Drawing.Point(368, 116)
        Me.LBLLNUMBER.Name = "LBLLNUMBER"
        Me.LBLLNUMBER.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLLNUMBER.Size = New System.Drawing.Size(44, 25)
        Me.LBLLNUMBER.TabIndex = 10
        Me.LBLLNUMBER.Text = "250k"
        Me.LBLLNUMBER.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLLNUMBER.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLRICEKG
        '
        Me.LBLRICEKG.AllowParentOverrides = False
        Me.LBLRICEKG.AutoEllipsis = False
        Me.LBLRICEKG.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLRICEKG.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLRICEKG, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLRICEKG.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRICEKG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLRICEKG.Location = New System.Drawing.Point(578, 116)
        Me.LBLRICEKG.Name = "LBLRICEKG"
        Me.LBLRICEKG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLRICEKG.Size = New System.Drawing.Size(37, 25)
        Me.LBLRICEKG.TabIndex = 11
        Me.LBLRICEKG.Text = "2KG"
        Me.LBLRICEKG.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLRICEKG.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'LBLWB
        '
        Me.LBLWB.AllowParentOverrides = False
        Me.LBLWB.AutoEllipsis = False
        Me.LBLWB.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLWB.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLWB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLWB.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLWB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLWB.Location = New System.Drawing.Point(781, 116)
        Me.LBLWB.Name = "LBLWB"
        Me.LBLWB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLWB.Size = New System.Drawing.Size(44, 25)
        Me.LBLWB.TabIndex = 12
        Me.LBLWB.Text = "200k"
        Me.LBLWB.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLWB.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuTransition
        '
        Me.BunifuTransition.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition.DefaultAnimation = Animation1
        '
        'LBLDASHBOARD
        '
        Me.LBLDASHBOARD.AllowParentOverrides = False
        Me.LBLDASHBOARD.AutoEllipsis = False
        Me.LBLDASHBOARD.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLDASHBOARD.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuTransition.SetDecoration(Me.LBLDASHBOARD, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.LBLDASHBOARD.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBLDASHBOARD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLDASHBOARD.Location = New System.Drawing.Point(15, 12)
        Me.LBLDASHBOARD.Name = "LBLDASHBOARD"
        Me.LBLDASHBOARD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLDASHBOARD.Size = New System.Drawing.Size(131, 30)
        Me.LBLDASHBOARD.TabIndex = 13
        Me.LBLDASHBOARD.Text = "DASHBOARD"
        Me.LBLDASHBOARD.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLDASHBOARD.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Guna2VSeparator1
        '
        Me.BunifuTransition.SetDecoration(Me.Guna2VSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(687, 76)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(12, 72)
        Me.Guna2VSeparator1.TabIndex = 14
        '
        'Guna2VSeparator2
        '
        Me.BunifuTransition.SetDecoration(Me.Guna2VSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2VSeparator2.Location = New System.Drawing.Point(475, 76)
        Me.Guna2VSeparator2.Name = "Guna2VSeparator2"
        Me.Guna2VSeparator2.Size = New System.Drawing.Size(12, 72)
        Me.Guna2VSeparator2.TabIndex = 15
        '
        'Guna2VSeparator3
        '
        Me.BunifuTransition.SetDecoration(Me.Guna2VSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2VSeparator3.Location = New System.Drawing.Point(248, 76)
        Me.Guna2VSeparator3.Name = "Guna2VSeparator3"
        Me.Guna2VSeparator3.Size = New System.Drawing.Size(12, 72)
        Me.Guna2VSeparator3.TabIndex = 16
        '
        'PCWB
        '
        Me.BunifuTransition.SetDecoration(Me.PCWB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PCWB.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.raindrops
        Me.PCWB.Location = New System.Drawing.Point(740, 88)
        Me.PCWB.Name = "PCWB"
        Me.PCWB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PCWB.ShadowDecoration.Parent = Me.PCWB
        Me.PCWB.Size = New System.Drawing.Size(28, 27)
        Me.PCWB.TabIndex = 4
        Me.PCWB.TabStop = False
        '
        'PCRICE
        '
        Me.BunifuTransition.SetDecoration(Me.PCRICE, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PCRICE.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.wheat
        Me.PCRICE.Location = New System.Drawing.Point(538, 88)
        Me.PCRICE.Name = "PCRICE"
        Me.PCRICE.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PCRICE.ShadowDecoration.Parent = Me.PCRICE
        Me.PCRICE.Size = New System.Drawing.Size(27, 27)
        Me.PCRICE.TabIndex = 3
        Me.PCRICE.TabStop = False
        '
        'PCLOAN
        '
        Me.BunifuTransition.SetDecoration(Me.PCLOAN, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PCLOAN.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.piggy_bank
        Me.PCLOAN.Location = New System.Drawing.Point(330, 88)
        Me.PCLOAN.Name = "PCLOAN"
        Me.PCLOAN.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PCLOAN.ShadowDecoration.Parent = Me.PCLOAN
        Me.PCLOAN.Size = New System.Drawing.Size(30, 27)
        Me.PCLOAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCLOAN.TabIndex = 2
        Me.PCLOAN.TabStop = False
        '
        'PCMEM
        '
        Me.BunifuTransition.SetDecoration(Me.PCMEM, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PCMEM.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.users_alt__2_
        Me.PCMEM.Location = New System.Drawing.Point(105, 88)
        Me.PCMEM.Name = "PCMEM"
        Me.PCMEM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PCMEM.ShadowDecoration.Parent = Me.PCMEM
        Me.PCMEM.Size = New System.Drawing.Size(29, 27)
        Me.PCMEM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCMEM.TabIndex = 1
        Me.PCMEM.TabStop = False
        '
        'USRCRTLDASHBOARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Controls.Add(Me.Guna2VSeparator3)
        Me.Controls.Add(Me.Guna2VSeparator2)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.LBLDASHBOARD)
        Me.Controls.Add(Me.LBLWB)
        Me.Controls.Add(Me.LBLRICEKG)
        Me.Controls.Add(Me.LBLLNUMBER)
        Me.Controls.Add(Me.LBLMEMNUM)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.LBLRICE)
        Me.Controls.Add(Me.LBLLOAN)
        Me.Controls.Add(Me.LBLLMEM)
        Me.Controls.Add(Me.PCWB)
        Me.Controls.Add(Me.PCRICE)
        Me.Controls.Add(Me.PCLOAN)
        Me.Controls.Add(Me.PCMEM)
        Me.BunifuTransition.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Name = "USRCRTLDASHBOARD"
        Me.Size = New System.Drawing.Size(941, 571)
        CType(Me.PCWB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCRICE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCLOAN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCMEM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PCMEM As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PCLOAN As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PCRICE As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents PCWB As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LBLLMEM As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLLOAN As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLRICE As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLMEMNUM As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLLNUMBER As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLRICEKG As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents LBLWB As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuTransition As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents LBLDASHBOARD As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2VSeparator2 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2VSeparator3 As Guna.UI2.WinForms.Guna2VSeparator
End Class
