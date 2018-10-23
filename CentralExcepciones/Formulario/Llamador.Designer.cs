namespace Formulario
{
    partial class frmLlamador
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gpbPanel = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.gpbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(24, 29);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(408, 32);
            this.txtDestino.TabIndex = 0;
            this.txtDestino.Text = "Nro Destino";
            // 
            // btnLlamar
            // 
            this.btnLlamar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLlamar.Location = new System.Drawing.Point(284, 98);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(129, 23);
            this.btnLlamar.TabIndex = 1;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(284, 153);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(284, 218);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(129, 20);
            this.txtOrigen.TabIndex = 3;
            this.txtOrigen.Text = "Nro Origen";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(284, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbFranja
            // 
            this.cmbFranja.Enabled = false;
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(24, 341);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(408, 21);
            this.cmbFranja.TabIndex = 5;
            this.cmbFranja.Text = "Franja";
            // 
            // gpbPanel
            // 
            this.gpbPanel.Controls.Add(this.btnNumeral);
            this.gpbPanel.Controls.Add(this.btnCero);
            this.gpbPanel.Controls.Add(this.btnAsterisco);
            this.gpbPanel.Controls.Add(this.btnNueve);
            this.gpbPanel.Controls.Add(this.btnOcho);
            this.gpbPanel.Controls.Add(this.btnSiete);
            this.gpbPanel.Controls.Add(this.btnSeis);
            this.gpbPanel.Controls.Add(this.btnCinco);
            this.gpbPanel.Controls.Add(this.btnCuatro);
            this.gpbPanel.Controls.Add(this.btnTres);
            this.gpbPanel.Controls.Add(this.btnDos);
            this.gpbPanel.Controls.Add(this.btnUno);
            this.gpbPanel.Location = new System.Drawing.Point(55, 98);
            this.gpbPanel.Name = "gpbPanel";
            this.gpbPanel.Size = new System.Drawing.Size(160, 198);
            this.gpbPanel.TabIndex = 6;
            this.gpbPanel.TabStop = false;
            this.gpbPanel.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(107, 146);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(46, 36);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btnCero
            // 
            this.btnCero.Location = new System.Drawing.Point(55, 146);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(46, 36);
            this.btnCero.TabIndex = 10;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.btnCero_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(3, 146);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(46, 36);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(107, 104);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(46, 36);
            this.btnNueve.TabIndex = 8;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(55, 104);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(46, 36);
            this.btnOcho.TabIndex = 7;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(3, 104);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(46, 36);
            this.btnSiete.TabIndex = 6;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(107, 58);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(46, 36);
            this.btnSeis.TabIndex = 5;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(55, 58);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(46, 36);
            this.btnCinco.TabIndex = 4;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(3, 58);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(46, 36);
            this.btnCuatro.TabIndex = 3;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(107, 16);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(46, 36);
            this.btnTres.TabIndex = 2;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(55, 16);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(46, 36);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(3, 16);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(46, 36);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // frmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 471);
            this.Controls.Add(this.gpbPanel);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.txtDestino);
            this.Name = "frmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.Load += new System.EventHandler(this.frmLlamador_Load);
            this.gpbPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbFranja;
        private System.Windows.Forms.GroupBox gpbPanel;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
    }
}