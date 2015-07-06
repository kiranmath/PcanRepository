<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChartGenerator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ChartGenerator </p>
       
             <a href="GenerateTable_VinDashboard_Tabular.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=DailyBatteryData" class="btn btn-primary btn-large">DailyBatteryData  &raquo;</a></p>

         <p><a href="GenerateReport_Type01.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=GenVehicleData_SoCByPacks_Min" class="btn btn-primary btn-large">SoC Min By Packs &raquo;</a></p>
         <p><a href="GenerateReport_Type01.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=GenVehicleData_SoCByPacks_Max" class="btn btn-primary btn-large">SoC Max By Packs &raquo;</a></p>
         <p><a href="GenerateReport_Type01.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=GenVehicleData_TMaxByPacks" class="btn btn-primary btn-large">TMax By Packs &raquo;</a></p>

             <p><a href="GenerateReport_Type01.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=GenVehicleData_CurrentByPacks" class="btn btn-primary btn-large">Current By Packs &raquo;</a></p>

       TEST
         
        
        <p><a href="GenerateTable_VinDashboard_NREL.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=22&YearNumber=2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard NREL Weekly</a></p>
        
         <p><a href="GenerateTable_VinDashboard.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=22&YearNumber=2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard Weekly</a></p>
         <p><a href="GenerateChart_Type_Column.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=22&YearNumber=2015&ReportType=GenVehicleData_VinPECoolantTempHist" class="btn btn-primary btn-large">VinPECoolantTempHist</a></p>


         <p><a href="GenerateChart_Type_Column.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=22&YearNumber=2015&ReportType=GenVehicleData_VinSpeedHist" class="btn btn-primary btn-large">>GenVehicleData_VinSpeedHist</a></p>

        End TEST

          
        
              
                
          <a href="GenerateChart_Type_Column.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=22&YearNumber=2015&ReportType=GenVehicleData_VinChgEnergyHist" class="btn btn-primary btn-large">
              GenVehicleData_VinChgEnergyHist</a></p>
              NREL  &raquo;</a>
       

           <a href="GenerateChart_Type_Column.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=23&YearNumber=2015&ReportType=GenVehicleData_VinChgEnergyHist" class="btn btn-primary btn-large">GenVehicleData_VinChgEnergyHist NREL  &raquo;</a></p>
         
                <p><a href="GenerateReport_Type01.aspx?VinID=177&ProcessDate=6/2/2015&ReportType=GenVehicleData_SoC" class="btn btn-primary btn-large">GenVehicleData_SoC &raquo;</a></p>

                 <p><a href="GenerateCoverPage.aspx?VinID=194&ReportPeriod=NREL&WeekNumber=20&YearNumber=2015&ReportType="" class="btn btn-primary btn-large">Cover Weekly</a></p>
             
         <p><a href="GenerateTable_VinDashboard_NREL.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=23&YearNumber=2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard NREL Weekly</a></p>
                
         <p><a href="GenerateCoverPage.aspx?VinID=194&ReportPeriod=Weekly&WeekNumber=20&YearNumber=2015&ReportType=TempData" class="btn btn-primary btn-large">Cover Weekly</a></p>
     
         <p><a href="GenerateTable_VinDashboard.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=23&YearNumber=2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard Weekly</a></p>
        <p><a href="GenerateTable_VinDashboard.aspx?VinID=177&ReportPeriod=Daily&ProcessDate=06/02/2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard Daily</a></p>

         <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ReportPeriod=Daily&ProcessDate=05/11/2015&ReportType=GenVehicleData_VinTransTempHist" class="btn btn-primary btn-large">TransTemp Daily &raquo;</a>
            <a href="GenerateChart_Type_Column.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=20&YearNumber=2015&ReportType=GenVehicleData_VinTransTempHist" class="btn btn-primary btn-large">TransTemp Weekly  &raquo;</a></p>
                 DailyTempData


       <p> <a href="GenerateTable_VinDashboard_Tabular.aspx?VinID=177&ReportPeriod=Weekly&WeekNumber=23&YearNumber=2015&ReportType=DailyTempData" class="btn btn-primary btn-large">DailyTempData  &raquo;</a></p>
         
     
          <a href="GenerateTable_VinDashboard_Tabular.aspx?VinID=194&ReportPeriod=Weekly&WeekNumber=23&YearNumber=2015&ReportType=DailyChargingData" class="btn btn-primary btn-large">DailyChargingData  &raquo;</a></p>
         
     


          <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ReportPeriod=Daily&ProcessDate=05/11/2015&ReportType=GenVehicleData_VinMinAirPressureHist" class="btn btn-primary btn-large">VinMinAirPressureHistWeekly Daily &raquo;</a>
            <a href="GenerateChart_Type_Column.aspx?VinID=194&ReportPeriod=Weekly&WeekNumber=20&YearNumber=2015&ReportType=GenVehicleData_VinMinAirPressureHist" class="btn btn-primary btn-large">VinMinAirPressureHistWeekly Weekly  &raquo;</a></p>
         

         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinMinAirPressureHistWeekly" class="btn btn-primary btn-large">MinAirPressure Weekly &raquo;</a></p>
        

          <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinBatteryCoolantPumpHistWeekly" class="btn btn-primary btn-large">BatteryCoolantPump Weekly&raquo;</a></p>
       

        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinRadiatorFanSpeedHistWeekly" class="btn btn-primary btn-large">RadiatorFanSpeed Weekly&raquo;</a></p>


        
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorIGBTTempHistWeekly" class="btn btn-primary btn-large">TractionMotorIGBTTemp Weekly &raquo;</a></p>


        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorInverterTempHistWeekly" class="btn btn-primary btn-large">VinTractionMotorInverterTemp Weekly &raquo;</a></p>
        
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinStatorTempHistWeekly" class="btn btn-primary btn-large">StatorTemp Weekly &raquo;</a></p>

        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorRotorTempHistWeekly" class="btn btn-primary btn-large">TractionMotorRotorTemp  Weekly&raquo;</a></p>
                
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinDCDCConverterPowerHistWeekly" class="btn btn-primary btn-large">DCDCConverterPower Weekly&raquo;</a></p>
     
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinBatteryTempMaxHistWeekly" class="btn btn-primary btn-large">BatteryTempMaxWeekly &raquo;</a></p>
        
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinSocMinHistWeekly" class="btn btn-primary btn-large">VinSocMinHistWeekly &raquo;</a></p>
        
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/13/2015&ReportType=GenVehicleData_VinVoltageHistWeekly" class="btn btn-primary btn-large">VoltageHistWeekly &raquo;</a></p>
                
        <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ProcessDate=05/1/2015&ReportType=GenVehicleData_VinChargingHistWeekly" class="btn btn-primary btn-large">ChargingWeekly &raquo;</a></p>

        <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ProcessDate=05/1/2015&ReportType=GenVehicleData_VinBrakePedalHistWeekly" class="btn btn-primary btn-large"> VinBreakPedalHistWeekly </a></p>
        
         <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ProcessDate=05/1/2015&ReportType=GenVehicleData_VinAccelPedalHistWeekly" class="btn btn-primary btn-large"> VinAccelPedalHistWeekly </a></p>
        
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinEfficiencyHistWeekly" class="btn btn-primary btn-large">VinEfficiencyHistWeekly &raquo;</a></p>
                     
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinSpeedHistWeekly" class="btn btn-primary btn-large">VinSpeedHistWeekly &raquo;</a></p>

         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinPECoolantTempHistWeekly" class="btn btn-primary btn-large">PECoolantTemp Weekly &raquo;</a></p>

         
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTransTempHist" class="btn btn-primary btn-large">TransTemp &raquo;</a></p>
         
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinMinAirPressureHist" class="btn btn-primary btn-large">MinAirPressure &raquo;</a></p>
          
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinBatteryCoolantPumpHist" class="btn btn-primary btn-large">BatteryCoolantPump &raquo;</a></p>
        
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinRadiatorFanSpeedHist" class="btn btn-primary btn-large">RadiatorFanSpeed &raquo;</a></p>

         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorInverterTempHist" class="btn btn-primary btn-large">VinTractionMotorInverterTempHist &raquo;</a></p>
                
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorRotorTempHist" class="btn btn-primary btn-large">TractionMotorRotorTemp &raquo;</a></p>

        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinTractionMotorIGBTTempHist" class="btn btn-primary btn-large">TractionMotorIGBTTemp &raquo;</a></p>

        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/13/2015&ReportType=GenVehicleData_VinSpeedHist" class="btn btn-primary btn-large">>GenVehicleData_VinSpeedHist</a></p>
        
        <p><a href="GenerateChart_Type_Column.aspx?VinID=194&ProcessDate=05/1/2015&ReportType=GenVehicleData_VinChargingHist" class="btn btn-primary btn-large">Charging &raquo;</a></p>
        
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/13/2015&ReportType=GenVehicleData_VinBrakePedalHist" class="btn btn-primary btn-large">GenVehicleData_VinBrakePedalHist &raquo;</a></p>
                
         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/13/2015&ReportType=GenVehicleData_VinVoltageHist" class="btn btn-primary btn-large">GenVehicleData_VoltageHist &raquo;</a></p>
                
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinSocMinHist" class="btn btn-primary btn-large">GenVehicleData_SocMinHist &raquo;</a></p>
                  
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinBatteryTempMaxHist" class="btn btn-primary btn-large">BatteryTempMax &raquo;</a></p>

         <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinDCDCConverterPowerHist" class="btn btn-primary btn-large">DCDCConverterPower &raquo;</a></p>
     
        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinStatorTempHist" class="btn btn-primary btn-large">StatorTemp &raquo;</a></p>

        <p><a href="GenerateChart_Type_Column.aspx?VinID=181&ProcessDate=05/4/2015&ReportType=GenVehicleData_VinPECoolantTempHist" class="btn btn-primary btn-large">PECoolantTemp &raquo;</a></p>

        <p><a href="GenerateReport_Type01.aspx?VinID=195&ProcessDate=05/13/2015&ReportType=GenVehicleData_SoC" class="btn btn-primary btn-large">GenVehicleData_SoC &raquo;</a></p>
        
        <p><a href="GenerateTable_VinDashboard.aspx?VinID=194&ProcessDate=5/10/2015&ReportType=TempData" class="btn btn-primary btn-large">Dashboard</a></p>
    </div>

    

</asp:Content>
