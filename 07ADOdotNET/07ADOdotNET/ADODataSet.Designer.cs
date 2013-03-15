namespace _07ADOdotNET
{
    partial class ADODataSet
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
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStates
            // 
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(12, 22);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(121, 21);
            this.cboStates.TabIndex = 0;
            this.cboStates.SelectedIndexChanged += new System.EventHandler(this.cboStates_SelectedIndexChanged);
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(12, 71);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(429, 404);
            this.grdCustomers.TabIndex = 1;
            // 
            // ADODataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 487);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.cboStates);
            this.Name = "ADODataSet";
            this.Text = "ADODataSet";
            this.Load += new System.EventHandler(this.ADODataSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}