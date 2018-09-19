using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblotecaEmpleado;
using BibliotecaEmpresa;

namespace Clase8
{
    public partial class frmClase8 : Form
    {
        private Empresa empresa;
        public frmClase8()
        {
          InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                    c.Text = "";
            }
        }

        private void frmClase8_Load(object sender, EventArgs e)
        {
            /*
            foreach(EPuestoJerarquico puesto in Enum.GetValues(typeof(EPuestoJerarquico)))
            {
                cmbPuesto.Items.Add(puesto);
            }
            */
            cmbPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
            btnEmpresa_Click(sender, e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EPuestoJerarquico puesto;
            Enum.TryParse<EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto);
            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, GetSalario(mtxtSalario.Text));
            if(this.empresa + empleado)
                rtxtConsola.Text = this.empresa.MostarEmpresa();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa pantallaEmpresa = new frmEmpresa(this.empresa);
            pantallaEmpresa.ShowDialog();
            if (pantallaEmpresa.DialogResult == DialogResult.OK)
                this.empresa = pantallaEmpresa.empresa;
        }

        private int GetSalario(string cadena)
        {
            int salario;
            StringBuilder sb = new StringBuilder();

            foreach(char c in cadena)
            {
                if (char.IsDigit(c))
                    sb.Append(c);
            }

            salario = int.Parse(sb.ToString());

            return salario;
        }
    }
}
