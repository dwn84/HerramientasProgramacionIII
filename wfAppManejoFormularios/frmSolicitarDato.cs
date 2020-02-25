using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmSolicitarDato : Form
    {
        private double valorMonetario;

        public double ValorMonetario { get => valorMonetario; }

        public frmSolicitarDato()
        {
            InitializeComponent();
        }

        public frmSolicitarDato(string titular,string mensaje, string textoBoton)
        {
            InitializeComponent();
            this.Text = titular;
            this.lblMensaje.Text = mensaje;
            this.btnAceptar.Text = textoBoton;

        }

        private void frmSolicitarDato_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            valorMonetario = Convert.ToDouble(txtValor.Text);
            this.Close();
        }
    }
}
