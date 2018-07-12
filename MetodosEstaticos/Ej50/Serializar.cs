using System;
using System.Collections.Generic;
using System.Text;

namespace Ej50
{
    public class Serializar<S, V> : IGuardar<S, V>
    {
        public bool Guardar(S obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V) Convert.ChangeType("Objeto Leído", typeof(V));
        }
    }
}
