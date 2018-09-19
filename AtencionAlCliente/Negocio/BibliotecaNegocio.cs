using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes;
using PuestoDeAtencion;

namespace Negocios
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            //set
            //{
            //    if (!(value is null))
            //        this.clientes.Enqueue(value); 
            //}
        }

        public Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool salida = true;

            if (n != c)
                n.clientes.Enqueue(c);

            else
                salida = false;

            return salida;
        }

        public static bool operator ~(Negocio n)
        {
            if (!(n is null))
            {
                n.caja.Atender(n.Cliente);
                return true;
            }
            else
                return false;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            Queue<Cliente> auxCola = new Queue<Cliente>();
            Cliente auxCliente;
            bool salida = false;

            while (n.clientes.Count > 0)
            {
                auxCliente = n.clientes.Dequeue();
                auxCola.Enqueue(auxCliente);
                if (auxCliente == c)
                {
                    salida = true;
                    break;
                }
            }

            while (auxCola.Count > 0)
            {
                n.clientes.Enqueue(auxCola.Dequeue());
            }

            return salida;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public int ClientesPendiente()
        {
            return this.clientes.Count;
        }
    }
}
