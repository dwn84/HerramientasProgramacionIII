using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ejemplo_Capas1
{
    public partial class frmLogin : Form
    {

        GestorTratamiento gt;
        public frmLogin()
        {
            InitializeComponent();
            gt = new GestorTratamiento();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string rolUsuario = gt.ValidarUsuario(txtUsuario.Text, txtPassword.Text);
            if (rolUsuario != "99")
            {
                Form1 menuprincipal = new Form1(rolUsuario);
                menuprincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
}
