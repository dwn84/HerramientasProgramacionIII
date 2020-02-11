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


    public partial class frmSimuladorBancario : Form
    {

        private double saldoCuentaAhorros;
        private double saldoCuentaCorriente;
        private double saldoCuentaCDT;
        private double valorMovimientoFinanciero;
        public frmSimuladorBancario()
        {
            InitializeComponent();
            saldoCuentaAhorros = 0;
            saldoCuentaCorriente = 0;
            saldoCuentaCDT = 0;
            valorMovimientoFinanciero = 0;
            txtSaldoCuentaAhorros.Text = saldoCuentaAhorros.ToString();
        }



        private void frmSimuladorBancario_Load(object sender, EventArgs e)
        {

        }

        private void btnConsignarAhorros_Click(object sender, EventArgs e)
        {
            mostrarModal("Consignación cuenta de ahorros", "Valor de consignación", "Consignar");
            saldoCuentaAhorros += valorMovimientoFinanciero;
            txtSaldoCuentaAhorros.Text = saldoCuentaAhorros.ToString();
        }

        private void btnRetirarAhorros_Click(object sender, EventArgs e)
        {
            mostrarModal("Retirar dinero en cuenta de ahorros", "Dinero para retirar", "Retirar");
            if (valorMovimientoFinanciero > saldoCuentaAhorros)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            else
            {
                saldoCuentaAhorros -= valorMovimientoFinanciero;
                txtSaldoCuentaAhorros.Text = saldoCuentaAhorros.ToString();
            }
 
        
        }

        private void mostrarModal(string titular, string mensaje, string textoBoton) 
        {
            var ventanaDato = new frmSolicitarDato(titular, mensaje, textoBoton);
            ventanaDato.ShowDialog(this);
            valorMovimientoFinanciero = ventanaDato.ValorMonetario;

        }
    }
}
