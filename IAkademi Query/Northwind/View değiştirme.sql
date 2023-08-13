SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[vw_urunleri_listele]
as
SELECT p.ProductID, p.ProductName, 
c.CategoryID, c.CategoryName, 
s.SupplierID, s.CompanyName
FROM Products as p
INNER JOIN Categories as c
ON p.CategoryID = c.CategoryID
INNER JOIN Suppliers as s
ON p.SupplierID = s.SupplierID

GO
