<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AppsProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_AppsProperties))
        Me.BoxIcons = New System.Windows.Forms.PictureBox()
        Me.BOXPNL1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.LPermissions = New System.Windows.Forms.Label()
        Me.LAppInstallTime = New System.Windows.Forms.Label()
        Me.LAppFlag = New System.Windows.Forms.Label()
        Me.LAppName = New System.Windows.Forms.Label()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        CType(Me.BoxIcons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BOXPNL1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BoxIcons
        '
        Me.BoxIcons.BackColor = System.Drawing.Color.White
        Me.BoxIcons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BoxIcons.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoxIcons.Location = New System.Drawing.Point(0, 0)
        Me.BoxIcons.Name = "BoxIcons"
        Me.BoxIcons.Size = New System.Drawing.Size(361, 196)
        Me.BoxIcons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BoxIcons.TabIndex = 0
        Me.BoxIcons.TabStop = False
        '
        'BOXPNL1
        '
        Me.BOXPNL1.AutoScroll = True
        Me.BOXPNL1.BackColor = System.Drawing.Color.White
        Me.BOXPNL1.Controls.Add(Me.Guna2ControlBox1)
        Me.BOXPNL1.Controls.Add(Me.LPermissions)
        Me.BOXPNL1.Controls.Add(Me.LAppInstallTime)
        Me.BOXPNL1.Controls.Add(Me.LAppFlag)
        Me.BOXPNL1.Controls.Add(Me.LAppName)
        Me.BOXPNL1.Controls.Add(Me.BoxIcons)
        Me.BOXPNL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BOXPNL1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.BOXPNL1.Location = New System.Drawing.Point(0, 0)
        Me.BOXPNL1.Name = "BOXPNL1"
        Me.BOXPNL1.Size = New System.Drawing.Size(361, 360)
        Me.BOXPNL1.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(313, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 6
        '
        'LPermissions
        '
        Me.LPermissions.BackColor = System.Drawing.Color.White
        Me.LPermissions.Dock = System.Windows.Forms.DockStyle.Top
        Me.LPermissions.ForeColor = System.Drawing.Color.Black
        Me.LPermissions.Location = New System.Drawing.Point(0, 307)
        Me.LPermissions.Name = "LPermissions"
        Me.LPermissions.Size = New System.Drawing.Size(361, 37)
        Me.LPermissions.TabIndex = 5
        Me.LPermissions.Text = "Permissão"
        Me.LPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LAppInstallTime
        '
        Me.LAppInstallTime.BackColor = System.Drawing.Color.White
        Me.LAppInstallTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.LAppInstallTime.ForeColor = System.Drawing.Color.Black
        Me.LAppInstallTime.Location = New System.Drawing.Point(0, 270)
        Me.LAppInstallTime.Name = "LAppInstallTime"
        Me.LAppInstallTime.Size = New System.Drawing.Size(361, 37)
        Me.LAppInstallTime.TabIndex = 3
        Me.LAppInstallTime.Text = "Tempo de Instalação"
        Me.LAppInstallTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LAppFlag
        '
        Me.LAppFlag.BackColor = System.Drawing.Color.White
        Me.LAppFlag.Dock = System.Windows.Forms.DockStyle.Top
        Me.LAppFlag.ForeColor = System.Drawing.Color.Black
        Me.LAppFlag.Location = New System.Drawing.Point(0, 233)
        Me.LAppFlag.Name = "LAppFlag"
        Me.LAppFlag.Size = New System.Drawing.Size(361, 37)
        Me.LAppFlag.TabIndex = 2
        Me.LAppFlag.Text = "Rascunho"
        Me.LAppFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LAppName
        '
        Me.LAppName.BackColor = System.Drawing.Color.White
        Me.LAppName.Dock = System.Windows.Forms.DockStyle.Top
        Me.LAppName.ForeColor = System.Drawing.Color.Black
        Me.LAppName.Location = New System.Drawing.Point(0, 196)
        Me.LAppName.Name = "LAppName"
        Me.LAppName.Size = New System.Drawing.Size(361, 37)
        Me.LAppName.TabIndex = 1
        Me.LAppName.Text = "Nome do Aplicativo"
        Me.LAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'AppsProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 360)
        Me.Controls.Add(Me.BOXPNL1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AppsProperties"
        Me.Opacity = 0R
        Me.Text = "Properties"
        CType(Me.BoxIcons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BOXPNL1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BoxIcons As PictureBox
    Friend WithEvents BOXPNL1 As Panel
    Friend WithEvents LAppInstallTime As Label
    Friend WithEvents LAppFlag As Label
    Friend WithEvents LAppName As Label
    Friend WithEvents TOpacity As Timer
    Friend WithEvents LPermissions As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
