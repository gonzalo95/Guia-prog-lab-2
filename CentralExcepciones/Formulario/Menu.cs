using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class frmMenu : Form
    {
        private Centralita central;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.central = new Centralita();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador(this.central);
            llamador.ShowDialog();

            if(llamador.DialogResult == DialogResult.OK)
            {
                this.central = llamador.Central;
            }
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(central);
            mostrar.Tipo = Llamada.TipoLlamada.Todas;
            mostrar.Show();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(central);
            mostrar.Tipo = Llamada.TipoLlamada.Local;
            mostrar.Show();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(central);
            mostrar.Tipo = Llamada.TipoLlamada.Provincial;
            mostrar.Show();
        }
    }
}
