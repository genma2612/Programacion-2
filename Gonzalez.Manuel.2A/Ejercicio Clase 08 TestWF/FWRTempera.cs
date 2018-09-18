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
    public partial class FWRTempera : Form
    {
        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get { return this._miTempera; }
        }


        public FWRTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }
            this.cboColor.SelectedItem = ConsoleColor.Red;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FWRTempera(Tempera Temp) : this()
        {
            this.textBox1.Text = ((sbyte) Temp).ToString();
            //this.textBox1.Text = ;
            //this.cboColor.SelectedItem = ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._miTempera = new Tempera(this.textBox2.Text, (ConsoleColor)this.cboColor.SelectedItem, sbyte.Parse(this.textBox1.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
