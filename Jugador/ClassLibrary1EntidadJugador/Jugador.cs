using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadJugador
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(long dni, string nombre) :this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(long dni, string nombre, int goles, int partidos) : this(dni, nombre)
        {
            this.totalGoles = goles;
            this.partidosJugados = partidos;
        }

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

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioDeGol
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Dni: {0}\n", this.dni);
            sb.AppendFormat("Total partidos: {0}\n", this.partidosJugados);
            sb.AppendFormat("promedio de gol: {0}\n", this.PromedioDeGol);
            sb.AppendFormat("Total goles: {0}\n", this.totalGoles);
            sb.AppendLine("-----------------");

            return sb.ToString();
        }

        public static bool operator ==(Jugador e1, Jugador e2)
        {
            return e1.dni == e2.dni;
        }

        public static bool operator !=(Jugador e1, Jugador e2)
        {
            return !(e1 == e2);
        }
    }
}
