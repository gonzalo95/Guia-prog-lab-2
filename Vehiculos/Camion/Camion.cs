using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        short cantidadMarchas;
        int pesoCarga;

        public Camion(short ruedas, short puertas, Color color, short marchas, int peso)
            : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = peso;
        }

        public short CantidadMarchas
        {
            get
            {
                return this.cantidadMarchas;
            }
        }

        public int PesoCarga
        {
            get
            {
                return this.pesoCarga;
            }
        }
    }
}
