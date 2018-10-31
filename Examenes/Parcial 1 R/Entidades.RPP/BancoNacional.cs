using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class BancoNacional : Banco
    {
        public string pais;

        public BancoNacional(string nombre, string pais) :base(nombre)
        {
            this.pais = pais;
        }

        public override string Mostrar()
        {
            return "NOMBRE: " + base.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return "PAIS: " + this.pais + " - ";
        }
    }
}
