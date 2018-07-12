using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial: Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float costo = 0;

            switch (franjaHoraria)
            {
                case (Franja.Franja_1):
                    costo = (float) 0.99;
                    break;
                case (Franja.Franja_2):
                    costo = (float) 1.25;
                    break;
                case (Franja.Franja_3):
                    costo = (float) 0.66;
                    break;
            }

            return costo * duracion;
        }

        public string Mostrar()
        {
            string baseResult = base.Mostrar();

            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}\nCosto de llamada:    {1}\nFranja:    {2}\n\n", baseResult, CostoLlamada, franjaHoraria);

            return str.ToString();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
