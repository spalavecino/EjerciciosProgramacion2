using System;
using System.Collections.Generic;
using System.Text;

namespace Moneda
{
    public class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        private Pesos()
        {
            Pesos.cotizRespectoDolar = (float)(1 / 17.55);
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p){
            return new Dolar(Pesos.GetCotizacion() * p.GetCantidad());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(((Dolar) p).GetCantidad() / Euro.GetCotizacion());
        }

        public static implicit operator Pesos(double cantidad)
        {
            return new Pesos(cantidad);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() != p2.GetCantidad();
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator != (Pesos p, Dolar d)
        {
            return d != p;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return d == p;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return e != p;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return e == p;
        }

        public static Pesos operator +(Pesos p1, Pesos p2)
        {
            return new Pesos(p1.GetCantidad() + p2.GetCantidad());
        }

        public static Pesos operator - (Pesos p1, Pesos p2)
        {
            return new Pesos(p1.GetCantidad() - p2.GetCantidad());
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p + (Pesos)d;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p - (Pesos)d;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + (Euro)e;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p - (Euro)e;
        }


    }
}