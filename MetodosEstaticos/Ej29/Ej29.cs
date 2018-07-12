using System;

namespace Ej29
{
    class Ej29
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_29";

            Jugador jugador = new Jugador(36400924, "Sebastian Palavecino");
            Jugador jugador1 = new Jugador(36411924, "Daysi Calderon");
            Jugador jugador2 = new Jugador(36400924, "Sebastian Palavecino");
            Jugador jugador3 = new Jugador(36511924, "Daysi Calderon");

            Equipo equipo = new Equipo(2, "Un equipo");
            bool playerAdded;

            playerAdded = equipo + jugador;
            playerAdded = equipo + jugador1;
            playerAdded = equipo + jugador2;
            playerAdded = equipo + jugador3;

            //Console.WriteLine("Partidos jugados: {0}\nPromedio: {1}\nTotal Goles: {2}", jugador.partidosJugados, jugador.promedioGoles, jugador.totalGoles);

            Console.ReadKey();
        }
    }
}
