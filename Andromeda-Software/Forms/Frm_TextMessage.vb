Public Class Frm_TextMessage
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
     Private Sub SpyStyle()
        For Each gr As RichTextBox In Me.Controls.OfType(Of RichTextBox)()
        Next
    End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub TextMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\14.ico")
         SpyStyle()
         TextMsg.Font = Frm_Config_Settings.f
         Me.CMenu.Renderer = New Frm_Config_Option
         TextMsg.ContextMenuStrip = Me.CMenu
         Me.Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
     End Sub
     Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextMsg.Cut()
    End Sub
     Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextMsg.Copy()
    End Sub
     Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextMsg.Paste()
    End Sub

    Private Sub TextMsg_TextChanged(sender As Object, e As EventArgs) Handles TextMsg.TextChanged

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub
End Class