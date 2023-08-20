-- gunction (fonksiyon)
-- 2 sayıyı toplayan func
create function fn_toplama(@sayi1 int, @sayi2 int)
returns int
as
begin
	declare @toplam int
	set @toplam = @sayi1 + @sayi2
	return @toplam
end
---- test
select dbo.fn_toplama(3,8)