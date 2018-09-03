using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaCentimetrosYMetros
{
  class Metro
  {
    public int valor;

    public Metro(int valor)
    {
      this.valor = valor;
    }

    public static Metro operator +(Metro metro, Centimetro centimetro)
    {
      metro.valor += (int)centimetro.valor / 100;
      return metro;
    }

    public static bool operator ==(Metro metro1, Metro metro2)
    {
      return metro1.valor == metro2.valor;
    }

    public static bool operator !=(Metro metro1, Metro metro2)
    {
      return !(metro1.valor == metro2.valor);
    }
  }
}
