/* ===============================
   CREATE DATABASE
================================ */
USE master;
GO

IF DB_ID('ElectronicManagementDB') IS NOT NULL
    DROP DATABASE ElectronicManagementDB;
GO

CREATE DATABASE ElectronicManagementDB;
GO

USE ElectronicManagementDB;
GO

/* ===============================
   PRODUCT CATEGORY TABLE
================================ */
CREATE TABLE ProductCategory(
    ProductCategoryId INT PRIMARY KEY IDENTITY(1,1),
    ProductCategoryName NVARCHAR(100) NOT NULL,
    ProductCategoryDescription NVARCHAR(200)
);
GO

/* ===============================
   PRODUCT TABLE
================================ */
CREATE TABLE Product (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(200) NOT NULL,
    Unit NVARCHAR(50) NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    AvailableQuantity INT NOT NULL,
    ProductImage NVARCHAR(500) NULL,
    ProductCategoryId INT NOT NULL,
    CONSTRAINT FK_Product_Category 
        FOREIGN KEY (ProductCategoryId) 
        REFERENCES ProductCategory(ProductCategoryId)
);
GO

/* ===============================
   CUSTOMER TABLE
================================ */
CREATE TABLE Customer (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(200) NOT NULL,
    ContactNumber NVARCHAR(20) NOT NULL,
    ContactAddress NVARCHAR(500) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

/* ===============================
   ORDERS TABLE
================================ */
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    TotalAmount DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Orders_Customer 
        FOREIGN KEY (CustomerId) 
        REFERENCES Customer(CustomerId)
);
GO

/* ===============================
   ORDER DETAILS TABLE
================================ */
CREATE TABLE OrderDetails (
    OrderDetailId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    OrderQuantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    Amount DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_OrderDetails_Order 
        FOREIGN KEY (OrderId) 
        REFERENCES Orders(OrderId) 
        ON DELETE CASCADE,
    CONSTRAINT FK_OrderDetails_Product 
        FOREIGN KEY (ProductId) 
        REFERENCES Product(ProductId)
);
GO

/* ===============================
   SAMPLE DATA : PRODUCT CATEGORY
================================ */
INSERT INTO ProductCategory 
(ProductCategoryName, ProductCategoryDescription)
VALUES
('Mobile', 'Smartphones and feature phones'),
('Laptop', 'Personal and business laptops'),
('Television', 'LED, Smart and Android TVs'),
('Accessories', 'Electronic accessories and gadgets');
GO

/* ===============================
   SAMPLE DATA : PRODUCT
================================ */
INSERT INTO Product
(ProductName, Unit, UnitPrice, AvailableQuantity, ProductImage, ProductCategoryId)
VALUES
('Samsung Galaxy S23', 'Piece', 95000.00, 30, NULL, 1),
('iPhone 14', 'Piece', 125000.00, 20, NULL, 1),
('Dell Inspiron 15', 'Piece', 78000.00, 15, NULL, 2),
('HP Pavilion', 'Piece', 82000.00, 10, NULL, 2),
('Sony Bravia 43 Inch', 'Piece', 65000.00, 8, NULL, 3),
('Wireless Mouse', 'Piece', 1200.00, 100, NULL, 4);
GO

/* ===============================
   SAMPLE DATA : CUSTOMER
================================ */
INSERT INTO Customer
(CustomerName, ContactNumber, ContactAddress)
VALUES
('Md. Karim', '01712345678', 'Dhaka, Bangladesh'),
('Fatema Akter', '01823456789', 'Chittagong, Bangladesh'),
('Abdul Rahman', '01934567890', 'Sylhet, Bangladesh');
GO

/* ===============================
   SAMPLE DATA : ORDERS
================================ */
INSERT INTO Orders (CustomerId, TotalAmount)
VALUES
(1, 107200.00),
(2, 125000.00);
GO

/* ===============================
   SAMPLE DATA : ORDER DETAILS
================================ */
INSERT INTO OrderDetails
(OrderId, ProductId, OrderQuantity, UnitPrice, Amount)
VALUES
(1, 1, 1, 95000.00, 95000.00),
(1, 6, 1, 1200.00, 1200.00),
(2, 2, 1, 125000.00, 125000.00);
GO

/* ===============================
   CHECK DATA
================================ */
SELECT * FROM ProductCategory;
SELECT * FROM Product;
SELECT * FROM Customer;
SELECT * FROM Orders;
SELECT * FROM OrderDetails;
GO
