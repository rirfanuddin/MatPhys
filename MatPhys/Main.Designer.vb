<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
<<<<<<< HEAD
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bangun Ruang")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satuan Ukuran")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SD", New System.Windows.Forms.TreeNode() {TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode32, TreeNode33})
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMP", New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode40, TreeNode41, TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMA", New System.Windows.Forms.TreeNode() {TreeNode39, TreeNode43})
=======
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bangun Ruang")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Panjang")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Luas")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Berat")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Volume")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satuan Ukuran", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SD", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Besaran dan Pengukuran")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Unsur Senyawa dan Campuran")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bilangan Pecahan")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Aljabar")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMP", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gerak Lurus")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Termodinamika")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sistem Persamaan Linier")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dimensi Tiga")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMA", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode21})
>>>>>>> c1f92ea8cbf59429cf00fc7c6c369f2a7af30662
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.rumusSdBangunRuang = New System.Windows.Forms.GroupBox()
        Me.ButtonHitBalok = New System.Windows.Forms.Button()
        Me.ButtonHitKubus = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxHasilVBalok = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxHasilLPBalok = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxInputTBalok = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxInputLBalok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxInputPBalok = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxHasilVKubus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxHasilLPKubus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxInputSisiKubus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
<<<<<<< HEAD
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBoxInputAPSegitiga = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxInputTPSegitiga = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButtonHitPrisma = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxHasilVPrisma = New System.Windows.Forms.TextBox()
        Me.TextBoxInputTPrisma = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rumusS = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
=======
>>>>>>> c1f92ea8cbf59429cf00fc7c6c369f2a7af30662
        Me.MenuStrip1.SuspendLayout()
        Me.rumusSdBangunRuang.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rumusS.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserDetailsToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'UserDetailsToolStripMenuItem
        '
        Me.UserDetailsToolStripMenuItem.Name = "UserDetailsToolStripMenuItem"
        Me.UserDetailsToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UserDetailsToolStripMenuItem.Text = "User Details"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 27)
        Me.TreeView1.Name = "TreeView1"
<<<<<<< HEAD
        TreeNode23.Name = "bangun_ruang"
        TreeNode23.Text = "Bangun Ruang"
        TreeNode24.Name = "satuan_ukuran"
        TreeNode24.Text = "Satuan Ukuran"
        TreeNode25.Name = "math_sd"
        TreeNode25.Text = "Matematika"
        TreeNode26.Name = "sd_root"
        TreeNode26.Text = "SD"
        TreeNode27.Name = "Node7"
        TreeNode27.Text = "Node7"
        TreeNode28.Name = "Node8"
        TreeNode28.Text = "Node8"
        TreeNode29.Name = "Node9"
        TreeNode29.Text = "Node9"
        TreeNode30.Name = "phys_smp"
        TreeNode30.Text = "Fisika"
        TreeNode31.Name = "Node10"
        TreeNode31.Text = "Node10"
        TreeNode32.Name = "Node11"
        TreeNode32.Text = "Node11"
        TreeNode33.Name = "Node12"
        TreeNode33.Text = "Node12"
        TreeNode34.Name = "math_smp"
        TreeNode34.Text = "Matematika"
        TreeNode35.Name = "smp_root"
        TreeNode35.Text = "SMP"
        TreeNode36.Name = "Node13"
        TreeNode36.Text = "Node13"
        TreeNode37.Name = "Node14"
        TreeNode37.Text = "Node14"
        TreeNode38.Name = "Node15"
        TreeNode38.Text = "Node15"
        TreeNode39.Name = "phys_sma"
        TreeNode39.Text = "Fisika"
        TreeNode40.Name = "Node16"
        TreeNode40.Text = "Node16"
        TreeNode41.Name = "Node17"
        TreeNode41.Text = "Node17"
        TreeNode42.Name = "Node18"
        TreeNode42.Text = "Node18"
        TreeNode43.Name = "phys_sma"
        TreeNode43.Text = "Matematika"
        TreeNode44.Name = "sma_root"
        TreeNode44.Text = "SMA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode35, TreeNode44})
=======
        TreeNode1.Name = "bangun_ruang"
        TreeNode1.Text = "Bangun Ruang"
        TreeNode2.Name = "ukuran_panjang"
        TreeNode2.Text = "Ukuran Panjang"
        TreeNode3.Name = "ukuran_luas"
        TreeNode3.Text = "Ukuran Luas"
        TreeNode4.Name = "ukuran_berat"
        TreeNode4.Text = "Ukuran Berat"
        TreeNode5.Name = "ukuran_volume"
        TreeNode5.Text = "Ukuran Volume"
        TreeNode6.Name = "satuan_ukuran"
        TreeNode6.Text = "Satuan Ukuran"
        TreeNode7.Name = "math_sd"
        TreeNode7.Text = "Matematika"
        TreeNode8.Name = "sd_root"
        TreeNode8.Text = "SD"
        TreeNode9.Name = "besaranSMP"
        TreeNode9.Text = "Besaran dan Pengukuran"
        TreeNode10.Name = "senyawaSMP"
        TreeNode10.Text = "Unsur Senyawa dan Campuran"
        TreeNode11.Name = "phys_smp"
        TreeNode11.Text = "Fisika"
        TreeNode12.Name = "pecahanSMP"
        TreeNode12.Text = "Bilangan Pecahan"
        TreeNode13.Name = "aljabarSMP"
        TreeNode13.Text = "Aljabar"
        TreeNode14.Name = "math_smp"
        TreeNode14.Text = "Matematika"
        TreeNode15.Name = "smp_root"
        TreeNode15.Text = "SMP"
        TreeNode16.Name = "glSMA"
        TreeNode16.Text = "Gerak Lurus"
        TreeNode17.Name = "termoSMA"
        TreeNode17.Text = "Termodinamika"
        TreeNode18.Name = "phys_sma"
        TreeNode18.Text = "Fisika"
        TreeNode19.Name = "splSMA"
        TreeNode19.Text = "Sistem Persamaan Linier"
        TreeNode20.Name = "3dSMA"
        TreeNode20.Text = "Dimensi Tiga"
        TreeNode21.Name = "phys_sma"
        TreeNode21.Text = "Matematika"
        TreeNode22.Name = "sma_root"
        TreeNode22.Text = "SMA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode15, TreeNode22})
>>>>>>> c1f92ea8cbf59429cf00fc7c6c369f2a7af30662
        Me.TreeView1.Size = New System.Drawing.Size(169, 349)
        Me.TreeView1.TabIndex = 1
        '
        'rumusSdBangunRuang
        '
        Me.rumusSdBangunRuang.Controls.Add(Me.rumusS)
        Me.rumusSdBangunRuang.Controls.Add(Me.ButtonHitPrisma)
        Me.rumusSdBangunRuang.Controls.Add(Me.ButtonHitBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.ButtonHitKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilVPrisma)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label14)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputTPrisma)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label15)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputTPSegitiga)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label16)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputAPSegitiga)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label17)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox3)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label18)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilVBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label12)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilLPBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label6)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputTBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label8)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputLBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label9)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputPBalok)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label10)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label11)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilVKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label7)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilLPKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label5)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputSisiKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label4)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox1)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label1)
        Me.rumusSdBangunRuang.Location = New System.Drawing.Point(13, 3)
        Me.rumusSdBangunRuang.Name = "rumusSdBangunRuang"
        Me.rumusSdBangunRuang.Size = New System.Drawing.Size(570, 957)
        Me.rumusSdBangunRuang.TabIndex = 3
        Me.rumusSdBangunRuang.TabStop = False
        Me.rumusSdBangunRuang.Text = "Rumus"
        Me.rumusSdBangunRuang.Visible = False
        '
        'ButtonHitBalok
        '
        Me.ButtonHitBalok.Location = New System.Drawing.Point(11, 606)
        Me.ButtonHitBalok.Name = "ButtonHitBalok"
        Me.ButtonHitBalok.Size = New System.Drawing.Size(319, 36)
        Me.ButtonHitBalok.TabIndex = 44
        Me.ButtonHitBalok.Text = "Hitung"
        Me.ButtonHitBalok.UseVisualStyleBackColor = True
        '
        'ButtonHitKubus
        '
        Me.ButtonHitKubus.Location = New System.Drawing.Point(11, 262)
        Me.ButtonHitKubus.Name = "ButtonHitKubus"
        Me.ButtonHitKubus.Size = New System.Drawing.Size(319, 36)
        Me.ButtonHitKubus.TabIndex = 42
        Me.ButtonHitKubus.Text = "Hitung"
        Me.ButtonHitKubus.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 654)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Prisma segitiga"
        '
        'TextBoxHasilVBalok
        '
        Me.TextBoxHasilVBalok.Enabled = False
        Me.TextBoxHasilVBalok.Location = New System.Drawing.Point(11, 578)
        Me.TextBoxHasilVBalok.Name = "TextBoxHasilVBalok"
        Me.TextBoxHasilVBalok.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxHasilVBalok.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 562)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Volume balok"
        '
        'TextBoxHasilLPBalok
        '
        Me.TextBoxHasilLPBalok.Enabled = False
        Me.TextBoxHasilLPBalok.Location = New System.Drawing.Point(11, 537)
        Me.TextBoxHasilLPBalok.Name = "TextBoxHasilLPBalok"
        Me.TextBoxHasilLPBalok.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxHasilLPBalok.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Luas permukaan balok"
        '
        'TextBoxInputTBalok
        '
        Me.TextBoxInputTBalok.Location = New System.Drawing.Point(11, 498)
        Me.TextBoxInputTBalok.Name = "TextBoxInputTBalok"
        Me.TextBoxInputTBalok.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputTBalok.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Masukkan tinggi balok"
        '
        'TextBoxInputLBalok
        '
        Me.TextBoxInputLBalok.Location = New System.Drawing.Point(11, 459)
        Me.TextBoxInputLBalok.Name = "TextBoxInputLBalok"
        Me.TextBoxInputLBalok.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputLBalok.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Masukkan lebar balok"
        '
        'TextBoxInputPBalok
        '
        Me.TextBoxInputPBalok.Location = New System.Drawing.Point(11, 420)
        Me.TextBoxInputPBalok.Name = "TextBoxInputPBalok"
        Me.TextBoxInputPBalok.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputPBalok.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Masukkan panjang balok"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(11, 339)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(319, 62)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 312)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Balok"
        '
        'TextBoxHasilVKubus
        '
        Me.TextBoxHasilVKubus.Enabled = False
        Me.TextBoxHasilVKubus.Location = New System.Drawing.Point(11, 236)
        Me.TextBoxHasilVKubus.Name = "TextBoxHasilVKubus"
        Me.TextBoxHasilVKubus.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxHasilVKubus.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Volume kubus"
        '
        'TextBoxHasilLPKubus
        '
        Me.TextBoxHasilLPKubus.Enabled = False
        Me.TextBoxHasilLPKubus.Location = New System.Drawing.Point(11, 197)
        Me.TextBoxHasilLPKubus.Name = "TextBoxHasilLPKubus"
        Me.TextBoxHasilLPKubus.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxHasilLPKubus.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Luas permukaan kubus"
        '
        'TextBoxInputSisiKubus
        '
        Me.TextBoxInputSisiKubus.Location = New System.Drawing.Point(11, 158)
        Me.TextBoxInputSisiKubus.Name = "TextBoxInputSisiKubus"
        Me.TextBoxInputSisiKubus.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputSisiKubus.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Masukkan panjang sisi kubus"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(11, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 62)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kubus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bangun Ruang"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.rumusSdBangunRuang)
        Me.Panel1.Location = New System.Drawing.Point(187, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 349)
        Me.Panel1.TabIndex = 4
        '
<<<<<<< HEAD
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 746)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Masukkan alas segitiga"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(11, 681)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(319, 65)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'TextBoxInputAPSegitiga
        '
        Me.TextBoxInputAPSegitiga.Location = New System.Drawing.Point(11, 762)
        Me.TextBoxInputAPSegitiga.Name = "TextBoxInputAPSegitiga"
        Me.TextBoxInputAPSegitiga.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputAPSegitiga.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 785)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(124, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Masukkan tinggi segitiga"
        '
        'TextBoxInputTPSegitiga
        '
        Me.TextBoxInputTPSegitiga.Location = New System.Drawing.Point(11, 801)
        Me.TextBoxInputTPSegitiga.Name = "TextBoxInputTPSegitiga"
        Me.TextBoxInputTPSegitiga.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputTPSegitiga.TabIndex = 37
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 824)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Masukkan tinggi prisma"
        '
        'ButtonHitPrisma
        '
        Me.ButtonHitPrisma.Location = New System.Drawing.Point(11, 906)
        Me.ButtonHitPrisma.Name = "ButtonHitPrisma"
        Me.ButtonHitPrisma.Size = New System.Drawing.Size(319, 36)
        Me.ButtonHitPrisma.TabIndex = 45
        Me.ButtonHitPrisma.Text = "Hitung"
        Me.ButtonHitPrisma.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 863)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Volume Prisma"
        '
        'TextBoxHasilVPrisma
        '
        Me.TextBoxHasilVPrisma.Enabled = False
        Me.TextBoxHasilVPrisma.Location = New System.Drawing.Point(11, 879)
        Me.TextBoxHasilVPrisma.Name = "TextBoxHasilVPrisma"
        Me.TextBoxHasilVPrisma.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxHasilVPrisma.TabIndex = 41
        '
        'TextBoxInputTPrisma
        '
        Me.TextBoxInputTPrisma.Location = New System.Drawing.Point(11, 840)
        Me.TextBoxInputTPrisma.Name = "TextBoxInputTPrisma"
        Me.TextBoxInputTPrisma.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputTPrisma.TabIndex = 39
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(155, 25)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Satuan Ukuran"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(11, 44)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(319, 95)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 142)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(147, 13)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Masukkan panjang sisi kubus"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(11, 158)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(319, 20)
        Me.TextBox12.TabIndex = 7
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 181)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(118, 13)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Luas permukaan kubus"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(11, 197)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(319, 20)
        Me.TextBox11.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 220)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Volume kubus"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(11, 236)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(319, 20)
        Me.TextBox10.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 521)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(115, 13)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Luas permukaan balok"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(11, 537)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(319, 20)
        Me.TextBox6.TabIndex = 27
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 562)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 28
        Me.Label22.Text = "Volume balok"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(11, 578)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(319, 20)
        Me.TextBox5.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 262)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(319, 36)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Hitung"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(11, 606)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(319, 36)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Hitung"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rumusS
        '
        Me.rumusS.Controls.Add(Me.Button2)
        Me.rumusS.Controls.Add(Me.Button3)
        Me.rumusS.Controls.Add(Me.TextBox5)
        Me.rumusS.Controls.Add(Me.Label22)
        Me.rumusS.Controls.Add(Me.TextBox6)
        Me.rumusS.Controls.Add(Me.Label23)
        Me.rumusS.Controls.Add(Me.TextBox7)
        Me.rumusS.Controls.Add(Me.Label24)
        Me.rumusS.Controls.Add(Me.TextBox8)
        Me.rumusS.Controls.Add(Me.Label25)
        Me.rumusS.Controls.Add(Me.TextBox9)
        Me.rumusS.Controls.Add(Me.Label26)
        Me.rumusS.Controls.Add(Me.PictureBox5)
        Me.rumusS.Controls.Add(Me.Label27)
        Me.rumusS.Controls.Add(Me.TextBox10)
        Me.rumusS.Controls.Add(Me.Label28)
        Me.rumusS.Controls.Add(Me.TextBox11)
        Me.rumusS.Controls.Add(Me.Label29)
        Me.rumusS.Controls.Add(Me.TextBox12)
        Me.rumusS.Controls.Add(Me.Label30)
        Me.rumusS.Controls.Add(Me.PictureBox6)
        Me.rumusS.Controls.Add(Me.Label32)
        Me.rumusS.Location = New System.Drawing.Point(32, 31)
        Me.rumusS.Name = "rumusS"
        Me.rumusS.Size = New System.Drawing.Size(570, 804)
        Me.rumusS.TabIndex = 46
        Me.rumusS.TabStop = False
        Me.rumusS.Text = "Rumus"
        Me.rumusS.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(11, 498)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(319, 20)
        Me.TextBox7.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 482)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(114, 13)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Masukkan tinggi balok"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(11, 459)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(319, 20)
        Me.TextBox8.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 443)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 13)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Masukkan lebar balok"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(11, 420)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(319, 20)
        Me.TextBox9.TabIndex = 21
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 404)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(127, 13)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "Masukkan panjang balok"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(7, 312)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 24)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Balok"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(11, 339)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(319, 62)
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
=======
>>>>>>> c1f92ea8cbf59429cf00fc7c6c369f2a7af30662
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 391)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "MatPhys"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.rumusSdBangunRuang.ResumeLayout(False)
        Me.rumusSdBangunRuang.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rumusS.ResumeLayout(False)
        Me.rumusS.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rumusSdBangunRuang As System.Windows.Forms.GroupBox
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxHasilVKubus As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxHasilLPKubus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxInputSisiKubus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxHasilVBalok As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxHasilLPBalok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxInputTBalok As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxInputLBalok As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxInputPBalok As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents UserDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonHitKubus As Button
    Friend WithEvents ButtonHitBalok As Button
    Friend WithEvents ButtonHitPrisma As Button
    Friend WithEvents TextBoxHasilVPrisma As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxInputTPrisma As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxInputTPSegitiga As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxInputAPSegitiga As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents rumusS As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label32 As Label
End Class
