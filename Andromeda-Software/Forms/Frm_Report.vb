Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
 Public Class Frm_Report
     Public Items As List(Of Notifications)
     Public WithEvents Bgworker As ComponentModel.BackgroundWorker
     Private MeHand As IntPtr
     Private ColorBack As Color = SpySettings.DefaultColor_Background
     Private ColorFont As Color = SpySettings.DefaultColor_Foreground
     Private ColorBorder As Color = Color.FromArgb(255, 35, 35)
     Private sizeFontHeight As Integer = 3
     Private sizeFontWidth As Integer = 5
     Private sizeHeightSTOP As Integer = 3
     Private timeOut As Integer = 10
     Private status As Boolean
     Public Async Sub AddItem(ByVal img As Bitmap, ByVal [Text] As String)
         Await Task.Factory.StartNew(Function() Add(img, [Text]), TaskCreationOptions.None)
     End Sub
     Private Function Add(ByVal img As Bitmap, ByVal [Text] As String)
         SyncLock sockets.Data.SyncNotifications
             If Me.Items.Count >= 60 Then
                 Me.Items.RemoveAt(0)
             End If
             Try
                 Dim item As New Notifications With {.FLAG = img, .TEXT = [Text]}
                 Me.Items.Add(item)
                 If Me.Items.Count > 0 And Not Me.status Then
                     Me.MyShow()
                 End If
             Catch ex As System.InvalidOperationException
             End Try
         End SyncLock
         Return Nothing
     End Function
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MeHand = Me.Handle
         Me.status = False
         Me.Items = New List(Of Notifications)
         Dim x, y As Integer
         If SpySettings.LOCATION_NOTICETIGHT = "Right" Then
             x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
         Else
             x = 5
         End If
         y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
         Me.Location = New Point(x, y)
         Me.Bgworker = New ComponentModel.BackgroundWorker
         If Not Bgworker.IsBusy Then
             Bgworker.RunWorkerAsync()
         End If
     End Sub
     Public Sub MyShow()
         Me.status = True
     End Sub
    Public Sub MyHide()
         Me.status = False
    End Sub
     Private Sub Worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Bgworker.DoWork
         Do While True
             Threading.Thread.Sleep(1)
             Try
                 Threading.Thread.Sleep(25)
                 If Me.Items.Count > 0 And Me.status Then
                     Try
                         SyncLock sockets.Data.SyncNotifications
                             Dim image As New Bitmap(Me.Width, Me.Height)
                             Dim G As Graphics = Graphics.FromImage(image)
                             G.SmoothingMode = SmoothingMode.AntiAlias
                            G.InterpolationMode = InterpolationMode.HighQualityBicubic
                            G.PixelOffsetMode = PixelOffsetMode.HighQuality
                            G.CompositingQuality = CompositingQuality.GammaCorrected
                            G.CompositingMode = CompositingMode.SourceOver
                            For Each Notice In Me.Items
                                If Notice.sizeHeight <= sizeHeightSTOP Then
                                    Notice.sizeHeight = sizeHeightSTOP
                                Else
                                    Dim count As Integer = Me.Items.Count
                                    If count > 60 Then
                                        Notice.sizeHeight = sizeHeightSTOP
                                    ElseIf count > 20 Then
                                        Notice.sizeHeight = Notice.sizeHeight + -14
                                    ElseIf count > 15 Then
                                        Notice.sizeHeight = Notice.sizeHeight + -8
                                    ElseIf count > 10 Then
                                        Notice.sizeHeight = Notice.sizeHeight + -4
                                    ElseIf count > 5 Then
                                        Notice.sizeHeight = Notice.sizeHeight + -2
                                    Else
                                        Notice.sizeHeight = Notice.sizeHeight + -1
                                    End If
                                    If Notice.sizeHeight <= sizeHeightSTOP Then
                                        Notice.sizeHeight = sizeHeightSTOP
                                    End If
                                End If
                                Dim sizeText As New SizeF
                                sizeText = G.MeasureString(Notice.TEXT, Frm_Config_Settings.f)
                                Dim RectY As Integer = sizeText.Height + sizeFontHeight
                                Dim rect As New Rectangle(0, Notice.sizeHeight, Me.Width - 10, RectY)
                                Dim x As New Drawing2D.LinearGradientBrush(rect, ColorBack, ColorBack, Drawing2D.LinearGradientMode.BackwardDiagonal)
                                Dim gp As Drawing2D.GraphicsPath = RoundRect(rect, If(SpySettings.NOTI_Round = "Yes", 12, 1))
                                G.FillPath(x, gp)
                                rect = New Rectangle(0, (Notice.sizeHeight - sizeFontHeight), 0, 0)
                                ControlPaint.DrawLockedFrame(G, rect, False)
                                If SpySettings.FLAGS_Visible = "Yes" Then
                                    Dim arguments As Object() = New Object(2 - 1) {}
                                    arguments(0) = Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Notice.FLAG.Clone)
                                    Dim point As New Point(Me.Width - 10 - Notice.FLAG.Width - 7, Notice.sizeHeight + sizeFontHeight)
                                    arguments(1) = point
                                    CompilerServices.NewLateBinding.LateCall(G, Nothing, "DrawImage", arguments, Nothing, Nothing, Nothing, True)
                                End If
                                G.DrawString(Notice.TEXT, Frm_Config_Settings.f, New SolidBrush(ColorFont), sizeFontWidth, Notice.sizeHeight + sizeFontHeight)
                                If Notice.sizeHeight > Me.Height - 50 Then
                                    Exit For
                                End If
                            Next
GOBACK:
                            Dim classs As Notifications
                            For Each classs In Me.Items
                                If Not classs.startTime Then
                                    classs.start = System.DateTime.Now().AddSeconds(timeOut)
                                    classs.startTime = True
                                End If
                                Dim result As Integer = DateTime.Compare(classs.start, System.DateTime.Now())
                                If result < 0 Then
                                    Me.Items.Remove(classs)
                                    GoTo GOBACK
                                End If
                            Next
                             If Me.Items.Count = 0 And Me.status Then
                                 image = Nothing
                                 Me.MyHide()
                             End If
                             G.Flush(Drawing2D.FlushIntention.Sync)
                             G.Dispose()
                             UpdateWindow(image)
                        End SyncLock
                     Catch ex As Exception
                     End Try
                 End If
             Catch ex As Exception
             End Try
         Loop
     End Sub
    Private Async Sub Report_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
         Await Task.Factory.StartNew(Function() AllClear(), TaskCreationOptions.None)
     End Sub
    Private Function AllClear()
         SyncLock sockets.Data.SyncNotifications
             Me.Items.Clear()
             BitmapClean()
             MyHide()
         End SyncLock
         Return Nothing
     End Function
    Public Function RoundRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As Drawing2D.GraphicsPath
         Dim gp As New Drawing2D.GraphicsPath
        With Rectangle
            gp.AddArc(.X + .Width - Curve, .Y, Curve, Curve, 270, 90)
            gp.AddArc(.X + .Width - Curve, .Y + .Height - Curve, Curve, Curve, 0, 90)
            gp.AddArc(.X, .Y + .Height - Curve, Curve, Curve, 90, 90)
            gp.AddArc(.X, .Y, Curve, Curve, 180, 90)
            gp.CloseFigure()
        End With
        Return gp
    End Function
     Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If Not Me.DesignMode Then
                cp.ExStyle = cp.ExStyle Or NativeMethods.WS_EX_LAYERED
            End If
            Return cp
        End Get
    End Property
     Public Sub BitmapClean()
        If Me.IsDisposed OrElse Me.Width <= 0 OrElse Me.Height <= 0 Then
            Return
        End If
        Dim c As Bitmap = New Bitmap(Me.Width, Me.Height, PixelFormat.Format32bppPArgb)
        UpdateWindow(c)
    End Sub
    Public Sub UpdateWindow(ByVal bm As Bitmap)
         If Me.IsDisposed OrElse Me.Width <= 0 OrElse Me.Height <= 0 Then
            Return
        End If
         Using backBuffer As New Bitmap(Me.Width, Me.Height, PixelFormat.Format32bppPArgb)
             Using gr As Graphics = Graphics.FromImage(backBuffer)
                 gr.SmoothingMode = SmoothingMode.AntiAlias
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality
                gr.CompositingQuality = CompositingQuality.GammaCorrected
                gr.CompositingMode = CompositingMode.SourceOver
                 If bm IsNot Nothing Then
                     gr.DrawImage(bm, New Rectangle(0, 0, bm.Width, bm.Height))
                 End If
                 Dim screenDC As IntPtr = NativeMethods.GetDC(IntPtr.Zero)
                Dim memDC As IntPtr = NativeMethods.CreateCompatibleDC(screenDC)
                Dim hBitmap As IntPtr = backBuffer.GetHbitmap(Color.FromArgb(0))
                Dim oldBitmap As IntPtr = NativeMethods.SelectObject(memDC, hBitmap)
                 Dim blend As New NativeMethods.BLENDFUNCTION(225)
                Dim ptDst As Point = Me.Location
                Dim szDst As Size = backBuffer.Size
                Dim ptSrc As Point = Point.Empty
                NativeMethods.UpdateLayeredWindow(MeHand, screenDC, ptDst, szDst, memDC, ptSrc, 0, blend, NativeMethods.ULW_ALPHA)
                 NativeMethods.SelectObject(memDC, oldBitmap)
                NativeMethods.DeleteObject(hBitmap)
                NativeMethods.DeleteDC(memDC)
                NativeMethods.DeleteDC(screenDC)
             End Using
         End Using
     End Sub
     Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        If Me.Created Then
            UpdateWindow(Nothing)
        End If
    End Sub
     Protected Overrides Sub OnLocationChanged(ByVal e As EventArgs)
        MyBase.OnLocationChanged(e)
        If Me.Created Then
            UpdateWindow(Nothing)
        End If
    End Sub
     Protected Overrides Sub OnVisibleChanged(ByVal e As EventArgs)
        MyBase.OnVisibleChanged(e)
        If Me.Visible Then
            UpdateWindow(Nothing)
        End If
    End Sub
     Private Sub Report_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Bgworker IsNot Nothing Then
            Bgworker.Dispose()
        End If
    End Sub
End Class
 Public Class NativeMethods
     <DllImport("user32.dll", SetLastError:=True)>
    Friend Shared Function UpdateLayeredWindow(ByVal hwnd As IntPtr, ByVal hdcDst As IntPtr, ByRef pptDst As Point, ByRef psize As Size, ByVal hdcSrc As IntPtr, ByRef pptSrc As Point, ByVal crKey As Int32, ByRef pblend As BLENDFUNCTION, ByVal dwFlags As Int32) As Boolean
    End Function
     <DllImport("user32.dll", SetLastError:=True)>
    Friend Shared Function GetDC(ByVal hWnd As IntPtr) As IntPtr
    End Function
     <DllImport("gdi32.dll")>
    Friend Shared Function CreateCompatibleDC(ByVal dc As IntPtr) As IntPtr
    End Function
     <DllImport("gdi32.dll")>
    Friend Shared Function SelectObject(ByVal hdc As IntPtr, ByVal hObj As IntPtr) As IntPtr
    End Function
     <DllImport("gdi32.dll")>
    Friend Shared Function DeleteDC(ByVal dc As IntPtr) As IntPtr
    End Function
     <DllImport("gdi32.dll")>
    Friend Shared Function DeleteObject(ByVal hObj As IntPtr) As IntPtr
    End Function
     <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Friend Structure BLENDFUNCTION
        Public BlendOp, BlendFlags, SourceConstantAlpha, AlphaFormat As Byte
        Public Sub New(ByVal alpha As Byte)
            Me.BlendOp = AC_SRC_OVER
            Me.BlendFlags = 0
            Me.SourceConstantAlpha = alpha
            Me.AlphaFormat = AC_SRC_ALPHA
        End Sub
    End Structure
     <StructLayout(LayoutKind.Sequential)>
    Friend Structure RECT
        Public Left, Top, Right, Bottom As Int32
    End Structure
     Friend Const WS_EX_LAYERED As Int32 = &H80000
    Friend Const AC_SRC_OVER As Int32 = &H0
    Friend Const AC_SRC_ALPHA As Int32 = &H1
    Friend Const ULW_ALPHA As Int32 = &H2
 End Class
Public NotInheritable Class Notifications
     Public FLAG As Bitmap
     Public TEXT As String
    Public sizeHeight As Integer = My.Forms.Frm_Report.Height
    Public start As System.DateTime
     Public startTime As Boolean
 End Class
 