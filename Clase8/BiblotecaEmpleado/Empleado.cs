using System;
using System.Text;

namespace BiblotecaEmpleado
{
    public enum EPuestoJerarquico
    {
        Administración,
        Gerencia,
        Sistemas,
        Accionista
    }

    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _legajo;
        private EPuestoJerarquico _puesto;
        private int _salario;

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public static bool operator ==(Empleado empleado1, Empleado empleado2)
        {
            return empleado1._legajo == empleado2._legajo;
        }

        public static bool operator !=(Empleado empleado1, Empleado empleado2)
        {
            return !(empleado1._legajo == empleado2._legajo);
        }

        public string Mostrar()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("NOMBRE: {0}\nAPELLIDO: {1}\nLEGAJO: {2}\nPUESTO: {3}\nSALARIO: {4}\n", this._nombre, this._apellido, this._legajo, this._puesto, this._salario);
            return salida.ToString();
        }

    }
}
