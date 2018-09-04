using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Program
  {
    static void Main(string[] args)
    {
            Euro e = new Euro(1);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(100);


            Console.WriteLine("---TESTS DE IGUALDAD Y DESIGUALDAD---");
            Console.WriteLine(e != d);
            Console.WriteLine(e == d);

            Console.WriteLine(e != p);
            Console.WriteLine(e == p);

            Console.WriteLine(d != e);
            Console.WriteLine(d == e);

            Console.WriteLine(d != p);
            Console.WriteLine(d == p);

            Console.WriteLine(p != d);
            Console.WriteLine(p == d);

            Console.WriteLine(p != e);
            Console.WriteLine(p == e);

            Console.WriteLine(e == e);
            Console.WriteLine(d == d);
            Console.WriteLine(p == p);

            Console.WriteLine("---TESTS DE IGUALDAD Y DESIGUALDAD CON CASTEO---");

            Console.Read();
    }
  }
}
