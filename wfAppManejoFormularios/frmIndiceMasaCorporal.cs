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
    public partial class frmIndiceMasaCorporal : Form
    {
        public frmIndiceMasaCorporal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text == "" && txtPeso.Text == "")
            {
                MessageBox.Show("Faltan datos");
            }
            else
            {
                var altura = double.Parse(txtAltura.Text);
                var peso = Convert.ToDouble(txtPeso.Text);
                var imc = peso / (altura * altura);
                MessageBox.Show(imc.ToString());
                var mensaje = "";

                if (imc < 16)
                {
                    mensaje = "Delgadez Severa";
                }
                else if(imc < 16.99)
                {
                    mensaje = "Delgadez moderada";
                }
                else if (imc < 18.49)
                {
                    mensaje = "Delgadez aceptable";
                }
                MessageBox.Show(mensaje);
            }
            }
 
            }
        }

