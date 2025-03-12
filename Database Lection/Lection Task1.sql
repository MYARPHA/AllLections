DECLARE @login VARCHAR(100) = 'admin';

DECLARE @year SMALLINT;
SET @year = 2024;

DECLARE @maxPrice DECIMAL(16, 2);
SET @maxPrice = (SELECT MAX(Price)
				FROM Game);

SELECT @login, @year, @maxPrice;
PRINT @login;
PRINT CONCAT_WS(' ', @login, @year, 'год', @maxPrice);

