using System;
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
    public partial class FormResum : Form
    {
        public FormResum()
        {
            InitializeComponent();

        }

        private string statutResum = string.Empty;

        // Methodes //

        public void MajResumL(string paramTitre, string paramAuteur)
        {
            labTitre.Text = paramTitre;
            labAuteur.Text = paramAuteur;
        }

        public void MajResumP(string paramNom, string paramPrenom, string paramClasse)
        {
            labNoElev.Text = paramNom;
            labPreElev.Text = paramPrenom;
            labClasse.Text = paramClasse;
        }

        public void MajRetour(string paramNom, string paramPrenom, string paramClasse, string paramTitre, string paramAuteur)
        {
            labTitre.Text = paramTitre;
            labAuteur.Text = paramAuteur;
            labNoElev.Text = paramNom;
            labPreElev.Text = paramPrenom;
            labClasse.Text = paramClasse;
            statutResum = "retourOk";
            MajStatut(statutResum);
        }

        public void MajStatut(string statut)
        {
            statutResum = statut;

            if (statut == "empruntOk") // C'est un emprunt
            {
                labStatut.Text = "Emprunt enregistré"; // Maj du champ Statut
                labStatut.Visible = true; // Statut visible
                pictBoxOk.Visible = true; // Affichage de l'image OK
                timer.Start(); // Démarrage du Timer
            }

            if (statut == "retourOk") // C'est un retour
            {
                labStatut.Text = "Retour enregistré"; // Maj du champ Statut
                labStatut.Visible = true; // Statut visible
                pictBoxOk.Visible = true; // Affichage de l'image OK
                timer.Start(); // Démarrage du Timer
            }

        }

        // Timer // 

        private void timer_Tick(object sender, EventArgs e)
        {

            timer.Stop(); // Arrêt du Timer après 2 Sec

            // Reinitialisation formRes
            init();
            pictBoxOk.Visible = false;
            labClasse.Text = "Classe";

            if (statutResum == "empruntOk") // C'est un emprunt
            {
                FormBibSC.formEmp.Visible = true; // On rend visible la fenêtre d'emprunt
                FormBibSC.formEmp.setTxtB_EmpEx(""); // Initialisation du champ
            }

            else // C'est un retour
            {

                if (Application.OpenForms["formRestit"] != null)
                {
                    FormBibSC.formRest.Visible = true;
                    FormBibSC.formRest.setTxtB_RestEx("");
                }

                else // Retour "Forcé" !!!
                {
                    AdoBcdSc.ScanLivre(AdoBcdSc.idEx); // Appel de la methode ScanLivre         
                }
            }
        }

        public void init()
        {
            foreach (Control lb in Controls)
            {
                if (lb.GetType() == typeof(Label))
                {
                    if (lb.Name.StartsWith("lab"))
                    {
                        lb.Text = "";
                    }
                }
            }


        }

    }
}
