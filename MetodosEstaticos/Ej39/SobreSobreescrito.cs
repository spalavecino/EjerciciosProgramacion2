using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga
{
    class SobreSobreescrito: Sobreescrito
    {
        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
