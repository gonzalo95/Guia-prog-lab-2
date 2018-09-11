using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
  public partial class FrmPantalla1 : Form
  {
    public FrmPantalla1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(MessageBox.Show("MIRA COMO TE INTERRUMPO PAPA", "VENTANA MOLESTA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        this.button1.Text = "SE";
      }
      else
      {
        this.button1.Text = "NI A PALOS";
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      MessageBox.Show("Evento: load");
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      //MessageBox.Show("Evento: paint");
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
      //MessageBox.Show("Evento: activated");
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
      MessageBox.Show("Evento: form closed");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      //MessageBox.Show("Evento: form closing");
      if (MessageBox.Show("Seguro?","Salir", MessageBoxButtons.YesNo) == DialogResult.No)
        e.Cancel = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      //FrmOwner owner = new FrmOwner();
      FrmPantalla2 pantalla2 = new FrmPantalla2();
      //FrmPantalla2 pantalla3 = new FrmPantalla2();
      //owner.Show();
      pantalla2.MdiParent = this;
      pantalla2.Show();
      //pantalla3.Show(owner);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      //this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
      //this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
      this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
      /*
      foreach(Control radio in GbrNacionalidad.Controls)
      {
        if(radio is RadioButton && ((RadioButton)radio).Checked)
        {
          MessageBox.Show(radio.Text);
        }
      }
      */

      string salida = "";
      foreach(Object item in this.LstListbox.SelectedItems)
      {
        salida += item;
      }
      MessageBox.Show(salida);

      //MessageBox.Show(this.ChkCasilla.Checked.ToString());
      //MessageBox.Show(this.Rbo1.Checked ? "Argentino":"Extranjero");
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
