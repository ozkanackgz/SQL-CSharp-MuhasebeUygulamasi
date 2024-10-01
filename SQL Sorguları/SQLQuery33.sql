
DECLARE @kadi varchar (20), @sifre varchar(20)

set @kadi = 'bilgehan'
set @sifre = '123'

SELECT * FROM KULLANICILAR WHERE KULLANICIADI = @kadi AND SIFRE = @sifre 

