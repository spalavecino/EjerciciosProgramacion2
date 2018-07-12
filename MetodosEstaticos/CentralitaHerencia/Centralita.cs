using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private static string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        public float GananciaPorTotal{
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            switch (tipo)
            {
                case (Llamada.TipoLlamada.Local):
                    foreach(Llamada llamada in listaDeLlamadas)
                    {
                        if(llamada is Local)
                        {
                            ganancia += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                case (Llamada.TipoLlamada.Provincial):
                    foreach (Llamada llamada in listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
                case (Llamada.TipoLlamada.Todas):
                    foreach(Llamada llamada in listaDeLlamadas)
                    {
                        if(llamada is Local)
                        {
                            ganancia += ((Local)llamada).CostoLlamada;
                        }
                        else
                        {
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            if (listaDeLlamadas.Count > 1)
            {
                Llamada llamadaAux;

                for(int i = 0; i< (listaDeLlamadas.Count - 1); i++)
                {
                    if (Llamada.OrdenarPorDuracion(listaDeLlamadas[i], listaDeLlamadas[i + 1]) == -1)
                    {
                        llamadaAux = listaDeLlamadas[i + 1];
                        listaDeLlamadas[i + 1] = listaDeLlamadas[i];
                        listaDeLlamadas[i] = llamadaAux;
                    }
                }                
            }
        }

        public string Mostrar()
        {
            // Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
            StringBuilder str = new StringBuilder();

            str.AppendFormat("Razon Social:     {0}\n", razonSocial);
            str.AppendFormat("Ganancia por TOTAL DE LLAMADAS:     {0}\n", GananciaPorTotal);
            str.AppendFormat("Ganancia por LLAMADAS LOCALES:     {0}\n", GananciaPorLocal);
            str.AppendFormat("Ganancia por LLAMADAS PROVINCIALES:     {0}\n", GananciaPorProvincial);

            foreach(Llamada llamada in listaDeLlamadas)
            {
                if(llamada is Local)
                {
                    str.AppendFormat(((Local)llamada).Mostrar());
                }
                else
                {
                    str.AppendFormat(((Provincial)llamada).Mostrar());
                }
            }

            return str.ToString();
        }
    }
}
