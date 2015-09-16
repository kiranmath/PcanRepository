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
    public partial class GenerateTable_VinDashboard_Tabular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string VinID = Request.QueryString["VinID"].ToString();
            //string ProcessDate = Request.QueryString["ProcessDate"].ToString();
            //string ReportPeriod = Request.QueryString["ReportPeriod"].ToString();

            //string ReportType = Request.QueryString["ReportType"].ToString();



            //string WeekNumber = Request.QueryString["WeekNumber"].ToString();
            //string YearNumber = Request.QueryString["YearNumber"].ToString();

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
            if (ReportPeriod == "Weekly")
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
                   

                    DataTable dataTable_TempData = new DataTable();

                    if (intWeekNumber > 0)
                    {
                        dataTable_TempData = gd.GetDashBoardDataTabular(intVinID, intWeekNumber, intYearNumber, ReportType);
                    }
                    else
                    {
                        dataTable_TempData = gd.GetDashBoardDataTabular(intVinID, dtProcessDate, ReportType);
                    }

                    if (ReportType == "DailyChargingData")
                    {
                        GV_DailyChargingData.Visible = true;
                        GV_DailyChargingData.DataSource = dataTable_TempData;
                        GV_DailyChargingData.DataBind();
                    }

                    if (ReportType == "DailyTempData")
                    {
                        GV_DailyTempData.Visible = true;
                        GV_DailyTempData.DataSource = dataTable_TempData;
                        GV_DailyTempData.DataBind();
                    }

                    if (ReportType == "DailyBatteryData")
                    {
                        GV_DailyBatteryData.Visible = true;
                        GV_DailyBatteryData.DataSource = dataTable_TempData;
                        GV_DailyBatteryData.DataBind();
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








        }

      
    }
}