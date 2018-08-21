using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasta;
            List<int> divisores = new List<int>();

            Console.Write("Ingrese un numero: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            while (hasta <= 0)
            {
                Console.WriteLine("Error, reingrese el numero");
                hasta = Convert.ToInt32(Console.ReadLine());
            }
            
            for(int i = 1; i < hasta; i++)
            {
                for(int j = 1; j < hasta; j++)
                {
                    if (i % j == 0)
                        divisores.Add(j);
                }

                if ((divisores.Sum() - i) == i)
                    Console.WriteLine(i);

                divisores.Clear();
            }
            Console.ReadKey();
        }
    }
}
