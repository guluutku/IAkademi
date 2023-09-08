-- New column  to the table
ALTER TABLE Tbl_Ogrenci ADD Silindi BIT NULL

UPDATE Tbl_Ogrenci SET Silindi = 0

CREATE TRIGGER trg_ogrenci_sil ON Tbl_Ogrenci
INSTEAD OF DELETE
AS 
BEGIN
    UPDATE Tbl_Ogrenci SET Silindi = 1 
    WHERE OgrenciID in (SELECT OgrenciID FROM deleted)
END
------
DELETE FROM Tbl_Ogrenci WHERE OgrenciID = 3