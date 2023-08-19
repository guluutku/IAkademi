-- stored procedure
create procedure sp_urun_detayi_getir
@degisken int
as
select * from [NORTHWND].[dbo].[Products] where ProductID = @degisken