using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int[] num = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write("\nIngrese un num: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            sum = num.Sum();

            Console.WriteLine("Max: {0}", num.Max());
            Console.WriteLine("Min: {0}", num.Min());
            Console.WriteLine("Prom: {0}", (float)sum/num.Length);

            Console.ReadKey();
        }
    }
}
