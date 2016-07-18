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
        Me.txtRecentVideoTitle = New System.Windows.Forms.TextBox()
        Me.txtRecentVideoLink = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtRecentVideoTitle
        '
        Me.txtRecentVideoTitle.Location = New System.Drawing.Point(12, 83)
        Me.txtRecentVideoTitle.Name = "txtRecentVideoTitle"
        Me.txtRecentVideoTitle.Size = New System.Drawing.Size(260, 20)
        Me.txtRecentVideoTitle.TabIndex = 0
        Me.txtRecentVideoTitle.Text = "Test"
        '
        'txtRecentVideoLink
        '
        Me.txtRecentVideoLink.Location = New System.Drawing.Point(12, 109)
        Me.txtRecentVideoLink.Name = "txtRecentVideoLink"
        Me.txtRecentVideoLink.Size = New System.Drawing.Size(260, 20)
        Me.txtRecentVideoLink.TabIndex = 1
        Me.txtRecentVideoLink.Text = "http://www.google.co.uk"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtRecentVideoLink)
        Me.Controls.Add(Me.txtRecentVideoTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRecentVideoTitle As TextBox
    Friend WithEvents txtRecentVideoLink As TextBox
End Class
