using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada, short ruedas)
            : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada)
            : this(patente, cilindrada, 2)
        { }

        public Moto(string patente, int cilindrada, short ruedas, int valorPorHora)
            : this(patente, cilindrada, ruedas)
        {
            valorHora = valorPorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine(((Vehiculo)this).ToString());
            salida.AppendLine("Ingreso: " + this.ingreso);
            salida.AppendLine("Ruedas: " + this.ruedas);
            salida.AppendLine("Cilindrada: " + this.cilindrada);
            salida.AppendLine("Valor hora: " + valorHora);

            return salida.ToString();
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
    }
}
