using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso;

namespace Clase5
{
  class Estante
  {
    private Producto[] productos;

    private int ubicacion;

    public Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacion = ubicacion;
    }

    public Producto[] GetProducto()
    {
      return this.productos;
    }

    public static string MostrarEstante(Estante e)
    {
      string estante = string.Format("Ubicacion: {0}\n", e.ubicacion);
      foreach(Producto p in e.GetProducto())
      {
        if(!(p is null))
        {
          estante += Producto.MostrarProducto(p);
        }
      }
      return estante;
    }

    public static bool operator ==(Estante e, Producto p)
    {
      if (Array.IndexOf(e.GetProducto(), p) != -1)
        return true;
      else
        return false;
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e == p);
    }

    public static bool operator +(Estante e, Producto p)
    {
      if(e != p && e.GetProducto()[Array.IndexOf(e.GetProducto(), e.GetProducto().Last())] is null)
      {
        int index = Array.IndexOf(e.GetProducto(), e.GetProducto().Last());
        e.GetProducto()[index] = p;
        return true;
      }
      else
        return false;
    }

    public static Estante operator -(Estante e, Producto p)
    {
      if(e == p)
      {
        Estante salida = new Estante(e.GetProducto().Rank ,e.ubicacion);
        int i = 0;
        foreach(Producto producto in e.GetProducto())
        {
          if(producto != p)
          {
            e.GetProducto()[i] = producto;
            i++;
          } 
        }
        return salida;
      }
      else
        return e;
    }
  }
}
