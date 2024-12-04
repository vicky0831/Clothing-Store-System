Imports Microsoft.Data.SqlClient

Public Class Form3

    Dim connectionString As String = "Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
    Dim currentUserID As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        If username = "vicky" And password = "0000" Then 'Change the admin username and password
            ' Redirect to the admin-specific page
            Dim adminPage As New Form5()
            adminPage.Show()
            Me.Hide()
            Return
        End If

        Dim query As String = "SELECT ID FROM users WHERE Username COLLATE Latin1_General_BIN = @Username AND Password COLLATE Latin1_General_BIN = @Password"


        Using connection As New SqlConnection(connectionString)
            ' Create the command and set parameters to prevent SQL injection
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            Try
                ' Open the connection
                connection.Open()

                ' Execute the query and check if a match is found
                Dim result As Object = command.ExecuteScalar()

                If result IsNot Nothing Then
                    currentUserID = Convert.ToInt32(result) ' Store the UserID
                    ' MessageBox.Show("Login successful!")
                    ' Open the next form (e.g., MainForm)
                    Dim homePage As New Form4(currentUserID)
                    homePage.Show()
                    Me.Hide()
                Else
                    ' If no match, show error message and prompt to retry
                    MessageBox.Show("Incorrect username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As SqlException
                ' Handle any database-related errors
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        PictureBox2.Left = Me.ClientSize.Width ' Start off-screen to the right
        Timer1.Start() ' Start the scrolling timer
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Left -= 5
        ' If the PictureBox goes off-screen to the left, reset it back to the right
        If PictureBox2.Left + PictureBox2.Width < 0 Then
            PictureBox2.Left = Me.ClientSize.Width ' Move back to the right side of the form
        End If
    End Sub
End Class