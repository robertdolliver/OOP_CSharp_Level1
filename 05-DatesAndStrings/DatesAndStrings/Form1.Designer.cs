namespace DatesAndStrings
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
            this.tabDateString = new System.Windows.Forms.TabControl();
            this.tabPageDates = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDateChoice = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPlus90 = new System.Windows.Forms.TextBox();
            this.lblPlus90 = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabPageStrings = new System.Windows.Forms.TabPage();
            this.btnStringFormat = new System.Windows.Forms.Button();
            this.btnSplitName = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.tabDateString.SuspendLayout();
            this.tabPageDates.SuspendLayout();
            this.tabPageStrings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDateString
            // 
            this.tabDateString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDateString.Controls.Add(this.tabPageDates);
            this.tabDateString.Controls.Add(this.tabPageStrings);
            this.tabDateString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDateString.Location = new System.Drawing.Point(12, 23);
            this.tabDateString.Name = "tabDateString";
            this.tabDateString.SelectedIndex = 0;
            this.tabDateString.Size = new System.Drawing.Size(439, 500);
            this.tabDateString.TabIndex = 0;
            // 
            // tabPageDates
            // 
            this.tabPageDates.Controls.Add(this.monthCalendar1);
            this.tabPageDates.Controls.Add(this.lblDateChoice);
            this.tabPageDates.Controls.Add(this.dateTimePicker1);
            this.tabPageDates.Controls.Add(this.txtPlus90);
            this.tabPageDates.Controls.Add(this.lblPlus90);
            this.tabPageDates.Controls.Add(this.txtCurrentDate);
            this.tabPageDates.Controls.Add(this.lblDate);
            this.tabPageDates.Location = new System.Drawing.Point(4, 29);
            this.tabPageDates.Name = "tabPageDates";
            this.tabPageDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDates.Size = new System.Drawing.Size(431, 467);
            this.tabPageDates.TabIndex = 0;
            this.tabPageDates.Text = "Date Time";
            this.tabPageDates.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(69, 160);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblDateChoice
            // 
            this.lblDateChoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDateChoice.AutoSize = true;
            this.lblDateChoice.Location = new System.Drawing.Point(150, 432);
            this.lblDateChoice.Name = "lblDateChoice";
            this.lblDateChoice.Size = new System.Drawing.Size(51, 20);
            this.lblDateChoice.TabIndex = 5;
            this.lblDateChoice.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtPlus90
            // 
            this.txtPlus90.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlus90.Location = new System.Drawing.Point(127, 56);
            this.txtPlus90.Name = "txtPlus90";
            this.txtPlus90.Size = new System.Drawing.Size(264, 26);
            this.txtPlus90.TabIndex = 3;
            // 
            // lblPlus90
            // 
            this.lblPlus90.AutoSize = true;
            this.lblPlus90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus90.Location = new System.Drawing.Point(16, 59);
            this.lblPlus90.Name = "lblPlus90";
            this.lblPlus90.Size = new System.Drawing.Size(112, 20);
            this.lblPlus90.TabIndex = 2;
            this.lblPlus90.Text = "Today Plus 90:";
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentDate.Location = new System.Drawing.Point(127, 24);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(264, 26);
            this.txtCurrentDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Current Date:";
            // 
            // tabPageStrings
            // 
            this.tabPageStrings.Controls.Add(this.btnStringFormat);
            this.tabPageStrings.Controls.Add(this.btnSplitName);
            this.tabPageStrings.Controls.Add(this.panel1);
            this.tabPageStrings.Controls.Add(this.txtEmployeeName);
            this.tabPageStrings.Controls.Add(this.lblEmployeeName);
            this.tabPageStrings.Location = new System.Drawing.Point(4, 29);
            this.tabPageStrings.Name = "tabPageStrings";
            this.tabPageStrings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStrings.Size = new System.Drawing.Size(431, 467);
            this.tabPageStrings.TabIndex = 1;
            this.tabPageStrings.Text = "Strings";
            this.tabPageStrings.UseVisualStyleBackColor = true;
            this.tabPageStrings.Click += new System.EventHandler(this.tabPageStrings_Click);
            // 
            // btnStringFormat
            // 
            this.btnStringFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStringFormat.Location = new System.Drawing.Point(37, 320);
            this.btnStringFormat.Name = "btnStringFormat";
            this.btnStringFormat.Size = new System.Drawing.Size(331, 39);
            this.btnStringFormat.TabIndex = 4;
            this.btnStringFormat.Text = "String Format";
            this.btnStringFormat.UseVisualStyleBackColor = true;
            this.btnStringFormat.Click += new System.EventHandler(this.btnStringFormat_Click);
            // 
            // btnSplitName
            // 
            this.btnSplitName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSplitName.Location = new System.Drawing.Point(36, 261);
            this.btnSplitName.Name = "btnSplitName";
            this.btnSplitName.Size = new System.Drawing.Size(331, 39);
            this.btnSplitName.TabIndex = 3;
            this.btnSplitName.Text = "Split Name";
            this.btnSplitName.UseVisualStyleBackColor = true;
            this.btnSplitName.Click += new System.EventHandler(this.btnSplitName_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 150);
            this.panel1.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(140, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(126, 26);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(140, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(126, 26);
            this.txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.Location = new System.Drawing.Point(176, 41);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(187, 26);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.Text = "Mickey Mouse";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(32, 44);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(129, 20);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 540);
            this.Controls.Add(this.tabDateString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabDateString.ResumeLayout(false);
            this.tabPageDates.ResumeLayout(false);
            this.tabPageDates.PerformLayout();
            this.tabPageStrings.ResumeLayout(false);
            this.tabPageStrings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDateString;
        private System.Windows.Forms.TabPage tabPageDates;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabPageStrings;
        private System.Windows.Forms.TextBox txtPlus90;
        private System.Windows.Forms.Label lblPlus90;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDateChoice;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSplitName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnStringFormat;
    }
}

