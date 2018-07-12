using System;
using System.Collections.Generic;
using System.Text;

namespace Ej38
{
    class Sobreescrito
    {

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return obj is Sobreescrito;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
