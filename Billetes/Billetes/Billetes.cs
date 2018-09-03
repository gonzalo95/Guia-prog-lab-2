using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
  class Euro
  {
    private double cantidad;
    private float cotizRespectoDolar;

    private Euro() { }

    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Euro(double cantidad, float cotizRespectoDolar) : this(cantidad)
    {
      this.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public float GetCotizacion()
    {
      return this.cotizRespectoDolar;
    }

  }
  class Dolar
  {
    private double cantidad;
    private float cotizRespectoDolar;

    private Dolar() { }

    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Dolar(double cantidad, float cotizRespectoDolar) : this(cantidad)
    {
      this.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public float GetCotizacion()
    {
      return this.cotizRespectoDolar;
    }
  }
  class Pesos
  {
    private double cantidad;
    private float cotizRespectoDolar;

    private Pesos() { }

    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Pesos(double cantidad, float cotizRespectoDolar) : this(cantidad)
    {
      this.cotizRespectoDolar = cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public float GetCotizacion()
    {
      return this.cotizRespectoDolar;
    }
  }
}
