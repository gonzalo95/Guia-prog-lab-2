using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase25
{
    public delegate void LlenarDelegado(string texto);

    public partial class frmLlenar : Form
    {
        public frmLlenar()
        {
            InitializeComponent();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            TextoIngresado.Invoke(this.rtbTexto.Text);
        }

        public event LlenarDelegado TextoIngresado;
    }
}
