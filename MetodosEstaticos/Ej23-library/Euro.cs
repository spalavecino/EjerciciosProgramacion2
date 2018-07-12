using System;
using System.Collections.Generic;
using System.Text;

namespace Moneda
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        private Euro()
        {
            Euro.cotizRespectoDolar = (float)1.3642;
        }

        public Euro(double cantidad):this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.cotizRespectoDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(((Dolar)e).GetCantidad() / Pesos.GetCotizacion());
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.GetCantidad() != e2.GetCantidad();
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return d != e;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return d == e;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return e != ((Euro) p);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == ((Dolar)p);
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() + e2.GetCantidad());
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() - e2.GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e + ((Euro) p);
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e - ((Euro) p);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e + ((Euro)d);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - ((Euro)d);
        }
    }
}
