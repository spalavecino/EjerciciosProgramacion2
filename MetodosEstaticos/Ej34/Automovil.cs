using System;
using System.Collections.Generic;
using System.Text;

namespace Ej34
{
    class Automovil:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color) { }
    }
}
