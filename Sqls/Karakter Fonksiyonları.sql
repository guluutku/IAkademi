﻿-- Karakter fonksiyonları
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
