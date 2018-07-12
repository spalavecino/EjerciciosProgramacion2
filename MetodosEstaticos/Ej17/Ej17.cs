using System;
using NameSpaceBoligrafo;

namespace Objetos
{
    class Ej17
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujoAzul;
            string dibujoRojo;

            boligrafoAzul.Pintar(3, out dibujoAzul);
            Console.ForegroundColor = boligrafoAzul.GetColor();
            Console.WriteLine("{0}", dibujoAzul);

            boligrafoRojo.Pintar(6, out dibujoRojo);
            Console.ForegroundColor = boligrafoRojo.GetColor();
            Console.WriteLine("{0}", dibujoRojo);

            Console.ReadKey();
        }
    }
}
