using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        short cantidadMarchas;
        int cantidadPasajeros;

        public Automovil(short ruedas, short puertas, Color color, short marchas, int pasajeros)
            : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }

        public short CantidadMarchas
        {
            get
            {
                return this.cantidadMarchas;
            }
        }

        public int CantidadPasajeros
        {
            get
            {
                return this.cantidadPasajeros;
            }
        }
    }
}
