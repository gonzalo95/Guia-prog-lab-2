using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadJugador;

namespace EntidadEquipo
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaDeJugadores;
        private string nombre;

        private Equipo()
        {
            this.listaDeJugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
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
