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
using DataServicesSol.dS_GetDataRangeDatesTableAdapters;

namespace DataServicesSol
{
    public partial class DataServicesGetTraceData : Form
    {
        TraceParameters parm = new TraceParameters();
        public DataServicesGetTraceData()
        {
            InitializeComponent();
        }

        private void DataServicesGetTraceData_Load(object sender, EventArgs e)
        {

            this.dpEventDate.Text = DateTime.Now.ToString("MM/d/yyyy");
            // TODO: This line of code loads data into the 'dS_GetDataTypes._Get_DataServices_DataItems' table. You can move, or remove it, as needed.
            this.get_DataServices_DataItemsTableAdapter.Fill(this.dS_GetDataTypes._Get_DataServices_DataItems);
            // TODO: This line of code loads data into the 'dS_GetCustomer.GetCustomer' table. You can move, or remove it, as needed.
            this.getCustomerTableAdapter.Fill(this.dS_GetCustomer.GetCustomer);


            string dataPath;
            dataPath = Properties.Settings.Default.TraceDataReportPath.ToString();
            if (dataPath.Contains("%USERPROFILE%"))
            {
                dataPath = Environment.ExpandEnvironmentVariables(dataPath);
            }

            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);

            txtOutPutFilePath1.Text = dataPath;




           // txtOutPutFilePath1.Text = Properties.Settings.Default.TraceDataReportPath.ToString();



        }

        private void cbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                //cbChargingStations.SelectedIndex = -1;
                //cbBus.SelectedIndex = -1;


                byte DataType = Convert.ToByte(cbDataType.SelectedValue.ToString());
               // GetStartTimes();
                if (DataType == 2)
                {
                    cbChargingStations.Visible = true;
                    lblChargingStation.Visible = true;

                    cbChargingStations.SelectedIndex = 0;
                    
                }

                else if (DataType == 3)
                {
                    cbChargingStations.Visible = true;
                    lblChargingStation.Visible = true;

                    cbChargingStations.SelectedIndex = 0;
                }
                else
                {
                    cbChargingStations.Visible = false;
                    lblChargingStation.Visible = false;
                    cbBus.Enabled = true;
                }

                cbBus.SelectedIndex = 0;
                //cbEndTime.SelectedIndex = 0;
                //cbEndTime.SelectedIndex = 0;
                lblDataAvail.Text = "";



            }
            catch (Exception)
            {
                
               //Do NOthing
            }
          

            
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.dS_GetChargingStations._Get_DataServices_ChargingStationsByCust, CustomerID);
                this.get_DataServices_BusByCustTableAdapter.Fill(this.dS_GetBus._Get_DataServices_BusByCust, CustomerID);

                //GetStartTimes();

                cbBus.SelectedIndex = 0;
                cbStartTime.SelectedIndex = -1;
                cbEndTime.SelectedIndex = -1;
                lblDataAvail.Text = "";
          
            }
            catch (Exception)
            {
                
                //Do Nothing
            }

          
        
        }


        private void GetDataMinMax()
        {
             string dttRange ;
             short ChargingStationID;
            short sCustomerID = parm.CustomerID;
            short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
            if (cbChargingStations.SelectedIndex > 0 )
            {
                ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
            }
            else
            {
                ChargingStationID = 0;
            }


            byte DataType = Convert.ToByte(cbDataType.SelectedValue.ToString());
            DataRangeDatesTableAdapter da = new DataRangeDatesTableAdapter();

            string ReqDataType = "" ;  
        
            switch(DataType)
            {
                case 1 : ReqDataType = "B"; break;
                case 2: ReqDataType = "C"; break;
                case 3: ReqDataType = "BC"; break;

            }


            dttRange = da.GetDataRangeDates(VinID, ChargingStationID, ReqDataType).ToString();
            lblDataAvail.Text = dttRange;
  

        }



        private void GetStartTimes()
        {

            try
            {
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
                short ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
                byte DataType = Convert.ToByte(cbDataType.SelectedValue.ToString());
                DateTime EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());

                DataType = 2;

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
                    byte DataType = Convert.ToByte(cbDataType.SelectedValue.ToString());
                    DateTime EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());
                    string SeedTime = cbStartTime.SelectedValue.ToString();
                    DataType = 1;
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


        private void dpEventDate_ValueChanged(object sender, EventArgs e)
        {
            GetStartTimes();
        }

        private void cbStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEndTimes();
        }

        private void btnOutPutFilePath_Click(object sender, EventArgs e)
        {


            sfdOutPutFile.Filter = "asc files (*.asc)|*.asc|trc files (*.trc)|*.trc|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfdOutPutFile.FilterIndex = 1;
            sfdOutPutFile.RestoreDirectory = true;

            if (sfdOutPutFile.ShowDialog() == DialogResult.OK)
            {

                String FileName = "";

                FileName = sfdOutPutFile.FileName;
               // txtOutPutFilePath.Text = FileName;
                txtOutPutFilePath1.Text = FileName;


            }
        }

        public static void WriteTraceFileFromDB(string dbFile,string TraceDt,int ReportID)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();

            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-CreateTraceFile]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@ReportID", ReportID);

            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();

            SqlDataReader sqlReader = comm.ExecuteReader();

            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //string dbFile = filePath + @"\sqlFile2.txt";
            
           
            using (StreamWriter file = new StreamWriter(dbFile, true))
            {
                file.WriteLine("date " + TraceDt);
                file.WriteLine("base hex  timestamps absolute");
                file.WriteLine("no internal events logged");
                file.WriteLine("Begin Triggerblock " + TraceDt);
                while (sqlReader.Read())
                {

                    string sTraceDt = StringExtensions.FixedWidth(sqlReader["TraceDt"].ToString().Trim(), 13, 1, "R");
                    string sBus = StringExtensions.FixedWidth(sqlReader["Bus"].ToString(), 3, 0, "R");
                    string sSymbolIDHex = StringExtensions.FixedWidth(sqlReader["SymbolIDHex"].ToString(), 16, 0, "R");
                    string sDataType = StringExtensions.FixedWidth(sqlReader["DataType"].ToString(), 5, 0, "R");
                    string sReserved = StringExtensions.FixedWidth(sqlReader["Reserved"].ToString(), 2, 0, "R");
                    string sDLC = StringExtensions.FixedWidth(sqlReader["DLC"].ToString(), 2, 0, "R");
                    string sData = sqlReader["Data"].ToString();
                    // string  sTraceDt = "Test";
                    file.WriteLine(sTraceDt + sBus + sSymbolIDHex + sDataType + sReserved + sDLC + sData);

                }

            }
            sqlReader.Close();
            comm.Connection.Close();


        }

        private void WorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        {

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

            //this.get_DataServices_ReportRequestsTableAdapter.Insert("", parm.UserName, "R", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", "", "T", DateTime.Now, bReportStatus, DateTime.Now, "Queued");

            //sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "R", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", "", "T", DateTime.Now, bReportStatus, DateTime.Now, "Queued");

            //parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + sReportID + "_" + Path.GetFileName(txtOutPutFilePath.Text.Trim());
          
       
            string tDay = (parm.EventDate.ToString("ddd"));
            string tMon = parm.EventDate.ToString("MMM");
            string tDate = parm.EventDate.ToString("dd");
            string tTime = "12:00:00 AM";
            string tYear = parm.EventDate.ToString("yyyy");

           // string StrDt = tDay + " " + tMon + " " + tDate + " " + tTime + " " + tYear;
            string StrDt = tMon + " " + tDate + " " + tTime + " " + tYear;
            string StrDt_File = tDay + "_" + tMon + "_" + tDate + "_" + tYear;


            string tVinChr = parm.ChargingStationID > 0 ? parm.ChargingStationLocation : parm.Vin;

            parm.OutputFilePath = parm.OutputFolderPath + @"\TD_" +tVinChr + "_{ReportID}_" + "For_" + StrDt_File + ".trc";

            sReportID = (int)this.get_DataServices_ReportRequestsTableAdapter.SetInsertReportRequestsRetInd("", parm.UserName, "R", parm.DataType, sCustomerID, sVinID, sChargingStationID, dEventDate, sStartTime, sEndTime, parm.OutputFilePath, bAllSymbols, bAllVaribles, "", "", "T", DateTime.Now, bReportStatus, DateTime.Now, "Queued");


            parm.OutputFilePath = parm.OutputFolderPath + @"\TD_" +tVinChr + "_" + sReportID + "_For_" + StrDt_File + ".trc";
            parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\TD_" +tVinChr + "_" + sReportID + "_" + "For_" + StrDt_File + ".trc";


            WriteTraceFileFromDB(parm.OutputFilePath, StrDt, sReportID);
     



            //System.Threading.Thread.Sleep(4000);
            if (e.Arguments.Count > 0)
            {
                e.Result = e.Arguments[0].ToString();
            }
            else
            {
                File.Copy(parm.OutputFilePath, parm.OutputNetworkFilePath,true);
                e.Result = "File Sucessfully Processed";
            }
        }
		
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            
           
            StringBuilder  MissingPara = new StringBuilder();

            if (ChkSymbols.Checked == true)
            {  
                parm.AllSymbols = 1;
            }

          
   
            if (dpEventDate.Value.ToString() != "")
            {
            parm.EventDate = Convert.ToDateTime(dpEventDate.Value.ToString());
            }
            else
            {
                MissingPara.Append ( ", Event Date");
            }


            if (cbCustomer.SelectedItem != null && cbCustomer.SelectedValue.ToString() != "-1")
            {
                parm.CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
            }
            else
            {
                MissingPara.Append(", Customer ");
            }




            if (cbDataType.SelectedItem != null && cbDataType.SelectedValue.ToString() != "-1")
            {
                parm.DataType = Convert.ToInt16(cbDataType.SelectedValue.ToString());
            }
            else
            {
                MissingPara.Append ( ", DataType ");
            }


            if (cbChargingStations.SelectedItem != null && cbChargingStations.SelectedValue.ToString() != "-1") 
            {
                parm.ChargingStationID = Convert.ToInt16(cbChargingStations.SelectedValue.ToString());
                parm.ChargingStationLocation = cbChargingStations.Text.ToString();
            }
            else if (cbDataType.SelectedItem != null && (cbDataType.SelectedValue.ToString() == "-1" || cbDataType.SelectedValue.ToString() == "1"))
            {
                //do Nothing
            }
            else
            {
                MissingPara.Append(", ChargingStations ");
            }



            if (cbStartTime.SelectedItem != null && cbStartTime.SelectedValue.ToString() != "<Select a Value>")
            {
            parm.StartTime = cbStartTime.SelectedValue.ToString();
            }
            else
            {
                MissingPara.Append ( ", StartTime ");
            }


            if (cbEndTime.SelectedItem != null && cbEndTime.SelectedValue.ToString() != "<Select a Value>")
            {
            parm.EndTime = cbEndTime.SelectedValue.ToString();
            }
            else
            {
                MissingPara.Append ( ", EndTime ");
            }



            if (cbBus.SelectedItem != null && cbBus.SelectedValue.ToString() != "-1")
            {
            parm.VinID = Convert.ToInt32(cbBus.SelectedValue.ToString());
            parm.Vin = cbBus.Text.ToString();
            }
            else
            {
                if (parm.DataType != 2)
                    {
                        MissingPara.Append(", Bus ");
                    }
            }


            if (txtOutPutFilePath1.Text != "")
            {
                parm.OutputFolderPath = txtOutPutFilePath1.Text.Trim();
                //parm.OutputFilePath = txtOutPutFilePath1.Text.Trim();
                //parm.OutputNetworkFilePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + Path.GetFileName(txtOutPutFilePath.Text.Trim());
            }
            else
            {
                MissingPara.Append(", OutPut Path ");
            }


            parm.UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

          
            if (MissingPara.Length > 0 )
            {
               char[] arr = new char[]{','};
                lblError.Text = String.Concat(" Required Parameters  - " , MissingPara.ToString().TrimStart(arr));
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DataServices trd = new DataServices();
            trd.Show();
            this.Hide();
        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbBus.SelectedItem != null && cbBus.SelectedValue.ToString() != "-1")
            {
                short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
                short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
                byte DataType = Convert.ToByte(cbDataType.SelectedValue.ToString());
             //   GetStartTimes();
                GetDataMinMax();
                GetStartTimes();

            }
           
        }

        private void cbChargingStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBus.SelectedIndex = 0;
            cbBus.Enabled = false;
            GetDataMinMax();
            GetStartTimes();
            //short VinID = Convert.ToInt16(cbBus.SelectedValue.ToString());
            //if (VinID > 0)
            //{
            //    //GetDataMinMax();
            //}

        }

        

        private void btnFolderPath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserTrace.ShowDialog();
            if (result == DialogResult.OK)
            {
                string FolderPathName = folderBrowserTrace.SelectedPath;
                txtOutPutFilePath1.Text = FolderPathName;
                Properties.Settings.Default.TraceDataReportPath = FolderPathName;

            }

        }


       
  


    }
}
