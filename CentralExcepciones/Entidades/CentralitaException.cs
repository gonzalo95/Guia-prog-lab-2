using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CentralitaException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.NombreMetodo;
            }
        }

        CentralitaException(string mensaje, string clase, string metodo)
        {

        }

        CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
        {

        }
    }
}
