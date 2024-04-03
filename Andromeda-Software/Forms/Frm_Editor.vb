Public Class Frm_Editor
    Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public status As Boolean
     Public path As String = Nothing
     Public Title As String = "null"
     Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub SpyStyle()
        For Each gr As Button In Panel1.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As RichTextBox In Me.Controls.OfType(Of RichTextBox)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\8.ico")
         SpyStyle()
         Me.CMenu.Renderer = New Frm_Config_Option
         EditText.ContextMenuStrip = Me.CMenu
         Me.Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
     Private Sub EditText_TextChanged(sender As Object, e As EventArgs) Handles EditText.TextChanged
         If Not b_ok.Visible = True And status = True Then
             b_ok.Visible = True
         End If
     End Sub
     Private Sub Editor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
         status = True
     End Sub
     Private Sub b_ok_Click(sender As Object, e As EventArgs) Handles b_ok.Click
         If Not classClient Is Nothing And Not path = Nothing Then
             Dim objs As Object()
             If EditText.Text.Length > 0 Then
                objs = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "save" & sockets.Data.SPL_DATA & path & sockets.Data.SPL_DATA & EditText.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            Else
                objs = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "empty" & sockets.Data.SPL_DATA & path, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            End If
             classClient.SendAsync(objs)
             Me.Close()
         End If
     End Sub
     Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        EditText.Cut()
    End Sub
     Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        EditText.Copy()
    End Sub
     Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        EditText.Paste()
    End Sub
End Class