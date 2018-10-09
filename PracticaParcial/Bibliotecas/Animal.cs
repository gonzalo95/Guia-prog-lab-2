using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public abstract class Animal
    {
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
        protected int _velocidadMaxima;

        private int DistanciaRecorrida
        {
            get
            {
                return _distanciaRecorrida.Next(10, this._velocidadMaxima);
            }
        }

        public int CantidadPatas
        {
            get
            {
                return this._cantidadPatas;
            }
            set
            {
                if (value <= 4 && value > 0)
                    this._cantidadPatas = value;
                else
                    this._cantidadPatas = 4;
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                if (value > 0 && value <= 60)
                    this._velocidadMaxima = value;
                else
                    this._velocidadMaxima = 60;
            }
        }

        static Animal()
        {
            _distanciaRecorrida = new Random();
        }

        public Animal(int patas, int velocidad)
        {
            this.CantidadPatas = patas;
            this.VelocidadMaxima = velocidad;
        }

        public string MostrarDatos()
        {
            StringBuilder salida = new StringBuilder();

            salida.AppendLine("Patas: " + this.CantidadPatas);
            salida.AppendLine("Velocidad maxima: " + this.VelocidadMaxima);
            salida.AppendLine("Distancia recorrida: " + this.DistanciaRecorrida);

            return salida.ToString();
        }
    }
}
