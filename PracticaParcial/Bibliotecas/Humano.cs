using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Humano : Animal
    {
        private static int _piernas;
        private string _nombre;
        private string _apellido;

        static Humano()
        {
            _piernas = 2;
        }

        public Humano(int velocidadMaxima) : base(_piernas, velocidadMaxima)
        { }

        public Humano(string nombre, string apellido, int velocidadMaxima)
            : this (velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string MostrarHumano()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Nombre: " + this._nombre);
            salida.AppendLine("Apellido: " + this._apellido);
            salida.Append(base.MostrarDatos());

            return salida.ToString();
        }

        public static bool operator ==(Humano h1, Humano h2)
        {
            return h1._nombre == h2._nombre && h1._apellido == h2._apellido;
        }

        public static bool operator !=(Humano h1, Humano h2)
        {
            return !(h1 == h2);
        }
    }
}
