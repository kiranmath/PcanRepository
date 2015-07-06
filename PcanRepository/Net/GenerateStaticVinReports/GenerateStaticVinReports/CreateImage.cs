using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System.Drawing.Imaging;
using OpenQA.Selenium.IE;
using System.IO;

namespace GenerateStaticVinReports
{
    public class CreateImages
    {

        private IWebDriver _driver;


        public void SetUp()
        {
            _driver = new PhantomJSDriver();
        }




       private void getImageNREL(string VinID, string ProcessDate,string WebAddress, string ImageFolder, string ReportPeriod, string WeekNumber, string YearNumber)
        {
            string WebParam;
            Uri WebUrl;
            string ImagePath;
            Uri websiteName = new Uri(WebAddress);
 
           
            WebParam = string.Format("GenerateTable_VinDashboard_NREL.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=DailyChargingData&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinDashBoard.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinSpeedHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinSpeedHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinEfficiencyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinEfficiencyHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinAccelPedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinAccelPedalHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBrakePedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinBrakePedalHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChargingHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinChargingHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinDCDCConverterPowerHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinDCDCConverterPowerHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


            WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinPECoolantTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinPECoolantTempHist.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

        }


       private void getImageDailyBattery(string VinID, string ProcessDate, string WebAddress, string ImageFolder, string ReportPeriod, string WeekNumber, string YearNumber)
       {
           string WebParam;
           Uri WebUrl;
           string ImagePath;
           Uri websiteName = new Uri(WebAddress);

           WebParam = string.Format("GenerateTable_VinDashboard_Tabular.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=DailyBatteryData&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinDashBoard.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_SoCByPacks_Min&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "SoCByPacks_Min.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_SoCByPacks_Max&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "SoCByPacks_Max.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_TMaxByPacks&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "TMaxByPacks.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_CurrentByPacks&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "CurrentByPacks.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

           
       }


       private void getImageWeekly(string VinID, string ProcessDate, string WebAddress, string ImageFolder, string ReportPeriod, string WeekNumber, string YearNumber)
       {

           string WebParam;
           Uri WebUrl;
           string ImagePath;
           Uri websiteName = new Uri(WebAddress);

           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChgEnergyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinChgEnergyHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateTable_VinDashboard.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=TempData&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinDashBoard.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinSpeedHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinSpeedHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinEfficiencyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinEfficiencyHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinAccelPedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinAccelPedalHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBrakePedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBrakePedalHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChargingHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinChargingHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinDCDCConverterPowerHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinDCDCConverterPowerHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinPECoolantTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinPECoolantTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChgEnergyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinChgEnergyHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinVoltageHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinVoltageHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryTempMaxHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryTempMaxHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinPECoolantTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinPECoolantTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinStatorTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinStatorTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorRotorTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorRotorTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorInverterTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorInverterTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorIGBTTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorIGBTTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinRadiatorFanSpeedHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinRadiatorFanSpeedHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryCoolantPumpHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryCoolantPumpHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinMinAirPressureHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinMinAirPressureHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTransTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTransTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryTempMaxHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryTempMaxHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

       }

       private void getImageDaily(string VinID, string ProcessDate, string WebAddress, string ImageFolder, string ReportPeriod, string WeekNumber, string YearNumber)
       {

           string WebParam;
           Uri WebUrl;
           string ImagePath;
           Uri websiteName = new Uri(WebAddress);

           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChgEnergyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinChgEnergyHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateTable_VinDashboard.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=TempData&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinDashBoard.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinSpeedHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinSpeedHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinEfficiencyHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinEfficiencyHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinAccelPedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinAccelPedalHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBrakePedalHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBrakePedalHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinChargingHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinChargingHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinDCDCConverterPowerHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinDCDCConverterPowerHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinPECoolantTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinPECoolantTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);






           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinVoltageHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinVoltageHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryTempMaxHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryTempMaxHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinPECoolantTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinPECoolantTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinStatorTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinStatorTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorRotorTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorRotorTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorInverterTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorInverterTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTractionMotorIGBTTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTractionMotorIGBTTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinRadiatorFanSpeedHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinRadiatorFanSpeedHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryCoolantPumpHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryCoolantPumpHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinMinAirPressureHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinMinAirPressureHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinTransTempHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "VinTransTempHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);





           WebParam = string.Format("GenerateChart_Type_Column.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinBatteryTempMaxHist&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           ImagePath = Path.Combine(ImageFolder, "VinBatteryTempMaxHist.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);




           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_SoC&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "GenVehicleData_SoC.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_VinSpeed&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "GenVehicleData_VinSpeed.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);



           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_SoCEnergy&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "GenVehicleData_SoCEnergy.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


           WebParam = string.Format("GenerateReport_Type01.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=GenVehicleData_CurrentVoltage&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
           WebUrl = new Uri(websiteName, WebParam);
           ImagePath = Path.Combine(ImageFolder, "GenVehicleData_CurrentVoltage.png");
           _driver.Navigate().GoToUrl(WebUrl);
           _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
           ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);


     

       }

        public void getImage(string VinID, string ProcessDate,string WebAddress, string ImageFolder, string ReportPeriod, string WeekNumber, string YearNumber)
        {

            string WebParam;
            Uri WebUrl;
            string ImagePath;
            Uri websiteName = new Uri(WebAddress);



            WebParam = string.Format("GenerateCoverPage.aspx?VinID={0}&ProcessDate={1}&ReportPeriod={2}&ReportType=CoverPage&WeekNumber={3}&YearNumber={4}", VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            WebUrl = new Uri(websiteName, WebParam);
            ImagePath = Path.Combine(ImageFolder, "VinCoverPage.png");
            _driver.Navigate().GoToUrl(WebUrl);
            _driver.WaitUntil(d => d.FindElement(By.Id("footer")).Equals(true));
            ((ITakesScreenshot)_driver).GetScreenshot().SaveAsFile(@ImagePath, ImageFormat.Png);

            switch (ReportPeriod)
            {
                case "Daily":
                    getImageDaily(VinID, ProcessDate, WebAddress, ImageFolder, ReportPeriod, WeekNumber, YearNumber);
                    break;
                case "Weekly":
                    getImageWeekly(VinID, ProcessDate, WebAddress, ImageFolder, ReportPeriod, WeekNumber, YearNumber);
                    break;
                case "NREL":
                    getImageNREL(VinID, ProcessDate, WebAddress, ImageFolder, ReportPeriod, WeekNumber, YearNumber);
                      break;
                case "DailyBattery":
                     getImageDailyBattery(VinID, ProcessDate, WebAddress, ImageFolder, ReportPeriod, WeekNumber, YearNumber);
                      break;
                default:
                   
                    break;
            }
           

    

        }




        public void TearDown()
        {

            _driver.Close();
            _driver.Quit();
           
        }

    }
}
