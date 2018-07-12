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
using Franja = CentralitaAbstract.Provincial.Franja;

namespace Ej40Form
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        Franja franjas;
        

        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita{
            get
            {
                return this.centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            cmbFranja.Enabled = false;
            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnNumberAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNumberNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text.Length>0 && txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void cmbFranja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if(txtNroDestino.Text != null && txtNroDestino.Text.Length > 0)
            {
                Llamada llamada;
                float duracion = (new Random()).Next(1, 50);
                if (cmbFranja.Enabled)
                {
                    llamada = new Provincial(txtNroOrigen.Text, franjas, duracion, txtNroDestino.Text);
                }
                else
                {
                    llamada = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, (float) ((new Random()).NextDouble() * (5.6 - 0.5) + 0.5));
                }
                try
                {
                    centralita = centralita + llamada;
                }
                catch (CentralitaException ce)
                {
                    MessageBox.Show(ce.Message);
                    Console.WriteLine("Nombre de la clase donde se origino el error: {0}\n Nombre del metodo: {1}", ce.NombreClase, ce.NombreMetodo);
                    if (ce.InnerException != null)
                    {
                        Console.WriteLine("Exception originaria: {0}", ce.InnerException);
                    }
                }
                
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
