-- CHARINDEX([aranan], [�zerinde aranacak], [ba�lang��])
SELECT CARIUNVAN, CHARINDEX('t', CARIUNVAN) as INDEKS, LEN(CARIUNVAN) AS UZUNLUK,
LOWER(CARIUNVAN) AS KUCUK, UPPER(CARIUNVAN) AS BUYUK,
REPLACE(CARIUNVAN, '-', '') AS DEGISIKLIK,
SUBSTRING(CARIUNVAN, 1, 4) AS ALTMETIN,
SUBSTRING(CARIUNVAN, CHARINDEX('-', CARIUNVAN)+1, 5) AS ALTMETIN2,
TELEFON, EMAIL FROM CARI_HESAPLAR

--DECLARE @STR VARCHAR(20)
--SET @STR = '  MERHABA D�NYA  '
--SELECT @STR, LTRIM(@STR) AS SOL, RTRIM(@STR) AS SAG