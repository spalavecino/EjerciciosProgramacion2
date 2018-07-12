using System;
using System.Collections.Generic;
using System.Text;

namespace Ej30
{
    class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            return str.ToString();
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public short SetCantidadCombustible(short cantidadCombustible)
        {
            return this.cantidadCombustible = cantidadCombustible;
        }

        public short SetVueltasRestantes(short vueltasRestantes)
        {
            return this.vueltasRestantes = vueltasRestantes;
        }

        public bool SetEnCompetencia(bool enCompetencia)
        {
            return this.enCompetencia = enCompetencia;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero) && (a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
