using System;
using Ej47Library;

namespace Ej47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_47";

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>();
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>();

            EquipoFutbol ef1 = new EquipoFutbol("Boca");
            EquipoFutbol ef2 = new EquipoFutbol("River");
            EquipoFutbol ef3 = new EquipoFutbol("Velez");

            EquipoBasquet eb1 = new EquipoBasquet("San Antonio Spurs");
            EquipoBasquet eb2 = new EquipoBasquet("LA Lakers");
            EquipoBasquet eb3 = new EquipoBasquet("Chicago Bulls");

            torneoBasquet += eb1;
            torneoBasquet += eb2;
            torneoBasquet += eb3;

            torneoFutbol += ef1;
            torneoFutbol += ef2;
            torneoFutbol += ef3;

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.WriteLine("\n{0}", torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.ReadKey();
        }
    }
}
