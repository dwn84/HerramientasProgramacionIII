namespace WindowsFormsApp2
{
    partial class frmSimuladorBancario
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRetirarAhorros = new System.Windows.Forms.Button();
            this.btnConsignarAhorros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoCuentaAhorros = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulador Bancario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cédula";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(241, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRetirarAhorros);
            this.groupBox2.Controls.Add(this.btnConsignarAhorros);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSaldoCuentaAhorros);
            this.groupBox2.Location = new System.Drawing.Point(15, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta de ahorros";
            // 
            // btnRetirarAhorros
            // 
            this.btnRetirarAhorros.Location = new System.Drawing.Point(266, 29);
            this.btnRetirarAhorros.Name = "btnRetirarAhorros";
            this.btnRetirarAhorros.Size = new System.Drawing.Size(75, 23);
            this.btnRetirarAhorros.TabIndex = 3;
            this.btnRetirarAhorros.Text = "Retirar";
            this.btnRetirarAhorros.UseVisualStyleBackColor = true;
            this.btnRetirarAhorros.Click += new System.EventHandler(this.btnRetirarAhorros_Click);
            // 
            // btnConsignarAhorros
            // 
            this.btnConsignarAhorros.Location = new System.Drawing.Point(176, 30);
            this.btnConsignarAhorros.Name = "btnConsignarAhorros";
            this.btnConsignarAhorros.Size = new System.Drawing.Size(75, 23);
            this.btnConsignarAhorros.TabIndex = 2;
            this.btnConsignarAhorros.Text = "Consignar";
            this.btnConsignarAhorros.UseVisualStyleBackColor = true;
            this.btnConsignarAhorros.Click += new System.EventHandler(this.btnConsignarAhorros_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo";
            // 
            // txtSaldoCuentaAhorros
            // 
            this.txtSaldoCuentaAhorros.Enabled = false;
            this.txtSaldoCuentaAhorros.Location = new System.Drawing.Point(57, 32);
            this.txtSaldoCuentaAhorros.Name = "txtSaldoCuentaAhorros";
            this.txtSaldoCuentaAhorros.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoCuentaAhorros.TabIndex = 0;
            // 
            // frmSimuladorBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmSimuladorBancario";
            this.Text = "Simulador Bancario";
            this.Load += new System.EventHandler(this.frmSimuladorBancario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRetirarAhorros;
        private System.Windows.Forms.Button btnConsignarAhorros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoCuentaAhorros;
    }
}