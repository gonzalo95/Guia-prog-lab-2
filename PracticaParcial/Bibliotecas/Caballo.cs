using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Caballo : Animal
    {
        private static int _patas;
        private string _nombre;

        static Caballo()
        {
            _patas = 4;
        }

        public Caballo(string nombre, int velocidadMaxima)
            : base(_patas, velocidadMaxima)
        {
            this._nombre = nombre;
        }

        public string MostrarCaballo()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Nombre: " + this._nombre);
            salida.Append(base.MostrarDatos());

            return salida.ToString();
        }

        public static bool operator ==(Caballo c1, Caballo c2)
        {
            return c1._nombre == c2._nombre;
        }

        public static bool operator !=(Caballo c1, Caballo c2)
        {
            return !(c1 == c2);
        }

    }
}
