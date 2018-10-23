using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancias = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada l in this.listaDeLlamadas)
                    {
                        if (l is Local)
                            ganancias += ((Local)l).CostoLlamada;
                    }
                    break;

                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada l in this.listaDeLlamadas)
                    {
                        if (l is Provincial)
                            ganancias += ((Provincial)l).CostoLlamada;
                    }
                    break;

                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada l in this.listaDeLlamadas)
                    {
                        if (l is Provincial)
                            ganancias += ((Provincial)l).CostoLlamada;
                        else if (l is Local)
                            ganancias += ((Local)l).CostoLlamada;
                    }
                    break;
            }

            return ganancias;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private string Mostrar()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("Empresa: {0}\n", this.razonSocial);
            salida.AppendFormat("Ganancia local: {0}\n", GananciaPorLocal);
            salida.AppendFormat("Ganancia provincial: {0}\n", GananciaPorProvincial);
            salida.AppendFormat("Ganancia total: {0}\n", GananciaTotal);
            salida.AppendLine("Resumen por llamada:\n");
            foreach (Llamada l in this.listaDeLlamadas)
            {
                salida.Append(l.ToString());
            }

            return salida.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool salida = false;

            foreach (Llamada item in c.Llamadas)
            {
                if (item.Equals(l))
                    salida = true;
            }

            return salida;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c == nuevaLlamada)
                throw new CentralitaException("La llamada ya se encontraba cargada", "Centralita", "+");
            else
                c.AgregarLlamada(nuevaLlamada);

            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
