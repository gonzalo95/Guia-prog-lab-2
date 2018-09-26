using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Alumno : Persona
    {
        short anio;
        Divisiones division;

        public string AnioDivision
        {
            get
            {
                return this.anio.ToString() + this.division;
            }
        }

        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division)
            : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.ExponerDatos());
            salida.AppendFormat("Año: {0}\n", this.anio);
            salida.AppendFormat("Division: {0}\n", this.division);
            salida.AppendLine("----------");

            return salida.ToString();
        }

        protected override bool ValidarDocumentacion(string documentacion)
        {
            return Regex.IsMatch(documentacion, "[0-9]{2}-[0-9]{4}-[0-9]{1}") ? true : false;
        }
    }
}
