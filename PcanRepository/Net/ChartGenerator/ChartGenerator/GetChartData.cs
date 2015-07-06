using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ChartGenerator
{
    public class GetChartData
    {


        public DataTable GetDashBoardData(int VinID, DateTime ProcessDate, string Group)
        {


            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDashBoard";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Group", SqlDbType.VarChar);
                cmd.Parameters["@Group"].Value = Group;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
        
        public DataTable GetDashBoardData(int VinID, int WeekNumber, int YearNumber, string Group)
        {


            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDashBoard";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Group", SqlDbType.VarChar);
                cmd.Parameters["@Group"].Value = Group;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
        
        public DataTable GetDashBoardDataTabular(int VinID, int WeekNumber, int YearNumber, string Group)
        {


            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDashBoardTabular";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Group", SqlDbType.VarChar);
                cmd.Parameters["@Group"].Value = Group;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }

        public DataTable GetDashBoardDataTabular(int VinID, DateTime ProcessDate,  string Group)
        {


            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDashBoardTabular";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;
                
                cmd.Parameters.Add("@Group", SqlDbType.VarChar);
                cmd.Parameters["@Group"].Value = Group;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
       
        public string GetSoCData(int VinID, DateTime Dt)
        {



            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select Time_Occur = Time_Occur, SocMin = PCes_usi_SoCmin_pct,SocMax =PCes_usi_SoCmax_pct,SocDash=PCbo_usi_DashSOC_pct from dbo.ReportServices_ByTraceDate_BusMatrix where vinid = 181 and [Date] = '2015-04-2' ", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                    return serializer.Serialize(rows);
                }
            }
        }
        
        public DataTable GetSoCDt(int VinID, DateTime Dt)
        {


            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select RecordNum=Row_Number() over(order by Time_Occur),Time_Occur = Time_Occur, SocMin = PCes_usi_SoCmin_pct,SocMax =PCes_usi_SoCmax_pct,SocDash=PCbo_usi_DashSOC_pct from dbo.ReportServices_ByTraceDate_BusMatrix where vinid = 226 and [Date] = '2015-04-14' ", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;

                }

            }
        }
        
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
        
        public DataTable GetDateRangeFromWeekNumber(int WeekNumber, int YearNumber)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "DataSystem_GetDateRangeForIsoWeek";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


             

            }
        }


        //----------Daily-----------------//

        public DataTable Dt_DailyGrab_GetSoC(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetSoC";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
        public DataTable Dt_DailyGrab_GetSoCbyPacks(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetSoCbyPacks";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
        public DataTable Dt_DailyGrab_GetTMaxbyPacks(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetTMaxbyPacks";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }
        public DataTable Dt_DailyGrab_GetCurrentbyPacks(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetCurrentbyPacks";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }


            }
        }


        public DataTable Dt_DailyGrab_GetVenSpeedHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinSpeedHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenEfficiencyHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinEfficiencyHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenAccelPedalHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinAccelPedalHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenBrakePedalHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBrakePedalHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenChargingHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinChargingHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
    
        public DataTable Dt_DailyGrab_GetVenVoltageHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinVoltageHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenSocMinHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinSocMinHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenBatteryTempMaxHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBatteryTempMaxHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenPECoolantTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinPECoolantTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
                
        public DataTable Dt_DailyGrab_GetVenDCDCConverterPowerHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDCDCConverterPowerHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenStatorTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinStatorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenTractionMotorRotorTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorRotorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenTractionMotorInverterTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorInvertorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenTractionMotorIGBTTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorIGBTTempHist";
                          

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenRadiatorFanSpeedHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinRadiatorFanSpeedHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenBatteryCoolantPumpHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBatteryCoolantPumpHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenMinAirPressureHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinMinAirPressureHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
                
        public DataTable Dt_DailyGrab_GetVenTransTempHist(int VinID, DateTime ProcessDate, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTransTempHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@ProcessDate", SqlDbType.Date);
                cmd.Parameters["@ProcessDate"].Value = ProcessDate;


                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }


        //----------Weekly-----------------//
        public DataTable Dt_DailyGrab_GetVenSpeedHist(int VinID,  int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinSpeedHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;
                
                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenEfficiencyHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinEfficiencyHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenAccelPedalHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinAccelPedalHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenBrakePedalHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBrakePedalHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenChargingHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinChargingHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;

                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenVoltageHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinVoltageHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenSocMinHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinSocMinHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenBatteryTempMaxHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBatteryTempMaxHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenPECoolantTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinPECoolantTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenDCDCConverterPowerHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinDCDCConverterPowerHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenStatorTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinStatorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }
        
        public DataTable Dt_DailyGrab_GetVenTractionMotorRotorTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorRotorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;




                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenTractionMotorInverterTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorInvertorTempHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;

                
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenTractionMotorIGBTTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTractionMotorIGBTTempHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenRadiatorFanSpeedHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinRadiatorFanSpeedHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenBatteryCoolantPumpHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinBatteryCoolantPumpHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenMinAirPressureHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinMinAirPressureHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenTransTempHist(int VinID, int WeekNumber,int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetVinTransTempHist";


            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;



                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

        public DataTable Dt_DailyGrab_GetVenChgEnergyHist(int VinID, int WeekNumber, int YearNumber, int Rounding)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["PCanRepository"].ConnectionString;
            string sql = "ReportServices_DailyGrab_GetWeeklyChgEnergyHist";

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@VinID", SqlDbType.Int);
                cmd.Parameters["@VinID"].Value = VinID;

                cmd.Parameters.Add("@WeekNumber", SqlDbType.Int);
                cmd.Parameters["@WeekNumber"].Value = WeekNumber;

                cmd.Parameters.Add("@YearNumber", SqlDbType.Int);
                cmd.Parameters["@YearNumber"].Value = YearNumber;

                cmd.Parameters.Add("@Rouding", SqlDbType.Int);
                cmd.Parameters["@Rouding"].Value = Rounding;


                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                catch
                {
                    return dt;
                }

                finally
                {
                    dt.Dispose();
                }
            }
        }

    }

}






     