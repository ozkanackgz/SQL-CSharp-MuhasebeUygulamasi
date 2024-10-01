CREATE TRIGGER TRG_KULLANICILAR_AU ON KULLANICILAR
   AFTER UPDATE  
AS 
BEGIN
	
	DECLARE @KAYITNO INT

	SELECT @KAYITNO = KNO FROM inserted

	INSERT INTO LOG(TABLOADI, ISLEMTURU, TARIH, KAYITNO)
	VALUES('KULLANICILAR', 'Kay�t G�ncelleme', GETDATE(), @KAYITNO)

END
GO


