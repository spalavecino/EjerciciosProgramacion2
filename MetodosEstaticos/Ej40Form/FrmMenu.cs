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
    public partial class FrmMenu : Form
    {
        public Centralita centralita;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centralita = new Centralita("Telefonica");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            //frmLlamador.MdiParent = this;
            if(frmLlamador.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.centralita = frmLlamador.Centralita;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }
    }
}
