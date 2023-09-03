CREATE TRIGGER trg_StockDelete ON [Order Details]
FOR DELETE
AS
BEGIN
    DECLARE @ProductID INT, @SaleQuantity INT
    SELECT @SaleQuantity = Quantity, @ProductID = ProductID FROM deleted

    DELETE FROM [Order Details]  WHERE ProductID = @ProductID
    UPDATE Products SET UnitsInStock = UnitsInStock + @SaleQuantity
        WHERE ProductID = @ProductID
    
END
GO
--------------------
ALTER TRIGGER trg_StockDelete ON [Order Details]
FOR DELETE
AS
BEGIN
    DECLARE @ProductID INT, @SaleQuantity INT
    SELECT @SaleQuantity = Quantity, @ProductID = ProductID FROM deleted

    UPDATE Products SET UnitsInStock = UnitsInStock + @SaleQuantity
        WHERE ProductID = @ProductID
    
END
GO
------------
DELETE FROM [Order Details]  WHERE OrderID = 10248 and ProductID = 2
DELETE FROM Products  WHERE ProductID = 2