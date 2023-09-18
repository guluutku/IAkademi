SELECT * FROM Tbl_Kitap
SELECT * FROM Tbl_Yazar -- 4 
SELECT * FROM Tbl_Tur -- 6, 1 yok

INSERT INTO Tbl_Tur VALUES('Polisiye')
INSERT INTO Tbl_Yazar VALUES('Ayşe', 'Kulin')

INSERT INTO Tbl_Kitap 
VALUES('eeeee', '5555', 3, 3, 123, 4)
--- Kitap tablosu güncellenirken eski sayfa sayısı daha fazla olmalı
-- While updating Tbl_Kitap, new number of the pages must be bigger than old number 0f the pages
CREATE TRIGGER trg_sayfa_kontrol ON Tbl_Kitap
AFTER UPDATE
AS
BEGIN
    if(exists(
        SELECT * FROM inserted, deleted WHERE inserted.SayfaSayisi < deleted.SayfaSayisi
    ))
        RAISERROR('Yeni sayfa sayyisi eskisinden az olamaz', 1, 1)
        ROLLBACK TRANSACTION
END

UPDATE Tbl_Kitap SET SayfaSayisi = 400 WHERE KitapID = 3