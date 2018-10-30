using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p, string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();
        }

        public static Persona Leer(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Persona p = (Persona)bf.Deserialize(fs);
            return p;
        }

        public override string ToString()
        {
            return string.Format("Nombre completo: {0}, {1}\n", this.apellido, this.nombre);
        }
    }
}
