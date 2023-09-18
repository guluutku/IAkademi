ALTER TABLE Tbl_Tur ADD Tarih DATETIME NULL

CREATE TRIGGER trg_tur_tarih_update ON Tbl_Tur
AFTER UPDATE
AS
BEGIN
    UPDATE Tbl_Tur SET Tarih = GETDATE() WHERE TurID in (SELECT TurID FROM deleted)
END
-----------
UPDATE Tbl_Tur SET TurAdi = 'Romantik' WHERE TurID = 6