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
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SD", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMP", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node15")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fisika", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node16")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node17")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node18")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Matematika", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SMA", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode26})
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.AccountToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(769, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem, Me.Test2ToolStripMenuItem, Me.Test3ToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'Test1ToolStripMenuItem
        '
        Me.Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Me.Test1ToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.Test1ToolStripMenuItem.Text = "test1"
        '
        'Test2ToolStripMenuItem
        '
        Me.Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Me.Test2ToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.Test2ToolStripMenuItem.Text = "test2"
        '
        'Test3ToolStripMenuItem
        '
        Me.Test3ToolStripMenuItem.Name = "Test3ToolStripMenuItem"
        Me.Test3ToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.Test3ToolStripMenuItem.Text = "test3"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
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
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "Node2"
        TreeNode6.Name = "Node3"
        TreeNode6.Text = "Node3"
        TreeNode7.Name = "Node9"
        TreeNode7.Text = "Node9"
        TreeNode8.Name = "math_sd"
        TreeNode8.Text = "Matematika"
        TreeNode9.Name = "sd"
        TreeNode9.Text = "SD"
        TreeNode10.Name = "Node7"
        TreeNode10.Text = "Node7"
        TreeNode11.Name = "Node8"
        TreeNode11.Text = "Node8"
        TreeNode12.Name = "Node9"
        TreeNode12.Text = "Node9"
        TreeNode13.Name = "phys_smp"
        TreeNode13.Text = "Fisika"
        TreeNode14.Name = "Node10"
        TreeNode14.Text = "Node10"
        TreeNode15.Name = "Node11"
        TreeNode15.Text = "Node11"
        TreeNode16.Name = "Node12"
        TreeNode16.Text = "Node12"
        TreeNode17.Name = "math_smp"
        TreeNode17.Text = "Matematika"
        TreeNode18.Name = "smp"
        TreeNode18.Text = "SMP"
        TreeNode19.Name = "Node13"
        TreeNode19.Text = "Node13"
        TreeNode20.Name = "Node14"
        TreeNode20.Text = "Node14"
        TreeNode21.Name = "Node15"
        TreeNode21.Text = "Node15"
        TreeNode22.Name = "phys_sma"
        TreeNode22.Text = "Fisika"
        TreeNode23.Name = "Node16"
        TreeNode23.Text = "Node16"
        TreeNode24.Name = "Node17"
        TreeNode24.Text = "Node17"
        TreeNode25.Name = "Node18"
        TreeNode25.Text = "Node18"
        TreeNode26.Name = "phys_sma"
        TreeNode26.Text = "Matematika"
        TreeNode27.Name = "sma"
        TreeNode27.Text = "SMA"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode18, TreeNode27})
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
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Test1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Test3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
