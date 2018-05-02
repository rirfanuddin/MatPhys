<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDash
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.sd_stats = New System.Windows.Forms.TabPage()
        Me.smp_stats = New System.Windows.Forms.TabPage()
        Me.sma_stats = New System.Windows.Forms.TabPage()
        Me.general_stats = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.general_stats)
        Me.TabControl1.Controls.Add(Me.sd_stats)
        Me.TabControl1.Controls.Add(Me.smp_stats)
        Me.TabControl1.Controls.Add(Me.sma_stats)
        Me.TabControl1.Location = New System.Drawing.Point(13, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 410)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 2
        '
        'sd_stats
        '
        Me.sd_stats.Location = New System.Drawing.Point(4, 22)
        Me.sd_stats.Name = "sd_stats"
        Me.sd_stats.Padding = New System.Windows.Forms.Padding(3)
        Me.sd_stats.Size = New System.Drawing.Size(767, 384)
        Me.sd_stats.TabIndex = 0
        Me.sd_stats.Text = "Statistik - SD"
        Me.sd_stats.UseVisualStyleBackColor = True
        '
        'smp_stats
        '
        Me.smp_stats.Location = New System.Drawing.Point(4, 22)
        Me.smp_stats.Name = "smp_stats"
        Me.smp_stats.Padding = New System.Windows.Forms.Padding(3)
        Me.smp_stats.Size = New System.Drawing.Size(767, 384)
        Me.smp_stats.TabIndex = 1
        Me.smp_stats.Text = "Statistik - SMP"
        Me.smp_stats.UseVisualStyleBackColor = True
        '
        'sma_stats
        '
        Me.sma_stats.Location = New System.Drawing.Point(4, 22)
        Me.sma_stats.Name = "sma_stats"
        Me.sma_stats.Size = New System.Drawing.Size(767, 384)
        Me.sma_stats.TabIndex = 2
        Me.sma_stats.Text = "Statistik - SMA"
        Me.sma_stats.UseVisualStyleBackColor = True
        '
        'general_stats
        '
        Me.general_stats.Location = New System.Drawing.Point(4, 22)
        Me.general_stats.Name = "general_stats"
        Me.general_stats.Size = New System.Drawing.Size(767, 384)
        Me.general_stats.TabIndex = 3
        Me.general_stats.Text = "Statistik Umum"
        Me.general_stats.UseVisualStyleBackColor = True
        '
        'AdminDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDash"
        Me.Text = "AdminDash"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents sd_stats As TabPage
    Friend WithEvents smp_stats As TabPage
    Friend WithEvents sma_stats As TabPage
    Friend WithEvents general_stats As TabPage
End Class
