Public Class Frm_AppsProperties
    Public Title As String = "null"
     Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
     Private Sub AppsProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\2.ico")
         SpyStyle()
         Text = Title
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
     End Sub
     Private Sub SpyStyle()
         For Each gr As Panel In Me.Controls.OfType(Of Panel)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
         For Each gr As Label In BOXPNL1.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As PictureBox In BOXPNL1.Controls.OfType(Of PictureBox)()
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
         LPermissions.ForeColor = SpySettings.DefaultColor_ColorTitles
     End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
     Private Sub BoxIcons_Click(sender As Object, e As EventArgs) Handles BoxIcons.Click
         Process.Start(String.Format("{0}{1}", "https://play.google.com/store/apps/details?id=", CStr(BoxIcons.Tag)))
     End Sub
End Class