using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaAbstract
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

        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            string baseResult = base.Mostrar();

            StringBuilder str = new StringBuilder();

            str.AppendFormat("{0}\nCosto de llamada:    {1}\n\n", baseResult, CostoLlamada);

            return str.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
