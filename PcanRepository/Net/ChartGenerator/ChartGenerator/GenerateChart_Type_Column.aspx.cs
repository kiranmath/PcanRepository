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
    public partial class GenerateChart_Type_Column : System.Web.UI.Page
    {
        int Rounding = 0;
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




            //string ReportType = Request.QueryString["ReportType"].ToString();
            //string ReportPeriod = Request.QueryString["ReportPeriod"].ToString();
            //string WeekNumber = Request.QueryString["WeekNumber"].ToString();
            //string YearNumber = Request.QueryString["YearNumber"].ToString();

            
            
            //VinID = "221";
            //  ReportType = "GenVehicleData_VinSpeed";
            //ReportType = "GenVehicleData_CurrentVoltage";
            //ProcessDate = "04/13/2015";
            //DateTime dtProcessDate = DateTime.Parse(ProcessDate);


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

                case "GenVehicleData_VinSpeedHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicle, dtProcessDate);
                    }

                    break;                 
                  


                case "GenVehicleData_VinEfficiencyHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinEfficiencyHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinEfficiencyHist(Vehicle, dtProcessDate);
                    }

                    break;     


                case "GenVehicleData_VinAccelPedalHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinAccelPedalHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinAccelPedalHist(Vehicle, dtProcessDate);
                    }

                    break;     

                case "GenVehicleData_VinBrakePedalHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBrakePedalHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBrakePedalHist(Vehicle, dtProcessDate);
                    }

                    break;    

                case "GenVehicleData_VinChargingHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinChargingHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinChargingHist(Vehicle, dtProcessDate);
                    }

                    break;    

                case "GenVehicleData_VinVoltageHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinVoltageHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinVoltageHist(Vehicle, dtProcessDate);
                    }

                    break;    

                case "GenVehicleData_VinSocMinHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinSocMinHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinSocMinHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinBatteryTempMaxHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBatteryTempMaxHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBatteryTempMaxHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinPECoolantTempHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinPECoolantTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinPECoolantTempHist(Vehicle, dtProcessDate);
                    }

                    break;    

                case "GenVehicleData_VinDCDCConverterPowerHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinDCDCConverterPowerHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinDCDCConverterPowerHist(Vehicle, dtProcessDate);
                    }

                    break;    

                case "GenVehicleData_VinTractionMotorRotorTempHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorRotorTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorRotorTempHist(Vehicle, dtProcessDate);
                    }

                    break;    



                case "GenVehicleData_VinStatorTempHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinStatorTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinStatorTempHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinTractionMotorInverterTempHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorInverterTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorInverterTempHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinTractionMotorIGBTTempHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorIGBTTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTractionMotorIGBTTempHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinRadiatorFanSpeedHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinRadiatorFanSpeedHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinRadiatorFanSpeedHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinBatteryCoolantPumpHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBatteryCoolantPumpHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinBatteryCoolantPumpHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinMinAirPressureHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinMinAirPressureHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinMinAirPressureHist(Vehicle, dtProcessDate);
                    }

                    break;    


                case "GenVehicleData_VinTransTempHist":
                     if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTransTempHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinTransTempHist(Vehicle, dtProcessDate);
                    }

                    break;



                case "GenVehicleData_VinChgEnergyHist":
                    if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                    {
                        ReportServices_DailyGrab_GenVehicleData_VinChgEnergyHist(Vehicle, intWeekNumber, intYearNumber);
                    }
                    else
                    {
                        //do nothing 
                    }

                    break;    


                default:
                    Response.Write(" Chart Type does not exists!");
                    break;
            }
                

        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenSpeedHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Speed Band  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinSpeed = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinSpeed.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });

            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Speed") });
          
            var series = new Collection<Serie> { new Serie { name = "% of Time", data = pointCollectionVinSpeed.ToArray(), type = RenderType.column,showInLegend=false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();
        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinEfficiencyHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenEfficiencyHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Efficiency  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinEfficiency.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear,  categories = buckets.ToArray(),tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });


            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Efficiency") });
            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionVinEfficiency.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinAccelPedalHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenAccelPedalHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Accel Pedal  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinEfficiency.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear,  categories = buckets.ToArray(),tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Accel Pedal") });

            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionVinEfficiency.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinBrakePedalHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBrakePedalHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Brake Pedal  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
           // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Brake Pedal") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinChargingHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenChargingHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Vehicle Charging  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Occurence") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Charinging Time in Min") });



            var series = new Collection<Serie> { new Serie { name = "Counts", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinVoltageHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenVoltageHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Voltage  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Voltage") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSocMinHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenSocMinHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Soc Minimum  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Soc Min") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinBatteryTempMaxHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBatteryTempMaxHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Battery Temp Max  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Battery Temp Max") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinPECoolantTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenPECoolantTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("PE Coolant Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("PE Coolant Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinDCDCConverterPowerHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenDCDCConverterPowerHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("DC-DC Converter Power  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("DC-DC Converter Power") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinStatorTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenStatorTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Stator Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Stator Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorRotorTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorRotorTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Traction Motor Rotor Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor Rotor Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorInverterTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorInverterTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Traction Motor Inverter Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor Invertor Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorIGBTTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorIGBTTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Traction Motor IGBT Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor IGBT Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinRadiatorFanSpeedHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenRadiatorFanSpeedHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Radiator Fan Speed  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Radiator Fan Speed") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinBatteryCoolantPumpHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBatteryCoolantPumpHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Battery Coolant Pump  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Battery Coolant Pump") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinMinAirPressureHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenMinAirPressureHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Min Air Pressure  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Min Air Pressure") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinTransTempHist(Vehicles v, DateTime dt)
        {

            GetChartData gd = new GetChartData();
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTransTempHist(v.VinID, dt, Rounding);

            string mainTitle = string.Format("Trans Temp  - {0}", dt.ToString("MM/dd/yy"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Trans Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSpeedHist(Vehicles v, int WeekNumber, int YearNumber)
        {


            GetChartData gd = new GetChartData();

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenSpeedHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Vehicle Speed - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);
            



            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinSpeed = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();
            // Add string using Add method

            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinSpeed.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });

            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Speed") });

            var series = new Collection<Serie> { new Serie { name = "% of Time", data = pointCollectionVinSpeed.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();
        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinEfficiencyHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenEfficiencyHist(v.VinID, WeekNumber, YearNumber, Rounding);
              
            string mainTitle = string.Format("Vehicle Efficiency - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinEfficiency.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear,  categories = buckets.ToArray(),tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });


            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Efficiency") });
            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionVinEfficiency.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinAccelPedalHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenAccelPedalHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Vehicle Accel Pedal - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
          

            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionVinEfficiency = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionVinEfficiency.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            //hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear,  categories = buckets.ToArray(),tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Accel Pedal") });

            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionVinEfficiency.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinBrakePedalHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBrakePedalHist(v.VinID, WeekNumber, YearNumber, Rounding);

 
            string mainTitle = string.Format("Vehicle Brake Pedal - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
          
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Brake Pedal") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinChargingHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenChargingHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Vehicle Charging - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
          

            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Occurence") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Charinging Time in Min") });



            var series = new Collection<Serie> { new Serie { name = "Counts", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinVoltageHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();    

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenVoltageHist(v.VinID, WeekNumber, YearNumber, Rounding);
            string mainTitle = string.Format("Voltage - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));
          


            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Voltage") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinSocMinHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();   
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenSocMinHist(v.VinID, WeekNumber, YearNumber, Rounding);
            string mainTitle = string.Format("Soc Minimum - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));

            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Soc Min") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinBatteryTempMaxHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
  

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBatteryTempMaxHist(v.VinID, WeekNumber, YearNumber, Rounding);
            string mainTitle = string.Format("Soc Minimum - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));


            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Battery Temp Max") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinPECoolantTempHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenPECoolantTempHist(v.VinID, WeekNumber, YearNumber, Rounding);
            string mainTitle = string.Format("PE Coolant Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));



            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("PE Coolant Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinDCDCConverterPowerHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenDCDCConverterPowerHist(v.VinID, WeekNumber, YearNumber, Rounding);
            string mainTitle = string.Format("DC-DC Converter Power - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));





       
            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("DC-DC Converter Power") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorRotorTempHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorRotorTempHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Traction Motor Rotor Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));


            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);




            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor Rotor Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinStatorTempHist(Vehicles v,int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenStatorTempHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Stator Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));




            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Stator Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorInverterTempHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
       
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorInverterTempHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Traction Motor Inverter Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));




            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor Invertor Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinTractionMotorIGBTTempHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
            
            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTractionMotorIGBTTempHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Traction Motor IGBT Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));




            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Traction Motor IGBT Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

        private void ReportServices_DailyGrab_GenVehicleData_VinRadiatorFanSpeedHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();   

            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenRadiatorFanSpeedHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Radiator Fan Speed - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));







            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Radiator Fan Speed") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }
        
        private void ReportServices_DailyGrab_GenVehicleData_VinBatteryCoolantPumpHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();



            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenBatteryCoolantPumpHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Battery Coolant Pump - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));








            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Battery Coolant Pump") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }


        private void ReportServices_DailyGrab_GenVehicleData_VinMinAirPressureHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
           


            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenMinAirPressureHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Min Air Pressure - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));






            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Min Air Pressure") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }


        private void ReportServices_DailyGrab_GenVehicleData_VinTransTempHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();
          


            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber,YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenTransTempHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Trans Temp - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));



            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Time Percentage") });


            //Get point collection
            var pointCollectionBrakePedal = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionBrakePedal.Add(new Point(Convert.ToDouble(row["TimeInMins"])));
                buckets.Add(row["BucketEnd"].ToString());
                //pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCes_usi_SoCmax_pct"])));
                //pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["PCbo_usi_DashSOC_pct"])));
                // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }

            //Add data to serie
            //hcVendas.XAxis.Add(new XAxisItem { title = new Title("Time Buckets"), categories = pointCollectionCat.ToArray()  });
            // hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, categories = buckets.ToArray(), tickColor = "#ccc", tickLength = 50, labels = (new Labels() { rotation = -90, step = 1, y = 30 }) });
            hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Trans Temp") });



            var series = new Collection<Serie> { new Serie { name = "% Of Time", data = pointCollectionBrakePedal.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }


        private void ReportServices_DailyGrab_GenVehicleData_VinChgEnergyHist(Vehicles v, int WeekNumber, int YearNumber)
        {

            GetChartData gd = new GetChartData();



            DataTable DtRange = gd.GetDateRangeFromWeekNumber(WeekNumber, YearNumber);
            DataTable dataTable = gd.Dt_DailyGrab_GetVenChgEnergyHist(v.VinID, WeekNumber, YearNumber, Rounding);

            string mainTitle = string.Format("Chrg Energy kWh - {0} - {1}  ", Convert.ToDateTime(DtRange.Rows[0]["StartDate"]).ToString("d"), Convert.ToDateTime(DtRange.Rows[0]["EndDate"]).ToString("d"));



            string subTitle = string.Format("{0} - {1}", v.CustomerName, v.Vin);
            hcFrutas.Title = new Title(mainTitle);
            hcFrutas.SubTitle = new SubTitle(subTitle);

            hcFrutas.Theme = "grid";
            hcFrutas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
            hcFrutas.Appearance = new Appearance { renderTo = "container", animation = false };
            hcFrutas.YAxis.Add(new YAxisItem { title = new Title("Chrg Energy kWh") });


            //Get point collection
            var pointCollectionChgEnergy = new PointCollection();
            var pointCollectionCat = new PointCollection();
            //var pointCollectionSocMax = new PointCollection();
            //var pointCollectionSocDas = new PointCollection();

            List<string> buckets = new List<string>();


            // Add string using Add method



            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionChgEnergy.Add(new Point(Convert.ToDouble(row["Chg_Energy_kwh"])));
                buckets.Add(row["ProcessDate"].ToString());
              
            }

            //Add data to serie
               hcFrutas.XAxis.Add(new XAxisItem { type = AxisDataType.linear, tickColor = "#ccc", categories = buckets.ToArray(), tickLength = 1, title = new Title("Date") });



               var series = new Collection<Serie> { new Serie { name = "Chrg Energy kWh", data = pointCollectionChgEnergy.ToArray(), type = RenderType.column, showInLegend = false } };

            //hcVendas.PlotOptions = new PlotOptionsLine { marker = new Marker { enabled = true }, dataLabels = new DataLabels { enabled = true } };
            hcFrutas.PlotOptions = new PlotOptionsColumn { groupPadding = 0, pointPadding = 0, shadow = true, borderWidth = 2, borderColor = "#666", dataLabels = new DataLabels { enabled = true } };



            //Bind the control
            hcFrutas.DataSource = series;
            hcFrutas.DataBind();


        }

    }
}