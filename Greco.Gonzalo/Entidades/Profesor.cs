using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Profesor : Persona
    {
        DateTime fechaIngreso;

        public int Antiguedad
        {
            get
            {
                return (int)(DateTime.Today - this.fechaIngreso).TotalDays;
            }
        }

        public Profesor(string nombre, string apellido, string documento)
            :base(nombre, apellido, documento)
        { }

        public Profesor(string nombre, string apellido, string documento, DateTime ingreso)
            : this(nombre, apellido, documento)
        {
            this.fechaIngreso = ingreso;
        }

        public override string ExponerDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.ExponerDatos());
            salida.AppendFormat("Fecha de ingreso: {0}\n", this.fechaIngreso);
            salida.AppendFormat("Antiguedad: {0}\n", Antiguedad);
            salida.AppendLine("----------");

            return salida.ToString();
        }

        protected override bool ValidarDocumentacion(string documentacion)
        {
            return Regex.IsMatch(documentacion, "[0-9]{8}") ? true : false;
        }
    }
}
