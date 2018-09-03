using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4
{
  class Sobrecarga
  {
    // Con 2 operandos enteros.
    public static int Sumar(int op1, int op2)
    {
      return op1 + op2;
    }

    // Con 3 operandos enteros.
    public static int Sumar(int op1, int op2, int op3)
    {
      return op1 + op2 + op3;
    }

    // Con 2 operandos decimales.
    public static double Sumar(double op1, double op2)
    {
      return op1 + op2;
    }
  }
}
