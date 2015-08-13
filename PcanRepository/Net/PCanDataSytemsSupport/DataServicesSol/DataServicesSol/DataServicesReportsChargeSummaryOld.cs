using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataServicesSol
{
    public partial class DataServicesReportChargeSummary : Form
    {
        public DataServicesReportChargeSummary()
        {
            InitializeComponent();
        }


      


        private void DataServicesDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_GetDataTypes._Get_DataServices_DataItems' table. You can move, or remove it, as needed.
         
            this.get_DataServices_ReportRequestsTableAdapter.Fill(this.dS_ReportViewer._Get_DataServices_ReportRequests, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
   
        }

        private void lblGetTraceData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataServicesGetTraceData trd = new DataServicesGetTraceData();
           
            trd.Show();
          //  this.Close();
            this.Hide();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.get_DataServices_ReportRequestsTableAdapter.Fill(this.dS_ReportViewer._Get_DataServices_ReportRequests, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
    
        }

        private void lblGetDecodedData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DataServicesGetDecodedData trd = new DataServicesGetDecodedData();

            trd.Show();
            //  this.Close();
            this.Hide();

        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //  //  Process.Start("notepad++.exe", "D:\\Users\\kmath\\Documents\\New folder\\RawCharging01.txt");
        //}

        //private void gbDataFilter_Enter(object sender, EventArgs e)
        //{
        //    testBench trd = new testBench();

        //    trd.Show();
        //    //  this.Close();
        //    this.Hide();
        //}



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string filePath2 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                string ReportID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string filePath = Properties.Settings.Default.NetworkFilePath.ToString() + @"\" + ReportID  + "_" + Path.GetFileName(filePath2);
                
                string ext = Path.GetExtension(filePath);

                try
                {
                    if (ext == ".csv")
                    {
                        Process.Start( @filePath);
                    }
                    else
                    {
                        Process.Start("notepad++.exe", @filePath);
                    }
                }
                catch (Exception)
                {

                    Process.Start("notepad.exe", @filePath);
                }

               


                
                
            }
        }

        private void lblTwoHzData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataServicesGetTwoHzData trd = new DataServicesGetTwoHzData();

            trd.Show();
            ////  this.Close();
            this.Hide();
        }

        private void linkChargeSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        
    }
}
