
declare @s int 
SET @s = 0
print 'd�ng� �ncesi'
WHILE 1 = 1
BEGIN
    set @s = @s + 1

	if @s % 2 = 0
	    continue;

	if @s >= 10
	    break;

	print @s
END
print 'd�ng� bitti'