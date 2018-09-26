using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        string apellido;
        string documento;
        string nombre;

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if(ValidarDocumentacion(value))
                    this.documento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.Documento = documento;
            this.nombre = nombre;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("Nombre: {0}\n", Nombre);
            salida.AppendFormat("Apellido: {0}\n", Apellido);
            salida.AppendFormat("Documento: {0}\n", Documento);

            return salida.ToString();
        }

        protected abstract bool ValidarDocumentacion(string documentacion);

    }
}
