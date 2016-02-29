namespace WindowsFormsBiblio
{
    partial class FormResum
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResum));
            this.labTitre = new System.Windows.Forms.Label();
            this.labAuteur = new System.Windows.Forms.Label();
            this.labStatut = new System.Windows.Forms.Label();
            this.labNoElev = new System.Windows.Forms.Label();
            this.labPreElev = new System.Windows.Forms.Label();
            this.labClasse = new System.Windows.Forms.Label();
            this.pictBoxOk = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lEmprunteur = new System.Windows.Forms.Label();
            this.lLivre = new System.Windows.Forms.Label();
            this.lStaut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOk)).BeginInit();
            this.SuspendLayout();
            // 
            // labTitre
            // 
            this.labTitre.AutoSize = true;
            this.labTitre.Font = new System.Drawing.Font("Learning Curve", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitre.Location = new System.Drawing.Point(85, 40);
            this.labTitre.Name = "labTitre";
            this.labTitre.Size = new System.Drawing.Size(0, 33);
            this.labTitre.TabIndex = 2;
            // 
            // labAuteur
            // 
            this.labAuteur.AutoSize = true;
            this.labAuteur.Font = new System.Drawing.Font("Learning Curve", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuteur.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labAuteur.Location = new System.Drawing.Point(107, 80);
            this.labAuteur.Name = "labAuteur";
            this.labAuteur.Size = new System.Drawing.Size(0, 27);
            this.labAuteur.TabIndex = 3;
            // 
            // labStatut
            // 
            this.labStatut.AutoSize = true;
            this.labStatut.Font = new System.Drawing.Font("Learning Curve", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStatut.Location = new System.Drawing.Point(91, 119);
            this.labStatut.Name = "labStatut";
            this.labStatut.Size = new System.Drawing.Size(306, 27);
            this.labStatut.TabIndex = 4;
            this.labStatut.Text = "Retour enregistré ou emprunt enregistré";
            this.labStatut.Visible = false;
            // 
            // labNoElev
            // 
            this.labNoElev.AutoSize = true;
            this.labNoElev.Font = new System.Drawing.Font("Learning Curve", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNoElev.Location = new System.Drawing.Point(92, 193);
            this.labNoElev.Name = "labNoElev";
            this.labNoElev.Size = new System.Drawing.Size(0, 33);
            this.labNoElev.TabIndex = 5;
            // 
            // labPreElev
            // 
            this.labPreElev.AutoSize = true;
            this.labPreElev.Font = new System.Drawing.Font("Learning Curve", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPreElev.Location = new System.Drawing.Point(117, 226);
            this.labPreElev.Name = "labPreElev";
            this.labPreElev.Size = new System.Drawing.Size(0, 33);
            this.labPreElev.TabIndex = 6;
            // 
            // labClasse
            // 
            this.labClasse.AutoSize = true;
            this.labClasse.Font = new System.Drawing.Font("Learning Curve", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labClasse.ForeColor = System.Drawing.Color.SlateBlue;
            this.labClasse.Location = new System.Drawing.Point(321, 228);
            this.labClasse.Name = "labClasse";
            this.labClasse.Size = new System.Drawing.Size(64, 30);
            this.labClasse.TabIndex = 8;
            this.labClasse.Text = "Classe";
            // 
            // pictBoxOk
            // 
            this.pictBoxOk.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxOk.Image")));
            this.pictBoxOk.Location = new System.Drawing.Point(303, 117);
            this.pictBoxOk.Name = "pictBoxOk";
            this.pictBoxOk.Size = new System.Drawing.Size(30, 30);
            this.pictBoxOk.TabIndex = 9;
            this.pictBoxOk.TabStop = false;
            this.pictBoxOk.Visible = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.Location = new System.Drawing.Point(7, 40);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(69, 33);
            this.l1.TabIndex = 10;
            this.l1.Text = "Titre :";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(7, 74);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(93, 33);
            this.l2.TabIndex = 11;
            this.l2.Text = "Auteur :";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(7, 193);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(75, 33);
            this.l3.TabIndex = 12;
            this.l3.Text = "Nom :";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l4.Location = new System.Drawing.Point(7, 226);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(101, 33);
            this.l4.TabIndex = 13;
            this.l4.Text = "Prénom :";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lEmprunteur
            // 
            this.lEmprunteur.AutoSize = true;
            this.lEmprunteur.Font = new System.Drawing.Font("Learning Curve", 24F);
            this.lEmprunteur.ForeColor = System.Drawing.Color.SlateBlue;
            this.lEmprunteur.Location = new System.Drawing.Point(7, 157);
            this.lEmprunteur.Name = "lEmprunteur";
            this.lEmprunteur.Size = new System.Drawing.Size(217, 33);
            this.lEmprunteur.TabIndex = 14;
            this.lEmprunteur.Text = "Emprunteur .....................";
            // 
            // lLivre
            // 
            this.lLivre.AutoSize = true;
            this.lLivre.Font = new System.Drawing.Font("Learning Curve", 24F);
            this.lLivre.ForeColor = System.Drawing.Color.SlateBlue;
            this.lLivre.Location = new System.Drawing.Point(7, 3);
            this.lLivre.Name = "lLivre";
            this.lLivre.Size = new System.Drawing.Size(215, 33);
            this.lLivre.TabIndex = 15;
            this.lLivre.Text = "Livre ...................................";
            // 
            // lStaut
            // 
            this.lStaut.AutoSize = true;
            this.lStaut.Font = new System.Drawing.Font("Learning Curve", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStaut.Location = new System.Drawing.Point(7, 114);
            this.lStaut.Name = "lStaut";
            this.lStaut.Size = new System.Drawing.Size(90, 33);
            this.lStaut.TabIndex = 16;
            this.lStaut.Text = "Statut :";
            // 
            // FormResum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 263);
            this.Controls.Add(this.lStaut);
            this.Controls.Add(this.lLivre);
            this.Controls.Add(this.lEmprunteur);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.pictBoxOk);
            this.Controls.Add(this.labClasse);
            this.Controls.Add(this.labPreElev);
            this.Controls.Add(this.labNoElev);
            this.Controls.Add(this.labStatut);
            this.Controls.Add(this.labAuteur);
            this.Controls.Add(this.labTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormResum";
            this.Text = "Résumé";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labTitre;
        private System.Windows.Forms.Label labAuteur;
        private System.Windows.Forms.Label labStatut;
        private System.Windows.Forms.Label labNoElev;
        private System.Windows.Forms.Label labPreElev;
        private System.Windows.Forms.Label labClasse;
        private System.Windows.Forms.PictureBox pictBoxOk;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lEmprunteur;
        private System.Windows.Forms.Label lLivre;
        private System.Windows.Forms.Label lStaut;
    }
}