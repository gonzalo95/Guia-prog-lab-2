using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PrestamoPesos(float monto, DateTime vencimiento, float interes)
            : base(monto, vencimiento)
        {
            this.porcentajeInteres = interes;
        }

        public PrestamoPesos(Prestamo prestamo, float interes)
            : this(prestamo.Monto, prestamo.Vencimiento, interes)
        {}

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia = nuevoVencimiento - this.Vencimiento;
            int dias = diferencia.Days;

            for(int i = 0; i < dias; i++)
            {
                this.porcentajeInteres += 0.25f;
            }

            this.Vencimiento = nuevoVencimiento;
        }

        private float CalcularInteres()
        {
            return this.Monto + ((this.Monto * this.porcentajeInteres) / 100);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Interes: " + Interes);
            sb.AppendLine("--------");

            return sb.ToString();
        }
    }
}
