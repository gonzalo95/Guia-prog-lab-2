using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Perro : Animal
    {
        public enum Razas
        {
            Galgo,
            OvejeroAleman
        }

        private static int _patas;
        private Razas raza;

        static Perro()
        {
            _patas = 4;
        }

        public Perro(int velocidadMaxima) : base(_patas, velocidadMaxima)
        { }

        public Perro(Razas raza, int velocidadMaxima)
            : this(velocidadMaxima)
        {
            this.raza = raza;
        }

        public string MostrarPerro()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.MostrarDatos());
            salida.AppendLine("Raza: " + this.raza);

            return salida.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return p1.raza == p2.raza && p1.VelocidadMaxima == p2.VelocidadMaxima;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
    }
}
