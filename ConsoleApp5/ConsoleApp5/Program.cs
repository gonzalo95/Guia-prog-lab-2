using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sumIzq = 0;
            int sumDer = 0;
            List<int> rango = new List<int>();
            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num <= 1)
            {
              Console.Write("Error, reingrese en numero: ");
              num = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 1; i <= num; i++)
            {
              rango.Add(i);
            }

            for (int i = 1; i < rango.Count-1; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    sumIzq += rango[j];
                }
                for (int k = rango.Count-1; k > i; k--)
                {
                  sumDer += rango[k];
                }

                if (sumDer == sumIzq)
                  Console.WriteLine(i + 1);

                sumDer = 0;
                sumIzq = 0;
            }
            Console.ReadKey();     
        }
    }
}
