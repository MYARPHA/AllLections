Store Procedure sp_

CREATE PROCEDURE ... -- 1 вариант 

CREATE PROCEDURE dbo.Sample_Procedure -- шаблон
    @param1 int = 0,
    @param2 int  
AS
    SELECT @param1,@param2

EXEC имяПроцедуры имяПарам1, имяПарам2, имяПарам3 OUTPUT;

имяПроцедуры имяПарам1 = значение, имяПарам3 OUTPUT

