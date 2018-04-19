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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Kubus")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Balok")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prisma")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Limas")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tabung")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bola")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bangun Ruang", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Panjang")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Luas")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Berat")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ukuran Volume")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Satuan Ukuran", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SD", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMP", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34})
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMA", New System.Windows.Forms.TreeNode() {TreeNode31, TreeNode35})
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(769, 24)
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
        TreeNode1.Name = "Node6"
        TreeNode1.Text = "Node6"
        TreeNode2.Name = "Node7"
        TreeNode2.Text = "Node7"
        TreeNode3.Name = "Node8"
        TreeNode3.Text = "Node8"
        TreeNode4.Name = "phys_sd"
        TreeNode4.Text = "Fisika"
        TreeNode5.Name = "kubus"
        TreeNode5.Text = "Kubus"
        TreeNode6.Name = "balok"
        TreeNode6.Text = "Balok"
        TreeNode7.Name = "prisma"
        TreeNode7.Text = "Prisma"
        TreeNode8.Name = "limas"
        TreeNode8.Text = "Limas"
        TreeNode9.Name = "tabung"
        TreeNode9.Text = "Tabung"
        TreeNode10.Name = "bola"
        TreeNode10.Text = "Bola"
        TreeNode11.Name = "bangun_ruang"
        TreeNode11.Text = "Bangun Ruang"
        TreeNode12.Name = "ukuran_panjang"
        TreeNode12.Text = "Ukuran Panjang"
        TreeNode13.Name = "ukuran_luas"
        TreeNode13.Text = "Ukuran Luas"
        TreeNode14.Name = "ukuran_berat"
        TreeNode14.Text = "Ukuran Berat"
        TreeNode15.Name = "ukuran_volume"
        TreeNode15.Text = "Ukuran Volume"
        TreeNode16.Name = "satuan_ukuran"
        TreeNode16.Text = "Satuan Ukuran"
        TreeNode17.Name = "math_sd"
        TreeNode17.Text = "Matematika"
        TreeNode18.Name = "sd_root"
        TreeNode18.Text = "SD"
        TreeNode19.Name = "Node7"
        TreeNode19.Text = "Node7"
        TreeNode20.Name = "Node8"
        TreeNode20.Text = "Node8"
        TreeNode21.Name = "Node9"
        TreeNode21.Text = "Node9"
        TreeNode22.Name = "phys_smp"
        TreeNode22.Text = "Fisika"
        TreeNode23.Name = "Node10"
        TreeNode23.Text = "Node10"
        TreeNode24.Name = "Node11"
        TreeNode24.Text = "Node11"
        TreeNode25.Name = "Node12"
        TreeNode25.Text = "Node12"
        TreeNode26.Name = "math_smp"
        TreeNode26.Text = "Matematika"
        TreeNode27.Name = "smp_root"
        TreeNode27.Text = "SMP"
        TreeNode28.Name = "Node13"
        TreeNode28.Text = "Node13"
        TreeNode29.Name = "Node14"
        TreeNode29.Text = "Node14"
        TreeNode30.Name = "Node15"
        TreeNode30.Text = "Node15"
        TreeNode31.Name = "phys_sma"
        TreeNode31.Text = "Fisika"
        TreeNode32.Name = "Node16"
        TreeNode32.Text = "Node16"
        TreeNode33.Name = "Node17"
        TreeNode33.Text = "Node17"
        TreeNode34.Name = "Node18"
        TreeNode34.Text = "Node18"
        TreeNode35.Name = "phys_sma"
        TreeNode35.Text = "Matematika"
        TreeNode36.Name = "sma_root"
        TreeNode36.Text = "SMA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode27, TreeNode36})
        Me.TreeView1.Size = New System.Drawing.Size(169, 349)
        Me.TreeView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(552, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 349)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keterangan"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(187, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 349)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rumus"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 388)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "MatPhys"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
