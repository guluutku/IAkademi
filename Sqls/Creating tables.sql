-- Tbl_Ogrenci (OgrenciID, Ad, Soyad, Cinsiyet, DTarih, BolumID, Aktif)
-- Tbl_Bolum ( BolumID, BolumAdi)
-- Tbl_Kitap (KitapID, KitapAdi, IsbnNo, YazarID, SayfaSayisi, Puan)
-- Tbl_Yazar (YazarID, YazarAdi, YazarSoyadi)
-- Tbl_Tur (TurID, TurAdi)
-- Tbl_Islem(IslemID, OgrenciID, KitapID, ATarih, VTarih) -- Ara Tablo

INSERT INTO Tbl_Ogrenci (Ad, Soyad, Cinsiyet, DTarih, BolumID, Aktif)
VALUES ('Celal', 'bbbb', 'E', '2000-04-28', 5, 1)

TRUNCATE TABLE Tbl_Ogrenci -- Müşteriye verirken tabloyu bu şekilde temizle