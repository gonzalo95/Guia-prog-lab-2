using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaCentimetrosYMetros
{
  class Program
  {
    static void Main(string[] args)
    {
      Sobrecarga obj = new Sobrecarga();
      Console.WriteLine("Metros y metros: {0}", obj.Sumar(10, 10));
      Console.WriteLine("Metros y centimetros: {0}", obj.Sumar((float)10.1, (float)2.14));
      Console.WriteLine("Centimetros y metros: {0}", obj.Sumar((float)14.2, 10));
      Console.WriteLine("Centimetros y centimetros: {0}", obj.Sumar((float)10.5, (float)15.3));

      Console.WriteLine((new Metro(5) + new Centimetro(800)).valor);

      Console.WriteLine((new Metro(25) == new Metro(800)));
      Console.WriteLine((new Metro(25) == new Metro(25)));
      Console.WriteLine((new Metro(25) != new Metro(800)));
      Console.WriteLine((new Metro(25) != new Metro(25)));

      Console.WriteLine((new Centimetro(25) == new Centimetro(800)));
      Console.WriteLine((new Centimetro(800) == new Centimetro(800)));
      Console.WriteLine((new Centimetro(25) != new Centimetro(800)));
      Console.WriteLine((new Centimetro(800) != new Centimetro(800)));

      Console.Read();
    }
  }
}
