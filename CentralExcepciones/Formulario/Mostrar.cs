using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class frmMostrar : Form
    {
        Centralita central;
        Llamada.TipoLlamada tipo;
        public frmMostrar(Centralita c)
        {
            InitializeComponent();
            this.central = c;
        }

        public Llamada.TipoLlamada Tipo
        {
            set
            {
                this.tipo = value;
            }
        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {
            //foreach (Llamada l in central.Llamadas)
            //{
            //    switch (tipo)
            //    {
            //        case Llamada.TipoLlamada.Local:
            //            if (l is Local)
            //                this.rtbMostrar.Text += l.ToString();
            //            break;
            //        case Llamada.TipoLlamada.Provincial:
            //            if (l is Provincial)
            //                this.rtbMostrar.Text += l.ToString();
            //            break;
            //        case Llamada.TipoLlamada.Todas:
            //            this.rtbMostrar.Text += l.ToString();
            //            break;
            //        default:
            //            break;
            //    }
            //}

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    this.rtbMostrar.Text += central.GananciaPorLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    this.rtbMostrar.Text += central.GananciaPorProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    this.rtbMostrar.Text += central.GananciaTotal;
                    break;
                default:
                    break;
            }
        }
    }
}
