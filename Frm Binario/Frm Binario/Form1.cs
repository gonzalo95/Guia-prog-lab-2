using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Binario
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btmConvetADecimal_Click(object sender, EventArgs e)
    {
      int numero;
      if(int.TryParse(txtBinarioIngreso.Text, out numero))
      {
        txtDecimalConvertido.Text = Conversor.BinarioDecimal(txtBinarioIngreso.Text).ToString();
      }
    }

    private void btmConvertABinario_Click(object sender, EventArgs e)
    {
      int numero;
      if (int.TryParse(txtBinarioIngreso.Text, out numero))
      {
        txtBinarioConvertido.Text = Conversor.DecimalBinario(numero).ToString();
      }
    }
  }
}
