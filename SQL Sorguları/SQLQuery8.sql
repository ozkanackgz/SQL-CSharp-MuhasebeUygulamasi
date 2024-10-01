
-- depo miktarý 0 ise 'Sipariþ Verilecek' [1,500] arasýnda ise 'Zam Yapalým', aksi durumda 'Ýndirim Yapalým'
SELECT *,
CASE
    WHEN MIKTAR = 0 THEN 'Sipariþ Verilecek'
	WHEN MIKTAR >= 1 AND MIKTAR <= 500 THEN 'Zam Yapalým'
    WHEN MIKTAR > 500 THEN 'Ýndirim Yapalým'
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
