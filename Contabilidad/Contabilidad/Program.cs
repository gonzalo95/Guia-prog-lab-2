using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Recibo r1 = new Recibo(0);
            Recibo r2 = new Recibo();
            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);

            c += r1;
            c += r2;
            c += f1;
            c += f2;

            Console.WriteLine(c.Egresos);
            Console.WriteLine(c.Ingresos);

            Console.Read();
        }
    }
}
