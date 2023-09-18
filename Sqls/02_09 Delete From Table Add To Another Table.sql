-- Deleted students are sent to another table when deleted
-- Save Student name, surname in Tbl_Mezun (Graduate)
-- CREATE TABLE Tbl_Mezun(Ad NVARCHAR(50), Soyad NVARCHAR(50))

CREATE TRIGGER trg_silinen_ekle ON Tbl_Ogrenci
AFTER DELETE
AS
BEGIN
    INSERT INTO Tbl_Mezun SELECT Ad, Soyad FROM deleted
END
----
SELECT * FROM Tbl_Mezun
SELECT * FROM Tbl_Ogrenci

DELETE FROM Tbl_Ogrenci WHERE OgrenciID = 2