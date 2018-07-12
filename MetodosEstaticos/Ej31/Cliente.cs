using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            get{
                return nombre;
            }

            set{
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return c1.Numero != c2.Numero;
        }
    }
}
