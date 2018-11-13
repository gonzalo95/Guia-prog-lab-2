namespace Clase25
{
    partial class frmDelegado
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
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(59, 72);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 68);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(285, 72);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 68);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // frmDelegado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 221);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Name = "frmDelegado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delegado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
    }
}

