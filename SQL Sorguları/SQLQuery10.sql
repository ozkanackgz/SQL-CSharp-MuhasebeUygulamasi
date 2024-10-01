-- DELETE FROM CARI_HESAP_HAREKETLERI
DECLARE @CKAYIT INT, @CKOD VARCHAR(10), @ENO INT
SET @CKAYIT = 5
SET @ENO = 1
WHILE 1 = 1
BEGIN
    SET @CKOD = NULL
	SELECT TOP 1 @CKOD = CH.CARIKOD
	FROM CARI_HESAPLAR CH LEFT OUTER JOIN CARI_HESAP_HAREKETLERI CHH ON CH.CARIKOD = CHH.CARIKOD
	GROUP BY CH.CARIKOD, CHH.STOKKOD 
	HAVING COUNT(CHH.STOKKOD) = 0

	PRINT 'CAR� HESAP HAREKET� OLU�TURULACAK CAR� KODU : ' + @CKOD

	IF @CKOD IS NULL
	    BREAK;

		INSERT INTO CARI_HESAP_HAREKETLERI(EVRAKSERI, EVRAKNO, CARIKOD, STOKKOD, BIRIMFIYAT, MIKTAR, TOPLAMFIYAT)
		SELECT TOP 5 'TEST',@ENO, @CKOD, STOKKOD, GUNCELFIYAT, @ENO*2, GUNCELFIYAT * @ENO * 2
		    FROM STOKLAR ORDER BY GUNCELFIYAT DESC
		SET @ENO = @ENO + 1
END
SELECT * FROM CARI_HESAP_HAREKETLERI