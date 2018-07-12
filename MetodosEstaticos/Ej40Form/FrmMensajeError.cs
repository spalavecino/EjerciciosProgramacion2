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

namespace Ej40Form
{
    public partial class FrmMensajeError : Form
    {
        CentralitaException excepcion;

        public FrmMensajeError(CentralitaException e)
        {
            this.excepcion = e;
        }

        public FrmMensajeError()
        {
            InitializeComponent();
        }

        private void FrmMensajeError_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarMensaje()
        {
            txtMensajeError.Text = this.excepcion.ToString();
            Console.WriteLine("Nombre de la clase donde se origino el error: {0}\n Nombre del metodo: {1}", excepcion.NombreClase, excepcion.NombreMetodo);
            if (excepcion.InnerException != null)
            {
                Console.WriteLine("Exception originaria: {0}", excepcion.InnerException);
            }
        }
    }
}
