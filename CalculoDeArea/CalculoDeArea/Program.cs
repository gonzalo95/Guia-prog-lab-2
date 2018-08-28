using System;

namespace CalculoDeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            Console.WriteLine(CalculoDeArea.CalcularCuadrado(4));
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(5, 3));
            Console.WriteLine(CalculoDeArea.CalcularCirculo(10));

            Console.ReadKey();
        }
    }
}
