

SELECT * FROM CARI_HESAPLAR

INSERT INTO CARI_HESAPLAR (CARIKOD, CARIUNVAN, TELEFON, EMAIL, EH_TEDARIKCI)
VALUES('102','M��teri-3','4621000002','musteri3@gmail.com',1)

UPDATE CARI_HESAPLAR SET EH_TEDARIKCI = 1 WHERE CARIKOD = '100'