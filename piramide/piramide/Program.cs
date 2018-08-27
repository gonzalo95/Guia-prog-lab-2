using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int piso;
            string bloque = "*";
            Console.Write("Pisos: ");
            piso = int.Parse(Console.ReadLine());
            while (piso < 1)
            {
                Console.Write("Error, reingrese el dato: ");
                piso = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < piso; i++)
            {
                Console.WriteLine(bloque);
                bloque += "**";
            }
            Console.ReadKey();
        }
    }
}
