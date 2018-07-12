using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ej21_Form
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double euros;

            if (Double.TryParse(txtEuro.Text, out euros) && euros >= 0)
            {
                Euro euro = new Euro(euros);
                txtEuroAEuro.Text = txtEuro.Text;
                txtEuroADolar.Text =  (((Dolar) euro).GetCantidad()).ToString();
                txtEuroAPesos.Text = (((Pesos) euro).GetCantidad()).ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero mayor a 0 (cero)");
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double dolares;

            if (Double.TryParse(txtDolar.Text, out dolares) && dolares >= 0)
            {
                Dolar dolar = new Dolar(dolares);
                txtDolarAEuro.Text = (((Euro) dolar).GetCantidad()).ToString();
                txtDolarADolar.Text = txtDolar.Text;
                txtDolarAPesos.Text = (((Pesos) dolar).GetCantidad()).ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero mayor a 0 (cero)");
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            double pesos;

            if (Double.TryParse(txtPesos.Text, out pesos) && pesos >= 0)
            {
                Pesos objPesos = new Pesos(pesos);
                txtPesosAEuro.Text = (((Euro) objPesos).GetCantidad()).ToString();
                txtPesosADolar.Text = (((Dolar) objPesos).GetCantidad()).ToString();
                txtPesosAPesos.Text = txtDolar.Text;
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero mayor a 0 (cero)");
            }
        }
    }
}
