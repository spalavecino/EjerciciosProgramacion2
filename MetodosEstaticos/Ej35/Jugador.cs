using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{
    class Jugador
    {
        
        private int partidosJugados;
        private int totalGoles;

        public Jugador(string nombre, int totalGoles, int totalPartidos) : base(nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return totalGoles / partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Nombre:   {0}\nDni:    {1}\n", this.nombre, this.dni);
            str.AppendFormat("Partidos jugados:     {0}\nGoles:     {1}", this.partidosJugados, this.totalGoles);
            str.AppendFormat("\nPromedio de gol:    {0:#.###,00}", this.PromedioGoles);

            return str.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.dni != j2.dni;
        }
    }
}
