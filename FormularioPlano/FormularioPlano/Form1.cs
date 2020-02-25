using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPlano
{
    public partial class Form1 : Form
    {

        bool movimiento = false;
        int movX;
        int movY;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitular_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
            movX = e.X;
            movY = e.Y;
        }

        private void pnlTitular_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimiento) {
                this.SetDesktopLocation((MousePosition.X - movX), (MousePosition.Y - movY));
            }
        }

        private void pnlTitular_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CargarFormulario(new frmUsuarios());
            CambiarColorBoton(this.btnUsuarios);
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            CargarFormulario(new frmReportes());
            CambiarColorBoton(this.btnReportes);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            CargarFormulario(new frmConfig());
            CambiarColorBoton(this.btnConfiguracion);
        }

        private void CambiarColorBoton(Button botonActivo)
        {
            foreach (Control c in this.pnlMenu.Controls)
            {
                if (c.GetType() == typeof(Button)) 
                {
                    c.BackColor = Color.Blue;
                }
            }
            botonActivo.BackColor = Color.White;
        }

        private void CargarFormulario(Form formulario)
        {
            if (this.pnlContent.Controls.Count > 0)
            {
                this.pnlContent.Controls.Clear();
            }

            formulario.TopLevel = false;
            this.pnlContent.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
