using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
  class Program
  {
    static void Main(string[] args)
    {
      string dibujo = string.Empty;

      Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);

      azul.Pintar(-5, out dibujo);
      Console.ForegroundColor = azul.color;
      Console.WriteLine(dibujo);

      rojo.Pintar(-10, out dibujo);
      Console.ForegroundColor = rojo.color;
      Console.WriteLine(dibujo);

      Console.WriteLine(azul.GetTinta());
      Console.WriteLine(rojo.GetTinta());

      azul.se

      Console.ReadKey();
    }
  }
}
