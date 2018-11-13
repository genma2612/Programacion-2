using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_20_Forms
{
    public partial class frmPrincipal : Form
    {
        private Random rnd = new Random();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void MiManejadorClick(Object obj, EventArgs evento)
        {
            MessageBox.Show(((Control)obj).Name);
        }

        public void MiOtroManejadorClick(Object obj, EventArgs evento)
        {
            this.button2.Click -= new EventHandler(MiManejadorClick);
            this.button1.Click += new EventHandler(MiManejadorClick);
        }

        public void CambiarFondo(Object obj, EventArgs evento)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            ((Control)obj).BackColor = randomColor;
        }

        public void ManejadorCentral(Object obj, EventArgs evento)
        {
            // this.button3_Click(obj, evento); problema: "reinicia el orden"
            if(((Control)obj).Name == "button1")
            {
                this.button1.Click -= new EventHandler(MiManejadorClick);
                this.button1.Click -= new EventHandler(ManejadorCentral);
                this.button2.Click += new EventHandler(MiManejadorClick);
                this.button2.Click += new EventHandler(ManejadorCentral);
            }
            if (((Control)obj).Name == "button2")
            {
                this.button2.Click -= new EventHandler(MiManejadorClick);
                this.button2.Click -= new EventHandler(ManejadorCentral);
                this.textBox1.Click += new EventHandler(MiManejadorClick);
                this.textBox1.Click += new EventHandler(ManejadorCentral);
            }
            if (((Control)obj).Name == "textBox1")
            {
                this.textBox1.Click -= new EventHandler(MiManejadorClick);
                this.textBox1.Click -= new EventHandler(ManejadorCentral);
                this.button1.Click += new EventHandler(MiManejadorClick);
                this.button1.Click += new EventHandler(ManejadorCentral);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Click -= new EventHandler(MiManejadorClick);
            this.button2.Click -= new EventHandler(MiManejadorClick);
            this.textBox1.Click -= new EventHandler(MiManejadorClick);
            //this.Click -= new EventHandler(MiOtroManejadorClick);
            //this.Click -= new EventHandler(CambiarFondo);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.button1.Click += new EventHandler(MiManejadorClick);
            //this.button2.Click += new EventHandler(MiManejadorClick);
            //this.textBox1.Click += new EventHandler(MiManejadorClick);
            //this.Click += new EventHandler(MiOtroManejadorClick); // Click sobre el formulario borra el manejador del botòn 2.
            this.Click += new EventHandler(CambiarFondo);

            //
            this.button1.Click += new EventHandler(MiManejadorClick);
            this.button1.Click += new EventHandler(ManejadorCentral);
            //
        }
    }
}
