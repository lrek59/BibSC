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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            // Init du champ mot de passe //
            txtBoxMdp.Text = "";
            txtBoxMdp.PasswordChar = '*';
            txtBoxMdp.MaxLength = 10;
     
        }
    }
}
