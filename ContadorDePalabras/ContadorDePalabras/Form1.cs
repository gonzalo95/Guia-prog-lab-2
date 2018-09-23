using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorDePalabras
{
    public partial class frmContadorDePalabras : Form
    {
        public frmContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string input = rtxtTexto.Text;

            foreach(string palabra in input.Split(' '))
            {
                if (dic.ContainsKey(palabra))
                    dic[palabra] += 1;

                else
                    dic[palabra] = 1;
            }

            List<string> lista = dic.Keys.ToList();
            lista.OrderByDescending(x => dic[x]);

            MessageBox.Show(lista[0]);

        }
    }
}
