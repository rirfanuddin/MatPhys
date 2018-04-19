<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.signup_btn = New System.Windows.Forms.Button()
        Me.nama_txtbox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password_txtbtn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sd_radio = New System.Windows.Forms.RadioButton()
        Me.smp_radio = New System.Windows.Forms.RadioButton()
        Me.sma_radio = New System.Windows.Forms.RadioButton()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signup_btn
        '
        Me.signup_btn.Location = New System.Drawing.Point(231, 264)
        Me.signup_btn.Name = "signup_btn"
        Me.signup_btn.Size = New System.Drawing.Size(94, 23)
        Me.signup_btn.TabIndex = 11
        Me.signup_btn.Text = "Sign Up"
        '
        'nama_txtbox
        '
        Me.nama_txtbox.Location = New System.Drawing.Point(176, 38)
        Me.nama_txtbox.Name = "nama_txtbox"
        Me.nama_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.nama_txtbox.TabIndex = 8
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(174, 12)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "Nama"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(2, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 298)
        Me.LogoPictureBox.TabIndex = 7
        Me.LogoPictureBox.TabStop = False
        '
        'email_txtbox
        '
        Me.email_txtbox.Location = New System.Drawing.Point(176, 87)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.email_txtbox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(174, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Email"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'username_txtbox
        '
        Me.username_txtbox.Location = New System.Drawing.Point(177, 136)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(220, 20)
        Me.username_txtbox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(175, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'password_txtbtn
        '
        Me.password_txtbtn.Location = New System.Drawing.Point(178, 185)
        Me.password_txtbtn.Name = "password_txtbtn"
        Me.password_txtbtn.Size = New System.Drawing.Size(220, 20)
        Me.password_txtbtn.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sd_radio
        '
        Me.sd_radio.AutoSize = True
        Me.sd_radio.Location = New System.Drawing.Point(184, 227)
        Me.sd_radio.Name = "sd_radio"
        Me.sd_radio.Size = New System.Drawing.Size(40, 17)
        Me.sd_radio.TabIndex = 18
        Me.sd_radio.TabStop = True
        Me.sd_radio.Text = "SD"
        Me.sd_radio.UseVisualStyleBackColor = True
        '
        'smp_radio
        '
        Me.smp_radio.AutoSize = True
        Me.smp_radio.Location = New System.Drawing.Point(257, 227)
        Me.smp_radio.Name = "smp_radio"
        Me.smp_radio.Size = New System.Drawing.Size(48, 17)
        Me.smp_radio.TabIndex = 19
        Me.smp_radio.TabStop = True
        Me.smp_radio.Text = "SMP"
        Me.smp_radio.UseVisualStyleBackColor = True
        '
        'sma_radio
        '
        Me.sma_radio.AutoSize = True
        Me.sma_radio.Location = New System.Drawing.Point(338, 227)
        Me.sma_radio.Name = "sma_radio"
        Me.sma_radio.Size = New System.Drawing.Size(48, 17)
        Me.sma_radio.TabIndex = 20
        Me.sma_radio.TabStop = True
        Me.sma_radio.Text = "SMA"
        Me.sma_radio.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 299)
        Me.Controls.Add(Me.sma_radio)
        Me.Controls.Add(Me.smp_radio)
        Me.Controls.Add(Me.sd_radio)
        Me.Controls.Add(Me.password_txtbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.username_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signup_btn)
        Me.Controls.Add(Me.nama_txtbox)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Name = "SignUp"
        Me.Text = "Sign Up"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents signup_btn As Button
    Friend WithEvents nama_txtbox As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents password_txtbtn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sd_radio As RadioButton
    Friend WithEvents smp_radio As RadioButton
    Friend WithEvents sma_radio As RadioButton
End Class
