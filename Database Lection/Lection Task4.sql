-- средн€€ цена игры по категории
CREATE FUNCTION GetAvgPrice
(
	@idCategory INT
)
RETURNS DECIMAL(16,2)
AS
BEGIN
	DECLARE @avgPrice DECIMAL(16,2);

	SET @avgPrice = (SELECT AVG(Price)
						FROM Game
						WHERE @idCategory = CategoryId);
	RETURN @avgPrice;
END;

SELECT *, dbo.GetAvgPrice(CategoryId)
FROM Category;
