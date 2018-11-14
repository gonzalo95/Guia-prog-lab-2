using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    public class Torneo : IEntradaSalida<bool>
    {


        private List<Grupo> grupos;
        private string nombre;
        
        public Torneo(string nombre)
        {
            this.grupos = new List<Grupo>();
            this.nombre = nombre;
        }

        public bool Guardar()
        {
            foreach (Grupo g in this.grupos)
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Grupo));
                XmlTextWriter escritor = new XmlTextWriter(Environment.SpecialFolder.Desktop + string.Format("\\grupo-{0}.xml", g.Letra), Encoding.UTF8);
                serializador.Serialize(escritor, g);
                escritor.Close();
            }
            return true;
        }

        public bool Leer()
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Grupo));
            XmlTextReader lector = new XmlTextReader(archivo);
            this.grupos.Add((Grupo)serializador.Deserialize(lector));
            lector.Close();
        }
    }
}
