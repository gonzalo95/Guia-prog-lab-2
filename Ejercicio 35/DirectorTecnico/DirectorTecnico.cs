using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                this.fechaNacimiento = value;
            }
        }

        public DirectorTecnico(string nombre) : base(nombre)
        { 
        }

        public DirectorTecnico(string nombre, DateTime fecha) : this(nombre)
        {
            FechaNacimiento = fecha;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Fecha de nacimiento: {0}\n", FechaNacimiento);
            sb.AppendLine("---------");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni == dt2.Dni;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
