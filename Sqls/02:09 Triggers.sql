-- SELECT * FROM Products
-- SELECT * FROM [Order Details]

-- Triggers after insertion
CREATE TRIGGER trg_listele ON Tbl_Ogrenci
AFTER INSERT
AS
BEGIN
    SELECT * FROM Tbl_Ogrenci
END

-- Insertion example
INSERT INTO Tbl_Ogrenci 
VALUES('Tuğberk', 'Koçoğlu', 'E', '1996-12-14', 1, 1)
SELECT * FROM Tbl_Ogrenci

-- Disables trigger
DISABLE TRIGGER trg_listele ON Tbl_Ogrenci
-- Enables trigger
ENABLE TRIGGER trg_listele ON Tbl_Ogrenci
-- Delete trigger
DROP TRIGGER trg_listele ON Tbl_Ogrenci

-- Disables and enables all of the triggers inside Tbl_Ogrenci table
DISABLE TRIGGER ALL ON Tbl_Ogrenci
ENABLE TRIGGER ALL ON Tbl_Ogrenci