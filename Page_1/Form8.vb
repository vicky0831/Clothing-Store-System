Imports System.Net.Http
Imports Microsoft.Data.SqlClient
Imports Newtonsoft.Json.Linq

Public Class Form8

    Private cartTable As DataTable
    ' Constructor to pass cart items
    Public Sub New(cart As DataTable)
        InitializeComponent()
        cartTable = cart
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim userId As Integer = _userID ' Replace with actual user ID
        Dim addressParts = GetAddressPartsFromDatabase(userId)
        TextBox1.Text = addressParts.Item1
        TextBox6.Text = addressParts.Item2
        TextBox7.Text = addressParts.Item3
        TextBox2.Text = addressParts.Item4
        TextBox3.Text = addressParts.Item5

    End Sub

    Private Async Function GetCoordinatesFromAddressAsync(address As String) As Task(Of (Double, Double))
        Dim client As New HttpClient()

        ' Set the User-Agent header to comply with Nominatim API's usage policy
        client.DefaultRequestHeaders.Add("User-Agent", "YourAppName/1.0 (your.email@example.com)")

        ' URL to call Nominatim API (Geocoding)
        Dim url As String = $"https://nominatim.openstreetmap.org/search?q={address}&format=json&addressdetails=1"

        ' Send GET request to Nominatim API
        Dim response As HttpResponseMessage = Await client.GetAsync(url)

        If response.IsSuccessStatusCode Then
            ' Parse the response JSON
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim json As JArray = JArray.Parse(jsonResponse)

            If json.Count > 0 Then
                ' Get the latitude and longitude from the first result
                Dim lat As Double = json(0)("lat").ToObject(Of Double)()
                Dim lon As Double = json(0)("lon").ToObject(Of Double)()
                ' Return the coordinates
                Return (lat, lon)
            Else
                Throw New Exception("Address not found.")
            End If
        Else
            Throw New Exception("Error in Nominatim API response.")
        End If
    End Function

    ' Function to calculate the distance between two coordinates using OSRM API
    Private Async Function GetDistanceAsync(lat1 As Double, lon1 As Double, lat2 As Double, lon2 As Double) As Task(Of Double)
        Dim client As New HttpClient()

        ' Construct OSRM route API URL (OSRM supports routes and distances)
        Dim url As String = $"http://router.project-osrm.org/route/v1/driving/{lon1},{lat1};{lon2},{lat2}?overview=false&geometries=polyline"

        ' Send GET request to OSRM API
        Dim response As HttpResponseMessage = Await client.GetAsync(url)

        If response.IsSuccessStatusCode Then
            ' Parse the response JSON
            Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
            Dim json As JObject = JObject.Parse(jsonResponse)

            ' Extract the distance (in meters)
            Dim distance As Double = json("routes")(0)("legs")(0)("distance").ToObject(Of Double)()

            ' Return the distance in kilometers
            Return distance / 1000 ' Convert to kilometers
        Else
            Throw New Exception("Error in OSRM API response.")
        End If
    End Function

    ' Button click event to trigger the address geocoding and distance calculation
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Example: Outlet's coordinates (fixed coordinates of the outlet)
            Dim outletLat As Double = 3.503497 ' Example latitude of outlet
            Dim outletLon As Double = 101.103582 ' Example longitude of outlet

            ' Example: User's address (you can replace this with actual input)
            Dim userAddress As String = $"{TextBox7.Text}, {TextBox2.Text} {TextBox3.Text}"
            Dim encodedAddress As String = Uri.EscapeDataString(userAddress)
            ' Get the user's coordinates from the address
            Dim userCoordinates = Await GetCoordinatesFromAddressAsync(encodedAddress)
            Dim userLat As Double = userCoordinates.Item1
            Dim userLon As Double = userCoordinates.Item2

            ' Get distance between outlet and user
            Dim distance As Double = Await GetDistanceAsync(outletLat, outletLon, userLat, userLon)

            ' Display the distance
            MessageBox.Show("Distance from outlet to your address is: " & distance.ToString("F2") & " km")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim invoiceForm As New Form7(cartTable, TextBox1.Text, TextBox6.Text, TextBox7.Text, TextBox2.Text, TextBox3.Text)
        Me.Close()
        invoiceForm.ShowDialog()
    End Sub
    Private Function GetAddressPartsFromDatabase(userId As Integer) As (String, String, String, String, String)
        Dim houseNo As String = ""
        Dim streetName As String = ""
        Dim city As String = ""
        Dim postalCode As String = ""
        Dim state As String = ""

        Dim connectionString As String = "Server=LAPTOP-VC74QSL6\SQLEXPRESS;Database=Mini_Project;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT HouseNo, StreetName, City, Postcode, State FROM users WHERE ID = @UserId"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@UserId", userId)

            connection.Open()
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    houseNo = reader("HouseNo").ToString()
                    streetName = reader("StreetName").ToString()
                    city = reader("City").ToString()
                    postalCode = reader("Postcode").ToString()
                    state = reader("State").ToString()
                End If
            End Using
        End Using

        Return (houseNo, streetName, city, postalCode, state)
    End Function
End Class