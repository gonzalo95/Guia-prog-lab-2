namespace Clase25
{
    partial class frmLlenar
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
            this.btnLlenar = new System.Windows.Forms.Button();
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(200, 135);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(97, 47);
            this.btnLlenar.TabIndex = 0;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // rtbTexto
            // 
            this.rtbTexto.Location = new System.Drawing.Point(12, 12);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(472, 96);
            this.rtbTexto.TabIndex = 1;
            this.rtbTexto.Text = "";
            // 
            // frmLlenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 207);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.btnLlenar);
            this.Name = "frmLlenar";
            this.Text = "Llenar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.RichTextBox rtbTexto;
    }
}