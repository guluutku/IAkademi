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

select POWER(3, 2) -- üs alma
select SQUARE(5) -- karesini alma
select SQRT(9) -- karekök alma

select ROUND(2345.2146, 2) -- Virgül sonrasında 2 karakter göster, sonraki karakterleri yuvarla
select CEILING(2345.2146) -- yukarı yuvarla
select FLOOR(2345.21445) -- aşağı yuvarla

-- Positif mi negatif mi göster
select SIGN(225.5)
select SIGN(0)
select SIGN(-225.5)

select AVG(UnitPrice) as [ORTALAMA FİYAT] from Products -- verilen sayıların ortalaması alınır
														-- ver tabanı içinde kullanım şekli
select COUNT(*) as [ÜRÜN SAYISI] from Products where CategoryID = 4 -- veri tabanından veri sayısını al

select MAX(UnitPrice) from Products
select MIN(UnitPrice) from Products

select SUM(Quantity) as ADEST from [Order Details] where tarih = GETDATE()
select SUM(UnitsInStock) from Products -- toplam veri sayısı

select top 5 * from Products order by NEWID() -- rastgele 5 ürün

-- tarihsel hazır fonksiyonlar
select GETDATE()
select GETUTCDATE() -- merkezi saat
select YEAR(GETDATE()) -- Belirli bir tarih şeklini seç
select MONTH(GETDATE())
select DAY(GETDATE())

select FirstName, LastName, BirthDate, YEAR(GETDATE()) - YEAR(BirthDate) as YAŞ from Employees