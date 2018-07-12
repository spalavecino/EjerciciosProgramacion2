using System;
using System.Collections.Generic;
using System.Text;

namespace Ej29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this() {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.cantidadDeJugadores > e.jugadores.Count)
            {
                bool playerAddedBefore = false;

                foreach(Jugador jugador in e.jugadores)
                {
                    if(jugador == j)
                    {
                        playerAddedBefore = true;
                        break;
                    }
                }

                if (!playerAddedBefore)
                {
                    e.jugadores.Add(j);
                    return true;
                }
            }

            return false;
        }
    }
}
