using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
  class Alumno
  {
    public string apellido;

    public string nombre;

    public int legajo;

    private byte _nota1;

    private byte _nota2;

    private float _final;

    public void CalcularFinal()
    {
      Random final = new Random();

      if (this._nota1 >= 4 && this._nota2 >= 4)
        this._final = final.Next(0, 10);

      else
        this._final = -1;
    }

    public void Estudiar(byte notaUno, byte notaDos)
    {
      this._nota1 = notaUno;
      this._nota2 = notaDos;
    }

    public void Mostrar()
    {
      Console.WriteLine(this.nombre);
      Console.WriteLine(this.apellido);
      Console.WriteLine(this.legajo);
      Console.WriteLine(this._nota1);
      Console.WriteLine(this._nota2);
      if(this._final == -1)
        Console.WriteLine("Alumno Desaprobado");
      else
        Console.WriteLine(this._final);
      Console.WriteLine();
    }

  }
}
