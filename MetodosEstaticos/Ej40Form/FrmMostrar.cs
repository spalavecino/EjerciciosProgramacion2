using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaAbstract;
using TipoLlamada = CentralitaAbstract.Llamada.TipoLlamada;

namespace Ej40Form
{
    public partial class FrmMostrar : Form
    {
        TipoLlamada tipoLlamada;
        Centralita centralita;

        public FrmMostrar(Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public TipoLlamada TipoLlamada{
            set{
                this.tipoLlamada = value;

                switch (this.tipoLlamada)
                {
                    case TipoLlamada.Local:
                        txtRichTextBox.Text = "Ganancias de llamadas LOCALES: $" + centralita.GananciaPorLocal;
                        break;
                    case TipoLlamada.Provincial:
                       txtRichTextBox.Text = "Ganancias de llamadas PROVINCIALES: $" + centralita.GananciaPorProvincial;
                        break;
                    case TipoLlamada.Todas:
                        txtRichTextBox.Text = "Ganancias de TODAS las llamadas: $" + centralita.GananciaPorTotal;
                        break;
                }                
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
