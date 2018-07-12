using System;

namespace MetodosEstaticos
{
    class Ej15

    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_15";

            double n1;
            double n2;
            //char operador;
            bool operadorValido = false;
            Calculadora calculadora = new Calculadora();

            Console.Write("Ingrese un numero:   ");
            n1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese la operacion a realizar entre ambos numeros:     ");
            char operador = (Console.ReadKey()).KeyChar;

            Console.Write("\nIngrese otro numero:   ");
            n2 = Convert.ToDouble(Console.ReadLine());

            calculadora.Mostrar(calculadora.Calcular(n1, n2, operador));

            Console.ReadKey();
        }
    }
}
