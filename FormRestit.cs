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
    public partial class FormRestit : Form
    {
        private Int64 idExempl;  // Code barre de l'exemplaire

        public FormRestit()
        {
            InitializeComponent();
        }

        private void FormRestit_Load(object sender, EventArgs e)
        {
            txtB_RestEx.Focus();
        }

        private void txtB_RestEx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // bloque la saisie de texte
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtB_RestEx.Text != string.Empty)
            {
                idExempl = Convert.ToInt64(txtB_RestEx.Text); // ID de l'exemplaire
                AdoBcdSc.ScanLivre(idExempl);

                if (FormBibSC.scanL) // Scan du livre OK
                {
                    FormBibSC.formRes.Show(); // Raffraichissement de la fenêtre Résumé
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
                        txtB_RestEx.Text = "";
                        txtB_RestEx.Focus();
                    }

                }
            }
            else
            {
                txtB_RestEx.Focus();
            }
        }

        private void FormRestit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormBibSC.formRes.Dispose();
        }

        private void linkRestit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
