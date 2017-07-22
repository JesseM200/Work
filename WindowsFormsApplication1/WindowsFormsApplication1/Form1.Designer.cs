namespace LatinTranslator
{
    partial class frmLatinTranslator
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
            this.btnSinister = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnDexter = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSinister
            // 
            this.btnSinister.Location = new System.Drawing.Point(12, 206);
            this.btnSinister.Name = "btnSinister";
            this.btnSinister.Size = new System.Drawing.Size(75, 23);
            this.btnSinister.TabIndex = 0;
            this.btnSinister.Text = "Sinister";
            this.btnSinister.UseVisualStyleBackColor = true;
            this.btnSinister.Click += new System.EventHandler(this.btnSinister_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(103, 206);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnDexter
            // 
            this.btnDexter.Location = new System.Drawing.Point(197, 206);
            this.btnDexter.Name = "btnDexter";
            this.btnDexter.Size = new System.Drawing.Size(75, 23);
            this.btnDexter.TabIndex = 2;
            this.btnDexter.Text = "Dexter";
            this.btnDexter.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(124, 131);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // frmLatinTraslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDexter);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnSinister);
            this.Name = "frmLatinTraslator";
            this.Text = "Latin Traslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSinister;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnDexter;
        private System.Windows.Forms.Label lblOutput;
    }
}

