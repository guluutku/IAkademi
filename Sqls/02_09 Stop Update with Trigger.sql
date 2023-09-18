-- Stop update table with trigger
CREATE TRIGGER trg_guncellenmesin_cinsiyet ON Tbl_Ogrenci
AFTER UPDATE
AS
BEGIN
    if(exists(SELECT * FROM inserted, deleted WHERE inserted.OgrenciID = deleted.OgrenciID AND inserted.Cinsiyet != deleted.Cinsiyet))
        BEGIN
            RAISERROR ('Cinsiyet değiştirilemez', 1, 1)
        END
END
-- Alter
ALTER TRIGGER trg_guncellenmesin_cinsiyet ON Tbl_Ogrenci
AFTER UPDATE
AS
BEGIN
    if(exists(SELECT * FROM inserted, deleted WHERE inserted.OgrenciID = deleted.OgrenciID AND inserted.Cinsiyet != deleted.Cinsiyet))
        BEGIN
            RAISERROR ('Cinsiyet değiştirilemez', 1, 1)
            ROLLBACK TRANSACTION
        END
END
-------
UPDATE Tbl_Ogrenci SET Cinsiyet = 'K' WHERE OgrenciID = 3