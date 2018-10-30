namespace Notepad
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
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.mstMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbrirBinario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbrirTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBinarioGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTextoGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            this.mstMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbEditor
            // 
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Location = new System.Drawing.Point(0, 24);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(497, 248);
            this.rtbEditor.TabIndex = 0;
            this.rtbEditor.Text = "";
            this.rtbEditor.TextChanged += new System.EventHandler(this.rtbEditor_TextChanged);
            // 
            // mstMenu
            // 
            this.mstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mstMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMenu.Name = "mstMenu";
            this.mstMenu.Size = new System.Drawing.Size(497, 24);
            this.mstMenu.TabIndex = 1;
            this.mstMenu.Text = "Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbrir,
            this.tsmiGuardar,
            this.tsmiGuardarComo});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmiAbrir
            // 
            this.tsmiAbrir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbrirBinario,
            this.tsmiAbrirTexto});
            this.tsmiAbrir.Name = "tsmiAbrir";
            this.tsmiAbrir.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbrir.Text = "Abrir";
            // 
            // tsmiAbrirBinario
            // 
            this.tsmiAbrirBinario.Name = "tsmiAbrirBinario";
            this.tsmiAbrirBinario.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbrirBinario.Text = "Binario";
            this.tsmiAbrirBinario.Click += new System.EventHandler(this.binarioToolStripMenuItem_Click);
            // 
            // tsmiAbrirTexto
            // 
            this.tsmiAbrirTexto.Name = "tsmiAbrirTexto";
            this.tsmiAbrirTexto.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbrirTexto.Text = "Texto";
            this.tsmiAbrirTexto.Click += new System.EventHandler(this.textoToolStripMenuItem_Click);
            // 
            // tsmiGuardar
            // 
            this.tsmiGuardar.Name = "tsmiGuardar";
            this.tsmiGuardar.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardar.Text = "Guargar";
            this.tsmiGuardar.Click += new System.EventHandler(this.guargarToolStripMenuItem_Click);
            // 
            // tsmiGuardarComo
            // 
            this.tsmiGuardarComo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBinarioGuardarComo,
            this.tsmiTextoGuardarComo});
            this.tsmiGuardarComo.Name = "tsmiGuardarComo";
            this.tsmiGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardarComo.Text = "Guardar como...";
            // 
            // tsmiBinarioGuardarComo
            // 
            this.tsmiBinarioGuardarComo.Name = "tsmiBinarioGuardarComo";
            this.tsmiBinarioGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.tsmiBinarioGuardarComo.Text = "Binario";
            this.tsmiBinarioGuardarComo.Click += new System.EventHandler(this.binarioToolStripMenuItem1_Click);
            // 
            // tsmiTextoGuardarComo
            // 
            this.tsmiTextoGuardarComo.Name = "tsmiTextoGuardarComo";
            this.tsmiTextoGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.tsmiTextoGuardarComo.Text = "Texto";
            this.tsmiTextoGuardarComo.Click += new System.EventHandler(this.textoToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCaracteres});
            this.statusStrip1.Location = new System.Drawing.Point(0, 250);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(497, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCaracteres
            // 
            this.toolStripStatusCaracteres.Name = "toolStripStatusCaracteres";
            this.toolStripStatusCaracteres.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusCaracteres.Text = " ";
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.FileName = "openFileDialog1";
            // 
            // frmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 272);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.mstMenu);
            this.MainMenuStrip = this.mstMenu;
            this.Name = "frmFormulario";
            this.Text = "Ejercicio 56";
            this.mstMenu.ResumeLayout(false);
            this.mstMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.MenuStrip mstMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardarComo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCaracteres;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbrirBinario;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbrirTexto;
        private System.Windows.Forms.ToolStripMenuItem tsmiBinarioGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextoGuardarComo;
    }
}

