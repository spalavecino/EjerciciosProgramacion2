using System;
using System.Collections.Generic;
using System.Text;

namespace Ej34
{
    class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color) : base(cantidadRuedas, cantidadPuertas, color) { }
    }
}
