namespace WindowsFormsBiblio
{
    partial class FormScanEleve
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
            this.txtB_ScanEleve = new System.Windows.Forms.TextBox();
            this.labAtScanEleve = new System.Windows.Forms.Label();
            this.labScanEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtB_ScanEleve
            // 
            this.txtB_ScanEleve.Location = new System.Drawing.Point(109, 130);
            this.txtB_ScanEleve.Name = "txtB_ScanEleve";
            this.txtB_ScanEleve.Size = new System.Drawing.Size(127, 20);
            this.txtB_ScanEleve.TabIndex = 8;
            this.txtB_ScanEleve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_ScanEleve_KeyPress);
            // 
            // labAtScanEleve
            // 
            this.labAtScanEleve.AutoSize = true;
            this.labAtScanEleve.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAtScanEleve.ForeColor = System.Drawing.Color.Red;
            this.labAtScanEleve.Location = new System.Drawing.Point(67, 76);
            this.labAtScanEleve.Name = "labAtScanEleve";
            this.labAtScanEleve.Size = new System.Drawing.Size(210, 33);
            this.labAtScanEleve.TabIndex = 7;
            this.labAtScanEleve.Text = "En attente du scan ...";
            // 
            // labScanEleve
            // 
            this.labScanEleve.AutoSize = true;
            this.labScanEleve.Font = new System.Drawing.Font("Learning Curve", 27.75F);
            this.labScanEleve.ForeColor = System.Drawing.Color.Firebrick;
            this.labScanEleve.Location = new System.Drawing.Point(23, 21);
            this.labScanEleve.Name = "labScanEleve";
            this.labScanEleve.Size = new System.Drawing.Size(279, 38);
            this.labScanEleve.TabIndex = 6;
            this.labScanEleve.Text = "Scannez le code de l\'élève";
            // 
            // FormScanEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.txtB_ScanEleve);
            this.Controls.Add(this.labAtScanEleve);
            this.Controls.Add(this.labScanEleve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormScanEleve";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scannez le code élève";
            this.Load += new System.EventHandler(this.FormScanEleve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_ScanEleve;
        private System.Windows.Forms.Label labAtScanEleve;
        private System.Windows.Forms.Label labScanEleve;
    }
}