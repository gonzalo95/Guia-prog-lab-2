using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            int nivel;
            string bloque = "*";
            string espacio = string.Empty;
            
            Console.Write("Niveles: ");
            nivel = int.Parse(Console.ReadLine());
            while (nivel < 1)
            {
                Console.Write("Error, reingrese el dato: ");
                nivel = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nivel; i++)
            {
                espacio = new string(' ', nivel - i);
                Console.WriteLine(espacio + bloque);
                bloque += "**";
            }
            Console.ReadKey();
        }
    }
}
