using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(string nombre, int goles, int partidos) : base(nombre)
        {
            TotalGoles = goles;
            PartidosJugados = partidos;
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioDeGol
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Total partidos: {0}\n", this.partidosJugados);
            sb.AppendFormat("promedio de gol: {0}\n", this.PromedioDeGol);
            sb.AppendFormat("Total goles: {0}\n", this.totalGoles);
            sb.AppendLine("-----------------");

            return sb.ToString();
        }

        public static bool operator ==(Jugador e1, Jugador e2)
        {
            return e1.Dni == e2.Dni;
        }

        public static bool operator !=(Jugador e1, Jugador e2)
        {
            return !(e1 == e2);
        }
    }
}
