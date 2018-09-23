using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short competidores, short vueltas) :this()
        {
            this.cantidadCompetidores = competidores;
            this.cantidadVueltas = vueltas;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool salida = false;

            if (c.competidores.Contains(a))
                salida = true;

            return salida;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        private void Agregar(AutoF1 a)
        {
            Random r = new Random();

            a.CantidadCombustible = (short)r.Next(15, 100);
            a.EnCompetencia = true;
            a.VueltasRestantes = this.cantidadVueltas;
            this.competidores.Add(a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool salida = false;

            if(c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.Agregar(a);
                salida = true;
            }

            return salida;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool salida = false;

            if (c == a)
            {
                c.competidores.Remove(a);
                salida = true;
            }

            return salida;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Cantidad de competidores: {0}\n", this.cantidadCompetidores);
            sb.AppendFormat("Cantidad de vueltas: {0}\n", this.cantidadVueltas);
            sb.AppendLine("Competidores:");

            foreach(AutoF1 competidor in this.competidores)
            {
                sb.AppendLine(competidor.MostrarDatos());
            }

            return sb.ToString();
        }
    }
}
