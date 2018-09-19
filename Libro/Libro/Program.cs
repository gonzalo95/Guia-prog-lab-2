using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaLibro;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro l = new Libro();

            l[0] = "Hola";
            l[1] = "";
            l[2] = "mundo";
            l[3] = "!!!!";
            l[4] = ".";

            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
            Console.WriteLine(l[2]);
            Console.WriteLine(l[3]);
            Console.WriteLine(l[4]);

            Console.WriteLine(l[5]);
            Console.WriteLine(l[-1]);

            Console.WriteLine(l[4]);
            Console.WriteLine(l[3]);
            Console.WriteLine(l[2]);
            Console.WriteLine(l[1]);
            Console.WriteLine(l[0]);

            Console.WriteLine(l[5]);
            Console.WriteLine(l[-1]);

            l[0] = "Adios";
            l[1] = "";
            l[2] = "c#";
            l[3] = "";
            l[4] = ".";

            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
            Console.WriteLine(l[2]);
            Console.WriteLine(l[3]);
            Console.WriteLine(l[4]);

            Console.Read();
        }
    }
}
