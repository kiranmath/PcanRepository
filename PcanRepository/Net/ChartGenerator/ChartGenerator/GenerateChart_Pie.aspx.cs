using System;
using System.Data;
using System.Collections.ObjectModel;
using Highcharts.Core;
using Highcharts.Core.Appearance;
using Highcharts.Core.Data.Chart;
using Highcharts.Core.PlotOptions;
using System.Collections.Specialized;
using System.Collections.Generic;
namespace ChartGenerator
{
    public partial class GenerateChart_Pie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //int ChargingStationID = 18;
            //int Rounding = 0;
            //DateTime dt = DateTime.Parse("07/29/2015");
            //int WeekNumber = 31;
            //int YearNumer = 2015;


            int intWeekNumber = 0;
            int intYearNumber = 0;
            int intChargingStationID = 0;

            string ChargingStationID = Request.QueryString["ChargingStationID"].ToString();

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








            Chargers Charger = new Chargers();

            if (ChargingStationID != "")
            {

                bool IsChargerNumeric = int.TryParse(ChargingStationID, out intChargingStationID);

                if (IsChargerNumeric)
                {
                    intChargingStationID = int.Parse(ChargingStationID);

                    GetChartData gcd = new GetChartData();

                    Charger = gcd.GetChargerInfo(intChargingStationID);

                }


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

                if (ReportType == "ChargerStatus")
                {

                    Display_ChargingStatus_All(Charger, intWeekNumber, intYearNumber);
                }
                else if (ReportType == "ChargerFails")
                {
                    Display_ChargingStatus_Faults(Charger, intWeekNumber, intYearNumber);
                }


            }
        }

        private void Display_ChargingStatus_All(Chargers Charger, int WeekNumer, int YearNumer)
        {
            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Ct_GetWeeklyChargingStatus(Charger.ChargingStationID, WeekNumer, YearNumer);

            //  string mainTitle = string.Format("Vehicle Efficiency  - {0}", dt.ToString("MM/dd/yy"));
            //  string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            string mainTitle = Charger.Location.ToUpper().ToString() + " - Charger Status";
            string subTitle = "Week Number " + WeekNumer + ", " + YearNumer;

            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            //   hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method

            Int32 totalArraySize = dataTable.Rows.Count;
            Object[] XAxisData = new object[totalArraySize];
            Object[] YAxisServices = new object[totalArraySize];
            int J = 0;
            foreach (DataRow drRow in dataTable.Rows)
            {

                YAxisServices[J] = new object[] { drRow[0].ToString(), Convert.ToInt32(drRow[1].ToString()) };
                J += 1;
            }




            SerieCollection series = new SerieCollection();
            Serie serieServices = new Serie();
            serieServices.size = 150;
            // serieServices.cumulative = -0.25;
            serieServices.data = YAxisServices;
            serieServices.type = RenderType.pie;
            serieServices.name = "";
            serieServices.showInLegend = false;
            series.Add(serieServices);

            hcFrutas.PlotOptions = new Highcharts.Core.PlotOptions.PlotOptionsPie
            {
                allowPointSelect = true,
                cursor = "pointer",

                startAngle = 60,
                dataLabels = new Highcharts.Core.PlotOptions.DataLabels { enabled = true, formatter = "this.point.name +': ['+ this.y  + ']'" },
                animation = false
            };

            hcFrutas.Tooltip = new ToolTip("this.point.name +': '+ this.y ");
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();
            hcFrutas.Dispose();

        }

        private void Display_ChargingStatus_Faults(Chargers Charger, int WeekNumer, int YearNumer)
        {
            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Ct_GetWeeklyChargingFails(Charger.ChargingStationID, WeekNumer, YearNumer);

            //  string mainTitle = string.Format("Vehicle Efficiency  - {0}", dt.ToString("MM/dd/yy"));
            //  string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            string mainTitle = Charger.Location.ToUpper().ToString() + " - Charger Fails";
            string subTitle = "Week Number " + WeekNumer + ", " + YearNumer;

            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            //   hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method

            Int32 totalArraySize = dataTable.Rows.Count;
            Object[] XAxisData = new object[totalArraySize];
            Object[] YAxisServices = new object[totalArraySize];
            int J = 0;
            foreach (DataRow drRow in dataTable.Rows)
            {

                YAxisServices[J] = new object[] { drRow[0].ToString(), Convert.ToInt32(drRow[1].ToString()) };
                J += 1;
            }




            SerieCollection series = new SerieCollection();
            Serie serieServices = new Serie();
            serieServices.size = 150;
            // serieServices.cumulative = -0.25;
            serieServices.data = YAxisServices;
            serieServices.type = RenderType.pie;
            serieServices.name = "";
            serieServices.showInLegend = false;
            series.Add(serieServices);

            hcFrutas.PlotOptions = new Highcharts.Core.PlotOptions.PlotOptionsPie
            {
                allowPointSelect = true,
                cursor = "pointer",

                startAngle = 60,
                dataLabels = new Highcharts.Core.PlotOptions.DataLabels { enabled = true, formatter = "this.point.name +': ['+ this.y  + ']'" },
                animation = false
            };

            hcFrutas.Tooltip = new ToolTip("this.point.name +': '+ this.y ");
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();
            hcFrutas.Dispose();

        }
    }
}