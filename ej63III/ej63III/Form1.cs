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

namespace ej63III
{
    public partial class frmFormulario : Form
    {
        private Thread hilo;

        public frmFormulario()
        {
            InitializeComponent();
            this.hilo = new Thread(Actualizar);
        }

        private void Actualizar()
        {
            if (this.lblTimer.InvokeRequired)
            {
                this.lblTimer.BeginInvoke((MethodInvoker)delegate
                {
                    while (true)
                    {
                        this.lblTimer.Text = DateTime.Now.ToString();
                        Thread.Sleep(1000);
                    }
                }
                );
            }
            else
            {
                while (true)
                {
                    this.lblTimer.Text = DateTime.Now.ToString();
                    Thread.Sleep(1000);
                }
            }
        }

        private void frmFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.hilo.Abort();
        }

        private void frmFormulario_Shown(object sender, EventArgs e)
        {
            this.hilo.Start();
        }
    }
}
