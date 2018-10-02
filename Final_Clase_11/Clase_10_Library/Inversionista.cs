using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Library
{
    public class Inversionista : Persona
    {
        private int _porcionAccionaria;

        public Inversionista(string nombre, string apellido, int porcion) : base(nombre, apellido)
        {
            PorcionAccionaria = porcion;
        }

        public int PorcionAccionaria
        {
            set
            {
                if (value <= 100 && value > 0) this._porcionAccionaria = value;
            }
            get
            {
                return this._porcionAccionaria;
            }
        }

        public override string PosicionSocietaria()
        {
            return "Accionista con el " + this.PorcionAccionaria + "% de la porción accionaria";
        }

        public static bool operator ==(Inversionista i1, Inversionista i2)
        {
            return i1.Apellido == i2.Apellido && i1.Nombre == i2.Nombre && i1.PorcionAccionaria == i2.PorcionAccionaria;
        }

        public static bool operator !=(Inversionista i1, Inversionista i2)
        {
            return !(i1 == i2);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + base.Nombre);
            sb.AppendLine("Apellido: " + base.Apellido);
            sb.AppendLine("Procion societaria: " + this.PorcionAccionaria);
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
