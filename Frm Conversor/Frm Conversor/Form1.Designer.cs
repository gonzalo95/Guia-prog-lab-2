namespace Frm_Conversor
{
    partial class Form1
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
            this.btnConvertDolar = new System.Windows.Forms.Button();
            this.btnConvertEuro = new System.Windows.Forms.Button();
            this.lblEuroFil = new System.Windows.Forms.Label();
            this.LblDolarFil = new System.Windows.Forms.Label();
            this.lblPesosFil = new System.Windows.Forms.Label();
            this.lblEuroCol = new System.Windows.Forms.Label();
            this.lblDolarCol = new System.Windows.Forms.Label();
            this.lblPesosCol = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConvertPesos = new System.Windows.Forms.Button();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertDolar
            // 
            this.btnConvertDolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvertDolar.Location = new System.Drawing.Point(178, 80);
            this.btnConvertDolar.Name = "btnConvertDolar";
            this.btnConvertDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertDolar.TabIndex = 1;
            this.btnConvertDolar.Text = "->";
            this.btnConvertDolar.UseVisualStyleBackColor = true;
            this.btnConvertDolar.Click += new System.EventHandler(this.btnConvertDolar_Click);
            // 
            // btnConvertEuro
            // 
            this.btnConvertEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvertEuro.Location = new System.Drawing.Point(178, 40);
            this.btnConvertEuro.Name = "btnConvertEuro";
            this.btnConvertEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertEuro.TabIndex = 2;
            this.btnConvertEuro.Text = "->";
            this.btnConvertEuro.UseVisualStyleBackColor = true;
            this.btnConvertEuro.Click += new System.EventHandler(this.btnConvertEuro_Click);
            // 
            // lblEuroFil
            // 
            this.lblEuroFil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEuroFil.AutoSize = true;
            this.lblEuroFil.Location = new System.Drawing.Point(27, 45);
            this.lblEuroFil.Name = "lblEuroFil";
            this.lblEuroFil.Size = new System.Drawing.Size(29, 13);
            this.lblEuroFil.TabIndex = 3;
            this.lblEuroFil.Text = "Euro";
            this.lblEuroFil.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblDolarFil
            // 
            this.LblDolarFil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDolarFil.AutoSize = true;
            this.LblDolarFil.Location = new System.Drawing.Point(25, 85);
            this.LblDolarFil.Name = "LblDolarFil";
            this.LblDolarFil.Size = new System.Drawing.Size(32, 13);
            this.LblDolarFil.TabIndex = 4;
            this.LblDolarFil.Text = "Dólar";
            // 
            // lblPesosFil
            // 
            this.lblPesosFil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesosFil.AutoSize = true;
            this.lblPesosFil.Location = new System.Drawing.Point(23, 129);
            this.lblPesosFil.Name = "lblPesosFil";
            this.lblPesosFil.Size = new System.Drawing.Size(36, 13);
            this.lblPesosFil.TabIndex = 5;
            this.lblPesosFil.Text = "Pesos";
            this.lblPesosFil.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEuroCol
            // 
            this.lblEuroCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEuroCol.AutoSize = true;
            this.lblEuroCol.Location = new System.Drawing.Point(319, 9);
            this.lblEuroCol.Name = "lblEuroCol";
            this.lblEuroCol.Size = new System.Drawing.Size(29, 13);
            this.lblEuroCol.TabIndex = 6;
            this.lblEuroCol.Text = "Euro";
            // 
            // lblDolarCol
            // 
            this.lblDolarCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDolarCol.AutoSize = true;
            this.lblDolarCol.Location = new System.Drawing.Point(435, 9);
            this.lblDolarCol.Name = "lblDolarCol";
            this.lblDolarCol.Size = new System.Drawing.Size(32, 13);
            this.lblDolarCol.TabIndex = 7;
            this.lblDolarCol.Text = "Dólar";
            // 
            // lblPesosCol
            // 
            this.lblPesosCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPesosCol.AutoSize = true;
            this.lblPesosCol.Location = new System.Drawing.Point(544, 9);
            this.lblPesosCol.Name = "lblPesosCol";
            this.lblPesosCol.Size = new System.Drawing.Size(36, 13);
            this.lblPesosCol.TabIndex = 8;
            this.lblPesosCol.Text = "Pesos";
            // 
            // txtPesos
            // 
            this.txtPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesos.Location = new System.Drawing.Point(92, 125);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(61, 20);
            this.txtPesos.TabIndex = 9;
            // 
            // txtEuro
            // 
            this.txtEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEuro.Location = new System.Drawing.Point(92, 42);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(61, 20);
            this.txtEuro.TabIndex = 10;
            // 
            // txtDolar
            // 
            this.txtDolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDolar.Location = new System.Drawing.Point(92, 81);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(61, 20);
            this.txtDolar.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.07143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.92857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.lblPesosCol, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConvertPesos, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnConvertDolar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnConvertEuro, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPesos, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDolar, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtEuro, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPesosFil, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblDolarFil, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEuroFil, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEuroAEuro, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDolarAEuro, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPesosAEuro, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEuroADolar, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEuroAPesos, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDolarADolar, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDolarAPesos, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPesosADolar, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPesosAPesos, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDolarCol, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEuroCol, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 161);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnConvertPesos
            // 
            this.btnConvertPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvertPesos.Location = new System.Drawing.Point(178, 124);
            this.btnConvertPesos.Name = "btnConvertPesos";
            this.btnConvertPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertPesos.TabIndex = 12;
            this.btnConvertPesos.Text = "->";
            this.btnConvertPesos.UseVisualStyleBackColor = true;
            this.btnConvertPesos.Click += new System.EventHandler(this.btnConvertPesos_Click);
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEuroAEuro.Location = new System.Drawing.Point(291, 42);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(84, 20);
            this.txtEuroAEuro.TabIndex = 13;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDolarAEuro.Location = new System.Drawing.Point(291, 81);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(84, 20);
            this.txtDolarAEuro.TabIndex = 14;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesosAEuro.Location = new System.Drawing.Point(291, 125);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.ReadOnly = true;
            this.txtPesosAEuro.Size = new System.Drawing.Size(84, 20);
            this.txtPesosAEuro.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEuroADolar.Location = new System.Drawing.Point(409, 42);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(84, 20);
            this.txtEuroADolar.TabIndex = 16;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEuroAPesos.Location = new System.Drawing.Point(520, 42);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.ReadOnly = true;
            this.txtEuroAPesos.Size = new System.Drawing.Size(84, 20);
            this.txtEuroAPesos.TabIndex = 17;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDolarADolar.Location = new System.Drawing.Point(409, 81);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(84, 20);
            this.txtDolarADolar.TabIndex = 18;
            this.txtDolarADolar.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDolarAPesos.Location = new System.Drawing.Point(520, 81);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.ReadOnly = true;
            this.txtDolarAPesos.Size = new System.Drawing.Size(84, 20);
            this.txtDolarAPesos.TabIndex = 19;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesosADolar.Location = new System.Drawing.Point(409, 125);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.ReadOnly = true;
            this.txtPesosADolar.Size = new System.Drawing.Size(84, 20);
            this.txtPesosADolar.TabIndex = 20;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesosAPesos.Location = new System.Drawing.Point(520, 125);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.ReadOnly = true;
            this.txtPesosAPesos.Size = new System.Drawing.Size(84, 20);
            this.txtPesosAPesos.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConvertDolar;
        private System.Windows.Forms.Button btnConvertEuro;
        private System.Windows.Forms.Label lblEuroFil;
        private System.Windows.Forms.Label LblDolarFil;
        private System.Windows.Forms.Label lblPesosFil;
        private System.Windows.Forms.Label lblEuroCol;
        private System.Windows.Forms.Label lblDolarCol;
        private System.Windows.Forms.Label lblPesosCol;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConvertPesos;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesosAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAPesos;
    }
}

