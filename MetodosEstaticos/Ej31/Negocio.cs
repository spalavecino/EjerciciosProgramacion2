using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }

            set
            {
                bool result = this + value;
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach(Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            else
            {
                return false;
            }
        }
    }
}
