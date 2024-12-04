CREATE TABLE delivery (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL,
    TotalPrice DECIMAL(18, 2) NOT NULL,
    Quantity INT NOT NULL,
    Address NVARCHAR(255) NOT NULL
);
