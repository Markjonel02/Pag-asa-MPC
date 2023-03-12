Public Class FRMMAIN
    Private Sub FRMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ctrldash As Integer
        For ctrldash = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrldash)
        Next
        Dim D As New USRCRTLDASHBOARD()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BunifuToolTip1_Popup(sender As Object, e As Bunifu.UI.WinForms.BunifuToolTip.PopupEventArgs) Handles ExitTTP.Popup

    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim msg = MsgBox("Are you sure you want to exit the application", vbQuestion + vbYesNo, "System Exit!")

        If msg = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTNDASH_Click(sender As Object, e As EventArgs) Handles BTNDASH.Click
        'This will usrctrl to main panel 

        Dim ctrldash As Integer
        For ctrldash = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrldash)
        Next
        Dim D As New USRCRTLDASHBOARD()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub



    Private Sub BTNMP_Click(sender As Object, e As EventArgs) Handles BTNMP.Click
        Dim ctrlmem As Integer
        For ctrldash = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrlmem)
        Next
        Dim D As New USRCTRLMEMBERSHIPAPP()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNLOAN_Click(sender As Object, e As EventArgs) Handles BTNLOAN.Click
        Dim ctrlloan As Integer
        For ctrldash = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrlloan)
        Next
        Dim D As New USRCRTLLOAN()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub
End Class