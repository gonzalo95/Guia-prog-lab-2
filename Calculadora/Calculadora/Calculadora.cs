using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        public static float Calcular(float op1, float op2, char opcion)
        {
            float retorno = 0;
            switch (opcion)
            {
                
                case '+':
                    retorno = op1 + op2;
                    break;

                case '-':
                    retorno = op1 - op2;
                    break;

                case '*':
                    retorno = op1 * op2;
                    break;

                case '/':
                    if (Calculadora.Validar(op2))
                        retorno = op1 / op2;
                    else
                        Console.WriteLine("Operando invalido");
                    break;
            }
            return retorno;
        }

        private static bool Validar(float num)
        {
            return num != 0;
        }

        public static void Mostrar(float num)
        {
            Console.WriteLine("Resultado : {0}", num);
        }
    }
}
