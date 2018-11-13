using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void DelegadoGuardar(Alumno a);
    public delegate bool DelegadoModificar(Alumno a);
    public delegate List<Alumno> DelegadoTraer(int id);

    public class Alumno
    {
        private string nom;
        private string apellido;
        private DateTime fecha;
        private int dni;
        private string direccion;

        public string Nombre
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public override string ToString()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendLine("Nombre: " + this.Nombre);
            salida.AppendLine("Apellido: " + this.Apellido);
            salida.AppendLine("Fecha de nacimiento: " + this.Fecha);
            salida.AppendLine("Dni: " + this.DNI);
            salida.AppendLine("Direccion: " + this.Direccion);
            salida.AppendLine("-----------------------");
            return salida.ToString();
        }

        public event DelegadoGuardar Guardar;
        public event DelegadoModificar Modificar;
        public event DelegadoTraer traer;
    }
}
