 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Documento
    {
        private int numero;

        public Documento(int num)
        {
            this.numero = num;
        }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType() && this.numero == ((Documento)obj).numero;
        }
    }
}
