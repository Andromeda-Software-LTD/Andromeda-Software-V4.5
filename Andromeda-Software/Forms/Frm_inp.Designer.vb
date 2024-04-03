<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_inp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_inp))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.BOXX = New System.Windows.Forms.Panel()
        Me.CheckHidden = New System.Windows.Forms.CheckBox()
        Me.CheckFolder = New System.Windows.Forms.CheckBox()
        Me.b_ok = New System.Windows.Forms.Button()
        Me.InputText = New System.Windows.Forms.TextBox()
        Me.LTitle = New System.Windows.Forms.Label()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BOXX.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Controls.Add(Me.BOXX)
        Me.Panel1.Controls.Add(Me.b_ok)
        Me.Panel1.Controls.Add(Me.InputText)
        Me.Panel1.Controls.Add(Me.LTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 130)
        Me.Panel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(375, 7)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 5
        '
        'BOXX
        '
        Me.BOXX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BOXX.Controls.Add(Me.CheckHidden)
        Me.BOXX.Controls.Add(Me.CheckFolder)
        Me.BOXX.Location = New System.Drawing.Point(12, 95)
        Me.BOXX.Name = "BOXX"
        Me.BOXX.Size = New System.Drawing.Size(335, 23)
        Me.BOXX.TabIndex = 4
        Me.BOXX.Visible = False
        '
        'CheckHidden
        '
        Me.CheckHidden.AutoSize = True
        Me.CheckHidden.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckHidden.Location = New System.Drawing.Point(211, 0)
        Me.CheckHidden.Name = "CheckHidden"
        Me.CheckHidden.Size = New System.Drawing.Size(71, 23)
        Me.CheckHidden.TabIndex = 1
        Me.CheckHidden.Text = "Esconder"
        Me.CheckHidden.UseVisualStyleBackColor = True
        '
        'CheckFolder
        '
        Me.CheckFolder.AutoSize = True
        Me.CheckFolder.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckFolder.Location = New System.Drawing.Point(282, 0)
        Me.CheckFolder.Name = "CheckFolder"
        Me.CheckFolder.Size = New System.Drawing.Size(53, 23)
        Me.CheckFolder.TabIndex = 0
        Me.CheckFolder.Text = "Pasta"
        Me.CheckFolder.UseVisualStyleBackColor = True
        '
        'b_ok
        '
        Me.b_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.b_ok.BackColor = System.Drawing.Color.White
        Me.b_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ok.ForeColor = System.Drawing.Color.Black
        Me.b_ok.Location = New System.Drawing.Point(353, 95)
        Me.b_ok.Name = "b_ok"
        Me.b_ok.Size = New System.Drawing.Size(67, 23)
        Me.b_ok.TabIndex = 3
        Me.b_ok.Text = "OK"
        Me.b_ok.UseVisualStyleBackColor = False
        '
        'InputText
        '
        Me.InputText.BackColor = System.Drawing.Color.White
        Me.InputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InputText.ForeColor = System.Drawing.Color.Black
        Me.InputText.Location = New System.Drawing.Point(12, 56)
        Me.InputText.Name = "InputText"
        Me.InputText.Size = New System.Drawing.Size(408, 13)
        Me.InputText.TabIndex = 2
        '
        'LTitle
        '
        Me.LTitle.AutoSize = True
        Me.LTitle.ForeColor = System.Drawing.Color.Black
        Me.LTitle.Location = New System.Drawing.Point(12, 23)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(23, 13)
        Me.LTitle.TabIndex = 1
        Me.LTitle.Text = "null"
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
        'inp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 130)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inp"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "inp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BOXX.ResumeLayout(False)
        Me.BOXX.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTitle As Label
    Friend WithEvents InputText As TextBox
    Friend WithEvents b_ok As Button
    Friend WithEvents BOXX As Panel
    Friend WithEvents CheckHidden As CheckBox
    Friend WithEvents CheckFolder As CheckBox
    Friend WithEvents TOpacity As Timer
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
