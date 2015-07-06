using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace GenerateStaticVinReports
{


    class Program
    {

   
        static void Main(string[] args)
        {


            string ReportFolderPath = @"\\bus.local\files\Engineering\_UnifiedData\VehicleSummaryReports";
            string TempFolderPath = @"C:\Reports\Temp";
            string ImageFolderPath = @"C:\Reports\Images";
            string WebAddress = "http://localhost/ChartGenerator/";
            string VinID = String.Empty;
            string Vin = String.Empty;
            string ReportPeriod = String.Empty;
            string CustomerName = String.Empty;
            string ProcessDate = String.Empty;
            string WeekNumber = String.Empty;
            string YearNumber = String.Empty;
            int ReportID = 0;

            string GenerationMode = "Auto";
    
            if (args == null)
            {
                Console.WriteLine("args is null"); // Check for null array
                GenerationMode = "Auto";
            }
            else
            {

                if (args.Length > 0)
                {
                    GenerationMode = "Manual";
                }
                else
                {
                    GenerationMode = "Auto";
                }

                Console.Write("args length is ");
                Console.WriteLine(args.Length); // Write array length
                for (int i = 0; i < args.Length; i++) // Loop through array
                {
                    string argument = args[i];
                    //Console.Write("args index ");
                    //Console.Write(i); // Write index
                    //Console.Write(" is [");
                    //Console.Write(argument); // Write string
                    //Console.WriteLine("]");

                    if (i == 0)
                    {
                        VinID = argument;
                    }


                    if (i == 1)
                    {
                        ReportPeriod = argument;
                    }

                     if (i == 2)
                    {
                        if (IsDate(argument))
                        {

                            ProcessDate = argument;
                        }
                        else
                        {
                            WeekNumber = argument;
                        }
                    }
                                                      

                     if (i == 3)
                     {
                         YearNumber = argument;
                     }


                }
            }

            //Console.Write("VinID  " + VinID);
            //Console.Write("  ProcessDate  " + ProcessDate);

            if (GenerationMode == "Auto")
            {
                VinReportParam rp = new VinReportParam();

                 GetData VinRptData = new GetData();
                  rp = VinRptData.GetActionReportRow();

                  ProcessDate = rp.ProcessDate;
                  VinID = rp.VinID.ToString();
                  WeekNumber = rp.WeekNumber;
                  YearNumber = rp.YearNumber;
                  ReportPeriod = rp.ReportPeriod;
                  ReportID = rp.ReportID;

            }


            if (VinID != String.Empty)
            {          
                GetVehicleDetails(VinID, ref Vin, ref CustomerName);

                if (string.IsNullOrEmpty(CustomerName) == false)
                {
                    CheckFolderPath(ReportFolderPath,TempFolderPath, Vin, CustomerName,ReportPeriod);

                    Boolean CheckData = GetData.CheckDataExists(VinID, ProcessDate, ReportPeriod, WeekNumber, YearNumber);

                    if (ReportPeriod == "DailyBattery")
                    {
                        CheckData  = true;
                    }


                    if (CheckData  == true)
                    {
                        CreateReportImage(WebAddress, TempFolderPath, Vin, VinID, ProcessDate, CustomerName, ReportPeriod, WeekNumber, YearNumber);
                        CreateReportPdf(ReportFolderPath, TempFolderPath, ImageFolderPath, Vin, ProcessDate, CustomerName, ReportPeriod, WeekNumber, YearNumber,
                            ReportID);
                    }
               }

            }

        }

        private static void CreateReportPdf(string ReportFolderPath, string TempFolderPath, string ImageFolderPath, string Vin, string ProcessDate, string CustomerName, string ReportPeriod, string WeekNumber, string YearNumber, int ReportID)
        {
            CreateReports CrtPdf = new CreateReports();

            string PdfFolder = Path.Combine(ReportFolderPath, CustomerName, Vin, ReportPeriod);
            string ReportFileName = String.Empty;
            if (ReportPeriod == "Weekly")
            {
                ReportFileName = Path.Combine(PdfFolder, "WeeklyVinReport_" + Vin + "_" + WeekNumber + "_" + YearNumber + ".pdf");
            }
            else if (ReportPeriod == "NREL")
            {
                ReportFileName = Path.Combine(PdfFolder, "NRELVinReport_" + Vin + "_" + WeekNumber + "_" + YearNumber + ".pdf");
            }
            else if (ReportPeriod == "DailyBattery")
            {
                ReportFileName = Path.Combine(PdfFolder, "DailyBatteryReport_" + Vin + "_" + WeekNumber + "_" + YearNumber + ".pdf");
            }
            else
            {
                ReportFileName = Path.Combine(PdfFolder, "DailyVinReport_" + Vin + "_" + ProcessDate.Replace("/", "") + ".pdf");
            }

     
            string ImageFileName = Path.Combine(ImageFolderPath, "splash.png");
            string RptImageFolder = Path.Combine(TempFolderPath, CustomerName, Vin, ReportPeriod);


            CrtPdf.SetUp(ReportFileName, Vin, ProcessDate, ReportPeriod, WeekNumber, YearNumber);
            CrtPdf.GenPdf(RptImageFolder, ImageFileName, ReportPeriod);
         //   CrtPdf.getImage(VinId, ProcessDate, WebAddress, ImageFolder);
            CrtPdf.TearDown();


            GetData VinRptData = new GetData();
            VinRptData.UdpdateReportLog(ReportID);

        }

        private static void CreateReportImage(string WebAddress, string TempFolderPath,string Vin, string VinId, string ProcessDate, string CustomerName, string ReportPeriod, string WeekNumber, string YearNumber)
        {
            CreateImages CrtImg = new CreateImages();
            CrtImg.SetUp();
            string ImageFolder = Path.Combine(TempFolderPath, CustomerName, Vin, ReportPeriod);
            CrtImg.getImage(VinId, ProcessDate, WebAddress, ImageFolder,ReportPeriod, WeekNumber, YearNumber);
            CrtImg.TearDown();


        }

        private static void GetVehicleDetails(string VinID, ref string Vin,  ref string CustomerName)
        {
            //var dataConnect = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
           
            int intVinID;
            bool IsVinNumeric = int.TryParse(VinID, out intVinID);
            Vehicles Vehicle = new Vehicles();
            if (IsVinNumeric == true)
            {
                  GetData VinData = new GetData();
                  Vehicle = VinData.GetVinInfo(intVinID);
                  Vin = Vehicle.Vin;
                  CustomerName = Vehicle.CustomerName;


                  Console.Write("Vin   " + Vehicle.Vin);
                  Console.Write("Customer   " + Vehicle.CustomerName);

            }

           
            

           
        }

        private static void CheckFolderPath(string ReportFolderPath, String TempFolderPath, string Vin, string CustomerName, String ReportPeriod)
        {

            
            
            Console.Write("Vin   " + Vin);
            Console.Write("Customer   " + CustomerName);


            string rptPath = Path.Combine(ReportFolderPath, CustomerName, Vin, ReportPeriod);
            string tempPath = Path.Combine(TempFolderPath, CustomerName, Vin, ReportPeriod);
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(rptPath))
                {
                    Directory.CreateDirectory(rptPath);
     
                }

                if (!Directory.Exists(tempPath))
                {
                    Directory.CreateDirectory(tempPath);
                }
                else
                {
                    DirectoryInfo tempImagMessageInfo = new DirectoryInfo(tempPath);

                    foreach (FileInfo file in tempImagMessageInfo.GetFiles())
                    {
                        file.Delete();
                    }
                }


            }
            catch (Exception)
            {
                // Fail silently
            }

        }
        

        private static  bool IsDate(string inputDate)
{

DateTime dt;
return DateTime.TryParse(inputDate, out dt);

}
        
    
    }


}
