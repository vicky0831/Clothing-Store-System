Imports Microsoft.Data.SqlClient

Public Class Form6
    Private connectionString As String = "Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
    Private cartTable As New DataTable()

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure Panel for scrolling
        Panel1.AutoScroll = True

        ' Set up cart table columns
        cartTable.Columns.Add("CartID", GetType(Integer))
        cartTable.Columns.Add("Product Name", GetType(String))
        cartTable.Columns.Add("Quantity", GetType(Integer))
        cartTable.Columns.Add("Price (RM)", GetType(Decimal))

        ' Load cart data
        LoadCartData()

        ' Adjust PictureBox size and repaint
        AdjustPictureBoxSize()
        PictureBox1.Invalidate() ' Force redraw
    End Sub

    Private Sub LoadCartData()
        Try
            Dim query As String = "SELECT * FROM cart WHERE UserID = @UserID"

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", _userID) ' Replace _userID with actual user ID

                Dim adapter As New SqlDataAdapter(command)
                Dim dbTable As New DataTable()

                connection.Open()
                adapter.Fill(dbTable)
                connection.Close()

                ' Populate cartTable
                cartTable.Clear()

                For Each row As DataRow In dbTable.Rows
                    Dim productNameWithSize As String = $"{row("ProductName")} ({row("Size")})"
                    cartTable.Rows.Add(row("CartID"), productNameWithSize, row("Quantity"), row("Price"))
                Next

            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading cart data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdjustPictureBoxSize()
        ' Calculate the required size for the PictureBox
        Dim rowHeight As Integer = 30
        Dim headerHeight As Integer = 30
        Dim totalHeight As Integer = headerHeight + (cartTable.Rows.Count * rowHeight)

        PictureBox1.Width = Panel1.Width - SystemInformation.VerticalScrollBarWidth
        PictureBox1.Height = totalHeight

        ' Debugging Output
        Debug.WriteLine($"PictureBox resized to Width: {PictureBox1.Width}, Height: {PictureBox1.Height}")
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        ' Clear previous drawings
        e.Graphics.Clear(Color.White)

        ' Define table layout
        Dim columnWidths As Integer() = {200, 80, 100, 50}
        Dim rowHeight As Integer = 30
        Dim startX As Integer = 0
        Dim currentY As Integer = 0

        ' Fonts and brushes
        Dim fontHeader As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim fontBody As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim pen As New Pen(Color.Black)
        Dim brush As Brush = Brushes.Black

        ' Draw header
        Dim columnTitles As String() = {"Product Name", "Quantity", "Price (RM)", "Delete"}
        For i As Integer = 0 To columnTitles.Length - 1
            e.Graphics.DrawRectangle(pen, startX, currentY, columnWidths(i), rowHeight)
            e.Graphics.DrawString(columnTitles(i), fontHeader, brush, startX + 5, currentY + 5)
            startX += columnWidths(i)
        Next

        ' Draw rows
        startX = 0
        currentY += rowHeight
        For Each row As DataRow In cartTable.Rows
            Dim values As String() = {
                row("Product Name").ToString(),
                row("Quantity").ToString(),
                $"{Convert.ToDecimal(row("Price (RM)")) * row("Quantity"):F2}"
            }

            For i As Integer = 0 To values.Length - 1
                e.Graphics.DrawRectangle(pen, startX, currentY, columnWidths(i), rowHeight)
                e.Graphics.DrawString(values(i), fontBody, brush, startX + 5, currentY + 5)
                startX += columnWidths(i)
            Next

            Dim buttonRect As New Rectangle(startX + 5, currentY + 5, columnWidths(3) - 10, rowHeight - 10)
            e.Graphics.DrawRectangle(pen, buttonRect)
            e.Graphics.FillRectangle(Brushes.Red, buttonRect)
            e.Graphics.DrawString("X", fontBody, Brushes.White, buttonRect.X + 10, buttonRect.Y + 5)

            startX = 0
            currentY += rowHeight
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If cartTable.Rows.Count < 1 Then
            MessageBox.Show("Please add items to your cart.", "Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim invoiceForm As New Form8(cartTable)
            Me.Close()
            invoiceForm.ShowDialog()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mainPage As New Form4(_userID)
        mainPage.Show()
        Me.Close() ' Close the current form (Form2)
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        Dim rowHeight As Integer = 30
        Dim headerHeight As Integer = 30
        Dim deleteColumnStartX As Integer = 380 ' Start X of the Delete button column
        Dim deleteColumnWidth As Integer = 50

        ' Calculate clicked row index
        Dim clickedRow As Integer = (e.Y - headerHeight) \ rowHeight

        If clickedRow >= 0 AndAlso clickedRow < cartTable.Rows.Count Then
            Dim rowYStart As Integer = headerHeight + (clickedRow * rowHeight)
            If e.X >= deleteColumnStartX AndAlso e.X <= deleteColumnStartX + deleteColumnWidth AndAlso
           e.Y >= rowYStart AndAlso e.Y <= rowYStart + rowHeight Then

                ' Get the CartId of the clicked item
                Dim cartId As Integer = Convert.ToInt32(cartTable.Rows(clickedRow)("CartID"))
                Dim productName As String = cartTable.Rows(clickedRow)("Product Name").ToString()

                ' Ask for confirmation before deleting
                If MessageBox.Show($"Delete {productName} from cart?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    DeleteCartItem(cartId) ' Call the delete method with cartId
                End If
            End If
        End If
    End Sub

    Private Sub DeleteCartItem(cartId As Integer)
        Try
            ' SQL query to delete the item based on cartId
            Dim query As String = "DELETE FROM cart WHERE CartID = @CartId"
            Dim updateQuery As String = "UPDATE products SET Quantity = Quantity + @Quantity WHERE ProductName = @ProductName"
            Dim selectQuery As String = "SELECT ProductName, Quantity FROM cart WHERE CartID = @CartId"
            Dim quantity As Integer
            Dim ProductName As String

            Using connection As New SqlConnection(connectionString)
                Dim selectcommand As New SqlCommand(selectQuery, connection)
                selectcommand.Parameters.AddWithValue("@CartId", cartId)

                connection.Open()
                Using reader As SqlDataReader = selectcommand.ExecuteReader()
                    If reader.Read() Then
                        ProductName = reader("ProductName").ToString()
                        quantity = Convert.ToInt32(reader("Quantity"))
                    End If
                End Using
                connection.Close()
            End Using

            Using connection As New SqlConnection(connectionString)
                Dim updatecommand As New SqlCommand(updateQuery, connection)
                updatecommand.Parameters.AddWithValue("@Quantity", quantity)
                updatecommand.Parameters.AddWithValue("@ProductName", ProductName)
                connection.Open()
                updatecommand.ExecuteNonQuery()
                connection.Close()

                ' After deletion, refresh the cart data
                MessageBox.Show("Item added in products successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CartId", cartId)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                ' After deletion, refresh the cart data
                LoadCartData()
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error deleting item: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

