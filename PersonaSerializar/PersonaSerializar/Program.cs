using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PersonaSerializar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona p = new Persona("Osvaldo", "Basualdo");
                Console.WriteLine(p.ToString());
                Persona.Guardar(p, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona");
                Persona q = Persona.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona");
                Console.WriteLine(q.ToString());
                Console.Read();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No existe el archivo");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No tiene permisos suficientes");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Los parametros deben ser del tipo string");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No existe el directorio");
            }
            catch (System.Runtime.Serialization.SerializationException)
            {
                Console.WriteLine("No se pudo serializar");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Valor invalido");
            }
        }
    }
}
