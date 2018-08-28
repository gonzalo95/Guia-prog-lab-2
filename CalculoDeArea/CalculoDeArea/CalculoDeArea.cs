using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoDeArea
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }

        public static double CalcularTriangulo(double lado, double altura)
        {
            return 0.5 * lado * altura;
        }

        public static double CalcularCirculo(double radio)
        {
            return 3.14 * Math.Pow(radio, 2);
        }
    }
}
