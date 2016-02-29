using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBiblio
{
    public partial class FormBibSC : Form
    {
        // Variables // 

        private FormEmpEnCours empEnCours; // Emprunts en cours
        public MdiClient ctlMDI;
        public static Int64 paramIdExem; // enregistrement de l'ID de l'exemplaire
        public static int paramIdPers; // enregistrement de l'ID de l'eleve
        private DateTime datEmp = DateTime.Now;
        public static FormResum formRes; // Fenêtre Résumé
        public static FormEmprunt formEmp; // Fenêtre Emprunter
        public static FormRestit formRest; // Fenêtre Restituer
        public static FormScanEleve formEle; // Scan Eleve
        public static bool scanL; // Verif si scan Livre OK
        public static bool scanP; // Verif si scan Personne OK
        private string statut = string.Empty;
        public bool timeOff;

        //-----------//

        public FormBibSC()
        {
            InitializeComponent();
        }

        private void butEmp_Click(object sender, EventArgs e) // EMPRUNTER UN LIVRE
        {
            scanL = false; scanP = false;
            formEmp = new FormEmprunt(); // Creation du WinForm Emprunter un livre
            formRes = new FormResum(); // Creation du WinForm Resume un livre
            formRes.MdiParent = this; // Definition du parent
            formRes.Show();// Affichage de la fenêtre de résumé
            formRes.Left = (this.ClientSize.Width - formRes.Width - 5);  // Position de la fenêtre de résumé
            formRes.Top = 5;

            formEmp.ShowDialog(); // Affichage de la fenetre d'emprunt

            if (scanL)
            {
                formEle = new FormScanEleve();
                formEle.ShowDialog(); // Affichage de la fenêtre Scan Eleve
            }
 
            if (scanP)
            {
                formRes.Show(); // // Raffraichissement de la fenêtre Résumé                       
                AdoBcdSc.EnrEmprunt(paramIdPers, paramIdExem, datEmp); // Enregistrement de l'emprunt
                statut = "empruntOk";
                formRes.MajStatut(statut); // modification du statut dans la fenêtre de Résumé
            }

        }

        private void butRest_Click(object sender, EventArgs e) // RESTITUER UN LIVRE
        {
            scanL = false; scanP = false;
            formRest = new FormRestit(); // Creation du WinForm Restituer un livre
            formRes = new FormResum(); // Creation du WinForm Resume un livre
            formRes.MdiParent = this; // Definition du parent
            formRes.Show(); // Affichage de la fenêtre de résumé
            formRes.Left = (this.ClientSize.Width - formRes.Width - 5);  // Position de la fenêtre de résumé
            formRes.Top = 5;
            formRest.ShowDialog(); // Affichage de la fenêtre Restituer un livre

            //if (scanL)
            //{
            //    formRes.Show(); // Raffraichissement de la fenêtre Résumé    
            //    statut = "retourOk";
            //   /* formRes.MajStatut(statut);*/ // modification du statut dans la fenêtre de Résumé
            //}

        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConnexion formCnx = new FormConnexion();
            formCnx.ShowDialog();
        }

        private void FormBibSC_Load(object sender, EventArgs e)
        {
            // position des boutons

            butEmp.Left = (this.ClientSize.Width / 2) - butEmp.Width;
            butEmp.Top = (this.ClientSize.Height - butEmp.Height) / 2;
            butRest.Top = (this.ClientSize.Height - butRest.Height) / 2;

            // Background Blanc

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            // Position du logo

            pictureBox1.Left = this.ClientSize.Width - (pictureBox1.Width + 10);
            pictureBox1.Top = this.ClientSize.Height - (pictureBox1.Height + 10 + statusStrip1.Height);
        }

        // Liste des emprunts en cours //

        private void empruntsEnCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormEmpEnCours.isOpen)
            {
                empEnCours = new FormEmpEnCours();
                empEnCours.MdiParent = this;
                empEnCours.Show();
                // empEnCours.Width = Convert.ToInt16(this.ClientSize.Width * 0.25);
                empEnCours.Height = this.ClientSize.Height - (20 + menuStrip1.Height + statusStrip1.Height);
                empEnCours.Left = 10;
                empEnCours.Top = 10;

            }
            else
            {
                empEnCours.WindowState = FormWindowState.Normal;
                empEnCours.Left = 10;
                empEnCours.Top = 10;
            }
        }

    }
}
