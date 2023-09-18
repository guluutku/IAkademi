-- Bütün tablonun yedeği
-- Backup all table
SELECT * INTO YedekProduct FROM Products
SELECT * INTO YedekProduct5 FROM Products ORDER BY UnitPrice
-- Belli kolonların yedeği
-- Backup some of the collumns
SELECT ProductID, ProductName, UnitPrice INTO YedekProduct2 FROM Products
-- Belli şarta göre yedek
-- Backup with condition
SELECT * INTO YedekProduct3 FROM Products WHERE UnitPrice > 20 AND UnitPrice < 30
SELECT * INTO YedekProduct4 FROM Products WHERE UnitPrice BETWEEN 20 AND 30
-- Standart versiyon ve üstü olmalı
-- Express'de çalışmaz
/*
    Job oluşturma
*/