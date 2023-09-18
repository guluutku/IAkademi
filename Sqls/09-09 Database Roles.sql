
-- [db_owner] veri tabanındaki en yüksek yetki
-- CRUD işlemleri yapar, başlatma- durdurma yetkisi var

-- [db_accessadmin] kullanıcılara veri tabanına erişim, yetki atayandır

-- [db_securityadmin] database'deki yetki/kural yönetir

-- [db_datareader] kullanıcılara SELECT sorgusunu çalıştırmasına izin verir

-- [db_datawriter] insert, update, delete

-- [db_ddladmin] DDl komutlarını çalıştırır
--  create, alter, drop table
-- truncate table yapıyor
-- create/drop trigger, view, stored procedure, function, index, constraints
-- constraints: Primery Key, Foreign Key, Unique, Check, Default

-- [db_denydatareader] SELECT sorgusunun çalıştırmasını kısıtlar
-- seçili kolonları, tabloları, vb. göremesin

-- [db_denydatawriter] INSERT, UPDATE ve DELETE sorgusunun çalıştırmasını kısıtlar
-- seçili kolonları, tabloları, vb. değiştirmesin

-- [db_backupoperator] yedek alır

-- DDl , Data Definition language (Veri İşleme Dili)

-- DMl , Data Mapulation language (Veri İşleme Dili)
-- SELECT, UPDATE, DELETE, INSERT

-- DCl , Data Control Language (Veri Kontrol Dili)
-- Kullanıcıların role ile ilgili izinlerini düzenler
-- grant, deny
-- revoke daha önce verilen tüm izin ve kısıtlamaları iptal eder

-- [diskadmin] disk dosyalarının yönetimini sağlar

-- [processadmin] çalışan işlemleri kontrol eder
