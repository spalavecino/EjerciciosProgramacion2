using System;

namespace Ej26
{
    class Ej26
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_26";

            int[] numbers = new int[20];
            int numberSelected;
            bool parseSuccessfull;

            for(int i=0; i<20; i++)
            {
                numberSelected = 0;
                Console.Write("Ingrese un numero entero distinto de cero:   ");
                parseSuccessfull = Int32.TryParse(Console.ReadLine(), out numberSelected);

                while(!parseSuccessfull || numberSelected == 0)
                {
                    Console.Write("El numero ingresado debe ser entero y distinto de cero (0), intentelo nuevamente:   ");
                    parseSuccessfull = Int32.TryParse(Console.ReadLine(), out numberSelected);
                }

                numbers[i] = numberSelected;
            }

            Console.WriteLine("Listando numeros... \n\n");

            foreach(int numero in numbers)
            {
                Console.WriteLine("{0}", numero);
            }

            Console.WriteLine("\n\nListando positivos de forma decreciente...\n\n");
            Array.Sort(numbers);

            for(int i=0; i < 20; i++)
            {
                if (numbers[19 - i] < 0)
                {
                    break;
                }

                Console.WriteLine("{0}", numbers[19 - i]);
            }

            Console.WriteLine("\n\nListando negativos de forma creciente...\n\n");

            foreach(int number in numbers)
            {
                if (number > 0)
                {
                    break;
                }

                Console.WriteLine("{0}", number);
            }

            Console.ReadKey();
        }
    }
}
