namespace Hilos
{
    partial class frmHilos
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
            this.txtPrimero = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.txtTercero = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimero
            // 
            this.txtPrimero.Location = new System.Drawing.Point(36, 103);
            this.txtPrimero.Name = "txtPrimero";
            this.txtPrimero.Size = new System.Drawing.Size(120, 20);
            this.txtPrimero.TabIndex = 0;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(192, 103);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(120, 20);
            this.txtSegundo.TabIndex = 1;
            // 
            // txtTercero
            // 
            this.txtTercero.Location = new System.Drawing.Point(361, 103);
            this.txtTercero.Name = "txtTercero";
            this.txtTercero.Size = new System.Drawing.Size(120, 20);
            this.txtTercero.TabIndex = 2;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(48, 179);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.Text = "Parar";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Location = new System.Drawing.Point(214, 179);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(75, 23);
            this.btnSegundo.TabIndex = 4;
            this.btnSegundo.Text = "Parar";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Location = new System.Drawing.Point(380, 179);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(75, 23);
            this.btnTercero.TabIndex = 5;
            this.btnTercero.Text = "Parar";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // frmHilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 282);
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtTercero);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtPrimero);
            this.Name = "frmHilos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hilos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHilos_FormClosing);
            this.Load += new System.EventHandler(this.frmHilos_Load);
            this.Shown += new System.EventHandler(this.frmHilos_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimero;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.TextBox txtTercero;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnTercero;
    }
}

