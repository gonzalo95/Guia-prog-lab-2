using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        public enum TipoManada
        {
            Unica,
            Mixta
        }

        string nombre;
        static TipoManada tipo;
        List<Mascota> manada;

        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }

        static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nom) : this()
        {
            this.nombre = nom;
        }

        public Grupo(string nombre, TipoManada tipoManada)
            : this(nombre)
        {
            tipo = tipoManada;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool salida = false;

            foreach(Mascota item in g.manada)
            {
                if(m is Perro && (Perro)m == (Perro)item)
                {
                    salida = true;
                    break;
                }
                else if(m is Gato && (Gato)m == (Gato)item)
                {
                    salida = true;
                    break;
                }
            }

            return salida;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static implicit operator string(Grupo g)
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("**{0} {1}**\n", g.nombre, tipo);
            salida.AppendLine("Integrantes:");
            foreach(Mascota m in g.manada)
            {
                salida.Append(m.ToString());
            }

            return salida.ToString();
        }
        
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (g != m)
                g.manada.Add(m);

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
                g.manada.Remove(m);

            return g;
        }
    }
}
