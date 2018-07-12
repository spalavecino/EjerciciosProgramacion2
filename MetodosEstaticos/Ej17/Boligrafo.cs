using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpaceBoligrafo
{
    class Boligrafo
    {
        private const short cantidadTintaMaxima = 10;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta)
        {
            this.tinta = 0;
            SetTinta(tinta);
        }

        public Boligrafo(short tinta, ConsoleColor color):this(tinta)
        {
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if(GetTinta() < 0)
            {
                this.tinta = 0;
            }

            if(GetTinta() > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar (int gasto, out string dibujo)
        {
            dibujo = "";

            if(GetTinta() == 0)
            {
                return false;
            }
            else
            {
                short tintaAntes = GetTinta();
                SetTinta((short) - gasto);
                short tintaGastada = (Int16) (tintaAntes - GetTinta());
                StringBuilder str = new StringBuilder();

                for(int i = 0; i < tintaGastada; i++)
                {
                    str.Append("*");
                }

                dibujo = str.ToString();

                return true;
            }
            

        }
    }
}
