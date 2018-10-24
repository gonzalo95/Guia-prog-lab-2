using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        List<T> equipos;
        string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                if (this.equipos.Count < 2) return "No hay equipos suficientes\n";

                Random r = new Random();
                int e1 = r.Next(0, this.equipos.Count);
                int e2 = r.Next(0, this.equipos.Count);

                while (e1 == e2)
                {
                    e2 = r.Next(0, this.equipos.Count);
                }

                return CalcularPartido(this.equipos[e1], this.equipos[e2]);
            }
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            bool salida = false;

            foreach (T e in torneo.equipos)
            {
                if (e == equipo)
                {
                    salida = true;
                    break;
                }
            }

            return salida;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Torneo: " + this.nombre);
            salida.AppendLine("Participantes: ");
            foreach (Equipo e in this.equipos)
            {
                salida.Append(e.Ficha());
            }

            return salida.ToString();
        }

        private static string CalcularPartido(T e1, T e2)
        {
            Random r = new Random();
            int min = 0;
            int max = (e1 is EquipoBasquet) ? 100 : 6;

            return string.Format("{0} {1} - {2} {3}", e1.Nombre, r.Next(min, max), e2.Nombre, r.Next(min, max));
        }
    }
}