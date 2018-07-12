using System;

namespace Sobrecarga
{
    class Ej19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";

            Sumador sumador1 = new Sumador(15);
            Sumador sumador2 = new Sumador();
            long resultLong;
            string resultString;

            resultLong = sumador1.Sumar(1000, 88);
            resultLong = sumador1.Sumar(1000, 88);
            resultString = sumador2.Sumar("Hola, ", "como va?");

            Sumador sumador3 = new Sumador(17);
            int cantSum3 = (int)sumador3;
            long sumUnoTres = sumador1 + sumador3;
            bool igualCantSumador = sumador1 | sumador3;
            sumador3.Sumar(10, 3);
            igualCantSumador = sumador1 | sumador3;

            Console.ReadKey();

        }
    }
}
