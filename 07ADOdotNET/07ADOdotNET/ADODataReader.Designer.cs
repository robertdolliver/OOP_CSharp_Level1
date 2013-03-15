namespace _07ADOdotNET
{
    partial class ADODataReader
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
            this.btnCustomerNames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(12, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(260, 284);
            this.lstCustomers.TabIndex = 0;
            // 
            // btnCustomerNames
            // 
            this.btnCustomerNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerNames.Location = new System.Drawing.Point(12, 304);
            this.btnCustomerNames.Name = "btnCustomerNames";
            this.btnCustomerNames.Size = new System.Drawing.Size(260, 30);
            this.btnCustomerNames.TabIndex = 1;
            this.btnCustomerNames.Text = "Get Customer Names";
            this.btnCustomerNames.UseVisualStyleBackColor = true;
            this.btnCustomerNames.Click += new System.EventHandler(this.btnCustomerNames_Click);
            // 
            // ADODataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 346);
            this.Controls.Add(this.btnCustomerNames);
            this.Controls.Add(this.lstCustomers);
            this.Name = "ADODataReader";
            this.Text = "DataReader";
            this.Load += new System.EventHandler(this.ADODataReader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnCustomerNames;
    }
}