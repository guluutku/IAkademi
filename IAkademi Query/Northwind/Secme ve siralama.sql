select top 4 * FROM Products WHERE CategoryID = '4' or SupplierID IN ('5', '6', '7') 
AND UnitPrice BETWEEN 10 and 35 ORDER BY ProductName