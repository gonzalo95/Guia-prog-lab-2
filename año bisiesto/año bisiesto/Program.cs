using System;

namespace año_bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "EJercicio nº 6";

            int num;
            Console.Write("Ingrese el año: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num <= 0)
            { 
                Console.Write("Error, reingrese el año: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            if (num % 4 == 0 && (num % 100 != 0 || (num % 100 == 0 && num % 400 == 0)))
                Console.Write("El año {0} es bisiesto", num);
            else
                Console.Write("El año {0} NO es bisiesto", num);

            Console.ReadKey();
        }
    }
}
