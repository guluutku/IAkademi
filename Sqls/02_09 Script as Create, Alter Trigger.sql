SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_listele] ON [dbo].[Tbl_Ogrenci]
AFTER INSERT
AS
BEGIN
    SELECT * FROM Tbl_Ogrenci
END
GO
ALTER TABLE [dbo].[Tbl_Ogrenci] ENABLE TRIGGER [trg_listele]
GO
-- Change inside trigger
ALTER TRIGGER [dbo].[trg_listele] ON [dbo].[Tbl_Ogrenci]
AFTER INSERT
AS
BEGIN
    SELECT * FROM Tbl_Ogrenci ORDER BY Ad
END
GO