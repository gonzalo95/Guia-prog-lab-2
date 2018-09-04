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
    private static float cotizRespectoDolar;

    private Euro()
    {
      cotizRespectoDolar = 1.3642f;
    }

    public Euro(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }

    public Euro(double cantidad, float cotizacion)
    {
      this.cantidad = cantidad;
      cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public static bool operator ==(Euro e1, Euro e2)
    {
      return e1.cantidad == e2.cantidad;
    }

    public static bool operator !=(Euro e1, Euro e2)
    {
      return !(e1.cantidad == e2.cantidad);
    }

    /*
    public static bool operator ==(Euro e, Dolar d)
    {
      return (e.cantidad * cotizRespectoDolar) == d.GetCantidad();
    }

    public static bool operator !=(Euro e, Dolar d)
    {
      return !((e.cantidad * cotizRespectoDolar) == d.GetCantidad());
    }
    */

    public static Euro operator +(Euro e1, Euro e2)
    {
      return new Euro(e1.GetCantidad() + e2.GetCantidad());
    }

    public static Euro operator -(Euro e1, Euro e2)
    {
      return new Euro(e1.GetCantidad() - e2.GetCantidad());
    }

    public static explicit operator Dolar(Euro e)
    {
      return new Dolar(e.cantidad * cotizRespectoDolar);
    }

    public static explicit operator Pesos(Euro e)
    {
      return new Pesos(((Dolar)e).GetCantidad() / Pesos.GetCotizacion());
    }

    /*
    public static implicit operator Euro(Euro e)
    {
      return new Euro(e.cantidad);
    }
    */

  }
  class Dolar
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Dolar()
    {
      cotizRespectoDolar = 1;
    }

    public Dolar(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }

    public Dolar(double cantidad, float cotizacion)
    {
      this.cantidad = cantidad;
      cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public static bool operator ==(Dolar d1, Dolar d2)
    {
      return d1.cantidad == d2.cantidad;
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d1.cantidad == d2.cantidad);
    }

    public static Dolar operator +(Dolar d1, Dolar d2)
    {
      return new Dolar(d1.GetCantidad() + d2.GetCantidad());
    }

    public static Dolar operator -(Dolar d1, Dolar d2)
    {
      return new Dolar(d1.GetCantidad() - d2.GetCantidad());
    }

    public static explicit operator Euro(Dolar d)
    {
      return new Euro();
    }
  }
  class Pesos
  {
    private double cantidad;
    private static float cotizRespectoDolar;

    private Pesos()
    {
      cotizRespectoDolar = 1 / 17.55f;
    }

    public Pesos(double cantidad) : this()
    {
      this.cantidad = cantidad;
    }

    public Pesos(double cantidad, float cotizacion)
    {
      this.cantidad = cantidad;
      cotizRespectoDolar = cotizacion;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }

    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public static bool operator ==(Pesos p1, Pesos p2)
    {
      return p1.cantidad == p2.cantidad;
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1.cantidad == p2.cantidad);
    }

    public static Pesos operator +(Pesos p1, Pesos p2)
    {
      return new Pesos(p1.GetCantidad() + p2.GetCantidad());
    }

    public static Pesos operator -(Pesos p1, Pesos p2)
    {
      return new Pesos(p1.GetCantidad() - p2.GetCantidad());
    }
  }
}
