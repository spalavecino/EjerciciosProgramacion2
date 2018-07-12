using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaAbstract
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        // CONSTRUCTORS
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        // PROPIEDADES
        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLlamada{
            get;
        }

        // METHODS
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if(llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }else {
                return 1;
            }
        }
        
        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Duracion:     {0}\nNro origen:    {1}\nNro destino:   {2}", duracion, nroOrigen, nroDestino);

            return str.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
