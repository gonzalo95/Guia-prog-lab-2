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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EPuestoJerarquico puesto;
            Enum.TryParse<EPuestoJerarquico>(cmbPuesto.SelectedValue.ToString(), out puesto);
            Empleado empleado = new Empleado(txtNombre.Text, txtApellido.Text, mtxtLegajo.Text, puesto, Convert.ToInt32(mtxtSalario.Text));
            
        }

        private void tbnEmpresa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
