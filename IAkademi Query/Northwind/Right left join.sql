-- Fazladan bağlanmamış kategori var
-- Kategori tablosundaki herşeyi gösterir
SELECT * FROM Products AS p
RIGHT JOIN Categories AS c
on p.CategoryID = c.CategoryID

SELECT * FROM Products AS p
FULL OUTER JOIN Categories AS c
on p.CategoryID = c.CategoryID