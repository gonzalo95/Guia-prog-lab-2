using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace IO
{
    class PuntoDat : Archivo , IO.IArchivos<PuntoDat>
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

        }

        public PuntoDat Leer(string ruta)
        {

        }
    }
}
