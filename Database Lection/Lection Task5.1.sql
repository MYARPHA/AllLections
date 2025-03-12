-- список игр по категории
CREATE FUNCTION GetGamesByCategory
(
	@name NVARCHAR(100)
)
RETURNS TABLE 
AS
	RETURN 
	(
		SELECT Game.*
		FROM Game JOIN Category ON Game.CategoryId=Category.CategoryId
		WHERE Category.Name = @name
	)

SELECT *
FROM dbo.GetGamesByCategory('RPG')
