using System;
using System.Collections.Generic;
using System.Text;

namespace Ej33
{
    class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]{
            get
            {
                if(i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                else
                {
                    return "";
                }
                
            }

            set
            {
                if(i>= 0 && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                else if(i >= paginas.Count)
                {
                    paginas.Add(value);
                }
                
            }
            
        }
    }
}
