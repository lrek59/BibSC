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
    public partial class FormEmprunts : Form
    {
        static public bool isOpen = false;
        public FormEmprunts()
        {
            InitializeComponent();
            isOpen = true;
        }

        private void FormEmprunts_FormClosed(object sender, FormClosedEventArgs e)
        {
            isOpen = false;
        }

    }
}
