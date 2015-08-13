namespace DataServicesSol
{
    partial class DataServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataServices));
            this.lblHeading = new System.Windows.Forms.Label();
            this.gbDataFilter = new System.Windows.Forms.GroupBox();
            this.linkReports = new System.Windows.Forms.LinkLabel();
            this.lblTwoHzData = new System.Windows.Forms.LinkLabel();
            this.lblGetDecodedData = new System.Windows.Forms.LinkLabel();
            this.lblGetTraceData = new System.Windows.Forms.LinkLabel();
            this.dS_ReportViewer = new DataServicesSol.dS_ReportViewer();
            this.getDataServicesReportRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_ReportRequestsTableAdapter = new DataServicesSol.dS_ReportViewerTableAdapters.Get_DataServices_ReportRequestsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submittedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPutPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.linkSubscribe = new System.Windows.Forms.LinkLabel();
            this.gbDataFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(14, 35);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(346, 19);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Data Services : Get Trace Data";
            // 
            // gbDataFilter
            // 
            this.gbDataFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDataFilter.Controls.Add(this.linkSubscribe);
            this.gbDataFilter.Controls.Add(this.linkReports);
            this.gbDataFilter.Controls.Add(this.lblTwoHzData);
            this.gbDataFilter.Controls.Add(this.lblGetDecodedData);
            this.gbDataFilter.Controls.Add(this.lblGetTraceData);
            this.gbDataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbDataFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataFilter.Location = new System.Drawing.Point(19, 107);
            this.gbDataFilter.Name = "gbDataFilter";
            this.gbDataFilter.Size = new System.Drawing.Size(1133, 75);
            this.gbDataFilter.TabIndex = 10;
            this.gbDataFilter.TabStop = false;
            this.gbDataFilter.Text = "Get Data";
            // 
            // linkReports
            // 
            this.linkReports.AutoSize = true;
            this.linkReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReports.Location = new System.Drawing.Point(1050, 31);
            this.linkReports.Name = "linkReports";
            this.linkReports.Size = new System.Drawing.Size(62, 19);
            this.linkReports.TabIndex = 3;
            this.linkReports.TabStop = true;
            this.linkReports.Text = "Reports";
            this.linkReports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReports_LinkClicked);
            // 
            // lblTwoHzData
            // 
            this.lblTwoHzData.AutoSize = true;
            this.lblTwoHzData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoHzData.Location = new System.Drawing.Point(399, 31);
            this.lblTwoHzData.Name = "lblTwoHzData";
            this.lblTwoHzData.Size = new System.Drawing.Size(122, 19);
            this.lblTwoHzData.TabIndex = 2;
            this.lblTwoHzData.TabStop = true;
            this.lblTwoHzData.Text = "Get Two Hz Data";
            this.lblTwoHzData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTwoHzData_LinkClicked);
            // 
            // lblGetDecodedData
            // 
            this.lblGetDecodedData.AutoSize = true;
            this.lblGetDecodedData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetDecodedData.Location = new System.Drawing.Point(228, 31);
            this.lblGetDecodedData.Name = "lblGetDecodedData";
            this.lblGetDecodedData.Size = new System.Drawing.Size(133, 19);
            this.lblGetDecodedData.TabIndex = 1;
            this.lblGetDecodedData.TabStop = true;
            this.lblGetDecodedData.Text = "Get Decoded Data";
            this.lblGetDecodedData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGetDecodedData_LinkClicked);
            // 
            // lblGetTraceData
            // 
            this.lblGetTraceData.AutoSize = true;
            this.lblGetTraceData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetTraceData.Location = new System.Drawing.Point(70, 31);
            this.lblGetTraceData.Name = "lblGetTraceData";
            this.lblGetTraceData.Size = new System.Drawing.Size(109, 19);
            this.lblGetTraceData.TabIndex = 0;
            this.lblGetTraceData.TabStop = true;
            this.lblGetTraceData.Text = "Get Trace Data";
            this.lblGetTraceData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGetTraceData_LinkClicked);
            // 
            // dS_ReportViewer
            // 
            this.dS_ReportViewer.DataSetName = "dS_ReportViewer";
            this.dS_ReportViewer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getDataServicesReportRequestsBindingSource
            // 
            this.getDataServicesReportRequestsBindingSource.DataMember = "Get-DataServices-ReportRequests";
            this.getDataServicesReportRequestsBindingSource.DataSource = this.dS_ReportViewer;
            // 
            // get_DataServices_ReportRequestsTableAdapter
            // 
            this.get_DataServices_ReportRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportIDDataGridViewTextBoxColumn,
            this.UserName,
            this.customerNameDataGridViewTextBoxColumn,
            this.vinDataGridViewTextBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.submittedDateDataGridViewTextBoxColumn,
            this.outPutPathDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getDataServicesReportRequestsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(19, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 440);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reportIDDataGridViewTextBoxColumn
            // 
            this.reportIDDataGridViewTextBoxColumn.DataPropertyName = "ReportID";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.NullValue = null;
            this.reportIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.reportIDDataGridViewTextBoxColumn.HeaderText = "ReportID";
            this.reportIDDataGridViewTextBoxColumn.Name = "reportIDDataGridViewTextBoxColumn";
            this.reportIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportIDDataGridViewTextBoxColumn.ToolTipText = "Download File";
            this.reportIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 80;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // vinDataGridViewTextBoxColumn
            // 
            this.vinDataGridViewTextBoxColumn.DataPropertyName = "Vin";
            this.vinDataGridViewTextBoxColumn.HeaderText = "Vin";
            this.vinDataGridViewTextBoxColumn.Name = "vinDataGridViewTextBoxColumn";
            this.vinDataGridViewTextBoxColumn.ReadOnly = true;
            this.vinDataGridViewTextBoxColumn.Width = 140;
            // 
            // dataTypeDataGridViewTextBoxColumn
            // 
            this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
            this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
            this.dataTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EventDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Trace Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // submittedDateDataGridViewTextBoxColumn
            // 
            this.submittedDateDataGridViewTextBoxColumn.DataPropertyName = "SubmittedDate";
            this.submittedDateDataGridViewTextBoxColumn.HeaderText = "SubmittedDate";
            this.submittedDateDataGridViewTextBoxColumn.Name = "submittedDateDataGridViewTextBoxColumn";
            this.submittedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.submittedDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // outPutPathDataGridViewTextBoxColumn
            // 
            this.outPutPathDataGridViewTextBoxColumn.DataPropertyName = "OutPutPath";
            this.outPutPathDataGridViewTextBoxColumn.HeaderText = "OutPutPath";
            this.outPutPathDataGridViewTextBoxColumn.Name = "outPutPathDataGridViewTextBoxColumn";
            this.outPutPathDataGridViewTextBoxColumn.ReadOnly = true;
            this.outPutPathDataGridViewTextBoxColumn.Width = 340;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 50;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 50;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(19, 188);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.InitialImage = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.Location = new System.Drawing.Point(727, 43);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(425, 58);
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // linkSubscribe
            // 
            this.linkSubscribe.AutoSize = true;
            this.linkSubscribe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSubscribe.Location = new System.Drawing.Point(964, 31);
            this.linkSubscribe.Name = "linkSubscribe";
            this.linkSubscribe.Size = new System.Drawing.Size(75, 19);
            this.linkSubscribe.TabIndex = 4;
            this.linkSubscribe.TabStop = true;
            this.linkSubscribe.Text = "Subscribe";
            this.linkSubscribe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSubscribe_LinkClicked);
            // 
            // DataServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbDataFilter);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataServices: Dashboard (V 1.1)";
            this.Load += new System.EventHandler(this.DataServicesDashboard_Load);
            this.gbDataFilter.ResumeLayout(false);
            this.gbDataFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gbDataFilter;
        private System.Windows.Forms.LinkLabel lblGetTraceData;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getDataServicesReportRequestsBindingSource;
        private dS_ReportViewer dS_ReportViewer;
        private dS_ReportViewerTableAdapters.Get_DataServices_ReportRequestsTableAdapter get_DataServices_ReportRequestsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.LinkLabel lblGetDecodedData;
        private System.Windows.Forms.LinkLabel lblTwoHzData;
        private System.Windows.Forms.LinkLabel linkReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn submittedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outPutPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel linkSubscribe;

    }
}