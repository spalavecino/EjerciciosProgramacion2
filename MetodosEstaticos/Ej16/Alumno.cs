using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    public class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void CalcularFinal() {
            if(_nota1 >=4 && _nota2 >= 4)
            {
               this._notaFinal = (new Random()).Next(0, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nApellido: {1}\nLegajo: {2}\n", this.nombre, this.apellido, this.legajo);
            if(this._notaFinal == -1)
            {
                str.AppendLine("Alumno DESAPROBADO.\n");
            }
            else
            {
                str.AppendFormat("Nota final: {0}\n\n", this._notaFinal);
            }

            return str.ToString();
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }
            
    }
}
