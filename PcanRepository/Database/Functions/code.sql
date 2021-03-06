USE [PCanRepository]
GO
/****** Object:  UserDefinedFunction [dbo].[BinaryToDecimal]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BinaryToDecimal]
(
	@Input varchar(255)
)
RETURNS bigint
AS
BEGIN

	DECLARE @Cnt tinyint = 1
	DECLARE @Len tinyint = LEN(@Input)
	DECLARE @Output bigint = CAST(SUBSTRING(@Input, @Len, 1) AS bigint)

	WHILE(@Cnt < @Len) BEGIN
		SET @Output = @Output + POWER(CAST(SUBSTRING(@Input, @Len - @Cnt, 1) * 2 AS bigint), @Cnt)

		SET @Cnt = @Cnt + 1
	END

	RETURN @Output	

END




GO
/****** Object:  UserDefinedFunction [dbo].[BinaryToDecimal2]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BinaryToDecimal2]
(
	@Input varchar(255)
)
RETURNS bigint
AS
BEGIN

	DECLARE @Cnt tinyint = 1
	DECLARE @Len tinyint = LEN(@Input)
	DECLARE @Output bigint = CAST(SUBSTRING(@Input, @Len, 1) AS bigint)

	WHILE(@Cnt < @Len) BEGIN
		SET @Output = @Output + POWER(CAST(SUBSTRING(@Input, @Len - @Cnt, 1) * 2 AS bigint), @Cnt)

		SET @Cnt = @Cnt + 1
	END

	RETURN @Output	

END



GO
/****** Object:  UserDefinedFunction [dbo].[ConvertTimeToMillSeconds]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[ConvertTimeToMillSeconds]
(
	-- Add the parameters for the function here
	@inTime AS time
)
RETURNS decimal(20,6)
AS
BEGIN

DECLARE @hr int = 	datepart(hour, @inTime) * 3600;
DECLARE @min int = 	datepart(MINUTE, @inTime) * 60;
DECLARE @sec int = 	datepart(SECOND, @inTime) * 1;
DECLARE @mse decimal(20,6) = CONVERT(decimal(20,7), RIGHT(@inTime,7)/10000000.000000);
	
	RETURN @hr + @min + @sec + @mse;

END




GO
/****** Object:  UserDefinedFunction [dbo].[ConvertTimeToSecondsWithFractions]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create FUNCTION [dbo].[ConvertTimeToSecondsWithFractions]
(
	-- Add the parameters for the function here
	@inTime AS time
)
RETURNS decimal(20,6)
AS
BEGIN

DECLARE @hr int = 	datepart(hour, @inTime) * 3600;
DECLARE @min int = 	datepart(MINUTE, @inTime) * 60;
DECLARE @sec int = 	datepart(SECOND, @inTime) * 1;
DECLARE @mse decimal(20,6) = CONVERT(decimal(20,7), RIGHT(@inTime,7)/10000000.000000);
	
	RETURN @hr + @min + @sec + @mse;

END


GO
/****** Object:  UserDefinedFunction [dbo].[DataSystem_SummaryTables_fuc_GetNextProcessDate]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Function [dbo].[DataSystem_SummaryTables_fuc_GetNextProcessDate](@VinID int)
RETURNS Date
AS
BEGIN

Declare  @BaseDate date = '5/17/2015';
Declare  @DefaultDate date = '1/1/2010';
Declare @NextProcessDateSumTable date; 
Declare @NextProcessDate date; 
declare @TableVar table (NextProcessDate date NOT NULL) 


set @NextProcessDateSumTable = (select DATEADD(dd,1,ISNULL(Max(ProcessDate),@BaseDate))  from  DataSystem_SummaryTables_VinDashBoard WITH(NOLOCK) where vinID = @VinID);

INSERT INTO @TableVar(NextProcessDate)
select ISNULL(min(date),@DefaultDate) as NextProcessDate   from PCanBusTwoHz_Committed pb with(nolock) where vinID = @VinID and Date >= @NextProcessDateSumTable  OPTION(RECOMPILE);


RETURN (select NextProcessDate from  @TableVar ) ;
---@NextProcessDate;

End 


GO
/****** Object:  UserDefinedFunction [dbo].[DateTimeAdd]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DateTimeAdd]
(
       @datepart         date,
       @timepart         time
)
RETURNS datetime2
AS
BEGIN
       RETURN DATEADD(dd, DATEDIFF(dd, 0, @datepart), CAST(@timepart AS datetime2));
END



GO
/****** Object:  UserDefinedFunction [dbo].[DateTimeAdd2]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DateTimeAdd2]
(
       @datepart         date,
       @timepart         time
)
RETURNS datetime2
AS
BEGIN
       RETURN DATEADD(dd, DATEDIFF(dd, 0, @datepart), CAST(@timepart AS datetime2));
END



GO
/****** Object:  UserDefinedFunction [dbo].[DecimalToBinary]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DecimalToBinary]
(
	@Input bigint
)
RETURNS varchar(255)
AS
BEGIN

	DECLARE @Output varchar(255) = ''

	WHILE @Input > 0 BEGIN

		SET @Output = @Output + CAST((@Input % 2) AS varchar)
		SET @Input = @Input / 2

	END

	RETURN REVERSE(@Output)

END



GO
/****** Object:  UserDefinedFunction [dbo].[f_min_int]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create function [dbo].[f_min_int](@a as int, @b as int) 
returns int
as
begin
    return case when @a < @b then @a else coalesce(@b,@a) end
end
GO
/****** Object:  UserDefinedFunction [dbo].[f_round15min]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE function [dbo].[f_round15min]
(
@date datetime
) returns datetime
as
begin -- adding 150 seconds to round off instead of truncating
return dateadd(minute, datediff(minute, '1900-01-01', dateadd(second, 450, @date))/15*15, 0)
end


GO
/****** Object:  UserDefinedFunction [dbo].[f_round5min]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create function [dbo].[f_round5min]
(
@date datetime
) returns datetime
as
begin -- adding 150 seconds to round off instead of truncating
return dateadd(minute, datediff(minute, '1900-01-01', dateadd(second, 150, @date))/5*5, 0)
end
GO
/****** Object:  UserDefinedFunction [dbo].[FiscalWeek]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[FiscalWeek] (@startMonth varchar(2), @myDate datetime)  
returns int  
as  
begin  
declare @firstWeek datetime  
declare @weekNum int  
declare @year int  
set @year = datepart(year, @myDate)+1  
--Get 4th day of month of next year, this will always be in week 1  
set @firstWeek = convert(datetime, str(@year)+@startMonth+'04', 102)  
--Retreat to beginning of week  
set @firstWeek = dateadd(day, (1-datepart(dw, @firstWeek)), @firstWeek)  
while @myDate < @firstWeek --Repeat the above steps but for previous year  
 begin  
  set @year = @year - 1  
  set @firstWeek = convert(datetime, str(@year)+@startMonth+'04', 102)  
  set @firstWeek = dateadd(day, (1-datepart(dw, @firstWeek)), @firstWeek)  
 end  
set @weekNum = (@year*100)+((datediff(day, @firstweek, @myDate)/7)+1)  
return @weekNum  
end  



GO
/****** Object:  UserDefinedFunction [dbo].[GetDecimal]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetDecimal] (@BinaryNumber BIGINT)

RETURNS BIGINT

AS

BEGIN

   

    DECLARE  @DecimalNumber BIGINT

            ,@Divider BIGINT

            ,@BinaryNumberLength INT

           

    SET @BinaryNumberLength = LEN(@BinaryNumber) - 1

    SET @Divider = '1' + REPLICATE('0', @BinaryNumberLength);

      

    WITH cte (Id, Divider, lvl) 

    AS

    (

    SELECT 

         @BinaryNumber / @Divider AS Id

        ,@Divider/10 AS Divider

        ,@BinaryNumberLength AS lvl

    UNION ALL

    SELECT

         @BinaryNumber / Divider AS Id

        ,Divider/10 AS Divider

        ,lvl - 1

    FROM cte

    WHERE Divider > 0

    )

    SELECT @DecimalNumber = SUM(RIGHT(Id, 1) * POWER(2, Lvl))

    FROM cte

       

    RETURN (@DecimalNumber)

 

END





GO
/****** Object:  UserDefinedFunction [dbo].[Hex2Bin]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Hex2Bin](@hex VARCHAR(256))

RETURNS VARCHAR(1024)

AS

BEGIN

 

DECLARE @bin VARCHAR(1024);

 

SET @bin = '';

 

WITH Converter (hex, bin)

AS

(SELECT '0', '0000' UNION ALL

 SELECT '1', '0001' UNION ALL

 SELECT '2', '0010' UNION ALL

 SELECT '3', '0011' UNION ALL

 SELECT '4', '0100' UNION ALL 

 SELECT '5', '0101' UNION ALL

 SELECT '6', '0110' UNION ALL

 SELECT '7', '0111' UNION ALL 

 SELECT '8', '1000' UNION ALL

 SELECT '9', '1001' UNION ALL

 SELECT 'A', '1010' UNION ALL 

 SELECT 'B', '1011' UNION ALL

 SELECT 'C', '1100' UNION ALL

 SELECT 'D', '1101' UNION ALL 

 SELECT 'E', '1110' UNION ALL 

 SELECT 'F', '1111'),

N1 (n) AS (SELECT 1 UNION ALL SELECT 1),

N2 (n) AS (SELECT 1 FROM N1 AS X, N1 AS Y),

N3 (n) AS (SELECT 1 FROM N2 AS X, N2 AS Y),

N4 (n) AS (SELECT ROW_NUMBER() OVER(ORDER BY X.n) 

           FROM N3 AS X, N3 AS Y)

SELECT @bin = (SELECT REPLACE(SUBSTRING(@hex, n, 1), hex, bin)

               FROM N4 AS Nums

               JOIN Converter AS C

                 ON SUBSTRING(@hex, n, 1) = hex

               WHERE n <= LEN(@hex)

               FOR XML PATH(''));

 

RETURN @bin;

 

END

 






GO
/****** Object:  UserDefinedFunction [dbo].[Hex2BinA]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[Hex2BinA](@hex VARCHAR(256))

RETURNS VARCHAR(1024)

AS

BEGIN
 
RETURN dbo.DecimalToBinary(CONVERT( bigint , CONVERT( varbinary( 20 ),@hex,2)))

END

 







GO
/****** Object:  UserDefinedFunction [dbo].[HexToBinary2Digits]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  FUNCTION [dbo].[HexToBinary2Digits] 
(
@hex varchar(2) 
)

RETURNS varchar(8)

AS

BEGIN
declare @Ihex varchar(10) =  @hex;

SET @IHex=REPLACE (@IHex,'0','0000')
set @IHex=replace (@IHex,'1','0001')
set @IHex=replace (@IHex,'2','0010')
set @IHex=replace (@IHex,'3','0011')
set @IHex=replace (@IHex,'4','0100')
set @IHex=replace (@IHex,'5','0101')
set @IHex=replace (@IHex,'6','0110')
set @IHex=replace (@IHex,'7','0111')
set @IHex=replace (@IHex,'8','1000')
set @IHex=replace (@IHex,'9','1001')
set @IHex=replace (@IHex,'A','1010')
set @IHex=replace (@IHex,'B','1011')
set @IHex=replace (@IHex,'C','1100')
set @IHex=replace (@IHex,'D','1101')
set @IHex=replace (@IHex,'E','1110')
set @IHex=replace (@IHex,'F','1111')

RETURN @IHex
END





GO
/****** Object:  UserDefinedFunction [dbo].[ISOWeek]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ISOWeek] 
( 
     @dt SMALLDATETIME 
) 
RETURNS TINYINT 
AS 
BEGIN 
     DECLARE @ISOweek TINYINT 
 
     SET @ISOweek = DATEPART(WEEK,@dt)+1 
         -DATEPART(WEEK,RTRIM(YEAR(@dt))+'0104') 
 
     IF @ISOweek = 0 
     BEGIN 
         SET @ISOweek = dbo.ISOweek 
         ( 
             RTRIM(YEAR(@dt)-1)+'12'+RTRIM(24+DAY(@dt)) 
         ) + 1 
     END 
 
     IF MONTH(@dt) = 12 AND DAY(@dt)-DATEPART(DW,@dt) >= 28 
     BEGIN 
         SET @ISOweek=1 
     END 
 
     RETURN(@ISOweek) 
END 




GO
/****** Object:  UserDefinedFunction [dbo].[PutSpaceBetweenEveryTwoCharacter]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:       
-- Create date:   
-- Description:   Puts spaces between letters. 
--                Example: "GEORGE" becomes "GE OR GE"
-- =============================================
CREATE FUNCTION [dbo].[PutSpaceBetweenEveryTwoCharacter]

(@String VARCHAR(100))

RETURNS VARCHAR(100)
AS
BEGIN
   DECLARE @pos INT, @result VARCHAR(100); 
   SET @result = @String; 
   SET @pos = 3 -- location where we want first space 
   WHILE @pos < LEN(@result)+1 
   BEGIN 
       SET @result = STUFF(@result, @pos, 0, SPACE(1)); 
       SET @pos = @pos+3; 
   END 
   RETURN @result; 
END



GO
/****** Object:  UserDefinedFunction [dbo].[Trim]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Trim] (
       @Str nvarchar(max)
)
RETURNS nvarchar(max) AS
BEGIN
       DECLARE @Result nvarchar(max)

       SET @Result = LTRIM(RTRIM(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(
              LTRIM(RTRIM(@Str)), CHAR(9), ''), CHAR(10), ''), CHAR(11), ''), CHAR(12), ''), CHAR(13), '')))

       RETURN @Result
END
GO
/****** Object:  UserDefinedFunction [dbo].[udf_PutSpacesBetweenChars]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:       
-- Create date:   
-- Description:   Puts spaces between letters. 
--                Example: "GEORGE" becomes "G E O R G E"
-- =============================================
CREATE FUNCTION [dbo].[udf_PutSpacesBetweenChars] 

(@String VARCHAR(100))

RETURNS VARCHAR(100)
AS
BEGIN
   DECLARE @pos INT, @result VARCHAR(100); 
   SET @result = @String; 
   SET @pos = 2 -- location where we want first space 
   WHILE @pos < LEN(@result)+1 
   BEGIN 
       SET @result = STUFF(@result, @pos, 0, SPACE(1)); 
       SET @pos = @pos+2; 
   END 
   RETURN @result; 
END



GO
/****** Object:  UserDefinedFunction [dbo].[udfConvertBigIntToCanHex]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,kmath>
-- Create date: <Create 5/16/2014, ,>
-- Description:	<Description, ,Converts Integer value to Hex For PCAN Symbols>

-- example :8FE5A21
-- select dbo.udfConvertBigIntToCanHex(2365479471)
-- =============================================
CREATE FUNCTION [dbo].[udfConvertBigIntToCanHex] 
(
	-- Add the parameters for the function here
	@IntValue BigInt
)
RETURNS VARCHAR(MAX)
AS
BEGIN


declare @HexValue varbinary(MAX) 
declare @HexValueChar varchar(MAX) 
set @HexValue = (select convert(varbinary(MAX), @IntValue))


set @HexValueChar = master.sys.fn_varbintohexstr(@HexValue)

set @HexValueChar = (select Replace (@HexValueChar,'0x',''))

set @HexValueChar = (select substring(@HexValueChar, patindex('%[^0]%',@HexValueChar), 20))

set @HexValueChar = (select CONVERT(varchar(1) ,CONVERT (int,LEFT(@HexValueChar,1) ) - 8) + Right(@HexValueChar,len(@HexValueChar) - 1))
set @HexValueChar = (select substring(@HexValueChar, patindex('%[^0]%',@HexValueChar), 20))
set @HexValueChar = UPPER(@HexValueChar) + 'x'

RETURN @HexValueChar

	 

END




GO
/****** Object:  UserDefinedFunction [dbo].[SplitStrings_XML]    Script Date: 7/6/2015 8:48:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SplitStrings_XML]
(
   @List       NVARCHAR(MAX),
   @Delimiter  NVARCHAR(255)
)
RETURNS TABLE
WITH SCHEMABINDING
AS
   RETURN 
   (  
      SELECT Item = y.i.value('(./text())[1]', 'nvarchar(4000)')
      FROM 
      ( 
        SELECT x = CONVERT(XML, '<i>' 
          + REPLACE(@List, @Delimiter, '</i><i>') 
          + '</i>').query('.')
      ) AS a CROSS APPLY x.nodes('i') AS y(i)
   );


GO
