using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -= (float)0.1 * texto.Length;
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Lapiz");
            salida.AppendLine("Color gris");
            salida.AppendLine("Tamaño mina: " + this.tamanioMina);

            return salida.ToString();
        }
    }
}
