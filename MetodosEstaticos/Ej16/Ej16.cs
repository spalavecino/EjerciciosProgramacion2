using System;

namespace Objetos
{
    class Ej16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_16";

            Alumno pichu = new Alumno("Daysi", "Calderon", 2408);
            Alumno seba = new Alumno("Sebastian", "Palavecino", 0824);
            Alumno mati = new Alumno("Matilde", "Meneces", 6169);

            pichu.Estudiar(10, 10);
            seba.Estudiar(5, 8);
            mati.Estudiar(6, 3);

            pichu.CalcularFinal();
            seba.CalcularFinal();
            mati.CalcularFinal();

            Console.Write(pichu.Mostrar());
            Console.Write(seba.Mostrar());
            Console.Write(mati.Mostrar());

            Console.ReadKey();
        }
    }
}
