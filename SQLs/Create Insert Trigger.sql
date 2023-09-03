CREATE TRIGGER [dbo].[trg_StockInsert] on [Order Details]
FOR INSERT
AS
BEGIN
    DECLARE  @Quantity int, @ProductID INT
    SELECT @Quantity = Quantity, @ProductID = ProductID from inserted
    UPDATE Products set UnitsInStock = UnitsInStock - @Quantity
    WHERE ProductID = @ProductID
END
GO