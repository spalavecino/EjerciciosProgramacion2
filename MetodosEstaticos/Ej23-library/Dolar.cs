using System;
using System.Collections.Generic;
using System.Text;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        private Dolar() {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos((Dolar.cotizRespectoDolar * d.GetCantidad()) / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro((Dolar.cotizRespectoDolar * d.GetCantidad()) / Euro.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() != d2.GetCantidad();
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return d != ((Dolar) e);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d == ((Dolar)e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return d != ((Dolar)p);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return d == ((Dolar)p);
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantidad() + d2.GetCantidad());
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantidad() - d2.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d + ((Dolar)p);
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d - ((Dolar)p);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + ((Euro)e);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - ((Euro)e);
        }
    }
}
