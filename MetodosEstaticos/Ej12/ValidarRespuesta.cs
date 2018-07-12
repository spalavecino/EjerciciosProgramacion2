using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosEstaticos
{
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            c = Char.Parse((c.ToString()).ToLower());
            if (c == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
