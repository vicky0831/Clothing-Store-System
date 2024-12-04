Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Form5

    Dim connectionString As String = "Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Apply unique styling for the Admin page
        Me.BackColor = Color.Beige ' Light brown-related background color

        ' Customize buttons
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = CType(ctrl, Button)
                btn.BackColor = Color.SandyBrown ' Light brown button color
                btn.ForeColor = Color.White ' Text color for buttons
                btn.FlatStyle = FlatStyle.Flat ' Optional: Modern look
                btn.FlatAppearance.BorderSize = 0 ' Optional: Remove border
            End If
        Next

        ' Customize labels
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                lbl.ForeColor = Color.Chocolate ' Darker brown for label text
                lbl.Font = New Font(lbl.Font, FontStyle.Bold) ' Make labels bold
            End If
        Next

        GroupBox1.Visible = False
        GroupBox2.Visible = False

        DataGridView1.BackgroundColor = Color.AntiqueWhite

        ' Load the current product data
        LoadProducts()
    End Sub

    Private Sub LoadProducts()
        Try
            ' Define the query to fetch products
            Dim query As String = "SELECT ProductID, ProductName, PRICE, Quantity, ProductImage, category FROM products"

            ' Establish the connection
            Using connection As New SqlConnection(connectionString)
                ' Create the data adapter
                Dim adapter As New SqlDataAdapter(query, connection)

                ' Fill the data table
                Dim productTable As New DataTable()
                adapter.Fill(productTable)

                ' Bind the data to the DataGridView
                DataGridView1.DataSource = productTable

                ' Customize column headers
                DataGridView1.Columns("ProductID").HeaderText = "ID"
                DataGridView1.Columns("ProductName").HeaderText = "Name"
                DataGridView1.Columns("PRICE").HeaderText = "Price"
                DataGridView1.Columns("Quantity").HeaderText = "Quantity"
                DataGridView1.Columns("category").HeaderText = "Category"

            End Using

        Catch ex As SqlException
            MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim name As String = TextBox1.Text
        Dim price As Decimal = Decimal.Parse(TextBox2.Text)
        Dim quantity As Integer = Integer.Parse(TextBox3.Text)
        Dim category As String = ComboBox1.Text
        Dim imageBytes As Byte() = Nothing

        If Not String.IsNullOrEmpty(txtImagePath.Text) Then
            imageBytes = File.ReadAllBytes(txtImagePath.Text)
        End If
        Try
            ' Insert product with image (BLOB) into the database
            Dim query As String = "INSERT INTO products (ProductName, PRICE, Quantity, ProductImage, category) VALUES (@Name, @Price, @Stock, @ProductImage, @Category)"
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Price", price)
                command.Parameters.AddWithValue("@Stock", quantity)
                command.Parameters.AddWithValue("@Category", category)
                command.Parameters.AddWithValue("@ProductImage", imageBytes) ' Store image as BLOB
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Product added successfully!")
                LoadProducts() ' Refresh product list
                GroupBox1.Visible = False
            End Using
        Catch ex As SqlException
            MessageBox.Show("Error adding product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog = DialogResult.OK Then
                ' Display the selected image in the PictureBox
                PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
                ' Save the image file path in the TextBox
                txtImagePath.Text = openFileDialog.FileName
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim productId As Integer = Integer.Parse(TextBox7.Text)

        Try
            Dim query As String = "DELETE FROM products WHERE ProductID = @ProductID"
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProductID", productId)
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Product deleted successfully!")
                LoadProducts() ' Refresh product list
                GroupBox2.Visible = False
            End Using
        Catch ex As SqlException
            MessageBox.Show("Error deleting product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim log_in_form As New Form3()
        log_in_form.Show()
        Me.Hide()
    End Sub

End Class