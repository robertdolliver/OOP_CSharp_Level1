namespace ControlStructures
{
    partial class frmStructures
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
            this.lstResults = new System.Windows.Forms.ListBox();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.btnIfElse = new System.Windows.Forms.Button();
            this.btnSwitchCase = new System.Windows.Forms.Button();
            this.cboChoices = new System.Windows.Forms.ComboBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnBreakContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 12);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(238, 225);
            this.lstResults.TabIndex = 0;
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(275, 149);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(131, 20);
            this.txtIterations.TabIndex = 1;
            this.txtIterations.Text = "10";
            this.txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIfElse
            // 
            this.btnIfElse.Location = new System.Drawing.Point(275, 43);
            this.btnIfElse.Name = "btnIfElse";
            this.btnIfElse.Size = new System.Drawing.Size(131, 23);
            this.btnIfElse.TabIndex = 2;
            this.btnIfElse.Text = "If-Else";
            this.btnIfElse.UseVisualStyleBackColor = true;
            this.btnIfElse.Click += new System.EventHandler(this.btnIfElse_Click);
            // 
            // btnSwitchCase
            // 
            this.btnSwitchCase.Location = new System.Drawing.Point(275, 72);
            this.btnSwitchCase.Name = "btnSwitchCase";
            this.btnSwitchCase.Size = new System.Drawing.Size(131, 23);
            this.btnSwitchCase.TabIndex = 3;
            this.btnSwitchCase.Text = "Switch-Case";
            this.btnSwitchCase.UseVisualStyleBackColor = true;
            this.btnSwitchCase.Click += new System.EventHandler(this.btnSwitchCase_Click);
            // 
            // cboChoices
            // 
            this.cboChoices.FormattingEnabled = true;
            this.cboChoices.Location = new System.Drawing.Point(275, 16);
            this.cboChoices.Name = "cboChoices";
            this.cboChoices.Size = new System.Drawing.Size(131, 21);
            this.cboChoices.TabIndex = 4;
            this.cboChoices.SelectedIndexChanged += new System.EventHandler(this.cboChoices_SelectedIndexChanged);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(275, 204);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(131, 23);
            this.btnFor.TabIndex = 6;
            this.btnFor.Text = "For-Next";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(275, 175);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(131, 23);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "While-Loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnBreakContinue
            // 
            this.btnBreakContinue.Location = new System.Drawing.Point(275, 233);
            this.btnBreakContinue.Name = "btnBreakContinue";
            this.btnBreakContinue.Size = new System.Drawing.Size(131, 23);
            this.btnBreakContinue.TabIndex = 7;
            this.btnBreakContinue.Text = "Break Continue";
            this.btnBreakContinue.UseVisualStyleBackColor = true;
            this.btnBreakContinue.Click += new System.EventHandler(this.btnBreakContinue_Click);
            // 
            // frmStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 284);
            this.Controls.Add(this.btnBreakContinue);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.cboChoices);
            this.Controls.Add(this.btnSwitchCase);
            this.Controls.Add(this.btnIfElse);
            this.Controls.Add(this.txtIterations);
            this.Controls.Add(this.lstResults);
            this.Name = "frmStructures";
            this.Text = "Control Structures";
            this.Load += new System.EventHandler(this.frmStructures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Button btnIfElse;
        private System.Windows.Forms.Button btnSwitchCase;
        private System.Windows.Forms.ComboBox cboChoices;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnBreakContinue;
    }
}

