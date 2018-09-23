namespace ContadorDePalabras
{
    partial class frmContadorDePalabras
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
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Location = new System.Drawing.Point(35, 60);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(370, 270);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(67, 362);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(277, 40);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmContadorDePalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 431);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtxtTexto);
            this.Name = "frmContadorDePalabras";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTexto;
        private System.Windows.Forms.Button btnCalcular;
    }
}

