using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using DataServicesSol.dS_GetDataRangeDatesTableAdapters;


namespace DataServicesSol
{
    public partial class DataServicesGetTwoHzData : Form
    {

        TraceParameters parm = new TraceParameters();

        public DataServicesGetTwoHzData()
        {
            InitializeComponent();
        }

        private void DataServicesGetTwoHzData_Load(object sender, EventArgs e)
        {
            this.dpEventDate.Text = DateTime.Now.ToString("MM/d/yyyy");
            // TODO: This line of code loads data into the 'dS_GetTwoHzVariables.TwoHzVariables' table. You can move, or remove it, as needed.
            this.twoHzVariablesTableAdapter.Fill(this.dS_GetTwoHzVariables.TwoHzVariables);
            // TODO: This line of code loads data into the 'dS_GetCustomer.GetCustomer' table. You can move, or remove it, as needed.
            this.getCustomerTableAdapter.Fill(this.dS_GetCustomer.GetCustomer);



            string dataPath;
            dataPath = Properties.Settings.Default.TwoHzReportPath.ToString();
            if (dataPath.Contains("%USERPROFILE%"))
            {
                dataPath = Environment.ExpandEnvironmentVariables(dataPath);
            }

            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);

            txtOutPutFilePath1.Text = dataPath;
            // txtOutPutFilePath1.Text = Properties.Settings.Default.TwoHzReportPath.ToString();

        }

        private void GetDataMinMax()
        {
            string dttRange;
            short sCustomerID = parm.CustomerID;
            short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());


            DataRangeDatesTableAdapter da = new DataRangeDatesTableAdapter();




            dttRange = da.GetDataRangeDates(VinID, 0, "BP").ToString();
            lblDataAvail.Text = dttRange;
        }



        private void GetAvailTime(DateTime TraceDate)
        {
            try
            {
                string HourlyDataAvailiablity;
                short sCustomerID = parm.CustomerID;
                short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
                DataRangeDatesTableAdapter da = new DataRangeDatesTableAdapter();
                HourlyDataAvailiablity = da.GetDateAvailTime(VinID, 0, "BP", TraceDate).ToString();
                lblAvailTime.Text = HourlyDataAvailiablity;
            }
            catch (Exception)
            {

                //do Nothing
            }
        }




        private void GetStartTimes()
        {

            try
            {
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
                short ChargingStationID = 0;
                byte DataType = 1;
                DateTime EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());

                if (VinID == 0 || DataType == 0)
                {
                    EventDate = DateTime.Parse("1/1/1900");
                    cbEndTime.SelectedIndex = -1;
                }


                this.get_DataServices_EventStartTimesTableAdapter.Fill(this.dS_StartTime._Get_DataServices_EventStartTimes, EventDate, DataType, VinID, ChargingStationID);

            }
            catch (Exception)
            {

                //do Nothing
            }

        }

        private void GetEndTimes()
        {
            try
            {

                try
                {
                    short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                    short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
                    byte DataType = 1;
                    DateTime EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());
                    string SeedTime = cbStartTime.SelectedValue.ToString();
                    this.get_DataServices_EventEndTimesTableAdapter.Fill(this.dS_EndTime._Get_DataServices_EventEndTimes, EventDate, DataType, VinID, SeedTime);

                }
                catch (Exception)
                {

                    //do Nothing
                }


            }
            catch (Exception)
            {

                //Do Nothing
            }

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                //   this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.dS_GetChargingStations._Get_DataServices_ChargingStationsByCust, CustomerID);
                this.get_DataServices_BusByCustTableAdapter.Fill(this.dS_GetBus._Get_DataServices_BusByCust, CustomerID);
                lblDataAvail.Text = "";

                // GetStartTimes();
            }
            catch (Exception)
            {

                //Do Nothing
            }


        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblDataAvail.Text = "";


            if (cbBus.SelectedItem != null && cbBus.SelectedValue.ToString() != "-1")
            {
                short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());


                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());

                GetStartTimes();
                GetDataMinMax();
                populateAvailTime();
                populateCheckgrid("B");

            }

        }

        private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEndTimes();
        }

        private void populateCheckgrid(string DataType)
        {
            //this.getDataServicesVariablesTableAdapter.Fill(this.dS_PcanVariables.GetDataServicesVariables, DataType);
            this.twoHzVariablesTableAdapter.Fill(this.dS_GetTwoHzVariables.TwoHzVariables);
            List<ArrayList> newval = new List<ArrayList>();
            foreach (DataRow dRow in dS_GetTwoHzVariables.Tables[0].Rows)
            {
                ArrayList values = new ArrayList();
                checkedListBox1.Items.Add(dRow.ItemArray[0].ToString());

            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {



            StringBuilder MissingPara = new StringBuilder();

            if (ChkSymbols.Checked == true)
            {
                parm.AllSymbols = 1;
            }



            //Get all variables
            StringBuilder sb = new StringBuilder();
            StringBuilder sbsql = new StringBuilder();
            int i = 0;
            foreach (string rowView in checkedListBox1.CheckedItems)
            {
                if (i <= 50)
                {
                    sb.Append(rowView).Append(",");
                    // sbsql.Append((rowView) + ",");
                    sbsql.Append("ISNULL(CONVERT(VARCHAR(50)," + rowView + "), '' ) AS " + rowView + ",");
                }
                i += 1;

            }



            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
                sbsql.Remove(sbsql.Length - 1, 1);

                string PcanVar = sb.ToString();
                parm.ListVariables = PcanVar;
                parm.ListVariablesSql = sbsql.ToString();
            }
            else
            {
                MissingPara.Append(", Variables ");
            }




            if (dpEventDate.Value.ToString() != "")
            {
                parm.EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());
            }
            else
            {
                MissingPara.Append(", Event Date");
            }


            if (cbCustomer.SelectedItem != null && cbCustomer.SelectedValue.ToString() != "-1")
            {
                parm.CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
            }
            else
            {
                MissingPara.Append(", Customer ");
            }










            if (cbStartTime.SelectedItem != null && cbStartTime.SelectedValue.ToString() != "<Select a Value>")
            {
                parm.StartTime = cbStartTime.SelectedValue.ToString();
            }
            else
            {
                MissingPara.Append(", StartTime ");
            }


            if (cbEndTime.SelectedItem != null && cbEndTime.SelectedValue.ToString() != "<Select a Value>")
            {
                parm.EndTime = cbEndTime.SelectedValue.ToString();
            }
            else
            {
                MissingPara.Append(", EndTime ");
            }



            if (cbBus.SelectedItem != null && cbBus.SelectedValue.ToString() != "-1")
            {
                parm.VinID = Convert.ToInt32(cbBus.SelectedValue.ToString());
                parm.Vin = cbBus.Text.ToString();
            }
            else
            {
                MissingPara.Append(", Bus ");
            }


            if (txtOutPutFilePath1.Text != "")
            {

                //parm.OutputFilePath = txtOutPutFilePath1.Text.Trim();
                parm.OutputFolderPath = txtOutPutFilePath1.Text.Trim();
            }
            else
            {
                MissingPara.Append(", OutPut Path ");
            }



            parm.UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;


            if (MissingPara.Length > 0)
            {
                char[] arr = new char[] { ',' };


                lblError.Text = String.Concat(" Required Parameters  - ", MissingPara.ToString().TrimStart(arr));
            }
            else
            {

                object result = Jacksonsoft.WaitWindow.Show(this.WorkerMethod);
                MessageBox.Show(result.ToString());
                DataServices trd = new DataServices();
                trd.Show();
                this.Hide();
            }


        }

        private void btnOutPutFilePath_Click(object sender, EventArgs e)
        {


            sfdOutPutFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfdOutPutFile.FilterIndex = 1;
            sfdOutPutFile.RestoreDirectory = true;

            if (sfdOutPutFile.ShowDialog() == DialogResult.OK)
            {

                String FileName = "";

                FileName = sfdOutPutFile.FileName;
                txtOutPutFilePath1.Text = FileName;


            }
        }



        private void WorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        {

            int ErrorFound;
            string ErrorMsg;
            int sReportID = 0;
            short sCustomerID = parm.CustomerID;
            short sVinID = Convert.ToInt16(parm.VinID);
            short sChargingStationID = Convert.ToInt16(parm.ChargingStationID);
            DateTime dEventDate = Convert.ToDateTime(parm.EventDate);
            string sStartTime = (parm.StartTime);
            string sEndTime = (parm.EndTime);
            byte bReportStatus = 1;
            byte bAllSymbols = Convert.ToByte(parm.AllSymbols);
            byte bAllVaribles = 0;
            string sListVariables = parm.ListVariables;
            string sListVariablesSql = parm.ListVariablesSql;
            //string sNetWorkFileName = Path.GetFileName(parm.OutputNetworkFilePath).Trim();
            // this.get_DataServices_ReportRequestsTableAdapter.Insert("", parm.UserName, "T", 1, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");
            // parm.OutputFilePath = parm.OutputFolderPath + @"\TH_" + parm.VinID + "_{ReportID}_" + "_Of_" + StrDt_File + ".csv";
            //   sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "T", 1, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");

            // parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + sReportID  + "_" + Path.GetFileName(txtOutPutFilePath1.Text.Trim());


            string tDay = (parm.EventDate.ToString("ddd"));
            string tMon = parm.EventDate.ToString("MMM");
            string tDate = parm.EventDate.ToString("dd");
            string tTime = "00:00:00";
            string tYear = parm.EventDate.ToString("yyyy");

            string StrDt = tDay + " " + tMon + " " + tDate + " " + tTime + " " + tYear;

            string StrDt_File = tDay + "_" + tMon + "_" + tDate + "_" + tYear;


            try
            {
                parm.OutputFilePath = parm.OutputFolderPath + @"\TH_" + parm.Vin + "_{ReportID}_" + "For_" + StrDt_File + ".csv";
                sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "T", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");
                parm.OutputFilePath = parm.OutputFolderPath + @"\TH_" + parm.Vin + "_" + sReportID + "_For_" + StrDt_File + ".csv";
                parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\TH_" + parm.Vin + "_" + sReportID + "_" + "For_" + StrDt_File + ".csv";
                WriteCSVFileFromDB(parm.OutputFilePath, StrDt, sListVariables, sReportID);

            }
            catch (Exception ex)
            {

                ErrorFound = 1;
                ErrorMsg = ex.ToString();
            }

            //System.Threading.Thread.Sleep(4000);
            if (e.Arguments.Count > 0)
            {
                e.Result = e.Arguments[0].ToString();
            }
            else
            {
                File.Copy(parm.OutputFilePath, parm.OutputNetworkFilePath, true);
                e.Result = "File Sucessfully Processed";
            }
        }


        public static void WriteCSVFileFromDB(string dbFile, string TraceDt, string ListVariable, int ReportID)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();
            string Separator = ",";

            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-CreateTwoHzPivotFile]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@ReportID", ReportID);
            comm.Parameters.AddWithValue("@UserName", System.Security.Principal.WindowsIdentity.GetCurrent().Name);

            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();

            SqlDataReader dr = comm.ExecuteReader();


            //Retrieve the schema of the table

            DataTable dtSchema = dr.GetSchemaTable();
            StreamWriter sw = new StreamWriter(dbFile, false, ASCIIEncoding.ASCII);
            sw.WriteLine("TraceDt," + ListVariable);
            string strRow = "";

            while (dr.Read())
            {
                strRow = "";
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    strRow += Iif(!DBNull.Value.Equals(dr.GetString(i)), (string)dr.GetString(i), String.Empty);
                    //strRow += AddFieldValue(dr, i);
                    if (i < dr.FieldCount - 1)
                    {
                        strRow += Separator;
                    }

                }
                sw.WriteLine(strRow);

            }
            dr.Close();
            comm.Connection.Close();

            sw.Close();

        }


        public static T Iif<T>(bool cond, T left, T right)
        {

            return cond ? left : right;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            DataServices trd = new DataServices();

            trd.Show();
            ////  this.Close();
            this.Hide();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void btnTwoHzFolderPath_Click(object sender, EventArgs e)
        {

            DialogResult result = folderBrowserTrace.ShowDialog();
            if (result == DialogResult.OK)
            {
                string FolderPathName = folderBrowserTrace.SelectedPath;
                txtOutPutFilePath1.Text = FolderPathName;
                Properties.Settings.Default.TwoHzReportPath = FolderPathName;

            }


        }

        private void txtOutPutFilePath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutPutFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDataFilter_Enter(object sender, EventArgs e)
        {

        }

        private void dpEventDate_ValueChanged(object sender, EventArgs e)
        {

            populateAvailTime();
          
        }


        private void populateAvailTime()
        {

            DateTime dEventDate = Convert.ToDateTime(dpEventDate.Value.ToString());
            DateTime date1 = new DateTime(2000, 1, 1, 0, 0, 0);

            if (dEventDate > date1)
            {
                GetAvailTime(dEventDate);
            }

        }


    }
}

