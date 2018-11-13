using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_20_Delegados_y_Forms
{
    public partial class frmPrincipal : Form
    {
        public actualizarNombrePorDelegado miDel;

        public frmPrincipal()
        {
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados delegado = new frmTestDelegados();
            delegado.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.Show(this);
            this.miDel += new actualizarNombrePorDelegado(datos.ActualizarNombre);
            //this.miDel.Invoke("Manuel Gonzalez");
        }


    }
}
