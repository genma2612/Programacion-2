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
    public class Manzana : Fruta, ISerializar<Manzana>, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre { get {return "Manzana"; } }

        public override bool TieneCarozo { get { return true; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Provincia: {1} {2}", this.Nombre, this._provinciaOrigen, base.FrutaToString());
        }

        public bool Xml(string path)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
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

        bool IDeserializar.Xml(string path, out Fruta f)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Fruta));
                TextReader writer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path);
                f = (Fruta)serializer.Deserialize(writer);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                f = default(Fruta);
                return false;
            }
        }

        public Manzana(string color, double peso, string provincia) :base(color, peso)
        {
            this._provinciaOrigen = provincia;
        }

    }
}
