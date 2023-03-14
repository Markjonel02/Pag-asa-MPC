Imports Bunifu.UI.WinForms

Public Class USRCRTLMEMBERGIFT


    Private Sub PNLMEM_Click(sender As Object, e As EventArgs) Handles PNLMEM.Click
        'PNLMEM.AutoScroll = True
        'PNLMEM.VerticalScroll.Visible = False Or PNLMEM.HorizontalScroll.Visible = False
        SCSCROLL.BindTo(PNLMEM)
    End Sub



End Class
