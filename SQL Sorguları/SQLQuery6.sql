SELECT * FROM CARI_HESAPLAR
SELECT MAX(CARIKOD)+1 FROM CARI_HESAPLAR

DECLARE @carikod VARCHAR (10) -- cari kod de�erini tutacak de�i�ken
DECLARE @ad VARCHAR(100)
DECLARE @email VARCHAR(100)
DECLARE @ehtedarikci bit
DECLARE @adres VARCHAR(100)
SET @carikod = (SELECT MAX(CARIKOD)+1 FROM CARI_HESAPLAR)
SELECT @carikod = MAX(CARIKOD)+1 FROM CARI_HESAPLAR
SET @ad = 'M��teri-' + @carikod
SET @email = 'musteri' + @carikod + '@gmail.com'
SET @ehtedarikci = @carikod % 2
SET @adres = 'M��teri-' + @carikod

SELECT @carikod, @ad, @email, @ehtedarikci, @adres

INSERT INTO CARI_HESAPLAR(CARIKOD, CARIUNVAN, TELEFON, EMAIL, EH_TEDARIKCI, ADRES)
SELECT @carikod, @ad, '4621000004', @email, @ehtedarikci, @adres

SELECT * FROM CARI_HESAPLAR

