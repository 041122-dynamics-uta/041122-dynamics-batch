
--Simple Stored Procedure
CREATE PROCEDURE GetAllCustomerNames
AS 
SELECT CustomerId, FirstName, AddressId
FROM Customers
WHERE addressID >1;

EXEC GetAllCustomerNames;
DROP PROCEDURE GetAllCustomerNames;

--Stored Procedure with variables
CREATE PROCEDURE GetCustomerShe   
    @LastName nvarchar(50),   
    @FirstName nvarchar(50)   
AS     
    SELECT FirstName, LastName, Remarks  
    FROM Customers  
    WHERE FirstName LIKE @FirstName 
	AND 
	LastName LIKE @LastName  
    AND 
	Remarks LIKE '%e%';  

-- use the '%' to allow any last name
EXEC GetCustomerShe 
	@LastName = '%', 
	@FirstName = 'Libby';

DROP PROCEDURE GetCustomerShe;
SELECT * FROM Customers;

--Silimar to the above Stored Procedure with variables
CREATE PROCEDURE GetCustomerHe   
    @LastName nvarchar(50),   
    @FirstName nvarchar(50)   
AS     
    SELECT FirstName, LastName, Remarks  
    FROM Customers  
    WHERE FirstName LIKE @FirstName AND LastName LIKE @LastName  
    AND Remarks LIKE 'T_s%';

EXEC GetCustomerHe @LastName = 'M%', @FirstName = '%';
DROP PROCEDURE GetCustomerShe;



--Prep for OUTPUT Parameter Query
--INSERT INTO Orders (CustomerID, OrderDate, totalAmount) VALUES (1, '2018-09-13', 0.31);
--INSERT INTO Orders (CustomerID, OrderDate, totalAmount) VALUES (1, '2020-12-25', 400);
--INSERT INTO Orders (CustomerID, OrderDate, totalAmount) VALUES (3, '2020-09-13', .31);

--Stored Procedure with OUT Parameter
CREATE PROCEDURE HowManyOrdersByCustomer (
    @CustomerNumber INT,--customerID
    @OrderCount INT OUTPUT
) AS
BEGIN
    SELECT CustomerID AS CustomersID, SUM(OrderId) AS "Total Number of Orders" 
    FROM Orders
    WHERE CustomerID = @CustomerNumber
	GROUP BY CustomerID;
-- @@ROWCOUNT is a system variable that returns 
-- the number of rows read by the previous statement.
    SELECT @OrderCount = @@ROWCOUNT;
END;

DECLARE @HowMany INT;--1. declare a variable to hold the return
EXEC HowManyOrdersByCustomer 2, @HowMany OUTPUT;--2. call the method with the 2 parameters
SELECT @HowMany AS 'Ten times the total';

DROP PROCEDURE HowManyOrdersByCustomer;
--SELECT * FROM Orders;
--SELECT * FROM Customers;