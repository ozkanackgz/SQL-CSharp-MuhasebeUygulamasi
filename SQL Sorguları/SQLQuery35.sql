




CREATE VIEW V_LOG
AS
SELECT LID,
       TABLOADI,
	   TARIH,
	   ISLEMTURU,
	   CONVERT(VARCHAR(20), TARIH, 104) + ' ' + CONVERT(VARCHAR(20), TARIH, 8) + ' => ' +
	   CONVERT(VARCHAR(10), KAYITNO) + ' numaralý kayýt ' + TABLOADI +
	               CASE ISLEMTURU WHEN 'Yeni Kayýt' THEN ' tablosuna eklendi '
				                  WHEN 'Kayýt Güncelleme' THEN ' tablosunda güncellendi' END AS ISLEM_METNI

FROM LOG