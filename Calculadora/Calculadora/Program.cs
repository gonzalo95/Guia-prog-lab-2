using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float op1;
            float op2;
            char operacion;
            float resultado;
            bool continuar = true;
            while(continuar)
            {
                Console.Write("Ingrese el primer operando: ");
                op1 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo operando: ");
                op2 = float.Parse(Console.ReadLine());
                Console.Write("Ingrese la operacion a realizar: ");
                operacion = char.Parse(Console.ReadLine());
                resultado = Calculadora.Calcular(op1, op2, operacion);
                Calculadora.Mostrar(resultado);
                Console.WriteLine("Continuar? S_N:");
                continuar = char.Parse(Console.ReadLine()) == 's';
      }
        }
    }
}
