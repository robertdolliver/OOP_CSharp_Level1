namespace ADOdotNET
{
    partial class AdoDataReader
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnGetCustomerNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(24, 22);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(202, 324);
            this.lstCustomers.TabIndex = 0;
            // 
            // btnGetCustomerNames
            // 
            this.btnGetCustomerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCustomerNames.Location = new System.Drawing.Point(24, 359);
            this.btnGetCustomerNames.Name = "btnGetCustomerNames";
            this.btnGetCustomerNames.Size = new System.Drawing.Size(202, 37);
            this.btnGetCustomerNames.TabIndex = 1;
            this.btnGetCustomerNames.Text = "Get Customer Names";
            this.btnGetCustomerNames.UseVisualStyleBackColor = true;
            this.btnGetCustomerNames.Click += new System.EventHandler(this.btnGetCustomerNames_Click);
            // 
            // AdoDataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 423);
            this.Controls.Add(this.btnGetCustomerNames);
            this.Controls.Add(this.lstCustomers);
            this.Name = "AdoDataReader";
            this.Text = "DataReader";
            this.Load += new System.EventHandler(this.AdoDataReader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnGetCustomerNames;
    }
}