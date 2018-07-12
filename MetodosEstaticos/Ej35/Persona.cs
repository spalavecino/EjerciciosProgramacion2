using System;
using System.Collections.Generic;
using System.Text;

namespace Ej35
{
    class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            this.dni = dni;
        }

        public long Dni{
            get {
                return dni;
            }

            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                this.nombre = value;
            }
        }
    }
}
