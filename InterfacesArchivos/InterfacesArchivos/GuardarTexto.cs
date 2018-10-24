using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesArchivos
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public string Leer()
        {
            return Convert.ChangeType("Texto leido", typeof(V)); // Ni idea pero no anda.
        }
    }
}
