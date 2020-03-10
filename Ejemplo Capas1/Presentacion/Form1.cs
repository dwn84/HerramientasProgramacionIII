using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Capas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmListadoTra());
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAsignarTra());
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRangoTratamientos());
        }

        private void AbrirFormulario(Form formulario) 
        {
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPaciente ());
        }
    }
}
