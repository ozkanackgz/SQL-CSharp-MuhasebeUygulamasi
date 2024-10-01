
-- SELECT * FROM CARI_HESAP_HAREKETLERI

DECLARE @CARIKOD INT
SET @CARIKOD = 100

WHILE @CARIKOD <=109
BEGIN
   DECLARE @CSONRAKI INT

   IF @CARIKOD = 109
     SET @CSONRAKI = 100
   ELSE
     SET @CSONRAKI = @CARIKOD + 1
   
   INSERT INTO CARI_HESAP_HAREKETLERI(EVRAKSERI,EVRAKNO, CARIKOD, STOKKOD, BIRIMFIYAT, MIKTAR, TOPLAMFIYAT)
   SELECT EVRAKSERI, EVRAKNO, @CARIKOD, STOKKOD, BIRIMFIYAT, MIKTAR, TOPLAMFIYAT FROM CARI_HESAP_HAREKETLERI
       WHERE CARIKOD = @CSONRAKI
   
   SET @CARIKOD = @CARIKOD + 1
END