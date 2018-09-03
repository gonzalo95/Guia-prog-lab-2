using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(Sobrecarga.Sumar(1, 2) + Sobrecarga.Sumar(1, 2, 3) + Sobrecarga.Sumar(1.1, 2.2));
      Console.Read();
    }
  }
}
