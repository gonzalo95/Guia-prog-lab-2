namespace Frm_Binario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBinarioADecimal = new System.Windows.Forms.Label();
            this.lblDecimalABinario = new System.Windows.Forms.Label();
            this.txtBinarioIngreso = new System.Windows.Forms.TextBox();
            this.txtDecimalIngreso = new System.Windows.Forms.TextBox();
            this.txtBinarioConvertido = new System.Windows.Forms.TextBox();
            this.txtDecimalConvertido = new System.Windows.Forms.TextBox();
            this.btmConvetADecimal = new System.Windows.Forms.Button();
            this.btmConvertABinario = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.Controls.Add(this.btmConvertABinario, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDecimalConvertido, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBinarioADecimal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDecimalABinario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBinarioIngreso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDecimalIngreso, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBinarioConvertido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btmConvetADecimal, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBinarioADecimal
            // 
            this.lblBinarioADecimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBinarioADecimal.AutoSize = true;
            this.lblBinarioADecimal.Location = new System.Drawing.Point(29, 19);
            this.lblBinarioADecimal.Name = "lblBinarioADecimal";
            this.lblBinarioADecimal.Size = new System.Drawing.Size(89, 13);
            this.lblBinarioADecimal.TabIndex = 1;
            this.lblBinarioADecimal.Text = "Binario a Decimal";
            // 
            // lblDecimalABinario
            // 
            this.lblDecimalABinario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDecimalABinario.AutoSize = true;
            this.lblDecimalABinario.Location = new System.Drawing.Point(29, 70);
            this.lblDecimalABinario.Name = "lblDecimalABinario";
            this.lblDecimalABinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalABinario.TabIndex = 2;
            this.lblDecimalABinario.Text = "Decimal a Binario";
            // 
            // txtBinarioIngreso
            // 
            this.txtBinarioIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBinarioIngreso.Location = new System.Drawing.Point(182, 15);
            this.txtBinarioIngreso.Name = "txtBinarioIngreso";
            this.txtBinarioIngreso.Size = new System.Drawing.Size(80, 20);
            this.txtBinarioIngreso.TabIndex = 3;
            // 
            // txtDecimalIngreso
            // 
            this.txtDecimalIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDecimalIngreso.Location = new System.Drawing.Point(185, 67);
            this.txtDecimalIngreso.Name = "txtDecimalIngreso";
            this.txtDecimalIngreso.Size = new System.Drawing.Size(73, 20);
            this.txtDecimalIngreso.TabIndex = 4;
            // 
            // txtBinarioConvertido
            // 
            this.txtBinarioConvertido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBinarioConvertido.Location = new System.Drawing.Point(482, 67);
            this.txtBinarioConvertido.Name = "txtBinarioConvertido";
            this.txtBinarioConvertido.ReadOnly = true;
            this.txtBinarioConvertido.Size = new System.Drawing.Size(73, 20);
            this.txtBinarioConvertido.TabIndex = 5;
            // 
            // txtDecimalConvertido
            // 
            this.txtDecimalConvertido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDecimalConvertido.Location = new System.Drawing.Point(484, 15);
            this.txtDecimalConvertido.Name = "txtDecimalConvertido";
            this.txtDecimalConvertido.ReadOnly = true;
            this.txtDecimalConvertido.Size = new System.Drawing.Size(69, 20);
            this.txtDecimalConvertido.TabIndex = 6;
            // 
            // btmConvetADecimal
            // 
            this.btmConvetADecimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmConvetADecimal.Location = new System.Drawing.Point(337, 14);
            this.btmConvetADecimal.Name = "btmConvetADecimal";
            this.btmConvetADecimal.Size = new System.Drawing.Size(75, 23);
            this.btmConvetADecimal.TabIndex = 7;
            this.btmConvetADecimal.Text = "->";
            this.btmConvetADecimal.UseVisualStyleBackColor = true;
            this.btmConvetADecimal.Click += new System.EventHandler(this.btmConvetADecimal_Click);
            // 
            // btmConvertABinario
            // 
            this.btmConvertABinario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmConvertABinario.Location = new System.Drawing.Point(337, 65);
            this.btmConvertABinario.Name = "btmConvertABinario";
            this.btmConvertABinario.Size = new System.Drawing.Size(75, 23);
            this.btmConvertABinario.TabIndex = 8;
            this.btmConvertABinario.Text = "->";
            this.btmConvertABinario.UseVisualStyleBackColor = true;
            this.btmConvertABinario.Click += new System.EventHandler(this.btmConvertABinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 151);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btmConvertABinario;
    private System.Windows.Forms.TextBox txtDecimalConvertido;
    private System.Windows.Forms.Label lblBinarioADecimal;
    private System.Windows.Forms.Label lblDecimalABinario;
    private System.Windows.Forms.TextBox txtBinarioIngreso;
    private System.Windows.Forms.TextBox txtDecimalIngreso;
    private System.Windows.Forms.TextBox txtBinarioConvertido;
    private System.Windows.Forms.Button btmConvetADecimal;
  }
}

