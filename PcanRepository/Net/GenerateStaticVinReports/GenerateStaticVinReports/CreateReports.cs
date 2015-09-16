using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;
using System.Data;


namespace GenerateStaticVinReports
{
    class CreateReports
    {

        private Document _doc;
        private FileStream _fs;
        private PdfWriter _writer;


        public void SetUp(string ReportFileName, string Vin, string ProcessDate, string ReportPeriod, string WeekNumber, string YearNumber)
        {
             _fs = new FileStream(@ReportFileName, FileMode.Create, FileAccess.Write, FileShare.Delete);
             _doc = new Document(); //new Document(PageSize.LETTER.Rotate())
             _writer = PdfWriter.GetInstance(_doc, _fs);
            // calling PDFFooter class to Include in document
            // _writer.PageEvent = new PDFFooter();
             _writer.PageEvent = new ITextEvents { Vin = Vin, ProcessDate = ProcessDate, ReportPeriod = ReportPeriod, WeekNumber = WeekNumber, YearNumber = YearNumber };
             
        }


        private void GenPdfDaily(string TempFolderPath, string ImageFileName, string ReportPeriod)
        {

            
            //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);

           
            _doc.Open();

            //string imageURL_VinSplash = @ImageFileName;

            string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
            iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            //Resize image depend upon your need
            jpg_VinSplash.ScalePercent(65f);

            //Give space before image
            jpg_VinSplash.SpacingBefore = 10f;

            //Give some space after the image
            jpg_VinSplash.SpacingAfter = 1f;
            jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinSplash);


            _doc.NewPage();

       

                                                                   
            string imageURL_VinDash = Path.Combine(TempFolderPath,"VinDashBoard.png");
            iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
            jpg_VinDash.ScalePercent(75f);

            //Give space before image
            jpg_VinDash.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDash.SpacingAfter = 1f;
            jpg_VinDash.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDash);


            _doc.NewPage();
            string imageURL_VinHist = Path.Combine(TempFolderPath, "VinSpeedHist.png");
       
            iTextSharp.text.Image jpg_VinHist = iTextSharp.text.Image.GetInstance(imageURL_VinHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinHist.ScalePercent(85f);

            //Give space before image
            jpg_VinHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinHist.SpacingAfter = 1f;
            jpg_VinHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinHist);
            
            string imageURL_VinEffHist = Path.Combine(TempFolderPath, "VinEfficiencyHist.png");
   
            iTextSharp.text.Image jpg_VinEffHist = iTextSharp.text.Image.GetInstance(imageURL_VinEffHist);
            jpg_VinEffHist.ScalePercent(85f);

            //Give space before image
            jpg_VinEffHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinEffHist.SpacingAfter = 1f;
            jpg_VinEffHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinEffHist);


            string imageURL_VinAccelPedalHist = Path.Combine(TempFolderPath, "VinAccelPedalHist.png");
         
            iTextSharp.text.Image jpg_VinAccelPedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinAccelPedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinAccelPedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinAccelPedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinAccelPedalHist.SpacingAfter = 1f;
            jpg_VinAccelPedalHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinAccelPedalHist);


            string imageURL_VinBrakePedalHist = Path.Combine(TempFolderPath, "VinBrakePedalHist.png");
      
            iTextSharp.text.Image jpg_VinBrakePedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinBrakePedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBrakePedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBrakePedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBrakePedalHist.SpacingAfter = 1f;
            jpg_VinBrakePedalHist.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinBrakePedalHist);
            
            string imageURL_VinChargingHist = Path.Combine(TempFolderPath, "VinChargingHist.png");

            iTextSharp.text.Image jpg_VinChargingHist = iTextSharp.text.Image.GetInstance(imageURL_VinChargingHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinChargingHist.ScalePercent(85f);

            //Give space before image
            jpg_VinChargingHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinChargingHist.SpacingAfter = 1f;
            jpg_VinChargingHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinChargingHist);


            string imageURL_VinDCDCConverterPowerHist = Path.Combine(TempFolderPath, "VinDCDCConverterPowerHist.png");

            iTextSharp.text.Image jpg_VinDCDCConverterPowerHist = iTextSharp.text.Image.GetInstance(imageURL_VinDCDCConverterPowerHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDCDCConverterPowerHist.ScalePercent(85f);

            //Give space before image
            jpg_VinDCDCConverterPowerHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDCDCConverterPowerHist.SpacingAfter = 1f;
            jpg_VinDCDCConverterPowerHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDCDCConverterPowerHist);



            string imageURL_VinPECoolantTempHist = Path.Combine(TempFolderPath, "VinPECoolantTempHist.png");

            iTextSharp.text.Image jpg_VinPECoolantTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinPECoolantTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinPECoolantTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinPECoolantTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinPECoolantTempHist.SpacingAfter = 1f;
            jpg_VinPECoolantTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinPECoolantTempHist);



            //VinVoltageHist.png




            string imageURL_VinVoltageHist = Path.Combine(TempFolderPath, "VinVoltageHist.png");

            iTextSharp.text.Image jpg_imageURL_VinVoltageHist = iTextSharp.text.Image.GetInstance(imageURL_VinVoltageHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_imageURL_VinVoltageHist.ScalePercent(85f);

            //Give space before image
            jpg_imageURL_VinVoltageHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_imageURL_VinVoltageHist.SpacingAfter = 1f;
            jpg_imageURL_VinVoltageHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_imageURL_VinVoltageHist);


          


            string imageURL_VinStatorTempHist = Path.Combine(TempFolderPath, "VinStatorTempHist.png");

            iTextSharp.text.Image jpg_VinStatorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinStatorTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinStatorTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinStatorTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinStatorTempHist.SpacingAfter = 1f;
            jpg_VinStatorTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinStatorTempHist);




            string imageURL_VinTractionMotorRotorTempHist = Path.Combine(TempFolderPath, "VinTractionMotorRotorTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorRotorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorRotorTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorRotorTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorRotorTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorRotorTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorRotorTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorRotorTempHist);



            string imageURL_VinTractionMotorInverterTempHist = Path.Combine(TempFolderPath, "VinTractionMotorInverterTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorInverterTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorInverterTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorInverterTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorInverterTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorInverterTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorInverterTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorInverterTempHist);


            string imageURL_VinTractionMotorIGBTTempHist = Path.Combine(TempFolderPath, "VinTractionMotorIGBTTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorIGBTTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorIGBTTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorIGBTTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorIGBTTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorIGBTTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorIGBTTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorIGBTTempHist);



            string imageURL_VinRadiatorFanSpeedHist = Path.Combine(TempFolderPath, "VinRadiatorFanSpeedHist.png");

            iTextSharp.text.Image jpg_VinRadiatorFanSpeedHist = iTextSharp.text.Image.GetInstance(imageURL_VinRadiatorFanSpeedHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinRadiatorFanSpeedHist.ScalePercent(85f);

            //Give space before image
            jpg_VinRadiatorFanSpeedHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinRadiatorFanSpeedHist.SpacingAfter = 1f;
            jpg_VinRadiatorFanSpeedHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinRadiatorFanSpeedHist);

            string imageURL_VinBatteryCoolantPumpHist = Path.Combine(TempFolderPath, "VinBatteryCoolantPumpHist.png");

            iTextSharp.text.Image jpg_VinBatteryCoolantPumpHist = iTextSharp.text.Image.GetInstance(imageURL_VinBatteryCoolantPumpHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBatteryCoolantPumpHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBatteryCoolantPumpHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBatteryCoolantPumpHist.SpacingAfter = 1f;
            jpg_VinBatteryCoolantPumpHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinBatteryCoolantPumpHist);

            string imageURL_VinMinAirPressureHist = Path.Combine(TempFolderPath, "VinMinAirPressureHist.png");

            iTextSharp.text.Image jpg_VinMinAirPressureHist = iTextSharp.text.Image.GetInstance(imageURL_VinMinAirPressureHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinMinAirPressureHist.ScalePercent(85f);

            //Give space before image
            jpg_VinMinAirPressureHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinMinAirPressureHist.SpacingAfter = 1f;
            jpg_VinMinAirPressureHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinMinAirPressureHist);





            string imageURL_VinTransTempHist = Path.Combine(TempFolderPath, "VinTransTempHist.png");

            iTextSharp.text.Image jpg_VinTransTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTransTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTransTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTransTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTransTempHist.SpacingAfter = 1f;
            jpg_VinTransTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTransTempHist);


            string imageURL_GenVehicleData_SoC = Path.Combine(TempFolderPath, "GenVehicleData_SoC.png");

            iTextSharp.text.Image jpg_Soc = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_SoC);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            //jpg.ScaleToFit(600f, 250f);
            //Give space before image
            jpg_Soc.ScalePercent(60f);
            jpg_Soc.SpacingBefore = 10f;
            //Give some space after the image
            jpg_Soc.SpacingAfter = 1f;
            jpg_Soc.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_Soc);


            string imageURL_GenVehicleData_VinSpeed = Path.Combine(TempFolderPath, "GenVehicleData_VinSpeed.png");
           // imageURL_GenVehicleData_VinSpeed = @"C:\TestScreen\temp\GenVehicleData_VinSpeed.png";
            iTextSharp.text.Image jpg_Spd = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_VinSpeed);
            //Resize image depend upon your need
            // jpgSpd.ScaleToFit(600f, 250f);
            //Give space before image

            jpg_Spd.ScalePercent(60f);
            jpg_Spd.SpacingBefore = 10f;
            //Give some space after the image
            jpg_Spd.SpacingAfter = 1f;
            jpg_Spd.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_Spd);


            string imageURL_GenVehicleData_SoCEnergy = Path.Combine(TempFolderPath, "GenVehicleData_SoCEnergy.png");

            iTextSharp.text.Image jpgSocEnergy = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_SoCEnergy);
            //Resize image depend upon your need
            //jpgSocEnergy.ScaleToFit(600f, 250f);
            //Give space before image

            jpgSocEnergy.ScalePercent(60f);
            jpgSocEnergy.SpacingBefore = 10f;
            //Give some space after the image
            jpgSocEnergy.SpacingAfter = 1f;
            jpgSocEnergy.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpgSocEnergy);
            
            string imageURL_GenVehicleData_CurrentVoltage = Path.Combine(TempFolderPath, "GenVehicleData_CurrentVoltage.png");
          //  imageURL = @"C:\TestScreen\temp\GenVehicleData_CurrentVoltage.png";
            iTextSharp.text.Image jpgVA = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_CurrentVoltage);
            //Resize image depend upon your need
            //jpgVA.ScaleToFit(600f, 250f);
            //Give space before image

            jpgVA.ScalePercent(60f);
            jpgVA.SpacingBefore = 10f;
            //Give some space after the image
            jpgVA.SpacingAfter = 1f;
            jpgVA.Alignment = Element.ALIGN_CENTER;
            
            _doc.Add(jpgVA);

            PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

            //    //set the open action for our writer object
            _writer.SetOpenAction(action);


        }


        private void GenPdfWeekly(string TempFolderPath, string ImageFileName, string ReportPeriod)
        {

            //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);


            _doc.Open();

            //string imageURL_VinSplash = @ImageFileName;
            //iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
            iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            //Resize image depend upon your need
            jpg_VinSplash.ScalePercent(65f);

            //Give space before image
            jpg_VinSplash.SpacingBefore = 10f;

            //Give some space after the image
            jpg_VinSplash.SpacingAfter = 1f;
            jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinSplash);
            _doc.NewPage();

            string imageURL_VinDash = Path.Combine(TempFolderPath, "VinDashboard.png");
            iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDash.ScalePercent(75f);

            //Give space before image
            jpg_VinDash.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDash.SpacingAfter = 1f;
            jpg_VinDash.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDash);
            _doc.NewPage();

            string imageURL_VinHist = Path.Combine(TempFolderPath, "VinSpeedHist.png");

            iTextSharp.text.Image jpg_VinHist = iTextSharp.text.Image.GetInstance(imageURL_VinHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinHist.ScalePercent(85f);

            //Give space before image
            jpg_VinHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinHist.SpacingAfter = 1f;
            jpg_VinHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinHist);
            string imageURL_VinEffHist = Path.Combine(TempFolderPath, "VinEfficiencyHist.png");

            iTextSharp.text.Image jpg_VinEffHist = iTextSharp.text.Image.GetInstance(imageURL_VinEffHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinEffHist.ScalePercent(85f);

            //Give space before image
            jpg_VinEffHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinEffHist.SpacingAfter = 1f;
            jpg_VinEffHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinEffHist);


            string imageURL_VinAccelPedalHist = Path.Combine(TempFolderPath, "VinAccelPedalHist.png");

            iTextSharp.text.Image jpg_VinAccelPedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinAccelPedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinAccelPedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinAccelPedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinAccelPedalHist.SpacingAfter = 1f;
            jpg_VinAccelPedalHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinAccelPedalHist);


            string imageURL_VinBrakePedalHist = Path.Combine(TempFolderPath, "VinBrakePedalHist.png");

            iTextSharp.text.Image jpg_VinBrakePedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinBrakePedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBrakePedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBrakePedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBrakePedalHist.SpacingAfter = 1f;
            jpg_VinBrakePedalHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinBrakePedalHist);

            string imageURL_VinChargingHist = Path.Combine(TempFolderPath, "VinChargingHist.png");

            iTextSharp.text.Image jpg_VinChargingHist = iTextSharp.text.Image.GetInstance(imageURL_VinChargingHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinChargingHist.ScalePercent(85f);

            //Give space before image
            jpg_VinChargingHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinChargingHist.SpacingAfter = 1f;
            jpg_VinChargingHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinChargingHist);

            string imageURL_VinDCDCConverterPowerHist = Path.Combine(TempFolderPath, "VinDCDCConverterPowerHist.png");

            iTextSharp.text.Image jpg_VinDCDCConverterPowerHist = iTextSharp.text.Image.GetInstance(imageURL_VinDCDCConverterPowerHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDCDCConverterPowerHist.ScalePercent(85f);

            //Give space before image
            jpg_VinDCDCConverterPowerHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDCDCConverterPowerHist.SpacingAfter = 1f;
            jpg_VinDCDCConverterPowerHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDCDCConverterPowerHist);



            string imageURL_VinPECoolantTempHist = Path.Combine(TempFolderPath, "VinPECoolantTempHist.png");

            iTextSharp.text.Image jpg_VinPECoolantTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinPECoolantTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinPECoolantTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinPECoolantTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinPECoolantTempHist.SpacingAfter = 1f;
            jpg_VinPECoolantTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinPECoolantTempHist);




            string imageURL_VinChgEnergyHist = Path.Combine(TempFolderPath, "VinChgEnergyHist.png");
            iTextSharp.text.Image jpg_VinChgEnergyHist = iTextSharp.text.Image.GetInstance(imageURL_VinChgEnergyHist);
            jpg_VinChgEnergyHist.ScalePercent(85f);

            //Give space before image
            jpg_VinChgEnergyHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinChgEnergyHist.SpacingAfter = 1f;
            jpg_VinChgEnergyHist.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinChgEnergyHist);




            string imageURL_VinVoltageHist = Path.Combine(TempFolderPath, "VinVoltageHist.png");

            iTextSharp.text.Image jpg_VinVoltageHist = iTextSharp.text.Image.GetInstance(imageURL_VinVoltageHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinVoltageHist.ScalePercent(85f);

            //Give space before image
            jpg_VinVoltageHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinVoltageHist.SpacingAfter = 1f;
            jpg_VinVoltageHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinVoltageHist);


            string imageURL_VinBatteryTempMaxHist = Path.Combine(TempFolderPath, "VinBatteryTempMaxHist.png");

            iTextSharp.text.Image jpg_VinBatteryTempMaxHist = iTextSharp.text.Image.GetInstance(imageURL_VinBatteryTempMaxHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBatteryTempMaxHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBatteryTempMaxHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBatteryTempMaxHist.SpacingAfter = 1f;
            jpg_VinBatteryTempMaxHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinBatteryTempMaxHist);

            string imageURL_VinStatorTempHist = Path.Combine(TempFolderPath, "VinStatorTempHist.png");

            iTextSharp.text.Image jpg_VinStatorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinStatorTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinStatorTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinStatorTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinStatorTempHist.SpacingAfter = 1f;
            jpg_VinStatorTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinStatorTempHist);



            string imageURL_VinTractionMotorRotorTempHist = Path.Combine(TempFolderPath, "VinTractionMotorRotorTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorRotorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorRotorTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorRotorTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorRotorTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorRotorTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorRotorTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorRotorTempHist);



            string imageURL_VinTractionMotorInverterTempHist = Path.Combine(TempFolderPath, "VinTractionMotorInverterTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorInverterTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorInverterTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorInverterTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorInverterTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorInverterTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorInverterTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorInverterTempHist);


            string imageURL_VinTractionMotorIGBTTempHist = Path.Combine(TempFolderPath, "VinTractionMotorIGBTTempHist.png");

            iTextSharp.text.Image jpg_VinTractionMotorIGBTTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorIGBTTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTractionMotorIGBTTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTractionMotorIGBTTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTractionMotorIGBTTempHist.SpacingAfter = 1f;
            jpg_VinTractionMotorIGBTTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTractionMotorIGBTTempHist);



            string imageURL_VinRadiatorFanSpeedHist = Path.Combine(TempFolderPath, "VinRadiatorFanSpeedHist.png");

            iTextSharp.text.Image jpg_VinRadiatorFanSpeedHist = iTextSharp.text.Image.GetInstance(imageURL_VinRadiatorFanSpeedHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinRadiatorFanSpeedHist.ScalePercent(85f);

            //Give space before image
            jpg_VinRadiatorFanSpeedHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinRadiatorFanSpeedHist.SpacingAfter = 1f;
            jpg_VinRadiatorFanSpeedHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinRadiatorFanSpeedHist);

            string imageURL_VinBatteryCoolantPumpHist = Path.Combine(TempFolderPath, "VinBatteryCoolantPumpHist.png");

            iTextSharp.text.Image jpg_VinBatteryCoolantPumpHist = iTextSharp.text.Image.GetInstance(imageURL_VinBatteryCoolantPumpHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBatteryCoolantPumpHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBatteryCoolantPumpHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBatteryCoolantPumpHist.SpacingAfter = 1f;
            jpg_VinBatteryCoolantPumpHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinBatteryCoolantPumpHist);

            string imageURL_VinMinAirPressureHist = Path.Combine(TempFolderPath, "VinMinAirPressureHist.png");

            iTextSharp.text.Image jpg_VinMinAirPressureHist = iTextSharp.text.Image.GetInstance(imageURL_VinMinAirPressureHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinMinAirPressureHist.ScalePercent(85f);

            //Give space before image
            jpg_VinMinAirPressureHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinMinAirPressureHist.SpacingAfter = 1f;
            jpg_VinMinAirPressureHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinMinAirPressureHist);

            string imageURL_VinTransTempHist = Path.Combine(TempFolderPath, "VinTransTempHist.png");

            iTextSharp.text.Image jpg_VinTransTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTransTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinTransTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinTransTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinTransTempHist.SpacingAfter = 1f;
            jpg_VinTransTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinTransTempHist);


            PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

            //    //set the open action for our writer object
            _writer.SetOpenAction(action);


        }

        private void GenPdfNREL(string TempFolderPath, string ImageFileName, string ReportPeriod)
        {

            //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);


            _doc.Open();

            //string imageURL_VinSplash = @ImageFileName;
            //iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
            iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            //Resize image depend upon your need
            jpg_VinSplash.ScalePercent(65f);

            //Give space before image
            jpg_VinSplash.SpacingBefore = 10f;

            //Give some space after the image
            jpg_VinSplash.SpacingAfter = 1f;
            jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinSplash);


            _doc.NewPage();


            string imageURL_VinDash = Path.Combine(TempFolderPath, "VinDashboard.png");
            iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDash.ScalePercent(75f);

            //Give space before image
            jpg_VinDash.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDash.SpacingAfter = 1f;
            jpg_VinDash.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDash);
            _doc.NewPage();

            string imageURL_VinHist = Path.Combine(TempFolderPath, "VinSpeedHist.png");

            iTextSharp.text.Image jpg_VinHist = iTextSharp.text.Image.GetInstance(imageURL_VinHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinHist.ScalePercent(85f);

            //Give space before image
            jpg_VinHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinHist.SpacingAfter = 1f;
            jpg_VinHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinHist);
            string imageURL_VinEffHist = Path.Combine(TempFolderPath, "VinEfficiencyHist.png");

            iTextSharp.text.Image jpg_VinEffHist = iTextSharp.text.Image.GetInstance(imageURL_VinEffHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinEffHist.ScalePercent(85f);

            //Give space before image
            jpg_VinEffHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinEffHist.SpacingAfter = 1f;
            jpg_VinEffHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinEffHist);


            string imageURL_VinAccelPedalHist = Path.Combine(TempFolderPath, "VinAccelPedalHist.png");

            iTextSharp.text.Image jpg_VinAccelPedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinAccelPedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinAccelPedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinAccelPedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinAccelPedalHist.SpacingAfter = 1f;
            jpg_VinAccelPedalHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinAccelPedalHist);


            string imageURL_VinBrakePedalHist = Path.Combine(TempFolderPath, "VinBrakePedalHist.png");

            iTextSharp.text.Image jpg_VinBrakePedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinBrakePedalHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinBrakePedalHist.ScalePercent(85f);

            //Give space before image
            jpg_VinBrakePedalHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinBrakePedalHist.SpacingAfter = 1f;
            jpg_VinBrakePedalHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinBrakePedalHist);

            string imageURL_VinChargingHist = Path.Combine(TempFolderPath, "VinChargingHist.png");

            iTextSharp.text.Image jpg_VinChargingHist = iTextSharp.text.Image.GetInstance(imageURL_VinChargingHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinChargingHist.ScalePercent(85f);

            //Give space before image
            jpg_VinChargingHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinChargingHist.SpacingAfter = 1f;
            jpg_VinChargingHist.Alignment = Element.ALIGN_CENTER;


            _doc.Add(jpg_VinChargingHist);

            string imageURL_VinDCDCConverterPowerHist = Path.Combine(TempFolderPath, "VinDCDCConverterPowerHist.png");

            iTextSharp.text.Image jpg_VinDCDCConverterPowerHist = iTextSharp.text.Image.GetInstance(imageURL_VinDCDCConverterPowerHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDCDCConverterPowerHist.ScalePercent(85f);

            //Give space before image
            jpg_VinDCDCConverterPowerHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDCDCConverterPowerHist.SpacingAfter = 1f;
            jpg_VinDCDCConverterPowerHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDCDCConverterPowerHist);



            string imageURL_VinPECoolantTempHist = Path.Combine(TempFolderPath, "VinPECoolantTempHist.png");

            iTextSharp.text.Image jpg_VinPECoolantTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinPECoolantTempHist);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinPECoolantTempHist.ScalePercent(85f);

            //Give space before image
            jpg_VinPECoolantTempHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinPECoolantTempHist.SpacingAfter = 1f;
            jpg_VinPECoolantTempHist.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinPECoolantTempHist);





            string imageURL_VinChgEnergyHist = Path.Combine(TempFolderPath, "VinChgEnergyHist.png");
                                                                             
            iTextSharp.text.Image jpg_VinChgEnergyHist = iTextSharp.text.Image.GetInstance(imageURL_VinChgEnergyHist);
            jpg_VinChgEnergyHist.ScalePercent(85f);

            //Give space before image
            jpg_VinChgEnergyHist.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinChgEnergyHist.SpacingAfter = 1f;
            jpg_VinChgEnergyHist.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinChgEnergyHist);

            PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

            //    //set the open action for our writer object
            _writer.SetOpenAction(action);


          

        }



        public void GenPdfDailyBatteryAllCust(string TempFolderPath, string ImageFileName, string ReportPeriod, string ProcessDate)
        {

            //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);
            _doc.Open();


            string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
            iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            //Resize image depend upon your need
            jpg_VinSplash.ScalePercent(65f);

            //Give space before image
            jpg_VinSplash.SpacingBefore = 10f;

            //Give some space after the image
            jpg_VinSplash.SpacingAfter = 1f;
            jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinSplash);


            PdfPTable table = GenerateBatteryAllCustDashboard(ProcessDate);

            _doc.Add(table);

            GenerateBatteryChartByCustVin(TempFolderPath, ProcessDate);

            PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

            //    //set the open action for our writer object
            _writer.SetOpenAction(action);
        }

        private void GenerateBatteryChartByCustVin(string TempFolderPath, string ProcessDate)
        {
            Paragraph para = new Paragraph();
            Section sec = new Section();
            string CustomerId = string.Empty;
            string CustomerName = string.Empty;
            string Vin = string.Empty;
            int VinId = 0;
            string Bus = string.Empty;

            DataTable dtCust = new DataTable();
            DataTable dtVin = new DataTable();
            GetData gd = new GetData();
            dtCust = gd.DtGetCustomerInfo(DateTime.Parse(ProcessDate));

            int i = 0;
            int j = 0;
            foreach (DataRow dRow in dtCust.Rows)
            {

                i++;
                j = 0;
                CustomerId = dRow["CustomerId"].ToString();
                CustomerName = dRow["CustomerName"].ToString();

                dtVin = gd.DtGetCustomerVehicleInfo(int.Parse(CustomerId), DateTime.Parse(ProcessDate));
              
             
                _doc.NewPage();

                //para = new Paragraph(CustomerName);
                //Chapter chap = new Chapter(para, i);
                //Section section1 = chap.AddSection(20f, "Section 1.1", 1);       
                //_doc.Add(chap);
              

                foreach (DataRow vRow in dtVin.Rows)
                {

                    j++;
                    Vin = string.Empty;
                    
                    Vin = vRow["Vin"].ToString();
                    Bus = vRow["Bus"].ToString();
                    VinId = int.Parse(vRow["VinID"].ToString());

                    if (j > 1)
                    {
                        _doc.NewPage();
                    }
                    //Dashboard//
                    //  sec = chap.AddSection(20f, Vin, j);
                    //PdfPTable tableHeader = GenerateBatteryAllCustHeader(ProcessDate, CustomerName, Vin, Bus);
                    //_doc.Add(tableHeader);
                    para = new Paragraph(Bus.ToUpper());
                    Chapter chap = new Chapter(para, j);
                    _doc.Add(chap);
                    string imageURL_VinDash = Path.Combine(TempFolderPath, string.Format("VinDashboard_{0}.png", vRow["VinID"].ToString()));

                    //iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
                    ////Resize image depend upon your need
                    ////jpg.ScaleToFit(chartWidth, chartHeight);
                    //// jpg_VinHist.ScaleToFit(600f, 250f);
                    //jpg_VinDash.ScalePercent(75f);

                    ////Give space before image
                    //jpg_VinDash.SpacingBefore = 10f;
                    ////Give some space after the image
                    //jpg_VinDash.SpacingAfter = 1f;
                    //jpg_VinDash.Alignment = Element.ALIGN_CENTER;
                    //_doc.Add(jpg_VinDash);


                    PdfPTable tablebat = GenerateBatteryVinDashboard(ProcessDate, VinId);
                    _doc.Add(tablebat);

                    //TMaxByPacks//               
                    string imageURL_TMaxByPacks = Path.Combine(TempFolderPath, string.Format("TMaxByPacks_{0}.png", vRow["VinID"].ToString()));

                    iTextSharp.text.Image jpg_TMaxByPacks = iTextSharp.text.Image.GetInstance(imageURL_TMaxByPacks);
                    //Resize image depend upon your need
                    //jpg.ScaleToFit(chartWidth, chartHeight);
                    // jpg_VinHist.ScaleToFit(600f, 250f);
                    jpg_TMaxByPacks.ScalePercent(60f);

                    //Give space before image
                    jpg_TMaxByPacks.SpacingBefore = 10f;
                    //Give some space after the image
                    jpg_TMaxByPacks.SpacingAfter = 1f;
                    jpg_TMaxByPacks.Alignment = Element.ALIGN_CENTER;
                    _doc.Add(jpg_TMaxByPacks);

                    //CurrentByPacks//               
                    string imageURL_CurrentByPacks = Path.Combine(TempFolderPath, string.Format("CurrentByPacks_{0}.png", vRow["VinID"].ToString()));

                    iTextSharp.text.Image jpg_CurrentByPacks = iTextSharp.text.Image.GetInstance(imageURL_CurrentByPacks);
                    //Resize image depend upon your need
                    //jpg.ScaleToFit(chartWidth, chartHeight);
                    // jpg_VinHist.ScaleToFit(600f, 250f);
                    jpg_CurrentByPacks.ScalePercent(60f);

                    //Give space before image
                    jpg_CurrentByPacks.SpacingBefore = 10f;
                    //Give some space after the image
                    jpg_CurrentByPacks.SpacingAfter = 1f;
                    jpg_CurrentByPacks.Alignment = Element.ALIGN_CENTER;
                    _doc.Add(jpg_CurrentByPacks);



                    //SoCByPacks_Min//               
                    string imageURL_SoCByPacks_Min = Path.Combine(TempFolderPath, string.Format("SoCByPacks_Min_{0}.png", vRow["VinID"].ToString()));

                    iTextSharp.text.Image jpg_SoCByPacks_Min = iTextSharp.text.Image.GetInstance(imageURL_SoCByPacks_Min);
                    //Resize image depend upon your need
                    //jpg.ScaleToFit(chartWidth, chartHeight);
                    // jpg_VinHist.ScaleToFit(600f, 250f);
                    jpg_SoCByPacks_Min.ScalePercent(60f);

                    //Give space before image
                    jpg_SoCByPacks_Min.SpacingBefore = 10f;
                    //Give some space after the image
                    jpg_SoCByPacks_Min.SpacingAfter = 1f;
                    jpg_SoCByPacks_Min.Alignment = Element.ALIGN_CENTER;
                    _doc.Add(jpg_SoCByPacks_Min);



                    //SoCByPacks_Max//               
                    string imageURL_SoCByPacks_Max = Path.Combine(TempFolderPath, string.Format("SoCByPacks_Max_{0}.png", vRow["VinID"].ToString()));

                    iTextSharp.text.Image jpg_SoCByPacks_Max = iTextSharp.text.Image.GetInstance(imageURL_SoCByPacks_Max);
                    //Resize image depend upon your need
                    //jpg.ScaleToFit(chartWidth, chartHeight);
                    // jpg_VinHist.ScaleToFit(600f, 250f);
                    jpg_SoCByPacks_Max.ScalePercent(60f);

                    //Give space before image
                    jpg_SoCByPacks_Max.SpacingBefore = 10f;
                    //Give some space after the image
                    jpg_SoCByPacks_Max.SpacingAfter = 1f;
                    jpg_SoCByPacks_Max.Alignment = Element.ALIGN_CENTER;
                    _doc.Add(jpg_SoCByPacks_Max);

                    //CurrentByPacks


                   
                }

              

            }
        }

        private static PdfPTable GenerateBatteryAllCustHeader(string ProcessDate,string CustomerName, string Vin, string Bus)
        {

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            Font times = new Font(bfTimes, 12, Font.ITALIC, Color.RED);
            Font fontTinyItalic = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.ITALIC, Color.GRAY);

            PdfPTable table = new PdfPTable(4);

            table.WidthPercentage = (100.0f);

            //relative col widths in proportions - 1/3 and 2/3

               float[] widths = new float[] { 1f, 3f,6f,2f };
            //float[] colWidths = { 70, 100, 100,400 };

               table.SetWidths(widths);

            table.HorizontalAlignment = 1;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;
            table.DefaultCell.HorizontalAlignment = 2;
            table.DefaultCell.Border = (PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER);

           // table.DefaultCell.GrayFill = 1;
         //   table.DefaultCell.Border = (PdfPCell.RECTANGLE);
            table.DefaultCell.BorderWidth = 2f;
            table.DefaultCell.BorderColor = new iTextSharp.text.Color(0, 128, 0);
            //table.DefaultCell.BorderColorBottom = new iTextSharp.text.Color(0, 0, 0);
            table.DefaultCell.Padding = 4;
            table.DefaultCell.BackgroundColor = new iTextSharp.text.Color(242, 242, 242);
            //table.DefaultCell.Border = 1;



            table.AddCell(" ");



            iTextSharp.text.Font fontIstRow = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8);
            // iTextSharp.text.Cell c1 = new iTextSharp.text.Cell("");
            string c1Text = CustomerName;
            PdfPCell cell1 = new PdfPCell(new Phrase(c1Text, fontIstRow));
            cell1.HorizontalAlignment = 1;
            cell1.Border = (PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER);
            cell1.BorderWidth = 2f;
           // cell1.Border = 1;
            cell1.GrayFill = 1;
            cell1.BorderColor = new iTextSharp.text.Color(0, 128, 0);
            cell1.BackgroundColor = new iTextSharp.text.Color(242, 242, 242);
            cell1.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell1);
            //c1.UseBorderPadding = false;  


            string c2Text = string.Concat(Bus, "  [",  Vin, "]");
            PdfPCell cell2 = new PdfPCell(new Phrase(c2Text, fontIstRow));
            cell2.HorizontalAlignment = 3;
            cell2.Border = (PdfPCell.BOTTOM_BORDER | PdfPCell.TOP_BORDER);
            cell2.BorderWidth = 2f;
            //cell2.Border = 1;
            cell2.GrayFill = 1;
            cell2.BorderColor = new iTextSharp.text.Color(0, 128, 0);
            cell2.BackgroundColor = new iTextSharp.text.Color(242, 242, 242);
            cell2.VerticalAlignment = Element.ALIGN_MIDDLE;
            table.AddCell(cell2);


            table.AddCell(" ");

          //  table.HeaderRows = 0;
            table.DefaultCell.BorderWidth = 1;
            Color altRow = new Color(242, 242, 242);
            table.DefaultCell.BackgroundColor = altRow;




            return table;

        }

        private static PdfPTable GenerateBatteryAllCustDashboard(string ProcessDate)
        {

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            Font times = new Font(bfTimes, 12, Font.ITALIC, Color.RED);
            Font fontTinyItalic = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.ITALIC, Color.GRAY);

            PdfPTable table = new PdfPTable(6);

            //actual width of table in points

            //table.TotalWidth = 216f;

            //fix the absolute width of the table

            // table.LockedWidth = true;

            table.WidthPercentage = (90.0f);

            //relative col widths in proportions - 1/3 and 2/3

            //   float[] widths = new float[] { 1f, 2f };
            float[] colWidths = {  70, 70, 70, 70, 70, 70 };

            table.SetWidths(colWidths);

            table.HorizontalAlignment = 1;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;
            table.DefaultCell.HorizontalAlignment = 2;
            //table.DefaultCell.Border = (PdfPCell.BOTTOM_BORDER);
            table.DefaultCell.GrayFill = 1;
            table.DefaultCell.Border = (PdfPCell.RECTANGLE);
            table.DefaultCell.BorderColor = new iTextSharp.text.Color(255, 255, 255);
            table.DefaultCell.BorderColorBottom = new iTextSharp.text.Color(255, 255, 255);
            table.DefaultCell.Padding = 4;


            //PdfPCell cell = new PdfPCell(new Phrase("Products","Test"));

            //cell.Colspan = 2;

            //cell.Border = 0;

            //cell.HorizontalAlignment = 1;


            //table.AddCell(cell);


            //Creating First Row that will contain the Title  


          //  table.AddCell("");

            Color headRowColor = new Color(0, 0, 0);
            Color headRowFontColor = new Color(255, 255, 255);
            iTextSharp.text.Font fontIstRow = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.WHITE);
            // iTextSharp.text.Cell c1 = new iTextSharp.text.Cell("");
            string c1Text = "VEHICLE";
            PdfPCell cell1 = new PdfPCell(new Phrase(c1Text, fontIstRow));
            cell1.HorizontalAlignment = 1; 
            cell1.Border = 0;
            cell1.GrayFill = 1;
            cell1.BackgroundColor = headRowColor;
            table.AddCell(cell1);
           
            //c1.UseBorderPadding = false;  

            string c2Text = "I_MIN(A)";
            PdfPCell cell2 = new PdfPCell(new Phrase(c2Text, fontIstRow));
            cell2.HorizontalAlignment = 1;
            cell2.Border = 0;
            cell2.GrayFill = 1;
            cell2.BackgroundColor = headRowColor;
            table.AddCell(cell2);


            string c3Text = "I_MAX(A)";
            PdfPCell cell3 = new PdfPCell(new Phrase(c3Text, fontIstRow));
            cell3.HorizontalAlignment = 1;
            cell3.Border = 0;
            cell3.GrayFill = 1;
            cell3.BackgroundColor = headRowColor;
            table.AddCell(cell3);






            string c6Text = "TEMP(C)";
            PdfPCell cell6 = new PdfPCell(new Phrase(c6Text, fontIstRow));
            cell6.HorizontalAlignment = 1;
            cell6.Border = 0;
            cell6.GrayFill = 1;
            cell6.BackgroundColor = headRowColor;
            table.AddCell(cell6);


            string c7Text = "SOC(%)";
            PdfPCell cell7 = new PdfPCell(new Phrase(c7Text, fontIstRow));
            cell7.HorizontalAlignment = 1;
            cell7.Border = 0;
            cell7.GrayFill = 1;
            cell7.BackgroundColor = headRowColor;
            table.AddCell(cell7);


            string c8Text = "Drive(Hr)";
            PdfPCell cell8 = new PdfPCell(new Phrase(c8Text, fontIstRow));
            cell8.HorizontalAlignment = 1;
            cell8.Border = 0;

            cell8.GrayFill = 1;
            cell8.BackgroundColor = headRowColor;
            table.AddCell(cell8);





            //table.AddCell("Drive_h");
            //table.AddCell("Temp");
            //table.AddCell("Soc");
            //table.AddCell("Drive_h");
            DateTime dtProcessDate;
            bool IsProcessDate = DateTime.TryParse(ProcessDate, out dtProcessDate);

            iTextSharp.text.Font fontDynmaicRows = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8,iTextSharp.text.Font.BOLD,iTextSharp.text.Color.BLACK);
            iTextSharp.text.Font fontDynmaicRowsRed = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.RED);
            iTextSharp.text.Font fontDynmaicRowsNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.BLACK);
            iTextSharp.text.Font fontDynmaicRowsRedNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.RED);
            GetData gd = new GetData();
            DataTable dataTable_TempData = new DataTable();
            dataTable_TempData = gd.Dt_DailyGrab_GetBatteryDashAllCust(dtProcessDate, 0);
            table.HeaderRows = 1;
            table.DefaultCell.BorderWidth = 1;
            Color altRow = new Color(242, 242, 242);

            int i = 0;
            foreach (DataRow dRow in dataTable_TempData.Rows)
            {

                i++;
                if (i % 2 == 1)
                {
                    table.DefaultCell.BackgroundColor = altRow;
                }
                else
                {
                    table.DefaultCell.BackgroundColor = Color.WHITE;
                }

                if (dRow[9].ToString() == "1")
                {
                  //  table.AddCell(new Phrase(dRow[0].ToString(), fontDynmaicRowsRed));

                    PdfPCell Cell1Hdr = new PdfPCell(new Phrase(dRow[1].ToString().ToUpper(), fontDynmaicRows));
                    Cell1Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    if (i % 2 == 1)
                    {
                        Cell1Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell1Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell1Hdr);


                    //PdfPCell Cell2Hdr = new PdfPCell(new Phrase(dRow[2].ToString(), fontDynmaicRowsNormal));
                    //Cell2Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    //table.AddCell(Cell2Hdr);


                    //PdfPCell Cell3Hdr = new PdfPCell(new Phrase(dRow[3].ToString(), fontDynmaicRows));
                    //Cell3Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    //table.AddCell(Cell3Hdr);


                    PdfPCell Cell4Hdr = new PdfPCell(new Phrase(dRow[4].ToString(), fontDynmaicRowsRed));
                    Cell4Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell4Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell4Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell4Hdr);


                    PdfPCell Cell5Hdr = new PdfPCell(new Phrase(dRow[5].ToString(), fontDynmaicRowsRedNormal));
                    Cell5Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell5Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell5Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell5Hdr);


                    PdfPCell Cell6Hdr = new PdfPCell(new Phrase(dRow[6].ToString(), fontDynmaicRowsRedNormal));
                    Cell6Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell6Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell6Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell6Hdr);

                    PdfPCell Cell7Hdr = new PdfPCell(new Phrase(dRow[7].ToString(), fontDynmaicRowsRedNormal));
                    Cell7Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell7Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell7Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell7Hdr);


                    PdfPCell Cell8Hdr = new PdfPCell(new Phrase(dRow[8].ToString(), fontDynmaicRowsRedNormal));
                    Cell8Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell8Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell8Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell8Hdr);




                    //table.AddCell(new Phrase(dRow[1].ToString(), fontDynmaicRowsRed));

                    //table.AddCell(new Phrase(dRow[4].ToString(), fontDynmaicRowsRed));
                    //table.AddCell(new Phrase(dRow[5].ToString(), fontDynmaicRowsRed));

                    //table.AddCell(new Phrase(dRow[6].ToString(), fontDynmaicRowsRed));
                    //table.AddCell(new Phrase(dRow[7].ToString(), fontDynmaicRowsRed));
                    //table.AddCell(new Phrase(dRow[8].ToString(), fontDynmaicRowsRed));
                }
                else
                {
                  //  table.AddCell(new Phrase(dRow[0].ToString(), fontDynmaicRows));

                    PdfPCell Cell1Hdr = new PdfPCell(new Phrase(dRow[1].ToString().ToUpper(), fontDynmaicRows));
                    Cell1Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    if (i % 2 == 1)
                    {
                        Cell1Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell1Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell1Hdr);


                    //PdfPCell Cell2Hdr = new PdfPCell(new Phrase(dRow[2].ToString(), fontDynmaicRowsNormal));
                    //Cell2Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    //table.AddCell(Cell2Hdr);


                    //PdfPCell Cell3Hdr = new PdfPCell(new Phrase(dRow[3].ToString(), fontDynmaicRows));
                    //Cell3Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    //table.AddCell(Cell3Hdr);


                    PdfPCell Cell4Hdr = new PdfPCell(new Phrase(dRow[4].ToString(), fontDynmaicRowsNormal));
                    Cell4Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell4Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell4Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell4Hdr);


                    PdfPCell Cell5Hdr = new PdfPCell(new Phrase(dRow[5].ToString(), fontDynmaicRowsNormal));
                    Cell5Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell5Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell5Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell5Hdr);


                    PdfPCell Cell6Hdr = new PdfPCell(new Phrase(dRow[6].ToString(), fontDynmaicRowsNormal));
                    Cell6Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell6Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell6Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell6Hdr);

                    PdfPCell Cell7Hdr = new PdfPCell(new Phrase(dRow[7].ToString(), fontDynmaicRowsNormal));
                    Cell7Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell7Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell7Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell7Hdr);


                    PdfPCell Cell8Hdr = new PdfPCell(new Phrase(dRow[8].ToString(), fontDynmaicRowsNormal));
                    Cell8Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell8Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell8Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell8Hdr);

             
                   // table.AddCell(new Phrase(dRow[1].ToString(), fontDynmaicRows));

                    //table.AddCell(new Phrase(dRow[4].ToString(), fontDynmaicRowsNormal));
                    //table.AddCell(new Phrase(dRow[5].ToString(), fontDynmaicRowsNormal));

                    //table.AddCell(new Phrase(dRow[6].ToString(), fontDynmaicRowsNormal));
                    //table.AddCell(new Phrase(dRow[7].ToString(), fontDynmaicRowsNormal));
                    //table.AddCell(new Phrase(dRow[8].ToString(), fontDynmaicRowsNormal));
                }


      

            }
            return table;
        }

        private static PdfPTable GenerateBatteryVinDashboard(string ProcessDate,int VinID)
        {

            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            Font times = new Font(bfTimes, 12, Font.ITALIC, Color.RED);
            Font fontTinyItalic = FontFactory.GetFont("Arial", 7, iTextSharp.text.Font.ITALIC, Color.GRAY);

            PdfPTable table = new PdfPTable(7);


            table.WidthPercentage = (70.0f);

            //relative col widths in proportions - 1/3 and 2/3

            //   float[] widths = new float[] { 1f, 2f };
            float[] colWidths = { 120, 70, 70, 70, 70, 70,70 };

            table.SetWidths(colWidths);

            table.HorizontalAlignment = 1;

            //leave a gap before and after the table

            table.SpacingBefore = 20f;

            table.SpacingAfter = 30f;
            table.DefaultCell.HorizontalAlignment = 2;
            //table.DefaultCell.Border = (PdfPCell.BOTTOM_BORDER);
            table.DefaultCell.GrayFill = 1;
            table.DefaultCell.Border = (PdfPCell.RECTANGLE);
            table.DefaultCell.BorderColor = new iTextSharp.text.Color(255, 255, 255);
            table.DefaultCell.BorderColorBottom = new iTextSharp.text.Color(255, 255, 255);
            table.DefaultCell.Padding = 4;


    
            Color headRowColor = new Color(0, 0, 0);
            Color headRowFontColor = new Color(255, 255, 255);
            iTextSharp.text.Font fontIstRow = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.WHITE);
            // iTextSharp.text.Cell c1 = new iTextSharp.text.Cell("");
            string c1Text = "Battery Pack";
            PdfPCell cell1 = new PdfPCell(new Phrase(c1Text, fontIstRow));
            cell1.HorizontalAlignment = 1;
            cell1.Border = 0;
            cell1.GrayFill = 1;
            cell1.BackgroundColor = headRowColor;
            table.AddCell(cell1);

            //c1.UseBorderPadding = false;  

            string c2Text = "dSoC";
            PdfPCell cell2 = new PdfPCell(new Phrase(c2Text, fontIstRow));
            cell2.HorizontalAlignment = 1;
            cell2.Border = 0;
            cell2.GrayFill = 1;
            cell2.BackgroundColor = headRowColor;
            table.AddCell(cell2);


            string c3Text = "I_MIN(A)";
            PdfPCell cell3 = new PdfPCell(new Phrase(c3Text, fontIstRow));
            cell3.HorizontalAlignment = 1;
            cell3.Border = 0;
            cell3.GrayFill = 1;
            cell3.BackgroundColor = headRowColor;
            table.AddCell(cell3);






            string c6Text = "I_MAX(A)";
            PdfPCell cell6 = new PdfPCell(new Phrase(c6Text, fontIstRow));
            cell6.HorizontalAlignment = 1;
            cell6.Border = 0;
            cell6.GrayFill = 1;
            cell6.BackgroundColor = headRowColor;
            table.AddCell(cell6);


            string c7Text = "T_MIN(C)";
            PdfPCell cell7 = new PdfPCell(new Phrase(c7Text, fontIstRow));
            cell7.HorizontalAlignment = 1;
            cell7.Border = 0;
            cell7.GrayFill = 1;
            cell7.BackgroundColor = headRowColor;
            table.AddCell(cell7);


            string c8Text = "T_MAX(C)";
            PdfPCell cell8 = new PdfPCell(new Phrase(c8Text, fontIstRow));
            cell8.HorizontalAlignment = 1;
            cell8.Border = 0;

            cell8.GrayFill = 1;
            cell8.BackgroundColor = headRowColor;
            table.AddCell(cell8);


            string c9Text = "SoC Range";
            PdfPCell cell9 = new PdfPCell(new Phrase(c9Text, fontIstRow));
            cell9.HorizontalAlignment = 1;
            cell9.Border = 0;

            cell9.GrayFill = 1;
            cell9.BackgroundColor = headRowColor;
            table.AddCell(cell9);




            DateTime dtProcessDate;
            bool IsProcessDate = DateTime.TryParse(ProcessDate, out dtProcessDate);

            iTextSharp.text.Font fontDynmaicRows = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.BLACK);
            iTextSharp.text.Font fontDynmaicRowsRed = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.RED);
            iTextSharp.text.Font fontDynmaicRowsNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.BLACK);
            iTextSharp.text.Font fontDynmaicRowsRedNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.RED);
            GetData gd = new GetData();
            DataTable dataTable_TempData = new DataTable();
            dataTable_TempData = gd.GetDashBoardDataTabular(VinID,dtProcessDate,"");
            table.HeaderRows = 1;
            table.DefaultCell.BorderWidth = 1;
            Color altRow = new Color(242, 242, 242);

            int i = 0;
            foreach (DataRow dRow in dataTable_TempData.Rows)
            {

                i++;
             

                    PdfPCell Cell1Hdr = new PdfPCell(new Phrase(dRow[1].ToString().ToUpper(), fontDynmaicRows));
                    Cell1Hdr.HorizontalAlignment = Element.ALIGN_LEFT;
                    if (i % 2 == 1)
                    {
                        Cell1Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell1Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell1Hdr);



                    PdfPCell Cell4Hdr = new PdfPCell(new Phrase(dRow[2].ToString(), fontDynmaicRowsNormal));
                    Cell4Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell4Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell4Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell4Hdr);


                    PdfPCell Cell5Hdr = new PdfPCell(new Phrase(dRow[3].ToString(), fontDynmaicRowsNormal));
                    Cell5Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell5Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell5Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell5Hdr);


                    PdfPCell Cell6Hdr = new PdfPCell(new Phrase(dRow[4].ToString(), fontDynmaicRowsNormal));
                    Cell6Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell6Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell6Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell6Hdr);

                    PdfPCell Cell7Hdr = new PdfPCell(new Phrase(dRow[5].ToString(), fontDynmaicRowsNormal));
                    Cell7Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell7Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell7Hdr.BackgroundColor = Color.WHITE;
                    }
                    table.AddCell(Cell7Hdr);


                    PdfPCell Cell8Hdr = new PdfPCell(new Phrase(dRow[6].ToString(), fontDynmaicRowsNormal));
                    Cell8Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell8Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell8Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell8Hdr);



                    PdfPCell Cell9Hdr = new PdfPCell(new Phrase(dRow[7].ToString(), fontDynmaicRowsNormal));
                    Cell9Hdr.HorizontalAlignment = Element.ALIGN_RIGHT;
                    if (i % 2 == 1)
                    {
                        Cell9Hdr.BackgroundColor = altRow;
                    }
                    else
                    {
                        Cell9Hdr.BackgroundColor = Color.WHITE;
                    }

                    table.AddCell(Cell9Hdr);






            }
            return table;
        }



        private void GenPdfDailyBattery(string TempFolderPath, string ImageFileName, string ReportPeriod)
        {
            //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
            PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);
            _doc.Open();

            //string imageURL_VinSplash = @ImageFileName;
            //iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
            iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

            //Resize image depend upon your need
            jpg_VinSplash.ScalePercent(75f);

            //Give space before image
            jpg_VinSplash.SpacingBefore = 10f;

            //Give some space after the image
            jpg_VinSplash.SpacingAfter = 1f;
            jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

            _doc.Add(jpg_VinSplash);
            _doc.NewPage();

            string imageURL_VinDash = Path.Combine(TempFolderPath, "VinDashboard.png");
            iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_VinDash.ScalePercent(60f);

            //Give space before image
            jpg_VinDash.SpacingBefore = 10f;
            //Give some space after the image
            jpg_VinDash.SpacingAfter = 1f;
            jpg_VinDash.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_VinDash);
  


            
            string imageURL_SoCByPacks_Min = Path.Combine(TempFolderPath, "SoCByPacks_Min.png");
            iTextSharp.text.Image jpg_SoCByPacks_Min = iTextSharp.text.Image.GetInstance(imageURL_SoCByPacks_Min);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_SoCByPacks_Min.ScalePercent(60f);

            //Give space before image
            jpg_SoCByPacks_Min.SpacingBefore = 10f;
            //Give some space after the image
            jpg_SoCByPacks_Min.SpacingAfter = 1f;
            jpg_SoCByPacks_Min.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_SoCByPacks_Min);
        



             string imageURL_SoCByPacks_Max = Path.Combine(TempFolderPath, "SoCByPacks_Max.png");
            iTextSharp.text.Image jpg_SoCByPacks_Max = iTextSharp.text.Image.GetInstance(imageURL_SoCByPacks_Max);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_SoCByPacks_Max.ScalePercent(60f);

            //Give space before image
            jpg_SoCByPacks_Max.SpacingBefore = 10f;
            //Give some space after the image
            jpg_SoCByPacks_Max.SpacingAfter = 1f;
            jpg_SoCByPacks_Max.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_SoCByPacks_Max);
       


             string imageURL_CurrentByPacks = Path.Combine(TempFolderPath, "CurrentByPacks.png");
            iTextSharp.text.Image jpg_CurrentByPacks = iTextSharp.text.Image.GetInstance(imageURL_CurrentByPacks);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_CurrentByPacks.ScalePercent(60f);

            //Give space before image
            jpg_CurrentByPacks.SpacingBefore = 10f;
            //Give some space after the image
            jpg_CurrentByPacks.SpacingAfter = 1f;
            jpg_CurrentByPacks.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_CurrentByPacks);


            string imageURL_TMaxByPacks_Max = Path.Combine(TempFolderPath, "TMaxByPacks.png");
            iTextSharp.text.Image jpg_TMaxByPacks_Max = iTextSharp.text.Image.GetInstance(imageURL_TMaxByPacks_Max);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_TMaxByPacks_Max.ScalePercent(60f);

            //Give space before image
            jpg_TMaxByPacks_Max.SpacingBefore = 10f;
            //Give some space after the image
            jpg_TMaxByPacks_Max.SpacingAfter = 1f;
            jpg_TMaxByPacks_Max.Alignment = Element.ALIGN_CENTER;
            _doc.Add(jpg_TMaxByPacks_Max);
         



           

               PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

            //    //set the open action for our writer object
                _writer.SetOpenAction(action);





        }

        public void GenPdf(string TempFolderPath, string ImageFileName, string ReportPeriod)
        {

            switch (ReportPeriod)
            {
                case "Daily":
                    GenPdfDaily(TempFolderPath, ImageFileName, ReportPeriod);
                    break;
                case "Weekly":
                    GenPdfWeekly(TempFolderPath, ImageFileName, ReportPeriod);
                    break;
                case "NREL":
                    GenPdfNREL(TempFolderPath, ImageFileName, ReportPeriod);
                    break;
                case "DailyBattery":
                    GenPdfDailyBattery(TempFolderPath, ImageFileName, ReportPeriod);
                    break;
             
                    

                default:
                    break;
            }
           

        }

        //public void GenPdfOld(string TempFolderPath, string ImageFileName, string ReportPeriod)
        //{
          


        //    //this creates a new destination to send the action to when the document is opened. The zoom in this instance is set to 0.75f (75%). Again I use doc.PageSize.Height to set the y coordinate to the top of the page. PdfDestination.XYZ is a specific PdfDestination Type that allows us to set the location and zoom.
        //    PdfDestination pdfDest = new PdfDestination(PdfDestination.XYZ, 0, _doc.PageSize.Height, 1.00f);

           
        //    _doc.Open();

        //    //string imageURL_VinSplash = @ImageFileName;
        //    //iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

        //    string imageURL_VinSplash = Path.Combine(TempFolderPath, "VinCoverPage.png");
        //    iTextSharp.text.Image jpg_VinSplash = iTextSharp.text.Image.GetInstance(imageURL_VinSplash);

        //    //Resize image depend upon your need
        //    jpg_VinSplash.ScalePercent(65f);

        //    //Give space before image
        //    jpg_VinSplash.SpacingBefore = 10f;

        //    //Give some space after the image
        //    jpg_VinSplash.SpacingAfter = 1f;
        //    jpg_VinSplash.Alignment = Element.ALIGN_CENTER;

        //    _doc.Add(jpg_VinSplash);


        //    _doc.NewPage();

        //    //call WriteSelectedRows of PdfTable. This writes rows from PdfWriter in PdfTable
        //    //first param is start row. -1 indicates there is no end row and all the rows to be included to write
        //    //Third and fourth param is x and y position to start writing
        //    //pdfTab.WriteSelectedRows(0, -1, 40, document.PageSize.Height - 30, writer.DirectContent);




        //    string imageURL_VinDash = Path.Combine(TempFolderPath,"VinDashboard.png");
        //    iTextSharp.text.Image jpg_VinDash = iTextSharp.text.Image.GetInstance(imageURL_VinDash);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinDash.ScalePercent(75f);

        //    //Give space before image
        //    jpg_VinDash.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinDash.SpacingAfter = 1f;
        //    jpg_VinDash.Alignment = Element.ALIGN_CENTER;
        //    _doc.Add(jpg_VinDash);




            
        //    //string imageURL_ChargingStats = Path.Combine(TempFolderPath,"GenVehicleData_ChargingStats.png");
        //    //iTextSharp.text.Image jpg_ChargingStats = iTextSharp.text.Image.GetInstance(imageURL_ChargingStats);
        //    ////Resize image depend upon your need
        //    ////jpg.ScaleToFit(chartWidth, chartHeight);
        //    //// jpg_VinHist.ScaleToFit(600f, 250f);
        //    //jpg_ChargingStats.ScalePercent(75f);

        //    ////Give space before image
        //    //jpg_ChargingStats.SpacingBefore = 10f;
        //    ////Give some space after the image
        //    //jpg_ChargingStats.SpacingAfter = 1f;
        //    //jpg_ChargingStats.Alignment = Element.ALIGN_CENTER;
        //    //_doc.Add(jpg_ChargingStats);




  




        //    _doc.NewPage();








        //    string imageURL_VinHist = Path.Combine(TempFolderPath, "VinSpeedHist.png");
       
        //    iTextSharp.text.Image jpg_VinHist = iTextSharp.text.Image.GetInstance(imageURL_VinHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinHist.SpacingAfter = 1f;
        //    jpg_VinHist.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_VinHist);




        //    string imageURL_VinEffHist = Path.Combine(TempFolderPath, "VinEfficiencyHist.png");
   
        //    iTextSharp.text.Image jpg_VinEffHist = iTextSharp.text.Image.GetInstance(imageURL_VinEffHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinEffHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinEffHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinEffHist.SpacingAfter = 1f;
        //    jpg_VinEffHist.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_VinEffHist);


        //    string imageURL_VinAccelPedalHist = Path.Combine(TempFolderPath, "VinAccelPedalHist.png");
         
        //    iTextSharp.text.Image jpg_VinAccelPedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinAccelPedalHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinAccelPedalHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinAccelPedalHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinAccelPedalHist.SpacingAfter = 1f;
        //    jpg_VinAccelPedalHist.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_VinAccelPedalHist);


        //    string imageURL_VinBrakePedalHist = Path.Combine(TempFolderPath, "VinBrakePedalHist.png");
      
        //    iTextSharp.text.Image jpg_VinBrakePedalHist = iTextSharp.text.Image.GetInstance(imageURL_VinBrakePedalHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinBrakePedalHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinBrakePedalHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinBrakePedalHist.SpacingAfter = 1f;
        //    jpg_VinBrakePedalHist.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_VinBrakePedalHist);




        //    string imageURL_VinChargingHist = Path.Combine(TempFolderPath, "VinChargingHist.png");

        //    iTextSharp.text.Image jpg_VinChargingHist = iTextSharp.text.Image.GetInstance(imageURL_VinChargingHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinChargingHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinChargingHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinChargingHist.SpacingAfter = 1f;
        //    jpg_VinChargingHist.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_VinChargingHist);



         




        //    string imageURL_VinDCDCConverterPowerHist = Path.Combine(TempFolderPath, "VinDCDCConverterPowerHist.png");

        //    iTextSharp.text.Image jpg_VinDCDCConverterPowerHist = iTextSharp.text.Image.GetInstance(imageURL_VinDCDCConverterPowerHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinDCDCConverterPowerHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinDCDCConverterPowerHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinDCDCConverterPowerHist.SpacingAfter = 1f;
        //    jpg_VinDCDCConverterPowerHist.Alignment = Element.ALIGN_CENTER;
        //    _doc.Add(jpg_VinDCDCConverterPowerHist);



        //    string imageURL_VinPECoolantTempHist = Path.Combine(TempFolderPath, "VinPECoolantTempHist.png");

        //    iTextSharp.text.Image jpg_VinPECoolantTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinPECoolantTempHist);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    // jpg_VinHist.ScaleToFit(600f, 250f);
        //    jpg_VinPECoolantTempHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinPECoolantTempHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinPECoolantTempHist.SpacingAfter = 1f;
        //    jpg_VinPECoolantTempHist.Alignment = Element.ALIGN_CENTER;
        //    _doc.Add(jpg_VinPECoolantTempHist);



               
        //   if (ReportPeriod == "NREL" || ReportPeriod == "Weekly"  )
        //    {
        //     string imageURL_VinChgEnergyHist = Path.Combine(TempFolderPath, "VinChgEnergyHist.png");
        //    iTextSharp.text.Image jpg_VinChgEnergyHist = iTextSharp.text.Image.GetInstance(imageURL_VinChgEnergyHist);        
        //    jpg_VinChgEnergyHist.ScalePercent(85f);

        //    //Give space before image
        //    jpg_VinChgEnergyHist.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_VinChgEnergyHist.SpacingAfter = 1f;
        //    jpg_VinChgEnergyHist.Alignment = Element.ALIGN_CENTER;
               
        //    _doc.Add(jpg_VinChgEnergyHist);

        //    }



        //    if (ReportPeriod != "NREL")
        //    {



        //        string imageURL_VinVoltageHist = Path.Combine(TempFolderPath, "VinVoltageHist.png");

        //        iTextSharp.text.Image jpg_VinVoltageHist = iTextSharp.text.Image.GetInstance(imageURL_VinVoltageHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinVoltageHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinVoltageHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinVoltageHist.SpacingAfter = 1f;
        //        jpg_VinVoltageHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinVoltageHist);
                
                
        //        string imageURL_VinBatteryTempMaxHist = Path.Combine(TempFolderPath, "VinBatteryTempMaxHist.png");

        //        iTextSharp.text.Image jpg_VinBatteryTempMaxHist = iTextSharp.text.Image.GetInstance(imageURL_VinBatteryTempMaxHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinBatteryTempMaxHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinBatteryTempMaxHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinBatteryTempMaxHist.SpacingAfter = 1f;
        //        jpg_VinBatteryTempMaxHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinBatteryTempMaxHist);

    





        //        string imageURL_VinStatorTempHist = Path.Combine(TempFolderPath, "VinStatorTempHist.png");

        //        iTextSharp.text.Image jpg_VinStatorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinStatorTempHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinStatorTempHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinStatorTempHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinStatorTempHist.SpacingAfter = 1f;
        //        jpg_VinStatorTempHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinStatorTempHist);



        //        string imageURL_VinTractionMotorRotorTempHist = Path.Combine(TempFolderPath, "VinTractionMotorRotorTempHist.png");

        //        iTextSharp.text.Image jpg_VinTractionMotorRotorTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorRotorTempHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinTractionMotorRotorTempHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinTractionMotorRotorTempHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinTractionMotorRotorTempHist.SpacingAfter = 1f;
        //        jpg_VinTractionMotorRotorTempHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinTractionMotorRotorTempHist);



        //        string imageURL_VinTractionMotorInverterTempHist = Path.Combine(TempFolderPath, "VinTractionMotorInverterTempHist.png");

        //        iTextSharp.text.Image jpg_VinTractionMotorInverterTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorInverterTempHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinTractionMotorInverterTempHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinTractionMotorInverterTempHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinTractionMotorInverterTempHist.SpacingAfter = 1f;
        //        jpg_VinTractionMotorInverterTempHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinTractionMotorInverterTempHist);


        //        string imageURL_VinTractionMotorIGBTTempHist = Path.Combine(TempFolderPath, "VinTractionMotorIGBTTempHist.png");

        //        iTextSharp.text.Image jpg_VinTractionMotorIGBTTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTractionMotorIGBTTempHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinTractionMotorIGBTTempHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinTractionMotorIGBTTempHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinTractionMotorIGBTTempHist.SpacingAfter = 1f;
        //        jpg_VinTractionMotorIGBTTempHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinTractionMotorIGBTTempHist);



        //        string imageURL_VinRadiatorFanSpeedHist = Path.Combine(TempFolderPath, "VinRadiatorFanSpeedHist.png");

        //        iTextSharp.text.Image jpg_VinRadiatorFanSpeedHist = iTextSharp.text.Image.GetInstance(imageURL_VinRadiatorFanSpeedHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinRadiatorFanSpeedHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinRadiatorFanSpeedHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinRadiatorFanSpeedHist.SpacingAfter = 1f;
        //        jpg_VinRadiatorFanSpeedHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinRadiatorFanSpeedHist);




        //        string imageURL_VinBatteryCoolantPumpHist = Path.Combine(TempFolderPath, "VinBatteryCoolantPumpHist.png");

        //        iTextSharp.text.Image jpg_VinBatteryCoolantPumpHist = iTextSharp.text.Image.GetInstance(imageURL_VinBatteryCoolantPumpHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinBatteryCoolantPumpHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinBatteryCoolantPumpHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinBatteryCoolantPumpHist.SpacingAfter = 1f;
        //        jpg_VinBatteryCoolantPumpHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinBatteryCoolantPumpHist);



        //        string imageURL_VinMinAirPressureHist = Path.Combine(TempFolderPath, "VinMinAirPressureHist.png");

        //        iTextSharp.text.Image jpg_VinMinAirPressureHist = iTextSharp.text.Image.GetInstance(imageURL_VinMinAirPressureHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinMinAirPressureHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinMinAirPressureHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinMinAirPressureHist.SpacingAfter = 1f;
        //        jpg_VinMinAirPressureHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinMinAirPressureHist);



        //        string imageURL_VinTransTempHist = Path.Combine(TempFolderPath, "VinTransTempHist.png");

        //        iTextSharp.text.Image jpg_VinTransTempHist = iTextSharp.text.Image.GetInstance(imageURL_VinTransTempHist);
        //        //Resize image depend upon your need
        //        //jpg.ScaleToFit(chartWidth, chartHeight);
        //        // jpg_VinHist.ScaleToFit(600f, 250f);
        //        jpg_VinTransTempHist.ScalePercent(85f);

        //        //Give space before image
        //        jpg_VinTransTempHist.SpacingBefore = 10f;
        //        //Give some space after the image
        //        jpg_VinTransTempHist.SpacingAfter = 1f;
        //        jpg_VinTransTempHist.Alignment = Element.ALIGN_CENTER;
        //        _doc.Add(jpg_VinTransTempHist);

        //    }



           


        //    if (ReportPeriod =="Daily")
        //    { 

        //    string imageURL_GenVehicleData_SoC = Path.Combine(TempFolderPath, "GenVehicleData_SoC.png");

        //    iTextSharp.text.Image jpg_Soc = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_SoC);
        //    //Resize image depend upon your need
        //    //jpg.ScaleToFit(chartWidth, chartHeight);
        //    //jpg.ScaleToFit(600f, 250f);
        //    //Give space before image
        //    jpg_Soc.ScalePercent(85f);
        //    jpg_Soc.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_Soc.SpacingAfter = 1f;
        //    jpg_Soc.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_Soc);


        //    string imageURL_GenVehicleData_VinSpeed = Path.Combine(TempFolderPath, "GenVehicleData_VinSpeed.png");
        //   // imageURL_GenVehicleData_VinSpeed = @"C:\TestScreen\temp\GenVehicleData_VinSpeed.png";
        //    iTextSharp.text.Image jpg_Spd = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_VinSpeed);
        //    //Resize image depend upon your need
        //    // jpgSpd.ScaleToFit(600f, 250f);
        //    //Give space before image

        //    jpg_Spd.ScalePercent(85f);
        //    jpg_Spd.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpg_Spd.SpacingAfter = 1f;
        //    jpg_Spd.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpg_Spd);


        //    string imageURL_GenVehicleData_SoCEnergy = Path.Combine(TempFolderPath, "GenVehicleData_SoCEnergy.png");

        //    iTextSharp.text.Image jpgSocEnergy = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_SoCEnergy);
        //    //Resize image depend upon your need
        //    //jpgSocEnergy.ScaleToFit(600f, 250f);
        //    //Give space before image

        //    jpgSocEnergy.ScalePercent(85f);
        //    jpgSocEnergy.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpgSocEnergy.SpacingAfter = 1f;
        //    jpgSocEnergy.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpgSocEnergy);



        //    string imageURL_GenVehicleData_CurrentVoltage = Path.Combine(TempFolderPath, "GenVehicleData_CurrentVoltage.png");
        //  //  imageURL = @"C:\TestScreen\temp\GenVehicleData_CurrentVoltage.png";
        //    iTextSharp.text.Image jpgVA = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_CurrentVoltage);
        //    //Resize image depend upon your need
        //    //jpgVA.ScaleToFit(600f, 250f);
        //    //Give space before image

        //    jpgVA.ScalePercent(85f);
        //    jpgVA.SpacingBefore = 10f;
        //    //Give some space after the image
        //    jpgVA.SpacingAfter = 1f;
        //    jpgVA.Alignment = Element.ALIGN_CENTER;


        //    _doc.Add(jpgVA);



        //    }





        //    PdfAction action = PdfAction.GotoLocalPage(1, pdfDest, _writer);

        //    //set the open action for our writer object
        //    _writer.SetOpenAction(action);

          
      

        //}


        public void TearDown()
        {
         
       
            _doc.Close();
            _fs.Close();
            _writer.Close();

        }


    }
}
