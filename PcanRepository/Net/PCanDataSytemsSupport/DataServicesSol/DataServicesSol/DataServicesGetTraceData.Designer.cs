namespace DataServicesSol
{
    partial class DataServicesGetTraceData
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
            this.gbDataFilter = new System.Windows.Forms.GroupBox();
            this.btnOutPutFilePath = new System.Windows.Forms.Button();
            this.lblDataAvail = new System.Windows.Forms.Label();
            this.txtOutPutFilePath = new System.Windows.Forms.TextBox();
            this.cbEndTime = new System.Windows.Forms.ComboBox();
            this.getDataServicesEventEndTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_EndTime = new DataServicesSol.dS_EndTime();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.getDataServicesEventStartTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_StartTime = new DataServicesSol.dS_StartTime();
            this.label3 = new System.Windows.Forms.Label();
            this.dpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.cbBus = new System.Windows.Forms.ComboBox();
            this.getDataServicesBusByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetBus = new DataServicesSol.dS_GetBus();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChargingStations = new System.Windows.Forms.ComboBox();
            this.getDataServicesChargingStationsByCustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetChargingStations = new DataServicesSol.dS_GetChargingStations();
            this.lblChargingStation = new System.Windows.Forms.Label();
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.getDataServicesDataItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetDataTypes = new DataServicesSol.dS_GetDataTypes();
            this.lblDataType = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.getCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetCustomer = new DataServicesSol.DS_GetCustomer();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.btnFolderPath = new System.Windows.Forms.Button();
            this.txtOutPutFilePath1 = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.getCustomerTableAdapter = new DataServicesSol.DS_GetCustomerTableAdapters.GetCustomerTableAdapter();
            this.get_DataServices_DataItemsTableAdapter = new DataServicesSol.dS_GetDataTypesTableAdapters.Get_DataServices_DataItemsTableAdapter();
            this.get_DataServices_ChargingStationsByCustTableAdapter = new DataServicesSol.dS_GetChargingStationsTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter();
            this.get_DataServices_BusByCustTableAdapter = new DataServicesSol.dS_GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter();
            this.get_DataServices_EventStartTimesTableAdapter = new DataServicesSol.dS_StartTimeTableAdapters.Get_DataServices_EventStartTimesTableAdapter();
            this.get_DataServices_EventEndTimesTableAdapter = new DataServicesSol.dS_EndTimeTableAdapters.Get_DataServices_EventEndTimesTableAdapter();
            this.lblHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkSymbols = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.sfdOutPutFile = new System.Windows.Forms.SaveFileDialog();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.get_DataServices_ReportRequestsTableAdapter = new DataServicesSol.dS_GetReportRequestsTableAdapters.Get_DataServices_ReportRequestsTableAdapter();
            this.getDataServicesReportRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GetReportRequests = new DataServicesSol.dS_GetReportRequests();
            this.folderBrowserTrace = new System.Windows.Forms.FolderBrowserDialog();
            this.gbDataFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesEventEndTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_EndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesEventStartTimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_StartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesBusByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargingStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesDataItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetDataTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).BeginInit();
            this.gbFilePath.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetReportRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataFilter
            // 
            this.gbDataFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDataFilter.Controls.Add(this.btnOutPutFilePath);
            this.gbDataFilter.Controls.Add(this.lblDataAvail);
            this.gbDataFilter.Controls.Add(this.txtOutPutFilePath);
            this.gbDataFilter.Controls.Add(this.cbEndTime);
            this.gbDataFilter.Controls.Add(this.label4);
            this.gbDataFilter.Controls.Add(this.cbStartTime);
            this.gbDataFilter.Controls.Add(this.label3);
            this.gbDataFilter.Controls.Add(this.dpEventDate);
            this.gbDataFilter.Controls.Add(this.lblEventDate);
            this.gbDataFilter.Controls.Add(this.cbBus);
            this.gbDataFilter.Controls.Add(this.label2);
            this.gbDataFilter.Controls.Add(this.cbChargingStations);
            this.gbDataFilter.Controls.Add(this.lblChargingStation);
            this.gbDataFilter.Controls.Add(this.cbDataType);
            this.gbDataFilter.Controls.Add(this.lblDataType);
            this.gbDataFilter.Controls.Add(this.cbCustomer);
            this.gbDataFilter.Controls.Add(this.lblCustomer);
            this.gbDataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbDataFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataFilter.Location = new System.Drawing.Point(37, 77);
            this.gbDataFilter.Name = "gbDataFilter";
            this.gbDataFilter.Size = new System.Drawing.Size(1118, 241);
            this.gbDataFilter.TabIndex = 0;
            this.gbDataFilter.TabStop = false;
            this.gbDataFilter.Text = "Data Filters";
            // 
            // btnOutPutFilePath
            // 
            this.btnOutPutFilePath.Location = new System.Drawing.Point(814, 166);
            this.btnOutPutFilePath.Name = "btnOutPutFilePath";
            this.btnOutPutFilePath.Size = new System.Drawing.Size(23, 23);
            this.btnOutPutFilePath.TabIndex = 1;
            this.btnOutPutFilePath.Text = "..";
            this.btnOutPutFilePath.UseVisualStyleBackColor = true;
            this.btnOutPutFilePath.Visible = false;
            this.btnOutPutFilePath.Click += new System.EventHandler(this.btnOutPutFilePath_Click);
            // 
            // lblDataAvail
            // 
            this.lblDataAvail.AutoSize = true;
            this.lblDataAvail.Location = new System.Drawing.Point(338, 143);
            this.lblDataAvail.Name = "lblDataAvail";
            this.lblDataAvail.Size = new System.Drawing.Size(0, 15);
            this.lblDataAvail.TabIndex = 0;
            // 
            // txtOutPutFilePath
            // 
            this.txtOutPutFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutFilePath.Location = new System.Drawing.Point(461, 166);
            this.txtOutPutFilePath.Name = "txtOutPutFilePath";
            this.txtOutPutFilePath.ReadOnly = true;
            this.txtOutPutFilePath.Size = new System.Drawing.Size(321, 23);
            this.txtOutPutFilePath.TabIndex = 0;
            this.txtOutPutFilePath.Visible = false;
            // 
            // cbEndTime
            // 
            this.cbEndTime.DataSource = this.getDataServicesEventEndTimesBindingSource;
            this.cbEndTime.DisplayMember = "Time";
            this.cbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEndTime.FormattingEnabled = true;
            this.cbEndTime.Location = new System.Drawing.Point(130, 195);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(200, 23);
            this.cbEndTime.TabIndex = 13;
            this.cbEndTime.ValueMember = "Time";
            // 
            // getDataServicesEventEndTimesBindingSource
            // 
            this.getDataServicesEventEndTimesBindingSource.DataMember = "Get-DataServices-EventEndTimes";
            this.getDataServicesEventEndTimesBindingSource.DataSource = this.dS_EndTime;
            // 
            // dS_EndTime
            // 
            this.dS_EndTime.DataSetName = "dS_EndTime";
            this.dS_EndTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "End Time";
            // 
            // cbStartTime
            // 
            this.cbStartTime.DataSource = this.getDataServicesEventStartTimesBindingSource;
            this.cbStartTime.DisplayMember = "Time";
            this.cbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Location = new System.Drawing.Point(130, 166);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(200, 23);
            this.cbStartTime.TabIndex = 11;
            this.cbStartTime.ValueMember = "Time";
            this.cbStartTime.SelectedIndexChanged += new System.EventHandler(this.cbStartTime_SelectedIndexChanged);
            // 
            // getDataServicesEventStartTimesBindingSource
            // 
            this.getDataServicesEventStartTimesBindingSource.DataMember = "Get-DataServices-EventStartTimes";
            this.getDataServicesEventStartTimesBindingSource.DataSource = this.dS_StartTime;
            // 
            // dS_StartTime
            // 
            this.dS_StartTime.DataSetName = "dS_StartTime";
            this.dS_StartTime.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start Time";
            // 
            // dpEventDate
            // 
            this.dpEventDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEventDate.Location = new System.Drawing.Point(130, 137);
            this.dpEventDate.MaxDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dpEventDate.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dpEventDate.Name = "dpEventDate";
            this.dpEventDate.Size = new System.Drawing.Size(200, 23);
            this.dpEventDate.TabIndex = 9;
            this.dpEventDate.Value = new System.DateTime(2014, 8, 28, 0, 0, 0, 0);
            this.dpEventDate.ValueChanged += new System.EventHandler(this.dpEventDate_ValueChanged);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(6, 137);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(64, 15);
            this.lblEventDate.TabIndex = 8;
            this.lblEventDate.Text = "Trace Date";
            // 
            // cbBus
            // 
            this.cbBus.DataSource = this.getDataServicesBusByCustBindingSource;
            this.cbBus.DisplayMember = "VIN";
            this.cbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBus.FormattingEnabled = true;
            this.cbBus.Location = new System.Drawing.Point(130, 104);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(230, 23);
            this.cbBus.TabIndex = 7;
            this.cbBus.ValueMember = "VinID";
            this.cbBus.SelectedIndexChanged += new System.EventHandler(this.cbBus_SelectedIndexChanged);
            // 
            // getDataServicesBusByCustBindingSource
            // 
            this.getDataServicesBusByCustBindingSource.DataMember = "Get-DataServices-BusByCust";
            this.getDataServicesBusByCustBindingSource.DataSource = this.dS_GetBus;
            // 
            // dS_GetBus
            // 
            this.dS_GetBus.DataSetName = "dS_GetBus";
            this.dS_GetBus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bus";
            // 
            // cbChargingStations
            // 
            this.cbChargingStations.DataSource = this.getDataServicesChargingStationsByCustBindingSource;
            this.cbChargingStations.DisplayMember = "Location";
            this.cbChargingStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChargingStations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChargingStations.FormattingEnabled = true;
            this.cbChargingStations.Location = new System.Drawing.Point(535, 76);
            this.cbChargingStations.Name = "cbChargingStations";
            this.cbChargingStations.Size = new System.Drawing.Size(247, 23);
            this.cbChargingStations.TabIndex = 5;
            this.cbChargingStations.ValueMember = "ChargingStationID";
            this.cbChargingStations.Visible = false;
            this.cbChargingStations.SelectedIndexChanged += new System.EventHandler(this.cbChargingStations_SelectedIndexChanged);
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
            // lblChargingStation
            // 
            this.lblChargingStation.AutoSize = true;
            this.lblChargingStation.Location = new System.Drawing.Point(395, 76);
            this.lblChargingStation.Name = "lblChargingStation";
            this.lblChargingStation.Size = new System.Drawing.Size(96, 15);
            this.lblChargingStation.TabIndex = 4;
            this.lblChargingStation.Text = "Charging Station";
            this.lblChargingStation.Visible = false;
            // 
            // cbDataType
            // 
            this.cbDataType.DataSource = this.getDataServicesDataItemsBindingSource;
            this.cbDataType.DisplayMember = "ItemType";
            this.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Location = new System.Drawing.Point(130, 73);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(230, 23);
            this.cbDataType.TabIndex = 3;
            this.cbDataType.ValueMember = "ItemTypeID";
            this.cbDataType.SelectedIndexChanged += new System.EventHandler(this.cbDataType_SelectedIndexChanged);
            // 
            // getDataServicesDataItemsBindingSource
            // 
            this.getDataServicesDataItemsBindingSource.DataMember = "Get-DataServices-DataItems";
            this.getDataServicesDataItemsBindingSource.DataSource = this.dS_GetDataTypes;
            // 
            // dS_GetDataTypes
            // 
            this.dS_GetDataTypes.DataSetName = "dS_GetDataTypes";
            this.dS_GetDataTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(6, 76);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(61, 15);
            this.lblDataType.TabIndex = 2;
            this.lblDataType.Text = "Data Type";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.getCustomerBindingSource;
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
            // getCustomerBindingSource
            // 
            this.getCustomerBindingSource.DataMember = "GetCustomer";
            this.getCustomerBindingSource.DataSource = this.dS_GetCustomer;
            // 
            // dS_GetCustomer
            // 
            this.dS_GetCustomer.DataSetName = "DS_GetCustomer";
            this.dS_GetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.btnFolderPath);
            this.gbFilePath.Controls.Add(this.txtOutPutFilePath1);
            this.gbFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilePath.Location = new System.Drawing.Point(37, 334);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Size = new System.Drawing.Size(378, 65);
            this.gbFilePath.TabIndex = 1;
            this.gbFilePath.TabStop = false;
            this.gbFilePath.Text = "OutPut File Path";
            // 
            // btnFolderPath
            // 
            this.btnFolderPath.Location = new System.Drawing.Point(349, 22);
            this.btnFolderPath.Name = "btnFolderPath";
            this.btnFolderPath.Size = new System.Drawing.Size(23, 23);
            this.btnFolderPath.TabIndex = 9;
            this.btnFolderPath.Text = "..";
            this.btnFolderPath.UseVisualStyleBackColor = true;
            this.btnFolderPath.Click += new System.EventHandler(this.btnFolderPath_Click);
            // 
            // txtOutPutFilePath1
            // 
            this.txtOutPutFilePath1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutFilePath1.Location = new System.Drawing.Point(9, 22);
            this.txtOutPutFilePath1.Name = "txtOutPutFilePath1";
            this.txtOutPutFilePath1.ReadOnly = true;
            this.txtOutPutFilePath1.Size = new System.Drawing.Size(321, 23);
            this.txtOutPutFilePath1.TabIndex = 4;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblError);
            this.gbStatus.Location = new System.Drawing.Point(435, 334);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(720, 65);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
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
            // getCustomerTableAdapter
            // 
            this.getCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_DataItemsTableAdapter
            // 
            this.get_DataServices_DataItemsTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_ChargingStationsByCustTableAdapter
            // 
            this.get_DataServices_ChargingStationsByCustTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_BusByCustTableAdapter
            // 
            this.get_DataServices_BusByCustTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_EventStartTimesTableAdapter
            // 
            this.get_DataServices_EventStartTimesTableAdapter.ClearBeforeFill = true;
            // 
            // get_DataServices_EventEndTimesTableAdapter
            // 
            this.get_DataServices_EventEndTimesTableAdapter.ClearBeforeFill = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(37, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(346, 19);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Data Services : Get Trace Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkSymbols);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symbols";
            // 
            // ChkSymbols
            // 
            this.ChkSymbols.AutoSize = true;
            this.ChkSymbols.Checked = true;
            this.ChkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkSymbols.Enabled = false;
            this.ChkSymbols.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSymbols.Location = new System.Drawing.Point(9, 23);
            this.ChkSymbols.Name = "ChkSymbols";
            this.ChkSymbols.Size = new System.Drawing.Size(125, 19);
            this.ChkSymbols.TabIndex = 0;
            this.ChkSymbols.Text = "Select All Symbols";
            this.ChkSymbols.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(982, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(1075, 639);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.InitialImage = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.Location = new System.Drawing.Point(851, 21);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(304, 50);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // get_DataServices_ReportRequestsTableAdapter
            // 
            this.get_DataServices_ReportRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // getDataServicesReportRequestsBindingSource
            // 
            this.getDataServicesReportRequestsBindingSource.DataMember = "Get-DataServices-ReportRequests";
            this.getDataServicesReportRequestsBindingSource.DataSource = this.dS_GetReportRequests;
            // 
            // dS_GetReportRequests
            // 
            this.dS_GetReportRequests.DataSetName = "dS_GetReportRequests";
            this.dS_GetReportRequests.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataServicesGetTraceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.gbDataFilter);
            this.Name = "DataServicesGetTraceData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Services : Get Trace Data";
            this.Load += new System.EventHandler(this.DataServicesGetTraceData_Load);
            this.gbDataFilter.ResumeLayout(false);
            this.gbDataFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesEventEndTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_EndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesEventStartTimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_StartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesBusByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesChargingStationsByCustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetChargingStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesDataItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetDataTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetCustomer)).EndInit();
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GetReportRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataFilter;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.GroupBox gbStatus;
        private DS_GetCustomer dS_GetCustomer;
        private System.Windows.Forms.BindingSource getCustomerBindingSource;
        private DS_GetCustomerTableAdapters.GetCustomerTableAdapter getCustomerTableAdapter;
        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.Label lblDataType;
        private dS_GetDataTypes dS_GetDataTypes;
        private System.Windows.Forms.BindingSource getDataServicesDataItemsBindingSource;
        private dS_GetDataTypesTableAdapters.Get_DataServices_DataItemsTableAdapter get_DataServices_DataItemsTableAdapter;
        private System.Windows.Forms.ComboBox cbChargingStations;
        private System.Windows.Forms.BindingSource getDataServicesChargingStationsByCustBindingSource;
        private dS_GetChargingStations dS_GetChargingStations;
        private System.Windows.Forms.Label lblChargingStation;
        private dS_GetChargingStationsTableAdapters.Get_DataServices_ChargingStationsByCustTableAdapter get_DataServices_ChargingStationsByCustTableAdapter;
        private System.Windows.Forms.ComboBox cbBus;
        private System.Windows.Forms.BindingSource getDataServicesBusByCustBindingSource;
        private dS_GetBus dS_GetBus;
        private System.Windows.Forms.Label label2;
        private dS_GetBusTableAdapters.Get_DataServices_BusByCustTableAdapter get_DataServices_BusByCustTableAdapter;
        private System.Windows.Forms.DateTimePicker dpEventDate;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.BindingSource getDataServicesEventStartTimesBindingSource;
        private dS_StartTime dS_StartTime;
        private System.Windows.Forms.Label label3;
        private dS_StartTimeTableAdapters.Get_DataServices_EventStartTimesTableAdapter get_DataServices_EventStartTimesTableAdapter;
        private System.Windows.Forms.ComboBox cbEndTime;
        private System.Windows.Forms.BindingSource getDataServicesEventEndTimesBindingSource;
        private dS_EndTime dS_EndTime;
        private System.Windows.Forms.Label label4;
        private dS_EndTimeTableAdapters.Get_DataServices_EventEndTimesTableAdapter get_DataServices_EventEndTimesTableAdapter;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnOutPutFilePath;
        private System.Windows.Forms.TextBox txtOutPutFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkSymbols;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.SaveFileDialog sfdOutPutFile;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblError;
        private dS_GetReportRequestsTableAdapters.Get_DataServices_ReportRequestsTableAdapter get_DataServices_ReportRequestsTableAdapter;
        private System.Windows.Forms.BindingSource getDataServicesReportRequestsBindingSource;
        private dS_GetReportRequests dS_GetReportRequests;
        private System.Windows.Forms.Label lblDataAvail;
        private System.Windows.Forms.TextBox txtOutPutFilePath1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserTrace;
        private System.Windows.Forms.Button btnFolderPath;
    }
}

