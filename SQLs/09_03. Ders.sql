SELECT * FROM [Order Details]
SELECT * FROM Products
INSERT INTO [Order Details] VALUES
(10248, 2, 750, 20, 0)

SELECT * FROM [Order Details] AS od
INNER JOIN Products AS p
ON od.ProductID = p.ProductID