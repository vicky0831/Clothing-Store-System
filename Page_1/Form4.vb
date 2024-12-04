Imports System.IO
Imports Microsoft.Data.SqlClient
Module SharedData
    Public _userID As Integer
End Module

Public Class Form4
    Dim connectionString As String = "Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
    Dim selectedCategory As String
    ' Constructor to accept User ID
    Public Sub New(userID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Set the User ID
        _userID = userID
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DisplayProducts("All")
    End Sub

    Private Sub DisplayProducts(category As String)

        RemoveHandler Label2.Click, AddressOf CategoryLabel_Click
        RemoveHandler Label3.Click, AddressOf CategoryLabel_Click
        RemoveHandler Label5.Click, AddressOf CategoryLabel_Click
        RemoveHandler Label6.Click, AddressOf CategoryLabel_Click

        AddHandler Label2.Click, AddressOf CategoryLabel_Click
        AddHandler Label3.Click, AddressOf CategoryLabel_Click
        AddHandler Label5.Click, AddressOf CategoryLabel_Click
        AddHandler Label6.Click, AddressOf CategoryLabel_Click

        Dim dt As DataTable = GetProducts(category)
        FlowLayoutPanel1.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim productPanel As New Panel()
            productPanel.Width = 200
            productPanel.Height = 350

            Dim lblName As New Label()
            lblName.Text = row("ProductName").ToString()
            ' lblName.Dock = DockStyle.Top
            lblName.Font = New Font("Arial", 14, FontStyle.Bold) ' Set font size and style
            lblName.ForeColor = Color.Black
            ' Nice blue color
            ' lblName.Margin = New Padding(10) ' Add margin around the label
            lblName.Width = 180 ' Set label width
            lblName.Location = New Point(12, 0) ' Position inside the panel
            lblName.TextAlign = ContentAlignment.MiddleCenter ' Center-align the text


            Dim lblPrice As New Label()
            lblPrice.Text = "RM " & Convert.ToDecimal(row("PRICE")).ToString("F2")
            ' lblPrice.Dock = DockStyle.Top
            lblPrice.AutoSize = True

            lblPrice.Font = New Font("Arial", 14, FontStyle.Bold) ' Set font size and style
            lblPrice.ForeColor = Color.Black
            'ColorTranslator.FromHtml("#8B5E3C") ' Nice blue color
            lblPrice.Location = New Point(50, 30)
            lblPrice.TextAlign = ContentAlignment.MiddleCenter

            Dim radioSmall As New RadioButton()

            Dim radioMedium As New RadioButton()

            Dim radioLarge As New RadioButton()

            If row("category").ToString() = "T-Shirts" OrElse row("category").ToString() = "Jeans" OrElse row("category").ToString() = "Sneakers" Then
                radioSmall.Text = "S"
                radioSmall.AutoSize = True
                radioSmall.Font = New Font("Arial", 9, FontStyle.Regular)

                radioMedium.Text = "M"
                radioMedium.AutoSize = True
                radioMedium.Font = New Font("Arial", 9, FontStyle.Regular)

                radioLarge.Text = "L"
                radioLarge.AutoSize = True
                radioLarge.Font = New Font("Arial", 9, FontStyle.Regular)

                radioSmall.Location = New Point(35, 280)
                radioMedium.Location = New Point(95, 280)
                radioLarge.Location = New Point(150, 280)

                productPanel.Controls.Add(radioSmall)
                productPanel.Controls.Add(radioMedium)
                productPanel.Controls.Add(radioLarge)

            End If

            Dim picBox As New PictureBox()
            Dim imageBytes As Byte() = If(IsDBNull(row("ProductImage")), Nothing, CType(row("ProductImage"), Byte()))

            ' Check if image data exists
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Using ms As New MemoryStream(imageBytes)
                    picBox.Image = Image.FromStream(ms)
                End Using
            Else

            End If
            picBox.Width = 175
            picBox.Height = 180
            picBox.SizeMode = PictureBoxSizeMode.StretchImage
            picBox.Location = New Point(15, 57)
            '  picBox.Dock = DockStyle.Bottom

            ' Add quantity controls
            Dim btnDecrease As New Button()
            btnDecrease.Text = "-"
            btnDecrease.Width = 30
            btnDecrease.Height = 30
            btnDecrease.Location = New Point(40, 242)

            Dim txtQuantity As New TextBox()
            txtQuantity.Text = "1"
            txtQuantity.Width = 50
            txtQuantity.Height = 30
            txtQuantity.Location = New Point(80, 244)
            txtQuantity.TextAlign = HorizontalAlignment.Center

            Dim btnIncrease As New Button()
            btnIncrease.Text = "+"
            btnIncrease.Width = 30
            btnIncrease.Height = 30
            btnIncrease.Location = New Point(140, 242)

            ' Add event handlers for buttons
            AddHandler btnDecrease.Click, Sub(sender, e)
                                              Dim qty As Integer = Integer.Parse(txtQuantity.Text)
                                              If qty > 1 Then
                                                  txtQuantity.Text = (qty - 1).ToString()
                                              End If
                                          End Sub

            AddHandler btnIncrease.Click, Sub(sender, e)
                                              Dim qty As Integer = Integer.Parse(txtQuantity.Text)

                                              Dim productName As String = row("ProductName").ToString()

                                              ' Retrieve the latest maxQty from the database
                                              Dim maxQty As Integer
                                              Dim query As String = "SELECT Quantity FROM products WHERE ProductName = @ProductID"
                                              Using conn As New SqlConnection(connectionString)
                                                  Using cmd As New SqlCommand(query, conn)
                                                      cmd.Parameters.AddWithValue("@ProductID", productName)
                                                      conn.Open()
                                                      maxQty = Convert.ToInt32(cmd.ExecuteScalar()) ' Get the latest Quantity value from the database
                                                  End Using
                                              End Using

                                              '  Dim maxQty As Integer = Convert.ToInt32(row("Quantity")) ' Assuming the column for stock is "StockQuantity"
                                              If qty < maxQty Then
                                                  txtQuantity.Text = (qty + 1).ToString()
                                              Else
                                                  MessageBox.Show($"Maximum available quantity is {maxQty}.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                              End If
                                          End Sub

            Dim btnAddToCart As New Button()
            btnAddToCart.Text = "Add to Cart"
            btnAddToCart.Font = New Font("Arial", 10, FontStyle.Bold)
            btnAddToCart.Width = 120
            btnAddToCart.Height = 35
            btnAddToCart.BackColor = ColorTranslator.FromHtml("#8B5E3C")
            btnAddToCart.ForeColor = Color.White
            btnAddToCart.Location = New Point(45, 300)


            AddHandler btnAddToCart.Click, Sub(sender, e)
                                               Dim productName As String = lblName.Text
                                               Dim productPrice As Decimal = Convert.ToDecimal(row("PRICE"))
                                               Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
                                               Dim selectedSize As String
                                               Dim Total_Price As Decimal

                                               If quantity < 1 Then
                                                   MessageBox.Show("Please Add Quantity! Min 1")

                                               Else

                                                   If Not row("category").ToString = "Watches" Then
                                                       If Not (radioSmall.Checked Or radioMedium.Checked Or radioLarge.Checked) Then
                                                           MessageBox.Show("Please select a size (S, M, or L)!")
                                                           Return
                                                       End If

                                                       If radioSmall.Checked Then
                                                           selectedSize = "S"
                                                       ElseIf radioMedium.Checked Then
                                                           selectedSize = "M"
                                                       Else
                                                           selectedSize = "L"
                                                       End If
                                                   End If

                                                   If row("category") = "Watches" Then
                                                       selectedSize = " "
                                                   End If


                                                   txtQuantity.Text = "0"
                                                   Try
                                                       ' Define the query to fetch products
                                                       Dim query As String = "INSERT INTO cart (UserID,ProductName,Size, Quantity, Price) VALUES (@Id,@ProductName ,@Size, @Stock, @Price )"

                                                       Using connection As New SqlConnection(connectionString)
                                                           Dim command As New SqlCommand(query, connection)
                                                           command.Parameters.AddWithValue("@Id", _userID)
                                                           command.Parameters.AddWithValue("@ProductName", productName)
                                                           command.Parameters.AddWithValue("@Size", selectedSize)
                                                           command.Parameters.AddWithValue("@Price", productPrice)
                                                           command.Parameters.AddWithValue("@Stock", quantity)

                                                           connection.Open()
                                                           command.ExecuteNonQuery()
                                                           MessageBox.Show("Product added to Cart successfully!")
                                                       End Using

                                                       Dim updateQuery As String = "UPDATE products SET Quantity = Quantity - @Quantity WHERE ProductName = @ProductName"

                                                       Using connection As New SqlConnection(connectionString)
                                                           Dim command As New SqlCommand(updateQuery, connection)
                                                           command.Parameters.AddWithValue("@Quantity", quantity)
                                                           command.Parameters.AddWithValue("@ProductName", productName)

                                                           connection.Open()
                                                           command.ExecuteNonQuery()
                                                           ' MessageBox.Show($"Updated stock for {productName}.")

                                                       End Using

                                                   Catch ex As SqlException
                                                       MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                   End Try
                                                   MessageBox.Show($"Added to Cart: {productName} (x{quantity}) for RM {productPrice * quantity:F2}")
                                                   '  RestartForm()
                                               End If
                                           End Sub

            productPanel.Controls.Add(btnDecrease)
            productPanel.Controls.Add(txtQuantity)
            productPanel.Controls.Add(btnIncrease)
            productPanel.Controls.Add(lblName)
            productPanel.Controls.Add(lblPrice)
            productPanel.Controls.Add(picBox)
            productPanel.Controls.Add(btnAddToCart)

            FlowLayoutPanel1.AutoScroll = True

            FlowLayoutPanel1.Margin = New Padding(10) ' 10px margin around the FlowLayoutPanel

            FlowLayoutPanel1.Padding = New Padding(10) ' 10px padding inside FlowLayoutPanel

            ' Set margin for each productPanel to control the gap between product panels
            productPanel.Margin = New Padding(15) ' 10px gap between each productPanel

            FlowLayoutPanel1.Controls.Add(productPanel)
        Next
    End Sub

    Private Sub CategoryLabel_Click(sender As Object, e As EventArgs)
        ' Get the category based on the label clicked
        selectedCategory = CType(sender, Label).Text
        ' Update the category in the DisplayProducts method
        DisplayProducts(selectedCategory)
    End Sub

    Private Function GetProducts(category As String) As DataTable
        Dim dt As New DataTable()
        Dim query As String

        Select Case category
            Case "All"
                query = "SELECT * FROM products" ' Fetch all products
            Case "T-Shirts"
                query = "SELECT * FROM products WHERE category = 'T-Shirts'" ' Fetch shirts
            Case "Jeans"
                query = "SELECT * FROM products WHERE category = 'Jeans'" ' Fetch pants
            Case "Sneakers"
                query = "SELECT * FROM products WHERE category = 'Sneakers'" ' Fetch shoes
            Case "Watches"
                query = "SELECT * FROM products WHERE category = 'Watches'" ' Fetch jackets
            Case Else
                query = "SELECT * FROM products" ' Default to fetch all products if the category is unrecognized
        End Select

        Using conn As New SqlConnection("Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;")
            Using cmd As New SqlCommand(query, conn)
                Using adapter As New SqlDataAdapter(cmd)
                    conn.Open()
                    adapter.Fill(dt)
                    conn.Close()
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim cartPage As New Form6()
        cartPage.Show()
        Me.Hide()
    End Sub

    Private Sub RestartForm()
        ' Close the current form
        Me.Close()
        ' Create a new instance of the form
        Dim newForm As New Form4(_userID) ' Pass the UserID or any other parameters you need
        newForm.selectedCategory = selectedCategory ' Pass the current category
        newForm.DisplayProducts(selectedCategory) ' Display products based on the selected category

        newForm.Show()

    End Sub

End Class