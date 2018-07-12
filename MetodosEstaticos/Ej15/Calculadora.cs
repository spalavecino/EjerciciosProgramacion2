using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosEstaticos
{
    public class Calculadora
    {
        public string Calcular(double n1, double n2, char operador)
        {
            string result = "";

            switch (operador)
            {
                case '+':
                    result = (n1 + n2).ToString();
                    break;
                case '-':
                    result = (n1 - n2).ToString();
                    break;
                case '*':
                    result = (n1 * n2).ToString();
                    break;
                case '/':
                    if (Validar(n2))
                    {
                        result = (n1 / n2).ToString();
                    }
                    else
                    {
                        result = "No se puede realizar la division por 0 (cero)";
                    }
                        break;
            }

            return result;
        }

        private bool Validar (double divisor)
        {
            if(divisor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Mostrar(string result)
        {
            Console.WriteLine("El resultado de la operacion es: {0:#,###.00}", float.Parse(result));
        }
    }
}
