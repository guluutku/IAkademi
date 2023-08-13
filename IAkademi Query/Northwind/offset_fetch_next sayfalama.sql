
-- sıfırdan başla 10 ürün getir
SELECT * FROM [NORTHWND].[dbo].[Products] ORDER BY ProductID 
OFFSET 0 ROWS
FETCH NEXT 10 ROWS ONLY
-------------

--0-20, 20-20, 40-20, 60-20
-- sayfaNo - 1 * 20
------------

-- CREATE PROCEDURE sp_sayfalama
-- (
--    @baslangic int,
--    @adet int,
-- ) AS
-- SELECT * FROM [NORTHWND].[dbo].[Products] ORDER BY ProductID 
-- OFFSET @baslangic ROWS
-- FETCH NEXT @adet ROWS ONLY
------------------------

