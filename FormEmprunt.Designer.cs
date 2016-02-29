namespace WindowsFormsBiblio
{
    partial class FormEmprunt
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
            this.labEmpEx = new System.Windows.Forms.Label();
            this.labAtScanEx = new System.Windows.Forms.Label();
            this.txtB_EmpEx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labEmpEx
            // 
            this.labEmpEx.AutoSize = true;
            this.labEmpEx.Font = new System.Drawing.Font("Learning Curve", 27.75F);
            this.labEmpEx.ForeColor = System.Drawing.Color.Firebrick;
            this.labEmpEx.Location = new System.Drawing.Point(6, 20);
            this.labEmpEx.Name = "labEmpEx";
            this.labEmpEx.Size = new System.Drawing.Size(326, 38);
            this.labEmpEx.TabIndex = 0;
            this.labEmpEx.Text = "Scannez le livre a emprunter";
            // 
            // labAtScanEx
            // 
            this.labAtScanEx.AutoSize = true;
            this.labAtScanEx.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAtScanEx.ForeColor = System.Drawing.Color.Red;
            this.labAtScanEx.Location = new System.Drawing.Point(64, 74);
            this.labAtScanEx.Name = "labAtScanEx";
            this.labAtScanEx.Size = new System.Drawing.Size(210, 33);
            this.labAtScanEx.TabIndex = 1;
            this.labAtScanEx.Text = "En attente du scan ...";
            // 
            // txtB_EmpEx
            // 
            this.txtB_EmpEx.Location = new System.Drawing.Point(106, 127);
            this.txtB_EmpEx.Name = "txtB_EmpEx";
            this.txtB_EmpEx.Size = new System.Drawing.Size(127, 20);
            this.txtB_EmpEx.TabIndex = 2;
            this.txtB_EmpEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_EmpEx_KeyPress);
            // 
            // FormEmprunt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.txtB_EmpEx);
            this.Controls.Add(this.labAtScanEx);
            this.Controls.Add(this.labEmpEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmprunt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprunter un livre";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmprunt_FormClosed);
            this.Load += new System.EventHandler(this.FormEmprunt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labEmpEx;
        private System.Windows.Forms.Label labAtScanEx;
        private System.Windows.Forms.TextBox txtB_EmpEx;

        public void setTxtB_EmpEx(string val) { txtB_EmpEx.Text = val; } // Accesseur pour la textBox
    }
}