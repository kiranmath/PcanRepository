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
    public partial class DataServicesChargeStationSummary : Form
    {

        TraceParameters parm = new TraceParameters();
        public DataServicesChargeStationSummary()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataServicesReportsDashboard trd = new DataServicesReportsDashboard();
            trd.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataServicesChargeSummary_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'dS_GetDataTypes._Get_DataServices_DataItems' table. You can move, or remove it, as needed.
            this.get_DataServices_DataItemsTableAdapter.Fill(this.dS_GetDataTypes._Get_DataServices_DataItems);
            // TODO: This line of code loads data into the 'dS_GetCustomer.GetCustomer' table. You can move, or remove it, as needed.
            this.getCustomerTableAdapter.Fill(this.dS_GetCustomer.GetCustomer);

            //txtOutPutFilePath.Text = Properties.Settings.Default.ChargingSummaryReportPath.ToString();



            string dataPath;
            dataPath = Properties.Settings.Default.ChargingSummaryReportPath.ToString();
            if (dataPath.Contains("%USERPROFILE%"))
            {
                dataPath = Environment.ExpandEnvironmentVariables(dataPath);
            }

            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);

             txtOutPutFilePath.Text = dataPath;
            


        }

        private void cbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.dS_GetChargingStations._Get_DataServices_ChargingStationsByCust, CustomerID);
            }
            catch (Exception)
            {

                //Do Nothing
            }


        }


        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
            short ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
            short Year = Convert.ToInt16(cbYear.SelectedItem.ToString());

            this.get_DataServices_ChargeSummary_IsoWeekTableAdapter.Fill(this.dS_GetChargeSummaryIsoWeek._Get_DataServices_ChargeSummary_IsoWeek, ChargingStationID, Year);

        }

        private void btnOutPutFilePath_Click(object sender, EventArgs e)
        {
            //sfdOutPutFile.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //sfdOutPutFile.FilterIndex = 1;
            //sfdOutPutFile.RestoreDirectory = true;

            //if (sfdOutPutFile.ShowDialog() == DialogResult.OK)
            //{

            //    String FileName = "";

            //    FileName = sfdOutPutFile.FileName;
            //    txtOutPutFilePath.Text = FileName;
            //}

            

        DialogResult result = folderBrowserTrace.ShowDialog();
	    if (result == DialogResult.OK)
        {
           string FolderPathName = folderBrowserTrace.SelectedPath;
           txtOutPutFilePath.Text = FolderPathName;
           Properties.Settings.Default.ChargingSummaryReportPath =   FolderPathName;

        }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //short ISOWeek = Convert.ToInt16(cbWeek.SelectedValue.ToString());
            //short ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
            //short Year  = Convert.ToInt16(cbYear.SelectedItem.ToString());
            //string OutputFilePath = txtOutPutFilePath.Text;
            //string OutputNetworkFilePath = String.Empty;
            //string UserName = String.Empty;


            StringBuilder MissingPara = new StringBuilder();



            if (cbYear.SelectedItem.ToString() != "")
            {
                parm.Year = Convert.ToInt16(cbYear.SelectedItem.ToString());
            }
            else
            {
                MissingPara.Append(", Year");
            }


            if (cbChargingStations.SelectedValue.ToString() != "")
            {
                parm.ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
                parm.ChargingStationLocation = cbChargingStations.Text;
            }
            else
            {
                MissingPara.Append(", Charging Stations ");
            }




            if (cbWeek.SelectedValue.ToString() != "-1")
            {
                parm.ISOWeek = Convert.ToInt16(cbWeek.SelectedValue.ToString());
            }
            else
            {
                MissingPara.Append(", DataType ");
            }





            if (cbCustomer.SelectedItem != null && cbCustomer.SelectedValue.ToString() != "-1")
            {
                parm.CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                parm.CustomerName = cbCustomer.Text;


            }
            else
            {
                MissingPara.Append(", Customer ");
            }

           


            if (txtOutPutFilePath.Text != "")
            {

                parm.OutputFolderPath = txtOutPutFilePath.Text.Trim();
                parm.OutputNetworkFolderPath = Properties.Settings.Default.NetworkFilePath.ToString();


                //parm.OutputFilePath = txtOutPutFilePath.Text.Trim();
                //parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + Path.GetFileName(txtOutPutFilePath.Text.Trim());
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




            //WriteCSVFileFromDB(dbFile, ISOWeek, ChargingStationID, Year);
        }

        private void WorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        {

            int sReportID = 0;
            short sCustomerID = parm.CustomerID;
            short sVinID = 0;
            short sChargingStationID = Convert.ToInt16(parm.ChargingStationID);
            DateTime dEventDate =DateTime.Now;


            string sStartTime = DateTime.Now.ToString("h:mm:ss tt");
            string sEndTime = DateTime.Now.ToString("h:mm:ss tt");

            byte bReportStatus = 1;
            byte bAllSymbols = 0;
            byte bAllVaribles = 0;
            string sListVariables = parm.ListVariables;
            string sListVariablesSql = parm.ListVariablesSql;
            


            //this.get_DataServices_ReportRequestsTableAdapter.Insert("", parm.UserName, "P", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");


            int ErrorFound = 0;
            string ErrorMsg = string.Empty;

            try
            {
                parm.OutputFilePath = parm.OutputFolderPath + @"\" + parm.ChargingStationLocation + "_CS_{ReportID}_" + "WeekNum_" + parm.ISOWeek + ".csv";
                sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "CS", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");
                parm.OutputFilePath = parm.OutputFolderPath + @"\" + parm.ChargingStationLocation + "_CS_" + sReportID + "_" + "WeekNum_" + parm.ISOWeek + ".csv";
                parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + parm.ChargingStationLocation + "_CS_" + sReportID + "_" + "WeekNum_" + parm.ISOWeek + ".csv";
                WriteCSVFileFromDB(parm.OutputFilePath, parm.ISOWeek, parm.ChargingStationID, parm.Year, "CS");
                File.Copy(parm.OutputFilePath, parm.OutputNetworkFilePath, true);
            }
            catch (Exception ex)
            {
                ErrorFound = 1;
                ErrorMsg = ex.ToString();
            }


            try
            {
                //Docksummary
                parm.OutputFilePath = parm.OutputFolderPath + @"\" + parm.ChargingStationLocation + "_DS_{ReportID}_" + "WeekNum_" + parm.ISOWeek + ".csv";
                sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "DS", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", sListVariablesSql, "P", DateTime.Now, bReportStatus, DateTime.Now, "Queued");
                parm.OutputFilePath = parm.OutputFolderPath + @"\" + parm.ChargingStationLocation + "_DS_" + sReportID + "_" + "WeekNum_" + parm.ISOWeek + ".csv";
                parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + parm.ChargingStationLocation + "_DS_" + sReportID + "_" + "WeekNum_" + parm.ISOWeek + ".csv";
                WriteCSVFileFromDB(parm.OutputFilePath, parm.ISOWeek, parm.ChargingStationID, parm.Year, "DS");
                File.Copy(parm.OutputFilePath, parm.OutputNetworkFilePath, true);
            }
            catch( Exception ex)
            {
                ErrorFound = 1;
                ErrorMsg = ex.ToString();
            }


            if (ErrorFound == 1)
            {
                e.Result = ErrorMsg;
            }
            else
            {
                e.Result = "File Sucessfully Processed";
            }



            //parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + sReportID + "_" + Path.GetFileName(txtOutPutFilePath.Text.Trim());

            //string tDay = (parm.EventDate.ToString("ddd"));
            //string tMon = parm.EventDate.ToString("MMM");
            //string tDate = parm.EventDate.ToString("dd");
            //string tTime = "00:00:00";
            //string tYear = parm.EventDate.ToString("yyyy");

            //string StrDt = tDay + " " + tMon + " " + tDate + " " + tTime + " " + tYear;
          

            //System.Threading.Thread.Sleep(4000);
            //if (e.Arguments.Count > 0)
            //{
            //    e.Result = e.Arguments[0].ToString();
            //}
            //else
            //{
            //    File.Copy(parm.OutputFilePath, parm.OutputNetworkFilePath, true);
            //    e.Result = "File Sucessfully Processed";
            //}
        }
		

        public static void WriteCSVFileFromDB(string dbFile, int ISOWeek, int ChargingStationID, int Year,String DataType)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();
            string Separator = ",";

            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            if (DataType == "CS")
            {
                comm.CommandText = "dbo.[Get-Reports-ChargeSummaryStr]";
            }
            else
            {
                comm.CommandText = "dbo.[Get-Reports-DockSummaryStr]";
            }


            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Year", Year);
            comm.Parameters.AddWithValue("@ISOWeek", ISOWeek);
            comm.Parameters.AddWithValue("@ChargingStationID", ChargingStationID);
          // comm.Parameters.AddWithValue("@UserName", System.Security.Principal.WindowsIdentity.GetCurrent().Name);

            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();

            SqlDataReader dr = comm.ExecuteReader();
            string strRow = "";
            StreamWriter sw = new StreamWriter(dbFile, false, ASCIIEncoding.ASCII);
         
            //Retrieve the schema of the table

            DataTable dtSchema = dr.GetSchemaTable();

            int index = dtSchema.Columns.IndexOf("ColumnName");
            DataColumn columnName = dtSchema.Columns[index];

            //For each field in the table...
            foreach (DataRow myField in dtSchema.Rows)
            {
                String columnNameValue = myField[columnName].ToString();
                strRow += columnNameValue;
                strRow += Separator;

            }
            strRow.TrimEnd(',');
            sw.WriteLine(strRow);

           
        

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

        private void txtOutPutFilePath_TextChanged(object sender, EventArgs e)
        {

        }

      
      

    }

      

}


