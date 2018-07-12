using System;


namespace MetodosEstaticos
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";

            int numeroIngresado;
            int maximo = 0;
            int minimo = 0;
            int i;
            float promedio = 0;
            bool pudoParsearNumero;

            for(i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entero entre -100 y 100");
                    pudoParsearNumero = Int32.TryParse(Console.ReadLine(), out numeroIngresado);
                }
                while (!pudoParsearNumero || !Validacion.Validar(numeroIngresado, -100, 100));

                if(i == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }
                else
                {
                    if(minimo > numeroIngresado)
                    {
                        minimo = numeroIngresado;
                    }

                    if(maximo < numeroIngresado)
                    {
                        maximo = numeroIngresado;
                    }
                }
                promedio += numeroIngresado;
            }

            promedio /= i;

            Console.WriteLine("El menor numero ingresado es {0}\n El mayor numero ingresado es {1}\n El promedio entre los numeros ingresados fue: {2,5:#,###.00}", minimo, maximo, promedio);
            Console.ReadKey();
        }
    }
}
