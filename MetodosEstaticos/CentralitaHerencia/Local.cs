using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return duracion * costo;
        }

        public string Mostrar()
        {
            string baseResult = base.Mostrar();

            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}\nCosto de llamada:    {1}\n\n", baseResult, CostoLlamada);

            return str.ToString();
        }
    }
}
