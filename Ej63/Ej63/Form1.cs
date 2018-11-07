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

namespace Ej63
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            while (true)
            {
                this.lblTimer.Text = (DateTime.Now).ToString();
                Thread.Sleep(1000);
            }
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            this.lblTimer.Text = (DateTime.Now).ToString();
        }
    }
}
