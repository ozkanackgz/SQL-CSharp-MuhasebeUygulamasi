
-- depo miktar� 0 ise 'Sipari� Verilecek' [1,500] aras�nda ise 'Zam Yapal�m', aksi durumda '�ndirim Yapal�m'
SELECT *,
CASE
    WHEN MIKTAR = 0 THEN 'Sipari� Verilecek'
	WHEN MIKTAR >= 1 AND MIKTAR <= 500 THEN 'Zam Yapal�m'
    WHEN MIKTAR > 500 THEN '�ndirim Yapal�m'
END AS KARAR
FROM STOKLAR
/*
CASE
    WHEN [condition-1] THEN [statement-1]
	WHEN [condition-2] THEN [statement-2]
	WHEN [condition-3] THEN [statement-3]
	...
	...
END
*/
