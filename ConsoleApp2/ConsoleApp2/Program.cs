using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num <= 0)
            {
                Console.WriteLine("Error, reingrese el numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Cuadrado: {0}", Math.Pow(num, 2));
            Console.WriteLine("Cubo: {0}", Math.Pow(num, 3));

            Console.ReadKey();
        }
    }
}
