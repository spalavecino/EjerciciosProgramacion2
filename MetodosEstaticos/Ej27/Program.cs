using System;
using System.Collections.Generic;

namespace Ej27
{
    class Ej27
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_27";

            List<int> numbers = new List<int>();
            Queue<int> queueNumbers = new Queue<int>();
            Stack<int> stackNumbers = new Stack<int>();

            int numberSelected;
            bool parseSuccessfull;

            for (int i = 0; i < 20; i++)
            {
                numberSelected = 0;
                Console.Write("Ingrese un numero entero distinto de cero:   ");
                parseSuccessfull = Int32.TryParse(Console.ReadLine(), out numberSelected);

                while (!parseSuccessfull || numberSelected == 0)
                {
                    Console.Write("El numero ingresado debe ser entero y distinto de cero (0), intentelo nuevamente:   ");
                    parseSuccessfull = Int32.TryParse(Console.ReadLine(), out numberSelected);
                }

                numbers.Add(numberSelected);
            }

            Console.WriteLine("Listando numeros ingresados...\n");

            foreach(int number in numbers)
            {
                Console.WriteLine("{0}", number);
            }

            numbers.Sort();            

            foreach(int number in numbers)
            {
                if (number < 0)
                {
                    queueNumbers.Enqueue(number);
                }
                else
                {
                    stackNumbers.Push(number);
                }
            }

            Console.WriteLine("\n\nListando numeros positivos en forma decreciente...\n");

            while (queueNumbers.Count > 0)
            {
                Console.WriteLine("{0}", queueNumbers.Dequeue());
            }

            Console.WriteLine("\n\nListando numeros negativos en forma creciente...\n");

            while (stackNumbers.Count > 0) {
                Console.WriteLine("{0}", stackNumbers.Pop());
            }

            Console.ReadKey();
        }
    }
}
