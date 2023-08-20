-- Insert
-- create procedure sp_insert_products
--(
--@ProductName nvarchar(40),
--@UnitPrice money,
--@UnitsInStock smallint,
--@CategoryID int,
--@SupplierID int
--)
--as
--insert into [NORTHWND].[dbo].[Products] (ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID)
--values (@ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @SupplierID)

-- Update
create proc sp_update_products
(
@ProductName nvarchar(40),
@UnitPrice money,
@UnitsInStock smallint,
@CategoryID int,
@SupplierID int,
@ProductID int
)
as
update [NORTHWND].[dbo].[Products] set ProductName = @ProductName, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, 
CategoryID = @CategoryID, SupplierID = @SupplierID
where ProductID = @ProductID