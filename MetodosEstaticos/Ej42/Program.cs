using System;

namespace Ej42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cuentas.Dividir();
            }
            catch (MiException e)
            {
                Console.Write("Entro");
            }

            Console.ReadKey();
        }

        class Cuentas
        {
            public Cuentas()
            {
                try
                {

                }
                catch (DivideByZeroException e) {
                    throw e;
                }
            }

            public Cuentas (string algo)
            {
            }

            public static void Dividir()
            {
                int numero = 0;
                float result = 5 / numero;
            }
        }

        class MiException : Exception
        {

        }
    }
}
