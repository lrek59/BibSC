namespace WindowsFormsBiblio
{
    partial class FormRestit
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
            this.txtB_RestEx = new System.Windows.Forms.TextBox();
            this.labAtScanExRest = new System.Windows.Forms.Label();
            this.labRestEx = new System.Windows.Forms.Label();
            this.linkRestit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtB_RestEx
            // 
            this.txtB_RestEx.Location = new System.Drawing.Point(107, 127);
            this.txtB_RestEx.Name = "txtB_RestEx";
            this.txtB_RestEx.Size = new System.Drawing.Size(127, 20);
            this.txtB_RestEx.TabIndex = 5;
            this.txtB_RestEx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_RestEx_KeyPress);
            // 
            // labAtScanExRest
            // 
            this.labAtScanExRest.AutoSize = true;
            this.labAtScanExRest.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAtScanExRest.ForeColor = System.Drawing.Color.Red;
            this.labAtScanExRest.Location = new System.Drawing.Point(65, 73);
            this.labAtScanExRest.Name = "labAtScanExRest";
            this.labAtScanExRest.Size = new System.Drawing.Size(210, 33);
            this.labAtScanExRest.TabIndex = 4;
            this.labAtScanExRest.Text = "En attente du scan ...";
            // 
            // labRestEx
            // 
            this.labRestEx.AutoSize = true;
            this.labRestEx.Font = new System.Drawing.Font("Learning Curve", 27.75F);
            this.labRestEx.ForeColor = System.Drawing.Color.Firebrick;
            this.labRestEx.Location = new System.Drawing.Point(21, 18);
            this.labRestEx.Name = "labRestEx";
            this.labRestEx.Size = new System.Drawing.Size(299, 38);
            this.labRestEx.TabIndex = 3;
            this.labRestEx.Text = "Scannez le livre a restituer";
            // 
            // linkRestit
            // 
            this.linkRestit.AutoSize = true;
            this.linkRestit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRestit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRestit.LinkColor = System.Drawing.Color.Teal;
            this.linkRestit.Location = new System.Drawing.Point(100, 153);
            this.linkRestit.Name = "linkRestit";
            this.linkRestit.Size = new System.Drawing.Size(147, 15);
            this.linkRestit.TabIndex = 6;
            this.linkRestit.TabStop = true;
            this.linkRestit.Text = "Restituer sans code barre";
            this.linkRestit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRestit_LinkClicked);
            // 
            // FormRestit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.linkRestit);
            this.Controls.Add(this.txtB_RestEx);
            this.Controls.Add(this.labAtScanExRest);
            this.Controls.Add(this.labRestEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormRestit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restituer un livre";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRestit_FormClosed);
            this.Load += new System.EventHandler(this.FormRestit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_RestEx;
        private System.Windows.Forms.Label labAtScanExRest;
        private System.Windows.Forms.Label labRestEx;

        public void setTxtB_RestEx(string val) { txtB_RestEx.Text = val; } // Accesseur pour la textBox

        private System.Windows.Forms.LinkLabel linkRestit;
    }
}