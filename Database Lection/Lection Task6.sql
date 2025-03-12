CREATE PROCEDURE dbo.AddCategory 
    @name NVARCHAR(100),
    @id INT OUTPUT 
AS
BEGIN
    INSERT INTO Category(name) VALUES(@name);
	SET @id = SCOPE_IDENTITY();
END
-- גûחמג
DECLARE @n INT;
EXEC AddCategory 'arcada', @n OUTPUT;
SELeCT @n