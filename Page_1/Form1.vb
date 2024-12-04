Imports System.Runtime.ConstrainedExecution

Public Class Form1

    Private titleText As String = "FROD JERRY"
    Private words As String()
    Private titleText_quota As String = """Life isn't perfect, but your outfit can be."""
    Private words_quota As String()
    Private wordIndex As Integer = 0
    Private wordIndex1 As Integer = 0
    Private tracker_word As Integer = 0


    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        words = titleText.Split(" "c)
        words_quota = titleText_quota.Split(" "c)
        Label1.Text = ""
        Label4.Text = ""
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If wordIndex < words.Length Then
            Label1.Text &= words(wordIndex) & " "
            wordIndex += 1
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        PictureBox1.Visible = True
        ' Stop the timer to prevent it from ticking repeatedly
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If wordIndex1 < words_quota.Length Then
            Label4.Text &= words_quota(wordIndex1) & " "
            wordIndex1 += 1
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim secondPage As New Form2()
        secondPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Page_3 As New Form3()
        Page_3.Show()
        Me.Hide() ' Close the current form (Form2)
    End Sub

End Class
