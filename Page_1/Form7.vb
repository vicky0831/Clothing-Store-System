Imports System.Drawing.Printing
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class Form7
    Dim _userName As String
    Dim _userAddress As String
    Private cartTable As DataTable
    Private _houseNo As String
    Private _streetName As String
    Private _city As String
    Private _postalCode As String
    Private _state As String

    ' Constructor to pass cart items
    Public Sub New(cart As DataTable, houseNo As String, streetName As String, city As String, postalCode As String, state As String)
        InitializeComponent()

        ' Store the address parts in private fields
        cartTable = cart
        _houseNo = houseNo
        _streetName = streetName
        _city = city
        _postalCode = postalCode
        _state = state

        _userAddress = $"{houseNo}{vbCrLf}" &
               $"{streetName}{vbCrLf}" &
               $"{postalCode} {city}{vbCrLf}" &
               $"{state}"

    End Sub

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Display invoice in a Label
        Dim width As Integer = 150 * 3.77953 ' A4 width in pixels (approx 210mm)
        Dim height As Integer = 297 * 3.77953 ' A4 height in pixels (approx 297mm)
        Dim invoiceBitmap As New Bitmap(width, height)
        Dim totalAmount As Decimal = 0

        ' Create a Graphics object from the Bitmap
        Using graphics As Graphics = Graphics.FromImage(invoiceBitmap)
            ' Set up the graphics to render to the Bitmap
            graphics.Clear(Color.White)

            ' Define fonts and brushes for drawing
            Dim fontHeader As New Font("Segoe UI", 14, FontStyle.Bold)
            Dim fontBody As New Font("Segoe UI", 10, FontStyle.Regular)
            Dim fontFooter As New Font("Segoe UI", 10, FontStyle.Italic)
            Dim brush As Brush = Brushes.Black

            ' Load logo image
            Dim logoImage As System.Drawing.Image = System.Drawing.Image.FromFile("C:\Users\USER\source\repos\Page_1\Page_1\Resources\LOGO_FROD-removebg-preview.png")

            ' Define margins and starting positions
            Dim marginX As Integer = 50
            Dim marginY As Integer = 50
            Dim lineHeight As Integer = 20

            Dim maxWidth As Integer = 600 ' Set the maximum width for the address to fit in the form

            ' Draw the logo if available
            If logoImage IsNot Nothing Then
                graphics.DrawImage(logoImage, marginX, marginY - 5, 100, 100)
            End If

            ' Draw header text
            graphics.DrawString("FROD JERRY", fontHeader, brush, marginX + 120, marginY + 15)
            graphics.DrawString("INVOICE", fontHeader, brush, marginX + 400, marginY + 15)

            Dim query As String = "SELECT FirstName, HouseNo, StreetName, City, Postcode, State FROM users WHERE ID = @userID"
            Using conn As New SqlConnection("Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;")
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", _userID) ' Replace _userID with the actual user ID variable
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            _userName = reader("FirstName").ToString()
                        End If
                    End Using
                End Using
            End Using

            ' Draw invoice details (date, etc.)
            graphics.DrawString($"Date: 25/11/2024", fontBody, brush, marginX, marginY + 120)
            graphics.DrawString($"User Name: {_userName}", fontBody, brush, marginX + 360, marginY + 54)
            '  graphics.DrawString($"User Address: {_userAddress}", fontBody, brush, marginX + 360, marginY + 100)
            Dim addressLines As List(Of String) = WrapText(_userAddress, fontBody, maxWidth, graphics)
            Dim addressStartY As Integer = marginY + 75
            For Each line As String In addressLines
                graphics.DrawString(line, fontBody, brush, marginX + 360, addressStartY)
                addressStartY += lineHeight
            Next
            ' Draw table header
            Dim tableStartY As Integer = marginY + 160
            graphics.DrawString("Product Name", fontBody, brush, marginX, tableStartY)
            graphics.DrawString("Qty", fontBody, brush, marginX + 200, tableStartY)
            graphics.DrawString("Price (RM)", fontBody, brush, marginX + 300, tableStartY)
            graphics.DrawString("Total (RM)", fontBody, brush, marginX + 400, tableStartY)
            graphics.DrawLine(Pens.Black, marginX, tableStartY + 20, width - marginX, tableStartY + 20)

            ' Draw cart items
            Dim currentY As Integer = tableStartY + 30
            '6 Dim totalAmount As Decimal = 0

            For Each row As DataRow In cartTable.Rows
                Dim productName As String = row("Product Name").ToString()
                Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
                Dim price As Decimal = Convert.ToDecimal(row("Price (RM)"))
                Dim total As Decimal = quantity * price
                totalAmount += total

                ' Align the data in columns
                graphics.DrawString(productName, fontBody, brush, marginX, currentY)
                graphics.DrawString(quantity.ToString(), fontBody, brush, marginX + 200, currentY)
                graphics.DrawString($"{price:F2}", fontBody, brush, marginX + 300, currentY)
                graphics.DrawString($"{total:F2}", fontBody, brush, marginX + 400, currentY)
                currentY += lineHeight
            Next

            ' Draw footer
            graphics.DrawLine(Pens.Black, marginX, currentY, width - marginX, currentY)
            graphics.DrawString("Total Amount (RM)", fontBody, brush, 50, currentY + 10)
            graphics.DrawString($"{totalAmount:F2}", fontBody, brush, marginX + 400, currentY + 10)

            currentY += 50
            graphics.DrawString("Thank you for shopping with us!", fontFooter, brush, marginX, currentY)
        End Using

        PictureBox2.Image = invoiceBitmap
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize

        ' Add the PictureBox to the Panel
        Panel1.Controls.Clear()
        Panel1.Controls.Add(PictureBox2)
        Panel1.AutoScroll = True

        Try
            Using conn As New SqlConnection("Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;")
                conn.Open()

                ' Iterate through the rows of cartTable
                For Each row As DataRow In cartTable.Rows
                    ' Prepare the SQL query to insert a record
                    Dim query As String = "INSERT INTO delivery (ID, ProductName, TotalPrice, Quantity, Address) VALUES (@UserID, @ProductName, @Price, @Quantity, @Address)"

                    Using cmd As New SqlCommand(query, conn)
                        ' Add parameters for the query
                        cmd.Parameters.AddWithValue("@UserID", _userID) ' Ensure _userID is properly set
                        cmd.Parameters.AddWithValue("@ProductName", row("Product Name").ToString()) ' Adjust column name as needed
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(row("Price (RM)"))) ' Adjust column name and type
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(row("Quantity"))) ' Adjust column name and type
                        cmd.Parameters.AddWithValue("@Address", _userAddress) ' Ensure _userAddress is properly set

                        ' Execute the query for the current row
                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

        Catch ex As Exception
            ' Handle errors during the insertion process
            MessageBox.Show($"An error occurred while adding delivery records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Try
            ' Define the query to delete all items for the current user
            Dim query As String = "DELETE FROM Cart WHERE UserID = @userID"

            ' Connect to the database
            Using conn As New SqlConnection("Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;")
                Using cmd As New SqlCommand(query, conn)
                    ' Add parameter for the current user
                    cmd.Parameters.AddWithValue("@userID", _userID) ' Replace _userID with the actual user ID variable

                    ' Open the connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show($"An error occurred while clearing the cart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim printDialog As New PrintDialog()

        ' Set the PrintDocument that will handle the actual printing
        printDialog.Document = PrintDocument1

        ' Show the Print Dialog
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' If the user clicks OK, print the document
            Try
                PrintDocument1.Print()
            Catch ex As Exception
                MessageBox.Show($"Error during printing: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage, PrintDocument1.PrintPage
        ' Render the invoice content for printing
        ' Define fonts for header, body, and footer
        Dim fontHeader As New Font("Segoe UI", 16, FontStyle.Bold) ' Slightly larger for better readability
        Dim fontBody As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim fontFooter As New Font("Segoe UI", 10, FontStyle.Italic)
        Dim brush As Brush = Brushes.Black

        ' Load logo image
        Dim logoImage As System.Drawing.Image = System.Drawing.Image.FromFile("C:\Users\USER\source\repos\Page_1\Page_1\Resources\LOGO_FROD-removebg-preview.png")

        ' Define printable area for A4 (794 x 1123 pixels at 96 DPI)
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim pageHeight As Integer = e.PageBounds.Height

        ' Margins for A4 (25.4mm or approximately 96px)
        Dim marginX As Integer = 96
        Dim marginY As Integer = 96
        Dim lineHeight As Integer = 25 ' Line height adjusted for better spacing
        Dim maxWidth As Integer = pageWidth - (marginX * 2)

        ' Draw the logo (adjusted for A4 scaling)
        If logoImage IsNot Nothing Then
            e.Graphics.DrawImage(logoImage, marginX, marginY, 120, 120) ' Logo scaled to fit A4 proportions
        End If

        ' Draw header text
        e.Graphics.DrawString("FROD JERRY", fontHeader, brush, marginX + 150, marginY + 20)
        e.Graphics.DrawString("INVOICE", fontHeader, brush, marginX + 550, marginY + 20)

        ' Draw invoice details (date, etc.)
        Dim detailsStartY As Integer = marginY + 150
        e.Graphics.DrawString($"Date: {DateTime.Now:dd/MM/yyyy}", fontBody, brush, marginX, detailsStartY)
        e.Graphics.DrawString($"User Name: {_userName}", fontBody, brush, marginX + 520, detailsStartY)
        Dim addressLines As List(Of String) = WrapText(_userAddress, fontBody, maxWidth, e.Graphics)
        Dim addressStartY As Integer = detailsStartY + lineHeight
        For Each line As String In addressLines
            e.Graphics.DrawString(line, fontBody, brush, marginX + 505, addressStartY)
            addressStartY += lineHeight
        Next

        ' Draw table header
        Dim tableStartY As Integer = addressStartY + 70
        e.Graphics.DrawString("Product Name", fontBody, brush, marginX, tableStartY)
        e.Graphics.DrawString("Qty", fontBody, brush, marginX + 250, tableStartY)
        e.Graphics.DrawString("Price (RM)", fontBody, brush, marginX + 400, tableStartY)
        e.Graphics.DrawString("Total (RM)", fontBody, brush, marginX + 550, tableStartY)
        e.Graphics.DrawLine(Pens.Black, marginX, tableStartY + 20, pageWidth - marginX, tableStartY + 20)

        ' Draw cart items
        Dim currentY As Integer = tableStartY + 30
        Dim totalAmount As Decimal = 0

        For Each row As DataRow In cartTable.Rows
            Dim productName As String = row("Product Name").ToString()
            Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
            Dim price As Decimal = Convert.ToDecimal(row("Price (RM)"))
            Dim total As Decimal = quantity * price
            totalAmount += total

            ' Align the data in columns
            e.Graphics.DrawString(productName, fontBody, brush, marginX, currentY)
            e.Graphics.DrawString(quantity.ToString(), fontBody, brush, marginX + 250, currentY)
            e.Graphics.DrawString($"{price:F2}", fontBody, brush, marginX + 400, currentY)
            e.Graphics.DrawString($"{total:F2}", fontBody, brush, marginX + 550, currentY)
            currentY += lineHeight
        Next

        ' Draw footer
        currentY += 30
        e.Graphics.DrawLine(Pens.Black, marginX, currentY, pageWidth - marginX, currentY)
        e.Graphics.DrawString("Total Amount (RM)", fontBody, brush, marginX, currentY + 10)
        e.Graphics.DrawString($"{totalAmount:F2}", fontBody, brush, marginX + 550, currentY + 10)

        currentY += 50
        e.Graphics.DrawString("Thank you for shopping with us!", fontFooter, brush, marginX, currentY)

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim cartPage As New Form6
        cartPage.Show()
        Me.Close() ' Close the current form (Form2)s

    End Sub

    Private Function WrapText(inputText As String, font As Font, maxWidth As Integer, graphics As Graphics) As List(Of String)
        Dim words As String() = inputText.Split(" "c)
        Dim lines As New List(Of String)
        Dim currentLine As New StringBuilder()

        For Each word As String In words
            ' Measure the width of the current line plus the new word
            currentLine.Append(word & " ")
            If graphics.MeasureString(currentLine.ToString(), font).Width > maxWidth Then
                ' If it exceeds the max width, add the current line to the list and start a new line
                lines.Add(currentLine.ToString().Trim())
                currentLine.Clear()
                currentLine.Append(word & " ")
            End If
        Next

        ' Add the last line if any
        If currentLine.Length > 0 Then
            lines.Add(currentLine.ToString().Trim())
        End If

        Return lines
    End Function
End Class
