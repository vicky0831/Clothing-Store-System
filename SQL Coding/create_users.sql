CREATE TABLE users (
    ID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL,
    PhoneNumber INT NOT NULL,
    HouseNo NVARCHAR(50) NOT NULL,
    StreetName NVARCHAR(255) NOT NULL,
    City NVARCHAR(100) NOT NULL,
    Postcode NVARCHAR(20) NOT NULL,
    State NVARCHAR(100) NOT NULL
);