<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ClipboardManager
    Inherits System.Windows.Forms.Form
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
      Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ClipboardManager))
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BTN_SET = New System.Windows.Forms.Button()
        Me.BTN_GET = New System.Windows.Forms.Button()
        Me.BoxClipboard = New System.Windows.Forms.TextBox()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.BTN_SET)
        Me.Panel1.Controls.Add(Me.BTN_GET)
        Me.Panel1.Controls.Add(Me.BoxClipboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 204)
        Me.Panel1.TabIndex = 3
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(325, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'BTN_SET
        '
        Me.BTN_SET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SET.Location = New System.Drawing.Point(286, 104)
        Me.BTN_SET.Name = "BTN_SET"
        Me.BTN_SET.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SET.TabIndex = 3
        Me.BTN_SET.Text = "Colar"
        Me.BTN_SET.UseVisualStyleBackColor = True
        '
        'BTN_GET
        '
        Me.BTN_GET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GET.Location = New System.Drawing.Point(286, 75)
        Me.BTN_GET.Name = "BTN_GET"
        Me.BTN_GET.Size = New System.Drawing.Size(75, 23)
        Me.BTN_GET.TabIndex = 1
        Me.BTN_GET.Text = "Copiar"
        Me.BTN_GET.UseVisualStyleBackColor = True
        '
        'BoxClipboard
        '
        Me.BoxClipboard.BackColor = System.Drawing.Color.White
        Me.BoxClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BoxClipboard.ForeColor = System.Drawing.Color.Black
        Me.BoxClipboard.Location = New System.Drawing.Point(21, 28)
        Me.BoxClipboard.Multiline = True
        Me.BoxClipboard.Name = "BoxClipboard"
        Me.BoxClipboard.Size = New System.Drawing.Size(247, 147)
        Me.BoxClipboard.TabIndex = 0
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ClipboardManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 204)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ClipboardManager"
        Me.Opacity = 0R
        Me.Text = "ClipboardManager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_GET As Button
    Friend WithEvents BoxClipboard As TextBox
    Friend WithEvents BTN_SET As Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
