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


      Console.WriteLine("--- TESTS DE IGUALDAD Y DESIGUALDAD ---");
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

      Console.WriteLine("\n--- TESTS DE CASTEO ---");
      Console.WriteLine(((Dolar)e).GetCantidad());
      Console.WriteLine(((Pesos)e).GetCantidad());

      Console.WriteLine(((Euro)d).GetCantidad());
      Console.WriteLine(((Pesos)d).GetCantidad());

      Console.WriteLine(((Dolar)p).GetCantidad());
      Console.WriteLine(((Euro)p).GetCantidad());

      Console.WriteLine(((Euro)55).GetCantidad());
      Console.WriteLine(((Dolar)65).GetCantidad());
      Console.WriteLine(((Pesos)75).GetCantidad());

      Console.WriteLine("\n--- TESTS DE ADICION Y SUBSTRACCION ---");
      Console.WriteLine((p + p).GetCantidad());
      Console.WriteLine((p + d).GetCantidad());
      Console.WriteLine((p + e).GetCantidad());

      Console.WriteLine((d + d).GetCantidad());
      Console.WriteLine((d + p).GetCantidad());
      Console.WriteLine((d + e).GetCantidad());

      Console.WriteLine((e + e).GetCantidad());
      Console.WriteLine((e + d).GetCantidad());
      Console.WriteLine((e + p).GetCantidad());

      Console.Read();
    }
  }
}
