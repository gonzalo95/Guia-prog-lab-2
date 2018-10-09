using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public class Carrera
    {
        private List<Animal> _animales;
        private int corredoresMax;

        private Carrera()
        {
            this._animales = new List<Animal>();
        }

        public Carrera(int corredores) : this()
        {
            this.corredoresMax = corredores;
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            bool salida = false;
            if (!(c is null) && !(a is null))
            {
                foreach (Animal animal in c._animales)
                {
                    //if(a.GetType() == animal.GetType() && a == animal)
                    //{
                    //    salida = true;
                    //    break;
                    //}

                    if (animal is Humano && a is Humano && ((Humano)animal) == (Humano)a)
                    {
                        salida = true;
                        break;
                    }
                    else if (animal is Perro && a is Perro && ((Perro)animal) == (Perro)a)
                    {
                        salida = true;
                        break;
                    }
                    else if (animal is Caballo && a is Caballo && ((Caballo)animal) == (Caballo)a)
                    {
                        salida = true;
                        break;
                    }
                }
            }
            return salida;
        }

        public static bool operator !=(Carrera c, Animal a)
        {
            return !(c == a);
        }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if (c != a && c._animales.Count < c.corredoresMax)
                c._animales.Add(a);

            return c;
        }

        public static string MostrarCarrera(Carrera c)
        {
            StringBuilder salida = new StringBuilder();

            if(!(c is null))
            {
                salida.AppendLine(string.Format("{0} competidores de {1} posibles", c._animales.Count, c.corredoresMax));

                for(int i = 0; i < c._animales.Count; i++)
                {
                    if (c._animales[i] is Humano)
                    {
                        salida.Append(((Humano)c._animales[i]).MostrarHumano());
                    }

                    else if (c._animales[i] is Perro)
                    {
                        salida.Append(((Perro)c._animales[i]).MostrarPerro());
                    }

                    else
                    {
                        salida.Append(((Caballo)c._animales[i]).MostrarCaballo());                 
                    }
                }
            }

            return salida.ToString();
        }
    }
}
