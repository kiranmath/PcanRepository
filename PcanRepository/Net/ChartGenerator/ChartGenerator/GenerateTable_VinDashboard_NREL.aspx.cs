using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ChartGenerator
{
    public partial class GenerateTable_VinDashboard_NREL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


             string VinID = Request.QueryString["VinID"].ToString();

            string ProcessDate = String.Empty;
            DateTime dtProcessDate = DateTime.Today;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ProcessDate"]))
            {
                ProcessDate = Request.QueryString["ProcessDate"].ToString();
                dtProcessDate = DateTime.Parse(ProcessDate);
            }

            string ReportType = String.Empty;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ReportType"]))
            {
                ReportType = Request.QueryString["ReportType"].ToString();
            }


            string WeekNumber = String.Empty;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["WeekNumber"]))
            {
                WeekNumber = Request.QueryString["WeekNumber"].ToString();
            }


            string YearNumber = String.Empty;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["YearNumber"]))
            {
                YearNumber = Request.QueryString["YearNumber"].ToString();
            }



            string ReportPeriod = String.Empty;
            if (!string.IsNullOrWhiteSpace(Request.QueryString["ReportPeriod"]))
            {
                ReportPeriod = Request.QueryString["ReportPeriod"].ToString();
            }

            int intWeekNumber = 0;
            int intYearNumber = 0;

            string DtRangeWeekly = String.Empty;
            if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
            {
                bool IsWeekNumeric = int.TryParse(WeekNumber, out intWeekNumber);
                if (IsWeekNumeric)
                {
                    intWeekNumber = int.Parse(WeekNumber);
                }


                bool IsYearNumeric = int.TryParse(YearNumber, out intYearNumber);
                if (IsYearNumeric)
                {
                    intYearNumber = int.Parse(YearNumber);
                }

                GetChartData gd = new GetChartData();
                DataTable DtRange = gd.GetDateRangeFromWeekNumber(intWeekNumber, intYearNumber);

                DtRangeWeekly = Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d") + " - " + Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d");
            }

            if (ReportPeriod == "Weekly")
            {
                lblHead.InnerText = "Weekly Vehicle Report";
            }
            else     if (ReportPeriod == "NREL")
            {
                lblHead.InnerText = "NREL Weekly Vehicle Report";
            }
                

            else
            {
                lblHead.InnerText = "Daily Vehicle Report";
            }


            

            //VinID = "221";
            //  ReportType = "GenVehicleData_VinSpeed";
            //ReportType = "GenVehicleData_CurrentVoltage";
            //ProcessDate = "04/13/2015";
           


            Vehicles Vehicle = new Vehicles();

            if (VinID != "")
            {
                int intVinID;
                bool IsVinNumeric = int.TryParse(VinID, out intVinID);

                if (IsVinNumeric)
                {
                    intVinID = int.Parse(VinID);

                    GetChartData gcd = new GetChartData();
                    Vehicle = gcd.GetVinInfo(intVinID);
                    GetChartData gd = new GetChartData();
                    ReportType = "OperationalData";

                    DataTable dataTable_OperationalData = new DataTable();

                    if (intWeekNumber > 0)
                    {
                         dataTable_OperationalData = gd.GetDashBoardData(intVinID, intWeekNumber,intYearNumber, ReportType);
                    }
                    else
                    {
                        dataTable_OperationalData = gd.GetDashBoardData(intVinID, dtProcessDate, ReportType);
                    }

                    ReportType = "HVACOperationMode";

                    DataTable dataTable_HVACOperationMode = new DataTable();
                    if (intWeekNumber > 0)
                    {
                         dataTable_HVACOperationMode = gd.GetDashBoardData(intVinID, intWeekNumber, intYearNumber, ReportType);
                    }
                    else
                    {
                         dataTable_HVACOperationMode = gd.GetDashBoardData(intVinID, dtProcessDate, ReportType);
                    }


                    ReportType = "AuxLoadsOnTime";
                    DataTable dataTable_AuxLoadsOnTime = new DataTable();
                    if (intWeekNumber > 0)
                    {
                         dataTable_AuxLoadsOnTime = gd.GetDashBoardData(intVinID, intWeekNumber, intYearNumber, ReportType);
                    }
                    else
                    {
                         dataTable_AuxLoadsOnTime = gd.GetDashBoardData(intVinID, dtProcessDate, ReportType);
                    }


         
                    ReportType = "PowerTrainData";
                    DataTable dataTable_PowerTrainData = new DataTable();
                    if (intWeekNumber > 0)
                    {
                         dataTable_PowerTrainData = gd.GetDashBoardData(intVinID, intWeekNumber, intYearNumber, ReportType);
                    }
                    else
                    {
                         dataTable_PowerTrainData = gd.GetDashBoardData(intVinID, dtProcessDate, ReportType);
                    }


                  
                        ReportType = "DailyChargingData";
                        DataTable dataTable_DailyChargingData = new DataTable();
                        if (intWeekNumber > 0)
                        {
                            dataTable_DailyChargingData = gd.GetDashBoardDataTabular(intVinID, intWeekNumber, intYearNumber, ReportType);
                        }
                        else
                        {
                            // dataTable_OperationalData = gd.GetDashBoardDataTabular(intVinID, dtProcessDate, ReportType);
                        }

                       
                            GV_DailyChargingData.Visible = true;
                            GV_DailyChargingData.DataSource = dataTable_DailyChargingData;
                            GV_DailyChargingData.DataBind();



                            ReportType = "DailyTempData";
                            DataTable dataTable_DailyTempData = new DataTable();
                            if (intWeekNumber > 0)
                            {
                                dataTable_DailyTempData = gd.GetDashBoardDataTabular(intVinID, intWeekNumber, intYearNumber, ReportType);
                            }
                            else
                            {
                                // dataTable_OperationalData = gd.GetDashBoardDataTabular(intVinID, dtProcessDate, ReportType);
                            }


                            GV_DailyTempData1.Visible = true;
                            GV_DailyTempData1.DataSource = dataTable_DailyTempData;
                           GV_DailyTempData1.DataBind();
                        


                    GridView1.DataSource = dataTable_OperationalData;
                    GridView1.DataBind();

                    GridView3.DataSource = dataTable_HVACOperationMode;
                    GridView3.DataBind();
                                        
                    GridView4.DataSource = dataTable_AuxLoadsOnTime;
                    GridView4.DataBind();
                    
                    GridView5.DataSource = dataTable_PowerTrainData;
                    GridView5.DataBind();
                    
                    lblVin.InnerHtml = "<b>" + Vehicle.CustomerName + " - " + Vehicle.Vin;
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                     lblDate.InnerHtml = "<b>" + DtRangeWeekly;
                    }
                    else
                    { 
                    lblDate.InnerHtml = "<b>" + dtProcessDate.ToShortDateString();
                     }

                }
                else
                {
                    Response.Write(" Vehicle does not exists!");
                    Response.End();
                }

            }
            else
            {
                Response.Write(" Vehicle does not exists!");
                Response.End();
            }



        

            //switch (ReportType)
            //{

            //    case "TempData":
            //        ReportServices_DailyGrab_VinDashBoard_OperationalData(Vehicle, dtProcessDate);
            //        break;
             
            //    default:
            //        Response.Write(" Chart Type does not exists!");
            //        break;
            //}



        

        }
    }
}