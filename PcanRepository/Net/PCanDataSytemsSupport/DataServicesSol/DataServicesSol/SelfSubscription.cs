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
using DataServicesSol.ds_UserInfoTableAdapters;



namespace DataServicesSol
{
    public partial class SelfSubscription : Form
    {

        Users UserDetails = new Users();

        public SelfSubscription()
        {
            InitializeComponent();
        }
        

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SelfSubscription_Load(object sender, EventArgs e)
        {
            



            try
            {
                
                string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                
        
              

                this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.dS_GetChargingStations._Get_DataServices_ChargingStationsByCust, CustomerID);
                this.get_DataServices_BusByCustTableAdapter.Fill(this.dS_GetBus._Get_DataServices_BusByCust, CustomerID);
                lblDataAvail.Text = "";
                cbBus.SelectedIndex = 0;
                lblDataAvail.Text = "";

                // GetStartTimes();
            }
            catch (Exception)
            {

                //Do Nothing
            }

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
