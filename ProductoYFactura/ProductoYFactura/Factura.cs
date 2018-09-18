using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace ProductoYFactura
{

  public enum ETipoFactura
  {
    A,
    B,
    C
  }

  public enum ETipoMoneda
  {
    Pesos,
    Dolar,
    Euro
  }

  class Factura
  {
    private int numero;
    private DateTime fecha;
    ETipoMoneda moneda;
    private List<Producto> productos;
    ETipoFactura tipo;

    public Factura()
    {
      this.productos = new List<Producto>();
    }

    /*
    public double CalcularTotal()
    {
      double total = 0;
      foreach(Producto p in this.productos)
      {
        total += p.Total;
      }
      return total;
    }
    */

    public double Total
    {
      get
      {
        return (this.precio + this.iva) * this.cantidad;
      }
    }

    public int Numero
    {
      get {return this.numero;}
      set {this.numero = value;}
    }

    public DateTime Fecha
    {
      get {return this.fecha;}
      set {this.fecha = value;}
    }

    public ETipoMoneda Moneda
    {
      get {return this.moneda;}
      set {this.moneda = value;}
    }

    public ETipoFactura Tipo
    {
      get { return this.tipo; }
      set { this.tipo = value; }
    }

    public Producto this[int i]
    {
      get
      {
        foreach (Producto p in this.productos)
        {
          if (p.Identificador == i)
            return p;
        }

        return null;
      }

      set
      {
        bool existe = false;

        foreach (Producto item in this.productos)
        {
          if(item.Identificador == i)
          {
            item.Cantidad += value.Cantidad;
            existe = true;
          }
        }

        if (!existe)
          this.productos.Add(value);
      }
    }
  }
}
