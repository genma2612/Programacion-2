using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.sp
{
    public delegate void EventoPrecio();

    public class Cajon<T> :ISerializar<T>
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public List<T> Elementos { get { return this._elementos; } }
        public double PrecioTotal { get { return this._elementos.Count * this._precioUnitario; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", this.Elementos.Count, this._capacidad);
            sb.AppendLine("");
            foreach (T item in this.Elementos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Cajon<T>));
                XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, Encoding.UTF8);
                serializer.Serialize(writer, this);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c.Elementos.Count < c._capacidad)
            {
                c.Elementos.Add(f);
            }
            else
                throw new CajonLlenoException();
            return c;
        }

        public Cajon()
        {
            _elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precio, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precio;
        }

    }
}
