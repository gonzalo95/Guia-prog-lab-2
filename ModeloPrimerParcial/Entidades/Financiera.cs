using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public string RazonSocial
        {
            get
            {
                return this.razonSocial;
            }
        }

        public float InteresesEnDolares
        {
            get
            {

                return CalcularInteresGanado(TipoDePrestamo.Dolares);
            }
        }

        public float InteresesEnPesos
        {
            get
            {

                return CalcularInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {

                return CalcularInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            {
                return this.listaDePrestamos;
            }
        }

        private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float total = 0;

            foreach(Prestamo p in this.listaDePrestamos)
            {
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Dolares:
                        if(p is PrestamoDolar)
                            total += ((PrestamoDolar)p).Interes;
                        break;

                    case TipoDePrestamo.Pesos:
                        if (p is PrestamoPesos)
                            total += ((PrestamoPesos)p).Interes;
                        break;

                    case TipoDePrestamo.Todos:
                        if (p is PrestamoDolar)
                            total += ((PrestamoDolar)p).Interes;

                        else if (p is PrestamoPesos)
                            total += ((PrestamoPesos)p).Interes;
                        break;
                }
            }

            return total;
        }

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial) :this()
        {
            this.razonSocial = razonSocial;
        }

        public static string Mostrar(Financiera f)
        {
            return (string)f;
        }

        public static explicit operator string(Financiera f)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + f.RazonSocial);
            sb.AppendLine("Intereses totales: " + f.InteresesTotales);
            sb.AppendLine("Intereses en pesos: " + f.InteresesEnPesos);
            sb.AppendLine("Intereses en dolares: " + f.InteresesEnDolares);

            f.OrdenarPrestamos();

            foreach(Prestamo p in f.ListaDePrestamos)
            {
                sb.AppendLine(p.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }

        public static Financiera operator +(Financiera f, Prestamo p)
        {
            if(f != null && p != null)
                if(!(f == p))
                    f.ListaDePrestamos.Add(p);

            return f;
        }

        public static bool operator ==(Financiera f, Prestamo p)
        {
            return f.ListaDePrestamos.Contains(p);
        }

        public static bool operator !=(Financiera f, Prestamo p)
        {
            return !(f == p);
        }
    }
}
