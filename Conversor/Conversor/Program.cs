using System;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            Console.WriteLine(Conversor.BinarioDecimal("0100"));
            Console.WriteLine(Conversor.DecimalBinario(4));
            Console.ReadKey();
        }
    }
}
