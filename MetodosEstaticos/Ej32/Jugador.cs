using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamiento
{
    class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
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

        public long Dni
        {
            get
            {
                return dni;
            }

            set
            {
                this.dni = value;
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
