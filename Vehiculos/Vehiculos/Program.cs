using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Camion c = new Camion(18, 2, Color.Rojo, 5, 1500);
            Automovil a = new Automovil(4, 4, Color.Negro, 5, 5);
            Moto m = new Moto(2, 0, Color.Blanco, 150);

            Console.WriteLine("Camion: " + c.CantidadRuedas.ToString() + c.CantidadPuertas.ToString() + c.Color.ToString() + c.CantidadMarchas.ToString() + c.PesoCarga.ToString());
            Console.WriteLine("Auto: " + a.CantidadRuedas.ToString() + a.CantidadPuertas.ToString() + a.Color.ToString() + a.CantidadPasajeros.ToString() + a.CantidadMarchas.ToString());
            Console.WriteLine("Moto: " + m.CantidadRuedas.ToString() + m.CantidadPuertas.ToString() + m.Color.ToString() + m.Cilindrada.ToString());

            Console.Read();
        }
    }
}
