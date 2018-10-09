using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        int edad;
        bool esAlpha;

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlpha

        {
            get
            {
                return this.esAlpha;
            }
            set
            {
                this.esAlpha = value;

            }
        }

        public Perro(string nom, string raza, int edad, bool alpha)
            : base(nom, raza)
        {
            Edad = edad;
            EsAlpha = alpha;
        }

        public Perro(string nom, string raza)
            : this(nom, raza, 0, false)
        {
        }

        protected override string Ficha()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.DatosCompletos());

            if (EsAlpha)
                salida.Append(", alfa de la manada, ");

            salida.AppendLine("edad " + Edad);

            return salida.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return p1.Edad == p2.Edad && p1.Raza == p2.Raza && p1.Nombre == p2.Nombre;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(Object obj)
        {
            return this == (Perro)obj;
        }

        public static explicit operator int(Perro p)
        {
            return p.Edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
