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
    public partial class GenerateCoverPage : System.Web.UI.Page
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
                lblHead.InnerHtml = "<br/><br/><b>Weekly Vehicle Report";
            }
            else if (ReportPeriod == "NREL")
            {
                lblHead.InnerHtml = "<br/><br/><b>NREL Weekly Vehicle Report";
            }

            else if (ReportPeriod == "DailyBattery")
            {
                lblHead.InnerHtml = "<br/><br/><b>Daily Battery Report";
            }

            else
            {
                lblHead.InnerHtml = "<br/><br/><b>Daily Vehicle Report";
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

                    lblVin.InnerHtml = "<br/><br/><b>" + Vehicle.CustomerName + "  -  " + Vehicle.Vin;
                    if (ReportPeriod == "Weekly")
                    {
                     lblDate.InnerHtml = "<br/><br/><b>Report Dates: " + DtRangeWeekly;
                    }
                    else if (ReportPeriod == "NREL")
                    {
                        lblDate.InnerHtml = "<br/><br/><b>Report Dates: " + DtRangeWeekly;
                    }
                    else if (ReportPeriod == "DailyBattery")
                    {
                        lblDate.InnerHtml = "<br/><br/><b>Report Dates: " + dtProcessDate.ToShortDateString();
                    }
                    else
                    {
                        lblDate.InnerHtml = "<br/><br/><b>Report Date: " + dtProcessDate.ToShortDateString();
                    }

                }
                else
                {
                    lblVin.InnerHtml = "<br/><br/><b>" + " Vehicle does not exists!";
                    Response.End();
                }


            }
            else
            {
                lblVin.InnerHtml = "<b>" + " Vehicle does not exists!";
                Response.End();
            }




            //VinID = "221";
            //  ReportType = "GenVehicleData_VinSpeed";
            //ReportType = "GenVehicleData_CurrentVoltage";
            //ProcessDate = "04/13/2015";
           

        }
    }
}