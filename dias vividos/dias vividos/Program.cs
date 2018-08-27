using System;
using System.Collections.Generic;
using System.Linq;

namespace dias_vividos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio 7";

            DateTime fechaDeNacimiento;
            TimeSpan dias;
            Console.Write("Ingrese su fecha de nacimiento(dd/mm/aaaa): ");
            if(DateTime.TryParse(Console.ReadLine(), out fechaDeNacimiento))
            {
                dias = DateTime.Today - fechaDeNacimiento;
            }
            Console.WriteLine("Dias vividos: {0:dd}", dias);

            Console.ReadKey();
        }
    }
}
