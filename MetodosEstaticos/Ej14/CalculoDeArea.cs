using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosEstaticos
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double l)
        {
            return l * 4;
        }

        public static double CalcularTriangulo(double ladoBase, double altura)
        {
            return ladoBase * altura / 2;
        }

        public static double CalcularCirculo(double radio)
        {
            return (Math.PI) * radio * radio;
        }
    }
}
