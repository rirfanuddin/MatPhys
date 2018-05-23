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
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.general_stats = New System.Windows.Forms.TabPage()
        Me.dtg_umum = New System.Windows.Forms.DataGridView()
        Me.txt_umum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sd_stats = New System.Windows.Forms.TabPage()
        Me.dtg_sd = New System.Windows.Forms.DataGridView()
        Me.txt_sd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.smp_stats = New System.Windows.Forms.TabPage()
        Me.dtg_smp = New System.Windows.Forms.DataGridView()
        Me.txt_smp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sma_stats = New System.Windows.Forms.TabPage()
        Me.dtg_sma = New System.Windows.Forms.DataGridView()
        Me.txt_sma = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.general_stats.SuspendLayout()
        CType(Me.dtg_umum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sd_stats.SuspendLayout()
        CType(Me.dtg_sd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.smp_stats.SuspendLayout()
        CType(Me.dtg_smp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sma_stats.SuspendLayout()
        CType(Me.dtg_sma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.general_stats)
        Me.TabControl1.Controls.Add(Me.sd_stats)
        Me.TabControl1.Controls.Add(Me.smp_stats)
        Me.TabControl1.Controls.Add(Me.sma_stats)
        Me.TabControl1.Location = New System.Drawing.Point(13, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 335)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 2
        '
        'general_stats
        '
        Me.general_stats.Controls.Add(Me.dtg_umum)
        Me.general_stats.Controls.Add(Me.txt_umum)
        Me.general_stats.Controls.Add(Me.Label2)
        Me.general_stats.Location = New System.Drawing.Point(4, 22)
        Me.general_stats.Name = "general_stats"
        Me.general_stats.Size = New System.Drawing.Size(423, 309)
        Me.general_stats.TabIndex = 3
        Me.general_stats.Text = "Statistik Umum"
        Me.general_stats.UseVisualStyleBackColor = True
        '
        'dtg_umum
        '
        Me.dtg_umum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_umum.Location = New System.Drawing.Point(25, 62)
        Me.dtg_umum.Name = "dtg_umum"
        Me.dtg_umum.Size = New System.Drawing.Size(375, 231)
        Me.dtg_umum.TabIndex = 6
        '
        'txt_umum
        '
        Me.txt_umum.Enabled = False
        Me.txt_umum.Location = New System.Drawing.Point(115, 15)
        Me.txt_umum.Name = "txt_umum"
        Me.txt_umum.Size = New System.Drawing.Size(63, 20)
        Me.txt_umum.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Siswa Terdaftar: "
        '
        'sd_stats
        '
        Me.sd_stats.Controls.Add(Me.dtg_sd)
        Me.sd_stats.Controls.Add(Me.txt_sd)
        Me.sd_stats.Controls.Add(Me.Label1)
        Me.sd_stats.Location = New System.Drawing.Point(4, 22)
        Me.sd_stats.Name = "sd_stats"
        Me.sd_stats.Padding = New System.Windows.Forms.Padding(3)
        Me.sd_stats.Size = New System.Drawing.Size(423, 309)
        Me.sd_stats.TabIndex = 0
        Me.sd_stats.Text = "Statistik - SD"
        Me.sd_stats.UseVisualStyleBackColor = True
        '
        'dtg_sd
        '
        Me.dtg_sd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_sd.Location = New System.Drawing.Point(24, 72)
        Me.dtg_sd.Name = "dtg_sd"
        Me.dtg_sd.Size = New System.Drawing.Size(375, 231)
        Me.dtg_sd.TabIndex = 3
        '
        'txt_sd
        '
        Me.txt_sd.Enabled = False
        Me.txt_sd.Location = New System.Drawing.Point(114, 25)
        Me.txt_sd.Name = "txt_sd"
        Me.txt_sd.Size = New System.Drawing.Size(68, 20)
        Me.txt_sd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Siswa Terdaftar: "
        '
        'smp_stats
        '
        Me.smp_stats.Controls.Add(Me.dtg_smp)
        Me.smp_stats.Controls.Add(Me.txt_smp)
        Me.smp_stats.Controls.Add(Me.Label3)
        Me.smp_stats.Location = New System.Drawing.Point(4, 22)
        Me.smp_stats.Name = "smp_stats"
        Me.smp_stats.Padding = New System.Windows.Forms.Padding(3)
        Me.smp_stats.Size = New System.Drawing.Size(423, 309)
        Me.smp_stats.TabIndex = 1
        Me.smp_stats.Text = "Statistik - SMP"
        Me.smp_stats.UseVisualStyleBackColor = True
        '
        'dtg_smp
        '
        Me.dtg_smp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_smp.Location = New System.Drawing.Point(25, 62)
        Me.dtg_smp.Name = "dtg_smp"
        Me.dtg_smp.Size = New System.Drawing.Size(371, 231)
        Me.dtg_smp.TabIndex = 6
        '
        'txt_smp
        '
        Me.txt_smp.Enabled = False
        Me.txt_smp.Location = New System.Drawing.Point(115, 15)
        Me.txt_smp.Name = "txt_smp"
        Me.txt_smp.Size = New System.Drawing.Size(68, 20)
        Me.txt_smp.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Siswa Terdaftar: "
        '
        'sma_stats
        '
        Me.sma_stats.Controls.Add(Me.dtg_sma)
        Me.sma_stats.Controls.Add(Me.txt_sma)
        Me.sma_stats.Controls.Add(Me.Label4)
        Me.sma_stats.Location = New System.Drawing.Point(4, 22)
        Me.sma_stats.Name = "sma_stats"
        Me.sma_stats.Size = New System.Drawing.Size(423, 309)
        Me.sma_stats.TabIndex = 2
        Me.sma_stats.Text = "Statistik - SMA"
        Me.sma_stats.UseVisualStyleBackColor = True
        '
        'dtg_sma
        '
        Me.dtg_sma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_sma.Location = New System.Drawing.Point(25, 62)
        Me.dtg_sma.Name = "dtg_sma"
        Me.dtg_sma.Size = New System.Drawing.Size(375, 231)
        Me.dtg_sma.TabIndex = 6
        '
        'txt_sma
        '
        Me.txt_sma.Enabled = False
        Me.txt_sma.Location = New System.Drawing.Point(115, 15)
        Me.txt_sma.Name = "txt_sma"
        Me.txt_sma.Size = New System.Drawing.Size(68, 20)
        Me.txt_sma.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Siswa Terdaftar: "
        '
        'AdminDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 375)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDash"
        Me.Text = "AdminDash"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.general_stats.ResumeLayout(False)
        Me.general_stats.PerformLayout()
        CType(Me.dtg_umum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sd_stats.ResumeLayout(False)
        Me.sd_stats.PerformLayout()
        CType(Me.dtg_sd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.smp_stats.ResumeLayout(False)
        Me.smp_stats.PerformLayout()
        CType(Me.dtg_smp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sma_stats.ResumeLayout(False)
        Me.sma_stats.PerformLayout()
        CType(Me.dtg_sma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents sd_stats As TabPage
    Friend WithEvents smp_stats As TabPage
    Friend WithEvents sma_stats As TabPage
    Friend WithEvents general_stats As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents dtg_umum As DataGridView
    Friend WithEvents txt_umum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtg_sd As DataGridView
    Friend WithEvents txt_sd As TextBox
    Friend WithEvents dtg_smp As DataGridView
    Friend WithEvents txt_smp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtg_sma As DataGridView
    Friend WithEvents txt_sma As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class
