using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  class Producto
  {
    protected string codigoDeBarra;

    protected string marca;

    protected float precio;

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    public static string MostrarProducto(Producto p)
    {
      return string.Format("Marca: {0}; Precio: {1}; Codigo: {2}\n",p.GetMarca() , p.GetPrecio(), p.codigoDeBarra);
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      return p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra;
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1 == p2);
    }

    public static bool operator ==(Producto p, string marca)
    {
      return p.GetMarca() == marca;
    }

    public static bool operator !=(Producto p, string marca)
    {
      return !(p.GetMarca() == marca);
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }
  }
}
