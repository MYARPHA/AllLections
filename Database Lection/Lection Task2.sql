IF (5>0)
	BEGIN
		PRINT '5>0';
	END
ELSE
	BEGIN
		PRINT 'not 5>0';
	END

DECLARE @usersCount INT = 15;
DECLARE @i INT = 1;
WHILE @i <= @usersCount
BEGIN
	DECLARE @login VARCHAR(10);
	IF (@i < 10)
		SET @login = CONCAT('ispp350', @i);
	ELSE
		BEGIN 
		BREAK	
		SET @login = CONCAT('ispp35', @i);
		END 
	PRINT @login;
	SET @i += 1;
END;

THROW 51000, 'текст ошибки', 1;

BEGIN TRY
	;--действия
END TRY
BEGIN CATCH
	;--действия
END CATCH