using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        List<Alumno> alumnos;
        short anio;
        Divisiones division;
        Profesor profesor;

        public string AnioDivision
        {
            get
            {
                return this.anio.ToString() + this.division;
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor)
            : this()
        {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendFormat("Año: {0}\n", c.anio);
            salida.AppendFormat("Division: {0}\n", c.division);
            salida.Append(c.profesor.ExponerDatos());
            foreach(Alumno a in c.alumnos)
            {
                if(a != null)
                    salida.Append(a.ExponerDatos());
            }

            return salida.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            if (c is null || a is null)
                return false;
            else
                return c.AnioDivision == a.AnioDivision;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if (c == a && !c.alumnos.Contains(a))
                c.alumnos.Add(a);

            return c;
        }
    }
}
