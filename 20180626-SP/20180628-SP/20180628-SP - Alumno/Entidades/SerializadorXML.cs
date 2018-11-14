using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class SerializadorXML<T> : IArchivo<T>
    {
        public T Leer(string ruta)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                XmlTextReader lector = new XmlTextReader(ruta);
                T dato = (T)serializador.Deserialize(lector);
                lector.Close();
                return dato;
            }
            catch(Exception exc)
            {
                throw new ErrorArchivoException("Error al leer", exc);
            }
        }

        public bool Guardar(string ruta, T objeto)
        {
            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(T));
                XmlTextWriter escritor = new XmlTextWriter(ruta, Encoding.UTF8);
                serializador.Serialize(escritor, objeto);
                escritor.Close();
            }
            catch (Exception exc)
            {
                throw new ErrorArchivoException("Error al guardar", exc);
            }
            return true;
        }
    }
}
