using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaCentimetrosYMetros
{
  class Sobrecarga
  {
    public string tipoNumero;

    public Sobrecarga() : this("Metro") { }

    public Sobrecarga(string tipo)
    {
      tipoNumero = tipo;
    }

    public  int Sumar(int metros1, int metros2)
    {
      if (tipoNumero == "Metro")
        return metros1 + metros2;

      else
        return (metros1 + metros2) * 100;
    }
    
    public float Sumar(int metros, float centimetros)
    {
      return (float)metros + (centimetros / 100);
    }

    public float Sumar(float centimetros, int metros)
    {
      return (float)metros + (centimetros / 100);
    }

    public float Sumar(float centimetros1, float centimetros2)
    {
      return centimetros1 + centimetros2;
    }
  }
}
