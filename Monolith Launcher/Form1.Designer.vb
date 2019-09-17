<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MLauncher
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
        Dim Animation5 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MLauncher))
        Me.RoundEdge = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.HeaderPane = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MiniLink = New System.Windows.Forms.LinkLabel()
        Me.XLink = New System.Windows.Forms.LinkLabel()
        Me.GameInfoLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ErrCard = New Bunifu.Framework.UI.BunifuCards()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ErrDes = New System.Windows.Forms.RichTextBox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.DragProperty = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.DragProperty2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PROCESSCHK = New System.Windows.Forms.Timer(Me.components)
        Me.release = New System.Windows.Forms.Panel()
        Me.UpdPane = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GMODCard = New System.Windows.Forms.Panel()
        Me.RustCard = New System.Windows.Forms.Panel()
        Me.RustMP = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LinkLabel18 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.infolabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LinkLabel17 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateCheck = New System.ComponentModel.BackgroundWorker()
        Me.whatsnew = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GMODPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.RustPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.HeaderPane.SuspendLayout()
        Me.ErrCard.SuspendLayout()
        Me.release.SuspendLayout()
        Me.UpdPane.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GMODCard.SuspendLayout()
        Me.RustCard.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.whatsnew.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundEdge
        '
        Me.RoundEdge.ElipseRadius = 10
        Me.RoundEdge.TargetControl = Me
        '
        'HeaderPane
        '
        Me.HeaderPane.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.HeaderPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaderPane.Controls.Add(Me.BunifuCustomLabel6)
        Me.HeaderPane.Controls.Add(Me.PictureBox2)
        Me.HeaderPane.Controls.Add(Me.Logo)
        Me.HeaderPane.Controls.Add(Me.MiniLink)
        Me.HeaderPane.Controls.Add(Me.XLink)
        Me.BunifuTransition1.SetDecoration(Me.HeaderPane, BunifuAnimatorNS.DecorationType.None)
        Me.HeaderPane.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPane.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPane.Name = "HeaderPane"
        Me.HeaderPane.Size = New System.Drawing.Size(1239, 80)
        Me.HeaderPane.TabIndex = 0
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(566, 56)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(107, 15)
        Me.BunifuCustomLabel6.TabIndex = 22
        Me.BunifuCustomLabel6.Text = "Version 0.0.0.0000"
        '
        'MiniLink
        '
        Me.MiniLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiniLink.AutoSize = True
        Me.MiniLink.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.MiniLink, BunifuAnimatorNS.DecorationType.None)
        Me.MiniLink.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiniLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.MiniLink.LinkColor = System.Drawing.Color.White
        Me.MiniLink.Location = New System.Drawing.Point(1165, 7)
        Me.MiniLink.Name = "MiniLink"
        Me.MiniLink.Size = New System.Drawing.Size(31, 30)
        Me.MiniLink.TabIndex = 2
        Me.MiniLink.TabStop = True
        Me.MiniLink.Text = "__"
        '
        'XLink
        '
        Me.XLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XLink.AutoSize = True
        Me.XLink.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.XLink, BunifuAnimatorNS.DecorationType.None)
        Me.XLink.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.XLink.LinkColor = System.Drawing.Color.White
        Me.XLink.Location = New System.Drawing.Point(1201, 9)
        Me.XLink.Name = "XLink"
        Me.XLink.Size = New System.Drawing.Size(26, 30)
        Me.XLink.TabIndex = 1
        Me.XLink.TabStop = True
        Me.XLink.Text = "X"
        '
        'GameInfoLabel
        '
        Me.GameInfoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GameInfoLabel.AutoSize = True
        Me.GameInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.GameInfoLabel, BunifuAnimatorNS.DecorationType.None)
        Me.GameInfoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameInfoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GameInfoLabel.Location = New System.Drawing.Point(322, 93)
        Me.GameInfoLabel.Name = "GameInfoLabel"
        Me.GameInfoLabel.Size = New System.Drawing.Size(95, 15)
        Me.GameInfoLabel.TabIndex = 7
        Me.GameInfoLabel.Text = "hl2.exe is loaded"
        Me.GameInfoLabel.Visible = False
        '
        'ErrCard
        '
        Me.ErrCard.BackColor = System.Drawing.Color.Maroon
        Me.ErrCard.BorderRadius = 5
        Me.ErrCard.BottomSahddow = True
        Me.ErrCard.color = System.Drawing.Color.DarkRed
        Me.ErrCard.Controls.Add(Me.LinkLabel2)
        Me.ErrCard.Controls.Add(Me.ErrDes)
        Me.ErrCard.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuTransition1.SetDecoration(Me.ErrCard, BunifuAnimatorNS.DecorationType.None)
        Me.ErrCard.LeftSahddow = False
        Me.ErrCard.Location = New System.Drawing.Point(12, 471)
        Me.ErrCard.Name = "ErrCard"
        Me.ErrCard.RightSahddow = True
        Me.ErrCard.ShadowDepth = 20
        Me.ErrCard.Size = New System.Drawing.Size(625, 174)
        Me.ErrCard.TabIndex = 2
        Me.ErrCard.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(590, 13)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(17, 17)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "X"
        '
        'ErrDes
        '
        Me.ErrDes.BackColor = System.Drawing.Color.Maroon
        Me.ErrDes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.ErrDes, BunifuAnimatorNS.DecorationType.None)
        Me.ErrDes.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrDes.ForeColor = System.Drawing.Color.Silver
        Me.ErrDes.Location = New System.Drawing.Point(12, 36)
        Me.ErrDes.Name = "ErrDes"
        Me.ErrDes.ReadOnly = True
        Me.ErrDes.Size = New System.Drawing.Size(601, 127)
        Me.ErrDes.TabIndex = 8
        Me.ErrDes.Text = ""
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(8, 10)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(241, 20)
        Me.BunifuCustomLabel5.TabIndex = 7
        Me.BunifuCustomLabel5.Text = "The Launcher ran across a problem."
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-settings-100.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-settings-50.png")
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.White
        Me.LinkLabel4.Location = New System.Drawing.Point(64, 297)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(157, 15)
        Me.LinkLabel4.TabIndex = 17
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "View recommended Addons"
        '
        'DragProperty
        '
        Me.DragProperty.Fixed = True
        Me.DragProperty.Horizontal = True
        Me.DragProperty.TargetControl = Me.HeaderPane
        Me.DragProperty.Vertical = True
        '
        'DragProperty2
        '
        Me.DragProperty2.Fixed = True
        Me.DragProperty2.Horizontal = True
        Me.DragProperty2.TargetControl = Me.Logo
        Me.DragProperty2.Vertical = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Location = New System.Drawing.Point(1588, 644)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(160, 15)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "View application information"
        '
        'PROCESSCHK
        '
        Me.PROCESSCHK.Enabled = True
        Me.PROCESSCHK.Interval = 1000
        '
        'release
        '
        Me.release.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.release.Controls.Add(Me.UpdPane)
        Me.release.Controls.Add(Me.whatsnew)
        Me.release.Controls.Add(Me.ErrCard)
        Me.release.Controls.Add(Me.GMODCard)
        Me.release.Controls.Add(Me.RustCard)
        Me.release.Controls.Add(Me.Panel7)
        Me.release.Controls.Add(Me.infolabel2)
        Me.release.Controls.Add(Me.GameInfoLabel)
        Me.release.Controls.Add(Me.Panel6)
        Me.release.Controls.Add(Me.Panel5)
        Me.release.Controls.Add(Me.Panel4)
        Me.release.Controls.Add(Me.Panel3)
        Me.release.Controls.Add(Me.PictureBox1)
        Me.release.Controls.Add(Me.LinkLabel3)
        Me.BunifuTransition1.SetDecoration(Me.release, BunifuAnimatorNS.DecorationType.None)
        Me.release.Dock = System.Windows.Forms.DockStyle.Fill
        Me.release.Location = New System.Drawing.Point(0, 80)
        Me.release.Name = "release"
        Me.release.Size = New System.Drawing.Size(1239, 658)
        Me.release.TabIndex = 11
        '
        'UpdPane
        '
        Me.UpdPane.Controls.Add(Me.Panel1)
        Me.UpdPane.Controls.Add(Me.PictureBox12)
        Me.BunifuTransition1.SetDecoration(Me.UpdPane, BunifuAnimatorNS.DecorationType.None)
        Me.UpdPane.Location = New System.Drawing.Point(1027, 19)
        Me.UpdPane.Name = "UpdPane"
        Me.UpdPane.Size = New System.Drawing.Size(200, 100)
        Me.UpdPane.TabIndex = 24
        Me.UpdPane.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Location = New System.Drawing.Point(451, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 290)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monolith Launcher " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "has a new update!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.BunifuTransition1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Location = New System.Drawing.Point(58, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Yes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Location = New System.Drawing.Point(170, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "No"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Do you wanna download the latest version?"
        '
        'GMODCard
        '
        Me.GMODCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.GMODCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GMODCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GMODCard.Controls.Add(Me.PictureBox5)
        Me.GMODCard.Controls.Add(Me.GMODPlay)
        Me.GMODCard.Controls.Add(Me.LinkLabel4)
        Me.GMODCard.Controls.Add(Me.PictureBox4)
        Me.BunifuTransition1.SetDecoration(Me.GMODCard, BunifuAnimatorNS.DecorationType.None)
        Me.GMODCard.Location = New System.Drawing.Point(325, 111)
        Me.GMODCard.Name = "GMODCard"
        Me.GMODCard.Size = New System.Drawing.Size(286, 371)
        Me.GMODCard.TabIndex = 1
        '
        'RustCard
        '
        Me.RustCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.RustCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RustCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RustCard.Controls.Add(Me.RustMP)
        Me.RustCard.Controls.Add(Me.PictureBox6)
        Me.RustCard.Controls.Add(Me.RustPlay)
        Me.RustCard.Controls.Add(Me.PictureBox7)
        Me.BunifuTransition1.SetDecoration(Me.RustCard, BunifuAnimatorNS.DecorationType.None)
        Me.RustCard.Location = New System.Drawing.Point(629, 111)
        Me.RustCard.Name = "RustCard"
        Me.RustCard.Size = New System.Drawing.Size(286, 371)
        Me.RustCard.TabIndex = 2
        '
        'RustMP
        '
        Me.RustMP.BackColor = System.Drawing.Color.Transparent
        Me.RustMP.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.RustMP, BunifuAnimatorNS.DecorationType.None)
        Me.RustMP.ForeColor = System.Drawing.Color.White
        Me.RustMP.Items = New String() {"MONORUST.COM | 5X", "MONORUST.COM | 1000X (Battlefield)"}
        Me.RustMP.Location = New System.Drawing.Point(20, 277)
        Me.RustMP.Name = "RustMP"
        Me.RustMP.NomalColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.RustMP.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.RustMP.selectedIndex = 0
        Me.RustMP.Size = New System.Drawing.Size(242, 35)
        Me.RustMP.TabIndex = 7
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel7.Controls.Add(Me.LinkLabel18)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Controls.Add(Me.BunifuCustomLabel7)
        Me.BunifuTransition1.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Location = New System.Drawing.Point(402, 254)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(434, 101)
        Me.Panel7.TabIndex = 22
        Me.Panel7.Visible = False
        '
        'LinkLabel18
        '
        Me.LinkLabel18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel18.LinkColor = System.Drawing.Color.DimGray
        Me.LinkLabel18.Location = New System.Drawing.Point(66, 73)
        Me.LinkLabel18.Name = "LinkLabel18"
        Me.LinkLabel18.Size = New System.Drawing.Size(110, 15)
        Me.LinkLabel18.TabIndex = 15
        Me.LinkLabel18.TabStop = True
        Me.LinkLabel18.Text = "Reload Application"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.DimGray
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(65, 32)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(361, 30)
        Me.BunifuCustomLabel8.TabIndex = 13
        Me.BunifuCustomLabel8.Text = "We wasn't able to establish an connection with Monolith Servers," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "they might be O" &
    "ffline, or your Internet Connection is disconnected."
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.Gray
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(64, 12)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(308, 20)
        Me.BunifuCustomLabel7.TabIndex = 12
        Me.BunifuCustomLabel7.Text = "Where's the fun in playing without internet?"
        '
        'infolabel2
        '
        Me.infolabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.infolabel2.AutoSize = True
        Me.infolabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.infolabel2, BunifuAnimatorNS.DecorationType.None)
        Me.infolabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infolabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.infolabel2.Location = New System.Drawing.Point(626, 90)
        Me.infolabel2.Name = "infolabel2"
        Me.infolabel2.Size = New System.Drawing.Size(131, 15)
        Me.infolabel2.TabIndex = 21
        Me.infolabel2.Text = "RustClient.exe is loaded"
        Me.infolabel2.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LinkLabel17)
        Me.Panel6.Controls.Add(Me.PictureBox11)
        Me.Panel6.Controls.Add(Me.LinkLabel14)
        Me.Panel6.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel6.Controls.Add(Me.LinkLabel15)
        Me.Panel6.Controls.Add(Me.LinkLabel16)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(842, 508)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(218, 137)
        Me.Panel6.TabIndex = 20
        '
        'LinkLabel17
        '
        Me.LinkLabel17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel17, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel17.LinkColor = System.Drawing.Color.White
        Me.LinkLabel17.Location = New System.Drawing.Point(78, 116)
        Me.LinkLabel17.Name = "LinkLabel17"
        Me.LinkLabel17.Size = New System.Drawing.Size(85, 15)
        Me.LinkLabel17.TabIndex = 17
        Me.LinkLabel17.TabStop = True
        Me.LinkLabel17.Text = "File an appeal"
        Me.LinkLabel17.UseMnemonic = False
        '
        'LinkLabel14
        '
        Me.LinkLabel14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel14, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel14.LinkColor = System.Drawing.Color.White
        Me.LinkLabel14.Location = New System.Drawing.Point(78, 91)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel14.TabIndex = 16
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "Staff Reports"
        Me.LinkLabel14.UseMnemonic = False
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(64, 15)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(115, 20)
        Me.BunifuCustomLabel4.TabIndex = 12
        Me.BunifuCustomLabel4.Text = "Support & Help"
        Me.BunifuCustomLabel4.UseMnemonic = False
        '
        'LinkLabel15
        '
        Me.LinkLabel15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel15, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel15.LinkColor = System.Drawing.Color.White
        Me.LinkLabel15.Location = New System.Drawing.Point(78, 65)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(87, 15)
        Me.LinkLabel15.TabIndex = 15
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "Player Reports"
        Me.LinkLabel15.UseMnemonic = False
        '
        'LinkLabel16
        '
        Me.LinkLabel16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel16, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel16.LinkColor = System.Drawing.Color.White
        Me.LinkLabel16.Location = New System.Drawing.Point(78, 40)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(102, 15)
        Me.LinkLabel16.TabIndex = 14
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "In-game Refunds"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox10)
        Me.Panel5.Controls.Add(Me.LinkLabel11)
        Me.Panel5.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel5.Controls.Add(Me.LinkLabel12)
        Me.Panel5.Controls.Add(Me.LinkLabel13)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(618, 508)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(218, 131)
        Me.Panel5.TabIndex = 19
        '
        'LinkLabel11
        '
        Me.LinkLabel11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel11.LinkColor = System.Drawing.Color.White
        Me.LinkLabel11.Location = New System.Drawing.Point(78, 91)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(140, 15)
        Me.LinkLabel11.TabIndex = 16
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "Updates & Change Logs"
        Me.LinkLabel11.UseMnemonic = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(64, 15)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(90, 20)
        Me.BunifuCustomLabel3.TabIndex = 12
        Me.BunifuCustomLabel3.Text = "Information"
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel12, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel12.LinkColor = System.Drawing.Color.White
        Me.LinkLabel12.Location = New System.Drawing.Point(78, 65)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(73, 15)
        Me.LinkLabel12.TabIndex = 15
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "Rules & Info"
        Me.LinkLabel12.UseMnemonic = False
        '
        'LinkLabel13
        '
        Me.LinkLabel13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel13, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel13.LinkColor = System.Drawing.Color.White
        Me.LinkLabel13.Location = New System.Drawing.Point(78, 40)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(96, 15)
        Me.LinkLabel13.TabIndex = 14
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "Announcements"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox9)
        Me.Panel4.Controls.Add(Me.LinkLabel8)
        Me.Panel4.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel4.Controls.Add(Me.LinkLabel9)
        Me.Panel4.Controls.Add(Me.LinkLabel10)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Location = New System.Drawing.Point(394, 508)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(218, 117)
        Me.Panel4.TabIndex = 18
        '
        'LinkLabel8
        '
        Me.LinkLabel8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel8, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel8.LinkColor = System.Drawing.Color.White
        Me.LinkLabel8.Location = New System.Drawing.Point(78, 91)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(131, 15)
        Me.LinkLabel8.TabIndex = 16
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Monolith Steam Group"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(64, 15)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(49, 20)
        Me.BunifuCustomLabel2.TabIndex = 12
        Me.BunifuCustomLabel2.Text = "Social"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel9.LinkColor = System.Drawing.Color.White
        Me.LinkLabel9.Location = New System.Drawing.Point(78, 65)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(109, 15)
        Me.LinkLabel9.TabIndex = 15
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "MonoRust Discord"
        '
        'LinkLabel10
        '
        Me.LinkLabel10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel10, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel10.LinkColor = System.Drawing.Color.White
        Me.LinkLabel10.Location = New System.Drawing.Point(78, 40)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(117, 15)
        Me.LinkLabel10.TabIndex = 14
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "MonolithRP Discord"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox8)
        Me.Panel3.Controls.Add(Me.LinkLabel7)
        Me.Panel3.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel3.Controls.Add(Me.LinkLabel5)
        Me.Panel3.Controls.Add(Me.LinkLabel6)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(179, 508)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(208, 117)
        Me.Panel3.TabIndex = 17
        '
        'LinkLabel7
        '
        Me.LinkLabel7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel7, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.White
        Me.LinkLabel7.Location = New System.Drawing.Point(78, 91)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(77, 15)
        Me.LinkLabel7.TabIndex = 16
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "View Servers"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(64, 15)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(127, 20)
        Me.BunifuCustomLabel1.TabIndex = 12
        Me.BunifuCustomLabel1.Text = "Monolith Servers"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel5, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.White
        Me.LinkLabel5.Location = New System.Drawing.Point(78, 65)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(61, 15)
        Me.LinkLabel5.TabIndex = 15
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Visit Store"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel6, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.White
        Me.LinkLabel6.Location = New System.Drawing.Point(78, 40)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(74, 15)
        Me.LinkLabel6.TabIndex = 14
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Visit Forums"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "Monolith Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.BunifuTransition1.Cursor = Nothing
        Animation5.AnimateOnlyDifferences = True
        Animation5.BlindCoeff = CType(resources.GetObject("Animation5.BlindCoeff"), System.Drawing.PointF)
        Animation5.LeafCoeff = 0!
        Animation5.MaxTime = 1.0!
        Animation5.MinTime = 0!
        Animation5.MosaicCoeff = CType(resources.GetObject("Animation5.MosaicCoeff"), System.Drawing.PointF)
        Animation5.MosaicShift = CType(resources.GetObject("Animation5.MosaicShift"), System.Drawing.PointF)
        Animation5.MosaicSize = 0
        Animation5.Padding = New System.Windows.Forms.Padding(0)
        Animation5.RotateCoeff = 0!
        Animation5.RotateLimit = 0!
        Animation5.ScaleCoeff = CType(resources.GetObject("Animation5.ScaleCoeff"), System.Drawing.PointF)
        Animation5.SlideCoeff = CType(resources.GetObject("Animation5.SlideCoeff"), System.Drawing.PointF)
        Animation5.TimeCoeff = 0!
        Animation5.TransparencyCoeff = 1.0!
        Me.BunifuTransition1.DefaultAnimation = Animation5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2500
        '
        'UpdateCheck
        '
        '
        'whatsnew
        '
        Me.whatsnew.Controls.Add(Me.Panel8)
        Me.whatsnew.Controls.Add(Me.PictureBox13)
        Me.BunifuTransition1.SetDecoration(Me.whatsnew, BunifuAnimatorNS.DecorationType.None)
        Me.whatsnew.Location = New System.Drawing.Point(1027, 125)
        Me.whatsnew.Name = "whatsnew"
        Me.whatsnew.Size = New System.Drawing.Size(200, 100)
        Me.whatsnew.TabIndex = 25
        Me.whatsnew.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Button3)
        Me.Panel8.Controls.Add(Me.RichTextBox1)
        Me.Panel8.Controls.Add(Me.PictureBox14)
        Me.BunifuTransition1.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.Panel8.Location = New System.Drawing.Point(451, 132)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(336, 394)
        Me.Panel8.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.RichTextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.RichTextBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 79)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(312, 245)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BunifuTransition1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(73, 338)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(187, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Continue"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox14
        '
        Me.PictureBox14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.s_2498C21E55ADDB3F0E37325C58348AA60626868EC6DEADD8FAF68C9DF46F7B6D_1480362942566_Monolith_Document_Header_and_Footer22
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox14, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox14.Location = New System.Drawing.Point(-225, -50)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(785, 178)
        Me.PictureBox14.TabIndex = 3
        Me.PictureBox14.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.PictureBox13, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox13.Location = New System.Drawing.Point(0, 219)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(1239, 184)
        Me.PictureBox13.TabIndex = 3
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.PictureBox12, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox12.Location = New System.Drawing.Point(0, 219)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(1239, 184)
        Me.PictureBox12.TabIndex = 3
        Me.PictureBox12.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.logo
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 18)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(278, 46)
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'GMODPlay
        '
        Me.GMODPlay.Activecolor = System.Drawing.Color.Gray
        Me.GMODPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GMODPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GMODPlay.BackgroundImage = CType(resources.GetObject("GMODPlay.BackgroundImage"), System.Drawing.Image)
        Me.GMODPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GMODPlay.BorderRadius = 0
        Me.GMODPlay.ButtonText = "Play Monolith RP"
        Me.GMODPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.GMODPlay, BunifuAnimatorNS.DecorationType.None)
        Me.GMODPlay.DisabledColor = System.Drawing.Color.Gray
        Me.GMODPlay.Iconcolor = System.Drawing.Color.Transparent
        Me.GMODPlay.Iconimage = CType(resources.GetObject("GMODPlay.Iconimage"), System.Drawing.Image)
        Me.GMODPlay.Iconimage_right = Nothing
        Me.GMODPlay.Iconimage_right_Selected = Nothing
        Me.GMODPlay.Iconimage_Selected = Nothing
        Me.GMODPlay.IconMarginLeft = 0
        Me.GMODPlay.IconMarginRight = 0
        Me.GMODPlay.IconRightVisible = True
        Me.GMODPlay.IconRightZoom = 0R
        Me.GMODPlay.IconVisible = False
        Me.GMODPlay.IconZoom = 90.0R
        Me.GMODPlay.IsTab = False
        Me.GMODPlay.Location = New System.Drawing.Point(20, 314)
        Me.GMODPlay.Name = "GMODPlay"
        Me.GMODPlay.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GMODPlay.OnHovercolor = System.Drawing.Color.Black
        Me.GMODPlay.OnHoverTextColor = System.Drawing.Color.White
        Me.GMODPlay.selected = False
        Me.GMODPlay.Size = New System.Drawing.Size(242, 39)
        Me.GMODPlay.TabIndex = 6
        Me.GMODPlay.Text = "Play Monolith RP"
        Me.GMODPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GMODPlay.Textcolor = System.Drawing.Color.White
        Me.GMODPlay.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources._885284465_preview_568ba017698e7__1_
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(0, 84)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(284, 285)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.Untitled
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox6, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox6.Location = New System.Drawing.Point(2, 9)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(281, 64)
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'RustPlay
        '
        Me.RustPlay.Activecolor = System.Drawing.Color.Maroon
        Me.RustPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RustPlay.BackColor = System.Drawing.Color.Black
        Me.RustPlay.BackgroundImage = CType(resources.GetObject("RustPlay.BackgroundImage"), System.Drawing.Image)
        Me.RustPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RustPlay.BorderRadius = 0
        Me.RustPlay.ButtonText = "Play MonoRust"
        Me.RustPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.RustPlay, BunifuAnimatorNS.DecorationType.None)
        Me.RustPlay.DisabledColor = System.Drawing.Color.Gray
        Me.RustPlay.Iconcolor = System.Drawing.Color.Transparent
        Me.RustPlay.Iconimage = CType(resources.GetObject("RustPlay.Iconimage"), System.Drawing.Image)
        Me.RustPlay.Iconimage_right = Nothing
        Me.RustPlay.Iconimage_right_Selected = Nothing
        Me.RustPlay.Iconimage_Selected = Nothing
        Me.RustPlay.IconMarginLeft = 0
        Me.RustPlay.IconMarginRight = 0
        Me.RustPlay.IconRightVisible = True
        Me.RustPlay.IconRightZoom = 0R
        Me.RustPlay.IconVisible = False
        Me.RustPlay.IconZoom = 90.0R
        Me.RustPlay.IsTab = False
        Me.RustPlay.Location = New System.Drawing.Point(20, 314)
        Me.RustPlay.Name = "RustPlay"
        Me.RustPlay.Normalcolor = System.Drawing.Color.Black
        Me.RustPlay.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RustPlay.OnHoverTextColor = System.Drawing.Color.White
        Me.RustPlay.selected = False
        Me.RustPlay.Size = New System.Drawing.Size(242, 39)
        Me.RustPlay.TabIndex = 6
        Me.RustPlay.Text = "Play MonoRust"
        Me.RustPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RustPlay.Textcolor = System.Drawing.Color.White
        Me.RustPlay.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.huntigbow
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox7, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox7.Location = New System.Drawing.Point(0, 84)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(284, 285)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.logo_2_
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 46)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.icons8_headset_50
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox11, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox11.Location = New System.Drawing.Point(19, 15)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(39, 46)
        Me.PictureBox11.TabIndex = 11
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.icons8_signpost_50
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox10, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox10.Location = New System.Drawing.Point(19, 15)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(39, 46)
        Me.PictureBox10.TabIndex = 11
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.icons8_share_50
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox9, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox9.Location = New System.Drawing.Point(19, 15)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(39, 46)
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.logo_2_
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox8, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox8.Location = New System.Drawing.Point(19, 15)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(39, 46)
        Me.PictureBox8.TabIndex = 11
        Me.PictureBox8.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 219)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1239, 184)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.LinkLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.LinkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel3.ImageIndex = 1
        Me.LinkLabel3.ImageList = Me.ImageList1
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.White
        Me.LinkLabel3.Location = New System.Drawing.Point(190, 38)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(343, 45)
        Me.LinkLabel3.TabIndex = 10
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "      Advanced Settings"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.beta_version_icon_1_jpg
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 109)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Logo
        '
        Me.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.BackgroundImage = Global.Monolith_Launcher.My.Resources.Resources.logo
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Logo.Location = New System.Drawing.Point(454, 3)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(331, 68)
        Me.Logo.TabIndex = 1
        Me.Logo.TabStop = False
        '
        'MLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1239, 738)
        Me.Controls.Add(Me.release)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.HeaderPane)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MLauncher"
        Me.Text = "Monolith Launcher by Rondell"
        Me.HeaderPane.ResumeLayout(False)
        Me.HeaderPane.PerformLayout()
        Me.ErrCard.ResumeLayout(False)
        Me.ErrCard.PerformLayout()
        Me.release.ResumeLayout(False)
        Me.release.PerformLayout()
        Me.UpdPane.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GMODCard.ResumeLayout(False)
        Me.GMODCard.PerformLayout()
        Me.RustCard.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.whatsnew.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoundEdge As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents HeaderPane As Panel
    Friend WithEvents MiniLink As LinkLabel
    Friend WithEvents XLink As LinkLabel
    Friend WithEvents DragProperty As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Logo As PictureBox
    Friend WithEvents DragProperty2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GameInfoLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ErrCard As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents ErrDes As RichTextBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PROCESSCHK As Timer
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents release As Panel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents GMODPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GMODCard As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RustCard As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RustPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents LinkLabel14 As LinkLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LinkLabel15 As LinkLabel
    Friend WithEvents LinkLabel16 As LinkLabel
    Friend WithEvents LinkLabel17 As LinkLabel
    Friend WithEvents infolabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents RustMP As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LinkLabel18 As LinkLabel
    Friend WithEvents UpdateCheck As System.ComponentModel.BackgroundWorker
    Friend WithEvents UpdPane As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents whatsnew As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox13 As PictureBox
End Class
