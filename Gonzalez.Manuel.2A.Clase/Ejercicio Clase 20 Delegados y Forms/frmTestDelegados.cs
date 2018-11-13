﻿using System;
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
    public partial class frmTestDelegados : Form
    {
        public frmTestDelegados()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.textBox1.Text;
            ((frmPrincipal)this.Owner).miDel(s);
        }
    }
}
