namespace PCanDataSytemsSupport
{
    partial class CreateDecodeStoredProcByBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDecodeStoredProcByBus));
            this.GenSprocBut = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.btnOutPutFilePath = new System.Windows.Forms.Button();
            this.txtOutPutFilePath = new System.Windows.Forms.TextBox();
            this.gbDataFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileGrp = new System.Windows.Forms.TextBox();
            this.cbBus = new System.Windows.Forms.ComboBox();
            this.getDataServicesBusByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getBusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getBus = new PCanDataSytemsSupport.GetBus();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChargingStations = new System.Windows.Forms.ComboBox();
            this.getDataServicesChargingStationsByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getChargerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCharger = new PCanDataSytemsSupport.GetCharger();
            this.lblChargingStation = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.getDataServicesCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCustomer = new PCanDataSytemsSupport.GetCustomer();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.get_DataServices_CustomerTableAdapter = new PCanDataSytemsSupport.GetCustomerTableAdapters.Get_DataServices_CustomerTableAdapter();
            this.get_DataServices_ChargingStationsByCustTableAdapter = new PCanDataSytemsSupport.GetChargerTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter();
            this.get_DataServices_BusByCustTableAdapter = new PCanDataSytemsSupport.GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkListItems = new System.Windows.Forms.CheckedListBox();
            this.sfdOutPutFile = new System.Windows.Forms.SaveFileDialog();
            this.sfdOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbFilePath.SuspendLayout();
            this.gbDataFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesBusByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChargerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCharger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenSprocBut
            // 
            this.GenSprocBut.Location = new System.Drawing.Point(892, 659);
            this.GenSprocBut.Name = "GenSprocBut";
            this.GenSprocBut.Size = new System.Drawing.Size(75, 23);
            this.GenSprocBut.TabIndex = 0;
            this.GenSprocBut.Text = "Generate ...";
            this.GenSprocBut.UseVisualStyleBackColor = true;
            this.GenSprocBut.Click += new System.EventHandler(this.GenSprocBut_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(645, 71);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(312, 50);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(34, 83);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(467, 19);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Support Services : Get Sproc By Customers";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblError);
            this.gbStatus.Location = new System.Drawing.Point(436, 224);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(531, 90);
            this.gbStatus.TabIndex = 10;
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
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.btnOutPutFilePath);
            this.gbFilePath.Controls.Add(this.txtOutPutFilePath);
            this.gbFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilePath.Location = new System.Drawing.Point(34, 224);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Size = new System.Drawing.Size(382, 90);
            this.gbFilePath.TabIndex = 9;
            this.gbFilePath.TabStop = false;
            this.gbFilePath.Text = "OutPut File Path";
            // 
            // btnOutPutFilePath
            // 
            this.btnOutPutFilePath.Location = new System.Drawing.Point(336, 30);
            this.btnOutPutFilePath.Name = "btnOutPutFilePath";
            this.btnOutPutFilePath.Size = new System.Drawing.Size(23, 23);
            this.btnOutPutFilePath.TabIndex = 1;
            this.btnOutPutFilePath.Text = "..";
            this.btnOutPutFilePath.UseVisualStyleBackColor = true;
            this.btnOutPutFilePath.Click += new System.EventHandler(this.btnOutPutFilePath_Click_1);
            // 
            // txtOutPutFilePath
            // 
            this.txtOutPutFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutFilePath.Location = new System.Drawing.Point(9, 30);
            this.txtOutPutFilePath.Name = "txtOutPutFilePath";
            this.txtOutPutFilePath.Size = new System.Drawing.Size(321, 23);
            this.txtOutPutFilePath.TabIndex = 0;
            // 
            // gbDataFilter
            // 
            this.gbDataFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDataFilter.Controls.Add(this.label1);
            this.gbDataFilter.Controls.Add(this.txtFileGrp);
            this.gbDataFilter.Controls.Add(this.cbBus);
            this.gbDataFilter.Controls.Add(this.label2);
            this.gbDataFilter.Controls.Add(this.cbChargingStations);
            this.gbDataFilter.Controls.Add(this.lblChargingStation);
            this.gbDataFilter.Controls.Add(this.cbCustomer);
            this.gbDataFilter.Controls.Add(this.lblCustomer);
            this.gbDataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbDataFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataFilter.Location = new System.Drawing.Point(34, 118);
            this.gbDataFilter.Name = "gbDataFilter";
            this.gbDataFilter.Size = new System.Drawing.Size(929, 100);
            this.gbDataFilter.TabIndex = 8;
            this.gbDataFilter.TabStop = false;
            this.gbDataFilter.Text = "Data Filters";
            this.gbDataFilter.Enter += new System.EventHandler(this.gbDataFilter_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Group";
            // 
            // txtFileGrp
            // 
            this.txtFileGrp.Location = new System.Drawing.Point(448, 43);
            this.txtFileGrp.Name = "txtFileGrp";
            this.txtFileGrp.ReadOnly = true;
            this.txtFileGrp.Size = new System.Drawing.Size(116, 23);
            this.txtFileGrp.TabIndex = 8;
            // 
            // cbBus
            // 
            this.cbBus.DataSource = this.getDataServicesBusByCustBindingSource;
            this.cbBus.DisplayMember = "VIN";
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBus.FormattingEnabled = true;
            this.cbBus.Location = new System.Drawing.Point(435, 74);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(230, 23);
            this.cbBus.TabIndex = 7;
            this.cbBus.ValueMember = "VIN";
            this.cbBus.Visible = false;
            // 
            // getDataServicesBusByCustBindingSource
            // 
            this.getDataServicesBusByCustBindingSource.DataMember = "Get-DataServices-BusByCust";
            this.getDataServicesBusByCustBindingSource.DataSource = this.getBusBindingSource;
            // 
            // getBusBindingSource
            // 
            this.getBusBindingSource.DataSource = this.getBus;
            this.getBusBindingSource.Position = 0;
            // 
            // getBus
            // 
            this.getBus.DataSetName = "GetBus";
            this.getBus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bus";
            this.label2.Visible = false;
            // 
            // cbChargingStations
            // 
            this.cbChargingStations.DataSource = this.getDataServicesChargingStationsByCustBindingSource;
            this.cbChargingStations.DisplayMember = "Location";
            this.cbChargingStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChargingStations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChargingStations.FormattingEnabled = true;
            this.cbChargingStations.Location = new System.Drawing.Point(130, 74);
            this.cbChargingStations.Name = "cbChargingStations";
            this.cbChargingStations.Size = new System.Drawing.Size(229, 23);
            this.cbChargingStations.TabIndex = 5;
            this.cbChargingStations.ValueMember = "Location";
            this.cbChargingStations.Visible = false;
            // 
            // getDataServicesChargingStationsByCustBindingSource
            // 
            this.getDataServicesChargingStationsByCustBindingSource.DataMember = "Get-DataServices-ChargingStationsByCust";
            this.getDataServicesChargingStationsByCustBindingSource.DataSource = this.getChargerBindingSource;
            // 
            // getChargerBindingSource
            // 
            this.getChargerBindingSource.DataSource = this.getCharger;
            this.getChargerBindingSource.Position = 0;
            // 
            // getCharger
            // 
            this.getCharger.DataSetName = "GetCharger";
            this.getCharger.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblChargingStation
            // 
            this.lblChargingStation.AutoSize = true;
            this.lblChargingStation.Location = new System.Drawing.Point(6, 74);
            this.lblChargingStation.Name = "lblChargingStation";
            this.lblChargingStation.Size = new System.Drawing.Size(96, 15);
            this.lblChargingStation.TabIndex = 4;
            this.lblChargingStation.Text = "Charging Station";
            this.lblChargingStation.Visible = false;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.getDataServicesCustomerBindingSource;
            this.cbCustomer.DisplayMember = "CustomerName";
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(130, 40);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(230, 23);
            this.cbCustomer.TabIndex = 1;
            this.cbCustomer.ValueMember = "CustomerID";
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // getDataServicesCustomerBindingSource
            // 
            this.getDataServicesCustomerBindingSource.DataMember = "Get-DataServices-Customer";
            this.getDataServicesCustomerBindingSource.DataSource = this.getCustomerBindingSource;
            // 
            // getCustomerBindingSource
            // 
            this.getCustomerBindingSource.DataSource = this.getCustomer;
            this.getCustomerBindingSource.Position = 0;
            // 
            // getCustomer
            // 
            this.getCustomer.DataSetName = "GetCustomer";
            this.getCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(6, 40);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(61, 15);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer";
            // 
            // get_DataServices_CustomerTableAdapter
            // 
            this.get_DataServices_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_ChargingStationsByCustTableAdapter
            // 
            this.get_DataServices_ChargingStationsByCustTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_BusByCustTableAdapter
            // 
            this.get_DataServices_BusByCustTableAdapter.ClearBeforeFill = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(672, 500);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(8, 45);
            this.trackBar1.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkListItems);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 299);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Db Objects";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkListItems
            // 
            this.chkListItems.CheckOnClick = true;
            this.chkListItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListItems.FormattingEnabled = true;
            this.chkListItems.Location = new System.Drawing.Point(13, 22);
            this.chkListItems.Name = "chkListItems";
            this.chkListItems.Size = new System.Drawing.Size(884, 256);
            this.chkListItems.TabIndex = 15;
            // 
            // CreateDecodeStoredProcByBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.gbDataFilter);
            this.Controls.Add(this.GenSprocBut);
            this.Name = "CreateDecodeStoredProcByBus";
            this.Text = "CreateDecodeStoredProcByBus";
            this.Load += new System.EventHandler(this.CreateDecodeStoredProcByBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            this.gbDataFilter.ResumeLayout(false);
            this.gbDataFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesBusByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getChargerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCharger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenSprocBut;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.Button btnOutPutFilePath;
        private System.Windows.Forms.TextBox txtOutPutFilePath;
        private System.Windows.Forms.GroupBox gbDataFilter;
        private System.Windows.Forms.ComboBox cbBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChargingStations;
        private System.Windows.Forms.Label lblChargingStation;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.BindingSource getCustomerBindingSource;
        private GetCustomer getCustomer;
        private System.Windows.Forms.BindingSource getDataServicesCustomerBindingSource;
        private GetCustomerTableAdapters.Get_DataServices_CustomerTableAdapter get_DataServices_CustomerTableAdapter;
        private System.Windows.Forms.BindingSource getDataServicesChargingStationsByCustBindingSource;
        private System.Windows.Forms.BindingSource getChargerBindingSource;
        private GetCharger getCharger;
        private GetChargerTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter get_DataServices_ChargingStationsByCustTableAdapter;
        private System.Windows.Forms.BindingSource getDataServicesBusByCustBindingSource;
        private System.Windows.Forms.BindingSource getBusBindingSource;
        private GetBus getBus;
        private GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter get_DataServices_BusByCustTableAdapter;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtFileGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chkListItems;
        private System.Windows.Forms.SaveFileDialog sfdOutPutFile;
        private System.Windows.Forms.FolderBrowserDialog sfdOutputFolder;
    }
}