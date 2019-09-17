Imports System.IO
Imports System.Net
Imports System.Media
Imports System
Imports System.ComponentModel

Public Class MLauncher
    Private InstalledVersion As String = Application.ProductVersion
    Private UpdateLink As String ' = "insert url here."
    Private UpToDate As String = "UpToDate"
    Private Outdated As String = "Outdated"
    Private LatestVersion As String
    Private MAJ As New WebClient

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles XLink.LinkClicked
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MiniLink.LinkClicked
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CLForm.Show()
    End Sub
    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BunifuTransition1.HideSync(ErrCard)
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles GMODPlay.Click
        Dim p() As Process
        p = Process.GetProcessesByName("hl2")
        If p.Count > 0 Then
            BunifuTransition1.ShowSync(ErrCard)
            ErrDes.Text = ("hl2.exe appears to already be opened." + vbNewLine + vbNewLine + "Is hl2.exe not opened? - Right click your Taskbar then open Task Manager, Extend more details, Check and see if there's a instance of hl2.exe running, if so, terminate it." + vbNewLine + vbNewLine + "If error still presists, Contact Rondell#5907 on Discord for help.")
            SystemSounds.Hand.Play()
        Else
            Process.Start("steam://connect/208.103.169.58:27015")
        End If

    End Sub
    Private Sub MLauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdPane.Dock = DockStyle.Fill
        BunifuCustomLabel6.Text = "Version " + Application.ProductVersion
        If My.Computer.Network.IsAvailable = False Then
            GMODCard.Hide()
            RustCard.Hide()
            Panel7.Show()
        End If
        If My.Settings.whatsnew = "True" Then
            whatsnew.Show()
            whatsnew.Dock = DockStyle.Fill
        End If

    End Sub
    Private Sub PROCESSCHK_Tick(sender As Object, e As EventArgs) Handles PROCESSCHK.Tick
        Dim p() As Process
        p = Process.GetProcessesByName("hl2")
        If p.Count > 0 Then
            GameInfoLabel.Show()
        Else
            GameInfoLabel.Hide()
        End If

        Dim p2() As Process
        p2 = Process.GetProcessesByName("RustClient")
        If p2.Count > 0 Then
            infolabel2.Show()
        Else
            infolabel2.Hide()
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Settings.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateCheck.RunWorkerAsync()
        Timer1.Stop()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=1861050128")
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Process.Start("https://monolithservers.com/forums/")
    End Sub

    Private Sub LinkLabel5_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://monolithservers.com/store")
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Process.Start("https://monolithservers.com/servers")
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Process.Start("https://discord.gg/uj6NRBS")
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Process.Start("http://discord.gg/YQcjJtD")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Process.Start("https://steamcommunity.com/groups/MonolithServers")
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/announcements.4/")
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/rules-information.5/")
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/updates.43/")
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/player-reports.33/")
    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/staff-reports.37/")
    End Sub

    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/refund-requests.25/")
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        Process.Start("https://monolithservers.com/forums/forums/appeals.48/")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles RustPlay.Click
        Dim p() As Process
        p = Process.GetProcessesByName("RustClient")
        If p.Count > 0 Then

            BunifuTransition1.ShowSync(ErrCard)
            ErrDes.Text = ("Rust appears to already be opened." + vbNewLine + vbNewLine + "Is Rust not opened? - Right click your Taskbar then open Task Manager, Extend more details, Check and see if there's a instance of rust.exe running, if so, terminate it." + vbNewLine + vbNewLine + "If error still presists, Contact Rondell#5907 on Discord for help.")
            SystemSounds.Hand.Play()
        Else
            If RustPlay.Text = "Play MonoRust" Then
                If RustMP.selectedIndex = "0" Then
                    Process.Start("steam://connect/208.103.169.89:28015")
                ElseIf RustMP.selectedIndex = "1" Then
                    Process.Start("steam://connect/208.103.169.89:28016")
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If My.Computer.Keyboard.ShiftKeyDown = True And My.Computer.Keyboard.AltKeyDown = True Then
            My.Settings.Reset()
            Application.Restart()
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        Me.Controls.Clear()
        InitializeComponent()
        Me.MLauncher_Load(e, e)
    End Sub


    Private Sub UpdateCheck_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles UpdateCheck.DoWork

        Try
            LatestVersion = MAJ.DownloadString(UpdateLink)
            If LatestVersion.Contains(InstalledVersion) Then
                e.Result = UpToDate
            Else
                e.Result = Outdated
            End If

            MAJ.Dispose()
        Catch ex As Exception
            e.Result = ex.Message
        End Try
    End Sub

    Private Sub UpdateCheck_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles UpdateCheck.RunWorkerCompleted
        Select Case e.Result
            Case Outdated
                BunifuTransition1.ShowSync(UpdPane)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Process.Start(Application.StartupPath + "\MonoUpdater.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox("Make sure the Monolith Launcher.exe is in the same Directory as the MonoUpdater.exe then try again.")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BunifuTransition1.HideSync(UpdPane)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.whatsnew = "False"
        My.Settings.Save()
        My.Settings.Reload()
        BunifuTransition1.HideSync(whatsnew)
    End Sub
End Class
