CREATE FUNCTION FN_CARIEVRAKSAYISI 
(
	@CKOD VARCHAR(10)
)
RETURNS INT
AS
BEGIN
	DECLARE @S INT
	SELECT @S = COUNT(DISTINCT(EVRAKNO)) FROM CARI_HESAP_HAREKETLERI WHERE CARIKOD = @CKOD
	RETURN @S

END
GO

