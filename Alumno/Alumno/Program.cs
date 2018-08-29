using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumno
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno1 = new Alumno();
      Alumno alumno2 = new Alumno();
      Alumno alumno3 = new Alumno();

      alumno1.nombre = "Gaston";
      alumno1.apellido = "Silva";
      alumno1.legajo = 107075;

      alumno2.nombre = "Emanuel";
      alumno2.apellido = "Gigliotti";
      alumno2.legajo = 107076;

      alumno3.nombre = "Martin";
      alumno3.apellido = "Campaña";
      alumno3.legajo = 107077;

      alumno1.Estudiar(4, 4);
      alumno2.Estudiar(2, 6);
      alumno3.Estudiar(7, 8);

      alumno1.CalcularFinal();
      alumno2.CalcularFinal();
      alumno3.CalcularFinal();

      alumno1.Mostrar();
      alumno2.Mostrar();
      alumno3.Mostrar();

      Console.ReadKey();
    }
  }
}
