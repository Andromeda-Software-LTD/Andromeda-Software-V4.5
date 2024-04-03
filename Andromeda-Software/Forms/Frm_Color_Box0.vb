Imports System.Drawing.Drawing2D
Public Class 问想答英式文允份英份丢价的天文文英延个间份是书英用谢谢什方个
     Private BoxTitlePaintEventArgsWait As Boolean = False
     Private Sub SpyStyle()
        BoxTitle.BackColor = SpySettings.DefaultColor_Background
        Me.BackColor = SpySettings.DefaultColor_Background
        For Each gr As Button In Me.Controls.OfType(Of Button)()
            gr.BackColor = SpySettings.DefaultColor_Foreground
            gr.ForeColor = SpySettings.DefaultColor_Background
        Next
        For Each gr As CheckBox In Me.Controls.OfType(Of CheckBox)()
            gr.BackColor = SpySettings.DefaultColor_Background
            gr.ForeColor = SpySettings.DefaultColor_Foreground
        Next
    End Sub
    Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub Color_Box0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         SpyStyle()
         BTN_OK.Font = Frm_Config_Settings.f
         Me.TopMost = True
        Programmatically = True
         Bmp = New Bitmap(1, 1)
        G = Graphics.FromImage(Bmp)
         If clrSAVE.po1 = Nothing Then
            p0 = New Point(1, 1)
        Else
            p0 = clrSAVE.po1
        End If
         Dim obj As Object() = {p0.X, p0.Y}
        _Update0(obj, C_Box2)
        C_Box2.Invalidate()
         If clrSAVE.po2 = Nothing Then
            p1 = New Point(1, 1)
        Else
            p1 = clrSAVE.po2
        End If
         Dim obj1 As Object() = {p1.X, p1.Y}
        _Update1(obj1, C_Box0)
        C_Box0.Invalidate()
         Programmatically = False
         BoxTitlePaintEventArgsWait = True
     End Sub
     Public Programmatically As Boolean = False
     Public default_color As Color = Color.Yellow
     Public _new_color As Color = Color.Yellow
     Private Bmp As Bitmap
     Private G As Graphics
     Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
     Private Const VK_LBUTTON = &H1
     Private p1 As New Point(0, 0)
     Private s_mouse1 As Boolean = False
     Private p0 As Point = Nothing
     Private s_mouse0 As Boolean = False
     Private Sub C_Box0_Paint(sender As Object, e As PaintEventArgs) Handles C_Box0.Paint
         Dim G As Graphics = e.Graphics
        With G
            Dim Rect0 As New Rectangle(0, 0, C_Box0.Width, C_Box0.Height)
            Using LB0 As New LinearGradientBrush(Rect0, Color.White, default_color, LinearGradientMode.Horizontal)
                .FillRectangle(LB0, Rect0)
            End Using
            Dim Rect1 As New Rectangle(0, 0, C_Box0.Width, C_Box0.Height)
            Using LB1 As New LinearGradientBrush(Rect1, Color.Transparent, Color.Black, LinearGradientMode.Vertical)
                .FillRectangle(LB1, Rect1)
                Dim h As Integer = C_Box0.Height - 7
                .DrawLine(New Pen(Color.Black, 5), 0, h, C_Box0.Width, h)
            End Using
        End With
         If Not p1 = Nothing Then
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            Dim r As Rectangle
            If s_mouse1 Then
                r = New Rectangle(p1.X - 7, p1.Y - 7, 14, 14)
            Else
                r = New Rectangle(p1.X - 5, p1.Y - 5, 10, 10)
            End If
             Dim x As New Pen(Color.Black, 1)
            If CInt(C_Box0.Height / 2) < p1.Y Then
                x = New Pen(Color.White, 1)
            End If
             e.Graphics.DrawEllipse(x, r)
             Dim b = New Bitmap(C_Box0.ClientSize.Width, C_Box0.Height)
            C_Box0.DrawToBitmap(b, C_Box0.ClientRectangle)
            If b.Width > p1.X And b.Height > p1.Y Then
                Dim colour As Color = b.GetPixel(p1.X, p1.Y)
                b.Dispose()
                _new_color = colour
            End If
         End If
         C_Box3.BackColor = _new_color
         Title({C_Box3.BackColor.R, C_Box3.BackColor.G, C_Box3.BackColor.B})
         C_Box3.Refresh()
     End Sub
     Private Sub C_Box0_MouseDown(sender As Object, e As MouseEventArgs) Handles C_Box0.MouseDown
        s_mouse1 = True
        Dim obj As Object() = {e.X, e.Y}
        _Update1(obj, C_Box0)
    End Sub
     Private Sub _Update1(ByVal e As Object(), ByVal c As Control)
        If s_mouse1 Or Programmatically Then
            If Not e(0) > c.Width - 7 And Not e(0) < 1 And Not e(1) > c.Height - 7 And Not e(1) < 1 Then
                p1.X = e(0)
                p1.Y = e(1)
                clrSAVE.po2 = New Point(p1.X, p1.Y)
                Dim b = New Bitmap(c.ClientSize.Width, c.Height)
                c.DrawToBitmap(b, c.ClientRectangle)
                If b.Width > e(0) And b.Height > e(1) Then
                    Dim colour As Color = b.GetPixel(e(0), e(1))
                    b.Dispose()
                    _new_color = colour
                    c.Refresh()
                End If
                c.Invalidate()
            End If
        End If
    End Sub
    Private Sub C_Box0_MouseMove(sender As Object, e As MouseEventArgs) Handles C_Box0.MouseMove
        If s_mouse1 Then
             If C_Box0.Tag = Nothing Then
                Cursor.Clip = C_Box0.RectangleToScreen(New Rectangle(1, 1, C_Box0.Width - 7, C_Box0.Height - 7))
                C_Box0.Tag = True
            End If
             Dim obj As Object() = {e.X, e.Y}
            _Update1(obj, C_Box0)
         End If
     End Sub
     Private Sub C_Box0_MouseUp(sender As Object, e As MouseEventArgs) Handles C_Box0.MouseUp
        s_mouse1 = False
        Cursor.Clip = Nothing
        C_Box0.Tag = Nothing
        C_Box0.Invalidate()
    End Sub
     Private Sub C_Box2_Paint(sender As Object, e As PaintEventArgs) Handles C_Box2.Paint
         Using Rect0 As New Drawing2D.LinearGradientBrush(New Rectangle(New Point(0, 0), C_Box2.ClientSize), Color.Red, Color.Blue, 0)
            Dim cb As New ColorBlend
            cb.Positions = New Single() {0, 0.1F, 0.284F, 0.5F, 0.668F, 0.9F, 1}
            cb.Colors = New Color() {Color.Purple, Color.Red, Color.Yellow, Color.Lime, Color.Cyan, Color.Blue, Color.LightBlue}
            Rect0.InterpolationColors = cb
            e.Graphics.FillRectangle(Rect0, C_Box2.ClientRectangle)
        End Using
         If Not p0 = Nothing Then
             e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
             Dim r As New Rectangle(p0.X - 3, -1, 5, C_Box2.Height - 3)
             Dim pn As New Drawing.Pen(Color.Black, 1)
             e.Graphics.DrawRectangle(pn, r)
         End If
     End Sub
     Private Sub C_Box2_MouseDown(sender As Object, e As MouseEventArgs) Handles C_Box2.MouseDown
        s_mouse0 = True
        Dim obj As Object() = {e.X, e.Y}
        _Update0(obj, C_Box2)
    End Sub
    Private Sub _Update0(ByVal e As Object(), ByVal c As Control)
         If s_mouse0 Or Programmatically Then
            If Not e(0) > c.Width - 7 And Not e(0) < 1 And Not e(1) > c.Height - 7 And Not e(1) < 1 Then
                p0.X = e(0)
                p0.Y = e(1)
                clrSAVE.po1 = New Point(p0.X, p0.Y)
                Dim b = New Bitmap(c.ClientSize.Width, c.Height)
                c.DrawToBitmap(b, c.ClientRectangle)
                If b.Width > e(0) And b.Height > e(1) Then
                    Dim colour As Color = b.GetPixel(e(0), e(1))
                    b.Dispose()
                    default_color = colour
                    C_Box0.Invalidate()
                End If
                c.Invalidate()
            End If
        End If
    End Sub
    Private Sub C_Box2_MouseMove(sender As Object, e As MouseEventArgs) Handles C_Box2.MouseMove
        If s_mouse0 Then
             If C_Box2.Tag = Nothing Then
                Cursor.Clip = C_Box2.RectangleToScreen(New Rectangle(1, 1, C_Box2.Width - 7, C_Box2.Height - 7))
                C_Box2.Tag = True
            End If
             Dim obj As Object() = {e.X, e.Y}
            _Update0(obj, C_Box2)
         End If
     End Sub
     Private Sub C_Box2_MouseUp(sender As Object, e As MouseEventArgs) Handles C_Box2.MouseUp
        s_mouse0 = False
        Cursor.Clip = Nothing
        C_Box2.Tag = Nothing
    End Sub
     Private Sub ti_Tick(sender As Object, e As EventArgs) Handles ti.Tick
         Try
            G.CopyFromScreen(New Point(Cursor.Position), Point.Empty, Bmp.Size)
             C_Box3.BackColor = Color.FromArgb(Bmp.GetPixel(0, 0).R, Bmp.GetPixel(0, 0).G, Bmp.GetPixel(0, 0).B)
             Title({C_Box3.BackColor.R, C_Box3.BackColor.G, C_Box3.BackColor.B})
         Catch ex As Exception
         End Try
     End Sub
     Private TEXT_COLOR As String = "null"
    Private Sub Title(ByVal obj As Object())
         TEXT_COLOR = String.Format("RGB:({0},{1},{2})", obj(0), obj(1), obj(2))
         BoxTitle.Refresh()
     End Sub
     Private Sub CK1_MouseDown(sender As Object, e As MouseEventArgs) Handles CK1.MouseDown
        ti.Enabled = True
        CK1.Checked = True
    End Sub
     Private Sub CK1_MouseUp(sender As Object, e As MouseEventArgs) Handles CK1.MouseUp
        ti.Enabled = False
        CK1.Checked = False
    End Sub
     Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub Color_Box0_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        BoxTitle.Invalidate()
    End Sub
    Private Sub Color_Box0_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        BoxTitle.Invalidate()
    End Sub
    Private Sub BoxTitle_Resize(sender As Object, e As EventArgs) Handles BoxTitle.Resize
        BoxTitle.Invalidate()
    End Sub
    Private Sub C_Box0_Click(sender As Object, e As EventArgs) Handles C_Box0.Click
     End Sub
     Private Sub BoxTitle_Paint(sender As Object, e As PaintEventArgs) Handles BoxTitle.Paint
         If BoxTitlePaintEventArgsWait Then
             Dim _CLR As String = TEXT_COLOR
             Dim clr As Color = SpySettings.DefaultColor_Foreground
             e.Graphics.DrawLine(New Pen(Color.FromArgb(50, clr.R, clr.G, clr.B)), 0, 1, BoxTitle.Width, 1)
             Dim ColorFont As Brush
             ColorFont = New SolidBrush(SpySettings.DefaultColor_Foreground)
             Dim ColorBack As Brush = New SolidBrush(Color.FromArgb(170, BoxTitle.BackColor.R, BoxTitle.BackColor.G, BoxTitle.BackColor.B))
             Dim TextRender0 As Size = TextRenderer.MeasureText(_CLR, Frm_Config_Settings.f)
             Dim rect0 As New Rectangle(0, 2, BoxTitle.Width, TextRender0.Height + 5)
             e.Graphics.FillRectangle(New Pen(ColorBack).Brush, rect0)
             e.Graphics.DrawString(_CLR, Frm_Config_Settings.f, ColorFont, 0, 2)
             Dim MeSize As Size = TextRenderer.MeasureText("S", Frm_Config_Settings.f)
            If Not BoxTitle.Height = MeSize.Height + 3 Then
                BoxTitle.Height = MeSize.Height + 3
            End If
         End If
     End Sub
     Private Sub BoxTitle_Click(sender As Object, e As EventArgs) Handles BoxTitle.Click
     End Sub
     Private Sub C_Box2_Click(sender As Object, e As EventArgs) Handles C_Box2.Click
     End Sub
End Class