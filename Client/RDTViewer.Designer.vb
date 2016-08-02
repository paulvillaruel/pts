<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RDTViewer
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
        Me.rdtWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'rdtWebBrowser
        '
        Me.rdtWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdtWebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.rdtWebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.rdtWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.rdtWebBrowser.Name = "rdtWebBrowser"
        Me.rdtWebBrowser.Size = New System.Drawing.Size(299, 417)
        Me.rdtWebBrowser.TabIndex = 0
        '
        'RDTBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 417)
        Me.Controls.Add(Me.rdtWebBrowser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "RDTBrowser"
        Me.Text = "RDT Viewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdtWebBrowser As System.Windows.Forms.WebBrowser
End Class
