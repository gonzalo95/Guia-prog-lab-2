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

namespace Greco.Gonzalo
{
    public partial class frmVista : Form
    {
        private Curso curso;
        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones)); 
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            if(ValidarCamposCurso())
            {
                Profesor profesor = new Profesor(txtNombreProfe.Text, txtApellidoProfe.Text, txtDocumentoProfe.Text, stpFechaIngreso.Value);
                Divisiones division;

                Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
                this.curso = new Curso((short)nudAnioCurso.Value, division, profesor);
            }

            else
                MessageBox.Show("Complete los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidarCamposCurso()
        {
            bool salida = true;

            if (txtNombreProfe.Text == "" || txtDocumentoProfe.Text == "" || txtApellidoProfe.Text == "")
                salida = false;

            return salida;
        }

        private bool ValidarCamposAlumno()
        {
            bool salida = true;

            if (txtNombre.Text == "" || txtDocumento.Text == "" || txtApellido.Text == "")
                salida = false;

            return salida;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!(this.curso is null))
                rtbDatos.Text = (string)curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposAlumno() && !(this.curso is null))
            {
                Divisiones division;
                Enum.TryParse<Divisiones>(cmbDivision.SelectedValue.ToString(), out division);
                Alumno alumno = new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, (short)nudAnio.Value, division);
                this.curso += alumno;
            }

            else
                MessageBox.Show("Cree un curso y cumplete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
