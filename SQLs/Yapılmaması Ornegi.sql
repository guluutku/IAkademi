ALTER view [dbo].[vw_urun_listele]
as
SELECT P.*, C.CCategoryName from Products as P
inner join Categories as C
on P.CategoryID = C.CategoryID
GO