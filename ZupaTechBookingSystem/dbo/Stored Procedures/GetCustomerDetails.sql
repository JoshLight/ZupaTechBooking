
CREATE PROC [dbo].[GetCustomerDetails] @CustomerName NVARCHAR(50), @CustomerEmail NVARCHAR(50) 
AS
IF NOT EXISTS (SELECT CustomerId FROM Customer WHERE CustomerName = @CustomerName AND CustomerEmail = @CustomerEmail)
BEGIN
INSERT INTO Customer
VALUES
(NEWID(), @CustomerName, @CustomerEmail)
END
SELECT CustomerId, CustomerName, CustomerEmail FROM Customer WHERE CustomerName = @CustomerName and CustomerEmail = @CustomerEmail