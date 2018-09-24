using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string destino, string origen)
        {
            this.duracion = duracion;
            this.nroDestino = destino;
            this.nroOrigen = origen;
        }

        public virtual string Mostrar()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("Duracion: {0}\n", Duracion);
            salida.AppendFormat("Destino: {0}\n", NroDestino);
            salida.AppendFormat("Origen: {0}\n", NroOrigen);

            return salida.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            int salida = 0;

            if (l1.Duracion < l2.Duracion)
                salida = -1;

            else if (l1.Duracion > l2.Duracion)
                salida = 1;

                return salida;
        }

    }
}
