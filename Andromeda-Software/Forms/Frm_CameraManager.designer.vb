<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CameraManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CameraManager))
        Me.CAM0 = New System.Windows.Forms.PictureBox()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.FrontCameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackCameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopCameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TP = New System.Windows.Forms.Timer(Me.components)
        Me.Frames = New System.Windows.Forms.Timer(Me.components)
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.statustext = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbofoucs = New System.Windows.Forms.ComboBox()
        Me.combqulty = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ClientPic = New System.Windows.Forms.PictureBox()
        Me.Sbtn = New System.Windows.Forms.Button()
        Me.Bbtn = New System.Windows.Forms.Button()
        Me.Fbtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New Andromeda.Frm_Config_Users()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel6 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Guna2GradientPanel6.SuspendLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CAM0
        '
        Me.CAM0.BackColor = System.Drawing.Color.Transparent
        Me.CAM0.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.CAM0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CAM0.Location = New System.Drawing.Point(0, 0)
        Me.CAM0.Name = "CAM0"
        Me.CAM0.Size = New System.Drawing.Size(827, 462)
        Me.CAM0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CAM0.TabIndex = 0
        Me.CAM0.TabStop = False
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrontCameraToolStripMenuItem, Me.BackCameraToolStripMenuItem, Me.RotationToolStripMenuItem, Me.SaveFotoToolStripMenuItem, Me.StopCameraToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(154, 114)
        '
        'FrontCameraToolStripMenuItem
        '
        Me.FrontCameraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.FrontCameraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.FrontCameraToolStripMenuItem.Image = CType(resources.GetObject("FrontCameraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FrontCameraToolStripMenuItem.Name = "FrontCameraToolStripMenuItem"
        Me.FrontCameraToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FrontCameraToolStripMenuItem.Text = "Frontal camera"
        '
        'BackCameraToolStripMenuItem
        '
        Me.BackCameraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BackCameraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.BackCameraToolStripMenuItem.Image = CType(resources.GetObject("BackCameraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackCameraToolStripMenuItem.Name = "BackCameraToolStripMenuItem"
        Me.BackCameraToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BackCameraToolStripMenuItem.Text = "Back camera"
        '
        'RotationToolStripMenuItem
        '
        Me.RotationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RotationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.RotationToolStripMenuItem.Image = CType(resources.GetObject("RotationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RotationToolStripMenuItem.Name = "RotationToolStripMenuItem"
        Me.RotationToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.RotationToolStripMenuItem.Text = "Rotation"
        '
        'SaveFotoToolStripMenuItem
        '
        Me.SaveFotoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SaveFotoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.SaveFotoToolStripMenuItem.Image = CType(resources.GetObject("SaveFotoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveFotoToolStripMenuItem.Name = "SaveFotoToolStripMenuItem"
        Me.SaveFotoToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SaveFotoToolStripMenuItem.Text = "Save Foto"
        '
        'StopCameraToolStripMenuItem
        '
        Me.StopCameraToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.StopCameraToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.StopCameraToolStripMenuItem.Image = CType(resources.GetObject("StopCameraToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopCameraToolStripMenuItem.Name = "StopCameraToolStripMenuItem"
        Me.StopCameraToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.StopCameraToolStripMenuItem.Text = "Stop Camera"
        '
        'TP
        '
        Me.TP.Interval = 1
        '
        'Frames
        '
        Me.Frames.Interval = 1000
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.CAM0)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 462)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 404)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(544, 24)
        Me.Panel4.TabIndex = 1
        '
        'statustext
        '
        Me.statustext.AutoSize = True
        Me.statustext.BackColor = System.Drawing.Color.White
        Me.statustext.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.statustext.ForeColor = System.Drawing.Color.Black
        Me.statustext.Location = New System.Drawing.Point(-4, 11)
        Me.statustext.Name = "statustext"
        Me.statustext.Size = New System.Drawing.Size(140, 19)
        Me.statustext.TabIndex = 15
        Me.statustext.Text = "Camera Selecionada"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(901, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Foco"
        '
        'cmbofoucs
        '
        Me.cmbofoucs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbofoucs.BackColor = System.Drawing.Color.White
        Me.cmbofoucs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbofoucs.ForeColor = System.Drawing.Color.Black
        Me.cmbofoucs.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbofoucs.Location = New System.Drawing.Point(847, 267)
        Me.cmbofoucs.Name = "cmbofoucs"
        Me.cmbofoucs.Size = New System.Drawing.Size(147, 21)
        Me.cmbofoucs.TabIndex = 16
        '
        'combqulty
        '
        Me.combqulty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.combqulty.BackColor = System.Drawing.Color.White
        Me.combqulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combqulty.ForeColor = System.Drawing.Color.Black
        Me.combqulty.Items.AddRange(New Object() {"Auto", "High Quality"})
        Me.combqulty.Location = New System.Drawing.Point(834, 338)
        Me.combqulty.Name = "combqulty"
        Me.combqulty.Size = New System.Drawing.Size(147, 21)
        Me.combqulty.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(887, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Qualidade"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.ClientPic)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(681, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(16, 22)
        Me.Panel2.TabIndex = 1
        '
        'ClientPic
        '
        Me.ClientPic.BackColor = System.Drawing.Color.Black
        Me.ClientPic.Location = New System.Drawing.Point(46, 43)
        Me.ClientPic.Name = "ClientPic"
        Me.ClientPic.Size = New System.Drawing.Size(67, 55)
        Me.ClientPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ClientPic.TabIndex = 11
        Me.ClientPic.TabStop = False
        '
        'Sbtn
        '
        Me.Sbtn.BackColor = System.Drawing.Color.Transparent
        Me.Sbtn.Enabled = False
        Me.Sbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Sbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Sbtn.Location = New System.Drawing.Point(852, 161)
        Me.Sbtn.Name = "Sbtn"
        Me.Sbtn.Size = New System.Drawing.Size(165, 32)
        Me.Sbtn.TabIndex = 18
        Me.Sbtn.Text = "Parar"
        Me.Sbtn.UseVisualStyleBackColor = False
        '
        'Bbtn
        '
        Me.Bbtn.BackColor = System.Drawing.Color.Transparent
        Me.Bbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Bbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Bbtn.Location = New System.Drawing.Point(852, 44)
        Me.Bbtn.Name = "Bbtn"
        Me.Bbtn.Size = New System.Drawing.Size(165, 32)
        Me.Bbtn.TabIndex = 13
        Me.Bbtn.Tag = "off"
        Me.Bbtn.Text = "Camera de Trais"
        Me.Bbtn.UseVisualStyleBackColor = False
        '
        'Fbtn
        '
        Me.Fbtn.BackColor = System.Drawing.Color.Transparent
        Me.Fbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Fbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Fbtn.Location = New System.Drawing.Point(852, 6)
        Me.Fbtn.Name = "Fbtn"
        Me.Fbtn.Size = New System.Drawing.Size(165, 32)
        Me.Fbtn.TabIndex = 12
        Me.Fbtn.Tag = "off"
        Me.Fbtn.Text = "Camera da Frente"
        Me.Fbtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(852, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Rotação"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button4, "Rotate")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(852, 85)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Tag = "off"
        Me.Button3.Text = "Salvar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Button3, "Save")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SaveTimer
        '
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.statustext)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Location = New System.Drawing.Point(545, 479)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(17, 10)
        Me.Panel3.TabIndex = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(29, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(26, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.DarkTurquoise
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 9000
        '
        'Guna2GradientPanel6
        '
        Me.Guna2GradientPanel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel6.BorderRadius = 2
        Me.Guna2GradientPanel6.BorderThickness = 1
        Me.Guna2GradientPanel6.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Guna2GradientPanel6.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Guna2GradientPanel6.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2GradientPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2GradientPanel6.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2GradientPanel6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel6.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel6.Name = "Guna2GradientPanel6"
        Me.Guna2GradientPanel6.Size = New System.Drawing.Size(827, 43)
        Me.Guna2GradientPanel6.TabIndex = 105
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(741, 12)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.Guna2CirclePictureBox3.TabIndex = 161
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(767, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.Guna2CirclePictureBox2.TabIndex = 160
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(793, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.Guna2CirclePictureBox1.TabIndex = 159
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2GradientPanel1.BorderRadius = 2
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Button3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel3)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmbofoucs)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Button4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Sbtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Fbtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.combqulty)
        Me.Guna2GradientPanel1.Controls.Add(Me.Bbtn)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 43)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(827, 462)
        Me.Guna2GradientPanel1.TabIndex = 162
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel6
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'CameraManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 505)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel6)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(827, 505)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(827, 505)
        Me.Name = "CameraManager"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CameraManager"
        CType(Me.CAM0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ClientPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Guna2GradientPanel6.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CAM0 As PictureBox
    Friend WithEvents TP As Timer
    Friend WithEvents Frames As Timer
    Friend WithEvents TOpacity As Timer
    Friend WithEvents ProgressBar1 As Frm_Config_Users
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SaveTimer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ClientPic As PictureBox
    Friend WithEvents Bbtn As Button
    Friend WithEvents Fbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbofoucs As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combqulty As ComboBox
    Friend WithEvents Sbtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents statustext As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2GradientPanel6 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents FrontCameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackCameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopCameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
