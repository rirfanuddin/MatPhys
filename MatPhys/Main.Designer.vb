<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bangun Ruang")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Panjang")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Luas")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Berat")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Volume")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satuan Ukuran", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SD", New System.Windows.Forms.TreeNode() {TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMP", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMA", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode25})
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.rumusSdBangunRuang = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.rumusSdBangunRuang.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.AccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
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
        TreeNode9.Name = "Node7"
        TreeNode9.Text = "Node7"
        TreeNode10.Name = "Node8"
        TreeNode10.Text = "Node8"
        TreeNode11.Name = "Node9"
        TreeNode11.Text = "Node9"
        TreeNode12.Name = "phys_smp"
        TreeNode12.Text = "Fisika"
        TreeNode13.Name = "Node10"
        TreeNode13.Text = "Node10"
        TreeNode14.Name = "Node11"
        TreeNode14.Text = "Node11"
        TreeNode15.Name = "Node12"
        TreeNode15.Text = "Node12"
        TreeNode16.Name = "math_smp"
        TreeNode16.Text = "Matematika"
        TreeNode17.Name = "smp_root"
        TreeNode17.Text = "SMP"
        TreeNode18.Name = "Node13"
        TreeNode18.Text = "Node13"
        TreeNode19.Name = "Node14"
        TreeNode19.Text = "Node14"
        TreeNode20.Name = "Node15"
        TreeNode20.Text = "Node15"
        TreeNode21.Name = "phys_sma"
        TreeNode21.Text = "Fisika"
        TreeNode22.Name = "Node16"
        TreeNode22.Text = "Node16"
        TreeNode23.Name = "Node17"
        TreeNode23.Text = "Node17"
        TreeNode24.Name = "Node18"
        TreeNode24.Text = "Node18"
        TreeNode25.Name = "phys_sma"
        TreeNode25.Text = "Matematika"
        TreeNode26.Name = "sma_root"
        TreeNode26.Text = "SMA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode17, TreeNode26})
        Me.TreeView1.Size = New System.Drawing.Size(169, 349)
        Me.TreeView1.TabIndex = 1
        '
        'rumusSdBangunRuang
        '
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox11)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label14)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox12)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label15)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox13)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label16)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox14)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label17)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox3)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label18)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox10)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label13)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox9)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label12)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox5)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label6)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox6)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label8)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox7)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label9)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox8)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label10)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label11)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox4)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label3)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox3)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label7)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label5)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox1)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label4)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox1)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label1)
        Me.rumusSdBangunRuang.Location = New System.Drawing.Point(13, 3)
        Me.rumusSdBangunRuang.Name = "rumusSdBangunRuang"
        Me.rumusSdBangunRuang.Size = New System.Drawing.Size(570, 950)
        Me.rumusSdBangunRuang.TabIndex = 3
        Me.rumusSdBangunRuang.TabStop = False
        Me.rumusSdBangunRuang.Text = "Rumus"
        Me.rumusSdBangunRuang.Visible = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(11, 870)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(319, 20)
        Me.TextBox11.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 854)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Luas pemukaan balok"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(11, 831)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(319, 20)
        Me.TextBox12.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 815)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Masukkan tinggi balok"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(11, 792)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(319, 20)
        Me.TextBox13.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 776)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Masukkan lebar balok"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(11, 753)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(319, 20)
        Me.TextBox14.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 737)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Masukkan panjang balok"
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(11, 672)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(319, 65)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 645)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 24)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Prisma segitiga"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(11, 613)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(319, 20)
        Me.TextBox10.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 597)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Diagonal ruang balok"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(11, 573)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(319, 20)
        Me.TextBox9.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 557)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Volume balok"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(11, 532)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(319, 20)
        Me.TextBox5.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Luas pemukaan balok"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(11, 493)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(319, 20)
        Me.TextBox6.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 477)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Masukkan tinggi balok"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(11, 454)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(319, 20)
        Me.TextBox7.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 438)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Masukkan lebar balok"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(11, 415)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(319, 20)
        Me.TextBox8.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Masukkan panjang balok"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(11, 334)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(319, 62)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Balok"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 275)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(319, 20)
        Me.TextBox4.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Diagonal sisi kubus"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 236)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(319, 20)
        Me.TextBox3.TabIndex = 15
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 197)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(319, 20)
        Me.TextBox2.TabIndex = 9
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 158)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(319, 20)
        Me.TextBox1.TabIndex = 7
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label18 As Label
End Class
