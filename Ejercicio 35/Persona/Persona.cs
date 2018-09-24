using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        long dni;
        string nombre;

        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            Dni = dni;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Dni: {0}\n", Dni);
            sb.AppendFormat("Nombre: {0}\n", Nombre);

            return sb.ToString();
        }
    }
}
