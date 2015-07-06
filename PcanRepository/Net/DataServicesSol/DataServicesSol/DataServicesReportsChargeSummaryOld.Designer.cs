namespace DataServicesSol
{
    partial class DataServicesReportChargeSummary
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.dS_ReportViewer = new DataServicesSol.dS_ReportViewer();
            this.getDataServicesReportRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_DataServices_ReportRequestsTableAdapter = new DataServicesSol.dS_ReportViewerTableAdapters.Get_DataServices_ReportRequestsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbChargingStations = new System.Windows.Forms.ComboBox();
            this.lblChargingStation = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.btnOutPutFilePath = new System.Windows.Forms.Button();
            this.txtOutPutFilePath = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbFilePath.SuspendLayout();
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
            this.lblHeading.Size = new System.Drawing.Size(260, 19);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "Data Services : Reports";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cbChargingStations);
            this.groupBox1.Controls.Add(this.lblChargingStation);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Location = new System.Drawing.Point(54, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 327);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Week";
            this.label2.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(205, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // cbChargingStations
            // 
            this.cbChargingStations.DisplayMember = "Location";
            this.cbChargingStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChargingStations.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChargingStations.FormattingEnabled = true;
            this.cbChargingStations.Location = new System.Drawing.Point(205, 84);
            this.cbChargingStations.Name = "cbChargingStations";
            this.cbChargingStations.Size = new System.Drawing.Size(247, 23);
            this.cbChargingStations.TabIndex = 7;
            this.cbChargingStations.ValueMember = "ChargingStationID";
            this.cbChargingStations.Visible = false;
            // 
            // lblChargingStation
            // 
            this.lblChargingStation.AutoSize = true;
            this.lblChargingStation.Location = new System.Drawing.Point(81, 92);
            this.lblChargingStation.Name = "lblChargingStation";
            this.lblChargingStation.Size = new System.Drawing.Size(97, 15);
            this.lblChargingStation.TabIndex = 6;
            this.lblChargingStation.Text = "Charging Station";
            this.lblChargingStation.Visible = false;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DisplayMember = "CustomerName";
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(205, 38);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(247, 23);
            this.cbCustomer.TabIndex = 3;
            this.cbCustomer.ValueMember = "CustomerID";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(81, 38);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(59, 15);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblError);
            this.gbStatus.Location = new System.Drawing.Point(452, 489);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(658, 65);
            this.gbStatus.TabIndex = 12;
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
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.btnOutPutFilePath);
            this.gbFilePath.Controls.Add(this.txtOutPutFilePath);
            this.gbFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilePath.Location = new System.Drawing.Point(54, 489);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Size = new System.Drawing.Size(378, 65);
            this.gbFilePath.TabIndex = 11;
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
            // 
            // txtOutPutFilePath
            // 
            this.txtOutPutFilePath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutFilePath.Location = new System.Drawing.Point(9, 30);
            this.txtOutPutFilePath.Name = "txtOutPutFilePath";
            this.txtOutPutFilePath.ReadOnly = true;
            this.txtOutPutFilePath.Size = new System.Drawing.Size(321, 23);
            this.txtOutPutFilePath.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(1035, 595);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(954, 595);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            // DataServicesReportChargeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataServicesReportChargeSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataServices: Report Charge Summary";
            this.Load += new System.EventHandler(this.DataServicesDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_ReportViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDataServicesReportRequestsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getDataServicesReportRequestsBindingSource;
        private dS_ReportViewer dS_ReportViewer;
        private dS_ReportViewerTableAdapters.Get_DataServices_ReportRequestsTableAdapter get_DataServices_ReportRequestsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cbChargingStations;
        private System.Windows.Forms.Label lblChargingStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.Button btnOutPutFilePath;
        private System.Windows.Forms.TextBox txtOutPutFilePath;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

    }
}