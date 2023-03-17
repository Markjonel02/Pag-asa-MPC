﻿Public Class FRMMAIN
    Private Sub FRMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this will disable the visibility of panel 
        FLPNLLOANDROP.Visible = False
        FLPNLLOAN.Visible = False


        Dim ctrldash As Integer
        For ctrldash = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrldash)
        Next
        Dim D As New USRCRTLDASHBOARD()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub



    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim msg = MsgBox("Are you sure you want to exit the application", vbQuestion + vbYesNo, "System Exit!")

        If msg = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub




    Private Sub BTNDASHBOARD_Click(sender As Object, e As EventArgs) Handles BTNDASHBOARD.Click
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


    Private Sub BTNLOAN_Click(sender As Object, e As EventArgs) Handles BTNLOAN.Click
        If FLPNLLOANDROP.Visible = True Then
            FLPNLLOANDROP.Visible = False

        Else
            FLPNLLOANDROP.Visible = True

        End If

    End Sub

    Private Sub BTNLOANTRAN_Click(sender As Object, e As EventArgs) Handles BTNLOANTRAN.Click
        If FLPNLLOAN.Visible = True Then
            FLPNLLOAN.Visible = False
        Else
            FLPNLLOAN.Visible = True
        End If


    End Sub



    Private Sub PNLMAINNAV_Click(sender As Object, e As EventArgs) Handles PNLMAINNAV.Click
        BunifuVScrollBar1.BindTo(PNLNAV)

    End Sub

    Private Sub BTNRICEL_Click(sender As Object, e As EventArgs) Handles BTNRICEL.Click

        Dim ctrlrice As Integer
        For ctrlrice = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrlrice)
        Next
        Dim D As New USRCTRLRICELOANAPP()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNGIFT_Click(sender As Object, e As EventArgs) Handles BTNGIFT.Click
        Dim ctrlgift As Integer
        For ctrlgift = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrlgift)
        Next
        Dim D As New USRCRTLMEMBERGIFT()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNUSMNGT_Click(sender As Object, e As EventArgs) Handles BTNUSMNGT.Click
        Dim ctrlmem As Integer
        For ctrlmem = 0 To 0
            PNLMAINDOCKER.Controls.RemoveAt(ctrlmem)
        Next
        Dim D As New UserManagement()
        D.Parent = PNLMAINDOCKER
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BTNABOUT.Click

    End Sub
End Class