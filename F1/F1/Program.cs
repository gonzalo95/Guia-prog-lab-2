using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Entidades;

namespace F1
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(2, 15);
            AutoF1 a1 = new AutoF1(1, "primero");
            AutoF1 a2 = new AutoF1(2, "segundo");
            AutoF1 a3 = new AutoF1(1, "primero");

            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine(a2.MostrarDatos());
            Console.WriteLine(a3.MostrarDatos());

            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a3);

            bool b1 = c + a1;
            Thread.Sleep(100);
            bool b2 = c + a2;
            Thread.Sleep(100);
            bool b3 = c + a3;

            Console.WriteLine(b1 && b2);
            Console.WriteLine(b3);

            Console.WriteLine(c.MostrarDatos());

            bool b4 = c - a2;
            bool b5 = c - a1;

            Console.WriteLine(c.MostrarDatos());

            Console.Read();
        }
    }
}
