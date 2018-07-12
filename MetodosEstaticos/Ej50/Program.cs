using System;

namespace Ej50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_50";

            IGuardar<bool, string> guardar1 = new Serializar<bool, string>();
            IGuardar<bool, string> guardar2 = new GuardarTexto<bool, string>();

            Console.WriteLine("Leyendo con {0}:     {1}", guardar1.ToString(), guardar1.Leer());
            Console.WriteLine("Leyendo con {0}:     {1}", guardar2.ToString(), guardar2.Leer());

            Console.ReadKey();
        }
    }
}
