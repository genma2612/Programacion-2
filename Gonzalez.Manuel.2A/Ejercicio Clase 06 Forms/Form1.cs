using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_06_Forms
{
    public partial class Form1 : Form
    {
        private Tinta _tinta;
        private Pluma _pluma;


        public Form1()
        {
            InitializeComponent();
        }

        private void tintaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tinta formT = new Form_Tinta();
            formT.Show();
        }

        private void plumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pluma formP = new Form_Pluma();
            formP.Show();

        }
    }
}
