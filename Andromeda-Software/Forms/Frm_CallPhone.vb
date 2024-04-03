Public Class Frm_CallPhone
     Private _keyback As Boolean = False
    Public _Call As String = "call"
    Public Title As String = "null"
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
    Private Sub CallPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Me.Icon = New Icon(Frm_Config_Settings.res_Path & "\Icons\win\18.ico")
         Me.CMenu.Renderer = New Frm_Config_Option
         TextBox1.ContextMenuStrip = Me.CMenu
         SpyStyle()
         Dim F0ntSize As Integer = My.Settings.FontSize
         If IsFontInstalled("Wingdings 3") Then
             b_DEL.Font = New System.Drawing.Font("Wingdings 3", F0ntSize, System.Drawing.FontStyle.Regular)
             b_DEL.Text = "…"
         Else
             b_DEL.Text = "<"
         End If
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
    End Sub
    Public Shared Function IsFontInstalled(ByVal FontName As String) As Boolean
        Using TestFont As Font = New Font(FontName, 10)
            Return CBool(String.Compare(FontName, TestFont.Name, StringComparison.InvariantCultureIgnoreCase) = 0)
        End Using
    End Function
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
     Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        TextBox1.Text &= "1"
    End Sub
     Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        TextBox1.Text &= "2"
    End Sub
     Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        TextBox1.Text &= "3"
    End Sub
     Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        TextBox1.Text &= "4"
    End Sub
     Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        TextBox1.Text &= "5"
    End Sub
     Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        TextBox1.Text &= "6"
    End Sub
     Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        TextBox1.Text &= "7"
    End Sub
     Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        TextBox1.Text &= "8"
    End Sub
     Private Sub b9_Click(sender As Object, e As EventArgs) Handles b9.Click
        TextBox1.Text &= "9"
    End Sub
     Private Sub b0_Click(sender As Object, e As EventArgs) Handles b0.Click
        TextBox1.Text &= "0"
    End Sub
     Private Sub b_DEL_Click(sender As Object, e As EventArgs) Handles b_DEL.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)
        End If
    End Sub
    Private Sub B_star_Click(sender As Object, e As EventArgs) Handles B_star.Click
        TextBox1.Text &= "*"
    End Sub
    Private Sub B_hash_Click(sender As Object, e As EventArgs) Handles B_hash.Click
        TextBox1.Text &= "#"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _Call = "call"
        Me.DialogResult = DialogResult.OK
    End Sub
     Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
     End Sub
     Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If _keyback Then
             e.Handled = False
             Return
         End If
         Dim sKeys As String = "0123456789,*#+"
         If Not sKeys.Contains(e.KeyChar.ToString()) Then
             e.Handled = True
         End If
     End Sub
     Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
         If e.KeyCode = Keys.Back Then
             _keyback = True
         Else
             _keyback = False
         End If
     End Sub
     Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub
     Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub
     Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Dim sKeys As String = "0123456789,*#+"
        If My.Computer.Clipboard.ContainsText Then
            Dim tx As String = My.Computer.Clipboard.GetText
            If Not tx.Length > 1500 Then
                For Each i In tx
                    If Not sKeys.ToString.Contains(i) Then
                        GoTo skip
                    End If
                Next
            End If
        End If
        TextBox1.Paste()
 skip:
     End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class