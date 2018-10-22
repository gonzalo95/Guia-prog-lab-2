using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo)
            : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorPorHora)
            : this(patente, modelo)
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
            salida.AppendLine("Ingreso: " + this.ingreso);
            salida.AppendLine("Modelo: " + this.modelo);
            salida.AppendLine("Valor hora: " + valorHora);

            return salida.ToString();
        }
    }
}
