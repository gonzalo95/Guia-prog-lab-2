using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        string nombre;
        DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }


        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        // El nombre no es un verbo pero en la guia aparece asi.
        public string Ficha()
        {
            return string.Format("{0} fundado el {1}\n", this.Nombre, this.fechaCreacion.ToShortDateString());
        }
    }
}
