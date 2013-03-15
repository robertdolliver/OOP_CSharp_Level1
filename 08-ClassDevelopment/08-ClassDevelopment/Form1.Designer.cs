namespace _08_ClassDevelopment
{
    partial class Form1
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
            this.btnGetSales = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.lstArrays = new System.Windows.Forms.ListBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.btnLINQEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSales
            // 
            this.btnGetSales.Location = new System.Drawing.Point(264, 353);
            this.btnGetSales.Name = "btnGetSales";
            this.btnGetSales.Size = new System.Drawing.Size(130, 42);
            this.btnGetSales.TabIndex = 0;
            this.btnGetSales.Text = "Employee Sales";
            this.btnGetSales.UseVisualStyleBackColor = true;
            this.btnGetSales.Click += new System.EventHandler(this.btnGetSales_Click);
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(12, 356);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(108, 41);
            this.btnArray.TabIndex = 1;
            this.btnArray.Text = "Collections";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // lstArrays
            // 
            this.lstArrays.FormattingEnabled = true;
            this.lstArrays.Location = new System.Drawing.Point(12, 12);
            this.lstArrays.Name = "lstArrays";
            this.lstArrays.Size = new System.Drawing.Size(246, 329);
            this.lstArrays.TabIndex = 2;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(264, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(543, 329);
            this.dgvEmployee.TabIndex = 3;
            // 
            // btnLINQ
            // 
            this.btnLINQ.Location = new System.Drawing.Point(411, 353);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(109, 42);
            this.btnLINQ.TabIndex = 4;
            this.btnLINQ.Text = "LINQ";
            this.btnLINQ.UseVisualStyleBackColor = true;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            // 
            // btnLINQEmployees
            // 
            this.btnLINQEmployees.Location = new System.Drawing.Point(539, 353);
            this.btnLINQEmployees.Name = "btnLINQEmployees";
            this.btnLINQEmployees.Size = new System.Drawing.Size(109, 42);
            this.btnLINQEmployees.TabIndex = 5;
            this.btnLINQEmployees.Text = "LINQ Employees";
            this.btnLINQEmployees.UseVisualStyleBackColor = true;
            this.btnLINQEmployees.Click += new System.EventHandler(this.btnLINQEmployees_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 409);
            this.Controls.Add(this.btnLINQEmployees);
            this.Controls.Add(this.btnLINQ);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.lstArrays);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnGetSales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSales;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.ListBox lstArrays;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnLINQ;
        private System.Windows.Forms.Button btnLINQEmployees;
    }
}

