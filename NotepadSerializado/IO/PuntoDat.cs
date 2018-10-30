using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable]
    public class PuntoDat : Archivo , IO.IArchivos<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) != ".dat")
                    throw new ArchivoIncorrectoException("El archivo no es un dat.");
            }
            catch(FileNotFoundException exc)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", exc);
            }
            return true;
        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            FileStream fs = new FileStream(ruta, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, obj);
            fs.Close();
            return true; ;
        }

        public PuntoDat Leer(string ruta)
        {
            FileStream fs = new FileStream(ruta, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            PuntoDat salida = (PuntoDat)bf.Deserialize(fs);
            fs.Close();
            return salida;
        }
    }
}
