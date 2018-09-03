using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaCentimetrosYMetros
{
  class Centimetro
  {
    public float valor;

    public Centimetro(float valor)
    {
      this.valor = valor;
    }

    public static bool operator ==(Centimetro centimetro1, Centimetro centimetro2)
    {
      return centimetro1.valor == centimetro2.valor;
    }

    public static bool operator !=(Centimetro centimetro1, Centimetro centimetro2)
    {
      return !(centimetro1.valor == centimetro2.valor);
    }
  }
}
