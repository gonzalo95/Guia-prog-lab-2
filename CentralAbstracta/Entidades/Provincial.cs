using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        protected override string Mostrar()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.Mostrar());
            salida.AppendFormat("Franja: {0}\n", this.franjaHoraria);
            salida.AppendFormat("Costo: {0}\n", CostoLlamada);
            salida.AppendLine("-----------");

            return salida.ToString();
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.Duracion * (float)1.99;
                    break;

                case Franja.Franja_2:
                    costo = this.Duracion * (float)2.25;
                    break;

                case Franja.Franja_3:
                    costo = this.Duracion * (float)1.66;
                    break;

                default:
                    break;
            }

            return costo;
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
