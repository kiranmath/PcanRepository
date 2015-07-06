﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace GenerateStaticVinReports
{
    public class GetData
    {


        public Vehicles GetVinInfo(int VinID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "SELECT CustomerID,CustomerName, Bus, BusOwner,Vin,VinID from dbo.VehiclesVw with(nolock) where VinID=@VinID";
            Vehicles v = new Vehicles();

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        v.VinID = int.Parse(reader["VinID"].ToString());
                        v.CustomerID = int.Parse(reader["CustomerID"].ToString());
                        v.Vin = reader["Vin"].ToString();
                        v.CustomerName = reader["CustomerName"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return v;
            }
        }



        public void UdpdateReportLog(int ReportID)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            // string sql = "SELECT CustomerID,CustomerName, Bus, BusOwner,Vin,VinID from dbo.VehiclesVw with(nolock) where VinID=@VinID";
            string sql = "UPDATE DataSystem_SummaryTable_DataReportGeneration set ReportProduced = 1 where ID = @ReportID";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                int ReturnRows = 0;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@ReportID", SqlDbType.Int);
                cmd.Parameters["@ReportID"].Value = ReportID;
                try
                {
                    con.Open();
                    ReturnRows = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        


        public VinReportParam GetActionReportRow()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
           // string sql = "SELECT CustomerID,CustomerName, Bus, BusOwner,Vin,VinID from dbo.VehiclesVw with(nolock) where VinID=@VinID";
            string sql = "select ID,vinID, ProcessDate,WeekNumber, YearNumber, ReportPeriod  from DataSystem_SummaryTable_DataReportGeneration with(nolock)  where ID = ( select min(ID) from DataSystem_SummaryTable_DataReportGeneration with(nolock) where ReportProduced = 0 )";
            VinReportParam r = new VinReportParam();

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.Parameters.Add("@VinID", SqlDbType.Int);
                //cmd.Parameters["@VinID"].Value = VinID;
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        r.ReportID = int.Parse(reader["ID"].ToString());
                        r.VinID = int.Parse(reader["VinID"].ToString());
                        r.ProcessDate = reader["ProcessDate"].ToString();
                        r.WeekNumber = reader["WeekNumber"].ToString();
                        r.YearNumber = reader["YearNumber"].ToString();
                        r.ReportPeriod = reader["ReportPeriod"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return r;
            }
        }


        public static Boolean CheckDataExists(string VinID, string ProcessDate, string ReportPeriod, string WeekNumber, string YearNumber)
        {
           
            decimal MilesTravelled = 0;

            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = String.Empty;
            if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
            {
                 
                 sql = "select IsNull(TotalMiles_m,0) TotalMiles_m from [dbo].[DataSystem_SummaryTables_VinDashBoard] with(nolock) where VinID=@VinID AND WeekNumber = Convert(int,@WeekNumber) AND  YearNumber = Convert(int,@YearNumber) AND ReportPeriod='W'";

            }
            else
            {
                sql = "select IsNull(TotalMiles_m,0) TotalMiles_m from [dbo].[DataSystem_SummaryTables_VinDashBoard] with(nolock) where VinID=@VinID AND ProcessDate = Convert(date,@ProcessDate)  AND ReportPeriod='D'";
            }



            int intVinID;
            bool IsVinNumeric = int.TryParse(VinID, out intVinID);

            DateTime dtProcessDate;
           bool IsProcessDate = DateTime.TryParse(ProcessDate,out dtProcessDate);


            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = intVinID;

                if (ReportPeriod == "Weekly" || ReportPeriod == "NREL")
                {

                    int intWeekNumber = 0;
                    int intYearNumber = 0;

                    bool IsWeekNumeric = int.TryParse(WeekNumber, out intWeekNumber);
                    if (IsWeekNumeric)
                    {
                        intWeekNumber = int.Parse(WeekNumber);
                        cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                        cmd.Parameters["@WeekNumber"].Value = intWeekNumber;
                    }


                    bool IsYearNumeric = int.TryParse(YearNumber, out intYearNumber);
                    if (IsYearNumeric)
                    {
                        intYearNumber = int.Parse(YearNumber);
                        cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                        cmd.Parameters["@YearNumber"].Value = intYearNumber;
                    }
                    
                   
                }
                else
                {
                    cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                    cmd.Parameters["@ProcessDate"].Value = dtProcessDate;
                }



            

                string p = cmd.CommandText;
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        MilesTravelled = decimal.Parse(reader["TotalMiles_m"].ToString());

                    }
                }
                catch (Exception ex)
                {
                    MilesTravelled = 0;
                }

                if (MilesTravelled > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

        }
    }
}