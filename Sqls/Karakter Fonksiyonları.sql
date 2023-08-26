-- Karakter fonksiyonları
select CHAR(65) -- Ascii tablosunda 65 nolu index'in değerini olduğunu verir
select ASCII('A') -- Ascii tablosunda 65 nolu indexte olduğunu verir
-- metin içinde aranmak istenen kısmı arar
select CHARINDEX('ww','www.gunuluutku.com',0) -- bulursa index numarası, bulamazsa 0
select LEFT('www.gunluutku.com',7) -- Solundan itibaren 7 karater getir, RIGHT'de kullanılabilir