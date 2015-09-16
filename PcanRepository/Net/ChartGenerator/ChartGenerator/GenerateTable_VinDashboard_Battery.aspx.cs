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
    public partial class GenerateTable_VinDashboard_Battery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string ProcessDate = String.Empty;
            DateTime dtProcessDate = DateTime.Today;

            
            int CustomerID = int.Parse(Request.QueryString["CustomerID"].ToString());

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

           // dtProcessDate = DateTime.Parse("9/1/2015");

            GetChartData gd = new GetChartData();
            DataTable dataTable_TempData = new DataTable();
            dataTable_TempData = gd.Dt_DailyGrab_GetBatteryDash(dtProcessDate, CustomerID, 0);


            if (ReportType == "DailyBatteryData")
            {
                gvBattery.Visible = true;
                gvBattery.DataSource = dataTable_TempData;
                gvBattery.DataBind();
            }

            string custName=string.Empty;
                //string custName = (from DataRow dr in dataTable_TempData.Rows
                //  where dr["RowID"] == "1"
                //  select (string)dr["RowID"]).FirstOrDefault();


            DataRow[] oRows = null;

            oRows = dataTable_TempData.Select("RowID=1");

            if (oRows.Count() == 0)
            {
                // No rows found
            }
            else
            {
                custName = oRows[0][3].ToString();
                // At least one row found. Could be more than one
            }

                CustName.InnerHtml = custName;
        }
    }
}