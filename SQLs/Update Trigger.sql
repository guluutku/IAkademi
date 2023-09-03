-- SELECT * FROM [Order Details]
-- Order Details tablosunda adet güncelledğimizde
-- değişen adet kadar products tablosundan adet güncellenmeli
CREATE TRIGGER trg_StockUpdate ON [Order Details]
FOR UPDATE
AS
BEGIN
    DECLARE  @NewSaleQuantity INT, @ProductID INT, @SaleQuantity INT
    SELECT @SaleQuantity = Quantity, @ProductID = ProductID FROM deleted
    SELECT @NewSaleQuantity = Quantity, @ProductID = ProductID FROM inserted

    if (@NewSaleQuantity < @SaleQuantity) 
        BEGIN 
            UPDATE Products SET UnitsInStock = UnitsInStock + (@SaleQuantity - @NewSaleQuantity)
            WHERE ProductID = @ProductID
        END
    ELSE
        BEGIN
            UPDATE Products SET UnitsInStock = UnitsInStock - (@NewSaleQuantity - @SaleQuantity)
            WHERE ProductID = @ProductID
        END
END
GO
-----------------------
UPDATE [Order Details] set Quantity = 30 WHERE OrderID = 10248 and ProductID = 2