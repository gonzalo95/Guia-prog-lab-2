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
        Random x;
        Random y;

        public frmFormulario()
        {
            InitializeComponent();
            this.hiloCronometro = new Thread(ActualizarCronometro);
            this.hiloMovimiento = new Thread(new ParameterizedThreadStart(MoverCuadrado));
            this.x = new Random();
            this.y = new Random();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.pbxCuadrado.Visible = true;
            hiloMovimiento.Start();
            hiloCronometro.Start();
        }

        private void pbxCuadrado_Click(object sender, EventArgs e)
        {
            this.hiloMovimiento.Abort();
            this.hiloCronometro.Abort();
        }

        private void MoverCuadrado(object o)
        {
            while (true)
            {
                this.pbxCuadrado.Top = this.y.Next(0, 300);
                this.pbxCuadrado.Left = this.x.Next(0, 500);
                Thread.Sleep(500);
            }
        }

        private void ActualizarCronometro()
        {
            while (true)
            {
                if (this.lblCronometro.InvokeRequired)
                {
                    this.lblCronometro.BeginInvoke((MethodInvoker)delegate
                    {
                        this.lblCronometro.Text = (Convert.ToInt32(this.lblCronometro.Text) + 1).ToString();
                    }
                    );
                }
                else
                {
                    this.lblCronometro.Text = (Convert.ToInt32(this.lblCronometro.Text) + 1).ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void frmFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.hiloCronometro.Abort();
            this.hiloMovimiento.Abort();
        }

        private void pbxCuadrado_MouseDown(object sender, MouseEventArgs e)
        {
            this.hiloMovimiento.Abort();
            this.hiloCronometro.Abort();
        }
    }
}
