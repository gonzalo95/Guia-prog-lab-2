using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoB = new Torneo<EquipoBasquet>("Torneo de basquet");

            EquipoBasquet basque1 = new EquipoBasquet("Equipo de basquet 1", DateTime.Now);
            EquipoBasquet basque2 = new EquipoBasquet("Equipo de basquet 2", DateTime.Now);
            EquipoBasquet basque3 = new EquipoBasquet("Equipo de basquet 3", DateTime.Now);

            torneoB += basque1;
            torneoB += basque2;
            torneoB += basque3;
            // Reviso que no agrege equipos repetidos
            torneoB += basque3;

            Console.WriteLine(torneoB.Mostrar());

            Torneo<EquipoFutbol> torneoF = new Torneo<EquipoFutbol>("Torneo de futbol");

            EquipoFutbol futbol1 = new EquipoFutbol("Equipo de futbol 1", DateTime.Now);
            EquipoFutbol futbol2 = new EquipoFutbol("Equipo de futbol 2", DateTime.Now);
            EquipoFutbol futbol3 = new EquipoFutbol("Equipo de futbol 3", DateTime.Now);

            torneoF += futbol1;
            torneoF += futbol2;
            torneoF += futbol3;
            // Reviso que no agrege equipos repetidos
            torneoF += futbol3;

            Console.WriteLine(torneoF.Mostrar());

            //// Reviso que no se pueda agregar equipos de otras diciplinas.
            //torneoB += futbol1;
            //torneoF += basque1;

            Console.WriteLine(torneoB.JugarPartido);
            Thread.Sleep(10);
            Console.WriteLine(torneoB.JugarPartido);
            Thread.Sleep(10);
            Console.WriteLine(torneoB.JugarPartido);
            Thread.Sleep(10);

            Console.WriteLine(torneoF.JugarPartido);
            Thread.Sleep(10);
            Console.WriteLine(torneoF.JugarPartido);
            Thread.Sleep(10);
            Console.WriteLine(torneoF.JugarPartido);
            Thread.Sleep(10);

            Console.Read();
        }
    }
}
