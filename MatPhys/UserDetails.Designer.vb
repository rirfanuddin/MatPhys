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
        Me.sma_radio = New System.Windows.Forms.RadioButton()
        Me.smp_radio = New System.Windows.Forms.RadioButton()
        Me.sd_radio = New System.Windows.Forms.RadioButton()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.nama_txtbox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sma_radio
        '
        Me.sma_radio.AutoSize = True
        Me.sma_radio.Location = New System.Drawing.Point(174, 224)
        Me.sma_radio.Name = "sma_radio"
        Me.sma_radio.Size = New System.Drawing.Size(48, 17)
        Me.sma_radio.TabIndex = 32
        Me.sma_radio.TabStop = True
        Me.sma_radio.Text = "SMA"
        Me.sma_radio.UseVisualStyleBackColor = True
        '
        'smp_radio
        '
        Me.smp_radio.AutoSize = True
        Me.smp_radio.Location = New System.Drawing.Point(93, 224)
        Me.smp_radio.Name = "smp_radio"
        Me.smp_radio.Size = New System.Drawing.Size(48, 17)
        Me.smp_radio.TabIndex = 31
        Me.smp_radio.TabStop = True
        Me.smp_radio.Text = "SMP"
        Me.smp_radio.UseVisualStyleBackColor = True
        '
        'sd_radio
        '
        Me.sd_radio.AutoSize = True
        Me.sd_radio.Location = New System.Drawing.Point(20, 224)
        Me.sd_radio.Name = "sd_radio"
        Me.sd_radio.Size = New System.Drawing.Size(40, 17)
        Me.sd_radio.TabIndex = 30
        Me.sd_radio.TabStop = True
        Me.sd_radio.Text = "SD"
        Me.sd_radio.UseVisualStyleBackColor = True
        '
        'password_txtbox
        '
        Me.password_txtbox.Location = New System.Drawing.Point(14, 182)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.password_txtbox.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'username_txtbox
        '
        Me.username_txtbox.Location = New System.Drawing.Point(13, 133)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.username_txtbox.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'email_txtbox
        '
        Me.email_txtbox.Location = New System.Drawing.Point(12, 84)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.email_txtbox.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Email"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(73, 261)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(94, 23)
        Me.save_btn.TabIndex = 23
        Me.save_btn.Text = "Save"
        '
        'nama_txtbox
        '
        Me.nama_txtbox.Location = New System.Drawing.Point(12, 35)
        Me.nama_txtbox.Name = "nama_txtbox"
        Me.nama_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.nama_txtbox.TabIndex = 22
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(10, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 21
        Me.UsernameLabel.Text = "Nama"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 307)
        Me.Controls.Add(Me.sma_radio)
        Me.Controls.Add(Me.smp_radio)
        Me.Controls.Add(Me.sd_radio)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.username_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.nama_txtbox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Name = "UserDetails"
        Me.Text = "UserDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sma_radio As RadioButton
    Friend WithEvents smp_radio As RadioButton
    Friend WithEvents sd_radio As RadioButton
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents save_btn As Button
    Friend WithEvents nama_txtbox As TextBox
    Friend WithEvents UsernameLabel As Label
End Class
