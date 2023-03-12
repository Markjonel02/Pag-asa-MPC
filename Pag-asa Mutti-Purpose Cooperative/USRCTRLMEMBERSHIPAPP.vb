Public Class USRCTRLMEMBERSHIPAPP
    Private Sub USRCTRLMEMBERSHIPAPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PNLMEMAPP_Click(sender As Object, e As EventArgs) Handles PNLMEMAPP.Click
        SCSCROLL.BindTo(PNLMEMAPP)
    End Sub


End Class
