namespace MetodosDeExtencion
{
    partial class frmFormulario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.rtbAlumnos = new System.Windows.Forms.RichTextBox();
            this.lblCargando = new System.Windows.Forms.Label();
            this.pgbBarra = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(231, 60);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(231, 111);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(22, 28);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(47, 13);
            this.lblAlumnos.TabIndex = 2;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // rtbAlumnos
            // 
            this.rtbAlumnos.Location = new System.Drawing.Point(12, 44);
            this.rtbAlumnos.Name = "rtbAlumnos";
            this.rtbAlumnos.Size = new System.Drawing.Size(196, 172);
            this.rtbAlumnos.TabIndex = 3;
            this.rtbAlumnos.Text = "";
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Location = new System.Drawing.Point(22, 233);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(53, 13);
            this.lblCargando.TabIndex = 4;
            this.lblCargando.Text = "Cargando";
            // 
            // pgbBarra
            // 
            this.pgbBarra.Location = new System.Drawing.Point(12, 250);
            this.pgbBarra.Name = "pgbBarra";
            this.pgbBarra.Size = new System.Drawing.Size(331, 23);
            this.pgbBarra.TabIndex = 5;
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 285);
            this.Controls.Add(this.pgbBarra);
            this.Controls.Add(this.lblCargando);
            this.Controls.Add(this.rtbAlumnos);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmFormulario";
            this.Text = "Metodos de extension";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.RichTextBox rtbAlumnos;
        private System.Windows.Forms.Label lblCargando;
        private System.Windows.Forms.ProgressBar pgbBarra;
    }
}

