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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxHasilLPKubus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxInputLPKubus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnHitLPKubus = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.rumusSdBangunRuang.SuspendLayout()
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
        Me.rumusSdBangunRuang.Controls.Add(Me.BtnHitLPKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox3)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label7)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBox4)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label8)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label6)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxHasilLPKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label5)
        Me.rumusSdBangunRuang.Controls.Add(Me.TextBoxInputLPKubus)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label4)
        Me.rumusSdBangunRuang.Controls.Add(Me.PictureBox1)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label3)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label2)
        Me.rumusSdBangunRuang.Controls.Add(Me.Label1)
        Me.rumusSdBangunRuang.Location = New System.Drawing.Point(13, 3)
        Me.rumusSdBangunRuang.Name = "rumusSdBangunRuang"
        Me.rumusSdBangunRuang.Size = New System.Drawing.Size(570, 551)
        Me.rumusSdBangunRuang.TabIndex = 3
        Me.rumusSdBangunRuang.TabStop = False
        Me.rumusSdBangunRuang.Text = "Rumus"
        Me.rumusSdBangunRuang.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(11, 421)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(319, 20)
        Me.TextBox3.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Volume kubus"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 382)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(319, 20)
        Me.TextBox4.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 366)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Masukkan panjang sisi kubus"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(11, 320)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(319, 43)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Menghitung Volume Kubus"
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
        'TextBoxInputLPKubus
        '
        Me.TextBoxInputLPKubus.Location = New System.Drawing.Point(11, 158)
        Me.TextBoxInputLPKubus.Name = "TextBoxInputLPKubus"
        Me.TextBoxInputLPKubus.Size = New System.Drawing.Size(319, 20)
        Me.TextBoxInputLPKubus.TabIndex = 7
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
        Me.PictureBox1.Location = New System.Drawing.Point(11, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 43)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Menghitung Luas Permukaan Kubus"
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
        'BtnHitLPKubus
        '
        Me.BtnHitLPKubus.Location = New System.Drawing.Point(11, 236)
        Me.BtnHitLPKubus.Name = "BtnHitLPKubus"
        Me.BtnHitLPKubus.Size = New System.Drawing.Size(319, 45)
        Me.BtnHitLPKubus.TabIndex = 16
        Me.BtnHitLPKubus.Text = "Hitung"
        Me.BtnHitLPKubus.UseVisualStyleBackColor = True
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
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxHasilLPKubus As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxInputLPKubus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnHitLPKubus As Button
End Class
