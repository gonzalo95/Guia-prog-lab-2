namespace Hilos2
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
            this.pbxCuadrado = new System.Windows.Forms.PictureBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCuadrado
            // 
            this.pbxCuadrado.BackColor = System.Drawing.Color.Red;
            this.pbxCuadrado.Location = new System.Drawing.Point(250, 73);
            this.pbxCuadrado.Name = "pbxCuadrado";
            this.pbxCuadrado.Size = new System.Drawing.Size(47, 42);
            this.pbxCuadrado.TabIndex = 0;
            this.pbxCuadrado.TabStop = false;
            this.pbxCuadrado.Visible = false;
            this.pbxCuadrado.Click += new System.EventHandler(this.pbxCuadrado_Click);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(247, 9);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(13, 13);
            this.lblTiempo.TabIndex = 1;
            this.lblTiempo.Text = "0";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(235, 244);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 279);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pbxCuadrado);
            this.Name = "frmFormulario";
            this.Text = "Cuadrado rojo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCuadrado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnComenzar;
    }
}

