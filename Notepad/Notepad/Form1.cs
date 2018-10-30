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

namespace Notepad
{
    public partial class frmFormulario : Form
    {
        string path;

        public frmFormulario()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
                this.path = ofdAbrir.FileName;
            else
                return;
            StreamReader lector = new StreamReader(this.path);
            rtbEditor.Text = lector.ReadToEnd();
            lector.Close();
        }

        private void guargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter escritor = new StreamWriter(this.path);
            escritor.Write(rtbEditor.Text);
            escritor.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
                this.path = sfdGuardar.FileName;
            else
                return;
            StreamWriter escritor = new StreamWriter(this.path);
            escritor.Write(rtbEditor.Text);
            escritor.Close();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusCaracteres.Text = rtbEditor.Text.Length.ToString() + " caracteres";
        }
    }
}
