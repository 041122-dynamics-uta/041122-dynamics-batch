CREATE TABLE Stores(
StoreId int IDENTITY(1,1) Primary Key,
StoreName nvarchar(30) not null,
StoreLocation nvarchar(30) not null,
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

CREATE TABLE Products(
ProductId int IDENTITY(1,1) Primary Key,
ProductName nvarchar(30) not null,
ProductDescription nvarchar(255) not null,
Price decimal(4,2) not null,
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

CREATE TABLE Customers(
CustomerId int IDENTITY(1,1) Primary Key,
Fname nvarchar(30) not null,
Lname nvarchar(30) not null,
Pass nvarchar(30) not null,
Username nvarchar(30) not null,
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

CREATE TABLE Orders(
LineItemId int IDENTITY(1,1) Primary Key,
OrderId UNIQUEIDENTIFIER not null,--we will insert this from the GUID we create in the app.
CustomerId_FK int not null FOREIGN KEY REFERENCES Customers(CustomerId),
ProductId_FK int not null FOREIGN KEY REFERENCES Products(ProductId),
StoreId_FK int not null FOREIGN KEY REFERENCES Stores(StoreId),
Quantity int not null DEFAULT(1),
Price decimal(4,2) not null,
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);

CREATE TABLE Inventory(
InventoryItemId int IDENTITY(1,1) Primary Key,
ProductId_FK int not null FOREIGN KEY REFERENCES Products(ProductId),
StoreId_FK int not null FOREIGN KEY REFERENCES Stores(StoreId),
Quantity int not null DEFAULT(1),
DateCreated DATETIME2 not null DEFAULT(GETDATE())
);
