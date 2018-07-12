using System;

namespace ProyectoParaProbar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba el primer número");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba el segundo número");
                int j = int.Parse(Console.ReadLine());
                int k = i / j;
            }
            /*catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }*/catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
