using System;

namespace MetodosEstaticos
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_12";
            int suma;
            char sigueSumando;

            Console.WriteLine("Ingrese un numero entero \n");
            suma = Int32.Parse(Console.ReadLine());
            
            do
            {
                Console.Clear();
                Console.WriteLine("{0}", suma);
                Console.WriteLine("+");
                suma += (Int32.Parse(Console.ReadLine()));
                Console.WriteLine("--------\n{0}\n", suma);
                Console.WriteLine("Continuar? (S/N)");
                sigueSumando = (Console.ReadKey()).KeyChar;

            } while (ValidarRespuesta.ValidaS_N(sigueSumando));
        }
    }
}
