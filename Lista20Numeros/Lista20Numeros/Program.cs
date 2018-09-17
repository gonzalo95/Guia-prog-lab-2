using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista20Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = GenerarLista();
            List<int> positivos;
            List<int> negativos;

            Console.WriteLine("Lista generada");
            Mostrar(lista);

            positivos = lista.Where(x => x > 0).ToList();
            positivos.Sort();
            positivos.Reverse();

            Console.WriteLine("\n\nPositivos ordenados de forma descendente");
            Mostrar(positivos);

            negativos = lista.Where(x => x < 0).ToList();
            negativos.Sort();

            Console.WriteLine("\n\nNegativos ordenados de forma ascendente");
            Mostrar(negativos);

            Console.Read();
        }

        static List<int> GenerarLista()
        {
            const int tam = 20;
            List<int> lista = new List<int>();
            Random r = new Random();
            int numero;

            for(int i = 0; i < tam; i++)
            {
                numero = r.Next(-100, 100);

                while(numero == 0)
                {
                    numero = r.Next(-100, 100);
                }

                lista.Add(numero);
            }
            return lista;
        }

        static void Mostrar(List<int> lista)
        {
            for(int i = 0; i < lista.Count; i++)
            {
                Console.Write(lista[i] + " ");
            }
            
        }
    }
}
