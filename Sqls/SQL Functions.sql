-- gunction (fonksiyon)
-- 2 sayıyı toplayan func
create function fn_toplama(@sayi1 int, @sayi2 int)
returns int
as
begin
	declare @toplam int
	set @toplam = @sayi1 + @sayi2
	return @toplam
end
---- test
select dbo.fn_toplama(3,8)
--------- Hazır Fonksiyon
select SUBSTRING('www.website.com',10,4)
---- ad ve soyad gönder, birleştir ve geri gönder. CONCAT
select EmployeeID, FirstName, LastName CONCAT(FirstName, LastName) from [NORTHWND].[dbo].[Employees]
------
create function fn_birlestir(@Ad nvarchar(20), @Soyad nvarchar(30))
returns nvarchar(51)
as
begin
	return @Ad + Space(1) + @Soyad
end
----test
select dbo.fn_birlestir(gün, Ulurku)
-----------
select COUNT(*) from [NORTHWND].[dbo].[Products] where SupplierID = 1

-----
create function fn_urun_adet(@SupplierID int)
returns int
as
begin
	return (select COUNT(*) from [NORTHWND].[dbo].[Products] where SupplierID = @SupplierID)
end
-------- func and view
create view vw_marka_listesi
as
select SupplierID, CompanyName, dbo.fn_urun_adet(SupplierID) as [ÜRÜN SAYISI]
from [NORTHWND].[dbo].[Suppliers]

select * from vw_marka_listesi order by SupplierID
-- alter procedure
alter procedure sp_marka_listesi
(
@search nvarchar(50)
)
as
select SupplierID, CompanyName, dbo.fn_urun_adet(SupplierID) as [ÜRÜN SAYISI]
from [NORTHWND].[dbo].[Suppliers] where CompanyName like '%'+@search+'%'  order by SupplierID
-- test
exec sp_marka_listesi 't'
--------- Yaş Hesaplama
create function fn_yas_hesapla(@tarih datetime)
returns int
as 
begin
	declare @sonuc int
	set @sonuc = DATEDIFF(YEAR, @tarih, GETDATE())
	return @sonuc
end
--- test
select dbo.fn_yas_hesapla('1997-08-17')
select GETDATE()
----------
-- 1. parametrenin 2. parametreye tam bölünüp bölünmediği bulunsun
create function fn_tam_bolunur_mu(@sayi1 int, @sayi2 int)
returns nvarchar(19)
as
begin
	declare @mesaj nvarchar(10)
	if (@sayi1 % @sayi2 = 0)
		set @mesaj = 'Tam bölünüyor'
	else
		set @mesaj = 'Bölünmez'
	return @mesaj
end
-- test
select dbo.fn_tam_bolunur_mu(103,2)