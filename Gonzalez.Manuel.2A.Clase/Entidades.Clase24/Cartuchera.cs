using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Clase24
{
    public class Cartuchera<T> : IInterface
    {
        private string _marca;
        private byte _capacidad;
        private List<T> _elementos;

        public void Add(T elemento)
        {
            if (this._elementos.Count == this._capacidad)
                throw new CartucheraLlenaExcepcion();
            else
                this._elementos.Add(elemento);
        }

        public bool Remove(T elemento)
        {
            bool retorno = false;
            if (this._elementos.Remove(elemento))
                retorno = true;
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Marca: {0} Capacidad: {1}\n", this._marca, this._capacidad);
            foreach (T item in this._elementos)
            {
                retorno.Append(item.ToString());
            }
            return retorno.ToString();
        }

        public void SerializarXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cartuchera<T>));
            XmlTextWriter writer = new XmlTextWriter("Cartuchera.xml", Encoding.UTF8);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public void DeserializarXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cartuchera<T>));
            TextReader writer = new StreamReader(path);
            //Cartuchera<T> c = (T)serializer.Deserialize(writer);
            writer.Close();
        }

        public static implicit operator Cartuchera<T>(byte b)
        {
            return new Cartuchera<T>(b);
        }

        public Cartuchera()
        {

        }
        
        private Cartuchera(byte capacidad)
        {
            this._elementos = new List<T>();
            this._capacidad = capacidad;
        }
    }
}
