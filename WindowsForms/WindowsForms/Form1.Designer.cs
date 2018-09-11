namespace WindowsForms
{
  partial class FrmPantalla1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ChkCasilla = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.GbrNacionalidad = new System.Windows.Forms.GroupBox();
            this.Rbo1 = new System.Windows.Forms.RadioButton();
            this.Rbo2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.LstListbox = new System.Windows.Forms.ListBox();
            this.LblEtiqueta = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CmbPais = new System.Windows.Forms.ComboBox();
            this.GbrNacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "boton\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ordenar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ChkCasilla
            // 
            this.ChkCasilla.AutoSize = true;
            this.ChkCasilla.Location = new System.Drawing.Point(365, 39);
            this.ChkCasilla.Name = "ChkCasilla";
            this.ChkCasilla.Size = new System.Drawing.Size(56, 17);
            this.ChkCasilla.TabIndex = 5;
            this.ChkCasilla.Text = "Casilla";
            this.ChkCasilla.UseVisualStyleBackColor = true;
            this.ChkCasilla.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Casilla";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GbrNacionalidad
            // 
            this.GbrNacionalidad.Controls.Add(this.Rbo2);
            this.GbrNacionalidad.Controls.Add(this.Rbo1);
            this.GbrNacionalidad.Location = new System.Drawing.Point(64, 26);
            this.GbrNacionalidad.Name = "GbrNacionalidad";
            this.GbrNacionalidad.Size = new System.Drawing.Size(126, 100);
            this.GbrNacionalidad.TabIndex = 7;
            this.GbrNacionalidad.TabStop = false;
            this.GbrNacionalidad.Text = "Nacionalidad";
            // 
            // Rbo1
            // 
            this.Rbo1.AutoSize = true;
            this.Rbo1.Location = new System.Drawing.Point(6, 31);
            this.Rbo1.Name = "Rbo1";
            this.Rbo1.Size = new System.Drawing.Size(70, 17);
            this.Rbo1.TabIndex = 0;
            this.Rbo1.TabStop = true;
            this.Rbo1.Text = "Argentino";
            this.Rbo1.UseVisualStyleBackColor = true;
            // 
            // Rbo2
            // 
            this.Rbo2.AutoSize = true;
            this.Rbo2.Location = new System.Drawing.Point(6, 54);
            this.Rbo2.Name = "Rbo2";
            this.Rbo2.Size = new System.Drawing.Size(72, 17);
            this.Rbo2.TabIndex = 1;
            this.Rbo2.TabStop = true;
            this.Rbo2.Text = "Extranjero";
            this.Rbo2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(64, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Argentino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 155);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Extranjero";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // LstListbox
            // 
            this.LstListbox.FormattingEnabled = true;
            this.LstListbox.Items.AddRange(new object[] {
            "Hola",
            "Mundo",
            "c#",
            "!"});
            this.LstListbox.Location = new System.Drawing.Point(211, 26);
            this.LstListbox.Name = "LstListbox";
            this.LstListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LstListbox.Size = new System.Drawing.Size(120, 95);
            this.LstListbox.TabIndex = 10;
            // 
            // LblEtiqueta
            // 
            this.LblEtiqueta.AutoSize = true;
            this.LblEtiqueta.Location = new System.Drawing.Point(208, 136);
            this.LblEtiqueta.Name = "LblEtiqueta";
            this.LblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.LblEtiqueta.TabIndex = 11;
            this.LblEtiqueta.Text = "Etiqueta";
            this.LblEtiqueta.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(274, 133);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(122, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // CmbPais
            // 
            this.CmbPais.FormattingEnabled = true;
            this.CmbPais.Items.AddRange(new object[] {
            "Argentina",
            "Uruguay",
            "Ecuador",
            "Venezuela"});
            this.CmbPais.Location = new System.Drawing.Point(274, 159);
            this.CmbPais.Name = "CmbPais";
            this.CmbPais.Size = new System.Drawing.Size(122, 21);
            this.CmbPais.TabIndex = 13;
            // 
            // FrmPantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 300);
            this.Controls.Add(this.CmbPais);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEtiqueta);
            this.Controls.Add(this.LstListbox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.GbrNacionalidad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ChkCasilla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.IsMdiContainer = true;
            this.Name = "FrmPantalla1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.GbrNacionalidad.ResumeLayout(false);
            this.GbrNacionalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.CheckBox ChkCasilla;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.GroupBox GbrNacionalidad;
    private System.Windows.Forms.RadioButton Rbo2;
    private System.Windows.Forms.RadioButton Rbo1;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.ListBox LstListbox;
    private System.Windows.Forms.Label LblEtiqueta;
    private System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.ComboBox CmbPais;
  }
}

