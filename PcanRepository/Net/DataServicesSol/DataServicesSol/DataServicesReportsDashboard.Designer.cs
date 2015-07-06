namespace DataServicesSol
{
    partial class DataServicesReportsDashboard
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
            this.gbDataFilter = new System.Windows.Forms.GroupBox();
            this.linkChargeSummary = new System.Windows.Forms.LinkLabel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.linkDashboard = new System.Windows.Forms.LinkLabel();
            this.gbDataFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataFilter
            // 
            this.gbDataFilter.AccessibleDescription = " Charge and Dock Summary Reports By Week";
            this.gbDataFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDataFilter.Controls.Add(this.linkChargeSummary);
            this.gbDataFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbDataFilter.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataFilter.Location = new System.Drawing.Point(17, 186);
            this.gbDataFilter.Name = "gbDataFilter";
            this.gbDataFilter.Size = new System.Drawing.Size(1133, 216);
            this.gbDataFilter.TabIndex = 13;
            this.gbDataFilter.TabStop = false;
            this.gbDataFilter.Text = "Get Charge Reports";
            // 
            // linkChargeSummary
            // 
            this.linkChargeSummary.AutoSize = true;
            this.linkChargeSummary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChargeSummary.Location = new System.Drawing.Point(21, 34);
            this.linkChargeSummary.Name = "linkChargeSummary";
            this.linkChargeSummary.Size = new System.Drawing.Size(138, 19);
            this.linkChargeSummary.TabIndex = 3;
            this.linkChargeSummary.TabStop = true;
            this.linkChargeSummary.Text = "Charging Summary";
            this.linkChargeSummary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChargeSummary_LinkClicked);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.InitialImage = global::DataServicesSol.Properties.Resources.Proterra_Logo;
            this.pbLogo.Location = new System.Drawing.Point(725, 62);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(425, 58);
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(12, 54);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(260, 19);
            this.lblHeading.TabIndex = 11;
            this.lblHeading.Text = "Data Services : Reports";
            // 
            // linkDashboard
            // 
            this.linkDashboard.AutoSize = true;
            this.linkDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDashboard.Location = new System.Drawing.Point(1051, 142);
            this.linkDashboard.Name = "linkDashboard";
            this.linkDashboard.Size = new System.Drawing.Size(83, 19);
            this.linkDashboard.TabIndex = 14;
            this.linkDashboard.TabStop = true;
            this.linkDashboard.Text = "Dashboard";
            this.linkDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDashboard_LinkClicked);
            // 
            // DataServicesReportsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.linkDashboard);
            this.Controls.Add(this.gbDataFilter);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblHeading);
            this.Name = "DataServicesReportsDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportDashbord";
            this.gbDataFilter.ResumeLayout(false);
            this.gbDataFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataFilter;
        private System.Windows.Forms.LinkLabel linkChargeSummary;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.LinkLabel linkDashboard;
    }
}