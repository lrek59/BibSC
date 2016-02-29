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
    public partial class FormScanEleve : Form
    {
        private int idPers; // Code barre de la personne
  
        public FormScanEleve()
        {
            InitializeComponent();
        }

        private void FormScanEleve_Load(object sender, EventArgs e)
        {
            txtB_ScanEleve.Focus();
        }

        private void txtB_ScanEleve_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // bloque la saisie de texte
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter) && txtB_ScanEleve.Text != string.Empty && txtB_ScanEleve.Text.Length <= 8) // Apres validation par touche entrée si le champ n'est pas vide
            {
                idPers = Convert.ToInt32(txtB_ScanEleve.Text); // ID de l'éléve
                AdoBcdSc.ScanEleve(idPers); // Appel de la methode ScanEleve
                FormBibSC.paramIdPers = idPers; // Enregistrement de l'ID de l'Eleve
                FormBibSC.formEle.Dispose(); // Fermeture de cette fenêtre
            }
    
            else
            {
                txtB_ScanEleve.Focus();
            }
        }
    }
}
