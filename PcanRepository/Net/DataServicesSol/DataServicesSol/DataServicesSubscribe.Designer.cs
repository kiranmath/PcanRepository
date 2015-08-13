namespace DataServicesSol
{
    partial class DataServicesSubscribe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All Customers");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All SPN Groups");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("All Reports");
            System.Windows.Forms.Label label1;
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbDataFilter = new System.Windows.Forms.GroupBox();
            this.lblUserTypeDesc = new System.Windows.Forms.Label();
            this.lblADUser = new System.Windows.Forms.Label();
            this.tvCustomers = new System.Windows.Forms.TreeView();
            this.dS_GetCustomer = new DataServicesSol.DS_GetCustomer();
            this.getCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerTableAdapter = new DataServicesSol.DS_GetCustomerTableAdapters.GetCustomerTableAdapter();
            this.tableAdapterManager1 = new DataServicesSol.DS_GetCustomerTableAdapters.TableAdapterManager();
            this.dS_GetBus = new DataServicesSol.dS_GetBus();
            this.get_DataServices_BusByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_BusByCustTableAdapter = new DataServicesSol.dS_GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter();
            this.tableAdapterManager2 = new DataServicesSol.dS_GetBusTableAdapters.TableAdapterManager();
            this.tvSPNGroups = new System.Windows.Forms.TreeView();
            this.dS_SpnGroups = new DataServicesSol.dS_SpnGroups();
            this.get_DataServices_AllGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_AllGroupsTableAdapter = new DataServicesSol.dS_SpnGroupsTableAdapters.Get_DataServices_AllGroupsTableAdapter();
            this.tableAdapterManager3 = new DataServicesSol.dS_SpnGroupsTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dS_ReportList1 = new DataServicesSol.dS_ReportList();
            this.get_DataServices_AllReportListTableAdapter1 = new DataServicesSol.DataSet2TableAdapters.Get_DataServices_AllReportListTableAdapter();
            this.tvAllReports = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dS_UserSubscribtions = new DataServicesSol.dS_UserSubscribtions();
            this.monitoringServices_GetUserSubscribtionsTableAdapter = new DataServicesSol.dS_UserSubscribtionsTableAdapters.MonitoringServices_GetUserSubscribtionsTableAdapter();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cbAllUser = new System.Windows.Forms.ComboBox();
            this.dS_UserInformation = new DataServicesSol.dS_UserInformation();
            this.get_DataServices_UserDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_UserDetailsTableAdapter = new DataServicesSol.dS_UserInformationTableAdapters.Get_DataServices_UserDetailsTableAdapter();
            this.tableAdapterManager = new DataServicesSol.dS_UserInformationTableAdapters.TableAdapterManager();
            this.dS_UserInformation1 = new DataServicesSol.dS_UserInformation();
            this.get_DataServices_UserDetailsTableAdapter1 = new DataServicesSol.dS_UserInformationTableAdapters.Get_DataServices_UserDetailsTableAdapter();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbDataFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_BusByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SpnGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_AllGroupsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportList1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserSubscribtions)).BeginInit();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_UserDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserInformation1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.InitialImage = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.Location = new System.Drawing.Point(725, 17);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(425, 58);
            this.pbLogo.TabIndex = 11;
            this.pbLogo.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(300, 19);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "Data Services : Preferences";
            // 
            // gbDataFilter
            // 
            this.gbDataFilter.AccessibleDescription = " Charge and Dock Summary Reports By Week";
            this.gbDataFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDataFilter.Controls.Add(this.lblUserTypeDesc);
            this.gbDataFilter.Controls.Add(this.lblADUser);
            this.gbDataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbDataFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataFilter.Location = new System.Drawing.Point(16, 31);
            this.gbDataFilter.Name = "gbDataFilter";
            this.gbDataFilter.Size = new System.Drawing.Size(290, 59);
            this.gbDataFilter.TabIndex = 14;
            this.gbDataFilter.TabStop = false;
            // 
            // lblUserTypeDesc
            // 
            this.lblUserTypeDesc.AutoSize = true;
            this.lblUserTypeDesc.Location = new System.Drawing.Point(147, 23);
            this.lblUserTypeDesc.Name = "lblUserTypeDesc";
            this.lblUserTypeDesc.Size = new System.Drawing.Size(83, 15);
            this.lblUserTypeDesc.TabIndex = 1;
            this.lblUserTypeDesc.Text = "UserTypeDesc";
            this.lblUserTypeDesc.Click += new System.EventHandler(this.lblUserTypeDesc_Click);
            // 
            // lblADUser
            // 
            this.lblADUser.AutoSize = true;
            this.lblADUser.Location = new System.Drawing.Point(17, 23);
            this.lblADUser.Name = "lblADUser";
            this.lblADUser.Size = new System.Drawing.Size(47, 15);
            this.lblADUser.TabIndex = 0;
            this.lblADUser.Text = "AdUser";
            // 
            // tvCustomers
            // 
            this.tvCustomers.CheckBoxes = true;
            this.tvCustomers.Location = new System.Drawing.Point(23, 21);
            this.tvCustomers.Name = "tvCustomers";
            treeNode4.Name = "AllCust";
            treeNode4.Text = "All Customers";
            this.tvCustomers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tvCustomers.Size = new System.Drawing.Size(240, 358);
            this.tvCustomers.TabIndex = 15;
            this.tvCustomers.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCustomers_AfterCheck);
            // 
            // dS_GetCustomer
            // 
            this.dS_GetCustomer.DataSetName = "DS_GetCustomer";
            this.dS_GetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCustomerBindingSource
            // 
            this.getCustomerBindingSource.DataMember = "GetCustomer";
            this.getCustomerBindingSource.DataSource = this.dS_GetCustomer;
            // 
            // getCustomerTableAdapter
            // 
            this.getCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = DataServicesSol.DS_GetCustomerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_GetBus
            // 
            this.dS_GetBus.DataSetName = "dS_GetBus";
            this.dS_GetBus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_BusByCustBindingSource
            // 
            this.get_DataServices_BusByCustBindingSource.DataMember = "Get-DataServices-BusByCust";
            this.get_DataServices_BusByCustBindingSource.DataSource = this.dS_GetBus;
            // 
            // get_DataServices_BusByCustTableAdapter
            // 
            this.get_DataServices_BusByCustTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.UpdateOrder = DataServicesSol.dS_GetBusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tvSPNGroups
            // 
            this.tvSPNGroups.CheckBoxes = true;
            this.tvSPNGroups.Location = new System.Drawing.Point(23, 20);
            this.tvSPNGroups.Name = "tvSPNGroups";
            treeNode5.Name = "AllSPNGroups";
            treeNode5.Text = "All SPN Groups";
            this.tvSPNGroups.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.tvSPNGroups.Size = new System.Drawing.Size(221, 358);
            this.tvSPNGroups.TabIndex = 16;
            this.tvSPNGroups.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvSPNGroups_AfterCheck);
            this.tvSPNGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSPNGroups_AfterSelect);
            // 
            // dS_SpnGroups
            // 
            this.dS_SpnGroups.DataSetName = "dS_SpnGroups";
            this.dS_SpnGroups.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_AllGroupsBindingSource
            // 
            this.get_DataServices_AllGroupsBindingSource.DataMember = "Get-DataServices-AllGroups";
            this.get_DataServices_AllGroupsBindingSource.DataSource = this.dS_SpnGroups;
            // 
            // get_DataServices_AllGroupsTableAdapter
            // 
            this.get_DataServices_AllGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.Connection = null;
            this.tableAdapterManager3.UpdateOrder = DataServicesSol.dS_SpnGroupsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvCustomers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 388);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvSPNGroups);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(303, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 388);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Groups";
            // 
            // dS_ReportList1
            // 
            this.dS_ReportList1.DataSetName = "DataSet2";
            this.dS_ReportList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_AllReportListTableAdapter1
            // 
            this.get_DataServices_AllReportListTableAdapter1.ClearBeforeFill = true;
            // 
            // tvAllReports
            // 
            this.tvAllReports.CheckBoxes = true;
            this.tvAllReports.Location = new System.Drawing.Point(23, 20);
            this.tvAllReports.Name = "tvAllReports";
            treeNode6.Name = "AllReports";
            treeNode6.Text = "All Reports";
            this.tvAllReports.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.tvAllReports.Size = new System.Drawing.Size(221, 358);
            this.tvAllReports.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tvAllReports);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(600, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 388);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(739, 587);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(125, 23);
            this.btnOK.TabIndex = 20;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.AllowDrop = true;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancel.Location = new System.Drawing.Point(600, 587);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(108, 23);
            this.btCancel.TabIndex = 21;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dS_UserSubscribtions
            // 
            this.dS_UserSubscribtions.DataSetName = "dS_UserSubscribtions";
            this.dS_UserSubscribtions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monitoringServices_GetUserSubscribtionsTableAdapter
            // 
            this.monitoringServices_GetUserSubscribtionsTableAdapter.ClearBeforeFill = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblError);
            this.gbStatus.Location = new System.Drawing.Point(16, 567);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(551, 65);
            this.gbStatus.TabIndex = 22;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            this.gbStatus.Enter += new System.EventHandler(this.gbStatus_Enter);
            // 
            // lblError
            // 
            this.lblError.AllowDrop = true;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(17, 20);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 14);
            this.lblError.TabIndex = 0;
            // 
            // cbAllUser
            // 
            this.cbAllUser.DisplayMember = "FullName";
            this.cbAllUser.FormattingEnabled = true;
            this.cbAllUser.Location = new System.Drawing.Point(99, 113);
            this.cbAllUser.Name = "cbAllUser";
            this.cbAllUser.Size = new System.Drawing.Size(198, 21);
            this.cbAllUser.TabIndex = 23;
            this.cbAllUser.ValueMember = "AdUserID";
            this.cbAllUser.SelectedIndexChanged += new System.EventHandler(this.cbAllUser_SelectedIndexChanged);
            // 
            // dS_UserInformation
            // 
            this.dS_UserInformation.DataSetName = "dS_UserInformation";
            this.dS_UserInformation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_UserDetailsBindingSource
            // 
            this.get_DataServices_UserDetailsBindingSource.DataMember = "Get-DataServices-UserDetails";
            this.get_DataServices_UserDetailsBindingSource.DataSource = this.dS_UserInformation;
            // 
            // get_DataServices_UserDetailsTableAdapter
            // 
            this.get_DataServices_UserDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = DataServicesSol.dS_UserInformationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS_UserInformation1
            // 
            this.dS_UserInformation1.DataSetName = "dS_UserInformation";
            this.dS_UserInformation1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_UserDetailsTableAdapter1
            // 
            this.get_DataServices_UserDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(24, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 13);
            label1.TabIndex = 24;
            label1.Text = "User Name";
            // 
            // DataServicesSubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(label1);
            this.Controls.Add(this.cbAllUser);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDataFilter);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHeading);
            this.Name = "DataServicesSubscribe";
            this.Text = "DataServicesSubscribe";
            this.Load += new System.EventHandler(this.DataServicesSubscribe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbDataFilter.ResumeLayout(false);
            this.gbDataFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_BusByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SpnGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_AllGroupsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportList1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserSubscribtions)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_DataServices_UserDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_UserInformation1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeading;
        private dS_UserInformation dS_UserInformation;
        private System.Windows.Forms.BindingSource get_DataServices_UserDetailsBindingSource;
        private dS_UserInformationTableAdapters.Get_DataServices_UserDetailsTableAdapter get_DataServices_UserDetailsTableAdapter;
        private dS_UserInformationTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDataFilter;
        private System.Windows.Forms.Label lblADUser;
        private System.Windows.Forms.Label lblUserTypeDesc;
        private System.Windows.Forms.TreeView tvCustomers;
        private DS_GetCustomer dS_GetCustomer;
        private System.Windows.Forms.BindingSource getCustomerBindingSource;
        private DS_GetCustomerTableAdapters.GetCustomerTableAdapter getCustomerTableAdapter;
        private DS_GetCustomerTableAdapters.TableAdapterManager tableAdapterManager1;
        private dS_GetBus dS_GetBus;
        private System.Windows.Forms.BindingSource get_DataServices_BusByCustBindingSource;
        private dS_GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter get_DataServices_BusByCustTableAdapter;
        private dS_GetBusTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TreeView tvSPNGroups;
        private dS_SpnGroups dS_SpnGroups;
        private System.Windows.Forms.BindingSource get_DataServices_AllGroupsBindingSource;
        private dS_SpnGroupsTableAdapters.Get_DataServices_AllGroupsTableAdapter get_DataServices_AllGroupsTableAdapter;
        private dS_SpnGroupsTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private dS_ReportList dS_ReportList1;
        private DataSet2TableAdapters.Get_DataServices_AllReportListTableAdapter get_DataServices_AllReportListTableAdapter1;
        private System.Windows.Forms.TreeView tvAllReports;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btCancel;
        private dS_UserSubscribtions dS_UserSubscribtions;
        private dS_UserSubscribtionsTableAdapters.MonitoringServices_GetUserSubscribtionsTableAdapter monitoringServices_GetUserSubscribtionsTableAdapter;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cbAllUser;
        private dS_UserInformation dS_UserInformation1;
        private dS_UserInformationTableAdapters.Get_DataServices_UserDetailsTableAdapter get_DataServices_UserDetailsTableAdapter1;
       
    }
}