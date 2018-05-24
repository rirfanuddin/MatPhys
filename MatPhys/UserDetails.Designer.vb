<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetails
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
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.alamat_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.sekolah_txtbox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'username_txtbox
        '
        Me.username_txtbox.Enabled = False
        Me.username_txtbox.Location = New System.Drawing.Point(15, 35)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.username_txtbox.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'alamat_txtbox
        '
        Me.alamat_txtbox.Location = New System.Drawing.Point(16, 86)
        Me.alamat_txtbox.Name = "alamat_txtbox"
        Me.alamat_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.alamat_txtbox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Alamat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(68, 187)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(94, 23)
        Me.save_btn.TabIndex = 23
        Me.save_btn.Text = "Save"
        '
        'sekolah_txtbox
        '
        Me.sekolah_txtbox.Location = New System.Drawing.Point(14, 135)
        Me.sekolah_txtbox.Name = "sekolah_txtbox"
        Me.sekolah_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.sekolah_txtbox.TabIndex = 22
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 109)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 21
        Me.UsernameLabel.Text = "Sekolah"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 230)
        Me.Controls.Add(Me.username_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.alamat_txtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.sekolah_txtbox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "UserDetails"
        Me.Text = "UserDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents alamat_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents sekolah_txtbox As TextBox
    Friend WithEvents UsernameLabel As Label
End Class
