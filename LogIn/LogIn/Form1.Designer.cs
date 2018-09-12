namespace LogIn
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
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cmbTelefono = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(116, 9);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(100, 16);
            this.lblIniciarSesion.TabIndex = 0;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(45, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(45, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(89, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 20);
            this.textBox5.TabIndex = 5;
            // 
            // cmbTelefono
            // 
            this.cmbTelefono.FormattingEnabled = true;
            this.cmbTelefono.Location = new System.Drawing.Point(45, 132);
            this.cmbTelefono.Name = "cmbTelefono";
            this.cmbTelefono.Size = new System.Drawing.Size(38, 21);
            this.cmbTelefono.TabIndex = 6;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(45, 159);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(90, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(141, 160);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(221, 160);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(67, 20);
            this.textBox7.TabIndex = 9;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(45, 186);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 10;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(45, 209);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 11;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(131, 245);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 12;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 280);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbTelefono);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIniciarSesion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblIniciarSesion;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.ComboBox cmbTelefono;
    private System.Windows.Forms.ComboBox cmbMes;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.RadioButton rbtMasculino;
    private System.Windows.Forms.RadioButton rbtFemenino;
    private System.Windows.Forms.Button btnContinuar;
  }
}

