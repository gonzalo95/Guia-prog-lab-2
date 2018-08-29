using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
  class Boligrafo
  {
    public static short cantidadMaximaTinta = 100;

    public ConsoleColor color;

    public short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }

    public void SetTinta(short tinta)
    {
      this.tinta = tinta;
    }

    public short GetTinta()
    {
      return this.tinta;
    }

    // Usar GetTinta()??
    private void SetTinta(short tinta)
    {
      if ((tinta + this.tinta) >= 0 || (tinta + this.tinta) <= Boligrafo.cantidadMaximaTinta)
        this.tinta += tinta;
      else if (tinta < 0)
        this.tinta = 0;
      else
        this.tinta = Boligrafo.cantidadMaximaTinta;
    }

    public void Recargar()
    {
      SetTinta(Boligrafo.cantidadMaximaTinta);
    }

    // Gasto es negativo??
    public bool Pintar(int gasto, out string dibujo)
    {
      bool retorno = false;
      if (gasto <= this.tinta)
      {
        dibujo = new string('*', Math.Abs(gasto));
        retorno = true;
      }

      else
        dibujo = new string('*', this.tinta);

      SetTinta((short)gasto);

      return retorno;
    }
  }
}
