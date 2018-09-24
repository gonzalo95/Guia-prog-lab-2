using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaDeJugadores;
        private string nombre;
        private DirectorTecnico directorTecnico;

        private Equipo()
        {
            this.listaDeJugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public Equipo(short cantidad, string nombre, DirectorTecnico dt) : this(cantidad, nombre)
        {
            this.directorTecnico = dt;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool salida = false;

            if (e.listaDeJugadores.Count < e.cantidadDeJugadores && !(e.listaDeJugadores.Contains(j)))
            {
                e.listaDeJugadores.Add(j);
                salida = true;
            }

            return salida;
        }
    }
}
