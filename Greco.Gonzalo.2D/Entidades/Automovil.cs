using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color)
            : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorPorHora)
            : this(patente, color)
        {
            valorHora = valorPorHora;
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ImprimirTicket()
        {
            StringBuilder salida = new StringBuilder();

            salida.Append(base.ImprimirTicket());
            salida.AppendLine("Monto: " + this.ingreso.Hour * valorHora);

            return salida.ToString();
        }

        public override string ConsultarDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine(((Vehiculo)this).ToString());
            salida.AppendLine("Ingreso : " + this.ingreso);
            salida.AppendLine("Color: " + this.color);
            salida.AppendLine("Valor hora: " + valorHora);

            return salida.ToString();
        }
    }
}
