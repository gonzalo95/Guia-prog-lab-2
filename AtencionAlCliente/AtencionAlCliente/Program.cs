using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes;
using Negocios;
using PuestoDeAtencion;

namespace AtencionAlCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux;
            Cliente c1 = new Cliente(1, "Primero");
            Cliente c2 = new Cliente(2, "Segundo");
            Cliente c3 = new Cliente(3, "Tercero");

            Negocio n = new Negocio("Negocio1");

            aux = n + c1;
            Console.WriteLine(n == c1);
            Console.WriteLine(n == c2);
            Console.WriteLine(n == c3);

            aux = n + c2;
            Console.WriteLine(n == c1);
            Console.WriteLine(n == c2);
            Console.WriteLine(n == c3);

            aux = n + c3;
            Console.WriteLine(n == c1);
            Console.WriteLine(n == c2);
            Console.WriteLine(n == c3);


            Console.WriteLine(n != c1);
            Console.WriteLine(n != c2);
            Console.WriteLine(n != c3);

            Console.WriteLine(n.Cliente == c1);
            Console.WriteLine(n.Cliente == c2);
            Console.WriteLine(n.Cliente == c3);

            Console.WriteLine(n.ClientesPendiente());

            while (n.ClientesPendiente() > 0)
            {
                Console.WriteLine(n.ClientesPendiente());
                aux = ~n;
            }

            Console.Read();
        }
    }
}
