using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosDeExtencion
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.ShowDialog();
        }
    }
}
