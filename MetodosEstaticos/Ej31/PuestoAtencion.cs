using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Encapsulamiento
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }
    }
}
