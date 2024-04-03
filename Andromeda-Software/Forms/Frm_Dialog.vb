Imports System.Windows.Forms
 Public Class Frm_Dialog
     Public Title As String
    Public TheText As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.TheText = Me.TheText
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
     Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
     Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Mytitle.Text = Title
     End Sub

    Private Sub Mytext_TextChanged(sender As Object, e As EventArgs) Handles Mytext.TextChanged

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub
End Class
