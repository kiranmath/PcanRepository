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
    public partial class GenerateReport : System.Web.UI.Page
    {
        int Rounding = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            string VinID = Request.QueryString["VinID"].ToString();
            string ProcessDate = Request.QueryString["ProcessDate"].ToString();
            string ReportType = Request.QueryString["ReportType"].ToString();


            //VinID = "221";
            //  ReportType = "GenVehicleData_VinSpeed";
            //ReportType = "GenVehicleData_CurrentVoltage";
            //ProcessDate = "04/13/2015";
            DateTime dtProcessDate = DateTime.Parse(ProcessDate);


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

            switch (ReportType)
            {
                case "GenVehicleData_SoC":
                    ReportServices_DailyGrab_GenVehicleData_SOC(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_SoCByPacks_Min":
                    ReportServices_DailyGrab_GenVehicleData_SOCByPacks(Vehicle, dtProcessDate, "MinSoC");
                    break;
                case "GenVehicleData_SoCByPacks_Max":
                    ReportServices_DailyGrab_GenVehicleData_SOCByPacks(Vehicle, dtProcessDate, "MaxSoC");
                    break;
                case "GenVehicleData_TMaxByPacks":
                    ReportServices_DailyGrab_GenVehicleData_TMaxByPacks(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_CurrentByPacks":
                    ReportServices_DailyGrab_GenVehicleData_CurrentByPacks(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_VinSpeed":
                    ReportServices_DailyGrab_GenVehicleData_VinSpeed(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_CurrentVoltage":
                    ReportServices_DailyGrab_GenVehicleData_CurrentVoltage(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_SoCEnergy":
                    ReportServices_DailyGrab_GenVehicleData_SOCEnergy(Vehicle, dtProcessDate);
                    break;
                case "GenVehicleData_VinSpeedHist":
                    ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicle, dtProcessDate);
                    break;


                default:
                    Response.Write(" Chart Type does not exists!");
                    break;
            }


        }

        private void ReportServices_DailyGrab_GenVehicleData_CurrentVoltage(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetSoC(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Current Voltage Daily - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Current/Voltage") });
            //   hcVendas.YAxis.Add(new YAxisItem { title = new Title("Energy") });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionCurrent = new PointCollection();
            var pointCollectionVoltage = new PointCollection();
            //var pointCollectionEnergy = new PointCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionCurrent.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCtm_uin_Current_a"])));
                pointCollectionVoltage.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCtm_uin_Voltage_v"])));
                //  pointCollectionEnergy.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["Pt_Energy"])));

                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie



            var series = new SerieCollection();

            series.Add(new Serie { id = "Current", name = "Current", type = RenderType.spline, yAxis = 0, data = pointCollectionCurrent.ToArray() });
            series.Add(new Serie { id = "Voltage", name = "Voltage", type = RenderType.spline, yAxis = 0, data = pointCollectionVoltage.ToArray() });
            //   series.Add(new Serie { id = "Energy", name = "Energy", type = RenderType.spline, yAxis=1, data = pointCollectionEnergy.ToArray() });

            //  series.Add(new Serie { id = "ScoopHeater", name = "ScoopHeater", type = RenderType.spline, data = pointCollectionScoopHeater.ToArray() });

            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };

            // var series = new Collection<Serie> { new Serie { name = "VinSpeed", data = pointCollectionVinSpeed.ToArray(), type = RenderType.scatter }, new Serie { name = "Charging", type = RenderType.scatter, data = pointCollectionCharging.ToArray() }, new Serie { name = "ScoopHeater", type = RenderType.scatter, data = pointCollectionScoopHeater.ToArray() } };

            // hcVendas.PlotOptions = new PlotOptionsScatter { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };

            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSpeed(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetSoC(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vin Speed Daily - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Speed in MPH") });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionVinSpeed = new PointCollection();
            var pointCollectionCharging = new PointCollection();
            var pointCollectionScoopHeater = new PointCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinSpeed.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpt_int_Spd_mph"])));
                pointCollectionCharging.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_ChargeEnable_xx"])));
                pointCollectionScoopHeater.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_bo_ScoopHeaterOn"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie



            var series = new SerieCollection();

            series.Add(new Serie { id = "VinSpeed", name = "VinSpeed", type = RenderType.spline, data = pointCollectionVinSpeed.ToArray() });
            series.Add(new Serie { id = "Charging", name = "Charging", color = "red", type = RenderType.spline, data = pointCollectionCharging.ToArray() });
            series.Add(new Serie { id = "ScoopHeater", name = "ScoopHeater", type = RenderType.spline, data = pointCollectionScoopHeater.ToArray() });

            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };

            // var series = new Collection<Serie> { new Serie { name = "VinSpeed", data = pointCollectionVinSpeed.ToArray(), type = RenderType.scatter }, new Serie { name = "Charging", type = RenderType.scatter, data = pointCollectionCharging.ToArray() }, new Serie { name = "ScoopHeater", type = RenderType.scatter, data = pointCollectionScoopHeater.ToArray() } };

            // hcVendas.PlotOptions = new PlotOptionsScatter { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };

            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();

        }

        private void ReportServices_DailyGrab_GenVehicleData_SOC(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetSoC(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Soc Daily - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("SoC %") });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionSocMin = new PointCollection();
            var pointCollectionSocMax = new PointCollection();
            var pointCollectionSocDas = new PointCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionSocMin.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmin_pct"])));
                pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            var series = new Collection<Serie> { new Serie { name = "SocMin", data = pointCollectionSocMin.ToArray() }, new Serie { name = "SocMax", data = pointCollectionSocMax.ToArray() }, new Serie { name = "SocDash", data = pointCollectionSocDas.ToArray() } };
            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };


            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_SOCEnergy(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetSoC(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Soc Energy Daily - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";

            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("SoC %") });
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Energy") });
            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionSocMin = new PointCollection();
            var pointCollectionSocMax = new PointCollection();
            var pointCollectionSocDas = new PointCollection();
            var pointCollectionEnergy = new PointCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionSocMin.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmin_pct"])));
                pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                pointCollectionEnergy.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["Pt_Energy"])));



                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            var series = new Collection<Serie> { new Serie { name = "SocMin", yAxis = 0, data = pointCollectionSocMin.ToArray() }, new Serie { name = "SocMax", data = pointCollectionSocMax.ToArray() }, new Serie { name = "SocDash", yAxis = 0, data = pointCollectionSocDas.ToArray() } };
            series.Add(new Serie { id = "Energy", name = "Energy", type = RenderType.spline, yAxis = 1, data = pointCollectionEnergy.ToArray() });

            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };


            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenSpeedHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Speed Band  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Time in Mins") });

            //  hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = new[] { "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002" } });


            //   hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionVinSpeed = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> revenues = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinSpeed.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                revenues.Add(row["BucketName"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = revenues.ToArray(), labels = (new Labels() { rotation = -90, step = 1, y = 20 }) });


            var series = new Collection<Serie> { new Serie { name = "VinSpeed", data = pointCollectionVinSpeed.ToArray(), type = RenderType.column } };
            series.Add(new Serie { name = "VinSpeed2", data = pointCollectionVinSpeed.ToArray(), type = RenderType.spline });
            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };





            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();


        }




        private void ReportServices_DailyGrab_GenVehicleData_SOCByPacks(Vehicles v, DateTime dt, string dtype)
        {

            string dtypeLabel = string.Empty;

            if (dtype == "MinSoC")
            {
                dtypeLabel = " Min ";
            }
            else if (dtype == "MaxSoC")
            {
                dtypeLabel = " Max ";
            }


            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetSoCbyPacks(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Soc {0}  Daily - {1}", dtypeLabel, dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);
          
            hcVendas.Theme = "grid";
     
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title(string.Format("Soc {0}  % ", dtypeLabel)), minorGridLineWidth = 0, gridLineWidth = 0 });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionSocMin = new PointCollection();
            var pointCollectionSocMinPack0 = new PointCollection();
            var pointCollectionSocMinPack1 = new PointCollection();
            var pointCollectionSocMinPack2 = new PointCollection();
            var pointCollectionSocMinPack3 = new PointCollection();
            var pointCollectionSocMinPack4 = new PointCollection();
            var pointCollectionSocMinPack5 = new PointCollection();
            var pointCollectionSocMinPack6 = new PointCollection();
            var pointCollectionSocMinPack7 = new PointCollection();

            var pointCollectionSocMax = new PointCollection();
            var pointCollectionSocMaxPack0 = new PointCollection();
            var pointCollectionSocMaxPack1 = new PointCollection();
            var pointCollectionSocMaxPack2 = new PointCollection();
            var pointCollectionSocMaxPack3 = new PointCollection();
            var pointCollectionSocMaxPack4 = new PointCollection();
            var pointCollectionSocMaxPack5 = new PointCollection();
            var pointCollectionSocMaxPack6 = new PointCollection();
            var pointCollectionSocMaxPack7 = new PointCollection();

           

            foreach (DataRow row in dataTable.Rows)
            {

                if (dtype == "MinSoC")
                {
                    // pointCollectionSocMin.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCMin_pct"])));
                         //.pointCollectionSocMin.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmin_pct"])));
                    pointCollectionSocMinPack0.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm0_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack1.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm1_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack2.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm2_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack3.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm3_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack4.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm4_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack5.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm5_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack6.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm6_usi_SoCMin_pct"])));
                    pointCollectionSocMinPack7.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm7_usi_SoCMin_pct"]),System.Drawing.Color.Black));


                    //pointCollectionSocMinPack0.Add(new Point(Convert.ToInt64(1), Convert.ToDouble(row["PCpm0_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack1.Add(new Point(Convert.ToInt64(2), Convert.ToDouble(row["PCpm1_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack2.Add(new Point(Convert.ToInt64(3), Convert.ToDouble(row["PCpm2_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack3.Add(new Point(Convert.ToInt64(4), Convert.ToDouble(row["PCpm3_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack4.Add(new Point(Convert.ToInt64(5), Convert.ToDouble(row["PCpm4_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack5.Add(new Point(Convert.ToInt64(6), Convert.ToDouble(row["PCpm5_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack6.Add(new Point(Convert.ToInt64(7), Convert.ToDouble(row["PCpm6_usi_SoCMin_pct"])));
                    //pointCollectionSocMinPack7.Add(new Point(Convert.ToInt64(8), Convert.ToDouble(row["PCpm7_usi_SoCMin_pct"])));

                }
                    

                else if (dtype == "MaxSoC")
                {

                    // pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCMax_pct"])));


                    pointCollectionSocMaxPack0.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm0_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack1.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm1_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack2.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm2_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack3.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm3_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack4.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm4_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack5.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm5_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack6.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm6_usi_SoCMax_pct"])));
                    pointCollectionSocMaxPack7.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm7_usi_SoCMax_pct"])));

                }




            }

            //Add data to serie

            if (dtype == "MinSoC")
            {

                var seriesMin = new Collection<Serie> { 
                   //  new Serie { name = "SocMin", data = pointCollectionSocMin.ToArray() },
                     new Serie { name = "P0", data = pointCollectionSocMinPack0.ToArray() }, 
                     new Serie { name = "P1", data = pointCollectionSocMinPack1.ToArray() }, 
                     new Serie { name = "P2", data = pointCollectionSocMinPack2.ToArray() }, 
                     new Serie { name = "P3", data = pointCollectionSocMinPack3.ToArray() }, 
                     new Serie { name = "P4", data = pointCollectionSocMinPack4.ToArray() }, 
                     new Serie { name = "P5", data = pointCollectionSocMinPack5.ToArray() }, 
                     new Serie { name = "P6", data = pointCollectionSocMinPack6.ToArray() },                  
                     new Serie { name = "P7", data = pointCollectionSocMinPack7.ToArray(),color="Grey" } 
                 };

                hcVendas.DataSource = seriesMin;

            }
            else if (dtype == "MaxSoC")
            {

                var seriesMax = new Collection<Serie> { 
                     //new Serie { name = "SocMax", data = pointCollectionSocMax.ToArray() },
                     new Serie { name = "P0", data = pointCollectionSocMaxPack0.ToArray() }, 
                     new Serie { name = "P1", data = pointCollectionSocMaxPack1.ToArray() }, 
                     new Serie { name = "P2", data = pointCollectionSocMaxPack2.ToArray() }, 
                     new Serie { name = "P3", data = pointCollectionSocMaxPack3.ToArray() }, 
                     new Serie { name = "P4", data = pointCollectionSocMaxPack4.ToArray() }, 
                     new Serie { name = "P5", data = pointCollectionSocMaxPack5.ToArray() }, 
                     new Serie { name = "P6", data = pointCollectionSocMaxPack6.ToArray() },                  
                     new Serie { name = "P7", data = pointCollectionSocMaxPack7.ToArray() ,color="Grey" } 
                 };

                hcVendas.DataSource = seriesMax;
            }



            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false }};


            //Bind the control         
            hcVendas.DataBind();


        }


        private void ReportServices_DailyGrab_GenVehicleData_TMaxByPacks(Vehicles v, DateTime dt)
        {


            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetTMaxbyPacks(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Tmax  Daily - {0}",  dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Tmax C "), minorGridLineWidth = 0, gridLineWidth = 0 });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionTmax = new PointCollection();
            var pointCollectionTmaxPack0 = new PointCollection();
            var pointCollectionTmaxPack1 = new PointCollection();
            var pointCollectionTmaxPack2 = new PointCollection();
            var pointCollectionTmaxPack3 = new PointCollection();
            var pointCollectionTmaxPack4 = new PointCollection();
            var pointCollectionTmaxPack5 = new PointCollection();
            var pointCollectionTmaxPack6 = new PointCollection();
            var pointCollectionTmaxPack7 = new PointCollection();



            foreach (DataRow row in dataTable.Rows)
            {


                // pointCollectionTmax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_Tmax_pct"])));
                pointCollectionTmaxPack0.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm0_usi_Tmax_c"])));
                pointCollectionTmaxPack1.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm1_usi_Tmax_c"])));
                pointCollectionTmaxPack2.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm2_usi_Tmax_c"])));
                pointCollectionTmaxPack3.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm3_usi_Tmax_c"])));
                pointCollectionTmaxPack4.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm4_usi_Tmax_c"])));
                pointCollectionTmaxPack5.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm5_usi_Tmax_c"])));
                pointCollectionTmaxPack6.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm6_usi_Tmax_c"])));
                pointCollectionTmaxPack7.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm7_usi_Tmax_c"])));


            }






            //Add data to serie



            var series = new Collection<Serie> { 
                   //  new Serie { name = "Tmax", data = pointCollectionTmax.ToArray() },
                     new Serie { name = "P0", data = pointCollectionTmaxPack0.ToArray() }, 
                     new Serie { name = "P1", data = pointCollectionTmaxPack1.ToArray() }, 
                     new Serie { name = "P2", data = pointCollectionTmaxPack2.ToArray() }, 
                     new Serie { name = "P3", data = pointCollectionTmaxPack3.ToArray() }, 
                     new Serie { name = "P4", data = pointCollectionTmaxPack4.ToArray() }, 
                     new Serie { name = "P5", data = pointCollectionTmaxPack5.ToArray() }, 
                     new Serie { name = "P6", data = pointCollectionTmaxPack6.ToArray() },                  
                     new Serie { name = "P7", data = pointCollectionTmaxPack7.ToArray() ,color="Grey"} 
                 };


            hcVendas.DataSource = series;






            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };


            //Bind the control         
            hcVendas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_CurrentByPacks(Vehicles v, DateTime dt)
        {


            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetCurrentbyPacks(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Current  Daily - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcVendas.Title = new Title(mainTitle);
            hcVendas.SubTitle = new SubTitle(subTitle);

            hcVendas.Theme = "grid";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcVendas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcVendas.YAxis.Add(new YAxisItem { title = new Title("Current Amps "), minorGridLineWidth = 0, gridLineWidth = 0 });

            hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" }, title = new Title("Time in Hours") });


            hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat('%H:%M', this.x) +': '+ this.y");

            //Get point collection
            var pointCollectionCurrent = new PointCollection();
            var pointCollectionCurrentPack0 = new PointCollection();
            var pointCollectionCurrentPack1 = new PointCollection();
            var pointCollectionCurrentPack2 = new PointCollection();
            var pointCollectionCurrentPack3 = new PointCollection();
            var pointCollectionCurrentPack4 = new PointCollection();
            var pointCollectionCurrentPack5 = new PointCollection();
            var pointCollectionCurrentPack6 = new PointCollection();
            var pointCollectionCurrentPack7 = new PointCollection();



            foreach (DataRow row in dataTable.Rows)
            {


                // pointCollectionCurrent.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_Current_pct"])));
                pointCollectionCurrentPack0.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm0_uin_PackI_a"])));
                pointCollectionCurrentPack1.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm1_uin_PackI_a"])));
                pointCollectionCurrentPack2.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm2_uin_PackI_a"])));
                pointCollectionCurrentPack3.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm3_uin_PackI_a"])));
                pointCollectionCurrentPack4.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm4_uin_PackI_a"])));
                pointCollectionCurrentPack5.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm5_uin_PackI_a"])));
                pointCollectionCurrentPack6.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm6_uin_PackI_a"])));
                pointCollectionCurrentPack7.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCpm7_uin_PackI_a"])));


            }






            //Add data to serie



            var series = new Collection<Serie> { 
                   //  new Serie { name = "Current", data = pointCollectionCurrent.ToArray() },
                     new Serie { name = "P0", data = pointCollectionCurrentPack0.ToArray() }, 
                     new Serie { name = "P1", data = pointCollectionCurrentPack1.ToArray() }, 
                     new Serie { name = "P2", data = pointCollectionCurrentPack2.ToArray() }, 
                     new Serie { name = "P3", data = pointCollectionCurrentPack3.ToArray() }, 
                     new Serie { name = "P4", data = pointCollectionCurrentPack4.ToArray() }, 
                     new Serie { name = "P5", data = pointCollectionCurrentPack5.ToArray() }, 
                     new Serie { name = "P6", data = pointCollectionCurrentPack6.ToArray() },                  
                     new Serie { name = "P7", data = pointCollectionCurrentPack7.ToArray(),color="Grey" } 
                 };


            hcVendas.DataSource = series;






            hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = false }, dataLabels = new DataLabels { enabled = false } };


            //Bind the control         
            hcVendas.DataBind();


        }

    }
}
