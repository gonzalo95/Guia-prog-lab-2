using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public enum PeriodicidadDePagos
    {
        Mensual,
        Bimestral,
        Trimestral
    }

    public enum TipoDePrestamo
    {
        Pesos,
        Dolares,
        Todos
    }

    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            {
                return this.monto;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                if(value > DateTime.Today)
                    this.vencimiento = value;   
                else
                    this.vencimiento = DateTime.Today;
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            Vencimiento = vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            if (p1.Vencimiento > p2.Vencimiento) return -1;
            if (p1.Vencimiento < p2.Vencimiento) return 1;
            return 0;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Monto: " + Monto);
            sb.AppendLine("Vencimiento: " + Vencimiento);

            return sb.ToString();
        }
    }
}
