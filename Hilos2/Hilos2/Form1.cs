using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hilos2
{
    public partial class frmFormulario : Form
    {
        Thread hiloCronometro;
        Thread hiloMovimiento;


        public frmFormulario()
        {
            InitializeComponent();
            this.hiloCronometro = new Thread();
            this.hiloMovimiento = new Thread(ParameterizedThreadStart());
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.pbxCuadrado.Visible = true;
        }

        private void pbxCuadrado_Click(object sender, EventArgs e)
        {
            this.hiloMovimiento.Abort();
        }

        private void MoverCuadrado(object o)
        {

        }
    }
}
