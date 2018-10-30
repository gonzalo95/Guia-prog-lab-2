using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string obj)
        {
            if (obj != null)
            {
                StreamWriter escritor = new StreamWriter(ruta);
                escritor.Write(obj);
                escritor.Close();
            }
            return true;
        }

        public string Leer(string ruta)
        {
            string salida = string.Empty;
            ValidarArchivo(ruta);

            StreamReader lector = new StreamReader(ruta);
            salida = lector.ReadToEnd();
            lector.Close();

            return salida;
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
