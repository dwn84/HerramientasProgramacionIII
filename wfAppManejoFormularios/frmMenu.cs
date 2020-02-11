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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmConvertir_Click(object sender, EventArgs e)
        {
            abrirVentana("Convertir", new frmConvertir());
        }

        private void tsmIndiceMasaCorporal_Click(object sender, EventArgs e)
        {

            abrirVentana("Indice de Masa Corporal", new frmIndiceMasaCorporal());


        }

        private void tsmCalcularNota_Click(object sender, EventArgs e)
        {
            abrirVentana("Calcular nota final", new frmCalcularNotaFinal());
        }

        private void tsmSimuladorBanco_Click(object sender, EventArgs e)
        {
            abrirVentana("Simulador Bancario", new frmSimuladorBancario());

          
        }

        private void abrirVentana(string titular, Form ventana) 
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {

                if (f.Text == titular)
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (!isOpen)
            {
                var myForm = ventana;
                myForm.MdiParent = this;
                myForm.Show();

            }


        }
    }
}
