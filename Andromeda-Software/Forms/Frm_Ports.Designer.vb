<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Ports
    Inherits System.Windows.Forms.Form
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
      Private components As System.ComponentModel.IContainer
        <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ports))
        Me.po = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.b_ok = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.notpass = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.po, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'po
        '
        Me.po.BackColor = System.Drawing.Color.Transparent
        Me.po.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.po.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.po.Location = New System.Drawing.Point(260, 171)
        Me.po.Maximum = New Decimal(New Integer() {65550, 0, 0, 0})
        Me.po.Name = "po"
        Me.po.ShadowDecoration.Enabled = True
        Me.po.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 0, 0, 5)
        Me.po.Size = New System.Drawing.Size(100, 30)
        Me.po.TabIndex = 23
        Me.po.UpDownButtonFillColor = System.Drawing.Color.White
        Me.po.Value = New Decimal(New Integer() {1515, 0, 0, 0})
        '
        'b_ok
        '
        Me.b_ok.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.b_ok.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.b_ok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.b_ok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.b_ok.FillColor = System.Drawing.Color.White
        Me.b_ok.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.b_ok.ForeColor = System.Drawing.Color.Black
        Me.b_ok.Location = New System.Drawing.Point(12, 156)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.ShadowDecoration.Enabled = True
        Me.b_ok.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 0, 0, 5)
        Me.b_ok.Size = New System.Drawing.Size(118, 45)
        Me.b_ok.TabIndex = 22
        Me.b_ok.Text = "Iniciar"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(315, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Enabled = True
        Me.Guna2ControlBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(1, 0, 0, 5)
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 21
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'notpass
        '
        Me.notpass.Text = "NotifyIcon1"
        Me.notpass.Visible = True
        '
        'Ports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(372, 213)
        Me.Controls.Add(Me.po)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.b_ok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ports"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ports"
        CType(Me.po, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TOpacity As Timer
    Friend WithEvents notpass As NotifyIcon
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents b_ok As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents po As Guna.UI2.WinForms.Guna2NumericUpDown
End Class
