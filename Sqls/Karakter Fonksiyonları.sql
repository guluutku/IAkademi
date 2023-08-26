-- Karakter fonksiyonları
select CHAR(65) -- Ascii tablosunda 65 nolu index'in değerini olduğunu verir
select ASCII('A') -- Ascii tablosunda 65 nolu indexte olduğunu verir
-- metin içinde aranmak istenen kısmı arar
select CHARINDEX('ww','www.gunuluutku.com',0) -- bulursa index numarası, bulamazsa 0
select LEFT('www.gunluutku.com',7) -- Solundan itibaren 7 karater getir, RIGHT'de kullanılabilir
select RIGHT('www.gunluutku.com',7) 
Select LEN('www.gunululu.com') -- uzunluk verir
select LOWER('www.GUNulu.Com') -- hepsini küçük karaktere dönüştürür
select UPPER('www.GUNulu.Com') -- hepsini büyük karaktere dönüştürür
insert into [NORTHWND].[dbo].[Products](ProductName, UnitPrice, CategoryID, SupplierID)
values(LOWER('TeLeVizYOn'),1000, 4, 5)
select * from [NORTHWND].[dbo].[Products] order by ProductID desc
-----------------
select LTRIM('            gu n     q') -- sol taraftaki boşluğu siler
select RTRIM('            gu n     ') -- sağ taraftaki boşluğu siler
select TRIM('            gu n     ') -- sağ ve sol taraftaki boşluğu aynı anda siler
--------------
select REVERSE('wwww.gunluul.com') -- tersine çevirir

select SUBSTRING('wwww.gunuluaswdf.com', 5, 10) -- belli bir aralıktaki string'i alır
												-- site ismini almak için kullanılabilir
select REPLACE('wwww.gunuluaswdf.com', 'aswdf', 'replace')
---
select STUFF('wwww.gunuluaswdf.com', 5, 10, 'STUFF')

select CONCAT('Gün', 'uluutku') as [isim Soyisim]

select PATINDEX('%a%', ProductName), ProductName from Products

-- Matematiksel Fonksiyonlar
select ABS(3) as sonuc -- mutlak değer
select ABS(-3) as sonuc

insert into [NORTHWND].[dbo].[Products](ProductName, UnitPrice, CategoryID, SupplierID)
values (LOWER('TelEVizYon'), ABS(-1000), 4, 5)

