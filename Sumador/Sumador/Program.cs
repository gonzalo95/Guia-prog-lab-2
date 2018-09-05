using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
  class Program
  {
    static void Main(string[] args)
    {
      Sumador sum = new Sumador();
      Sumador sum2 = new Sumador(33);

      Console.WriteLine((int)sum);
      Console.WriteLine(sum.Sumar(5, 3));
      Console.WriteLine(sum.Sumar(0, 0));
      Console.WriteLine(sum.Sumar(5, -2));
      Console.WriteLine(sum.Sumar(-4, -4));
      Console.WriteLine(sum.Sumar("", ""));
      Console.WriteLine(sum.Sumar("hola", "mundo"));
      Console.WriteLine((int)sum);
      Console.WriteLine(sum + sum2);
      Console.WriteLine(sum | sum2);
      Console.WriteLine(sum | sum);

      Console.Read();
    }
  }
}
