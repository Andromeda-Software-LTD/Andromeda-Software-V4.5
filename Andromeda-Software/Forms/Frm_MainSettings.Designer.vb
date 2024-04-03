<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MainSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MainSettings))
        Me.MainText = New System.Windows.Forms.Label()
        Me.Preform = New System.Windows.Forms.ComboBox()
        Me.Notifi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.saveit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.logit = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FMI = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FMQ = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainText
        '
        Me.MainText.AutoSize = True
        Me.MainText.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainText.ForeColor = System.Drawing.Color.Black
        Me.MainText.Location = New System.Drawing.Point(152, 63)
        Me.MainText.Name = "MainText"
        Me.MainText.Size = New System.Drawing.Size(91, 19)
        Me.MainText.TabIndex = 1
        Me.MainText.Text = "Performance"
        '
        'Preform
        '
        Me.Preform.BackColor = System.Drawing.Color.Black
        Me.Preform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Preform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Preform.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Preform.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Preform.Items.AddRange(New Object() {"High", "Normal", "Low"})
        Me.Preform.Location = New System.Drawing.Point(24, 63)
        Me.Preform.Name = "Preform"
        Me.Preform.Size = New System.Drawing.Size(104, 21)
        Me.Preform.TabIndex = 17
        '
        'Notifi
        '
        Me.Notifi.BackColor = System.Drawing.Color.White
        Me.Notifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Notifi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Notifi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notifi.ForeColor = System.Drawing.Color.Black
        Me.Notifi.Items.AddRange(New Object() {"Yes", "No"})
        Me.Notifi.Location = New System.Drawing.Point(24, 143)
        Me.Notifi.Name = "Notifi"
        Me.Notifi.Size = New System.Drawing.Size(104, 21)
        Me.Notifi.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ـــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــــ" &
    "ــ"
        '
        'saveit
        '
        Me.saveit.BackColor = System.Drawing.Color.Black
        Me.saveit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.saveit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.saveit.Items.AddRange(New Object() {"Yes", "No"})
        Me.saveit.Location = New System.Drawing.Point(23, 244)
        Me.saveit.Name = "saveit"
        Me.saveit.Size = New System.Drawing.Size(104, 21)
        Me.saveit.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 37)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "General"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(152, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Notifiation New Client"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 37)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Options"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(152, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Auto Save Data"
        '
        'logit
        '
        Me.logit.BackColor = System.Drawing.Color.Black
        Me.logit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.logit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.logit.Items.AddRange(New Object() {"Yes", "No"})
        Me.logit.Location = New System.Drawing.Point(24, 104)
        Me.logit.Name = "logit"
        Me.logit.Size = New System.Drawing.Size(104, 21)
        Me.logit.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(152, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Enable Log"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(152, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 19)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "FileManager icons"
        '
        'FMI
        '
        Me.FMI.BackColor = System.Drawing.Color.Black
        Me.FMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FMI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FMI.Items.AddRange(New Object() {"Small", "Large"})
        Me.FMI.Location = New System.Drawing.Point(23, 289)
        Me.FMI.Name = "FMI"
        Me.FMI.Size = New System.Drawing.Size(104, 21)
        Me.FMI.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(152, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "image view Quality"
        '
        'FMQ
        '
        Me.FMQ.BackColor = System.Drawing.Color.Black
        Me.FMQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FMQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FMQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FMQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FMQ.Items.AddRange(New Object() {"10", "20", "30", "40", "50", "60", "70", "80", "90"})
        Me.FMQ.Location = New System.Drawing.Point(24, 336)
        Me.FMQ.Name = "FMQ"
        Me.FMQ.Size = New System.Drawing.Size(104, 21)
        Me.FMQ.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.FMQ)
        Me.Panel1.Controls.Add(Me.MainText)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Preform)
        Me.Panel1.Controls.Add(Me.FMI)
        Me.Panel1.Controls.Add(Me.Notifi)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.saveit)
        Me.Panel1.Controls.Add(Me.logit)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 496)
        Me.Panel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 100)
        Me.Panel2.TabIndex = 33
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(0, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(329, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(0, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SaveSettings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(329, 496)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(345, 535)
        Me.MinimumSize = New System.Drawing.Size(345, 535)
        Me.Name = "MainSettings"
        Me.Text = "Andromeda Software"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainText As Label
    Friend WithEvents Preform As ComboBox
    Friend WithEvents Notifi As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents saveit As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents logit As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FMI As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FMQ As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
