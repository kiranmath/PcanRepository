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

namespace DataServicesSol
{
    public partial class DataServicesSubscribe : Form
    {
        string gUserName;
        string currentCleanUserName;
        string currentUserName;
        
        public DataServicesSubscribe()
        {
            InitializeComponent();
        }


        public void GetStarted()
        {
            gUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            if (currentUserName == string.Empty)
            {
                currentUserName = gUserName;
                currentCleanUserName = currentUserName.Replace(@"\", "/");
            }


            //string UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //string cUserName = UserName.Replace(@"\", "/");
            //cUserName = "bus/kSiniard";
            //UserName = "bus/kSiniard";
            string UserID;

            // this.get_DataServices_UserDetailsTableAdapter.Fill(dS_UserInformation._Get_DataServices_UserDetails, cUserName);
            this.get_DataServices_UserDetailsTableAdapter.FillAllUsers(dS_UserInformation._Get_DataServices_UserDetails);
            cbAllUser.DataSource = dS_UserInformation._Get_DataServices_UserDetails;
            Users u = new Users();

            string x;
            foreach (DataRow dRow in dS_UserInformation.Tables[0].Rows)
            {
                if (dRow.ItemArray[4].ToString().ToLower() == gUserName.Replace(@"\", "/").ToLower())
                {
                    u.UserID = Int32.Parse(dRow.ItemArray[0].ToString());
                    u.FirstName = dRow.ItemArray[1].ToString();
                    u.LastName = dRow.ItemArray[2].ToString();
                    u.EmailAddress = dRow.ItemArray[3].ToString();
                    u.UserTypeID = dRow.ItemArray[5].ToString();
                    u.UserTypeCode = dRow.ItemArray[6].ToString();
                    u.UserTypeDescription = dRow.ItemArray[7].ToString();
                }
            }

            lblADUser.Text = gUserName;

            lblUserTypeDesc.Text = u.UserTypeDescription;


            this.monitoringServices_GetUserSubscribtionsTableAdapter.Fill(this.dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions, currentUserName);


            populateTreeView();
        }
        private void DataServicesSubscribe_Load(object sender, EventArgs e)
        {


            GetStarted();
           getUserPrefrences();
        }



        //private void tvCustomers_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    /* Display the Text and Index of the 
        //     * selected tree node's Parent. */
        //    string xNode;

        //    if (e.Node.Parent != null &&
        //      e.Node.Parent.GetType() == typeof(TreeNode))
        //    {
        //        xNode = "Parent: " + e.Node.Parent.Text + "\n"
        //           + "Index Position: " + e.Node.Parent.Index.ToString();
        //    }
        //    else
        //    {
        //        xNode = "No parent node.";
        //    }
        //}

        private void populateTreeView()
        {


            this.getCustomerTableAdapter.FillAllCustomers(this.dS_GetCustomer.GetCustomer);
            int CustNode = 0;
            short CustId = 0;
            foreach (DataRow dRow in dS_GetCustomer.Tables[0].Rows)
            {
                tvCustomers.Nodes[0].Nodes.Add(dRow.ItemArray[2].ToString(), dRow.ItemArray[0].ToString());

                CustId = short.Parse(dRow.ItemArray[2].ToString());
                this.get_DataServices_BusByCustTableAdapter.FillAllBusByCustomer(this.dS_GetBus._Get_DataServices_BusByCust, CustId);

                foreach (DataRow dBusRow in dS_GetBus.Tables[0].Rows)
                {
                    tvCustomers.Nodes[0].Nodes[CustNode].Nodes.Add(dBusRow.ItemArray[1].ToString(), dBusRow.ItemArray[2].ToString());

                }

                //new System.Nullable<short>(((short)(System.Convert.ChangeType(dRow.ItemArray[2].ToString(), typeof(short))))));
               // CheckLeafNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode]);
              //  CheckCustNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode], CustId);
                CustNode += 1;
            }

            //CheckAllNodesFromDb(tvCustomers.Nodes[0]);
            tvCustomers.Nodes[0].Expand();
            
            //Populate SPN Groups


            // TODO: This line of code loads data into the 'dS_SpnGroups._Get_DataServices_AllGroups' table. You can move, or remove it, as needed.
            this.get_DataServices_AllGroupsTableAdapter.Fill(this.dS_SpnGroups._Get_DataServices_AllGroups);


            foreach (DataRow dRow in dS_SpnGroups.Tables[0].Rows)
            {


                tvSPNGroups.Nodes[0].Nodes.Add(dRow.ItemArray[0].ToString(), dRow.ItemArray[1].ToString());


            }

            //tvSPNGroups.Nodes[0].Expand();
            
      
            //CheckLeafNodesFromDb(tvSPNGroups.Nodes[0]);
            //CheckAllNodesFromDb(tvSPNGroups.Nodes[0]);



            //Populate Report List
            this.get_DataServices_AllReportListTableAdapter1.Fill(this.dS_ReportList1._Get_DataServices_AllReportList);


            foreach (DataRow dRow in dS_ReportList1.Tables[0].Rows)
            {


                tvAllReports.Nodes[0].Nodes.Add(dRow.ItemArray[0].ToString(), dRow.ItemArray[1].ToString());


            }

            //tvAllReports.Nodes[0].Expand();
            //CheckLeafNodesFromDb(tvAllReports.Nodes[0]);
            //CheckAllNodesFromDb(tvAllReports.Nodes[0]);
            
        }

        private void getUserPrefrences()
        {

            int CustNode = 0;
            short CustId = 0;
            tvCustomers.Nodes[0].Checked = false;
            CheckAllChildNodes(tvCustomers.Nodes[0], false);

            tvSPNGroups.Nodes[0].Checked = false;
            CheckAllChildNodes(tvSPNGroups.Nodes[0], false);

            tvAllReports.Nodes[0].Checked = false;
            CheckAllChildNodes(tvAllReports.Nodes[0], false);

            foreach (DataRow dRow in dS_GetCustomer.Tables[0].Rows)
            {
               // tvCustomers.Nodes[0].Nodes.Add(dRow.ItemArray[2].ToString(), dRow.ItemArray[0].ToString());

                CustId = short.Parse(dRow.ItemArray[2].ToString());
                

                //new System.Nullable<short>(((short)(System.Convert.ChangeType(dRow.ItemArray[2].ToString(), typeof(short))))));
                CheckLeafNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode]);
                CheckCustNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode], CustId);
                CustNode += 1;
            }

            CheckAllNodesFromDb(tvCustomers.Nodes[0]);
            tvCustomers.Nodes[0].Expand();

            tvSPNGroups.Nodes[0].Expand();           
      
            CheckLeafNodesFromDb(tvSPNGroups.Nodes[0]);
            CheckAllNodesFromDb(tvSPNGroups.Nodes[0]);

            tvAllReports.Nodes[0].Expand();
            CheckLeafNodesFromDb(tvAllReports.Nodes[0]);
            CheckAllNodesFromDb(tvAllReports.Nodes[0]);

            
        }

        
        private void tvSPNGroups_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }

            }
        }
        

        private void tvCustomers_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }

            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively. 
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Check if all customers are selected

            //string selectedUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //selectedUser = "bus/kSiniard";

            string selectedUser = currentUserName;

            int IsError = 0;
            string UserMessage = String.Empty;


            try
            {
             InsertCustomers(selectedUser);
             InsertGroups(selectedUser);
             InsertReports(selectedUser);
            }
            catch
            {
                IsError = 1;
            }

            if (IsError == 0)
            {
                UserMessage = " User Preferences Saved";
            }
            else
            {
                UserMessage = "There was an error during the trasaction.";
            }

            lblError.Text = UserMessage;
        }

        private void InsertCustomers(string selectedUser)
        {
            var checkedNodes = tvCustomers.Nodes.Cast<TreeNode>().Where(x => x.Checked);
            var selectedValues = checkedNodes.Select(x => Convert.ToString(x.Name));

            List<string> listOfBus = new List<string>();
            List<string> listOfCustomers = new List<string>();

            string AllBus = "F";
            if (selectedValues.Count() == 0)
            {
                // Get the customers
                ListOfCheckedCustomers(listOfCustomers);
                // Get the buses
                ListOfCheckedBus(listOfBus);
            }
            else
            {
                AllBus = "T";

            }

            string csvListOfCustomer = string.Join(",", listOfCustomers.ToArray());
            string csvListOfBus = string.Join(",", listOfBus.ToArray());

            WriteCSVFileToDB(selectedUser, AllBus, csvListOfCustomer, csvListOfBus);
        }

        private void ListOfCheckedCustomers(List<string> listOfCustomers)
        {
          
            IEnumerable<TreeNode> checkedNodesCust = null;
            IEnumerable<string> selectedValuesCust = null;
            checkedNodesCust = tvCustomers.Nodes[0].Nodes.Cast<TreeNode>().Where(x => x.Checked);
            selectedValuesCust = checkedNodesCust.Select(x => Convert.ToString(x.Name));
            if (selectedValuesCust.Count() != 0)
            {
                foreach (var ro in selectedValuesCust)
                {
                    listOfCustomers.Add(ro.ToString());
                }

            }
        }


        private void ListOfCheckedGroups(List<string> listOfGroups)
        {

            IEnumerable<TreeNode> checkedNodesGroups = null;
            IEnumerable<string> selectedValuesGroups = null;
            checkedNodesGroups = tvSPNGroups.Nodes[0].Nodes.Cast<TreeNode>().Where(x => x.Checked);
            selectedValuesGroups = checkedNodesGroups.Select(x => Convert.ToString(x.Name));
            if (selectedValuesGroups.Count() != 0)
            {
                foreach (var ro in selectedValuesGroups)
                {
                    listOfGroups.Add(ro.ToString());
                }

            }
        }


        private void ListOfCheckedBus(List<string> listOfBus)
        {
            foreach (TreeNode node in tvCustomers.Nodes[0].Nodes)
            {
                IEnumerable<TreeNode> checkedNodesBus = null;
                IEnumerable<string> selectedValuesBus = null;

                if (node.Nodes.Count > 0)
                {
                    checkedNodesBus = node.Nodes.Cast<TreeNode>().Where(x => x.Checked);
                    selectedValuesBus = checkedNodesBus.Select(x => Convert.ToString(x.Name));
                    if (selectedValuesBus.Count() != 0)
                    {
                        foreach (var ro in selectedValuesBus)
                        {
                            listOfBus.Add(ro.ToString());
                        }

                    }
                }

            }
        }

        public static void WriteCSVFileToDB(string selectedUser,string AllBus, string csvListOfCustomer, string csvListOfBus)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();
        
            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-InsertUserSubscribtion]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@SelectedUser", selectedUser);
            comm.Parameters.AddWithValue("@AllBus", AllBus);
            comm.Parameters.AddWithValue("@CsvListOfCustomer", csvListOfCustomer);
            comm.Parameters.AddWithValue("@CsvListOfBus", csvListOfBus);

            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Do nothing
            }
            finally
            {
                comm.Connection.Close();
            }


    
         


        }

        public static void WriteCSVFileToDBGroups(string selectedUser, string AllGroups, string csvListOfGroups)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();


            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-InsertUserSubscribtionGroups]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@SelectedUser", selectedUser);
            comm.Parameters.AddWithValue("@AllGroups", AllGroups);
            comm.Parameters.AddWithValue("@CsvListOfGroups", csvListOfGroups);
           
            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Do nothing
            }
            finally
            {
                comm.Connection.Close();
            }






        }

        private void InsertGroups(string selectedUser)
        {
            var checkedNodes = tvSPNGroups.Nodes.Cast<TreeNode>().Where(x => x.Checked);
            var selectedValues = checkedNodes.Select(x => Convert.ToString(x.Name));

            List<string> listOfGroups = new List<string>();


            string AllGroups = "F";
            if (selectedValues.Count() == 0)
            {
                // Get the Groups
               
                ListOfCheckedGroups(listOfGroups);
              
            }
            else
            {
                AllGroups = "T";

            }

            string csvListOfGroups = string.Join(",", listOfGroups.ToArray());


            WriteCSVFileToDBGroups(selectedUser, AllGroups, csvListOfGroups);
        }


        public static void WriteCSVFileToDBReports(string selectedUser, string AllReports, string csvListOfReports)
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();


            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-InsertUserSubscribtionReports]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@SelectedUser", selectedUser);
            comm.Parameters.AddWithValue("@AllReports", AllReports);
            comm.Parameters.AddWithValue("@CsvListOfReports", csvListOfReports);

            // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 0;
            comm.Connection.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Do nothing
            }
            finally
            {
                comm.Connection.Close();
            }
         }
        private void InsertReports(string selectedUser)
        {
            var checkedNodes = tvAllReports.Nodes.Cast<TreeNode>().Where(x => x.Checked);
            var selectedValues = checkedNodes.Select(x => Convert.ToString(x.Name));

            List<string> listOfReports = new List<string>();


            string AllReports = "F";
            if (selectedValues.Count() == 0)
            {
                // Get the Reports

                ListOfCheckedReports(listOfReports);

            }
            else
            {
                AllReports = "T";

            }

            string csvListOfReports = string.Join(",", listOfReports.ToArray());


            WriteCSVFileToDBReports(selectedUser, AllReports, csvListOfReports);
        }

        private void ListOfCheckedReports(List<string> listOfReports)
        {

            IEnumerable<TreeNode> checkedNodesReports = null;
            IEnumerable<string> selectedValuesReports = null;
            checkedNodesReports = tvAllReports.Nodes[0].Nodes.Cast<TreeNode>().Where(x => x.Checked);
            selectedValuesReports = checkedNodesReports.Select(x => Convert.ToString(x.Name));
            if (selectedValuesReports.Count() != 0)
            {
                foreach (var ro in selectedValuesReports)
                {
                    listOfReports.Add(ro.ToString());
                }

            }
        }


        
        //private void ListOfCheckedReports(List<string> listOfReports)
        //{
        //    foreach (TreeNode node in tvAllReports.Nodes[0].Nodes)
        //    {
        //        IEnumerable<TreeNode> checkedNodesReports = null;
        //        IEnumerable<string> selectedValuesReports = null;

        //        if (node.Nodes.Count > 0)
        //        {
        //            checkedNodesReports = node.Nodes.Cast<TreeNode>().Where(x => x.Checked);
        //            selectedValuesReports = checkedNodesReports.Select(x => Convert.ToString(x.Name));
        //            if (selectedValuesReports.Count() != 0)
        //            {
        //                foreach (var ro in selectedValuesReports)
        //                {
        //                    listOfReports.Add(ro.ToString());
        //                }

        //            }
        //        }

        //    }
        //}



        private void CheckLeafNodesFromDb(TreeNode treeNode)
        {



               //var query = from a in ds.Tables[0].AsEnumerable()
               //         where a.Field<string>("Name") == "Miller"
               //         select a;
            bool nodeChecked = false;

            string DatType="V"; 
            if (treeNode.Text == "All Reports")
            {
                //Get Reports Checked
                DatType = "R";

            }
            else if (treeNode.Text == "All SPN Groups" )
            {
                DatType = "G";
                
            }
            else if (treeNode.Text == "All Customers")
            {
                DatType = "V";

            }



            var query = from r in dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions
                        where r.Field<string>("DatType") == DatType
                        select r.ID;

            //if (query.Count() > 0)
            //{
            //    treeNode.Expand();
            //}


            bool dataFoundInNode = false;

            foreach (TreeNode node in treeNode.Nodes)
            {
                nodeChecked = false;
                    foreach (var ID in query)
                    {
                        if (short.Parse(node.Name) == ID)
                        {
                            nodeChecked = true;
                            dataFoundInNode = true;
                        }
                        
                    }
                node.Checked = nodeChecked;
                
            }

            if (dataFoundInNode == true)
            {

                treeNode.Expand();
            }
        }

        private void CheckCustNodesFromDb(TreeNode treeNode,int CustId)
        {

            bool nodeChecked = false;

            string DatType = "V";
            if (treeNode.Text == "All Reports")
            {
                //Get Reports Checked
                DatType = "R";

            }
            else if (treeNode.Text == "All SPN Groups")
            {
                DatType = "G";

            }
            else if (treeNode.Text == "All Customers")
            {
                DatType = "V";

            }

            var queryCust = from r in dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions
                            where (r.Field<string>("DatType") == DatType && r.Field<int>("CustomerID") == CustId)
                            select r.CustomerID;
                        foreach (var CustomerID in queryCust)
            {
                nodeChecked = true;
                treeNode.Checked = nodeChecked;
                this.CheckAllChildNodes(treeNode, nodeChecked);
            }
        }

        private void CheckAllNodesFromDb(TreeNode treeNode)
        {
           
            bool nodeChecked = false;

            string DatType = "V";
            if (treeNode.Text == "All Reports")
            {
                //Get Reports Checked
                DatType = "R";

            }
            else if (treeNode.Text == "All SPN Groups")
            {
                DatType = "G";

            }
            else if (treeNode.Text == "All Customers")
            {
                DatType = "V";

            }

            //if (DatType == "V")
            //{

            //    var queryCust = from r in dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions
            //                    where (r.Field<string>("DatType") == DatType && r.Field<int>("CustomerID") != 0)
            //                    select r.CustomerID;

            //    foreach (var CustomerID in queryCust)
            //    {
            //        nodeChecked = true;
            //        treeNode.Nodes[CustomerID].Checked = nodeChecked;
            //        this.CheckAllChildNodes(treeNode.Nodes[CustomerID], nodeChecked);
            //    }

            //}


            var query = from r in dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions
                        where (r.Field<string>("DatType") == DatType && r.Field<byte>("CheckAll") == 1)
                        select r.CheckAll;

            if (query.Count() > 0)
            {
                nodeChecked = true;
                treeNode.Checked = nodeChecked;
                this.CheckAllChildNodes(treeNode, nodeChecked);
            }

        }

        private void tvSPNGroups_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DataServices trd = new DataServices();
            trd.Show();
            this.Hide();
        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }

        private void fillAllUsersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_DataServices_UserDetailsTableAdapter.FillAllUsers(this.dS_UserInformation._Get_DataServices_UserDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillAllUsersToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.get_DataServices_UserDetailsTableAdapter.FillAllUsers(this.dS_UserInformation._Get_DataServices_UserDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillAllUsersToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.get_DataServices_UserDetailsTableAdapter.FillAllUsers(this.dS_UserInformation._Get_DataServices_UserDetails);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbAllUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUserName = cbAllUser.SelectedValue.ToString();
            currentCleanUserName = currentUserName;
            this.dS_UserSubscribtions.Clear();
            this.monitoringServices_GetUserSubscribtionsTableAdapter.Fill(this.dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions, currentUserName);
            
            getUserPrefrences();


        }

        private void lblUserTypeDesc_Click(object sender, EventArgs e)
        {

        }

        //private void cbAllUser_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    string eUserName = string.Empty;
        //    eUserName = cbAllUser.SelectedItem.ToString();
        //    this.dS_UserSubscribtions.Clear();
        //    this.monitoringServices_GetUserSubscribtionsTableAdapter.Fill(this.dS_UserSubscribtions.MonitoringServices_GetUserSubscribtions, eUserName);

        //    int CustNode = 0;
        //    short CustId = 0;
        //    foreach (DataRow dRow in dS_GetCustomer.Tables[0].Rows)
        //    {
        //        CheckLeafNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode]);
        //        CheckCustNodesFromDb(tvCustomers.Nodes[0].Nodes[CustNode], CustId);
        //        CustNode += 1;
        //    }

        //    CheckAllNodesFromDb(tvCustomers.Nodes[0]);
        //    tvCustomers.Nodes[0].Expand();
            
            
         
        //}
       
    }
}


