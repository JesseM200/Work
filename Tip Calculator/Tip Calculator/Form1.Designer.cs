namespace Tip_Calculator
{
    partial class frmTipCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lsOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cost :";
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(53, 6);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(147, 20);
            this.txtcost.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(125, 32);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsOutput
            // 
            this.lsOutput.FormattingEnabled = true;
            this.lsOutput.Location = new System.Drawing.Point(12, 70);
            this.lsOutput.Name = "lsOutput";
            this.lsOutput.Size = new System.Drawing.Size(188, 173);
            this.lsOutput.TabIndex = 3;
            // 
            // frmTipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 261);
            this.Controls.Add(this.lsOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.label1);
            this.Name = "frmTipCalculator";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lsOutput;
    }
}

