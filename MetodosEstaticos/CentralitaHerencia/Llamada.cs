﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Llamada
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
        
        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Duracion:     {0}\nNro origen:    {1}\nNro destino:   {2}", duracion, nroOrigen, nroDestino);

            return str.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
