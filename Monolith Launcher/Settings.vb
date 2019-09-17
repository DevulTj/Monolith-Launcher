Imports System.IO

Public Class Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim not1 As Integer
        not1 = MsgBox("You're about to erase your Garry's Mod addons, this doesn't unsubscribe you from your current subscribed addons, do you wanna continue?", vbYesNo)
        If not1 = vbYes Then
            Try
                'steamapps\common\GarrysMod\hl2.exe
                Dim strSteamInstallPath As String = My.Computer.Registry.GetValue(
           "HKEY_CURRENT_USER\Software\Valve\Steam", "InstallPath", Nothing)
                If Directory.Exists(strSteamInstallPath) Then
                    If Directory.Exists(strSteamInstallPath + "\steamapps\common\GarrysMod\garrysmod\addons") Then
                        Directory.Delete(strSteamInstallPath + "\steamapps\common\GarrysMod\garrysmod\addons", True)
                        Directory.CreateDirectory(strSteamInstallPath + "\steamapps\common\GarrysMod\garrysmod\addons")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Tools encountered a Exception." + vbNewLine + vbNewLine + ex.Message)
            End Try
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Delete's your addons in your Garry's Mod Addon Directory." + vbNewLine + vbNewLine + "Any addons you're subscribed to in Steam Workshop will automatically download back when the game loads.")
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Version " + Application.ProductVersion
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Process.Start(Application.StartupPath + "\MonoUpdater.exe")
            Application.Exit()
        Catch ex As Exception
            MsgBox("Make sure the Monolith Launcher.exe is in the same Directory as the MonoUpdater.exe then try again.")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        CLForm.Show()
    End Sub
End Class