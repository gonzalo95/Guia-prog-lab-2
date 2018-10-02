using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Abstracta
    {
        public abstract int Metodo1(int a);

        public virtual string Metodo1(int a, int b)
        {
            return "En abstracta";
        }

        public int Metodo1(string a)
        {
            return int.Parse(a);
        }
    }

    public class Hija : Abstracta
    {
        public override int Metodo1(int a)
        {
            return a;
        }
    }

    public override string Metodo1(int a, int b)
    {
        return "En hija";
    }
}
