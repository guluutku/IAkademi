-- insert
create proc sp_insert_products
(
@ProductName nvarchar(40),
@UnitPrice money,
@UnitsInStock smallint,
@CategoryID int,
@SupplierID int
)
as
insert into [NORTHWND].[dbo].[Products] (ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID)
values
(@ProductName, @UnitPrice, @UnitsInStock, @CategoryID, @SupplierID)
