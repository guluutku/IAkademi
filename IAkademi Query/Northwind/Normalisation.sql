-- Normalisation (Normalizasyon)
-- tabloları ve kolonları birleştirip, hangi tablolar birbiriyle ilişkili ona karar vereceğiz

-- SELECT * FROM Products
-- SELECT * FROM [NORTHWND].[dbo].[Categories]
--------------------------

CREATE VIEW vw_urunleri_listele -- Query'yi kaydeder. Bir aynı isimde view olduğu için hata veriyor
as
SELECT p.ProductID, p.ProductName, 
c.CategoryID, c.CategoryName, 
s.SupplierID, s.CompanyName
FROM Products as p
INNER JOIN Categories as c -- Normalisation yapımı
ON p.CategoryID = c.CategoryID
INNER JOIN Suppliers as s
ON p.SupplierID = s.SupplierID


----- alias
-- SELECT * FROM Products as p

SELECT * FROM vw_urunleri_listele -- view'i çağırma