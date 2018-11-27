using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase24
{
    public interface IInterface
    {
        void SerializarXml(string path); 
        void DeserializarXml(string path);
    }
}
