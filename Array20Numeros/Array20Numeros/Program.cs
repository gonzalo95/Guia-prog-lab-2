using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array20Numeros
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] array = GenerarArray();

      Console.WriteLine("Array original");
      ImprimirArray(array);

      Ordenar(array);

      Console.WriteLine("\nArray ordenado ascendentemente");
      ImprimirArray(array);

      Console.WriteLine("\nArray ordenado Descendentemente (?");

      Console.Read();
    }

    static int[] GenerarArray()
    {
      int[] array = new int[20];
      Random r = new Random();
      int num;

      for (int i = 0; i < 20; i++)
      {
        num = r.Next(-100, 100);
        if (num != 0)
          array[i] = num;
      }
      return array;
    }

    static void ImprimirArray(int[] array)
    {
      foreach (int n in array)
      {
        Console.Write(n + " ");
      }
      Console.Write("\n");
    }

    static void Ordenar(int[] array)
    {
      int aux;

      for(int i = 0; i < array.Count() - 1; i++)
      {
        for(int j = i + 1; j < array.Count(); j++)
        {
          if(array[j] < array[i])
          {
            aux = array[i];
            array[i] = array[j];
            array[j] = aux;
          }
        }
      }
    }
  }
}
