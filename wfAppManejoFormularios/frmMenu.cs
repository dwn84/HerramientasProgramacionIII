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
            bool isOpen = false;

            foreach (Form f in Application.OpenForms) 
            {

                if (f.Text == "Convertir")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
                
            }

            if (!isOpen)
            {
                var myForm = new frmConvertir();
                myForm.MdiParent = this;
                myForm.Show();


            }


        }

        private void tsmIndiceMasaCorporal_Click(object sender, EventArgs e)
        {
            bool isOpen = false;


            foreach (Form f in Application.OpenForms)
            {
                
                if (f.Text == "Indice de Masa Corporal")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (!isOpen)
            {
                var myForm = new frmIndiceMasaCorporal();
                myForm.MdiParent = this;
                myForm.Show();


            }

        }

        private void tsmCalcularNota_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {

                if (f.Text == "Calcular nota final")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (!isOpen)
            {
                var myForm = new frmCalcularNotaFinal();
                myForm.MdiParent = this;
                myForm.Show();
                
            }
        }

        private void tsmSimuladorBanco_Click(object sender, EventArgs e)
        {
            bool isOpen = false;

            foreach (Form f in Application.OpenForms)
            {

                if (f.Text == "Simulador Bancario")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }

            }

            if (!isOpen)
            {
                var myForm = new frmSimuladorBancario();
                myForm.MdiParent = this;
                myForm.Show();

            }
        }
    }
}
