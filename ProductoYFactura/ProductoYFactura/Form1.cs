using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoYFactura
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      //Producto producto = new Producto(Convert.ToInt32(txtId.Text), txtNombre.Text, Convert.ToDouble(txtPrecio.Text));
      Producto productoUno = new Producto(1, "Monitor", 4000);
      Producto productoDos = new Producto(2, "Teclado", 500);
      Factura factura = new Factura();

      factura[productoUno.Identificador] = productoUno;
      factura[productoDos.Identificador] = productoDos;

      MessageBox.Show("Total factura : $" + factura.Total.ToString());
    }
  }
}
