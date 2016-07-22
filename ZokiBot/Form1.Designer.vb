<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMotd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.btnprechange = New System.Windows.Forms.Button()
        Me.btnmotdchange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMotd
        '
        Me.txtMotd.AcceptsReturn = True
        Me.txtMotd.Location = New System.Drawing.Point(12, 23)
        Me.txtMotd.Multiline = True
        Me.txtMotd.Name = "txtMotd"
        Me.txtMotd.Size = New System.Drawing.Size(260, 20)
        Me.txtMotd.TabIndex = 0
        Me.txtMotd.Text = "This is the default MOTD message."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message of the day"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Command Prefix"
        '
        'txtPrefix
        '
        Me.txtPrefix.AcceptsReturn = True
        Me.txtPrefix.Location = New System.Drawing.Point(12, 74)
        Me.txtPrefix.Multiline = True
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(260, 20)
        Me.txtPrefix.TabIndex = 4
        Me.txtPrefix.Text = "!"
        '
        'btnprechange
        '
        Me.btnprechange.Location = New System.Drawing.Point(278, 72)
        Me.btnprechange.Name = "btnprechange"
        Me.btnprechange.Size = New System.Drawing.Size(109, 23)
        Me.btnprechange.TabIndex = 5
        Me.btnprechange.Text = "Change Prefix"
        Me.btnprechange.UseVisualStyleBackColor = True
        '
        'btnmotdchange
        '
        Me.btnmotdchange.Location = New System.Drawing.Point(278, 23)
        Me.btnmotdchange.Name = "btnmotdchange"
        Me.btnmotdchange.Size = New System.Drawing.Size(109, 23)
        Me.btnmotdchange.TabIndex = 6
        Me.btnmotdchange.Text = "Change MOTD"
        Me.btnmotdchange.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 110)
        Me.Controls.Add(Me.btnmotdchange)
        Me.Controls.Add(Me.btnprechange)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMotd)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Zoki Skype Bot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMotd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrefix As TextBox
    Friend WithEvents btnprechange As Button
    Friend WithEvents btnmotdchange As Button
End Class
