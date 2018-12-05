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

        private string _provinciaOrigen;

        public string Nombre { get {return "Manzana"; } }
        public override bool TieneCarozo { get { return true; } }
        public string ProvinciaOrigen { get { return this._provinciaOrigen; } set { this._provinciaOrigen = value; } }

        public override string ToString()
        {
            return string.Format("Nombre: {0} Provincia: {1} {2} Tiene Carozo: {3}", this.Nombre, this.ProvinciaOrigen, base.FrutaToString(), this.TieneCarozo);
        }

        public bool Xml(string path) //Constructor sin parametros necesario.
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path, Encoding.UTF8);
                serializer.Serialize(writer,this);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool IDeserializar.Xml(string path, out Fruta f) //Explicito: Castear en main (IDeserializar)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Manzana));
                XmlTextReader writer = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + path);
                f = (Manzana)serializer.Deserialize(writer);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                f = default(Manzana);
                return false;
            }
        }

        public Manzana()
        {
        }

        public Manzana(string color, double peso, string provincia) :base(color, peso)
        {
            this.ProvinciaOrigen = provincia;
        }

    }
}
