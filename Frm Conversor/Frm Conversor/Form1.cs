using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    private void textBox9_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnConvertEuro_Click(object sender, EventArgs e)
    {
      string input = txtEuro.Text;
      int numero;
      if (int.TryParse(input, out numero))
      {
        Euro euro = new Euro(numero);
        txtEuroAEuro.Text = euro.GetCantidad().ToString();
        txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
        txtEuroAPesos.Text = ((Pesos)euro).GetCantidad().ToString();
      }
    }

    private void btnConvertDolar_Click(object sender, EventArgs e)
    {
      string input = txtDolar.Text;
      int numero;
      if (int.TryParse(input, out numero))
      {
        Dolar dolar = new Dolar(numero);
        txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
        txtDolarADolar.Text = dolar.GetCantidad().ToString();
        txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
      }
    }

    private void btnConvertPesos_Click(object sender, EventArgs e)
    {
      string input = txtPesos.Text;
      int numero;
      if (int.TryParse(input, out numero))
      {
        Pesos peso = new Pesos(numero);
        txtPesosAEuro.Text = ((Euro)peso).GetCantidad().ToString();
        txtPesosADolar.Text = ((Dolar)peso).GetCantidad().ToString();
        txtPesosAPesos.Text = peso.GetCantidad().ToString();
      }
    }
  }
}
