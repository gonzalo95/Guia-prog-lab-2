using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasta;
            Console.Write("Ingrese un numero: ");
            hasta = Convert.ToInt32(Console.ReadLine());

            while(hasta <= 0)
            {
                Console.WriteLine("Error, reingrese el numero");
                hasta = Convert.ToInt32(Console.ReadLine());
            }

            if (hasta == 1)
                Console.WriteLine(hasta);

            for (int i = 1; i < hasta; i++)
            {
                if(esPrimo(i) == true)
                    Console.WriteLine("{0}", i);
            }
            Console.ReadKey();
            
            bool esPrimo(int n)
            {
                bool output = true;
                if(n != 1)
                {
                    for(int i = 2; i < n; i++)
                    {
                        if(n % i == 0)
                        {
                            output = false;
                            break;
                        }
                    }
                }
                
                return output;
            }
        }
    }
}
