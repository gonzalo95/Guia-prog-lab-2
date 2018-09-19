namespace Clase8
{
    partial class frmEmpresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtGanancias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(124, 192);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(156, 38);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(124, 46);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(156, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 46);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.lblRazonSocial.TabIndex = 2;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 88);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(12, 131);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(58, 13);
            this.lblGanancias.TabIndex = 4;
            this.lblGanancias.Text = "Ganancias";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 88);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(156, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtGanancias
            // 
            this.txtGanancias.Location = new System.Drawing.Point(124, 128);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.Size = new System.Drawing.Size(156, 20);
            this.txtGanancias.TabIndex = 6;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 264);
            this.Controls.Add(this.txtGanancias);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmEmpresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtGanancias;
    }
}