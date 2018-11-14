using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IArchivo<T>
    {
        T Leer(string ruta);
        bool Guardar(string ruta, T objeto);
    }
}
