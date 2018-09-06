using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversor;

namespace ConversorSobrecarga
{
  class Program
  {
    static void Main(string[] args)
    {
            NumeroBinario b = new NumeroBinario("100");
            NumeroDecimal d = new NumeroDecimal(4);

            Console.WriteLine("--- OPERADORES ---");
            Console.WriteLine(b.num);
            Console.WriteLine(d.num);

            Console.WriteLine("--- TESTS DE COMPARACION ---");
            Console.WriteLine("0100" == (string)b);
            Console.WriteLine(4 == (double)d);
            Console.WriteLine(b == d);
            Console.WriteLine(b != d);

            Console.WriteLine("--- TESTS DE ADICION Y SUBSTRACCION ---");
            Console.WriteLine(b + d);
            Console.WriteLine(b - d);
            Console.WriteLine(d + b);
            Console.WriteLine(d - b);
            NumeroDecimal d2 = 2;
            Console.WriteLine(b - d2);
            NumeroBinario b2 = "1001";
            Console.WriteLine(d + b2);

            Console.Read();
        }
  }
}
