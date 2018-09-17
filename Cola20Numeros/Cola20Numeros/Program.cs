using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola20Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola = GenerarCola();
            Queue<int> positivos = new Queue<int>();
            Queue<int> negativos = new Queue<int>();

            Console.WriteLine("Cola generada");
            Mostar(cola);

            Filtrar(cola, positivos, negativos);

            Console.WriteLine("\n\nPositivos ordenados de forma descendente");
            Mostar(positivos);

            Console.WriteLine("\n\nNegativos ordenados de forma ascendente");
            Mostar(negativos);

            Console.Read();
        }

        static Queue<int> GenerarCola()
        {
            Queue<int> cola = new Queue<int>();
            Random r = new Random();
            int numero;
            const int tam = 20;

            for(int i = 0; i < tam; i++)
            {
                numero = r.Next(-100, 100);

                while (numero == 0)
                {
                    numero = r.Next(-100, 100);
                }

                cola.Enqueue(numero);
            }
            return cola;
        }

        static void Mostar(Queue<int> cola)
        {
            while(cola.Count > 0)
            {
                Console.Write(cola.Dequeue() + " ");
            }
        }

        static void Filtrar(Queue<int> cola, Queue<int> positivos, Queue<int> negativos)
        {
            int num;
            while (cola.Count > 0)
            {
                num = cola.Dequeue();

                if (num > 0)
                    positivos.Enqueue(num);
                else
                    negativos.Enqueue(num);
            }
        }
    }
}
