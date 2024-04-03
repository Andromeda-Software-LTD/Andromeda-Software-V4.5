Public Class 要先价种房劳文书间延的年式先种式房间道肉方外华三的里价感烟常
    Private Sub b_ok_Click(sender As Object, e As EventArgs) Handles b_ok.Click
         Me.DialogResult = DialogResult.OK
     End Sub
    Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub SpyStyle()
        For Each gr As Label In Panel1.Controls.OfType(Of Label)()
            gr.ForeColor = SpySettings.DefaultColor_Foreground
            gr.BackColor = SpySettings.DefaultColor_Background
        Next
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
    Private Sub AddNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\12.ico")
         SpyStyle()
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
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

    Private Sub InputText1_TextChanged(sender As Object, e As EventArgs) Handles InputText1.TextChanged

    End Sub

    Private Sub L1_Click(sender As Object, e As EventArgs) Handles L1.Click

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub
End Class