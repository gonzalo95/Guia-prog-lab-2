using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Color
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    };

    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Color color;

        protected VehiculoTerrestre(short ruedas, short puertas, Color color)
        {
            this.cantidadPuertas = puertas;
            this.cantidadRuedas = ruedas;
            this.color = color;
        }

        public short CantidadRuedas
        {
            get
            {
                return this.cantidadRuedas;
            }
        }

        public short CantidadPuertas
        {
            get
            {
                return this.cantidadPuertas;
            }
        }

        public Color Color
        {
            get
            {
                return this.color;
            }
        }
    }
}
