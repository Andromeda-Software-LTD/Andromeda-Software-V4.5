Public Class Frm_MainSettings
     Sub New()
         InitializeComponent()
      End Sub
    Private Sub CypherSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
           GetValues()
       End Sub
    Public Sub GetValues()
        Preform.Text = Preform.Items(Preform.Items.IndexOf(My.Settings.performance))
        Notifi.Text = Notifi.Items(Notifi.Items.IndexOf(My.Settings.show_alert))
        logit.Text = logit.Items(logit.Items.IndexOf(My.Settings.LOG))
        saveit.Text = saveit.Items(saveit.Items.IndexOf(My.Settings.Saving_data))
        FMI.Text = FMI.Items(FMI.Items.IndexOf(My.Settings.FM_IC_Size))
        FMQ.Text = My.Settings.ImageQualty
    End Sub
     Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.performance = "Normal"
        My.Settings.show_alert = "Yes"
        My.Settings.LOG = "Yes"
        My.Settings.Saving_data = "Yes"
        My.Settings.FM_IC_Size = "Small"
        My.Settings.ImageQualty = "20"
        GetValues()
    End Sub
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
         My.Settings.performance = Preform.Text
        My.Settings.show_alert = Notifi.Text
        My.Settings.LOG = logit.Text
        My.Settings.Saving_data = saveit.Text
        My.Settings.FM_IC_Size = FMI.Text
        My.Settings.ImageQualty = FMQ.Text
         My.Settings.Save()
         MsgBox("Saved Changes will be made after restarting the program", MsgBoxStyle.Information, Frm_Config_Settings.nameRAT)
         Me.Close()
    End Sub
End Class