using System;

namespace Ej30
{
    class Ej30
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_30";

            AutoF1 auto = new AutoF1(17, "Ferrari");
            AutoF1 auto2 = new AutoF1(17, "Ferrari");

            Competencia competencia = new Competencia(15, 3);

            bool carAdded;
            bool carRemoved;

            carAdded = competencia + auto;
            carRemoved = competencia - auto2;
            Console.ReadKey();
        }
    }
}
