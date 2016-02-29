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
    public partial class FormEmprunt : Form
    {
        private Int64 idExempl; // Code barre de l'exemplaire

        public FormEmprunt()
        {
            InitializeComponent();
        }

        private void FormEmprunt_Load(object sender, EventArgs e)
        {
            txtB_EmpEx.Focus();
        }

        private void txtB_EmpEx_KeyPress(object sender, KeyPressEventArgs e)

        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // bloque la saisie de texte
            {
                e.Handled = true;
            }

                if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtB_EmpEx.Text!=string.Empty) // Apres validation par touche entrée si le champ n'est pas vide
            {
                idExempl = Convert.ToInt64(txtB_EmpEx.Text); // ID de l'exemplaire
                AdoBcdSc.ScanLivre(idExempl); // Appel de la methode ScanLivre
                FormBibSC.paramIdExem = idExempl; // Enregistrement de l'ID Exemplaire

                if (FormBibSC.scanL) // Scan du livre OK
                {
                    FormBibSC.formRes.Show(); // Raffraichissement de la fenêtre Résumé
                    FormBibSC.scanL = true; // Scan du livre terminé
                    this.Visible = false;    // On masque la fenêtre        
                }

                else // Scan du livre KO
                {
                    if (MessageBox.Show("Cet exemplaire n'existe pas, voulez-vous enregistrer cet exemplaire maintenant ?", "Exemplaire inexistant !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Affichage de la fenetre d'enregistrement du livre
                    }
                    else
                    {
                        MessageBox.Show("Veuillez mettre ce livre dans le bac \"Livres à problèmes\"");
                        txtB_EmpEx.Text = "";
                        txtB_EmpEx.Focus();
                    }
                }

            }
            else
            {
                txtB_EmpEx.Focus();
            }
     
        }

        private void FormEmprunt_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormBibSC.formRes.Dispose(); // Fermeture de la fenêtre
        }
    }
}
