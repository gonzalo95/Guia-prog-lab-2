using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Divisiones
    {
        A,
        B,
        C,
        D,
        E
    }
    public class Persona
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

        protected abstract bool ValidarDocumentacion(string documentacion)
        { }
    }
}
