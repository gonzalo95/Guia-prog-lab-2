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
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
        }

        public void ControladorEvento(string texto)
        {
            this.rtbTexto.Text = texto;
        }
    }
}
