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
    public partial class Form_Tinta : Form
    {
        public Form_Tinta()
        {
            InitializeComponent();
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboColor.Items.Add(color);
            }
            this.cboColor.SelectedItem = ConsoleColor.Black;
            this.cboColor.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (ETipoTinta tipo in Enum.GetValues(typeof(ETipoTinta)))
            {
                this.cboTipo.Items.Add(tipo);
            }
            this.cboTipo.SelectedItem = ETipoTinta.Comun;
            this.cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
