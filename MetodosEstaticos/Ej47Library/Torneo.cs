using System;
using System.Collections.Generic;
using System.Text;

namespace Ej47Library
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(){
            this.equipos = new List<T>();
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string JugarPartido
        {
            get
            {
                if (equipos.Count > 1)
                {
                    T t1 = equipos[(new Random().Next(0, equipos.Count))];
                    T t2;
                    do
                    {
                    t2 = equipos[(new Random().Next(0, equipos.Count))];
                    } while (t1 == t2);

                 return CalcularPartido<T>(t1, t2);
                }

                return "En el torneo hay menos de dos equipos inscriptos";
            }
        }

        public static bool operator ==(Torneo<T> t, Equipo e)
        {
            foreach(T equipo in t.equipos)
            {
                if(equipo == e)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> t, Equipo e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, Equipo e)
        {
            if(t != e)
            {
                t.equipos.Add((T)e);
            }

            return t;
        }

        public string Mostrar()
        {
            return "";
        }

        private string CalcularPartido<T>(T t, T s) where T:Equipo
        {
            Random r = new Random();

            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0} {1} - {2} {3}", t.Nombre, r.Next(), r.Next(), s.Nombre);
            return str.ToString();
        }
    }
}
