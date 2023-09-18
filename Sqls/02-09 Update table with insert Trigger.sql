--- Triggers are used for insert, update, delete
-- Add order to [Order Details] table and reduce stock from Products table

SELECT * FROM Products
SELECT * FROM [Order Details]

CREATE TRIGGER trg_update_stock ON [Order Details]
FOR INSERT
AS
BEGIN
    DECLARE @saleUnit INT, @productID INT
    SELECT @productID = ProductID, @saleUnit = Quantity FROM inserted
    UPDATE Products SET UnitsInStock = UnitsInStock - @saleUnit
    WHERE ProductID = @productID
END
---------

ALTER TRIGGER trg_update_stock ON [Order Details]
FOR INSERT
AS
BEGIN
    DECLARE @saleUnit INT, @productID INT
    SELECT @productID = ProductID, @saleUnit = Quantity FROM inserted
    UPDATE Products SET UnitsInStock = UnitsInStock - @saleUnit
    WHERE ProductID = @productID
END
----------
INSERT INTO [Order Details] VALUES (10248, 3, 18 , 2, 0)
