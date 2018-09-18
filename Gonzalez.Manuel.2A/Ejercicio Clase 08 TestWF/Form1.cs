using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase07;

namespace Ejercicio_Clase_08_TestWF
{
    public partial class Form1 : Form
    {

        Paleta _miPaleta;

        public Form1()
        {
            InitializeComponent();
            _miPaleta = 5;
            this.groupBox1.Text = "Paleta de Colores";
            this.textBox1.Multiline = true;
            this.button1.Text = "+";
            this.button2.Text = "-";
        }

        private void agregarPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.agregarPaletaToolStripMenuItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FWRTempera fortemp = new FWRTempera();
            DialogResult result = fortemp.ShowDialog();
            if(result == DialogResult.OK)
            {
                this._miPaleta += fortemp.MiTempera;
                this.textBox1.Text = (string) _miPaleta;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FWRTempera fortemp = new FWRTempera();
            DialogResult result = fortemp.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._miPaleta -= fortemp.MiTempera;
                this.textBox1.Text = (string)_miPaleta;
            }
        }
    }
}
