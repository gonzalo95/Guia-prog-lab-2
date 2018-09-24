using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;

        public Moto(short ruedas, short puertas, Color color, short cilindrada)
            : base (ruedas, puertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
        }
    }
}
