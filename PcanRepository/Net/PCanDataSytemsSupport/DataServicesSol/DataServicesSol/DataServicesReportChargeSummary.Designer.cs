namespace DataServicesSol
{
    partial class DataServicesChargeStationSummary
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
            this.btnOk = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnOutPutFilePath = new System.Windows.Forms.Button();
            this.txtOutPutFilePath = new System.Windows.Forms.TextBox();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChargingStations = new System.Windows.Forms.ComboBox();
            this.getDataServicesChargingStationsByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetChargingStations = new DataServicesSol.dS_GetChargingStations();
            this.lblError = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblChargingStation = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.dS_GetCustomer = new DataServicesSol.DS_GetCustomer();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dS_ReportViewer = new DataServicesSol.dS_ReportViewer();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbWeek = new System.Windows.Forms.ComboBox();
            this.getDataServicesChargeSummaryIsoWeekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSGetChargeSummaryIsoWeekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetChargeSummaryIsoWeek = new DataServicesSol.dS_GetChargeSummaryIsoWeek();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.dSGetChargeSummaryIsoWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetDataTypes = new DataServicesSol.dS_GetDataTypes();
            this.get_DataServices_DataItemsTableAdapter = new DataServicesSol.dS_GetDataTypesTableAdapters.Get_DataServices_DataItemsTableAdapter();
            this.getCustomerTableAdapter = new DataServicesSol.DS_GetCustomerTableAdapters.GetCustomerTableAdapter();
            this.get_DataServices_ChargingStationsByCustTableAdapter = new DataServicesSol.dS_GetChargingStationsTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter();
            this.getDataServicesChargeSummaryIsoWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_ChargeSummary_IsoWeekTableAdapter = new DataServicesSol.dS_GetChargeSummaryIsoWeekTableAdapters.Get_DataServices_ChargeSummary_IsoWeekTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sfdOutPutFile = new System.Windows.Forms.SaveFileDialog();
            this.get_DataServices_ReportRequestsTableAdapter = new DataServicesSol.dS_GetReportRequestsTableAdapters.Get_DataServices_ReportRequestsTableAdapter();
            this.folderBrowserTrace = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbFilePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargingStations)).BeginInit();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargeSummaryIsoWeekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetChargeSummaryIsoWeekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargeSummaryIsoWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetChargeSummaryIsoWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetDataTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargeSummaryIsoWeekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1044, 610);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.InitialImage = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.Location = new System.Drawing.Point(736, 58);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(425, 58);
            this.pbLogo.TabIndex = 16;
            this.pbLogo.TabStop = false;
            // 
            // btnOutPutFilePath
            // 
            this.btnOutPutFilePath.Location = new System.Drawing.Point(336, 30);
            this.btnOutPutFilePath.Name = "btnOutPutFilePath";
            this.btnOutPutFilePath.Size = new System.Drawing.Size(23, 23);
            this.btnOutPutFilePath.TabIndex = 1;
            this.btnOutPutFilePath.Text = "..";
            this.btnOutPutFilePath.UseVisualStyleBackColor = true;
            this.btnOutPutFilePath.Click += new System.EventHandler(this.btnOutPutFilePath_Click);
            // 
            // txtOutPutFilePath
            // 
            this.txtOutPutFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutFilePath.Location = new System.Drawing.Point(9, 30);
            this.txtOutPutFilePath.Name = "txtOutPutFilePath";
            this.txtOutPutFilePath.ReadOnly = true;
            this.txtOutPutFilePath.Size = new System.Drawing.Size(321, 23);
            this.txtOutPutFilePath.TabIndex = 0;
            this.txtOutPutFilePath.TextChanged += new System.EventHandler(this.txtOutPutFilePath_TextChanged);
            // 
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.btnOutPutFilePath);
            this.gbFilePath.Controls.Add(this.txtOutPutFilePath);
            this.gbFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilePath.Location = new System.Drawing.Point(63, 504);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Size = new System.Drawing.Size(378, 65);
            this.gbFilePath.TabIndex = 18;
            this.gbFilePath.TabStop = false;
            this.gbFilePath.Text = "OutPut Folder Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Week";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year";
            // 
            // cbChargingStations
            // 
            this.cbChargingStations.DataSource = this.getDataServicesChargingStationsByCustBindingSource;
            this.cbChargingStations.DisplayMember = "Location";
            this.cbChargingStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChargingStations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChargingStations.FormattingEnabled = true;
            this.cbChargingStations.Location = new System.Drawing.Point(205, 84);
            this.cbChargingStations.Name = "cbChargingStations";
            this.cbChargingStations.Size = new System.Drawing.Size(247, 23);
            this.cbChargingStations.TabIndex = 7;
            this.cbChargingStations.ValueMember = "ChargingStationID";
            // 
            // getDataServicesChargingStationsByCustBindingSource
            // 
            this.getDataServicesChargingStationsByCustBindingSource.DataMember = "Get-DataServices-ChargingStationsByCust";
            this.getDataServicesChargingStationsByCustBindingSource.DataSource = this.dS_GetChargingStations;
            // 
            // dS_GetChargingStations
            // 
            this.dS_GetChargingStations.DataSetName = "dS_GetChargingStations";
            this.dS_GetChargingStations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblError);
            this.gbStatus.Location = new System.Drawing.Point(461, 504);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(658, 65);
            this.gbStatus.TabIndex = 19;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // lblChargingStation
            // 
            this.lblChargingStation.AutoSize = true;
            this.lblChargingStation.Location = new System.Drawing.Point(81, 92);
            this.lblChargingStation.Name = "lblChargingStation";
            this.lblChargingStation.Size = new System.Drawing.Size(85, 13);
            this.lblChargingStation.TabIndex = 6;
            this.lblChargingStation.Text = "Charging Station";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.dS_GetCustomer;
            this.cbCustomer.DisplayMember = "GetCustomer.CustomerName";
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(205, 38);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(247, 23);
            this.cbCustomer.TabIndex = 3;
            this.cbCustomer.ValueMember = "GetCustomer.CustomerID";
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged_1);
            // 
            // dS_GetCustomer
            // 
            this.dS_GetCustomer.DataSetName = "DS_GetCustomer";
            this.dS_GetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(963, 610);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dS_ReportViewer
            // 
            this.dS_ReportViewer.DataSetName = "dS_ReportViewer";
            this.dS_ReportViewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(23, 50);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(478, 19);
            this.lblHeading.TabIndex = 15;
            this.lblHeading.Text = "Data Services : Charge And Dock Summary";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(81, 38);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbWeek);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChargingStations);
            this.groupBox1.Controls.Add(this.lblChargingStation);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Location = new System.Drawing.Point(63, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 327);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Parameters";
            // 
            // cbWeek
            // 
            this.cbWeek.DataSource = this.getDataServicesChargeSummaryIsoWeekBindingSource1;
            this.cbWeek.DisplayMember = "IsoWeek";
            this.cbWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeek.FormattingEnabled = true;
            this.cbWeek.Location = new System.Drawing.Point(205, 185);
            this.cbWeek.Name = "cbWeek";
            this.cbWeek.Size = new System.Drawing.Size(247, 23);
            this.cbWeek.TabIndex = 13;
            this.cbWeek.ValueMember = "IsoWeek";
            // 
            // getDataServicesChargeSummaryIsoWeekBindingSource1
            // 
            this.getDataServicesChargeSummaryIsoWeekBindingSource1.DataMember = "Get-DataServices-ChargeSummary-IsoWeek";
            this.getDataServicesChargeSummaryIsoWeekBindingSource1.DataSource = this.dSGetChargeSummaryIsoWeekBindingSource1;
            // 
            // dSGetChargeSummaryIsoWeekBindingSource1
            // 
            this.dSGetChargeSummaryIsoWeekBindingSource1.DataSource = this.dS_GetChargeSummaryIsoWeek;
            this.dSGetChargeSummaryIsoWeekBindingSource1.Position = 0;
            // 
            // dS_GetChargeSummaryIsoWeek
            // 
            this.dS_GetChargeSummaryIsoWeek.DataSetName = "dS_GetChargeSummaryIsoWeek";
            this.dS_GetChargeSummaryIsoWeek.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2015",
            "2016",
            "2017"});
            this.cbYear.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbYear.Location = new System.Drawing.Point(205, 130);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(247, 23);
            this.cbYear.TabIndex = 12;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // dSGetChargeSummaryIsoWeekBindingSource
            // 
            this.dSGetChargeSummaryIsoWeekBindingSource.DataSource = this.dS_GetChargeSummaryIsoWeek;
            this.dSGetChargeSummaryIsoWeekBindingSource.Position = 0;
            // 
            // dS_GetDataTypes
            // 
            this.dS_GetDataTypes.DataSetName = "dS_GetDataTypes";
            this.dS_GetDataTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // get_DataServices_DataItemsTableAdapter
            // 
            this.get_DataServices_DataItemsTableAdapter.ClearBeforeFill = true;
            // 
            // getCustomerTableAdapter
            // 
            this.getCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_ChargingStationsByCustTableAdapter
            // 
            this.get_DataServices_ChargingStationsByCustTableAdapter.ClearBeforeFill = true;
            // 
            // getDataServicesChargeSummaryIsoWeekBindingSource
            // 
            this.getDataServicesChargeSummaryIsoWeekBindingSource.DataMember = "Get-DataServices-ChargeSummary-IsoWeek";
            this.getDataServicesChargeSummaryIsoWeekBindingSource.DataSource = this.dSGetChargeSummaryIsoWeekBindingSource;
            // 
            // get_DataServices_ChargeSummary_IsoWeekTableAdapter
            // 
            this.get_DataServices_ChargeSummary_IsoWeekTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // get_DataServices_ReportRequestsTableAdapter
            // 
            this.get_DataServices_ReportRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // DataServicesChargeStationSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataServicesChargeStationSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Services : Charge and Dock Summary Report";
            this.Load += new System.EventHandler(this.DataServicesChargeSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargingStations)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargeSummaryIsoWeekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetChargeSummaryIsoWeekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargeSummaryIsoWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetChargeSummaryIsoWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetDataTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargeSummaryIsoWeekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnOutPutFilePath;
        private System.Windows.Forms.TextBox txtOutPutFilePath;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChargingStations;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblChargingStation;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Button btnCancel;
    
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        
        private DS_GetCustomer dS_GetCustomer;
        private dS_GetDataTypes dS_GetDataTypes;
        private dS_GetChargeSummaryIsoWeek dS_GetChargeSummaryIsoWeek;
        private dS_GetChargingStations dS_GetChargingStations;
        private dS_ReportViewer dS_ReportViewer;


        private dS_GetDataTypesTableAdapters.Get_DataServices_DataItemsTableAdapter get_DataServices_DataItemsTableAdapter;
        private DS_GetCustomerTableAdapters.GetCustomerTableAdapter getCustomerTableAdapter;
        private dS_GetChargingStationsTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter get_DataServices_ChargingStationsByCustTableAdapter;
        private dS_GetChargeSummaryIsoWeekTableAdapters.Get_DataServices_ChargeSummary_IsoWeekTableAdapter get_DataServices_ChargeSummary_IsoWeekTableAdapter;
        
        private System.Windows.Forms.BindingSource getDataServicesChargingStationsByCustBindingSource;
        private System.Windows.Forms.BindingSource getDataServicesChargeSummaryIsoWeekBindingSource;
        private System.Windows.Forms.BindingSource dSGetChargeSummaryIsoWeekBindingSource;
        
        
        private System.Windows.Forms.ComboBox cbWeek;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SaveFileDialog sfdOutPutFile;
        private dS_GetReportRequestsTableAdapters.Get_DataServices_ReportRequestsTableAdapter get_DataServices_ReportRequestsTableAdapter;
        private System.Windows.Forms.BindingSource getDataServicesChargeSummaryIsoWeekBindingSource1;
        private System.Windows.Forms.BindingSource dSGetChargeSummaryIsoWeekBindingSource1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserTrace;

        
    }
}