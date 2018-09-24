using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("primero", 1, 1);
            Jugador j2 = new Jugador("segundo", 0, 0);
            Jugador j3 = new Jugador("tercero", 5, 15);
            Jugador j4 = new Jugador("cuarto", 10, 100);
            Jugador j5 = new Jugador("quinto", 0, 5);

            j1.Dni = 1;
            j2.Dni = 2;
            j3.Dni = 3;
            j4.Dni = 1;
            j5.Dni = 5;

            DirectorTecnico dt = new DirectorTecnico("DT");

            dt.Dni = 6;

            Equipo e = new Equipo(4, "equipo", dt);

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
            Console.WriteLine(dt.MostrarDatos());

            Console.Read();
        }
    }

}

