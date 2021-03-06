USE [PCanRepository]
GO
/****** Object:  View [fht].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[RawTraceDataStage] AS  
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[RawTraceDataStage] AS  
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[RawTraceDataStage] AS  
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[RawTraceDataStage] AS  
 SELECT * FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[RawTraceDataStage] AS  
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_Reno WITH (NOLOCK)  


GO
/****** Object:  View [San].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[RawTraceDataStage] AS  
 SELECT * FROM San.RawTraceDataStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceDataStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceDataStage_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [Sen].[RawTraceDataStage]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16JXDS816039 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaHospital WITH(NOLOCK)




GO
/****** Object:  View [Sto].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[RawTraceDataStage] AS  
 SELECT * FROM Sto.RawTraceDataStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.RawTraceDataStage_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[RawTraceDataStage] AS  
 SELECT * FROM Tal.RawTraceDataStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_Tallahassee WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE VIEW [Wor].[RawTraceDataStage]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_Worcester WITH(NOLOCK)









GO
/****** Object:  View [dbo].[RawTraceDataStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

















CREATE VIEW [dbo].[RawTraceDataStage]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceDataStage] WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceDataStage] WITH(NOLOCK)





























GO
/****** Object:  View [fht].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[RawTraceDataCharger] AS  
SELECT * FROM fht.RawTraceDataStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceData_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceData_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[RawTraceDataCharger] AS  
SELECT * FROM Lou.RawTraceDataStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceData_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceData_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[RawTraceDataCharger] AS  
SELECT * FROM Nas.RawTraceData_Nashville WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceData_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[RawTraceDataCharger] AS  
SELECT * FROM Pro.RawTraceDataStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceData_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceData_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [Ren].[RawTraceDataCharger]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Ren.RawTraceDataStage_Reno WITH(NOLOCK)

UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Ren.RawTraceData_Reno WITH(NOLOCK)





GO
/****** Object:  View [San].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[RawTraceDataCharger] AS  
SELECT * FROM San.RawTraceData_SanAntonio WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceData_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [Sen].[RawTraceDataCharger]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaHospital WITH(NOLOCK)

UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_SenecaHospital WITH(NOLOCK)




GO
/****** Object:  View [Sto].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[RawTraceDataCharger] AS  
SELECT * FROM Sto.RawTraceDataStage_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceData_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [Tal].[RawTraceDataCharger]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Tal.RawTraceDataStage_Tallahassee WITH(NOLOCK)

UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Tal.RawTraceData_Tallahassee WITH(NOLOCK)


GO
/****** Object:  View [Wor].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [Wor].[RawTraceDataCharger]

AS


SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_Worcester WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_Worcester WITH(NOLOCK)







GO
/****** Object:  View [dbo].[RawTraceDataCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE VIEW [dbo].[RawTraceDataCharger]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceDataCharger]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceDataCharger]

















GO
/****** Object:  View [dbo].[GetTraceDatasetChrVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [dbo].[GetTraceDatasetChrVw]

AS
SELECT tf.FileName , 
       v.Vin , 
       rtd.TraceDt , 
       rtd.Increment , 
       rtd.Bus , 
       rtd.DLC , 
       rtd.SymbolIDHex , 
       rtd.Data , 
       rtd.ChargingStationID , 
       tm.dateID , 
       tf.FileID , 
       rtd.VinID , 
       cs.Location AS ChargerLoc
  FROM
       RawTraceDataCharger AS rtd WITH ( nolock) 
	  INNER JOIN TraceMaster AS tm WITH (Nolock) ON tm.TraceMasterID =  rtd.TraceMasterID
       INNER JOIN TraceFiles AS tf WITH (Nolock)  ON tf.FileID = tm.FileID             
       INNER JOIN ChargingStations AS cs WITH ( nolock)  ON cs.ChargingStationID = rtd.ChargingStationID	  
	  LEFT JOIN Vehicles AS v WITH (Nolock) ON v.VinID = rtd.VinID

  WHERE rtd.ChargingStationID IS NOT NULL  ;          
  
  --and v.VIN is not null    






GO
/****** Object:  View [fht].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[PCanBusTwoHz] AS  
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHz_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[PCanBusTwoHz] AS  
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHz_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[PCanBusTwoHz] AS  
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHz_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[PCanBusTwoHz] AS  
 SELECT * FROM Pro.PCanBusTwoHz_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHz_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[PCanBusTwoHz] AS  
 SELECT * FROM Ren.PCanBusTwoHz_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHz_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHz_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHz_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[PCanBusTwoHz] AS  
 SELECT * FROM San.PCanBusTwoHz_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusTwoHz_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusTwoHz_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE View [Sen].[PCanBusTwoHz]
AS

SELECT 
  * 
FROM [Sen].PCanBusTwoHz_1M9TG16J6CS816019 WITH (NOLOCK)
UNION ALL

SELECT 
  * 
FROM [Sen].PCanBusTwoHz_1M9TG16J4CS816021 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
FROM [Sen].PCanBusTwoHz_1M9TG16J8DS816024 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
 FROM [Sen].PCanBusTwoHz_1M9TG16J3DS816030 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
FROM [Sen].PCanBusTwoHz_1M9TG16JXDS816039 WITH (NOLOCK)









GO
/****** Object:  View [Sto].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[PCanBusTwoHz] AS  
 SELECT * FROM Sto.PCanBusTwoHz_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.PCanBusTwoHz_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[PCanBusTwoHz] AS  
 SELECT * FROM Tal.PCanBusTwoHz_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHz_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHz_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHz_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHz_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--select * from vehicles where BusOwner = 'worcester'

CREATE View [Wor].[PCanBusTwoHz]
AS

SELECT 
  * 
FROM [Wor].PCanBusTwoHz_1M9TG16JXDS816025 WITH (NOLOCK)
UNION ALL

SELECT 
  * 
FROM [Wor].PCanBusTwoHz_1M9TG16J1DS816026 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
FROM [Wor].PCanBusTwoHz_1M9TG16J3DS816027 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
 FROM [Wor].PCanBusTwoHz_1M9TG16J5DS816028 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
FROM [Wor].PCanBusTwoHz_1M9TG16J7DS816029 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
 FROM [Wor].PCanBusTwoHz_1M9TG16J3DS816031 WITH (NOLOCK)

--UNION ALL

--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J7DS816032 WITH (NOLOCK)

--UNION ALL
--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J9DS816033 WITH (NOLOCK)

--UNION ALL
--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J0DS816034 WITH (NOLOCK)





GO
/****** Object:  View [fht].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[PCanBusTwoHzStage] AS  
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusTwoHzStage_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[PCanBusTwoHzStage] AS  
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusTwoHzStage_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[PCanBusTwoHzStage] AS  
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusTwoHzStage_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[PCanBusTwoHzStage] AS  
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusTwoHzStage_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[PCanBusTwoHzStage] AS  
 SELECT * FROM Ren.PCanBusTwoHzStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHzStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHzStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusTwoHzStage_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[PCanBusTwoHzStage] AS  
 SELECT * FROM San.PCanBusTwoHzStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusTwoHzStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusTwoHzStage_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE  View [Sen].[PCanBusTwoHzStage]
AS
SELECT 
  * 
FROM [Sen].PCanBusTwoHzStage_1M9TG16J6CS816019 WITH (NOLOCK)
UNION ALL

SELECT 
  * 
FROM [Sen].PCanBusTwoHzStage_1M9TG16J4CS816021 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
FROM [Sen].PCanBusTwoHzStage_1M9TG16J8DS816024 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
 FROM [Sen].PCanBusTwoHzStage_1M9TG16J3DS816030 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
FROM [Sen].PCanBusTwoHzStage_1M9TG16JXDS816039 WITH (NOLOCK)



GO
/****** Object:  View [Sto].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[PCanBusTwoHzStage] AS  
 SELECT * FROM Sto.PCanBusTwoHzStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.PCanBusTwoHzStage_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[PCanBusTwoHzStage] AS  
 SELECT * FROM Tal.PCanBusTwoHzStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHzStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHzStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHzStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusTwoHzStage_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--select * from vehicles where BusOwner = 'worcester'

CREATE View [Wor].[PCanBusTwoHzStage]
AS

SELECT 
  * 
FROM [Wor].PCanBusTwoHzStage_1M9TG16JXDS816025 WITH (NOLOCK)
UNION ALL

SELECT 
  * 
FROM [Wor].PCanBusTwoHzStage_1M9TG16J1DS816026 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
FROM [Wor].PCanBusTwoHzStage_1M9TG16J3DS816027 WITH (NOLOCK)

UNION ALL
SELECT 
  * 
 FROM [Wor].PCanBusTwoHzStage_1M9TG16J5DS816028 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
FROM [Wor].PCanBusTwoHzStage_1M9TG16J7DS816029 WITH (NOLOCK)

UNION ALL

SELECT 
  * 
 FROM [Wor].PCanBusTwoHzStage_1M9TG16J3DS816031 WITH (NOLOCK)

--UNION ALL

--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J7DS816032 WITH (NOLOCK)

--UNION ALL
--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J9DS816033 WITH (NOLOCK)

--UNION ALL
--SELECT 
--  * 
--FROM [Wor].PCanBusTwoHzStage_1M9TG16J0DS816034 WITH (NOLOCK)





GO
/****** Object:  View [dbo].[PCanBusTwoHz]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE View [dbo].[PCanBusTwoHz]
AS
SELECT * from [Wor].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Sen].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Ren].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Pro].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Tal].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [San].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Nas].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Lou].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [fht].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Sto].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Wor].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Sen].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Ren].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Pro].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Tal].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [San].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Nas].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Lou].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [fht].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [sto].[PCanBusTwoHzStage] with (nolock)







GO
/****** Object:  View [fht].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[PivotDatVw] AS  
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivot_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivot_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivot_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[PivotDatVw] AS  
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivot_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivot_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivot_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[PivotDatVw] AS  
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivot_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivot_Nashville WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.PCanBusChrPivotStage_Nashville WITH (NOLOCK)  



GO
/****** Object:  View [Pro].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[PivotDatVw] AS  
 SELECT * FROM Pro.PCanBusChrPivot_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivot_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivot_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivot_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[PivotDatVw] AS  
 SELECT * FROM Ren.PCanBusChrPivot_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivot_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivot_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivot_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivot_Reno WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.PCanBusChrPivotStage_Reno WITH (NOLOCK)  


GO
/****** Object:  View [San].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[PivotDatVw] AS  
 SELECT * FROM San.PCanBusChrPivot_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusChrPivot_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusChrPivot_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.PCanBusChrPivot_SanAntonio WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.PCanBusChrPivotStage_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE  VIEW [Sen].[PivotDatVw]
AS 

SELECT  * from Sen.PCanBusChrPivot_1M9TG16J6CS816019  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivot_1M9TG16J4CS816021  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivot_1M9TG16J8DS816024  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivot_1M9TG16J3DS816030  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivot_SenecaDowntown  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivot_SenecaHospital  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J6CS816019  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J4CS816021  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J8DS816024  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J3DS816030  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivotStage_SenecaDowntown  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivotStage_SenecaHospital  WITH(NOLOCK)





GO
/****** Object:  View [Sto].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[PivotDatVw] AS  
 SELECT * FROM Sto.PCanBusChrPivot_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.PCanBusChrPivotStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.PCanBusChrPivot_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.PCanBusChrPivotStage_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.PCanBusChrPivot_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.PCanBusChrPivotStage_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[PivotDatVw] AS  
 SELECT * FROM Tal.PCanBusChrPivot_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivot_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivot_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivot_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivot_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivot_Tallahassee WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.PCanBusChrPivotStage_Tallahassee WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE  VIEW [Wor].[PivotDatVw]
AS 

SELECT  * from Wor.PCanBusChrPivot_1M9TG16JXDS816025  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_1M9TG16J1DS816026  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_1M9TG16J3DS816027  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_1M9TG16J5DS816028  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_1M9TG16J7DS816029  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_1M9TG16J3DS816031  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivot_Worcester  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16JXDS816025  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J1DS816026  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J3DS816027  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J5DS816028  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J7DS816029  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J3DS816031  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_Worcester  WITH(NOLOCK)




GO
/****** Object:  View [fht].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[TraceDecodeCommitted] AS  
 SELECT * FROM fht.TraceDecode_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J7AG816005 WITH (NOLOCK)  
  UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaNorth WITH (NOLOCK)  
 UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[TraceDecodeCommitted] AS  
 SELECT * FROM Lou.TraceDecode_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J6ES816072 WITH (NOLOCK) 
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleMarket WITH (NOLOCK)  
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[TraceDecodeCommitted] AS  
 SELECT * FROM Nas.TraceDecode_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J4ES816071 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM Nas.TraceDecode_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[TraceDecodeCommitted] AS  
 SELECT * FROM Pro.TraceDecode_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG16J4CS816018 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM Pro.TraceDecode_Plant WITH (NOLOCK)  
 UNION ALL 
SELECT * FROM Pro.TraceDecode_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[TraceDecodeCommitted] AS  
 SELECT * FROM Ren.TraceDecode_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J8DS816038 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM Ren.TraceDecode_Reno WITH (NOLOCK)  


GO
/****** Object:  View [San].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[TraceDecodeCommitted] AS  
 SELECT * FROM San.TraceDecode_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecode_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecode_1M9TG11J2BS816010 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM San.TraceDecode_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [Sen].[TraceDecodeCommitted]

AS

SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaHospital WITH(NOLOCK)




GO
/****** Object:  View [Sto].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[TraceDecodeCommitted] AS  
 SELECT * FROM Sto.TraceDecode_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.TraceDecode_1M9TG16J0CS816016 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM Sto.TraceDecode_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Wor].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [Wor].[TraceDecodeCommitted]

AS


SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_Worcester WITH(NOLOCK)



GO
/****** Object:  View [dbo].[PivotDatTraceMasterIDVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE VIEW [dbo].[PivotDatTraceMasterIDVw]
AS
SELECT  distinct TraceMasterID  FROM Ren.PivotDatVw WITH(NOLOCK) where traceDt >=  ( select distinct Min(traceDt) from ren.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Sen.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from sen.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Wor.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from wor.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Tal.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from wor.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Pro.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from pro.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM San.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from san.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Nas.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from nas.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Lou.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from Lou.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Fht.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from Fht.TraceDecodeCommitted td where chargingStationID is null)
UNION ALL
SELECT  distinct TraceMasterID FROM Sto.PivotDatVw WITH(NOLOCK) where traceDt >= ( select Min(traceDt)  from Sto.TraceDecodeCommitted td where chargingStationID is null)


















GO
/****** Object:  View [dbo].[ReportServices_ByTraceDate_BusMatrix]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE View [dbo].[ReportServices_ByTraceDate_BusMatrix]
AS
With T AS
(
select c.CustomerName, v.Vin,v.VinID,Date,Convert(time,dbo.f_round5min(Time))Time_Occur, 
Avg(PCtm_uin_Current_a) PCtm_uin_Current_a,  avg(PCtm_uin_Voltage_v) PCtm_uin_Voltage_v,
AVG(PCpt_int_Spd_mph) PCpt_int_Spd_mph,
MAX(PCes_usi_ChargeEnable_xx) PCes_usi_ChargeEnable_xx,
MAX(PCbo_bo_ScoopHeaterOn) PCbo_bo_ScoopHeaterOn,
AVG(PCes_usi_SoCmin_pct) PCes_usi_SoCmin_pct,
AVG(PCes_usi_SoCmax_pct) PCes_usi_SoCmax_pct,
AVG(PCbo_usi_DashSOC_pct) PCbo_usi_DashSOC_pct
 from PCanBusTwoHz th with(nolock) 
 inner join Vehicles v on v.vinid = th.vinID
 inner join CustomerVehicles cv on cv.VinID = v.vinid
 inner join Customers c on c.CustomerID = cv.CustomerID
where 


-- tracedt between convert(date,getdate() -7) and convert(date,getdate() + 1 )
--and 


abs(PCtm_uin_Voltage_v) between 200 and 1000 and abs(PCtm_uin_Current_a) < 2500  --and v.BusOwner like '%wor%'
Group by c.CustomerName,v.Vin,v.vinid,Date, Convert(time,dbo.f_round5min(Time))
)
select   CustomerName,Vin,VinID,Date,
Time_Occur,
convert(int,round(PCtm_uin_Current_a,0)) as PCtm_uin_Current_a ,
convert(int,round(PCtm_uin_Voltage_v,0)) PCtm_uin_Voltage_v, 
convert(int,round((PCtm_uin_Current_a * PCtm_uin_Voltage_v) * 300 / (1000 * 3600 ),0)) Pt_Energy,
convert(int,round(PCpt_int_Spd_mph,0)) PCpt_int_Spd_mph,
 10 *  PCes_usi_ChargeEnable_xx PCes_usi_ChargeEnable_xx,
 10 * PCbo_bo_ScoopHeaterOn PCbo_bo_ScoopHeaterOn,
convert(int,round(PCes_usi_SoCmin_pct,0)) PCes_usi_SoCmin_pct,
convert(int,round(PCes_usi_SoCmax_pct,0)) PCes_usi_SoCmax_pct,
convert(int,round(PCbo_usi_DashSOC_pct,0)) PCbo_usi_DashSOC_pct
 FROM T 





GO
/****** Object:  View [fht].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[RawTraceData] AS  
 SELECT * FROM fht.RawTraceData_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceData_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceData_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[RawTraceData] AS  
 SELECT * FROM Lou.RawTraceData_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceData_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceData_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[RawTraceData] AS  
 SELECT * FROM Nas.RawTraceData_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceData_Nashville WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[RawTraceData] AS  
 SELECT * FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceData_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceData_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[RawTraceData] AS  
 SELECT * FROM Ren.RawTraceData_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceData_Reno WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_Reno WITH (NOLOCK)  


GO
/****** Object:  View [San].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[RawTraceData] AS  
 SELECT * FROM San.RawTraceData_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceData_SanAntonio WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [Sen].[RawTraceData]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16JXDS816039 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_SenecaHospital WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH(NOLOCK)

UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16JXDS816039 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_SenecaHospital WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH(NOLOCK)




GO
/****** Object:  View [Sto].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[RawTraceData] AS  
 SELECT * FROM Sto.RawTraceData_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.RawTraceData_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceData_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[RawTraceData] AS  
 SELECT * FROM Tal.RawTraceData_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceData_Tallahassee WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_Tallahassee WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [Wor].[RawTraceData]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_Worcester WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_Worcester WITH(NOLOCK)






GO
/****** Object:  View [dbo].[RawTraceData]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE VIEW [dbo].[RawTraceData]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceData] WITH (NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceData] WITH (NOLOCK)
















GO
/****** Object:  View [Tal].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[TraceDecodeCommitted] AS  
 SELECT * FROM Tal.TraceDecode_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J6DS816023 WITH (NOLOCK)  

 UNION ALL 
SELECT * FROM Tal.TraceDecode_Tallahassee WITH (NOLOCK)  


GO
/****** Object:  View [dbo].[TraceDecodeCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO













CREATE view [dbo].[TraceDecodeCommitted] 
AS
    SELECT  TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Ren.TraceDecodeCommitted WITH (NOLOCK)
     UNION ALL 
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sen.TraceDecodeCommitted WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Wor.TraceDecodeCommitted WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Pro.TraceDecodeCommitted WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Tal.TraceDecodeCommitted WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   San.TraceDecodeCommitted WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Nas.TraceDecodeCommitted WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Lou.TraceDecodeCommitted WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Fht.TraceDecodeCommitted WITH (NOLOCK)
		 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sto.TraceDecodeCommitted WITH (NOLOCK)
























GO
/****** Object:  View [fht].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [fht].[RawTraceDataBusCommitted] AS  
 SELECT * FROM fht.RawTraceData_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J1DS816043 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J3DS816044 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J5DS816045 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J7DS816046 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816047 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816048 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J2DS816049 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816050 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816051 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J3AG816003 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J5AG816004 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J7AG816005 WITH (NOLOCK)




GO
/****** Object:  View [Lou].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Lou].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Lou.RawTraceData_1M9TG16J0ES816052 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J2ES816053 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J4ES816054 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816055 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J8ES816056 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816057 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816058 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J3ES816059 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816060 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816061 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816072 WITH (NOLOCK)
 

GO
/****** Object:  View [Nas].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Nas].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Nas.RawTraceData_1M9TG16J9ES816065 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J0ES816066 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816067 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816068 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J6ES816069 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816070 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816071 WITH (NOLOCK)
 


GO
/****** Object:  View [Pro].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Pro].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J9ES816063 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J0ES816064 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J7ES816062 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J59G816001 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J9BG816007 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J3CS816020 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG16J4CS816018 WITH (NOLOCK)
 


GO
/****** Object:  View [Ren].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Ren].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Ren.RawTraceData_1M9TG16J2DS816035 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J4DS816036 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J6DS816037 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J8DS816038 WITH (NOLOCK)
 


GO
/****** Object:  View [San].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [San].[RawTraceDataBusCommitted] AS  
 SELECT * FROM San.RawTraceData_1M9TG11J4BS816008 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J6BS816009 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J2BS816010 WITH (NOLOCK)



GO
/****** Object:  View [Sen].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [Sen].[RawTraceDataBusCommitted]

AS


SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16JXDS816039 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH(NOLOCK)






GO
/****** Object:  View [Sto].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Sto].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Sto.RawTraceData_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.RawTraceData_1M9TG16J0CS816016 WITH (NOLOCK)
 

GO
/****** Object:  View [Tal].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE VIEW   [Tal].[RawTraceDataBusCommitted] AS  
 SELECT * FROM Tal.RawTraceData_1M9TG11J2CS816011 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J3CS816012 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J5CS816013 WITH (NOLOCK)
 
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J4DS816022 WITH (NOLOCK)

 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J6DS816023 WITH (NOLOCK)
 



GO
/****** Object:  View [Wor].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [Wor].[RawTraceDataBusCommitted]

AS


SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816031 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_Worcester WITH(NOLOCK)








GO
/****** Object:  View [dbo].[RawTraceDataBusCommitted]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[RawTraceDataBusCommitted]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceDataBusCommitted]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceDataBusCommitted]




















GO
/****** Object:  View [dbo].[GetTraceDatasetBusVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[GetTraceDatasetBusVw]

AS
--SELECT        tf.FileName, v.Vin,  rtd.TraceDt, rtd.Increment, rtd.Bus, rtd.DLC, rtd.SymbolIDHex, rtd.Data, rtd.ChargingStationID, tm.dateID, tf.FileID,rtd.VinID
--FROM            dbo.RawTraceData AS rtd WITH (nolock) INNER JOIN
--                dbo.TraceMaster AS tm WITH (nolock) ON tm.TraceMasterID = rtd.TraceMasterID and rtd.ChargingStationID is NULL INNER JOIN
--                dbo.TraceFiles AS tf WITH (nolock) ON tf.FileID = tm.FileID INNER JOIN
--                dbo.Vehicles AS v WITH (nolock) ON v.VinID = rtd.VinID 

SELECT        v.Vin,  rtd.TraceDt, rtd.Increment, rtd.Bus, rtd.DLC, rtd.SymbolIDHex, rtd.Data, rtd.ChargingStationID,rtd.VinID, convert(date,rtd.TraceDt) as Tdate
FROM            dbo.RawTraceDataBusCommitted AS rtd WITH (nolock) INNER JOIN               
                dbo.Vehicles AS v WITH (nolock) ON v.VinID = rtd.VinID and rtd.ChargingStationID IS NULL 







GO
/****** Object:  View [dbo].[PCanBusTwoHzStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE View [dbo].[PCanBusTwoHzStage]
AS
SELECT * from [Wor].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Sen].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Ren].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Pro].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Tal].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [San].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Nas].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Lou].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [Fht].[PCanBusTwoHzStage] with (nolock)
UNION ALL
SELECT * from [sto].[PCanBusTwoHzStage] with (nolock)











GO
/****** Object:  View [dbo].[PivotDatVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE VIEW [dbo].[PivotDatVw]
AS

SELECT  * FROM Wor.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Sen.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Ren.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Pro.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Tal.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM San.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Nas.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Lou.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Fht.PivotDatVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Sto.PivotDatVw WITH(NOLOCK)











GO
/****** Object:  View [fht].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[TraceDecode] AS  
 SELECT * FROM fht.TraceDecode_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecode_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[TraceDecode] AS  
 SELECT * FROM Lou.TraceDecode_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecode_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[TraceDecode] AS  
 SELECT * FROM Nas.TraceDecode_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecode_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecode_Nashville WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecodeStage_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[TraceDecode] AS  
 SELECT * FROM Pro.TraceDecode_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecode_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecode_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecode_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[TraceDecode] AS  
 SELECT * FROM Ren.TraceDecode_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecodeStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecodeStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecodeStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecode_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecodeStage_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecode_Reno WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.TraceDecodeStage_Reno WITH (NOLOCK)  


GO
/****** Object:  View [San].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[TraceDecode] AS  
 SELECT * FROM San.TraceDecode_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecodeStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecode_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecodeStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecode_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecodeStage_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecode_SanAntonio WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecodeStage_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [Sen].[TraceDecode]

AS

SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaHospital WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaHospital WITH(NOLOCK)



GO
/****** Object:  View [Sto].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[TraceDecode] AS  
 SELECT * FROM Sto.TraceDecode_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.TraceDecodeStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.TraceDecode_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.TraceDecodeStage_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.TraceDecode_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.TraceDecodeStage_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[TraceDecode] AS  
 SELECT * FROM Tal.TraceDecode_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecode_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecode_Tallahassee WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.TraceDecodeStage_Tallahassee WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [Wor].[TraceDecode]

AS

SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_Worcester WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_Worcester WITH(NOLOCK)


GO
/****** Object:  View [dbo].[TraceDecode]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE view [dbo].[TraceDecode] 
AS
    SELECT  TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM  Ren.TraceDecode WITH (NOLOCK)
     UNION ALL 
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sen.TraceDecode WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Wor.TraceDecode WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Pro.TraceDecode WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Tal.TraceDecode WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   San.TraceDecode WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Nas.TraceDecode WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Lou.TraceDecode WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Fht.TraceDecode WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sto.TraceDecode WITH (NOLOCK)


















GO
/****** Object:  View [dbo].[GetDecodedDatasetBusVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[GetDecodedDatasetBusVw]
AS
SELECT        tf.FileName, v.VinID, v.Vin, tdm.TraceDt, tm.dateID, tf.FileID, tdm.RowNum, ps.SymbolID, ps.SymbolIDHex, ps.Name AS Symbol, pv.PcanvID, pv.Name AS SymbolVar,
                          ISNULL(tdm.DataEnum, tdm.DataVal) AS Data, tdm.PCanVId AS Expr1
FROM            dbo.TraceDecode AS tdm WITH (nolock) INNER JOIN
                         dbo.TraceMaster AS tm WITH (nolock) ON tm.TraceMasterID = tdm.TraceMasterID AND tdm.ChargingStationID IS NULL INNER JOIN
                         dbo.TraceFiles AS tf WITH (nolock) ON tf.FileID = tm.FileID INNER JOIN
                         dbo.Vehicles AS v WITH (nolock) ON v.VinID = tdm.VinID INNER JOIN
                         dbo.PcanVariables AS pv WITH (nolock) ON pv.PcanvID = tdm.PCanVId INNER JOIN
                         dbo.PcanSymbols AS ps WITH (nolock) ON ps.SymbolID = pv.SymbolID



GO
/****** Object:  View [dbo].[RenderDecodeToCSV]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[RenderDecodeToCSV]
AS
select 
convert(date,TraceDt) Dt,
convert(time,TraceDt) Tm,
PCabs_en_ABSActive,
PCabs_en_ABSFullyOperational,
PCabs_en_AmberWarningLamp,
PCabs_en_ASRBrakeCtrlActive,
PCabs_en_ASREngineCtrlActive,
PCabs_en_ATCInfoSig,
PCabs_en_RedWarningLamp,
PCabs_uin_FAxleSpd_kph,
PCabs_uin_WheelSpdCSF_kph,
PCabs_uin_WheelSpdCSR_kph,
PCabs_uin_WheelSpdSSF_kph,
PCabs_uin_WheelSpdSSR_kph,
PCabs_usi_RelSpdCSF_kph,
PCabs_usi_RelSpdCSR_kph,
PCabs_usi_RelSpdSSF_kph,
PCabs_usi_RelSpdSSR_kph,
PCabs_usi_RequestForPGN,
PCac_dat_TimeDatePGN,
PCac_en_CP1Status,
PCac_en_CP2Status,
PCac_en_FailStatus,
PCac_en_HVACOperMode,
PCac_en_IdleUpStatus,
PCac_en_MainStatusSwitch,
PCac_uin_DischargePressure1_psi,
PCac_uin_SuctionPressure1_psi,
PCac_usi_AmbientTemp_c,
PCac_usi_BlowerSpeed_pct,
PCac_usi_DuctAirTemp_c,
PCac_usi_InteriorTempSetpoint_f,
PCac_usi_ReturnAirTemp_c,
PCbe_en_CANEQHeartbeat,
PCbe_en_CANSSMSGON,
PCbe_en_EQFault,
PCbe_en_EQRun,
PCbe_en_EQSTATEONOFF,
PCbe_en_EXT12VFault,
PCbe_en_EXT24VFault,
PCbe_en_EXTGNDFault,
PCbe_en_ImbalanceFault,
PCbe_en_IOINShutdown,
PCbe_en_OVFault,
PCbe_en_STATECANJSO,
PCbe_en_STATEONOFFEN,
PCbe_en_UVFault,
PCbe_en_VCompFaultHigh,
PCbe_en_VCompFaultLow,
PCbe_uin_I12_a,
PCbe_uin_I24_a,
PCbe_uin_V12_v,
PCbe_uin_V24_v,
PCbo_bo_100pctChargeRequest,
PCbo_bo_BusReqAActivateBrushes,
PCbo_bo_BusReqAArmDown,
PCbo_bo_BusReqAArmUp,
PCbo_bo_BusReqAAutoCharge,
PCbo_bo_BusReqACANErr,
PCbo_bo_BusReqADoorBrkSolenoid,
PCbo_bo_BusReqAEscapeOpen,
PCbo_bo_BusReqAFOpen,
PCbo_bo_BusReqAManCharge,
PCbo_bo_BusReqAMasterSwOn,
PCbo_bo_BusReqAParkBrkOn,
PCbo_bo_BusReqAProx,
PCbo_bo_BusReqAROpen,
PCbo_bo_DCEnable,
PCbo_bo_DefrosterOn,
PCbo_bo_ESSEnable,
PCbo_bo_GroundFaultDetected,
PCbo_bo_HeadlightsOn,
PCbo_bo_InteriorLightsOn,
PCbo_bo_KeyOn,
PCbo_bo_ManualCharge,
PCbo_bo_ManualChargeParallel,
PCbo_bo_PowerSteeringOn,
PCbo_bo_PTEnableTraction,
PCbo_bo_PTHVReady,
PCbo_bo_PTParkBrakeTMInterlock,
PCbo_bo_PTParkingBrakeActive,
PCbo_bo_PTRegenOffSolStatus,
PCbo_bo_PTTMOverrideRequest,
PCbo_bo_ScoopHeaterOn,
PCbo_en_ActiveDiagPriority,
PCbo_en_ASPAirCompStatus,
PCbo_en_BusReqAGen,
PCbo_en_BusReqASelRNF,
PCbo_en_ChgrDerateReq,
PCbo_en_CP1CmdDir,
PCbo_en_CP1CmdPHold,
PCbo_en_CP2CmdDir,
PCbo_en_CP2CmdPHold,
PCbo_en_CP3CmdDir,
PCbo_en_CP3CmdPHold,
PCbo_en_DoorsPos,
PCbo_en_PTConfigID,
PCbo_en_PTDesiredGear,
PCbo_en_PTDNR,
PCbo_en_RampPos,
PCbo_en_RHKneelReqCS,
PCbo_en_RHKneelReqSS,
PCbo_en_RHNomLevelReqF,
PCbo_en_RHNomLevelReqR,
PCbo_en_RHProhibitAirSusp,
PCbo_en_RHProhibitAutoSusp,
PCbo_en_RHSecurityDevice,
PCbo_en_VRCANEQONOFF,
PCbo_en_VRCANJSO,
PCbo_en_VRCANONOFFEN,
PCbo_en_VRCANSSMSGEN,
PCbo_uin_BusReqARot_in,
PCbo_uin_CP1CmdSpd_rpm,
PCbo_uin_CP2CmdSpd_rpm,
PCbo_uin_CP3CmdSpd_rpm,
PCbo_uin_DC24VCmd_v,
PCbo_uin_DM1SPN_xx,
PCbo_uin_MainPower_mv,
PCbo_uin_VRFaultTimer_s,
PCbo_uin_VROVSet_v,
PCbo_uin_VRUVSet_v,
PCbo_usi_Accel_pct,
PCbo_usi_AccelRaw_xx,
PCbo_usi_ASPAuxiliary_psi,
PCbo_usi_ASPPrimary_psi,
PCbo_usi_ASPSecondary_psi,
PCbo_usi_AvailableMotorP_kw,
PCbo_usi_AvailableRegenP_kw,
PCbo_usi_AvgEff_kwhpmi,
PCbo_usi_Brake_pct,
PCbo_usi_BrakeRaw_xx,
PCbo_usi_BusID_xx,
PCbo_usi_BusReqABusNum_xx,
PCbo_usi_BusReqABusSpd_mph,
PCbo_usi_ChargerRequest_xx,
PCbo_usi_CoolantT_c,
PCbo_usi_CoolTBattRet_c,
PCbo_usi_CoolTElecRet_c,
PCbo_usi_CP1CmdSpd_pct,
PCbo_usi_CP2CmdSpd_pct,
PCbo_usi_CP3CmdSpd_pct,
PCbo_usi_CycleTime_ms,
PCbo_usi_DashSOC_pct,
PCbo_usi_DM1FMI_xx,
PCbo_usi_ESSFeatureSet_xx,
PCbo_usi_RadFanSpd_pct,
PCbo_usi_StringsActive_xx,
PCbo_usi_SWMajorNum_xx,
PCbo_usi_SWMajorRev_xx,
PCbo_usi_SWParameterNum_xx,
PCbo_usi_SWParameterRev_xx,
PCbo_usi_TireSize_revpmi,
PCbo_usi_VRIndexByte,
PCbo_usi_Watchdog_xx,
PCc0_Charger_Max_I,
PCc0_ChargerDerate,
PCc0_udi_BatteryID_xx,
PCc0_udi_EOCWhCharged_whr,
PCc0_uin_BMSVersion_xx,
PCc0_uin_ChargerAbort_xx,
PCc0_uin_ChargerI_a,
PCc0_uin_ChargerV_v,
PCc0_uin_CommProtocol_xx,
PCc0_uin_EOCAhCharged_ahr,
PCc0_uin_EOCAvgCellT_c,
PCc0_uin_EOCEndingSoC_pct,
PCc0_uin_EOCMaxCellT_c,
PCc0_uin_EOCMaxChargerP_kw,
PCc0_uin_EOCStartingSoC_pct,
PCc0_uin_ESMAbortCharge_xx,
PCc0_uin_ESMMaxCap_ahr,
PCc0_uin_ESMMaxI_a,
PCc0_uin_ESMMaxP_kw,
PCc0_uin_ESMMaxV_v,
PCc0_uin_ESSI_a,
PCc0_uin_ESSSoC_pct,
PCc0_uin_ESSV_v,
PCc0_uin_MaxI_a,
PCc0_uin_MaxP_kw,
PCc0_uin_MaxV_v,
PCc0_uin_ReadyCurrent_a,
PCc0_uin_ReqI_a,
PCc0_uin_ReqP_kw,
PCc0_uin_ReqV_v,
PCc0_uin_TimetoFull_s,
PCc0_usi_BMSIdentified_xx,
PCc0_usi_BMSTransferReady_xx,
PCc0_usi_ChargerInside_xx,
PCc0_usi_ChargerSerial_xx,
PCc0_usi_ChargerT_c,
PCc0_usi_ESST_c,
PCc0_usi_OutletNumber_xx,
PCc0_usi_PowerLevel_xx,
PCc0_usi_TransferReady_xx,
PCcp1_en_CtrlrStatus,
PCcp1_en_Dir,
PCcp1_uin_CtrlrT_c,
PCcp1_uin_P_w,
PCcp1_uin_Spd_rpm,
PCcp1_usi_Spd_pct,
PCcp2_en_CtrlrStatus,
PCcp2_en_Dir,
PCcp2_uin_CtrlrT_c,
PCcp2_uin_P_w,
PCcp2_uin_Spd_rpm,
PCcp2_usi_Spd_pct,
PCcp3_en_CtrlrStatus,
PCcp3_en_Dir,
PCcp3_uin_CtrlrT_c,
PCcp3_uin_P_w,
PCcp3_uin_Spd_rpm,
PCcp3_usi_Spd_pct,
PCcz_bo_ArmAErrIso,
PCcz_bo_ArmAErrLowAir,
PCcz_bo_ArmAErrOverTemp,
PCcz_bo_ArmAFdbkArmHome,
PCcz_bo_ArmAFdbkChargeHome,
PCcz_bo_ArmAFdbkDown,
PCcz_bo_ArmAFdbkLand,
PCcz_bo_ArmAFdbkNeutHome,
PCcz_bo_ArmAFdbkPilot,
PCcz_bo_ArmDownFdbk,
PCcz_bo_CmdAAutoCharge,
PCcz_bo_CmdACntctrClose,
PCcz_bo_CmdADockStop,
PCcz_bo_CmdAHeadLandStop,
PCcz_bo_CmdAPilotOn,
PCcz_bo_CmdARotReset,
PCcz_bo_HeadLand1,
PCcz_bo_HeadLand2,
PCcz_bo_M1NegRlyFdbk,
PCcz_bo_M1PosRlyFdbk,
PCcz_bo_M2NegRlyFdbk,
PCcz_bo_M2PosRlyFdbk,
PCcz_bo_NegBrushPos1Fdbk,
PCcz_bo_NegBrushPos2Fdbk,
PCcz_bo_NegBrushPos3Fdbk,
PCcz_bo_NegBrushPos4Fdbk,
PCcz_bo_NegBrushPos5Fdbk,
PCcz_bo_NeutralBrushPosFdbk,
PCcz_bo_OHNegRly1Fdbk,
PCcz_bo_OHNegRly2Fdbk,
PCcz_bo_OHPosRly1Fdbk,
PCcz_bo_OHPosRly2Fdbk,
PCcz_bo_PosBrushPos1Fdbk,
PCcz_bo_PosBrushPos2Fdbk,
PCcz_bo_PosBrushPos3Fdbk,
PCcz_bo_PosBrushPos4Fdbk,
PCcz_bo_PosBrushPos5Fdbk,
PCcz_en_ChgrStatusArmAID,
PCcz_en_CmdAESMRate,
PCcz_en_CmdASpdLim,
PCcz_en_CmdAState,
PCcz_usi_AIsoValue_v,
PCcz_usi_APilot,
PCcz_usi_ArmAUltrasonic_mm,
PCcz_usi_CmdABusNum,
PCcz_usi_CmdAESMReq,
PCcz_usi_DistCheck,
PCcz_usi_DockMode,
PCcz_usi_ErrAAbort0,
PCcz_usi_ErrABusNum,
PCcz_usi_ErrAFault0_xx,
PCcz_usi_ErrAFault1_xx,
PCcz_usi_ErrARetry0_xx,
PCcz_usi_ErrARetry1_xx,
PCcz_usi_HeightStore,
PCcz_usi_Press_Raw,
PCcz_usi_SideANegCurrSensor1_a,
PCcz_usi_SideANegCurrSensor2_a,
PCcz_usi_SideANegCurrSensor3_a,
PCcz_usi_SideANegCurrSensor4_a,
PCcz_usi_SideANegCurrSensor5_a,
PCcz_usi_SideAPosCurrSensor1_a,
PCcz_usi_SideAPosCurrSensor2_a,
PCcz_usi_SideAPosCurrSensor3_a,
PCcz_usi_SideAPosCurrSensor4_a,
PCcz_usi_SideAPosCurrSensor5_a,
PCdc_bo_ADCOK,
PCdc_bo_BIASError,
PCdc_bo_CANWD,
PCdc_bo_CONFIGMode,
PCdc_bo_CTopen,
PCdc_bo_CVTFault,
PCdc_bo_CVTHWFault,
PCdc_bo_CVTON,
PCdc_bo_CVTonReq,
PCdc_bo_DACok,
PCdc_bo_FaultLATCH,
PCdc_bo_HWFault,
PCdc_bo_InputOC,
PCdc_bo_InputOV,
PCdc_bo_InputUV,
PCdc_bo_OT,
PCdc_bo_OutputOC,
PCdc_bo_OutputOV,
PCdc_bo_OutputUV,
PCdc_bo_PLIM,
PCdc_bo_PLIMTemp,
PCdc_bo_REG_ERR,
PCdc_en_CTRLMode,
PCdc_en_Enabled,
PCdc_en_OverTemp,
PCdc_en_Status,
PCdc_en_TBD,
PCdc_uin_PACC_kwh,
PCdc_uin_RUNTIME_m,
PCdc_usi_CDCT_c,
PCdc_usi_DAC_v,
PCdc_usi_HeatsinkT_c,
PCdc_usi_InputI_a,
PCdc_usi_InputV_v,
PCdc_usi_IOut1_a,
PCdc_usi_IOut2_a,
PCdc_usi_IOut3_a,
PCdc_usi_OutputI_a,
PCdc_usi_OutputP_kw,
PCdc_usi_OutputV_v,
PCdc_usi_P12V_v,
PCdc_usi_SWVer,
PCdc_usi_TBD2,
PCes_bo_ChargerAErrCFG,
PCes_bo_ChargerAErrCHG,
PCes_bo_ChargerAErrPLP,
PCes_bo_ChargerBErrCFG,
PCes_bo_ChargerBErrCHG,
PCes_bo_ChargerBErrPLP,
PCes_bo_CTFault,
PCes_bo_HighTError,
PCes_bo_HighTWarn,
PCes_bo_HighVWarn,
PCes_bo_LowVError,
PCes_bo_LowVWarn,
PCes_bo_SoCImbalanceWarn,
PCes_bo_String1Active,
PCes_bo_String2Active,
PCes_bo_String3Active,
PCes_bo_String4Active,
PCes_bo_String5Active,
PCes_en_C0Mode,
PCes_en_C1Mode,
PCes_en_C2Mode,
PCes_en_C3Mode,
PCes_en_C4Mode,
PCes_en_C5Mode,
PCes_en_C6Mode,
PCes_en_C7Mode,
PCes_en_ChargerAErrEOC,
PCes_en_ChargerAErrorID,
PCes_en_ChargerBErrEOC,
PCes_en_ChargerBErrorID,
PCes_en_DerateCharge,
PCes_en_DerateDischarge,
PCes_en_SoCmaxPackID,
PCes_en_SoCminPackID,
PCes_en_VmaxPackID,
PCes_en_VminPackID,
PCes_uin_I_a,
PCes_uin_V_v,
PCes_usi_AvailableChargeP_kw,
PCes_usi_AvailableDischargeP_kw,
PCes_usi_ChargeEnable_xx,
PCes_usi_ChargerAErrMsg_xx,
PCes_usi_ChargerBErrMsg_xx,
PCes_usi_DerateReason_xx,
PCes_usi_SoCavg_pct,
PCes_usi_SoCmax_pct,
PCes_usi_SoCmin_pct,
PCes_usi_Tmax_c,
PCes_usi_Vmax_mv,
PCes_usi_Vmin_mv,
PCpm0_bo_ContactorStatus,
PCpm0_bo_GroundFault,
PCpm0_bo_HighTempErr,
PCpm0_bo_HighTempWarn,
PCpm0_bo_HighVoltWarn,
PCpm0_bo_LowSOCWarn,
PCpm0_bo_PackDisableReq,
PCpm0_bo_RedPerfReq,
PCpm0_uin_PackI_a,
PCpm0_usi_AvgCellT_c,
PCpm0_usi_AvgCellV_mv,
PCpm0_usi_Cell1_mv,
PCpm0_usi_Cell2_mv,
PCpm0_usi_Cell3_mv,
PCpm0_usi_Cell4_mv,
PCpm0_usi_Cell5_mv,
PCpm0_usi_Cell6_mv,
PCpm0_usi_Cell7_mv,
PCpm0_usi_Index_xx,
PCpm0_usi_MaxCellV_mv,
PCpm0_usi_MaxCellVID_xx,
PCpm0_usi_MaxPackT_c,
PCpm0_usi_MaxPackTID_xx,
PCpm0_usi_MinCellV_mv,
PCpm0_usi_MinCellVID_xx,
PCpm0_usi_PackV_v,
PCpm0_usi_SoCmax_pct,
PCpm0_usi_SoCmin_pct,
PCpm0_usi_Tmax_c,
PCpm1_bo_ContactorStatus,
PCpm1_bo_GroundFault,
PCpm1_bo_HighTempErr,
PCpm1_bo_HighTempWarn,
PCpm1_bo_HighVoltWarn,
PCpm1_bo_LowSOCWarn,
PCpm1_bo_PackDisableReq,
PCpm1_bo_RedPerfReq,
PCpm1_uin_PackI_a,
PCpm1_usi_AvgCellT_c,
PCpm1_usi_AvgCellV_mv,
PCpm1_usi_Cell1_mv,
PCpm1_usi_Cell2_mv,
PCpm1_usi_Cell3_mv,
PCpm1_usi_Cell4_mv,
PCpm1_usi_Cell5_mv,
PCpm1_usi_Cell6_mv,
PCpm1_usi_Cell7_mv,
PCpm1_usi_Index_xx,
PCpm1_usi_MaxCellV_mv,
PCpm1_usi_MaxCellVID_xx,
PCpm1_usi_MaxPackT_c,
PCpm1_usi_MaxPackTID_xx,
PCpm1_usi_MinCellV_mv,
PCpm1_usi_MinCellVID_xx,
PCpm1_usi_PackV_v,
PCpm1_usi_SoCmax_pct,
PCpm1_usi_SoCmin_pct,
PCpm1_usi_Tmax_c,
PCpm2_bo_ContactorStatus,
PCpm2_bo_GroundFault,
PCpm2_bo_HighTempErr,
PCpm2_bo_HighTempWarn,
PCpm2_bo_HighVoltWarn,
PCpm2_bo_LowSOCWarn,
PCpm2_bo_PackDisableReq,
PCpm2_bo_RedPerfReq,
PCpm2_uin_PackI_a,
PCpm2_usi_AvgCellT_c,
PCpm2_usi_AvgCellV_mv,
PCpm2_usi_Cell1_mv,
PCpm2_usi_Cell2_mv,
PCpm2_usi_Cell3_mv,
PCpm2_usi_Cell4_mv,
PCpm2_usi_Cell5_mv,
PCpm2_usi_Cell6_mv,
PCpm2_usi_Cell7_mv,
PCpm2_usi_Index_xx,
PCpm2_usi_MaxCellT_c,
PCpm2_usi_MaxCellTID_xx,
PCpm2_usi_MaxCellV_mv,
PCpm2_usi_MaxCellVID_xx,
PCpm2_usi_MinCellV_mv,
PCpm2_usi_MinCellVID_xx,
PCpm2_usi_PackV_v,
PCpm2_usi_SoCmax_pct,
PCpm2_usi_SoCmin_pct,
PCpm2_usi_Tmax_c,
PCpm3_bo_ContactorStatus,
PCpm3_bo_GroundFault,
PCpm3_bo_HighTempErr,
PCpm3_bo_HighTempWarn,
PCpm3_bo_HighVoltWarn,
PCpm3_bo_LowSOCWarn,
PCpm3_bo_PackDisableReq,
PCpm3_bo_RedPerfReq,
PCpm3_uin_PackI_a,
PCpm3_usi_AvgCellT_c,
PCpm3_usi_AvgCellV_mv,
PCpm3_usi_Cell1_mv,
PCpm3_usi_Cell2_mv,
PCpm3_usi_Cell3_mv,
PCpm3_usi_Cell4_mv,
PCpm3_usi_Cell5_mv,
PCpm3_usi_Cell6_mv,
PCpm3_usi_Cell7_mv,
PCpm3_usi_Index_xx,
PCpm3_usi_MaxCellT_c,
PCpm3_usi_MaxCellTID_xx,
PCpm3_usi_MaxCellV_mv,
PCpm3_usi_MaxCellVID_xx,
PCpm3_usi_MinCellV_mv,
PCpm3_usi_MinCellVID_xx,
PCpm3_usi_PackV_v,
PCpm3_usi_SoCmax_pct,
PCpm3_usi_SoCmin_pct,
PCpm3_usi_Tmax_c,
PCpm4_bo_ContactorStatus,
PCpm4_bo_GroundFault,
PCpm4_bo_HighTempErr,
PCpm4_bo_HighTempWarn,
PCpm4_bo_HighVoltWarn,
PCpm4_bo_LowSOCWarn,
PCpm4_bo_PackDisableReq,
PCpm4_bo_RedPerfReq,
PCpm4_uin_PackI_a,
PCpm4_usi_AvgCellT_c,
PCpm4_usi_AvgCellV_mv,
PCpm4_usi_Cell1_mv,
PCpm4_usi_Cell2_mv,
PCpm4_usi_Cell3_mv,
PCpm4_usi_Cell4_mv,
PCpm4_usi_Cell5_mv,
PCpm4_usi_Cell6_mv,
PCpm4_usi_Cell7_mv,
PCpm4_usi_Index_xx,
PCpm4_usi_MaxCellT_c,
PCpm4_usi_MaxCellTID_xx,
PCpm4_usi_MaxCellV_mv,
PCpm4_usi_MaxCellVID_xx,
PCpm4_usi_MinCellV_mv,
PCpm4_usi_MinCellVID_xx,
PCpm4_usi_PackV_v,
PCpm4_usi_SoCmax_pct,
PCpm4_usi_SoCmin_pct,
PCpm4_usi_Tmax_c,
PCpm5_bo_ContactorStatus,
PCpm5_bo_GroundFault,
PCpm5_bo_HighTempErr,
PCpm5_bo_HighTempWarn,
PCpm5_bo_HighVoltWarn,
PCpm5_bo_LowSOCWarn,
PCpm5_bo_PackDisableReq,
PCpm5_bo_RedPerfReq,
PCpm5_uin_PackI_a,
PCpm5_usi_AvgCellT_c,
PCpm5_usi_AvgCellV_mv,
PCpm5_usi_Cell1_mv,
PCpm5_usi_Cell2_mv,
PCpm5_usi_Cell3_mv,
PCpm5_usi_Cell4_mv,
PCpm5_usi_Cell5_mv,
PCpm5_usi_Cell6_mv,
PCpm5_usi_Cell7_mv,
PCpm5_usi_Index_xx,
PCpm5_usi_MaxCellT_c,
PCpm5_usi_MaxCellTID_xx,
PCpm5_usi_MaxCellV_mv,
PCpm5_usi_MaxCellVID_xx,
PCpm5_usi_MinCellV_mv,
PCpm5_usi_MinCellVID_xx,
PCpm5_usi_PackV_v,
PCpm5_usi_SoCmax_pct,
PCpm5_usi_SoCmin_pct,
PCpm5_usi_Tmax_c,
PCpm6_bo_ContactorStatus,
PCpm6_bo_GroundFault,
PCpm6_bo_HighTempErr,
PCpm6_bo_HighTempWarn,
PCpm6_bo_HighVoltWarn,
PCpm6_bo_LowSOCWarn,
PCpm6_bo_PackDisableReq,
PCpm6_bo_RedPerfReq,
PCpm6_uin_PackI_a,
PCpm6_usi_AvgCellT_c,
PCpm6_usi_AvgCellV_mv,
PCpm6_usi_Cell1_mv,
PCpm6_usi_Cell2_mv,
PCpm6_usi_Cell3_mv,
PCpm6_usi_Cell4_mv,
PCpm6_usi_Cell5_mv,
PCpm6_usi_Cell6_mv,
PCpm6_usi_Cell7_mv,
PCpm6_usi_Index_xx,
PCpm6_usi_MaxCellT_c,
PCpm6_usi_MaxCellTID_xx,
PCpm6_usi_MaxCellV_mv,
PCpm6_usi_MaxCellVID_xx,
PCpm6_usi_MinCellV_mv,
PCpm6_usi_MinCellVID_xx,
PCpm6_usi_PackV_v,
PCpm6_usi_SoCmax_pct,
PCpm6_usi_SoCmin_pct,
PCpm6_usi_Tmax_c,
PCpm7_bo_ContactorStatus,
PCpm7_bo_GroundFault,
PCpm7_bo_HighTempErr,
PCpm7_bo_HighTempWarn,
PCpm7_bo_HighVoltWarn,
PCpm7_bo_LowSOCWarn,
PCpm7_bo_PackDisableReq,
PCpm7_bo_RedPerfReq,
PCpm7_uin_PackI_a,
PCpm7_usi_AvgCellT_c,
PCpm7_usi_AvgCellV_mv,
PCpm7_usi_Cell1_mv,
PCpm7_usi_Cell2_mv,
PCpm7_usi_Cell3_mv,
PCpm7_usi_Cell4_mv,
PCpm7_usi_Cell5_mv,
PCpm7_usi_Cell6_mv,
PCpm7_usi_Cell7_mv,
PCpm7_usi_Index_xx,
PCpm7_usi_MaxCellT_c,
PCpm7_usi_MaxCellTID_xx,
PCpm7_usi_MaxCellV_mv,
PCpm7_usi_MaxCellVID_xx,
PCpm7_usi_MinCellV_mv,
PCpm7_usi_MinCellVID_xx,
PCpm7_usi_PackV_v,
PCpm7_usi_SoCmax_pct,
PCpm7_usi_SoCmin_pct,
PCpm7_usi_Tmax_c,
PCpt_bo_TMAccelLimitDisable,
PCpt_bo_TMDirBit,
PCpt_bo_TMEnable,
PCpt_bo_TMUseRawSpeed,
PCpt_en_Clutch1State,
PCpt_en_Clutch2State,
PCpt_en_Gear1FdbkStat,
PCpt_en_Gear2FdbkStat,
PCpt_en_ParkingBrakeSw,
PCpt_en_PresentGear,
PCpt_en_RequestedGear,
PCpt_en_StopLampSw,
PCpt_en_TMCommandCounter_xx,
PCpt_en_TMTurboMode,
PCpt_int_Spd_mph,
PCpt_uin_OutputSpd_rpm,
PCpt_uin_TMAccelLim_rpmps,
PCpt_uin_TMMaxFwdSpdLim_rpm,
PCpt_uin_TMMaxRevSpdLim_rpm,
PCpt_uin_TMMaxTrqLim_nm,
PCpt_uin_TMMinTrqLim_nm,
PCpt_uin_TMReqSignedSpd_rpm,
PCpt_uin_TMReqSignedTrq_nm,
PCpt_uin_TMSurgeLim_rpm,
PCpt_uin_VehicleSpd_kph,
PCpt_usi_Accel_mphps,
PCpt_usi_CycleTime_ms,
PCpt_usi_Fault1_xx,
PCpt_usi_Fault2_xx,
PCpt_usi_Fault3_xx,
PCpt_usi_Fault4_xx,
PCpt_usi_MotorAvailPower_pct,
PCpt_usi_RegenAvailPower_pct,
PCpt_usi_ShiftState_xx,
PCpt_usi_SWNum_xx,
PCpt_usi_SWVer_xx,
PCpt_usi_TMAccelCtrlMode,
PCpt_usi_TMCWCCmd_xx,
PCpt_usi_TMElecPower_kw,
PCpt_usi_TMMechPower_kw,
PCpt_usi_TMResetWDError_xx,
PCpt_usi_TMResetWDTimer_xx,
PCpt_usi_TransTemp_c,
PCpt_usi_Watchdog_xx,
PCrh_en_AboveNomFA,
PCrh_en_AboveNomRA,
PCrh_en_BelowNomFA,
PCrh_en_BelowNomRA,
PCrh_en_DoorRelease,
PCrh_en_FABumperRange,
PCrh_en_KneelingInfo,
PCrh_en_LevelCtrlMode,
PCrh_en_LiftAxle1Pos,
PCrh_en_LiftAxle2Pos,
PCrh_en_LiftingCtrlModeFA,
PCrh_en_LiftingCtrlModeRA,
PCrh_en_LoweringCtrlModeFA,
PCrh_en_LoweringCtrlModeRA,
PCrh_en_NomLevelFA,
PCrh_en_NomLevelRA,
PCrh_en_RABumperRange,
PCrh_en_SecurityDevice,
PCrh_en_SuspCtrlRefusal,
PCrh_en_SuspRemoteCtrl1,
PCrh_en_SuspRemoteCtrl2,
PCrh_en_VehicleMotionInhibit,
PCrh_uin_RelLevelCSF_mm,
PCrh_uin_RelLevelCSR_mm,
PCrh_uin_RelLevelSSF_mm,
PCrh_uin_RelLevelSSR_mm,
PCtm_bo_IGBTTempStatus,
PCtm_bo_SSMABCPhaseOrder,
PCtm_bo_SSMActivelyDampening,
PCtm_bo_SSMADCCalibrationP,
PCtm_bo_SSMBadPosSens,
PCtm_bo_SSMBadPowerSwitchDriver,
PCtm_bo_SSMBusOverIOpenLoop,
PCtm_bo_SSMCurrentTripFlt,
PCtm_bo_SSMDisabledMtrInMotion,
PCtm_bo_SSMForcedOpenLoop,
PCtm_bo_SSMForceVCtrlMode,
PCtm_bo_SSMInvalidPwrSupply,
PCtm_bo_SSMInvFault,
PCtm_bo_SSMInvFaultOccured,
PCtm_bo_SSMInvOverTOpenSensor,
PCtm_bo_SSMLegOverIOpenLoop,
PCtm_bo_SSMMtrOverTOpenSensor,
PCtm_bo_SSMNotEnabled,
PCtm_bo_SSMOverP,
PCtm_bo_SSMOverPhaseAdvance,
PCtm_bo_SSMOverSpdAlarm,
PCtm_bo_SSMOverSpdWarning,
PCtm_bo_SSMOverVAlarm,
PCtm_bo_SSMOverVWarning,
PCtm_bo_SSMPhaseCurrentSensErr,
PCtm_bo_SSMPwrSwitchOff,
PCtm_bo_SSMRegenSwitchOpen,
PCtm_bo_SSMRotorOverTOpenSensor,
PCtm_bo_SSMStallConditionActive,
PCtm_bo_SSMTurboMode,
PCtm_bo_SSMUnderVWarn,
PCtm_bo_SSMUnivCmdLimiting,
PCtm_bo_WatchdogError,
PCtm_bo_WDToggleBit,
PCtm_en_CANVer,
PCtm_en_SWVerSub,
PCtm_uin_AngularDist_deg,
PCtm_uin_Current_a,
PCtm_uin_Speed_rpm,
PCtm_uin_TMTorqueDesired_nm,
PCtm_uin_Torque_nm,
PCtm_uin_Voltage_v,
PCtm_usi_AvailDrivePower_kw,
PCtm_usi_AvailRegenPower_kw,
PCtm_usi_CWCCmd_constant,
PCtm_usi_EstRotorTemp_c,
PCtm_usi_IGBTTemp_c,
PCtm_usi_IGBTTempLimTime_s,
PCtm_usi_InvHeatSinkTemp_c,
PCtm_usi_StallSafety_pct,
PCtm_usi_StatorTemp_c,
PCtm_usi_SWVerMaj,
PCtm_usi_SWVerMinor_xx,
Use_PCAN_diag_channel_to_decode,VinId
from PivotDatVw with(nolock) ;

GO
/****** Object:  View [fht].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[RawTraceDataBus] AS  
 SELECT * FROM fht.RawTraceData_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceData_1M9TG11J7AG816005 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.RawTraceDataStage_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[RawTraceDataBus] AS  
 SELECT * FROM Lou.RawTraceData_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceData_1M9TG16J6ES816072 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[RawTraceDataBus] AS  
 SELECT * FROM Nas.RawTraceData_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceData_1M9TG16J4ES816071 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[RawTraceDataBus] AS  
 SELECT * FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceData_1M9TG16J4CS816018 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.RawTraceDataStage_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[RawTraceDataBus] AS  
 SELECT * FROM Ren.RawTraceData_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceData_1M9TG16J8DS816038 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Ren.RawTraceDataStage_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[RawTraceDataBus] AS  
 SELECT * FROM San.RawTraceData_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceData_1M9TG11J2BS816010 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.RawTraceDataStage_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [Sen].[RawTraceDataBus]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16JXDS816039 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceData_1M9TG16JXDS816039 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceData_1M9TG16J2CS816017 WITH(NOLOCK)





GO
/****** Object:  View [Sto].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[RawTraceDataBus] AS  
 SELECT * FROM Sto.RawTraceData_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.RawTraceData_1M9TG16J0CS816016 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.RawTraceDataStage_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[RawTraceDataBus] AS  
 SELECT * FROM Tal.RawTraceData_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceData_1M9TG16J6DS816023 WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Tal.RawTraceDataStage_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [Wor].[RawTraceDataBus]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816031 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_Worcester WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_1M9TG16J3DS816031 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceData_Worcester WITH(NOLOCK)







GO
/****** Object:  View [dbo].[RawTraceDataBus]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE VIEW [dbo].[RawTraceDataBus]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceDataBus]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceDataBus]



















GO
/****** Object:  View [fht].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[TraceDecodeCharger] AS  
SELECT * FROM fht.TraceDecodeStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecodeStage_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.TraceDecode_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[TraceDecodeCharger] AS  
SELECT * FROM Lou.TraceDecodeStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecodeStage_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.TraceDecode_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[TraceDecodeCharger] AS  
SELECT * FROM Nas.TraceDecodeStage_Nashville WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Nas.TraceDecode_Nashville WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[TraceDecodeCharger] AS  
SELECT * FROM Pro.TraceDecodeStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecode_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecodeStage_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.TraceDecode_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Ren].[TraceDecodeCharger]

AS



SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Ren.TraceDecodeStage_Reno WITH(NOLOCK)

UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Ren.TraceDecode_Reno WITH(NOLOCK)




GO
/****** Object:  View [San].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[TraceDecodeCharger] AS  
SELECT * FROM San.TraceDecodeStage_SanAntonio WITH (NOLOCK)
 UNION ALL 
SELECT * FROM San.TraceDecode_SanAntonio WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Sen].[TraceDecodeCharger]

AS



SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaHospital WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecode_SenecaHospital WITH(NOLOCK)





GO
/****** Object:  View [Sto].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[TraceDecodeCharger] AS  
SELECT * FROM Sto.TraceDecodeStage_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.TraceDecode_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [Tal].[TraceDecodeCharger]

AS



SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM tal.TraceDecodeStage_Tallahassee WITH(NOLOCK)

UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM tal.TraceDecode_Tallahassee WITH(NOLOCK)

GO
/****** Object:  View [Wor].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [Wor].[TraceDecodeCharger]

AS


SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_Worcester WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecode_Worcester WITH(NOLOCK)



GO
/****** Object:  View [dbo].[TraceDecodeCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE view [dbo].[TraceDecodeCharger] 
AS
    SELECT  TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM  Ren.TraceDecodeCharger WITH (NOLOCK)
     UNION ALL 
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sen.TraceDecodeCharger WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Wor.TraceDecodeCharger WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Pro.TraceDecodeCharger WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Tal.TraceDecodeCharger WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   San.TraceDecodeCharger WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Nas.TraceDecodeCharger WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Lou.TraceDecodeCharger WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Fht.TraceDecodeCharger WITH (NOLOCK)
	 UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sto.TraceDecodeCharger WITH (NOLOCK)



















GO
/****** Object:  View [fht].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[PivotDatVwCharger] AS  
SELECT * FROM fht.PCanBusChrPivotStage_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivot_PomonaNorth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivotStage_PomonaSouth WITH (NOLOCK)
 UNION ALL 
SELECT * FROM fht.PCanBusChrPivot_PomonaSouth WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[PivotDatVwCharger] AS  
SELECT * FROM Lou.PCanBusChrPivotStage_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivot_LouisvilleMarket WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivotStage_LouisvilleThird WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Lou.PCanBusChrPivot_LouisvilleThird WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  VIEW [Nas].[PivotDatVwCharger]
AS 


SELECT  * from Nas.PCanBusChrPivot_Nashville  WITH(NOLOCK)
UNION ALL
SELECT  * from Nas.PCanBusChrPivotStage_Nashville  WITH(NOLOCK)







GO
/****** Object:  View [Pro].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[PivotDatVwCharger] AS  
SELECT * FROM Pro.PCanBusChrPivotStage_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivot_Plant WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivotStage_Trailer WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Pro.PCanBusChrPivot_Trailer WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  VIEW [Ren].[PivotDatVwCharger]
AS 


SELECT  * from ren.PCanBusChrPivot_Reno  WITH(NOLOCK)
UNION ALL
SELECT  * from ren.PCanBusChrPivotStage_Reno  WITH(NOLOCK)


GO
/****** Object:  View [San].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  VIEW [San].[PivotDatVwCharger]
AS 


SELECT  * from San.PCanBusChrPivot_SanAntonio  WITH(NOLOCK)
UNION ALL
SELECT  * from San.PCanBusChrPivotStage_SanAntonio  WITH(NOLOCK)







GO
/****** Object:  View [Sen].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE  VIEW [Sen].[PivotDatVwCharger]
AS 

 
SELECT  * from Sen.PCanBusChrPivot_SenecaDowntown  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivot_SenecaHospital  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_SenecaDowntown  WITH(NOLOCK)
UNION ALL 
SELECT  * from Sen.PCanBusChrPivotStage_SenecaHospital  WITH(NOLOCK)






GO
/****** Object:  View [Sto].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[PivotDatVwCharger] AS  
SELECT * FROM Sto.PCanBusChrPivotStage_Stockton WITH (NOLOCK)
 UNION ALL 
SELECT * FROM Sto.PCanBusChrPivot_Stockton WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  VIEW [Tal].[PivotDatVwCharger]
AS 


SELECT  * from tal.PCanBusChrPivot_Tallahassee  WITH(NOLOCK)
UNION ALL
SELECT  * from tal.PCanBusChrPivotStage_Tallahassee  WITH(NOLOCK)






GO
/****** Object:  View [Wor].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE  VIEW [Wor].[PivotDatVwCharger]
AS 


SELECT  * from Wor.PCanBusChrPivot_Worcester  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_Worcester  WITH(NOLOCK)





GO
/****** Object:  View [dbo].[PivotDatVwCharger]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO













CREATE VIEW [dbo].[PivotDatVwCharger]
AS

SELECT * FROM Wor.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Sen.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Ren.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Pro.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Tal.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM San.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Nas.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Lou.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Fht.PivotDatVwCharger WITH(NOLOCK)
UNION ALL
SELECT * FROM Sto.PivotDatVwCharger WITH(NOLOCK)













GO
/****** Object:  View [dbo].[GetTraceDatasetChrBusVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[GetTraceDatasetChrBusVw]

AS
SELECT tf.FileName , 
       v.Vin , 
       rtd.TraceDt , 
       rtd.Increment , 
       rtd.Bus , 
       rtd.DLC , 
       rtd.SymbolIDHex , 
       rtd.Data , 
       rtd.ChargingStationID , 
       tm.dateID , 
       tf.FileID , 
       rtd.VinID , 
       cs.Location AS ChargerLoc
  FROM
       RawTraceDataCharger AS rtd WITH ( nolock) 
	  INNER JOIN TraceMaster AS tm WITH (Nolock) ON tm.TraceMasterID =  rtd.TraceMasterID
       INNER JOIN TraceFiles AS tf WITH (Nolock)  ON tf.FileID = tm.FileID      
       INNER JOIN Vehicles AS v WITH (Nolock) ON v.VinID = rtd.VinID
       --LEFT OUTER JOIN ChargingStations AS cs WITH ( nolock)  ON cs.ChargingStationID = rtd.ChargingStationID
	  INNER JOIN ChargingStations AS cs WITH ( nolock)  ON cs.ChargingStationID = rtd.ChargingStationID
  WHERE rtd.ChargingStationID IS NOT NULL ;              




GO
/****** Object:  View [fht].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[TraceDecodeStage] AS  
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.TraceDecodeStage_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[TraceDecodeStage] AS  
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.TraceDecodeStage_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[TraceDecodeStage] AS  
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.TraceDecodeStage_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[TraceDecodeStage] AS  
 SELECT * FROM Pro.TraceDecodeStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.TraceDecodeStage_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[TraceDecodeStage] AS  
 SELECT * FROM Ren.TraceDecodeStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecodeStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecodeStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.TraceDecodeStage_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[TraceDecodeStage] AS  
 SELECT * FROM San.TraceDecodeStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecodeStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.TraceDecodeStage_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [Sen].[TraceDecodeStage]

AS

SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaDowntown WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Sen.TraceDecodeStage_SenecaHospital WITH(NOLOCK)






GO
/****** Object:  View [Sto].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[TraceDecodeStage] AS  
 SELECT * FROM Sto.TraceDecodeStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.TraceDecodeStage_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[TraceDecodeStage] AS  
 SELECT * FROM Tal.TraceDecodeStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecodeStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecodeStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecodeStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.TraceDecodeStage_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [Wor].[TraceDecodeStage]

AS

SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_1M9TG16J3DS816031 WITH(NOLOCK)
UNION ALL
SELECT TraceID,TraceMasterID,PCanVID,RowNum,DataVal,DataEnum,VinID,ChargingStationID,TraceDt FROM Wor.TraceDecodeStage_Worcester WITH(NOLOCK)





GO
/****** Object:  View [dbo].[TraceDecodeStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO











CREATE view [dbo].[TraceDecodeStage] 
AS
    SELECT  TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Ren.TraceDecodeStage WITH (NOLOCK)
     UNION ALL 
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sen.TraceDecodeStage WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Wor.TraceDecodeStage WITH (NOLOCK)
     UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Pro.TraceDecodeStage WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Tal.TraceDecodeStage WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   San.TraceDecodeStage WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Nas.TraceDecodeStage WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Lou.TraceDecodeStage WITH (NOLOCK)
    UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Fht.TraceDecodeStage WITH (NOLOCK)
	UNION ALL
    SELECT TraceID, TraceMasterID, PCanVID, RowNum, VinID, DataEnum, DataVal, ChargingStationID, TraceDt FROM   Sto.TraceDecodeStage WITH (NOLOCK)














GO
/****** Object:  View [fht].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[PivotDatStageVw] AS  
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.PCanBusChrPivotStage_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[PivotDatStageVw] AS  
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.PCanBusChrPivotStage_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[PivotDatStageVw] AS  
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.PCanBusChrPivotStage_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[PivotDatStageVw] AS  
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.PCanBusChrPivotStage_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[PivotDatStageVw] AS  
 SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.PCanBusChrPivotStage_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[PivotDatStageVw] AS  
 SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.PCanBusChrPivotStage_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE  VIEW [Sen].[PivotDatStageVw]
AS 



SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J6CS816019  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J4CS816021  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J8DS816024  WITH(NOLOCK)
UNION ALL
SELECT  * from Sen.PCanBusChrPivotStage_1M9TG16J3DS816030  WITH(NOLOCK)





GO
/****** Object:  View [Sto].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[PivotDatStageVw] AS  
 SELECT * FROM Sto.PCanBusChrPivotStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.PCanBusChrPivotStage_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[PivotDatStageVw] AS  
 SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.PCanBusChrPivotStage_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE  VIEW [Wor].[PivotDatStageVw]
AS 



SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16JXDS816025  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J1DS816026  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J3DS816027  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J5DS816028  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J7DS816029  WITH(NOLOCK)
UNION ALL
SELECT  * from Wor.PCanBusChrPivotStage_1M9TG16J3DS816031  WITH(NOLOCK)






GO
/****** Object:  View [dbo].[PivotDatStageVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[PivotDatStageVw]
AS

SELECT  * FROM Wor.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Sen.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Ren.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Tal.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM San.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Pro.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Nas.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Lou.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Fht.PivotDatStageVw WITH(NOLOCK)
UNION ALL
SELECT  * FROM Sto.PivotDatStageVw WITH(NOLOCK)
















GO
/****** Object:  View [fht].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [fht].[RawTraceDataBusStage] AS  
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J6DS816040 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J8DS816041 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16JXDS816042 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J1DS816043 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J3DS816044 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J5DS816045 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J7DS816046 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816047 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816048 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J2DS816049 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J9DS816050 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG16J0DS816051 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J3AG816003 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J5AG816004 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM fht.RawTraceDataStage_1M9TG11J7AG816005 WITH (NOLOCK)  


GO
/****** Object:  View [Lou].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Lou].[RawTraceDataBusStage] AS  
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J0ES816052 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J2ES816053 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J4ES816054 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816055 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J8ES816056 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816057 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816058 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J3ES816059 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16JXES816060 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J1ES816061 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Lou.RawTraceDataStage_1M9TG16J6ES816072 WITH (NOLOCK)  


GO
/****** Object:  View [Nas].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Nas].[RawTraceDataBusStage] AS  
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J9ES816065 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J0ES816066 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816067 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816068 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J6ES816069 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J2ES816070 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Nas.RawTraceDataStage_1M9TG16J4ES816071 WITH (NOLOCK)  


GO
/****** Object:  View [Pro].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Pro].[RawTraceDataBusStage] AS  
 SELECT * FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J9ES816063 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J0ES816064 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TH16J7ES816062 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J59G816001 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J9BG816007 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG11J3CS816020 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Pro.RawTraceDataStage_1M9TG16J4CS816018 WITH (NOLOCK)  

GO
/****** Object:  View [Ren].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Ren].[RawTraceDataBusStage] AS  
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J2DS816035 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J4DS816036 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J6DS816037 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Ren.RawTraceDataStage_1M9TG16J8DS816038 WITH (NOLOCK)  


GO
/****** Object:  View [San].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [San].[RawTraceDataBusStage] AS  
 SELECT * FROM San.RawTraceDataStage_1M9TG11J4BS816008 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceDataStage_1M9TG11J6BS816009 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM San.RawTraceDataStage_1M9TG11J2BS816010 WITH (NOLOCK)  


GO
/****** Object:  View [Sen].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [Sen].[RawTraceDataBusStage]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J6CS816019 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J4CS816021 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J8DS816024 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16J3DS816030 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Sen.RawTraceDataStage_1M9TG16JXDS816039 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Pro.RawTraceDataStage_1M9TG16J2CS816017 WITH(NOLOCK)







GO
/****** Object:  View [Sto].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Sto].[RawTraceDataBusStage] AS  
 SELECT * FROM Sto.RawTraceDataStage_1M9TG16J9CS816015 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Sto.RawTraceDataStage_1M9TG16J0CS816016 WITH (NOLOCK)  

GO
/****** Object:  View [Tal].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW   [Tal].[RawTraceDataBusStage] AS  
 SELECT * FROM Tal.RawTraceDataStage_1M9TG11J2CS816011 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J3CS816012 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J5CS816013 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J4DS816022 WITH (NOLOCK)
 UNION ALL 
 SELECT * FROM Tal.RawTraceDataStage_1M9TG16J6DS816023 WITH (NOLOCK)  


GO
/****** Object:  View [Wor].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE VIEW [Wor].[RawTraceDataBusStage]

AS

SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16JXDS816025 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J1DS816026 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816027 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J5DS816028 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J7DS816029 WITH(NOLOCK)
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_1M9TG16J3DS816031 WITH(NOLOCK)
--UNION ALL
--SELECT  TraceID,TraceMasterID,Increment,Bus,Type,SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM Wor.RawTraceDataStage_Worcester WITH(NOLOCK)








GO
/****** Object:  View [dbo].[RawTraceDataBusStage]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO















CREATE VIEW [dbo].[RawTraceDataBusStage]
AS
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sen].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Ren].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Wor].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Pro].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Tal].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [San].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Nas].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Lou].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Fht].[RawTraceDataBusStage]
UNION ALL
SELECT  TraceID,TraceMasterID,Increment,Bus,[Type],SymbolIDHex,DLC,Data,VinID,ChargingStationID,TraceDt FROM [Sto].[RawTraceDataBusStage]




















GO
/****** Object:  View [dbo].[PCanBusTwoHz_Committed]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO












CREATE View [dbo].[PCanBusTwoHz_Committed]
AS
SELECT * from [Wor].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Sen].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Ren].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Pro].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Tal].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [San].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Nas].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [Lou].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [fht].[PCanBusTwoHz] with (nolock)
UNION ALL
SELECT * from [sto].[PCanBusTwoHz] with (nolock)






GO
/****** Object:  View [dbo].[ChargingStationsVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[ChargingStationsVw] 
AS 
select c.CustomerID,c.CustomerName,c.FileGrp,cs.ChargingStationID,cs.Location from ChargingStations cs
inner join CustomerChargingStations ccs with(nolock) on  ccs.ChargingStationID = cs.ChargingStationID 
inner join Customers c with(nolock) on c.customerid = ccs.customerid 
where cs.IsActive = 1

GO
/****** Object:  View [dbo].[CurrentProcessing_RAWBUSDATA]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CurrentProcessing_RAWBUSDATA]
as
select SUBSTRING (PackageName,24,3) as Loc ,Right(PackageName, 17) + ' [' + SUBSTRING (PackageName,24,3) + ']' as VIN ,ProcessDate,TotalFilesReceived, TotalFilesProcessed,IsNextDayFileAvailiable * 10 IsNextDayFileAvailiable from ProcessQueue where processStatus <> 'IsComplete' and TotalFilesReceived > 0 and processType = 'RAWBUSDATA' 

GO
/****** Object:  View [dbo].[FileGroupDetail]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[FileGroupDetail]
AS
    SELECT  pf.name AS pf_name ,
            ps.name AS partition_scheme_name ,
            p.partition_number ,
            ds.name AS partition_filegroup ,
            OBJECT_NAME(si.object_id) AS object_name ,
            rv.value AS range_value ,
            SUM(CASE WHEN si.index_id IN ( 1, 0 ) THEN p.rows
                     ELSE 0
                END) AS num_rows
    FROM    sys.destination_data_spaces AS dds
            JOIN sys.data_spaces AS ds ON dds.data_space_id = ds.data_space_id
            JOIN sys.partition_schemes AS ps ON dds.partition_scheme_id = ps.data_space_id
            JOIN sys.partition_functions AS pf ON ps.function_id = pf.function_id
            LEFT JOIN sys.partition_range_values AS rv ON pf.function_id = rv.function_id
                                                          AND dds.destination_id = CASE pf.boundary_value_on_right
                                                                                     WHEN 0 THEN rv.boundary_id
                                                                                     ELSE rv.boundary_id + 1
                                                                                   END
            LEFT JOIN sys.indexes AS si ON dds.partition_scheme_id = si.data_space_id
            LEFT JOIN sys.partitions AS p ON si.object_id = p.object_id
                                             AND si.index_id = p.index_id
                                             AND dds.destination_id = p.partition_number
            LEFT JOIN sys.dm_db_partition_stats AS dbps ON p.object_id = dbps.object_id
                                                           AND p.partition_id = dbps.partition_id
    GROUP BY ds.name ,
            p.partition_number ,
            pf.name ,
            pf.type_desc ,
            pf.fanout ,
            pf.boundary_value_on_right ,
            ps.name ,
            si.object_id ,
            rv.value;
GO
/****** Object:  View [dbo].[ObjectDetail]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Create a view to see partition information by object
CREATE VIEW [dbo].[ObjectDetail]	
AS
SELECT  SCHEMA_NAME(so.schema_id) AS schema_name ,
        OBJECT_NAME(p.object_id) AS object_name ,
        p.partition_number ,
        p.data_compression_desc ,
        dbps.row_count ,
        dbps.reserved_page_count * 8 / 1024. AS reserved_mb ,
        si.index_id ,
        CASE WHEN si.index_id = 0 THEN '(heap!)'
                ELSE si.name
        END AS index_name ,
        si.is_unique ,
        si.data_space_id ,
        mappedto.name AS mapped_to_name ,
        mappedto.type_desc AS mapped_to_type_desc ,
        partitionds.name AS partition_filegroup ,
        pf.name AS pf_name ,
        pf.type_desc AS pf_type_desc ,
        pf.fanout AS pf_fanout ,
        pf.boundary_value_on_right ,
        ps.name AS partition_scheme_name ,
        rv.value AS range_value
FROM    sys.partitions p
JOIN    sys.objects so
        ON p.object_id = so.object_id
            AND so.is_ms_shipped = 0
LEFT JOIN sys.dm_db_partition_stats AS dbps
        ON p.object_id = dbps.object_id
            AND p.partition_id = dbps.partition_id
JOIN    sys.indexes si
        ON p.object_id = si.object_id
            AND p.index_id = si.index_id
LEFT JOIN sys.data_spaces mappedto
        ON si.data_space_id = mappedto.data_space_id
LEFT JOIN sys.destination_data_spaces dds
        ON si.data_space_id = dds.partition_scheme_id
            AND p.partition_number = dds.destination_id
LEFT JOIN sys.data_spaces partitionds
        ON dds.data_space_id = partitionds.data_space_id
LEFT JOIN sys.partition_schemes AS ps
        ON dds.partition_scheme_id = ps.data_space_id
LEFT JOIN sys.partition_functions AS pf
        ON ps.function_id = pf.function_id
LEFT JOIN sys.partition_range_values AS rv
        ON pf.function_id = rv.function_id
            AND dds.destination_id = CASE pf.boundary_value_on_right
                                        WHEN 0 THEN rv.boundary_id
                                        ELSE rv.boundary_id + 1
                                    END

GO
/****** Object:  View [dbo].[VehiclesVw]    Script Date: 7/27/2015 9:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE View [dbo].[VehiclesVw] 
AS 
select  c.CustomerID,c.CustomerName,v.BusNumber,v.Bus,v.BusOwner,v.VIN,V.VinID,c.FileGrp from Vehicles v 
inner join CustomerVehicles cv with(nolock) on  cv.vinID = v.vinid 
inner join Customers c with(nolock) on c.customerid = cv.customerid 
where v.IsActive = 1


GO
