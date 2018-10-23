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
    public partial class frmLlamador : Form
    {
        private Centralita central;

        public frmLlamador(Centralita c)
        {
            InitializeComponent();
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.central = c;
        }

        public Centralita Central
        {
            get
            {
                return this.central;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtDestino.Text = "Nro Destino";
            this.cmbFranja.Enabled = false;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if(this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnUno.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnUno.Text;
            }
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnDos.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnDos.Text;
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnTres.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnTres.Text;
            }
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnCuatro.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnCuatro.Text;
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnCinco.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnCinco.Text;
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnSeis.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnSeis.Text;
            }
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnSiete.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnSiete.Text;
            }
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnOcho.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnOcho.Text;
            }
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnNueve.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnNueve.Text;
            }
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnCero.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnCero.Text;
            }
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnAsterisco.Text;
            }
            else
            {
                this.txtDestino.Text += this.btnAsterisco.Text;
            }
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (this.txtDestino.Text == "Nro Destino")
            {
                this.txtDestino.Text = this.btnNumeral.Text;
                this.cmbFranja.Enabled = true;
            }
            else
            {
                this.txtDestino.Text += this.btnNumeral.Text;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random();

            try
            {
                if (this.txtDestino.Text.First() == '#')
                {
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                    Provincial provincial = new Provincial(this.txtOrigen.Text, franjas, (float)duracion.Next(1, 50), this.txtDestino.Text);
                    this.central += provincial;
                }
                else
                {
                    Random costo = new Random();
                    Local local = new Local(this.txtOrigen.Text, (float)duracion.Next(1, 50), this.txtDestino.Text, (float)costo.Next(1, 5));
                    this.central += local;
                }
            }
            catch(CentralitaException exc)
            {
                MessageBox.Show("Error", "La llamada ya se encontraba registrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLlamador_Load(object sender, EventArgs e)
        {

        }
    }
}
