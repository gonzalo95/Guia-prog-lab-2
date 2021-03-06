﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.Color = color;
            this.UnidadesDeEscritura = unidades;
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Boligrafo");
            salida.AppendLine("Color: " + this.Color);
            salida.AppendLine("Tinta: " + this.UnidadesDeEscritura);

            return salida.ToString();
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= (float)0.3 * texto.Length;
            return new EscrituraWrapper(texto,this.Color);
        }
    }
}
