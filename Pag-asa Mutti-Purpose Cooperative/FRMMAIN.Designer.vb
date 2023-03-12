<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMAIN))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuTextBox.StateProperties = New Bunifu.UI.WinForms.BunifuTextBox.StateProperties()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.LBLNAME = New Bunifu.UI.WinForms.BunifuLabel()
        Me.LBLUST = New Bunifu.UI.WinForms.BunifuLabel()
        Me.ExitTTP = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.BTNEXIT = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTNLOGOUT = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.TXTSEARCH = New Bunifu.UI.WinForms.BunifuTextBox()
        Me.PNLMAINDOCKER = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PNLNAV = New Bunifu.UI.WinForms.BunifuPanel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTNSETT = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BTNREP = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BTNLOANTRAN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BTNLOAN = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BTNMP = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BTNDASH = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.PNLHIST = New Guna.UI2.WinForms.Guna2Panel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BTNdot = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLMAINDOCKER.SuspendLayout()
        Me.PNLNAV.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLHIST.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLNAME
        '
        Me.LBLNAME.AllowParentOverrides = False
        Me.LBLNAME.AutoEllipsis = False
        Me.LBLNAME.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLNAME.CursorType = System.Windows.Forms.Cursors.Default
        Me.LBLNAME.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LBLNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LBLNAME.Location = New System.Drawing.Point(972, 12)
        Me.LBLNAME.Name = "LBLNAME"
        Me.LBLNAME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLNAME.Size = New System.Drawing.Size(118, 17)
        Me.LBLNAME.TabIndex = 3
        Me.LBLNAME.Text = "Mark jonel D. Relles"
        Me.LBLNAME.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLNAME.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.LBLNAME, "")
        Me.ExitTTP.SetToolTipIcon(Me.LBLNAME, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.LBLNAME, "")
        '
        'LBLUST
        '
        Me.LBLUST.AllowParentOverrides = False
        Me.LBLUST.AutoEllipsis = False
        Me.LBLUST.CursorType = Nothing
        Me.LBLUST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LBLUST.ForeColor = System.Drawing.Color.DimGray
        Me.LBLUST.Location = New System.Drawing.Point(973, 30)
        Me.LBLUST.Name = "LBLUST"
        Me.LBLUST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLUST.Size = New System.Drawing.Size(36, 15)
        Me.LBLUST.TabIndex = 4
        Me.LBLUST.Text = "Admin"
        Me.LBLUST.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LBLUST.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.LBLUST, "")
        Me.ExitTTP.SetToolTipIcon(Me.LBLUST, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.LBLUST, "")
        '
        'ExitTTP
        '
        Me.ExitTTP.Active = True
        Me.ExitTTP.AlignTextWithTitle = False
        Me.ExitTTP.AllowAutoClose = False
        Me.ExitTTP.AllowFading = True
        Me.ExitTTP.AutoCloseDuration = 5000
        Me.ExitTTP.BackColor = System.Drawing.SystemColors.Control
        Me.ExitTTP.BorderColor = System.Drawing.Color.Gainsboro
        Me.ExitTTP.ClickToShowDisplayControl = False
        Me.ExitTTP.ConvertNewlinesToBreakTags = True
        Me.ExitTTP.DisplayControl = Nothing
        Me.ExitTTP.EntryAnimationSpeed = 350
        Me.ExitTTP.ExitAnimationSpeed = 200
        Me.ExitTTP.GenerateAutoCloseDuration = False
        Me.ExitTTP.IconMargin = 6
        Me.ExitTTP.InitialDelay = 0
        Me.ExitTTP.Name = "ExitTTP"
        Me.ExitTTP.Opacity = 1.0R
        Me.ExitTTP.OverrideToolTipTitles = False
        Me.ExitTTP.Padding = New System.Windows.Forms.Padding(10)
        Me.ExitTTP.ReshowDelay = 100
        Me.ExitTTP.ShowAlways = True
        Me.ExitTTP.ShowBorders = False
        Me.ExitTTP.ShowIcons = True
        Me.ExitTTP.ShowShadows = True
        Me.ExitTTP.Tag = Nothing
        Me.ExitTTP.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ExitTTP.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitTTP.TextMargin = 2
        Me.ExitTTP.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ExitTTP.TitleForeColor = System.Drawing.Color.Black
        Me.ExitTTP.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.ExitTTP.ToolTipTitle = "Exit"
        '
        'BTNEXIT
        '
        Me.BTNEXIT.BackColor = System.Drawing.Color.Transparent
        Me.BTNEXIT.CheckedState.Parent = Me.BTNEXIT
        Me.BTNEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEXIT.HoverState.Parent = Me.BTNEXIT
        Me.BTNEXIT.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.power
        Me.BTNEXIT.Location = New System.Drawing.Point(1146, 16)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.PressedState.Parent = Me.BTNEXIT
        Me.BTNEXIT.Size = New System.Drawing.Size(26, 23)
        Me.BTNEXIT.TabIndex = 5
        Me.ExitTTP.SetToolTip(Me.BTNEXIT, "Exit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ExitTTP.SetToolTipIcon(Me.BTNEXIT, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNEXIT, "")
        '
        'BTNLOGOUT
        '
        Me.BTNLOGOUT.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOGOUT.CheckedState.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.HoverState.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.exit__1_
        Me.BTNLOGOUT.Location = New System.Drawing.Point(1107, 16)
        Me.BTNLOGOUT.Name = "BTNLOGOUT"
        Me.BTNLOGOUT.PressedState.Parent = Me.BTNLOGOUT
        Me.BTNLOGOUT.Size = New System.Drawing.Size(26, 23)
        Me.BTNLOGOUT.TabIndex = 0
        Me.ExitTTP.SetToolTip(Me.BTNLOGOUT, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNLOGOUT, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNLOGOUT, "")
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 20
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(925, 8)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(41, 41)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 0
        Me.BunifuPictureBox1.TabStop = False
        Me.ExitTTP.SetToolTip(Me.BunifuPictureBox1, "")
        Me.ExitTTP.SetToolTipIcon(Me.BunifuPictureBox1, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BunifuPictureBox1, "")
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.AcceptsReturn = False
        Me.TXTSEARCH.AcceptsTab = False
        Me.TXTSEARCH.AnimationSpeed = 200
        Me.TXTSEARCH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.TXTSEARCH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.TXTSEARCH.BackColor = System.Drawing.Color.Transparent
        Me.TXTSEARCH.BackgroundImage = CType(resources.GetObject("TXTSEARCH.BackgroundImage"), System.Drawing.Image)
        Me.TXTSEARCH.BorderColorActive = System.Drawing.Color.Transparent
        Me.TXTSEARCH.BorderColorDisabled = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TXTSEARCH.BorderColorHover = System.Drawing.Color.Empty
        Me.TXTSEARCH.BorderColorIdle = System.Drawing.Color.Silver
        Me.TXTSEARCH.BorderRadius = 30
        Me.TXTSEARCH.BorderThickness = 1
        Me.TXTSEARCH.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.TXTSEARCH.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.DefaultFont = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.TXTSEARCH.DefaultText = ""
        Me.TXTSEARCH.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTSEARCH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TXTSEARCH.HideSelection = True
        Me.TXTSEARCH.IconLeft = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.search__1_
        Me.TXTSEARCH.IconLeftCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.IconPadding = 10
        Me.TXTSEARCH.IconRight = Nothing
        Me.TXTSEARCH.IconRightCursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTSEARCH.Lines = New String(-1) {}
        Me.TXTSEARCH.Location = New System.Drawing.Point(240, 12)
        Me.TXTSEARCH.MaxLength = 32767
        Me.TXTSEARCH.MinimumSize = New System.Drawing.Size(1, 1)
        Me.TXTSEARCH.Modified = False
        Me.TXTSEARCH.Multiline = False
        Me.TXTSEARCH.Name = "TXTSEARCH"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        StateProperties1.FillColor = System.Drawing.Color.White
        StateProperties1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        StateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTSEARCH.OnActiveState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        StateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.TXTSEARCH.OnDisabledState = StateProperties2
        StateProperties3.BorderColor = System.Drawing.Color.Empty
        StateProperties3.FillColor = System.Drawing.Color.Empty
        StateProperties3.ForeColor = System.Drawing.Color.Empty
        StateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTSEARCH.OnHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.Silver
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        StateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.TXTSEARCH.OnIdleState = StateProperties4
        Me.TXTSEARCH.Padding = New System.Windows.Forms.Padding(3)
        Me.TXTSEARCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTSEARCH.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.TXTSEARCH.PlaceholderText = "Search"
        Me.TXTSEARCH.ReadOnly = False
        Me.TXTSEARCH.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TXTSEARCH.SelectedText = ""
        Me.TXTSEARCH.SelectionLength = 0
        Me.TXTSEARCH.SelectionStart = 0
        Me.TXTSEARCH.ShortcutsEnabled = True
        Me.TXTSEARCH.Size = New System.Drawing.Size(235, 37)
        Me.TXTSEARCH.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu
        Me.TXTSEARCH.TabIndex = 2
        Me.TXTSEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TXTSEARCH.TextMarginBottom = 0
        Me.TXTSEARCH.TextMarginLeft = 3
        Me.TXTSEARCH.TextMarginTop = 0
        Me.TXTSEARCH.TextPlaceholder = "Search"
        Me.ExitTTP.SetToolTip(Me.TXTSEARCH, "")
        Me.ExitTTP.SetToolTipIcon(Me.TXTSEARCH, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.TXTSEARCH, "")
        Me.TXTSEARCH.UseSystemPasswordChar = False
        Me.TXTSEARCH.WordWrap = True
        '
        'PNLMAINDOCKER
        '
        Me.PNLMAINDOCKER.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PNLMAINDOCKER.BackgroundImage = CType(resources.GetObject("PNLMAINDOCKER.BackgroundImage"), System.Drawing.Image)
        Me.PNLMAINDOCKER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PNLMAINDOCKER.BorderColor = System.Drawing.Color.Transparent
        Me.PNLMAINDOCKER.BorderRadius = 0
        Me.PNLMAINDOCKER.BorderThickness = 1
        Me.PNLMAINDOCKER.Controls.Add(Me.Label1)
        Me.PNLMAINDOCKER.Location = New System.Drawing.Point(235, 58)
        Me.PNLMAINDOCKER.Name = "PNLMAINDOCKER"
        Me.PNLMAINDOCKER.ShowBorders = False
        Me.PNLMAINDOCKER.Size = New System.Drawing.Size(941, 571)
        Me.PNLMAINDOCKER.TabIndex = 1
        Me.ExitTTP.SetToolTip(Me.PNLMAINDOCKER, "")
        Me.ExitTTP.SetToolTipIcon(Me.PNLMAINDOCKER, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.PNLMAINDOCKER, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(577, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "."
        Me.ExitTTP.SetToolTip(Me.Label1, "")
        Me.ExitTTP.SetToolTipIcon(Me.Label1, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.Label1, "")
        Me.Label1.Visible = False
        '
        'PNLNAV
        '
        Me.PNLNAV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PNLNAV.BackgroundImage = CType(resources.GetObject("PNLNAV.BackgroundImage"), System.Drawing.Image)
        Me.PNLNAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PNLNAV.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PNLNAV.BorderRadius = 20
        Me.PNLNAV.BorderThickness = 1
        Me.PNLNAV.Controls.Add(Me.BunifuLabel1)
        Me.PNLNAV.Controls.Add(Me.Guna2PictureBox1)
        Me.PNLNAV.Controls.Add(Me.BTNSETT)
        Me.PNLNAV.Controls.Add(Me.BTNREP)
        Me.PNLNAV.Controls.Add(Me.BTNLOANTRAN)
        Me.PNLNAV.Controls.Add(Me.BTNLOAN)
        Me.PNLNAV.Controls.Add(Me.BTNMP)
        Me.PNLNAV.Controls.Add(Me.BTNDASH)
        Me.PNLNAV.Controls.Add(Me.PNLHIST)
        Me.PNLNAV.Location = New System.Drawing.Point(9, 8)
        Me.PNLNAV.Name = "PNLNAV"
        Me.PNLNAV.ShowBorders = True
        Me.PNLNAV.Size = New System.Drawing.Size(217, 621)
        Me.PNLNAV.TabIndex = 0
        Me.ExitTTP.SetToolTip(Me.PNLNAV, "")
        Me.ExitTTP.SetToolTipIcon(Me.PNLNAV, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.PNLNAV, "")
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(8, 78)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(198, 52)
        Me.BunifuLabel1.TabIndex = 1
        Me.BunifuLabel1.Text = "Pag-asa Multi-Purpose Cooperative"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.BunifuLabel1, "")
        Me.ExitTTP.SetToolTipIcon(Me.BunifuLabel1, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BunifuLabel1, "")
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.FB_IMG_1673280633955_removebg_preview
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(69, 11)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(80, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        Me.ExitTTP.SetToolTip(Me.Guna2PictureBox1, "")
        Me.ExitTTP.SetToolTipIcon(Me.Guna2PictureBox1, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.Guna2PictureBox1, "")
        '
        'BTNSETT
        '
        Me.BTNSETT.AllowAnimations = False
        Me.BTNSETT.AllowMouseEffects = True
        Me.BTNSETT.AllowToggling = True
        Me.BTNSETT.AnimationSpeed = 200
        Me.BTNSETT.AutoGenerateColors = False
        Me.BTNSETT.AutoRoundBorders = True
        Me.BTNSETT.AutoSizeLeftIcon = True
        Me.BTNSETT.AutoSizeRightIcon = True
        Me.BTNSETT.BackColor = System.Drawing.Color.Transparent
        Me.BTNSETT.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNSETT.BackgroundImage = CType(resources.GetObject("BTNSETT.BackgroundImage"), System.Drawing.Image)
        Me.BTNSETT.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNSETT.ButtonText = "Settings "
        Me.BTNSETT.ButtonTextMarginLeft = 0
        Me.BTNSETT.ColorContrastOnClick = 45
        Me.BTNSETT.ColorContrastOnHover = 45
        Me.BTNSETT.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = False
        Me.BTNSETT.CustomizableEdges = BorderEdges1
        Me.BTNSETT.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNSETT.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNSETT.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNSETT.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNSETT.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNSETT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSETT.ForeColor = System.Drawing.Color.White
        Me.BTNSETT.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSETT.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNSETT.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNSETT.IconMarginLeft = 11
        Me.BTNSETT.IconPadding = 10
        Me.BTNSETT.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNSETT.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNSETT.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNSETT.IconSize = 25
        Me.BTNSETT.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNSETT.IdleBorderRadius = 38
        Me.BTNSETT.IdleBorderThickness = 1
        Me.BTNSETT.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNSETT.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.settings
        Me.BTNSETT.IdleIconRightImage = Nothing
        Me.BTNSETT.IndicateFocus = True
        Me.BTNSETT.Location = New System.Drawing.Point(13, 376)
        Me.BTNSETT.Name = "BTNSETT"
        Me.BTNSETT.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNSETT.OnDisabledState.BorderRadius = 1
        Me.BTNSETT.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNSETT.OnDisabledState.BorderThickness = 1
        Me.BTNSETT.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNSETT.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNSETT.OnDisabledState.IconLeftImage = Nothing
        Me.BTNSETT.OnDisabledState.IconRightImage = Nothing
        Me.BTNSETT.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNSETT.onHoverState.BorderRadius = 1
        Me.BTNSETT.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNSETT.onHoverState.BorderThickness = 1
        Me.BTNSETT.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNSETT.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNSETT.onHoverState.IconLeftImage = Nothing
        Me.BTNSETT.onHoverState.IconRightImage = Nothing
        Me.BTNSETT.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNSETT.OnIdleState.BorderRadius = 1
        Me.BTNSETT.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNSETT.OnIdleState.BorderThickness = 1
        Me.BTNSETT.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNSETT.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNSETT.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.settings
        Me.BTNSETT.OnIdleState.IconRightImage = Nothing
        Me.BTNSETT.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSETT.OnPressedState.BorderRadius = 1
        Me.BTNSETT.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNSETT.OnPressedState.BorderThickness = 1
        Me.BTNSETT.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSETT.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNSETT.OnPressedState.IconLeftImage = Nothing
        Me.BTNSETT.OnPressedState.IconRightImage = Nothing
        Me.BTNSETT.Size = New System.Drawing.Size(190, 40)
        Me.BTNSETT.TabIndex = 6
        Me.BTNSETT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNSETT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNSETT.TextMarginLeft = 0
        Me.BTNSETT.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNSETT, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNSETT, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNSETT, "")
        Me.BTNSETT.UseDefaultRadiusAndThickness = True
        '
        'BTNREP
        '
        Me.BTNREP.AllowAnimations = False
        Me.BTNREP.AllowMouseEffects = True
        Me.BTNREP.AllowToggling = True
        Me.BTNREP.AnimationSpeed = 200
        Me.BTNREP.AutoGenerateColors = False
        Me.BTNREP.AutoRoundBorders = True
        Me.BTNREP.AutoSizeLeftIcon = True
        Me.BTNREP.AutoSizeRightIcon = True
        Me.BTNREP.BackColor = System.Drawing.Color.Transparent
        Me.BTNREP.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNREP.BackgroundImage = CType(resources.GetObject("BTNREP.BackgroundImage"), System.Drawing.Image)
        Me.BTNREP.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNREP.ButtonText = "Reports"
        Me.BTNREP.ButtonTextMarginLeft = 0
        Me.BTNREP.ColorContrastOnClick = 45
        Me.BTNREP.ColorContrastOnHover = 45
        Me.BTNREP.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = False
        Me.BTNREP.CustomizableEdges = BorderEdges2
        Me.BTNREP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNREP.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNREP.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNREP.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNREP.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNREP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREP.ForeColor = System.Drawing.Color.White
        Me.BTNREP.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREP.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNREP.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNREP.IconMarginLeft = 11
        Me.BTNREP.IconPadding = 10
        Me.BTNREP.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNREP.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNREP.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNREP.IconSize = 25
        Me.BTNREP.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNREP.IdleBorderRadius = 38
        Me.BTNREP.IdleBorderThickness = 1
        Me.BTNREP.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNREP.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.stats
        Me.BTNREP.IdleIconRightImage = Nothing
        Me.BTNREP.IndicateFocus = True
        Me.BTNREP.Location = New System.Drawing.Point(13, 330)
        Me.BTNREP.Name = "BTNREP"
        Me.BTNREP.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNREP.OnDisabledState.BorderRadius = 1
        Me.BTNREP.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNREP.OnDisabledState.BorderThickness = 1
        Me.BTNREP.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNREP.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNREP.OnDisabledState.IconLeftImage = Nothing
        Me.BTNREP.OnDisabledState.IconRightImage = Nothing
        Me.BTNREP.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNREP.onHoverState.BorderRadius = 1
        Me.BTNREP.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNREP.onHoverState.BorderThickness = 1
        Me.BTNREP.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNREP.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNREP.onHoverState.IconLeftImage = Nothing
        Me.BTNREP.onHoverState.IconRightImage = Nothing
        Me.BTNREP.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNREP.OnIdleState.BorderRadius = 1
        Me.BTNREP.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNREP.OnIdleState.BorderThickness = 1
        Me.BTNREP.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNREP.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNREP.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.stats
        Me.BTNREP.OnIdleState.IconRightImage = Nothing
        Me.BTNREP.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNREP.OnPressedState.BorderRadius = 1
        Me.BTNREP.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNREP.OnPressedState.BorderThickness = 1
        Me.BTNREP.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNREP.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNREP.OnPressedState.IconLeftImage = Nothing
        Me.BTNREP.OnPressedState.IconRightImage = Nothing
        Me.BTNREP.Size = New System.Drawing.Size(190, 40)
        Me.BTNREP.TabIndex = 5
        Me.BTNREP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNREP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNREP.TextMarginLeft = 0
        Me.BTNREP.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNREP, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNREP, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNREP, "")
        Me.BTNREP.UseDefaultRadiusAndThickness = True
        '
        'BTNLOANTRAN
        '
        Me.BTNLOANTRAN.AllowAnimations = False
        Me.BTNLOANTRAN.AllowMouseEffects = True
        Me.BTNLOANTRAN.AllowToggling = True
        Me.BTNLOANTRAN.AnimationSpeed = 200
        Me.BTNLOANTRAN.AutoGenerateColors = False
        Me.BTNLOANTRAN.AutoRoundBorders = True
        Me.BTNLOANTRAN.AutoSizeLeftIcon = True
        Me.BTNLOANTRAN.AutoSizeRightIcon = True
        Me.BTNLOANTRAN.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.BackgroundImage = CType(resources.GetObject("BTNLOANTRAN.BackgroundImage"), System.Drawing.Image)
        Me.BTNLOANTRAN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOANTRAN.ButtonText = "Loan Transaction"
        Me.BTNLOANTRAN.ButtonTextMarginLeft = 0
        Me.BTNLOANTRAN.ColorContrastOnClick = 45
        Me.BTNLOANTRAN.ColorContrastOnHover = 45
        Me.BTNLOANTRAN.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = False
        Me.BTNLOANTRAN.CustomizableEdges = BorderEdges3
        Me.BTNLOANTRAN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNLOANTRAN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOANTRAN.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOANTRAN.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOANTRAN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNLOANTRAN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOANTRAN.ForeColor = System.Drawing.Color.White
        Me.BTNLOANTRAN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLOANTRAN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOANTRAN.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNLOANTRAN.IconMarginLeft = 11
        Me.BTNLOANTRAN.IconPadding = 10
        Me.BTNLOANTRAN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLOANTRAN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOANTRAN.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNLOANTRAN.IconSize = 25
        Me.BTNLOANTRAN.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.IdleBorderRadius = 38
        Me.BTNLOANTRAN.IdleBorderThickness = 1
        Me.BTNLOANTRAN.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.ballot
        Me.BTNLOANTRAN.IdleIconRightImage = Nothing
        Me.BTNLOANTRAN.IndicateFocus = True
        Me.BTNLOANTRAN.Location = New System.Drawing.Point(13, 284)
        Me.BTNLOANTRAN.Name = "BTNLOANTRAN"
        Me.BTNLOANTRAN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOANTRAN.OnDisabledState.BorderRadius = 1
        Me.BTNLOANTRAN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOANTRAN.OnDisabledState.BorderThickness = 1
        Me.BTNLOANTRAN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOANTRAN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOANTRAN.OnDisabledState.IconLeftImage = Nothing
        Me.BTNLOANTRAN.OnDisabledState.IconRightImage = Nothing
        Me.BTNLOANTRAN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLOANTRAN.onHoverState.BorderRadius = 1
        Me.BTNLOANTRAN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOANTRAN.onHoverState.BorderThickness = 1
        Me.BTNLOANTRAN.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNLOANTRAN.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNLOANTRAN.onHoverState.IconLeftImage = Nothing
        Me.BTNLOANTRAN.onHoverState.IconRightImage = Nothing
        Me.BTNLOANTRAN.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.OnIdleState.BorderRadius = 1
        Me.BTNLOANTRAN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOANTRAN.OnIdleState.BorderThickness = 1
        Me.BTNLOANTRAN.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNLOANTRAN.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNLOANTRAN.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.ballot
        Me.BTNLOANTRAN.OnIdleState.IconRightImage = Nothing
        Me.BTNLOANTRAN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOANTRAN.OnPressedState.BorderRadius = 1
        Me.BTNLOANTRAN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOANTRAN.OnPressedState.BorderThickness = 1
        Me.BTNLOANTRAN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOANTRAN.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNLOANTRAN.OnPressedState.IconLeftImage = Nothing
        Me.BTNLOANTRAN.OnPressedState.IconRightImage = Nothing
        Me.BTNLOANTRAN.Size = New System.Drawing.Size(190, 40)
        Me.BTNLOANTRAN.TabIndex = 4
        Me.BTNLOANTRAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNLOANTRAN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNLOANTRAN.TextMarginLeft = 0
        Me.BTNLOANTRAN.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNLOANTRAN, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNLOANTRAN, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNLOANTRAN, "")
        Me.BTNLOANTRAN.UseDefaultRadiusAndThickness = True
        '
        'BTNLOAN
        '
        Me.BTNLOAN.AllowAnimations = False
        Me.BTNLOAN.AllowMouseEffects = True
        Me.BTNLOAN.AllowToggling = True
        Me.BTNLOAN.AnimationSpeed = 200
        Me.BTNLOAN.AutoGenerateColors = False
        Me.BTNLOAN.AutoRoundBorders = True
        Me.BTNLOAN.AutoSizeLeftIcon = True
        Me.BTNLOAN.AutoSizeRightIcon = True
        Me.BTNLOAN.BackColor = System.Drawing.Color.Transparent
        Me.BTNLOAN.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNLOAN.BackgroundImage = CType(resources.GetObject("BTNLOAN.BackgroundImage"), System.Drawing.Image)
        Me.BTNLOAN.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOAN.ButtonText = "Loan"
        Me.BTNLOAN.ButtonTextMarginLeft = 0
        Me.BTNLOAN.ColorContrastOnClick = 45
        Me.BTNLOAN.ColorContrastOnHover = 45
        Me.BTNLOAN.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = False
        Me.BTNLOAN.CustomizableEdges = BorderEdges4
        Me.BTNLOAN.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNLOAN.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOAN.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOAN.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOAN.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNLOAN.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOAN.ForeColor = System.Drawing.Color.White
        Me.BTNLOAN.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNLOAN.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOAN.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNLOAN.IconMarginLeft = 11
        Me.BTNLOAN.IconPadding = 10
        Me.BTNLOAN.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNLOAN.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNLOAN.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNLOAN.IconSize = 25
        Me.BTNLOAN.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNLOAN.IdleBorderRadius = 38
        Me.BTNLOAN.IdleBorderThickness = 1
        Me.BTNLOAN.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNLOAN.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.file_invoice_dollar
        Me.BTNLOAN.IdleIconRightImage = Nothing
        Me.BTNLOAN.IndicateFocus = True
        Me.BTNLOAN.Location = New System.Drawing.Point(13, 238)
        Me.BTNLOAN.Name = "BTNLOAN"
        Me.BTNLOAN.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNLOAN.OnDisabledState.BorderRadius = 1
        Me.BTNLOAN.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOAN.OnDisabledState.BorderThickness = 1
        Me.BTNLOAN.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNLOAN.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNLOAN.OnDisabledState.IconLeftImage = Nothing
        Me.BTNLOAN.OnDisabledState.IconRightImage = Nothing
        Me.BTNLOAN.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNLOAN.onHoverState.BorderRadius = 1
        Me.BTNLOAN.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOAN.onHoverState.BorderThickness = 1
        Me.BTNLOAN.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNLOAN.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNLOAN.onHoverState.IconLeftImage = Nothing
        Me.BTNLOAN.onHoverState.IconRightImage = Nothing
        Me.BTNLOAN.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNLOAN.OnIdleState.BorderRadius = 1
        Me.BTNLOAN.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOAN.OnIdleState.BorderThickness = 1
        Me.BTNLOAN.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNLOAN.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNLOAN.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.file_invoice_dollar
        Me.BTNLOAN.OnIdleState.IconRightImage = Nothing
        Me.BTNLOAN.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOAN.OnPressedState.BorderRadius = 1
        Me.BTNLOAN.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNLOAN.OnPressedState.BorderThickness = 1
        Me.BTNLOAN.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNLOAN.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNLOAN.OnPressedState.IconLeftImage = Nothing
        Me.BTNLOAN.OnPressedState.IconRightImage = Nothing
        Me.BTNLOAN.Size = New System.Drawing.Size(190, 40)
        Me.BTNLOAN.TabIndex = 3
        Me.BTNLOAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNLOAN.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNLOAN.TextMarginLeft = 0
        Me.BTNLOAN.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNLOAN, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNLOAN, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNLOAN, "")
        Me.BTNLOAN.UseDefaultRadiusAndThickness = True
        '
        'BTNMP
        '
        Me.BTNMP.AllowAnimations = False
        Me.BTNMP.AllowMouseEffects = True
        Me.BTNMP.AllowToggling = True
        Me.BTNMP.AnimationSpeed = 200
        Me.BTNMP.AutoGenerateColors = False
        Me.BTNMP.AutoRoundBorders = True
        Me.BTNMP.AutoSizeLeftIcon = True
        Me.BTNMP.AutoSizeRightIcon = True
        Me.BTNMP.BackColor = System.Drawing.Color.Transparent
        Me.BTNMP.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNMP.BackgroundImage = CType(resources.GetObject("BTNMP.BackgroundImage"), System.Drawing.Image)
        Me.BTNMP.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNMP.ButtonText = "Membership"
        Me.BTNMP.ButtonTextMarginLeft = 0
        Me.BTNMP.ColorContrastOnClick = 45
        Me.BTNMP.ColorContrastOnHover = 45
        Me.BTNMP.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = False
        Me.BTNMP.CustomizableEdges = BorderEdges5
        Me.BTNMP.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNMP.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNMP.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNMP.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNMP.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNMP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMP.ForeColor = System.Drawing.Color.White
        Me.BTNMP.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMP.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNMP.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNMP.IconMarginLeft = 11
        Me.BTNMP.IconPadding = 10
        Me.BTNMP.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNMP.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNMP.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNMP.IconSize = 25
        Me.BTNMP.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNMP.IdleBorderRadius = 38
        Me.BTNMP.IdleBorderThickness = 1
        Me.BTNMP.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNMP.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.users_alt__1_
        Me.BTNMP.IdleIconRightImage = Nothing
        Me.BTNMP.IndicateFocus = True
        Me.BTNMP.Location = New System.Drawing.Point(13, 192)
        Me.BTNMP.Name = "BTNMP"
        Me.BTNMP.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNMP.OnDisabledState.BorderRadius = 1
        Me.BTNMP.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNMP.OnDisabledState.BorderThickness = 1
        Me.BTNMP.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BTNMP.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNMP.OnDisabledState.IconLeftImage = Nothing
        Me.BTNMP.OnDisabledState.IconRightImage = Nothing
        Me.BTNMP.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNMP.onHoverState.BorderRadius = 1
        Me.BTNMP.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNMP.onHoverState.BorderThickness = 1
        Me.BTNMP.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNMP.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNMP.onHoverState.IconLeftImage = Nothing
        Me.BTNMP.onHoverState.IconRightImage = Nothing
        Me.BTNMP.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNMP.OnIdleState.BorderRadius = 1
        Me.BTNMP.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNMP.OnIdleState.BorderThickness = 1
        Me.BTNMP.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNMP.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNMP.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.users_alt__1_
        Me.BTNMP.OnIdleState.IconRightImage = Nothing
        Me.BTNMP.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMP.OnPressedState.BorderRadius = 1
        Me.BTNMP.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNMP.OnPressedState.BorderThickness = 1
        Me.BTNMP.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMP.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNMP.OnPressedState.IconLeftImage = Nothing
        Me.BTNMP.OnPressedState.IconRightImage = Nothing
        Me.BTNMP.Size = New System.Drawing.Size(190, 40)
        Me.BTNMP.TabIndex = 2
        Me.BTNMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNMP.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNMP.TextMarginLeft = 0
        Me.BTNMP.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNMP, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNMP, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNMP, "")
        Me.BTNMP.UseDefaultRadiusAndThickness = True
        '
        'BTNDASH
        '
        Me.BTNDASH.AllowAnimations = False
        Me.BTNDASH.AllowMouseEffects = True
        Me.BTNDASH.AllowToggling = True
        Me.BTNDASH.AnimationSpeed = 200
        Me.BTNDASH.AutoGenerateColors = False
        Me.BTNDASH.AutoRoundBorders = True
        Me.BTNDASH.AutoSizeLeftIcon = True
        Me.BTNDASH.AutoSizeRightIcon = True
        Me.BTNDASH.BackColor = System.Drawing.Color.Transparent
        Me.BTNDASH.BackColor1 = System.Drawing.Color.Transparent
        Me.BTNDASH.BackgroundImage = CType(resources.GetObject("BTNDASH.BackgroundImage"), System.Drawing.Image)
        Me.BTNDASH.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNDASH.ButtonText = "Dashboard"
        Me.BTNDASH.ButtonTextMarginLeft = 0
        Me.BTNDASH.ColorContrastOnClick = 45
        Me.BTNDASH.ColorContrastOnHover = 45
        Me.BTNDASH.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = False
        Me.BTNDASH.CustomizableEdges = BorderEdges6
        Me.BTNDASH.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNDASH.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNDASH.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNDASH.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNDASH.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BTNDASH.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDASH.ForeColor = System.Drawing.Color.White
        Me.BTNDASH.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNDASH.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BTNDASH.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BTNDASH.IconMarginLeft = 11
        Me.BTNDASH.IconPadding = 10
        Me.BTNDASH.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNDASH.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BTNDASH.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BTNDASH.IconSize = 25
        Me.BTNDASH.IdleBorderColor = System.Drawing.Color.Transparent
        Me.BTNDASH.IdleBorderRadius = 38
        Me.BTNDASH.IdleBorderThickness = 1
        Me.BTNDASH.IdleFillColor = System.Drawing.Color.Transparent
        Me.BTNDASH.IdleIconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.apps__1_
        Me.BTNDASH.IdleIconRightImage = Nothing
        Me.BTNDASH.IndicateFocus = True
        Me.BTNDASH.Location = New System.Drawing.Point(13, 146)
        Me.BTNDASH.Name = "BTNDASH"
        Me.BTNDASH.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BTNDASH.OnDisabledState.BorderRadius = 1
        Me.BTNDASH.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNDASH.OnDisabledState.BorderThickness = 1
        Me.BTNDASH.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNDASH.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BTNDASH.OnDisabledState.IconLeftImage = Nothing
        Me.BTNDASH.OnDisabledState.IconRightImage = Nothing
        Me.BTNDASH.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BTNDASH.onHoverState.BorderRadius = 1
        Me.BTNDASH.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNDASH.onHoverState.BorderThickness = 1
        Me.BTNDASH.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.BTNDASH.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BTNDASH.onHoverState.IconLeftImage = Nothing
        Me.BTNDASH.onHoverState.IconRightImage = Nothing
        Me.BTNDASH.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.BTNDASH.OnIdleState.BorderRadius = 1
        Me.BTNDASH.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNDASH.OnIdleState.BorderThickness = 1
        Me.BTNDASH.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.BTNDASH.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BTNDASH.OnIdleState.IconLeftImage = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.apps__1_
        Me.BTNDASH.OnIdleState.IconRightImage = Nothing
        Me.BTNDASH.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNDASH.OnPressedState.BorderRadius = 1
        Me.BTNDASH.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BTNDASH.OnPressedState.BorderThickness = 1
        Me.BTNDASH.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNDASH.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BTNDASH.OnPressedState.IconLeftImage = Nothing
        Me.BTNDASH.OnPressedState.IconRightImage = Nothing
        Me.BTNDASH.Size = New System.Drawing.Size(190, 40)
        Me.BTNDASH.TabIndex = 1
        Me.BTNDASH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BTNDASH.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BTNDASH.TextMarginLeft = 0
        Me.BTNDASH.TextPadding = New System.Windows.Forms.Padding(0)
        Me.ExitTTP.SetToolTip(Me.BTNDASH, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNDASH, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BTNDASH, "")
        Me.BTNDASH.UseDefaultRadiusAndThickness = True
        '
        'PNLHIST
        '
        Me.PNLHIST.BackColor = System.Drawing.Color.Transparent
        Me.PNLHIST.BorderRadius = 10
        Me.PNLHIST.Controls.Add(Me.BunifuLabel5)
        Me.PNLHIST.Controls.Add(Me.BunifuLabel3)
        Me.PNLHIST.Controls.Add(Me.BTNdot)
        Me.PNLHIST.Controls.Add(Me.BunifuLabel2)
        Me.PNLHIST.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.PNLHIST.FillColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PNLHIST.Location = New System.Drawing.Point(13, 481)
        Me.PNLHIST.Name = "PNLHIST"
        Me.PNLHIST.ShadowDecoration.Parent = Me.PNLHIST
        Me.PNLHIST.Size = New System.Drawing.Size(191, 128)
        Me.PNLHIST.TabIndex = 1
        Me.ExitTTP.SetToolTip(Me.PNLHIST, "")
        Me.ExitTTP.SetToolTipIcon(Me.PNLHIST, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.PNLHIST, "")
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.AutoSize = False
        Me.BunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuLabel5.Location = New System.Drawing.Point(17, 88)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(156, 28)
        Me.BunifuLabel5.TabIndex = 3
        Me.BunifuLabel5.Text = "transaction reports"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.BunifuLabel5, "")
        Me.ExitTTP.SetToolTipIcon(Me.BunifuLabel5, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BunifuLabel5, "")
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.AutoSize = False
        Me.BunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuLabel3.Location = New System.Drawing.Point(17, 70)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(156, 28)
        Me.BunifuLabel3.TabIndex = 2
        Me.BunifuLabel3.Text = "Check your history weekly"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.BunifuLabel3, "")
        Me.ExitTTP.SetToolTipIcon(Me.BunifuLabel3, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BunifuLabel3, "")
        '
        'BTNdot
        '
        Me.BTNdot.ActiveImage = Nothing
        Me.BTNdot.AllowAnimations = True
        Me.BTNdot.AllowBuffering = False
        Me.BTNdot.AllowToggling = False
        Me.BTNdot.AllowZooming = False
        Me.BTNdot.AllowZoomingOnFocus = False
        Me.BTNdot.BackColor = System.Drawing.Color.Transparent
        Me.BTNdot.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BTNdot.ErrorImage = CType(resources.GetObject("BTNdot.ErrorImage"), System.Drawing.Image)
        Me.BTNdot.FadeWhenInactive = False
        Me.BTNdot.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BTNdot.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.menu_dots_vertical
        Me.BTNdot.ImageActive = Nothing
        Me.BTNdot.ImageLocation = Nothing
        Me.BTNdot.ImageMargin = 40
        Me.BTNdot.ImageSize = New System.Drawing.Size(10, 11)
        Me.BTNdot.ImageZoomSize = New System.Drawing.Size(50, 51)
        Me.BTNdot.InitialImage = CType(resources.GetObject("BTNdot.InitialImage"), System.Drawing.Image)
        Me.BTNdot.Location = New System.Drawing.Point(136, 3)
        Me.BTNdot.Name = "BTNdot"
        Me.BTNdot.Rotation = 0
        Me.BTNdot.ShowActiveImage = False
        Me.BTNdot.ShowCursorChanges = True
        Me.BTNdot.ShowImageBorders = True
        Me.BTNdot.ShowSizeMarkers = False
        Me.BTNdot.Size = New System.Drawing.Size(50, 51)
        Me.BTNdot.TabIndex = 1
        Me.ExitTTP.SetToolTip(Me.BTNdot, "")
        Me.ExitTTP.SetToolTipIcon(Me.BTNdot, Nothing)
        Me.BTNdot.ToolTipText = ""
        Me.ExitTTP.SetToolTipTitle(Me.BTNdot, "")
        Me.BTNdot.WaitOnLoad = False
        Me.BTNdot.Zoom = 40
        Me.BTNdot.ZoomSpeed = 10
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BunifuLabel2.Location = New System.Drawing.Point(37, 50)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(120, 21)
        Me.BunifuLabel2.TabIndex = 1
        Me.BunifuLabel2.Text = "History  avaliable"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        Me.ExitTTP.SetToolTip(Me.BunifuLabel2, "")
        Me.ExitTTP.SetToolTipIcon(Me.BunifuLabel2, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.BunifuLabel2, "")
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.Pag_asa_Mutti_Purpose_Cooperative.My.Resources.Resources.time_past
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(20, 16)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(30, 29)
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.ExitTTP.SetToolTip(Me.Guna2CirclePictureBox1, "")
        Me.ExitTTP.SetToolTipIcon(Me.Guna2CirclePictureBox1, Nothing)
        Me.ExitTTP.SetToolTipTitle(Me.Guna2CirclePictureBox1, "")
        '
        'FRMMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1188, 637)
        Me.Controls.Add(Me.BTNEXIT)
        Me.Controls.Add(Me.BTNLOGOUT)
        Me.Controls.Add(Me.LBLUST)
        Me.Controls.Add(Me.LBLNAME)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.TXTSEARCH)
        Me.Controls.Add(Me.PNLMAINDOCKER)
        Me.Controls.Add(Me.PNLNAV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLMAINDOCKER.ResumeLayout(False)
        Me.PNLMAINDOCKER.PerformLayout()
        Me.PNLNAV.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLHIST.ResumeLayout(False)
        Me.PNLHIST.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNLNAV As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents PNLHIST As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNREP As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BTNLOANTRAN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BTNLOAN As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BTNMP As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BTNDASH As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BTNSETT As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BTNdot As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents TXTSEARCH As Bunifu.UI.WinForms.BunifuTextBox
    Friend WithEvents LBLUST As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents LBLNAME As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BTNLOGOUT As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTNEXIT As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents ExitTTP As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PNLMAINDOCKER As Bunifu.UI.WinForms.BunifuPanel
End Class
