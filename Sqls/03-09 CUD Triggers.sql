SELECT *
FROM [Order Details] AS od
    INNER JOIN Products AS pr
    ON od.ProductID = pr.ProductID

-- Disabled to not mix with old triggers
DISABLE TRIGGER trg_update_stock ON [Order Details]

CREATE TRIGGER trg_update_order_change ON [Order Details]
AFTER UPDATE
AS
BEGIN
    DECLARE @NewSaleQuantity INT, @productID INT, @oldOrderUnit INT
    SELECT @productID = ProductID, @oldOrderUnit = Quantity
    FROM deleted
    SELECT @NewSaleQuantity = Quantity, @ProductID = ProductID
    FROM inserted

    if (@NewSaleQuantity < @oldOrderUnit) 
        BEGIN
        UPDATE Products SET UnitsInStock = UnitsInStock + (@oldOrderUnit - @NewSaleQuantity)
            WHERE ProductID = @ProductID
    END
    ELSE
        BEGIN
        UPDATE Products SET UnitsInStock = UnitsInStock - (@NewSaleQuantity - @oldOrderUnit)
            WHERE ProductID = @ProductID
    END
END
---------
CREATE TRIGGER trg_delete_order ON [Order Details]
FOR DELETE
AS
BEGIN
    DECLARE @ProductID INT, @SaleQuantity INT
    SELECT @SaleQuantity = Quantity, @ProductID = ProductID FROM deleted

    UPDATE Products SET UnitsInStock = UnitsInStock + @SaleQuantity
        WHERE ProductID = @ProductID
END