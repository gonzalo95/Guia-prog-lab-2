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

namespace Hilos
{
    public partial class frmHilos : Form
    {
        private int[] numeros = { 0, 0, 0 };
        Thread hilo1;
        Thread hilo2;
        Thread hilo3;

        public frmHilos()
        {
            InitializeComponent();
            this.hilo1 = new Thread(new ParameterizedThreadStart(Aumentar));
            this.hilo2 = new Thread(new ParameterizedThreadStart(Aumentar));
            this.hilo3 = new Thread(new ParameterizedThreadStart(Aumentar));
        }

        private void frmHilos_Load(object sender, EventArgs e)
        {
            this.txtPrimero.Text = "0";
            this.txtSegundo.Text = "0";
            this.txtTercero.Text = "0";
        }

        private void Aumentar(object o)
        {
            int pos = (int)o;
            while (this.numeros[pos] < 10000)
            {
                this.numeros[pos] ++;
                Thread.Sleep(50);
                Mostrar(this.numeros[pos], pos);
            }
        }

        private void Mostrar(int n, int pos)
        {
            switch (pos)
            {
                case 0:
                    if (this.txtPrimero.InvokeRequired)
                    {
                        this.txtPrimero.BeginInvoke((MethodInvoker)delegate 
                        {
                            this.txtPrimero.Text = n.ToString();
                        }
                        );
                    }
                    break;

                case 1:
                    if (this.txtSegundo.InvokeRequired)
                    {
                        this.txtSegundo.BeginInvoke((MethodInvoker)delegate
                        {
                            this.txtSegundo.Text = n.ToString();
                        }
                        );
                    }
                    break;

                case 2:
                    if (this.txtTercero.InvokeRequired)
                    {
                        this.txtTercero.BeginInvoke((MethodInvoker)delegate
                        {
                            this.txtTercero.Text = n.ToString();
                        }
                        );
                    }
                    break;
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            hilo1.Abort();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            hilo2.Abort();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            hilo3.Abort();
        }

        private void frmHilos_Shown(object sender, EventArgs e)
        {
            hilo1.Start(0);
            hilo2.Start(1);
            hilo3.Start(2);
        }

        private void frmHilos_FormClosing(object sender, FormClosingEventArgs e)
        {
            hilo1.Abort();
            hilo2.Abort();
            hilo3.Abort();
        }
    }
}
