namespace WindowsFormsApp2
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConvertir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIndiceMasaCorporal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCalcularNota = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSimuladorBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConvertir,
            this.tsmIndiceMasaCorporal,
            this.tsmCalcularNota,
            this.tsmSimuladorBanco});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // tsmConvertir
            // 
            this.tsmConvertir.Name = "tsmConvertir";
            this.tsmConvertir.Size = new System.Drawing.Size(180, 22);
            this.tsmConvertir.Text = "Ventana 1";
            this.tsmConvertir.Click += new System.EventHandler(this.tsmConvertir_Click);
            // 
            // tsmIndiceMasaCorporal
            // 
            this.tsmIndiceMasaCorporal.Name = "tsmIndiceMasaCorporal";
            this.tsmIndiceMasaCorporal.Size = new System.Drawing.Size(180, 22);
            this.tsmIndiceMasaCorporal.Text = "V&entana 2";
            this.tsmIndiceMasaCorporal.Click += new System.EventHandler(this.tsmIndiceMasaCorporal_Click);
            // 
            // tsmCalcularNota
            // 
            this.tsmCalcularNota.Name = "tsmCalcularNota";
            this.tsmCalcularNota.Size = new System.Drawing.Size(180, 22);
            this.tsmCalcularNota.Text = "Ventana 3";
            this.tsmCalcularNota.Click += new System.EventHandler(this.tsmCalcularNota_Click);
            // 
            // tsmSimuladorBanco
            // 
            this.tsmSimuladorBanco.Name = "tsmSimuladorBanco";
            this.tsmSimuladorBanco.Size = new System.Drawing.Size(180, 22);
            this.tsmSimuladorBanco.Text = "Ventana 4";
            this.tsmSimuladorBanco.Click += new System.EventHandler(this.tsmSimuladorBanco_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmConvertir;
        private System.Windows.Forms.ToolStripMenuItem tsmIndiceMasaCorporal;
        private System.Windows.Forms.ToolStripMenuItem tsmCalcularNota;
        private System.Windows.Forms.ToolStripMenuItem tsmSimuladorBanco;
    }
}

