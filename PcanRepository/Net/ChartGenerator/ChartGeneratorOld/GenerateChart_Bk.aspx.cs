﻿using System;
using System.Data;
using System.Collections.ObjectModel;
using Highcharts.Core;
using Highcharts.Core.Appearance;
using Highcharts.Core.Data.Chart;
using Highcharts.Core.PlotOptions;


namespace ChartGenerator
{
    public partial class GenerateChart_SoC_Bk : System.Web.UI.Page
    {
           protected void Page_Load(object sender, EventArgs e)
        {
            AjaxReport01();
        }

        private void AjaxReport01()
        {
           // hcVendas.Appearance = new Appearance { renderTo = "container", zoomType = "x" };
           // hcVendas.YAxis.Add(new YAxisItem { title = new Title("SoC"), type = AxisDataType.linear });
            //hcVendas.XAxis.Add(new XAxisItem { maxZoom = 5, labels = (new Labels { rotation = 45, step = 2 }) });

            hcVendas.Title = new Title("SoC Daily");
            hcVendas.SubTitle = new SubTitle("Min - Max - Dash");

            hcVendas.Theme = "gray";
            hcVendas.Legend = new Legend { align = Align.right, layout = Layout.vertical, verticalAlign = VerticalAlign.top, x = -10, y = 70, borderWidth = 0 };
           hcVendas.Appearance = new Appearance { renderTo = "container", animation=false};
           hcVendas.YAxis.Add(new YAxisItem {title = new Title("SoC")});
           hcVendas.XAxis.Add(new XAxisItem { type = AxisDataType.datetime, dateTimeLabelFormats = new DateTimeLabelFormats { hour = "%H" } });
          // hcVendas.XAxis.Add(new XAxisItem { categories = new object[] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "24:00"} });


           hcVendas.Tooltip = new ToolTip("Highcharts.dateFormat("%H:%M", this.x) +": "+ this.y");

            //Get point collection
            var pointCollectionSocMin = new PointCollection();
            var pointCollectionSocMax = new PointCollection();
            var pointCollectionSocDas = new PointCollection();
            GetChartData gd = new GetChartData();
            
             DateTime dt1 = new DateTime(2015,4,2);

            DataTable dataTable = gd.GetSoCDt(189,dt1);
            foreach (DataRow row in dataTable.Rows)
            {
                pointCollectionSocMin.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["SocMin"])));
                pointCollectionSocMax.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["SocMax"])));
                pointCollectionSocDas.Add(new Point(Convert.ToInt64((DateTime.Parse(row["Time_Occur"].ToString()).Subtract(new DateTime(2015, 1, 1))).TotalMilliseconds), Convert.ToDouble(row["SocDash"])));
               // pointCollection.Add(new Point(DateTime.Parse(row["Time_Occur"].ToString()), Convert.ToDouble(row["SocMin"])));
            }
            
            //Add data to serie
            var series = new Collection<Serie> { new Serie { name = "SocMin", data = pointCollectionSocMin.ToArray() }, new Serie { name = "SocMax", data = pointCollectionSocMax.ToArray() }, new Serie { name = "SocDash",  data = pointCollectionSocDas.ToArray() } };
            hcVendas.PlotOptions = new PlotOptionsLine {marker= new Marker{enabled=false}, dataLabels = new DataLabels { enabled = false }};
            
            
            //Bind the control
            hcVendas.DataSource = series;
            hcVendas.DataBind();
         
           
            

            }

          
        }
    }
