using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblotecaEmpleado;

namespace BibliotecaEmpresa
{
    public class Empresa
    {
        private List<Empleado> _nominaEmpleados;
        private string _razonSocial;
        private string _direccion;
        private float _ganancias;

        public string RazonSocial
        {
            get
            {
                return this._razonSocial;
            }
            set
            {
                this._razonSocial = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this._direccion;
            }
            set
            {
                this._direccion = value;
            }
        }

        public float Ganancias
        {
            get
            {
                return this._ganancias;
            }
            set
            {
                this._ganancias = value;
            }
        }

        public Empresa()
        {
            this._nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias) :this()
        {
            this._razonSocial = razonSocial;
            this._direccion = direccion;
            this._ganancias = ganancias;
        }

        public static bool operator +(Empresa empresa, Empleado empleado)
        {
            bool agregado = true;

            if (empresa._nominaEmpleados.Contains(empleado))
                agregado = false;

            else
                empresa._nominaEmpleados.Add(empleado);

            return agregado;
        }

        public string MostarEmpresa()
        {
            StringBuilder salida = new StringBuilder();
            salida.AppendFormat("La empresa {0} sitiada en la calle {1} cuenta con ganancias por {2} y con {3} empleado/s:\n", this._razonSocial, this._direccion, this._ganancias, this._nominaEmpleados.Count);

            foreach(Empleado empleado in this._nominaEmpleados)
            {
                salida.Append(empleado.Mostrar());
            }

            return salida.ToString();
        }
    }
}
