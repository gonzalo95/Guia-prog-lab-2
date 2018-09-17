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
      int[] positivos;
      int[] negativos;

      Console.WriteLine("Array original");
      ImprimirArray(array);

      positivos = array.Where(x => x > 0).ToArray();
      Ordenar(positivos, -1);

      Console.WriteLine("\nPositivos ordenados de forma descendente");
      ImprimirArray(positivos);


      negativos = array.Where(x => x < 0).ToArray();
      Ordenar(negativos, 1);

      Console.WriteLine("\nNegativos ordenados de forma ascendente");
      ImprimirArray(negativos);

      Console.Read();
    }

    static int[] GenerarArray()
    {
      const int tam = 20; 
      int[] array = new int[tam];
      Random r = new Random();
      int num;

      for (int i = 0; i < tam; i++)
      {
        num = r.Next(-100, 100);
        while(num == 0)
        {
          num = r.Next(-100, 100);
        }
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
    static void Ordenar(int[] array, int orden)
    {
      int aux;

      if (orden == 1)
      {
          for (int i = 0; i < array.Count() - 1; i++)
          {
              for (int j = i + 1; j < array.Count(); j++)
              {
                  if (array[j] < array[i])
                  {
                      aux = array[i];
                      array[i] = array[j];
                      array[j] = aux;
                  }
              }
          }
      }
      else
      {
          for (int i = 0; i < array.Count() - 1; i++)
          {
              for (int j = i + 1; j < array.Count(); j++)
              {
                  if (array[j] > array[i])
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
}
