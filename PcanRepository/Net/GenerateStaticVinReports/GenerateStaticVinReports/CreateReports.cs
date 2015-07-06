using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp;
using System.IO;


namespace GenerateStaticVinReports
{
    class CreateReports
    {

        private Document _doc;
        private FileStream _fs;
        private PdfWriter _writer;


        public void SetUp(string ReportFileName, string Vin, string ProcessDate, string ReportPeriod, string WeekNumber, string YearNumber)
        {
             _fs = new FileStream(@ReportFileName, FileMode.Create, FileAccess.Write, FileShare.None);
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

       


            string imageURL_VinDash = Path.Combine(TempFolderPath,"VinDashboard.png");
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


            string imageURL_GenVehicleData_SoC = Path.Combine(TempFolderPath, "GenVehicleData_SoC.png");

            iTextSharp.text.Image jpg_Soc = iTextSharp.text.Image.GetInstance(imageURL_GenVehicleData_SoC);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            //jpg.ScaleToFit(600f, 250f);
            //Give space before image
            jpg_Soc.ScalePercent(85f);
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

            jpg_Spd.ScalePercent(85f);
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

            jpgSocEnergy.ScalePercent(85f);
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

            jpgVA.ScalePercent(85f);
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
  


            
            string imageURL_SoCByPacks_Min = Path.Combine(TempFolderPath, "SoCByPacks_Min.png");
            iTextSharp.text.Image jpg_SoCByPacks_Min = iTextSharp.text.Image.GetInstance(imageURL_SoCByPacks_Min);
            //Resize image depend upon your need
            //jpg.ScaleToFit(chartWidth, chartHeight);
            // jpg_VinHist.ScaleToFit(600f, 250f);
            jpg_SoCByPacks_Min.ScalePercent(75f);

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
            jpg_SoCByPacks_Max.ScalePercent(75f);

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
            jpg_CurrentByPacks.ScalePercent(75f);

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
            jpg_TMaxByPacks_Max.ScalePercent(75f);

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
