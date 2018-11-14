using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosExtension
    {
        public static void Formatear(this string texto, int espacios)
        {
            String.Format("{0, X}", texto, espacios);
        }
    }
}
