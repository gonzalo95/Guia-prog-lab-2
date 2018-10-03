using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public float Interes
        {
            get
            {
                return CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
            : base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
            : this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        {}

        private float CalcularInteres()
        {
            float salida = 0;

            switch (Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    salida = this.Monto * 1.25f;
                    break;

                case PeriodicidadDePagos.Bimestral:
                    salida = this.Monto * 1.35f;
                    break;

                case PeriodicidadDePagos.Trimestral:
                    salida = this.Monto * 1.40f;
                    break;
            }

            return salida;
        }

        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            TimeSpan diferencia = nuevoVencimiento - this.Vencimiento;
            int dias = diferencia.Days;

            for (int i = 0; i < dias; i++)
            {
                this.monto += 2.5f;
            }

            this.Vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("Periodicidad: " + this.periodicidad);
            sb.AppendLine("Interes: " + Interes);
            sb.AppendLine("--------");

            return sb.ToString();
        }
    }
}
