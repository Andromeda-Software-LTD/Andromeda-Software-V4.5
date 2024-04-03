Public Class Frm_Icons
    Public id As Integer
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
             gr.Columns(0).DefaultCellStyle.SelectionBackColor = SpySettings.DefaultColor_Background
         Next
     End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
     Private Sub Icons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\4.ico")
         SpyStyle()
         DGV0.ColumnHeadersDefaultCellStyle.Font = Frm_Config_Settings.f
         DGV0.DefaultCellStyle.Font = Frm_Config_Settings.f
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
    Private Sub DGV0_SortCompare(sender As Object, e As DataGridViewSortCompareEventArgs) Handles DGV0.SortCompare
         If e.RowIndex1 = 0 Then
             e.Handled = True
         End If
     End Sub
     Private Sub DGV0_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellDoubleClick
         If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
             id = e.RowIndex
             Me.DialogResult = DialogResult.OK
         End If
     End Sub
     Private Sub DGV0_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV0.CellContentClick
     End Sub
End Class