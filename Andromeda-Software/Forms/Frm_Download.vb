Imports System.ComponentModel
 Public Class Frm_Download
     Public Client As Net.Sockets.TcpClient
     Public classClient As sockets.Frm_Config_Client
     Public FileStream As System.IO.FileStream = Nothing
     Public _stream As Long = 0
     Public xName As String = "null"
     Public TotalSize As Long
     Public elapsed_time As TimeSpan
     Public start_time As DateTime
     Public stop_time As DateTime
     Public DownFolder As String
     Public Title As String = "null"
      Private Sub SpyStyle()
         For Each gr As DataGridView In Me.Controls.OfType(Of DataGridView)()
            gr.BackgroundColor = SpySettings.DefaultColor_Background
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ColumnHeadersDefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.BackColor = SpySettings.DefaultColor_Background
            gr.DefaultCellStyle.SelectionForeColor = SpySettings.DefaultColor_Background
              gr.DefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
            gr.DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Foreground
            gr.ColumnHeadersDefaultCellStyle.ForeColor = SpySettings.DefaultColor_Foreground
        Next
     End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Download_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\7.ico")
         SpyStyle()
         DGV0.ColumnHeadersDefaultCellStyle.Font = Frm_Config_Settings.f
         DGV0.DefaultCellStyle.Font = Frm_Config_Settings.f
         TimeFinish.Interval = 1000
         TimeFinish.Enabled = True
         Me.Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
     End Sub
     Private Sub Download_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
         TimeFinish.Enabled = False
         If Not classClient Is Nothing Then
             classClient.qit = True
             classClient.Close(Client, "")
         End If
         If FileStream IsNot Nothing Then
             FileStream.Dispose()
             FileStream.Close()
         End If
     End Sub
     Private Sub TimeFinish_Tick(sender As Object, e As EventArgs) Handles TimeFinish.Tick
         If DGV0.Rows.Count > 0 Then
             If Not Me._stream > Me.TotalSize Then
                 If Me._stream > 0 Then
                     Me.stop_time = Now
                     Me.elapsed_time = Me.stop_time.Subtract(Me.start_time)
                     Dim lng As Long = (Me.TotalSize - Me._stream) * Me.elapsed_time.TotalSeconds / Me._stream
                     Dim time As String = Frm_Config_Codes.ToTime(lng)
                     If Not time.Equals("0:0:0") Then
                         Dim cur As DateTime = System.DateTime.Now()
                         Dim dt As DateTime = Convert.ToDateTime(time)
                         cur = cur.AddHours(dt.Hour)
                         cur = cur.AddMinutes(dt.Minute)
                         cur = cur.AddSeconds(dt.Second)
                         DGV0.Rows(3).Cells(1).Value = String.Format("[{0}]", time)
                     End If
                End If
             End If
         End If
     End Sub
End Class