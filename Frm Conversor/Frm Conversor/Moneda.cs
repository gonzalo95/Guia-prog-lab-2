using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Conversor
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
      return e1.GetCantidad() == e2.GetCantidad();
    }

    public static bool operator !=(Euro e1, Euro e2)
    {
      return !(e1.GetCantidad() == e2.GetCantidad());
    }

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
      return new Dolar(e.GetCantidad() * cotizRespectoDolar);
    }

    public static explicit operator Pesos(Euro e)
    {
      Dolar d = (Dolar)e;
      Pesos p = new Pesos(1); // Si no esta intanciado estaria dividiendo por 0.
      return new Pesos(d.GetCantidad() / Pesos.GetCotizacion());
    }

    public static Euro operator +(Euro e, Dolar d)
    {
      return e + (Euro)d;
    }
    public static Euro operator +(Euro e, Pesos p)
    {
      return e + (Euro)p;
    }
    public static Euro operator -(Euro e, Dolar d)
    {
      return e - (Euro)d;
    }
    public static Euro operator -(Euro e, Pesos p)
    {
      return e - (Euro)p;
    }

    public static bool operator ==(Euro e, Dolar d)
    {
      return e == (Euro)d;
    }

    public static bool operator ==(Euro e, Pesos p)
    {
      return e == (Euro)p;
    }

    public static bool operator !=(Euro e, Dolar d)
    {
      return e != (Euro)d;
    }

    public static bool operator !=(Euro e, Pesos p)
    {
      return e != (Euro)p;
    }

    public static implicit operator Euro(Double d)
    {
      return new Euro(d);
    }

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
      return d1.GetCantidad() == d2.GetCantidad();
    }

    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return !(d1.GetCantidad() == d2.GetCantidad());
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
      Euro e = new Euro(1);
      return new Euro(d.GetCantidad() / Euro.GetCotizacion());
    }

    public static explicit operator Pesos(Dolar d)
    {
      Pesos p = new Pesos(1);
      return new Pesos(d.GetCantidad() / Pesos.GetCotizacion());
    }
    public static Dolar operator +(Dolar d, Euro e)
    {
      return d + (Dolar)e;
    }
    public static Dolar operator +(Dolar d, Pesos p)
    {
      return d + (Dolar)p;
    }
    public static Dolar operator -(Dolar d, Euro e)
    {
      return d - (Dolar)e;
    }
    public static Dolar operator -(Dolar d, Pesos p)
    {
      return d - (Dolar)p;
    }

    public static bool operator ==(Dolar d, Euro e)
    {
      return d == (Dolar)e;
    }

    public static bool operator ==(Dolar d, Pesos p)
    {
      return d == (Dolar)p;
    }

    public static bool operator !=(Dolar d, Euro e)
    {
      return d != (Dolar)e;
    }

    public static bool operator !=(Dolar d, Pesos p)
    {
      return d != (Dolar)p;
    }

    public static implicit operator Dolar(Double d)
    {
      return new Dolar(d);
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
      return p1.GetCantidad() == p2.GetCantidad();
    }

    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return !(p1.GetCantidad() == p2.GetCantidad());
    }

    public static Pesos operator +(Pesos p1, Pesos p2)
    {
      return new Pesos(p1.GetCantidad() + p2.GetCantidad());
    }

    public static Pesos operator -(Pesos p1, Pesos p2)
    {
      return new Pesos(p1.GetCantidad() - p2.GetCantidad());
    }

    public static explicit operator Euro(Pesos p)
    {
      Euro e = new Euro(1);
      return new Euro(p.GetCantidad() * cotizRespectoDolar / Euro.GetCotizacion());
    }

    public static explicit operator Dolar(Pesos p)
    {
      return new Dolar(p.GetCantidad() * cotizRespectoDolar);
    }

    public static Pesos operator +(Pesos p, Dolar d)
    {
      return p + (Pesos)d;
    }

    public static Pesos operator +(Pesos p, Euro e)
    {
      return p + (Pesos)e;
    }

    public static Pesos operator -(Pesos p, Dolar d)
    {
      return p - (Pesos)d;
    }

    public static Pesos operator -(Pesos p, Euro e)
    {
      return p - (Pesos)e;
    }

    public static bool operator ==(Pesos p, Euro e)
    {
      return p == (Pesos)e;
    }

    public static bool operator ==(Pesos p, Dolar d)
    {
      return p == (Pesos)d;
    }

    public static bool operator !=(Pesos p, Euro e)
    {
      return p != (Pesos)e;
    }

    public static bool operator !=(Pesos p, Dolar d)
    {
      return p != (Pesos)d;
    }

    public static implicit operator Pesos(Double d)
    {
      return new Pesos(d);
    }
  }
}
