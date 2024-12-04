CREATE TABLE products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(255) NOT NULL,
    PRICE DECIMAL(18, 2) NOT NULL,
    Quantity INT NOT NULL,
    ProductImage VARBINARY(MAX),  -- Storing binary data (image) in a column
    category NVARCHAR(100) NOT NULL
);