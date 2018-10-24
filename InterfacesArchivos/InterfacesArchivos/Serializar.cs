using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace InterfacesArchivos
{
    public class Serializar<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public string Leer()
        {
            return Convert.ChangeType("Objeto leido", typeof(V)); // Ni idea pero no anda.
        }
    }
}
