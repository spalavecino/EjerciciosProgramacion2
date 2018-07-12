using System;
using System.Collections.Generic;
using System.Text;

namespace Ej47Library
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public Equipo(string nombre) {
            this.nombre = nombre;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0} creado el {1}", this.nombre, this.fechaCreacion);

            return str.ToString();
        }
    }
}
