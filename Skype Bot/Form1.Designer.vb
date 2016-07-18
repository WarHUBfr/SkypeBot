<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.btnwelmeschange = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWelcome = New System.Windows.Forms.TextBox()
        Me.btnopenurl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnmotdchange = New System.Windows.Forms.Button()
        Me.btnprechange = New System.Windows.Forms.Button()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMotd = New System.Windows.Forms.TextBox()
        Me.TabMusicNow = New System.Windows.Forms.TabPage()
        Me.NowPlayingWeb = New System.Windows.Forms.WebBrowser()
        Me.TabMusicQueue = New System.Windows.Forms.TabPage()
        Me.MusicQueueTxt = New System.Windows.Forms.RichTextBox()
        Me.TabAbout = New System.Windows.Forms.TabPage()
        Me.TabControl.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.TabMusicNow.SuspendLayout()
        Me.TabMusicQueue.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabSettings)
        Me.TabControl.Controls.Add(Me.TabMusicNow)
        Me.TabControl.Controls.Add(Me.TabMusicQueue)
        Me.TabControl.Controls.Add(Me.TabAbout)
        Me.TabControl.Location = New System.Drawing.Point(-3, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(323, 413)
        Me.TabControl.TabIndex = 0
        '
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.SystemColors.Highlight
        Me.TabSettings.Controls.Add(Me.btnwelmeschange)
        Me.TabSettings.Controls.Add(Me.Label4)
        Me.TabSettings.Controls.Add(Me.txtWelcome)
        Me.TabSettings.Controls.Add(Me.btnopenurl)
        Me.TabSettings.Controls.Add(Me.Label3)
        Me.TabSettings.Controls.Add(Me.txtUrl)
        Me.TabSettings.Controls.Add(Me.btnmotdchange)
        Me.TabSettings.Controls.Add(Me.btnprechange)
        Me.TabSettings.Controls.Add(Me.txtPrefix)
        Me.TabSettings.Controls.Add(Me.Label2)
        Me.TabSettings.Controls.Add(Me.Label1)
        Me.TabSettings.Controls.Add(Me.txtMotd)
        Me.TabSettings.Location = New System.Drawing.Point(4, 24)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(315, 385)
        Me.TabSettings.TabIndex = 0
        Me.TabSettings.Text = "Settings"
        '
        'btnwelmeschange
        '
        Me.btnwelmeschange.Location = New System.Drawing.Point(194, 332)
        Me.btnwelmeschange.Name = "btnwelmeschange"
        Me.btnwelmeschange.Size = New System.Drawing.Size(109, 39)
        Me.btnwelmeschange.TabIndex = 24
        Me.btnwelmeschange.Text = "Change Welcome Message"
        Me.btnwelmeschange.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Welcome Message"
        '
        'txtWelcome
        '
        Me.txtWelcome.AcceptsReturn = True
        Me.txtWelcome.Location = New System.Drawing.Point(8, 306)
        Me.txtWelcome.Multiline = True
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(301, 20)
        Me.txtWelcome.TabIndex = 22
        Me.txtWelcome.Text = "Welcome to WelpeBot. This is a BOT so there will not be any human replies. For a " &
    "list of commands type !commands."
        '
        'btnopenurl
        '
        Me.btnopenurl.Location = New System.Drawing.Point(194, 240)
        Me.btnopenurl.Name = "btnopenurl"
        Me.btnopenurl.Size = New System.Drawing.Size(109, 39)
        Me.btnopenurl.TabIndex = 21
        Me.btnopenurl.Text = "Open URL"
        Me.btnopenurl.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Open Music URL"
        '
        'txtUrl
        '
        Me.txtUrl.AcceptsReturn = True
        Me.txtUrl.Location = New System.Drawing.Point(8, 214)
        Me.txtUrl.Multiline = True
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(301, 20)
        Me.txtUrl.TabIndex = 19
        Me.txtUrl.Text = "http://example.com"
        '
        'btnmotdchange
        '
        Me.btnmotdchange.Location = New System.Drawing.Point(194, 145)
        Me.btnmotdchange.Name = "btnmotdchange"
        Me.btnmotdchange.Size = New System.Drawing.Size(109, 41)
        Me.btnmotdchange.TabIndex = 18
        Me.btnmotdchange.Text = "Change MOTD"
        Me.btnmotdchange.UseVisualStyleBackColor = True
        '
        'btnprechange
        '
        Me.btnprechange.Location = New System.Drawing.Point(194, 59)
        Me.btnprechange.Name = "btnprechange"
        Me.btnprechange.Size = New System.Drawing.Size(109, 38)
        Me.btnprechange.TabIndex = 17
        Me.btnprechange.Text = "Change Prefix"
        Me.btnprechange.UseVisualStyleBackColor = True
        '
        'txtPrefix
        '
        Me.txtPrefix.AcceptsReturn = True
        Me.txtPrefix.Location = New System.Drawing.Point(8, 33)
        Me.txtPrefix.Multiline = True
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(301, 20)
        Me.txtPrefix.TabIndex = 16
        Me.txtPrefix.Text = "!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Command Prefix"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Message of the day"
        '
        'txtMotd
        '
        Me.txtMotd.AcceptsReturn = True
        Me.txtMotd.Location = New System.Drawing.Point(8, 119)
        Me.txtMotd.Multiline = True
        Me.txtMotd.Name = "txtMotd"
        Me.txtMotd.Size = New System.Drawing.Size(301, 20)
        Me.txtMotd.TabIndex = 13
        Me.txtMotd.Text = "This is the default MOTD message."
        '
        'TabMusicNow
        '
        Me.TabMusicNow.Controls.Add(Me.NowPlayingWeb)
        Me.TabMusicNow.Location = New System.Drawing.Point(4, 24)
        Me.TabMusicNow.Name = "TabMusicNow"
        Me.TabMusicNow.Size = New System.Drawing.Size(315, 385)
        Me.TabMusicNow.TabIndex = 3
        Me.TabMusicNow.Text = "Now playing"
        Me.TabMusicNow.UseVisualStyleBackColor = True
        '
        'NowPlayingWeb
        '
        Me.NowPlayingWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NowPlayingWeb.Location = New System.Drawing.Point(0, 0)
        Me.NowPlayingWeb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.NowPlayingWeb.Name = "NowPlayingWeb"
        Me.NowPlayingWeb.Size = New System.Drawing.Size(315, 385)
        Me.NowPlayingWeb.TabIndex = 0
        Me.NowPlayingWeb.Url = New System.Uri("http://youtube.com", System.UriKind.Absolute)
        '
        'TabMusicQueue
        '
        Me.TabMusicQueue.BackColor = System.Drawing.SystemColors.Control
        Me.TabMusicQueue.Controls.Add(Me.MusicQueueTxt)
        Me.TabMusicQueue.Location = New System.Drawing.Point(4, 24)
        Me.TabMusicQueue.Name = "TabMusicQueue"
        Me.TabMusicQueue.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMusicQueue.Size = New System.Drawing.Size(315, 385)
        Me.TabMusicQueue.TabIndex = 1
        Me.TabMusicQueue.Text = "Music Queue"
        '
        'MusicQueueTxt
        '
        Me.MusicQueueTxt.Location = New System.Drawing.Point(6, 6)
        Me.MusicQueueTxt.Name = "MusicQueueTxt"
        Me.MusicQueueTxt.ReadOnly = True
        Me.MusicQueueTxt.Size = New System.Drawing.Size(303, 373)
        Me.MusicQueueTxt.TabIndex = 0
        Me.MusicQueueTxt.Text = ""
        '
        'TabAbout
        '
        Me.TabAbout.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabAbout.Location = New System.Drawing.Point(4, 24)
        Me.TabAbout.Name = "TabAbout"
        Me.TabAbout.Size = New System.Drawing.Size(315, 385)
        Me.TabAbout.TabIndex = 2
        Me.TabAbout.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(316, 410)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "WelpeBot for Skype"
        Me.TabControl.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.TabSettings.PerformLayout()
        Me.TabMusicNow.ResumeLayout(False)
        Me.TabMusicQueue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabSettings As TabPage
    Friend WithEvents btnwelmeschange As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWelcome As TextBox
    Friend WithEvents btnopenurl As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnmotdchange As Button
    Friend WithEvents btnprechange As Button
    Friend WithEvents txtPrefix As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMotd As TextBox
    Friend WithEvents TabMusicQueue As TabPage
    Friend WithEvents TabAbout As TabPage
    Friend WithEvents MusicQueueTxt As RichTextBox
    Friend WithEvents TabMusicNow As TabPage
    Public WithEvents NowPlayingWeb As WebBrowser
End Class
