using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string msj) : base(msj) { }

        public ErrorArchivoException(string msj, Exception e) : base(msj, e) { }
    }
}
