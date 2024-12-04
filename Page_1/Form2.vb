Imports Microsoft.Web.WebView2.Core
Public Class Form2

    Private WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F5F5F5")

        ' Set label text color
        For Each lbl As Label In Me.Controls.OfType(Of Label)()
            lbl.ForeColor = ColorTranslator.FromHtml("#333333")
        Next

        ' Set button colors
        For Each btn As Button In Me.Controls.OfType(Of Button)()
            btn.BackColor = ColorTranslator.FromHtml("#8B5E3C")
            btn.ForeColor = Color.White
        Next

        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        WebView21.Dock = DockStyle.Fill
        WebView21.ZoomFactor = 0.8
        '  Add WebView2 to the GroupBox Or PictureBox
        PictureBox1.Controls.Add(WebView21)

        'Ensure WebView2 environment Is initialized
        Await WebView21.EnsureCoreWebView2Async(Nothing)

        AddHandler WebView21.CoreWebView2.PermissionRequested, AddressOf WebView21_PermissionRequested

        ' Set a URL to navigate
        WebView21.Source = New Uri("https://maps.app.goo.gl/WM7L8MYf1QCT3AUQA")
    End Sub

    Private Sub WebView21_PermissionRequested(sender As Object, e As CoreWebView2PermissionRequestedEventArgs)
        If e.PermissionKind = CoreWebView2PermissionKind.Geolocation Then
            e.State = CoreWebView2PermissionState.Allow ' Allow geolocation permission
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainPage As New Form1()
        mainPage.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

End Class