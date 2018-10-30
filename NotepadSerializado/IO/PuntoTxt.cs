using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<PuntoTxt>
    {
        public bool Guardar(string ruta, PuntoTxt obj)
        {

        }

        public string Leer(string ruta)
        {
            if (File.Exists(ruta))
            {
                StreamReader lector = new StreamReader(ruta);
                this.contenido = lector.ReadToEnd();
                lector.Close();
            }
            return this;
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) != ".txt")
                    throw new ArchivoIncorrectoException("El archivo no es un txt.");
            }
            catch(FileNotFoundException exc)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", exc);
            }
            return true;
        }
    }
}
