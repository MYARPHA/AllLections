/*-- 1
SELECT ����������(���������); -- SELECT GetDate();

-- 2
SET ������������� = ����������(���������);

-- 3
SELECT ����������(����������)
FROM ...;

SELECT Name, Price, ROUND(Price, -2)
FROM Game;

SELECT...
FROM ����������(���������);
*/
-- ����� ���� �����
CREATE FUNCTION GetSum
(
	@a INT,
	@b INT = 1 -- �������� �� ���������
)
RETURNS INT
AS
BEGIN
	RETURN @a+@b;
END;

SELECT dbo.GetSum(2, 3);
SELECT dbo.GetSum(2, DEFAULT);


