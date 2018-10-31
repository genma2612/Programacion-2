using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.RPP
{
    public class ClaseConstructores
    {
        public int valor;

        public int PropiedadEscritura
        {
            set
            {
                this.valor = value;
                MessageBox.Show("Propiedad de Escritura");
            }
        }

        public int PropiedadLectura
        {
            get
            {
                MessageBox.Show("Propiedad de Lectura");
                return this.MetodoDeInstancia();
            }
        }

        public static int MetodoEstatico()
        {
            MessageBox.Show("Mètodo estàtico");
            return 2;
        }

        public int MetodoDeInstancia()
        {
            MessageBox.Show("Mètodo de clase");
            return ClaseConstructores.MetodoEstatico();
        }

        static ClaseConstructores()
        {
            MessageBox.Show("Constructor Estàtico");
        }

        private ClaseConstructores(int A, int B)
        {
            this.PropiedadEscritura = this.PropiedadLectura;
            MessageBox.Show("Constructor con parametros");
        }

        public ClaseConstructores() : this(1,2)
        {
            MessageBox.Show("Constructor default");
        }
    }
}
