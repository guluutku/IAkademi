-- Tbl_Tur silinemez
-- Tbl_Tur cannot be deleted

CREATE TRIGGER trg_tur_silinemez ON Tbl_Tur
AFTER DELETE
AS
BEGIN
    RAISERROR('Tur Tablosu silinemez', 1, 1)
    ROLLBACK TRANSACTION
END