SELECT * FROM STOKLAR
DECLARE @kod varchar(10), @ad varchar(50), @fiyat decimal(18,2), @miktar bigint
SELECT @kod = MAX(STOKKOD) + 1 FROM STOKLAR
print 'kod : ' + @kod
SELECT @fiyat = GUNCELFIYAT + 10 FROM STOKLAR WHERE STOKKOD = @kod -1
print 'fiyat : ' + CONVERT(VARCHAR(20), @fiyat)
-- fiyat deðeri 100 TL altýnda ise 1000 adet, [100, 140] arasýnda ise 750 adet, 140 TL'den büyük ise 500 adet
IF @fiyat < 100
BEGIN
    SET @miktar = 1000
END
ELSE
BEGIN
    IF @fiyat <= 140
	BEGIN
	    SET @miktar = 750
	END
	ELSE
	BEGIN
	    SET @miktar = 500
	END
END
print 'miktar : ' + CAST(@miktar as VARCHAR(5))
INSERT INTO STOKLAR
SELECT @kod, 'Stok-' + @kod, @fiyat, @miktar
SELECT * FROM STOKLAR
/*
IF [condition]
BEGIN
    [TRUE STATEMENT]
END
ELSE
BEGIN
    [FALSE STATEMENT]
END
 
 CAST([donusturulecekDeger] AS [donusturulecekVeriTipi])
 CONVERT([donusturulecekVeriTipi], [donusturulecekDeger])
 */