using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataServicesSol
{
    public partial class DataServicesReportsDashboard : Form
    {
        public DataServicesReportsDashboard()
        {
            InitializeComponent();
        }

        private void linkChargeSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DataServicesChargeStationSummary trd = new DataServicesChargeStationSummary();

            trd.Show();
            ////  this.Close();
            this.Hide();
        }

        private void linkDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataServices trd = new DataServices();

            trd.Show();
            ////  this.Close();
            this.Hide();
        }

        private void linkDockSummary_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            //DataServicesReportChargingStationSummary trd = new DataServicesReportChargingStationSummary();

            //trd.Show();
            //////  this.Close();
            //this.Hide();
            
        }
    }
}
