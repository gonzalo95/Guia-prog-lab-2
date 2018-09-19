using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEmpresa;

namespace Clase8
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                Empresa empresa = new Empresa(txtRazonSocial.Text, txtDireccion.Text, float.Parse(txtGanancias.Text));
                this.Close();
            }
            else
                MessageBox.Show("Complete los datos para continuar");
            
        }

        private bool ValidarEntradas()
        {
            bool salida = true;
            foreach(Control c in this.Controls)
            {
                if (c is TextBox && c.Text == "")
                {
                    salida = false;
                    break;
                }
            }
            return salida;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            
        }
    }
}
