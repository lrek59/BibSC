namespace WindowsFormsBiblio
{
    partial class FormBibSC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBibSC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntsEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butEmp = new System.Windows.Forms.Button();
            this.butRest = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Learning Curve", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.empruntsEnCoursToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(116, 31);
            this.seConnecterToolStripMenuItem.Text = "&Se connecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // empruntsEnCoursToolStripMenuItem
            // 
            this.empruntsEnCoursToolStripMenuItem.ForeColor = System.Drawing.Color.MediumOrchid;
            this.empruntsEnCoursToolStripMenuItem.Name = "empruntsEnCoursToolStripMenuItem";
            this.empruntsEnCoursToolStripMenuItem.Size = new System.Drawing.Size(168, 31);
            this.empruntsEnCoursToolStripMenuItem.Text = "&Emprunts en cours";
            this.empruntsEnCoursToolStripMenuItem.Click += new System.EventHandler(this.empruntsEnCoursToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(99, 31);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            // 
            // butEmp
            // 
            this.butEmp.BackColor = System.Drawing.Color.White;
            this.butEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEmp.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEmp.Font = new System.Drawing.Font("Learning Curve", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEmp.ForeColor = System.Drawing.Color.Firebrick;
            this.butEmp.Location = new System.Drawing.Point(549, 383);
            this.butEmp.Name = "butEmp";
            this.butEmp.Size = new System.Drawing.Size(154, 53);
            this.butEmp.TabIndex = 2;
            this.butEmp.Text = "Emprunter";
            this.butEmp.UseVisualStyleBackColor = false;
            this.butEmp.Click += new System.EventHandler(this.butEmp_Click);
            // 
            // butRest
            // 
            this.butRest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butRest.BackColor = System.Drawing.Color.White;
            this.butRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRest.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRest.Font = new System.Drawing.Font("Learning Curve", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRest.ForeColor = System.Drawing.Color.Firebrick;
            this.butRest.Location = new System.Drawing.Point(791, 383);
            this.butRest.Name = "butRest";
            this.butRest.Size = new System.Drawing.Size(154, 53);
            this.butRest.TabIndex = 4;
            this.butRest.Text = "Restituer";
            this.butRest.UseVisualStyleBackColor = false;
            this.butRest.Click += new System.EventHandler(this.butRest_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1110, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 135);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormBibSC
            // 
            this.AcceptButton = this.butEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.butRest);
            this.Controls.Add(this.butEmp);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBibSC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliothèque Saint-Christophe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBibSC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntsEnCoursToolStripMenuItem;
        private System.Windows.Forms.Button butEmp;
        private System.Windows.Forms.Button butRest;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

