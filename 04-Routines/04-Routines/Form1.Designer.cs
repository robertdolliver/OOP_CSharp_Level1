namespace _04_Routines
{
    partial class form1
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
            this.btnVoidSubNoArgument = new System.Windows.Forms.Button();
            this.btnVoidSubWithArgument = new System.Windows.Forms.Button();
            this.btnTypedFunctionWithArgument = new System.Windows.Forms.Button();
            this.btnTypedFunctionNoArgument = new System.Windows.Forms.Button();
            this.grpVoidSub = new System.Windows.Forms.GroupBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.grpTypedFunction = new System.Windows.Forms.GroupBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.grpVoidSub.SuspendLayout();
            this.grpTypedFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoidSubNoArgument
            // 
            this.btnVoidSubNoArgument.ForeColor = System.Drawing.Color.Navy;
            this.btnVoidSubNoArgument.Location = new System.Drawing.Point(11, 22);
            this.btnVoidSubNoArgument.Name = "btnVoidSubNoArgument";
            this.btnVoidSubNoArgument.Size = new System.Drawing.Size(230, 33);
            this.btnVoidSubNoArgument.TabIndex = 0;
            this.btnVoidSubNoArgument.Text = "SayHello Routine (No Argument)";
            this.btnVoidSubNoArgument.UseVisualStyleBackColor = true;
            this.btnVoidSubNoArgument.Click += new System.EventHandler(this.btnVoidSubNoArgument_Click);
            // 
            // btnVoidSubWithArgument
            // 
            this.btnVoidSubWithArgument.ForeColor = System.Drawing.Color.Navy;
            this.btnVoidSubWithArgument.Location = new System.Drawing.Point(11, 73);
            this.btnVoidSubWithArgument.Name = "btnVoidSubWithArgument";
            this.btnVoidSubWithArgument.Size = new System.Drawing.Size(230, 33);
            this.btnVoidSubWithArgument.TabIndex = 1;
            this.btnVoidSubWithArgument.Text = "SayHello Routine (Dynamic with Argument)";
            this.btnVoidSubWithArgument.UseVisualStyleBackColor = true;
            this.btnVoidSubWithArgument.Click += new System.EventHandler(this.btnVoidSubWithArgument_Click);
            // 
            // btnTypedFunctionWithArgument
            // 
            this.btnTypedFunctionWithArgument.ForeColor = System.Drawing.Color.Navy;
            this.btnTypedFunctionWithArgument.Location = new System.Drawing.Point(13, 76);
            this.btnTypedFunctionWithArgument.Name = "btnTypedFunctionWithArgument";
            this.btnTypedFunctionWithArgument.Size = new System.Drawing.Size(230, 33);
            this.btnTypedFunctionWithArgument.TabIndex = 3;
            this.btnTypedFunctionWithArgument.Text = "SayHello Routine (Dynamic with Argument)";
            this.btnTypedFunctionWithArgument.UseVisualStyleBackColor = true;
            this.btnTypedFunctionWithArgument.Click += new System.EventHandler(this.btnTypedFunctionWithArgument_Click);
            // 
            // btnTypedFunctionNoArgument
            // 
            this.btnTypedFunctionNoArgument.ForeColor = System.Drawing.Color.Navy;
            this.btnTypedFunctionNoArgument.Location = new System.Drawing.Point(13, 22);
            this.btnTypedFunctionNoArgument.Name = "btnTypedFunctionNoArgument";
            this.btnTypedFunctionNoArgument.Size = new System.Drawing.Size(230, 33);
            this.btnTypedFunctionNoArgument.TabIndex = 2;
            this.btnTypedFunctionNoArgument.Text = "SayHello Routine (No Argument)";
            this.btnTypedFunctionNoArgument.UseVisualStyleBackColor = true;
            this.btnTypedFunctionNoArgument.Click += new System.EventHandler(this.btnTypedFunctionNoArgument_Click);
            // 
            // grpVoidSub
            // 
            this.grpVoidSub.Controls.Add(this.txtName1);
            this.grpVoidSub.Controls.Add(this.btnVoidSubWithArgument);
            this.grpVoidSub.Controls.Add(this.btnVoidSubNoArgument);
            this.grpVoidSub.ForeColor = System.Drawing.Color.Maroon;
            this.grpVoidSub.Location = new System.Drawing.Point(36, 26);
            this.grpVoidSub.Name = "grpVoidSub";
            this.grpVoidSub.Size = new System.Drawing.Size(255, 148);
            this.grpVoidSub.TabIndex = 4;
            this.grpVoidSub.TabStop = false;
            this.grpVoidSub.Text = "Void Routines";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(13, 112);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(228, 20);
            this.txtName1.TabIndex = 2;
            this.txtName1.Text = "Goofy";
            this.txtName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTypedFunction
            // 
            this.grpTypedFunction.Controls.Add(this.txtName2);
            this.grpTypedFunction.Controls.Add(this.btnTypedFunctionWithArgument);
            this.grpTypedFunction.Controls.Add(this.btnTypedFunctionNoArgument);
            this.grpTypedFunction.ForeColor = System.Drawing.Color.Maroon;
            this.grpTypedFunction.Location = new System.Drawing.Point(36, 197);
            this.grpTypedFunction.Name = "grpTypedFunction";
            this.grpTypedFunction.Size = new System.Drawing.Size(254, 145);
            this.grpTypedFunction.TabIndex = 5;
            this.grpTypedFunction.TabStop = false;
            this.grpTypedFunction.Text = "Typed Routines";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(13, 115);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(228, 20);
            this.txtName2.TabIndex = 4;
            this.txtName2.Text = "Goofy";
            this.txtName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 445);
            this.Controls.Add(this.grpTypedFunction);
            this.Controls.Add(this.grpVoidSub);
            this.Name = "form1";
            this.Text = "Routines";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form1_MouseDown);
            this.grpVoidSub.ResumeLayout(false);
            this.grpVoidSub.PerformLayout();
            this.grpTypedFunction.ResumeLayout(false);
            this.grpTypedFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoidSubNoArgument;
        private System.Windows.Forms.Button btnVoidSubWithArgument;
        private System.Windows.Forms.Button btnTypedFunctionWithArgument;
        private System.Windows.Forms.Button btnTypedFunctionNoArgument;
        private System.Windows.Forms.GroupBox grpVoidSub;
        private System.Windows.Forms.GroupBox grpTypedFunction;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
    }
}

