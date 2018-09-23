using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadEquipo;
using EntidadJugador;

namespace EncapsulamientoJugadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(1, "primero");
            Jugador j2 = new Jugador(2, "segundo");
            Jugador j3 = new Jugador(3, "tercero");
            Jugador j4 = new Jugador(1, "cuarto", 10, 100);
            Jugador j5 = new Jugador(5, "quinto");

            Equipo e = new Equipo(4, "equipo");

            bool b1 = e + j1;
            bool b2 = e + j2;
            bool b3 = e + j3;
            bool b4 = e + j4;
            bool b5 = e + j5;

            Console.WriteLine(b1 && b2 && b3 && b4); // True.
            Console.WriteLine(b5); // False.
            Console.WriteLine(j1 == j4); // True.
            Console.WriteLine(j1 == j2); // False.

            Console.WriteLine(j4.PromedioDeGol);
            Console.WriteLine(j4.MostrarDatos());

            Console.Read();
        }

    }
}
