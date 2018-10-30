using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;

namespace Notepad
{
    public partial class frmFormulario : Form
    {
        private string path;
        private string tipo;

        public frmFormulario()
        {
            InitializeComponent();
        }

        private void guargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.tipo)
            {
                case "binario":
                    PuntoDat dat = new PuntoDat();
                    dat.Contenido = rtbEditor.Text;
                    dat.Guardar(path, dat);
                    break;
                case "texto":
                    PuntoTxt txt = new PuntoTxt();
                    txt.Guardar(path, rtbEditor.Text);
                    break;
                default:
                    break;
            }
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusCaracteres.Text = rtbEditor.Text.Length.ToString() + " caracteres";
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
                this.path = ofdAbrir.FileName;
            else
                return;
            PuntoDat archivo = new PuntoDat();
            archivo = archivo.Leer(path);
            rtbEditor.Text = archivo.Contenido;
            this.tipo = "binario";
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
                this.path = ofdAbrir.FileName;
            else
                return;
            PuntoTxt archivo = new PuntoTxt();
            rtbEditor.Text = archivo.Leer(path);
            this.tipo = "texto";
        }

        private void textoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sfdGuardar.Filter = "Archivo Texto|*.txt";
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
                this.path = sfdGuardar.FileName;
            else
                return;
            PuntoTxt archivo = new PuntoTxt();
            archivo.Guardar(path, rtbEditor.Text);
            this.tipo = "texto";
        }

        private void binarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sfdGuardar.Filter = "Archivo Datos|*.dat";
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
                this.path = sfdGuardar.FileName;
            else
                return;
            PuntoDat archivo = new PuntoDat();
            archivo.Contenido = rtbEditor.Text;
            archivo.Guardar(path, archivo);
            this.tipo = "binario";
        }
    }
}
