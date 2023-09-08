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
VALUES('Duygu', 'Yiğit', 'K', '2002-12-14', 1, '10A', 1)

INSERT INTO Tbl_Ogrenci 
VALUES('Hamit', 'Canayakın', 'E', '2001-12-14', 1, '10A', 1)

SELECT * FROM Tbl_Ogrenci
UPDATE Tbl_Ogrenci SET Sinif = '10A'

-- Disables trigger
DISABLE TRIGGER trg_listele ON Tbl_Ogrenci
-- Enables trigger
ENABLE TRIGGER trg_listele ON Tbl_Ogrenci
-- Delete trigger
DROP TRIGGER trg_listele ON Tbl_Ogrenci

-- Disables and enables all of the triggers inside Tbl_Ogrenci table
DISABLE TRIGGER ALL ON Tbl_Ogrenci
ENABLE TRIGGER ALL ON Tbl_Ogrenci

-- 10A sınıfına sadece kız öğrenciler kayıt yapabilsin
-- Only female students can register 10A classroom
CREATE TRIGGER trg_cinsiyet ON Tbl_Ogrenci
FOR INSERT
AS
BEGIN
    IF (exists(SELECT * FROM inserted WHERE Sinif = '10A' AND Cinsiyet = 'E'))
        BEGIN
            RAISERROR('10A Sınıfına Erkek Öğrenci Kaydı yapılamaz', 1, 1)
            ROLLBACK TRANSACTION -- Reject action
        END
END

-- Don't delete girls from 10A classroom
CREATE TRIGGER trg_10a_kiz_ogrenciler_silinemez ON Tbl_Ogrenci
AFTER DELETE
AS
BEGIN
    IF (exists(SELECT * FROM deleted WHERE Sinif = '10A' AND Cinsiyet = 'K'))
        BEGIN
            RAISERROR('10A Sınıfına Kız Öğrenci Kaydı Silinemez', 2, 1)
            ROLLBACK TRANSACTION -- Reject action
        END
END

-- Delete example
SELECT * FROM Tbl_Ogrenci
DELETE FROM Tbl_Ogrenci WHERE OgrenciID = 1008 -- Girl student