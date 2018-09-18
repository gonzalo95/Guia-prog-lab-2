using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoYFactura
{
  class Producto
  {
    private int identificador;
    private string nombre;
    private double precio;
    private double iva;
    private int cantidad;
    private double total;


    public Producto(int id, string nombre, double precio)
    {
      this.identificador = id;
      this.nombre = nombre;
      this.Precio = precio;
      this.cantidad = 1;
    }

    /*
    public double GetPrecio()
    {
      return this.precio;
    }
    */

    public int Cantidad
    {
      get { return cantidad; }
      set { cantidad = value; }
    }

    public int Identificador
    {
      get{return this.identificador;}
      set {this.identificador = value;}
    }

    public string Nombre
    {
      get {return this.nombre;}
      set {this.nombre = value;}
    }

    public double Precio
    {
      set
      {
        this.precio = value;
        this.iva = this.precio * 21 / 100;
      }
    }

    public double Total
    {
      get {return this.precio + this.iva;}
    }
  }
}
