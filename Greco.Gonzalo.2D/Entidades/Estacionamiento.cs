using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible)
            : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Nombre: " + e.nombre);
            salida.AppendLine("Espacio disponible: " + e.espacioDisponible);
            foreach (Vehiculo item in e.vehiculos)
            {
                salida.Append(item.ConsultarDatos());
            }

            return salida.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool salida = false;

            foreach (Vehiculo item in e.vehiculos)
            {
                if(item == v)
                {
                    salida = true;
                    break;
                }
            }

            return salida;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v && v.Patente != string.Empty && e.espacioDisponible > e.vehiculos.Count)
                e.vehiculos.Add(v);

            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string salida;

            if (e == v)
            {
                salida = v.ImprimirTicket();
                e.vehiculos.Remove(v);
            }
            else
                salida = "El vehiculo no es parte del estacionamiento";

            return salida;
        }
    }
}
