using System;
using System.Threading;
using Clientes;

namespace PuestoDeAtencion
{
    public enum Puesto
    {
        caja1,
        caja2
    }

    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cliente)
        {
            Thread.Sleep(1500);
            return true;
        }
    }
}
