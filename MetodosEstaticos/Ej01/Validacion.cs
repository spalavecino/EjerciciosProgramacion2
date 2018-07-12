using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosEstaticos
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
