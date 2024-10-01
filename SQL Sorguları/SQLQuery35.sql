




CREATE VIEW V_LOG
AS
SELECT LID,
       TABLOADI,
	   TARIH,
	   ISLEMTURU,
	   CONVERT(VARCHAR(20), TARIH, 104) + ' ' + CONVERT(VARCHAR(20), TARIH, 8) + ' => ' +
	   CONVERT(VARCHAR(10), KAYITNO) + ' numaral� kay�t ' + TABLOADI +
	               CASE ISLEMTURU WHEN 'Yeni Kay�t' THEN ' tablosuna eklendi '
				                  WHEN 'Kay�t G�ncelleme' THEN ' tablosunda g�ncellendi' END AS ISLEM_METNI

FROM LOG