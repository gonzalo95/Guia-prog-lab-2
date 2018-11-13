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
    public partial class frmDelegado : Form
    {
        public frmDelegado()
        {
            InitializeComponent();
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            frmLlenar llenar = new frmLlenar();
            llenar.Owner = this;
            foreach (Form frm in this.OwnedForms)
            {
                if (frm is frmTexto)
                    llenar.TextoIngresado += ((frmTexto)frm).ControladorEvento;
            }
            btnDos_Click(sender, e);
            llenar.Show(this);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            frmTexto texto = new frmTexto();
            texto.Owner = this;
            foreach (Form frm in this.OwnedForms)
            {
                if (frm is frmLlenar)
                    ((frmLlenar)frm).TextoIngresado += texto.ControladorEvento;
            }
            texto.Show(this);
        }
    }
}
