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
    public partial class FormEmpEnCours : Form
    {
        static public bool isOpen = false;
        static ListViewItem it;
        public FormEmpEnCours()
        {
            InitializeComponent();
            isOpen = true;
        }

        private void FormEmprunts_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

        private void FormEmpEnCours_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bcdStChristopheDataSet1.Classe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.classeTableAdapter1.Fill(this.bcdStChristopheDataSet1.Classe);
            // TODO: cette ligne de code charge les données dans la table 'bcdStChristopheDataSet.Classe'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.classeTableAdapter.Fill(this.bcdStChristopheDataSet.Classe);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != " ")
            {
                string select = comboBox1.SelectedValue.ToString();
                AdoBcdSc.ListEmp(select); // Recherche des emprunts en cours 
                int i = 0;
                //ListViewItem it = new ListViewItem();
                listView1.Items.Clear(); // Initialisation de la liste
                DateTime datE = new DateTime();

                if (AdoBcdSc.listE.Count>0) // Si il y a des emprunts on remplit la liste
                {
                    foreach (var item in AdoBcdSc.listE)
                    {
                        it = new ListViewItem();
                        it.SubItems[0].Text = AdoBcdSc.listE[i].NOM;
                        it.SubItems.Add(AdoBcdSc.listE[i].PRENOM);
                        it.SubItems.Add(AdoBcdSc.listE[i].Titre);
                        datE = Convert.ToDateTime(AdoBcdSc.listE[i].DATEEMPRUNT);
                        it.SubItems.Add(datE.ToShortDateString());
                        listView1.Items.Add(it);               
                        i++;
                    }
                }            
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            MessageBox.Show(it.Selected.ToString()); // ????????????
        }
    }
}
