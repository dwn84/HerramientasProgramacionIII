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
            frmListadoTra formulario = new frmListadoTra();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarTra formulario = new frmAsignarTra();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void tratamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
