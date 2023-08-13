
SELECT ProductID AS ID, ProductName AS ÜRÜNADI
FROM [NORTHWND].[dbo].[Products]

-- [iletişim bilgileri] olarak da kullanılabilir
SELECT CompanyName AS ŞİRKETİSMİ, ContactName AS iletişim_bilgileri
FROM [NORTHWND].[dbo].[Customers]

-- Takma adları birleştirebilirsin
-- AS kullanılamıya da bilir
SELECT CompanyName ŞİRKETİSMİ, Address  +','+ PostalCode +','+ City  +','+ Country iletişim_bilgileri
FROM [NORTHWND].[dbo].[Customers]