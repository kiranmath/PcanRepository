namespace DataServicesSol
{
    partial class SelfSubscription
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
            this.button1 = new System.Windows.Forms.Button();
            this.ds_UserInfo = new DataServicesSol.dS_UserInfo1();
            this.dsUserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_UserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ds_UserInfo
            // 
            this.ds_UserInfo.DataSetName = "ds_UserInfo";
            this.ds_UserInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsUserInfoBindingSource
            // 
            this.dsUserInfoBindingSource.DataSource = this.ds_UserInfo;
            this.dsUserInfoBindingSource.Position = 0;
            // 
            // SelfSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 279);
            this.Controls.Add(this.button1);
            this.Name = "SelfSubscription";
            this.Text = "SelfSubscription";
            this.Load += new System.EventHandler(this.SelfSubscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_UserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUserInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private dS_UserInfo1 ds_UserInfo;
        private System.Windows.Forms.BindingSource dsUserInfoBindingSource;
       
    }
}