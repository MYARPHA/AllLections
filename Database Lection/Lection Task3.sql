/*-- 1
SELECT им€‘ункции(параметры); -- SELECT GetDate();

-- 2
SET им€ѕеременной = им€‘ункции(параметры);

-- 3
SELECT им€‘ункции(им€—толбца)
FROM ...;

SELECT Name, Price, ROUND(Price, -2)
FROM Game;

SELECT...
FROM им€‘ункции(параметры);
*/
-- сумма двух чисел
CREATE FUNCTION GetSum
(
	@a INT,
	@b INT = 1 -- значение по умолчанию
)
RETURNS INT
AS
BEGIN
	RETURN @a+@b;
END;

SELECT dbo.GetSum(2, 3);
SELECT dbo.GetSum(2, DEFAULT);


