--- Create Seq Codes 7/6/105

CREATE SEQUENCE [dbo].[SeqVin] 
 AS [smallint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -32768
 MAXVALUE 32767
 CACHE 
GO
CREATE SEQUENCE [dbo].[SeqBusTwoHzID] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO

CREATE SEQUENCE [dbo].[SeqChargeStation] 
 AS [smallint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 0
 MAXVALUE 32767
 CACHE 
GO

CREATE SEQUENCE [dbo].[SeqFileID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 0
 MAXVALUE 2147483647
 CACHE 
GO


CREATE SEQUENCE [dbo].[SeqPivotID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO

CREATE SEQUENCE [dbo].[SeqProcessID] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 0
 MAXVALUE 2147483647
 CACHE 
GO


CREATE SEQUENCE [dbo].[SeqSessionID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 CACHE 
GO


CREATE SEQUENCE [dbo].[SeqTraceID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO

CREATE SEQUENCE [dbo].[SeqTraceMasterID] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE 0
 MAXVALUE 2147483647
 CACHE 
GO


CREATE SEQUENCE [dbo].[SeqVin] 
 AS [smallint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -32768
 MAXVALUE 32767
 CACHE 
GO

