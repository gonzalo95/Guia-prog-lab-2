using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        string raza;
        string nombre;

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public Mascota(string nom, string raza)
        {
            this.nombre = nom;
            this.raza = raza;
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            return string.Format("{0} {1}", Nombre, Raza);
        }
    }
}
