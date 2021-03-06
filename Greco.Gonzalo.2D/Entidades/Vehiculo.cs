﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length == 6)
                    this.patente = value;
                else
                    this.patente = string.Empty;
            }
        }

        public Vehiculo(string patente)
        {
            this.Patente = patente;
            this.ingreso = DateTime.Now.AddHours(-3);
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("Patente {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine(this.ToString());
            salida.AppendLine(this.ingreso.ToString());

            return salida.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.Patente == v2.Patente && v1.Equals(v2);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
