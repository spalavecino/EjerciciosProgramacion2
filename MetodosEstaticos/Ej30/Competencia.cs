using System;
using System.Collections.Generic;
using System.Text;

namespace Ej30
{
    class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            return "";
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return c.competidores.Remove(auto);
                }
            }
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if((c.cantidadCompetidores > c.competidores.Count) && c != a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)(new Random()).Next(15, 100));
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
