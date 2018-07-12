using System;
using System.Collections.Generic;
using System.Text;

namespace Ej34
{
    class Camion:VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color):base(cantidadRuedas, cantidadPuertas, color){}
    }
}
