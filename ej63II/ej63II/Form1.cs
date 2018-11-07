using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej63II
{
    public partial class frmFormulario : Form
    {
        private Timer t;

        public frmFormulario()
        {
            InitializeComponent();
            this.t = new Timer();
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            this.lblTimer.Text = DateTime.Now.ToString();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            this.lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
